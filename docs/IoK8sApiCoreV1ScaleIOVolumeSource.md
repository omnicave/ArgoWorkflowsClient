# ArgoWorkflowsClient.Model.IoK8sApiCoreV1ScaleIOVolumeSource
ScaleIOVolumeSource represents a persistent ScaleIO volume

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FsType** | **string** | Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \&quot;ext4\&quot;, \&quot;xfs\&quot;, \&quot;ntfs\&quot;. Default is \&quot;xfs\&quot;. | [optional] 
**Gateway** | **string** | The host address of the ScaleIO API Gateway. | 
**ProtectionDomain** | **string** | The name of the ScaleIO Protection Domain for the configured storage. | [optional] 
**VarReadOnly** | **bool** | Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts. | [optional] 
**SecretRef** | [**IoK8sApiCoreV1LocalObjectReference**](IoK8sApiCoreV1LocalObjectReference.md) |  | 
**SslEnabled** | **bool** | Flag to enable/disable SSL communication with Gateway, default false | [optional] 
**StorageMode** | **string** | Indicates whether the storage for a volume should be ThickProvisioned or ThinProvisioned. Default is ThinProvisioned. | [optional] 
**StoragePool** | **string** | The ScaleIO Storage Pool associated with the protection domain. | [optional] 
**VarSystem** | **string** | The name of the storage system as configured in ScaleIO. | 
**VolumeName** | **string** | The name of a volume already created in the ScaleIO system that is associated with this volume source. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

