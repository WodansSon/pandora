package dataapigenerator

import (
	"fmt"
	"log"
	"path"
	"strings"

	"github.com/hashicorp/pandora/tools/importer-rest-api-specs/models"
)

func (g PandoraDefinitionGenerator) GenerateVersionDefinition(resources map[string]models.AzureApiResource, workingDirectory string) error {
	if g.debugLog {
		log.Printf("[DEBUG] Checking for an existing Generation Settings file..")
	}
	generationSettingFilePath := path.Join(workingDirectory, "ApiVersionDefinition-GenerationSetting.cs")
	settingsFile, err := readFromFile(generationSettingFilePath)
	if err != nil {
		return fmt.Errorf("reading the existing Generation Settings for %q: %+v", generationSettingFilePath, err)
	}
	if settingsFile != nil {
		if g.debugLog {
			log.Printf("[DEBUG] Using existing Generation Settings file at path %q..", generationSettingFilePath)
		}
	} else {
		code := codeForApiVersionDefinitionSetting(g.data.NamespaceForApiVersion)
		b := []byte(code)
		settingsFile = &b
	}

	// recreate the directory
	if err := recreateDirectory(g.data.WorkingDirectoryForApiVersion, g.debugLog); err != nil {
		return fmt.Errorf("recreating directory %q: %+v", g.data.WorkingDirectoryForApiVersion, err)
	}

	// then generate the files
	if g.debugLog {
		log.Printf("[DEBUG] Generating Api Version Definition..")
	}
	isPreview := strings.Contains(strings.ToLower(g.data.ApiVersion), "preview")
	code := codeForApiVersionDefinition(g.data.NamespaceForApiVersion, g.data.ApiVersion, isPreview, resources)
	definitionFilePath := path.Join(workingDirectory, "ApiVersionDefinition.cs")
	if err := writeToFile(definitionFilePath, code); err != nil {
		return fmt.Errorf("writing Api Version Definition to %q: %+v", definitionFilePath, err)
	}

	if g.debugLog {
		log.Printf("[DEBUG] Generating Api Version Definition Generation Setting..")
	}
	if err := writeToFile(generationSettingFilePath, string(*settingsFile)); err != nil {
		return fmt.Errorf("writing Api Version Definition Generation Setting to %q: %+v", definitionFilePath, err)
	}

	return nil
}
