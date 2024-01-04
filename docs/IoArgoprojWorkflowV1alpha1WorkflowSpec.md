# ArgoWorkflowsClient.Model.IoArgoprojWorkflowV1alpha1WorkflowSpec
WorkflowSpec is the specification of a Workflow.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActiveDeadlineSeconds** | **int** | Optional duration in seconds relative to the workflow start time which the workflow is allowed to run before the controller terminates the io.argoproj.workflow.v1alpha1. A value of zero is used to terminate a Running workflow | [optional] 
**Affinity** | [**IoK8sApiCoreV1Affinity**](IoK8sApiCoreV1Affinity.md) |  | [optional] 
**ArchiveLogs** | **bool** | ArchiveLogs indicates if the container logs should be archived | [optional] 
**Arguments** | [**IoArgoprojWorkflowV1alpha1Arguments**](IoArgoprojWorkflowV1alpha1Arguments.md) |  | [optional] 
**ArtifactGC** | [**IoArgoprojWorkflowV1alpha1WorkflowLevelArtifactGC**](IoArgoprojWorkflowV1alpha1WorkflowLevelArtifactGC.md) |  | [optional] 
**ArtifactRepositoryRef** | [**IoArgoprojWorkflowV1alpha1ArtifactRepositoryRef**](IoArgoprojWorkflowV1alpha1ArtifactRepositoryRef.md) |  | [optional] 
**AutomountServiceAccountToken** | **bool** | AutomountServiceAccountToken indicates whether a service account token should be automatically mounted in pods. ServiceAccountName of ExecutorConfig must be specified if this value is false. | [optional] 
**DnsConfig** | [**IoK8sApiCoreV1PodDNSConfig**](IoK8sApiCoreV1PodDNSConfig.md) |  | [optional] 
**DnsPolicy** | **string** | Set DNS policy for the pod. Defaults to \&quot;ClusterFirst\&quot;. Valid values are &#39;ClusterFirstWithHostNet&#39;, &#39;ClusterFirst&#39;, &#39;Default&#39; or &#39;None&#39;. DNS parameters given in DNSConfig will be merged with the policy selected with DNSPolicy. To have DNS options set along with hostNetwork, you have to specify DNS policy explicitly to &#39;ClusterFirstWithHostNet&#39;. | [optional] 
**Entrypoint** | **string** | Entrypoint is a template reference to the starting point of the io.argoproj.workflow.v1alpha1. | [optional] 
**Executor** | [**IoArgoprojWorkflowV1alpha1ExecutorConfig**](IoArgoprojWorkflowV1alpha1ExecutorConfig.md) |  | [optional] 
**Hooks** | [**Dictionary&lt;string, IoArgoprojWorkflowV1alpha1LifecycleHook&gt;**](IoArgoprojWorkflowV1alpha1LifecycleHook.md) | Hooks holds the lifecycle hook which is invoked at lifecycle of step, irrespective of the success, failure, or error status of the primary step | [optional] 
**HostAliases** | [**List&lt;IoK8sApiCoreV1HostAlias&gt;**](IoK8sApiCoreV1HostAlias.md) |  | [optional] 
**HostNetwork** | **bool** | Host networking requested for this workflow pod. Default to false. | [optional] 
**ImagePullSecrets** | [**List&lt;IoK8sApiCoreV1LocalObjectReference&gt;**](IoK8sApiCoreV1LocalObjectReference.md) | ImagePullSecrets is a list of references to secrets in the same namespace to use for pulling any images in pods that reference this ServiceAccount. ImagePullSecrets are distinct from Secrets because Secrets can be mounted in the pod, but ImagePullSecrets are only accessed by the kubelet. More info: https://kubernetes.io/docs/concepts/containers/images/#specifying-imagepullsecrets-on-a-pod | [optional] 
**Metrics** | [**IoArgoprojWorkflowV1alpha1Metrics**](IoArgoprojWorkflowV1alpha1Metrics.md) |  | [optional] 
**NodeSelector** | **Dictionary&lt;string, string&gt;** | NodeSelector is a selector which will result in all pods of the workflow to be scheduled on the selected node(s). This is able to be overridden by a nodeSelector specified in the template. | [optional] 
**OnExit** | **string** | OnExit is a template reference which is invoked at the end of the workflow, irrespective of the success, failure, or error of the primary io.argoproj.workflow.v1alpha1. | [optional] 
**Parallelism** | **int** | Parallelism limits the max total parallel pods that can execute at the same time in a workflow | [optional] 
**PodDisruptionBudget** | [**IoK8sApiPolicyV1PodDisruptionBudgetSpec**](IoK8sApiPolicyV1PodDisruptionBudgetSpec.md) |  | [optional] 
**PodGC** | [**IoArgoprojWorkflowV1alpha1PodGC**](IoArgoprojWorkflowV1alpha1PodGC.md) |  | [optional] 
**PodMetadata** | [**IoArgoprojWorkflowV1alpha1Metadata**](IoArgoprojWorkflowV1alpha1Metadata.md) |  | [optional] 
**PodPriority** | **int** | Priority to apply to workflow pods. DEPRECATED: Use PodPriorityClassName instead. | [optional] 
**PodPriorityClassName** | **string** | PriorityClassName to apply to workflow pods. | [optional] 
**PodSpecPatch** | **string** | PodSpecPatch holds strategic merge patch to apply against the pod spec. Allows parameterization of container fields which are not strings (e.g. resource limits). | [optional] 
**Priority** | **int** | Priority is used if controller is configured to process limited number of workflows in parallel. Workflows with higher priority are processed first. | [optional] 
**RetryStrategy** | [**IoArgoprojWorkflowV1alpha1RetryStrategy**](IoArgoprojWorkflowV1alpha1RetryStrategy.md) |  | [optional] 
**SchedulerName** | **string** | Set scheduler name for all pods. Will be overridden if container/script template&#39;s scheduler name is set. Default scheduler will be used if neither specified. | [optional] 
**SecurityContext** | [**IoK8sApiCoreV1PodSecurityContext**](IoK8sApiCoreV1PodSecurityContext.md) |  | [optional] 
**ServiceAccountName** | **string** | ServiceAccountName is the name of the ServiceAccount to run all pods of the workflow as. | [optional] 
**Shutdown** | **string** | Shutdown will shutdown the workflow according to its ShutdownStrategy | [optional] 
**Suspend** | **bool** | Suspend will suspend the workflow and prevent execution of any future steps in the workflow | [optional] 
**Synchronization** | [**IoArgoprojWorkflowV1alpha1Synchronization**](IoArgoprojWorkflowV1alpha1Synchronization.md) |  | [optional] 
**TemplateDefaults** | [**IoArgoprojWorkflowV1alpha1Template**](IoArgoprojWorkflowV1alpha1Template.md) |  | [optional] 
**Templates** | [**List&lt;IoArgoprojWorkflowV1alpha1Template&gt;**](IoArgoprojWorkflowV1alpha1Template.md) | Templates is a list of workflow templates used in a workflow | [optional] 
**Tolerations** | [**List&lt;IoK8sApiCoreV1Toleration&gt;**](IoK8sApiCoreV1Toleration.md) | Tolerations to apply to workflow pods. | [optional] 
**TtlStrategy** | [**IoArgoprojWorkflowV1alpha1TTLStrategy**](IoArgoprojWorkflowV1alpha1TTLStrategy.md) |  | [optional] 
**VolumeClaimGC** | [**IoArgoprojWorkflowV1alpha1VolumeClaimGC**](IoArgoprojWorkflowV1alpha1VolumeClaimGC.md) |  | [optional] 
**VolumeClaimTemplates** | [**List&lt;IoK8sApiCoreV1PersistentVolumeClaim&gt;**](IoK8sApiCoreV1PersistentVolumeClaim.md) | VolumeClaimTemplates is a list of claims that containers are allowed to reference. The Workflow controller will create the claims at the beginning of the workflow and delete the claims upon completion of the workflow | [optional] 
**Volumes** | [**List&lt;IoK8sApiCoreV1Volume&gt;**](IoK8sApiCoreV1Volume.md) | Volumes is a list of volumes that can be mounted by containers in a io.argoproj.workflow.v1alpha1. | [optional] 
**WorkflowMetadata** | [**IoArgoprojWorkflowV1alpha1WorkflowMetadata**](IoArgoprojWorkflowV1alpha1WorkflowMetadata.md) |  | [optional] 
**WorkflowTemplateRef** | [**IoArgoprojWorkflowV1alpha1WorkflowTemplateRef**](IoArgoprojWorkflowV1alpha1WorkflowTemplateRef.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

