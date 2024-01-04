# ArgoWorkflowsClient.Model.IoK8sApiCoreV1CSIVolumeSource
Represents a source location of a volume to mount, managed by an external CSI driver

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Driver** | **string** | Driver is the name of the CSI driver that handles this volume. Consult with your admin for the correct name as registered in the cluster. | 
**FsType** | **string** | Filesystem type to mount. Ex. \&quot;ext4\&quot;, \&quot;xfs\&quot;, \&quot;ntfs\&quot;. If not provided, the empty value is passed to the associated CSI driver which will determine the default filesystem to apply. | [optional] 
**NodePublishSecretRef** | [**IoK8sApiCoreV1LocalObjectReference**](IoK8sApiCoreV1LocalObjectReference.md) |  | [optional] 
**VarReadOnly** | **bool** | Specifies a read-only configuration for the volume. Defaults to false (read/write). | [optional] 
**VolumeAttributes** | **Dictionary&lt;string, string&gt;** | VolumeAttributes stores driver-specific properties that are passed to the CSI driver. Consult your driver&#39;s documentation for supported values. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

