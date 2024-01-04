# ArgoWorkflowsClient.Model.IoK8sApiCoreV1AzureFileVolumeSource
AzureFile represents an Azure File Service mount on the host and bind mount to the pod.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarReadOnly** | **bool** | Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts. | [optional] 
**SecretName** | **string** | the name of secret that contains Azure Storage Account Name and Key | 
**ShareName** | **string** | Share Name | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

