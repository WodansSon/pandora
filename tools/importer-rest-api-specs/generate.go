package main

import (
	"fmt"
	"log"
	"os"
	"strings"

	"github.com/hashicorp/pandora/tools/importer-rest-api-specs/components/dataapigenerator"
	"github.com/hashicorp/pandora/tools/importer-rest-api-specs/parser"
)

func generateServiceDefinitions(input parser.ParsedData, workingDirectory, rootNamespace string, resourceProvider, terraformPackageName *string, debug bool) error {
	os.MkdirAll(workingDirectory, permissions)

	if debug {
		log.Printf("[DEBUG] Processing Service %q..", input.ServiceName)
	}
	data := dataapigenerator.GenerationDataForService(input.ServiceName, workingDirectory, rootNamespace, resourceProvider, terraformPackageName)
	os.MkdirAll(data.WorkingDirectoryForService, permissions)

	// clean up any files or directories which aren't on the exclude list
	excludeList := []string{
		// TODO: presumably we can remove this once https://github.com/hashicorp/pandora/issues/403
		// is resolved
		"ServiceDefinition-GenerationSetting.cs",
	}
	files, err := findFilesInDirectory(data.WorkingDirectoryForService, excludeList, debug)
	if err != nil {
		return fmt.Errorf("finding files in directory %q: %+v", data.WorkingDirectoryForService, err)
	}

	for _, name := range *files {
		if debug {
			log.Printf("[DEBUG] Removing Path %q..", name)
		}
		os.RemoveAll(name)
	}

	// finally let's output the new Service Definition
	generator := dataapigenerator.NewPackageDefinitionGenerator(data, debug)
	if err := generator.GenerateServiceDefinition(input); err != nil {
		return fmt.Errorf("generating Service Definition for Namespace %q: %+v", data.NamespaceForService, err)
	}

	return nil
}

func findFilesInDirectory(directory string, excludeList []string, debug bool) (*[]string, error) {
	dir, err := os.Open(directory)
	if err != nil {
		if os.IsNotExist(err) {
			if debug {
				log.Printf("[DEBUG] Creating Directory %q..", directory)
			}

		} else {
			return nil, fmt.Errorf("opening directory %q: %+v", directory, err)
		}
	}
	defer dir.Close()

	files := make([]string, 0)
	f, err := dir.ReadDir(0)
	if err != nil {
		return nil, fmt.Errorf("finding files in %q: %+v", directory, err)
	}
	for i := range f {
		file := f[i]
		fileName := file.Name()

		skip := false
		for _, e := range excludeList {
			if strings.EqualFold(e, fileName) {
				skip = true
				break
			}
		}
		if skip {
			continue
		}
		files = append(files, fileName)
	}

	return &files, nil
}
