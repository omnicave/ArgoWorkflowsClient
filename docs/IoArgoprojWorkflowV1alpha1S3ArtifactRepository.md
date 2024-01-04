# ArgoWorkflowsClient.Model.IoArgoprojWorkflowV1alpha1S3ArtifactRepository
S3ArtifactRepository defines the controller configuration for an S3 artifact repository

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessKeySecret** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional] 
**Bucket** | **string** | Bucket is the name of the bucket | [optional] 
**CaSecret** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional] 
**CreateBucketIfNotPresent** | [**IoArgoprojWorkflowV1alpha1CreateS3BucketOptions**](IoArgoprojWorkflowV1alpha1CreateS3BucketOptions.md) |  | [optional] 
**EncryptionOptions** | [**IoArgoprojWorkflowV1alpha1S3EncryptionOptions**](IoArgoprojWorkflowV1alpha1S3EncryptionOptions.md) |  | [optional] 
**Endpoint** | **string** | Endpoint is the hostname of the bucket endpoint | [optional] 
**Insecure** | **bool** | Insecure will connect to the service with TLS | [optional] 
**KeyFormat** | **string** | KeyFormat defines the format of how to store keys and can reference workflow variables. | [optional] 
**KeyPrefix** | **string** | KeyPrefix is prefix used as part of the bucket key in which the controller will store artifacts. DEPRECATED. Use KeyFormat instead | [optional] 
**Region** | **string** | Region contains the optional bucket region | [optional] 
**RoleARN** | **string** | RoleARN is the Amazon Resource Name (ARN) of the role to assume. | [optional] 
**SecretKeySecret** | [**IoK8sApiCoreV1SecretKeySelector**](IoK8sApiCoreV1SecretKeySelector.md) |  | [optional] 
**UseSDKCreds** | **bool** | UseSDKCreds tells the driver to figure out credentials based on sdk defaults. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

