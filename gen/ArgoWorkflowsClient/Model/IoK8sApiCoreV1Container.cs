/*
 * Argo Workflows API
 *
 * Argo Workflows is an open source container-native workflow engine for orchestrating parallel jobs on Kubernetes. For more information, please see https://argoproj.github.io/argo-workflows/
 *
 * The version of the OpenAPI document: VERSION
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = ArgoWorkflowsClient.Client.OpenAPIDateConverter;

namespace ArgoWorkflowsClient.Model
{
    /// <summary>
    /// A single application container that you want to run within a pod.
    /// </summary>
    [DataContract(Name = "io.k8s.api.core.v1.Container")]
    public partial class IoK8sApiCoreV1Container : IValidatableObject
    {
        /// <summary>
        /// Image pull policy. One of Always, Never, IfNotPresent. Defaults to Always if :latest tag is specified, or IfNotPresent otherwise. Cannot be updated. More info: https://kubernetes.io/docs/concepts/containers/images#updating-images  Possible enum values:  - &#x60;\&quot;Always\&quot;&#x60; means that kubelet always attempts to pull the latest image. Container will fail If the pull fails.  - &#x60;\&quot;IfNotPresent\&quot;&#x60; means that kubelet pulls if the image isn&#39;t present on disk. Container will fail if the image isn&#39;t present and the pull fails.  - &#x60;\&quot;Never\&quot;&#x60; means that kubelet never pulls an image, but only uses a local image. Container will fail if the image isn&#39;t present
        /// </summary>
        /// <value>Image pull policy. One of Always, Never, IfNotPresent. Defaults to Always if :latest tag is specified, or IfNotPresent otherwise. Cannot be updated. More info: https://kubernetes.io/docs/concepts/containers/images#updating-images  Possible enum values:  - &#x60;\&quot;Always\&quot;&#x60; means that kubelet always attempts to pull the latest image. Container will fail If the pull fails.  - &#x60;\&quot;IfNotPresent\&quot;&#x60; means that kubelet pulls if the image isn&#39;t present on disk. Container will fail if the image isn&#39;t present and the pull fails.  - &#x60;\&quot;Never\&quot;&#x60; means that kubelet never pulls an image, but only uses a local image. Container will fail if the image isn&#39;t present</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ImagePullPolicyEnum
        {
            /// <summary>
            /// Enum Always for value: Always
            /// </summary>
            [EnumMember(Value = "Always")]
            Always = 1,

            /// <summary>
            /// Enum IfNotPresent for value: IfNotPresent
            /// </summary>
            [EnumMember(Value = "IfNotPresent")]
            IfNotPresent = 2,

            /// <summary>
            /// Enum Never for value: Never
            /// </summary>
            [EnumMember(Value = "Never")]
            Never = 3
        }


        /// <summary>
        /// Image pull policy. One of Always, Never, IfNotPresent. Defaults to Always if :latest tag is specified, or IfNotPresent otherwise. Cannot be updated. More info: https://kubernetes.io/docs/concepts/containers/images#updating-images  Possible enum values:  - &#x60;\&quot;Always\&quot;&#x60; means that kubelet always attempts to pull the latest image. Container will fail If the pull fails.  - &#x60;\&quot;IfNotPresent\&quot;&#x60; means that kubelet pulls if the image isn&#39;t present on disk. Container will fail if the image isn&#39;t present and the pull fails.  - &#x60;\&quot;Never\&quot;&#x60; means that kubelet never pulls an image, but only uses a local image. Container will fail if the image isn&#39;t present
        /// </summary>
        /// <value>Image pull policy. One of Always, Never, IfNotPresent. Defaults to Always if :latest tag is specified, or IfNotPresent otherwise. Cannot be updated. More info: https://kubernetes.io/docs/concepts/containers/images#updating-images  Possible enum values:  - &#x60;\&quot;Always\&quot;&#x60; means that kubelet always attempts to pull the latest image. Container will fail If the pull fails.  - &#x60;\&quot;IfNotPresent\&quot;&#x60; means that kubelet pulls if the image isn&#39;t present on disk. Container will fail if the image isn&#39;t present and the pull fails.  - &#x60;\&quot;Never\&quot;&#x60; means that kubelet never pulls an image, but only uses a local image. Container will fail if the image isn&#39;t present</value>
        [DataMember(Name = "imagePullPolicy", EmitDefaultValue = false)]
        public ImagePullPolicyEnum? ImagePullPolicy { get; set; }
        /// <summary>
        /// Indicate how the termination message should be populated. File will use the contents of terminationMessagePath to populate the container status message on both success and failure. FallbackToLogsOnError will use the last chunk of container log output if the termination message file is empty and the container exited with an error. The log output is limited to 2048 bytes or 80 lines, whichever is smaller. Defaults to File. Cannot be updated.  Possible enum values:  - &#x60;\&quot;FallbackToLogsOnError\&quot;&#x60; will read the most recent contents of the container logs for the container status message when the container exits with an error and the terminationMessagePath has no contents.  - &#x60;\&quot;File\&quot;&#x60; is the default behavior and will set the container status message to the contents of the container&#39;s terminationMessagePath when the container exits.
        /// </summary>
        /// <value>Indicate how the termination message should be populated. File will use the contents of terminationMessagePath to populate the container status message on both success and failure. FallbackToLogsOnError will use the last chunk of container log output if the termination message file is empty and the container exited with an error. The log output is limited to 2048 bytes or 80 lines, whichever is smaller. Defaults to File. Cannot be updated.  Possible enum values:  - &#x60;\&quot;FallbackToLogsOnError\&quot;&#x60; will read the most recent contents of the container logs for the container status message when the container exits with an error and the terminationMessagePath has no contents.  - &#x60;\&quot;File\&quot;&#x60; is the default behavior and will set the container status message to the contents of the container&#39;s terminationMessagePath when the container exits.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TerminationMessagePolicyEnum
        {
            /// <summary>
            /// Enum FallbackToLogsOnError for value: FallbackToLogsOnError
            /// </summary>
            [EnumMember(Value = "FallbackToLogsOnError")]
            FallbackToLogsOnError = 1,

            /// <summary>
            /// Enum File for value: File
            /// </summary>
            [EnumMember(Value = "File")]
            File = 2
        }


        /// <summary>
        /// Indicate how the termination message should be populated. File will use the contents of terminationMessagePath to populate the container status message on both success and failure. FallbackToLogsOnError will use the last chunk of container log output if the termination message file is empty and the container exited with an error. The log output is limited to 2048 bytes or 80 lines, whichever is smaller. Defaults to File. Cannot be updated.  Possible enum values:  - &#x60;\&quot;FallbackToLogsOnError\&quot;&#x60; will read the most recent contents of the container logs for the container status message when the container exits with an error and the terminationMessagePath has no contents.  - &#x60;\&quot;File\&quot;&#x60; is the default behavior and will set the container status message to the contents of the container&#39;s terminationMessagePath when the container exits.
        /// </summary>
        /// <value>Indicate how the termination message should be populated. File will use the contents of terminationMessagePath to populate the container status message on both success and failure. FallbackToLogsOnError will use the last chunk of container log output if the termination message file is empty and the container exited with an error. The log output is limited to 2048 bytes or 80 lines, whichever is smaller. Defaults to File. Cannot be updated.  Possible enum values:  - &#x60;\&quot;FallbackToLogsOnError\&quot;&#x60; will read the most recent contents of the container logs for the container status message when the container exits with an error and the terminationMessagePath has no contents.  - &#x60;\&quot;File\&quot;&#x60; is the default behavior and will set the container status message to the contents of the container&#39;s terminationMessagePath when the container exits.</value>
        [DataMember(Name = "terminationMessagePolicy", EmitDefaultValue = false)]
        public TerminationMessagePolicyEnum? TerminationMessagePolicy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1Container" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IoK8sApiCoreV1Container() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1Container" /> class.
        /// </summary>
        /// <param name="args">Arguments to the entrypoint. The docker image&#39;s CMD is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container&#39;s environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. \&quot;$$(VAR_NAME)\&quot; will produce the string literal \&quot;$(VAR_NAME)\&quot;. Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell.</param>
        /// <param name="command">Entrypoint array. Not executed within a shell. The docker image&#39;s ENTRYPOINT is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container&#39;s environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. \&quot;$$(VAR_NAME)\&quot; will produce the string literal \&quot;$(VAR_NAME)\&quot;. Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell.</param>
        /// <param name="env">List of environment variables to set in the container. Cannot be updated..</param>
        /// <param name="envFrom">List of sources to populate environment variables in the container. The keys defined within a source must be a C_IDENTIFIER. All invalid keys will be reported as an event when the container is starting. When a key exists in multiple sources, the value associated with the last source will take precedence. Values defined by an Env with a duplicate key will take precedence. Cannot be updated..</param>
        /// <param name="image">Docker image name. More info: https://kubernetes.io/docs/concepts/containers/images This field is optional to allow higher level config management to default or override container images in workload controllers like Deployments and StatefulSets. (required).</param>
        /// <param name="imagePullPolicy">Image pull policy. One of Always, Never, IfNotPresent. Defaults to Always if :latest tag is specified, or IfNotPresent otherwise. Cannot be updated. More info: https://kubernetes.io/docs/concepts/containers/images#updating-images  Possible enum values:  - &#x60;\&quot;Always\&quot;&#x60; means that kubelet always attempts to pull the latest image. Container will fail If the pull fails.  - &#x60;\&quot;IfNotPresent\&quot;&#x60; means that kubelet pulls if the image isn&#39;t present on disk. Container will fail if the image isn&#39;t present and the pull fails.  - &#x60;\&quot;Never\&quot;&#x60; means that kubelet never pulls an image, but only uses a local image. Container will fail if the image isn&#39;t present.</param>
        /// <param name="lifecycle">lifecycle.</param>
        /// <param name="livenessProbe">livenessProbe.</param>
        /// <param name="name">Name of the container specified as a DNS_LABEL. Each container in a pod must have a unique name (DNS_LABEL). Cannot be updated..</param>
        /// <param name="ports">List of ports to expose from the container. Exposing a port here gives the system additional information about the network connections a container uses, but is primarily informational. Not specifying a port here DOES NOT prevent that port from being exposed. Any port which is listening on the default \&quot;0.0.0.0\&quot; address inside a container will be accessible from the network. Cannot be updated..</param>
        /// <param name="readinessProbe">readinessProbe.</param>
        /// <param name="resources">resources.</param>
        /// <param name="securityContext">securityContext.</param>
        /// <param name="startupProbe">startupProbe.</param>
        /// <param name="stdin">Whether this container should allocate a buffer for stdin in the container runtime. If this is not set, reads from stdin in the container will always result in EOF. Default is false..</param>
        /// <param name="stdinOnce">Whether the container runtime should close the stdin channel after it has been opened by a single attach. When stdin is true the stdin stream will remain open across multiple attach sessions. If stdinOnce is set to true, stdin is opened on container start, is empty until the first client attaches to stdin, and then remains open and accepts data until the client disconnects, at which time stdin is closed and remains closed until the container is restarted. If this flag is false, a container processes that reads from stdin will never receive an EOF. Default is false.</param>
        /// <param name="terminationMessagePath">Optional: Path at which the file to which the container&#39;s termination message will be written is mounted into the container&#39;s filesystem. Message written is intended to be brief final status, such as an assertion failure message. Will be truncated by the node if greater than 4096 bytes. The total message length across all containers will be limited to 12kb. Defaults to /dev/termination-log. Cannot be updated..</param>
        /// <param name="terminationMessagePolicy">Indicate how the termination message should be populated. File will use the contents of terminationMessagePath to populate the container status message on both success and failure. FallbackToLogsOnError will use the last chunk of container log output if the termination message file is empty and the container exited with an error. The log output is limited to 2048 bytes or 80 lines, whichever is smaller. Defaults to File. Cannot be updated.  Possible enum values:  - &#x60;\&quot;FallbackToLogsOnError\&quot;&#x60; will read the most recent contents of the container logs for the container status message when the container exits with an error and the terminationMessagePath has no contents.  - &#x60;\&quot;File\&quot;&#x60; is the default behavior and will set the container status message to the contents of the container&#39;s terminationMessagePath when the container exits..</param>
        /// <param name="tty">Whether this container should allocate a TTY for itself, also requires &#39;stdin&#39; to be true. Default is false..</param>
        /// <param name="volumeDevices">volumeDevices is the list of block devices to be used by the container..</param>
        /// <param name="volumeMounts">Pod volumes to mount into the container&#39;s filesystem. Cannot be updated..</param>
        /// <param name="workingDir">Container&#39;s working directory. If not specified, the container runtime&#39;s default will be used, which might be configured in the container image. Cannot be updated..</param>
        public IoK8sApiCoreV1Container(List<string> args = default(List<string>), List<string> command = default(List<string>), List<IoK8sApiCoreV1EnvVar> env = default(List<IoK8sApiCoreV1EnvVar>), List<IoK8sApiCoreV1EnvFromSource> envFrom = default(List<IoK8sApiCoreV1EnvFromSource>), string image = default(string), ImagePullPolicyEnum? imagePullPolicy = default(ImagePullPolicyEnum?), IoK8sApiCoreV1Lifecycle lifecycle = default(IoK8sApiCoreV1Lifecycle), IoK8sApiCoreV1Probe livenessProbe = default(IoK8sApiCoreV1Probe), string name = default(string), List<IoK8sApiCoreV1ContainerPort> ports = default(List<IoK8sApiCoreV1ContainerPort>), IoK8sApiCoreV1Probe readinessProbe = default(IoK8sApiCoreV1Probe), IoK8sApiCoreV1ResourceRequirements resources = default(IoK8sApiCoreV1ResourceRequirements), IoK8sApiCoreV1SecurityContext securityContext = default(IoK8sApiCoreV1SecurityContext), IoK8sApiCoreV1Probe startupProbe = default(IoK8sApiCoreV1Probe), bool stdin = default(bool), bool stdinOnce = default(bool), string terminationMessagePath = default(string), TerminationMessagePolicyEnum? terminationMessagePolicy = default(TerminationMessagePolicyEnum?), bool tty = default(bool), List<IoK8sApiCoreV1VolumeDevice> volumeDevices = default(List<IoK8sApiCoreV1VolumeDevice>), List<IoK8sApiCoreV1VolumeMount> volumeMounts = default(List<IoK8sApiCoreV1VolumeMount>), string workingDir = default(string))
        {
            // to ensure "image" is required (not null)
            if (image == null)
            {
                throw new ArgumentNullException("image is a required property for IoK8sApiCoreV1Container and cannot be null");
            }
            this.Image = image;
            this.Args = args;
            this.Command = command;
            this.Env = env;
            this.EnvFrom = envFrom;
            this.ImagePullPolicy = imagePullPolicy;
            this.Lifecycle = lifecycle;
            this.LivenessProbe = livenessProbe;
            this.Name = name;
            this.Ports = ports;
            this.ReadinessProbe = readinessProbe;
            this.Resources = resources;
            this.SecurityContext = securityContext;
            this.StartupProbe = startupProbe;
            this.Stdin = stdin;
            this.StdinOnce = stdinOnce;
            this.TerminationMessagePath = terminationMessagePath;
            this.TerminationMessagePolicy = terminationMessagePolicy;
            this.Tty = tty;
            this.VolumeDevices = volumeDevices;
            this.VolumeMounts = volumeMounts;
            this.WorkingDir = workingDir;
        }

        /// <summary>
        /// Arguments to the entrypoint. The docker image&#39;s CMD is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container&#39;s environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. \&quot;$$(VAR_NAME)\&quot; will produce the string literal \&quot;$(VAR_NAME)\&quot;. Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell
        /// </summary>
        /// <value>Arguments to the entrypoint. The docker image&#39;s CMD is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container&#39;s environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. \&quot;$$(VAR_NAME)\&quot; will produce the string literal \&quot;$(VAR_NAME)\&quot;. Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell</value>
        [DataMember(Name = "args", EmitDefaultValue = false)]
        public List<string> Args { get; set; }

        /// <summary>
        /// Entrypoint array. Not executed within a shell. The docker image&#39;s ENTRYPOINT is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container&#39;s environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. \&quot;$$(VAR_NAME)\&quot; will produce the string literal \&quot;$(VAR_NAME)\&quot;. Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell
        /// </summary>
        /// <value>Entrypoint array. Not executed within a shell. The docker image&#39;s ENTRYPOINT is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container&#39;s environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. \&quot;$$(VAR_NAME)\&quot; will produce the string literal \&quot;$(VAR_NAME)\&quot;. Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell</value>
        [DataMember(Name = "command", EmitDefaultValue = false)]
        public List<string> Command { get; set; }

        /// <summary>
        /// List of environment variables to set in the container. Cannot be updated.
        /// </summary>
        /// <value>List of environment variables to set in the container. Cannot be updated.</value>
        [DataMember(Name = "env", EmitDefaultValue = false)]
        public List<IoK8sApiCoreV1EnvVar> Env { get; set; }

        /// <summary>
        /// List of sources to populate environment variables in the container. The keys defined within a source must be a C_IDENTIFIER. All invalid keys will be reported as an event when the container is starting. When a key exists in multiple sources, the value associated with the last source will take precedence. Values defined by an Env with a duplicate key will take precedence. Cannot be updated.
        /// </summary>
        /// <value>List of sources to populate environment variables in the container. The keys defined within a source must be a C_IDENTIFIER. All invalid keys will be reported as an event when the container is starting. When a key exists in multiple sources, the value associated with the last source will take precedence. Values defined by an Env with a duplicate key will take precedence. Cannot be updated.</value>
        [DataMember(Name = "envFrom", EmitDefaultValue = false)]
        public List<IoK8sApiCoreV1EnvFromSource> EnvFrom { get; set; }

        /// <summary>
        /// Docker image name. More info: https://kubernetes.io/docs/concepts/containers/images This field is optional to allow higher level config management to default or override container images in workload controllers like Deployments and StatefulSets.
        /// </summary>
        /// <value>Docker image name. More info: https://kubernetes.io/docs/concepts/containers/images This field is optional to allow higher level config management to default or override container images in workload controllers like Deployments and StatefulSets.</value>
        [DataMember(Name = "image", IsRequired = true, EmitDefaultValue = true)]
        public string Image { get; set; }

        /// <summary>
        /// Gets or Sets Lifecycle
        /// </summary>
        [DataMember(Name = "lifecycle", EmitDefaultValue = false)]
        public IoK8sApiCoreV1Lifecycle Lifecycle { get; set; }

        /// <summary>
        /// Gets or Sets LivenessProbe
        /// </summary>
        [DataMember(Name = "livenessProbe", EmitDefaultValue = false)]
        public IoK8sApiCoreV1Probe LivenessProbe { get; set; }

        /// <summary>
        /// Name of the container specified as a DNS_LABEL. Each container in a pod must have a unique name (DNS_LABEL). Cannot be updated.
        /// </summary>
        /// <value>Name of the container specified as a DNS_LABEL. Each container in a pod must have a unique name (DNS_LABEL). Cannot be updated.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// List of ports to expose from the container. Exposing a port here gives the system additional information about the network connections a container uses, but is primarily informational. Not specifying a port here DOES NOT prevent that port from being exposed. Any port which is listening on the default \&quot;0.0.0.0\&quot; address inside a container will be accessible from the network. Cannot be updated.
        /// </summary>
        /// <value>List of ports to expose from the container. Exposing a port here gives the system additional information about the network connections a container uses, but is primarily informational. Not specifying a port here DOES NOT prevent that port from being exposed. Any port which is listening on the default \&quot;0.0.0.0\&quot; address inside a container will be accessible from the network. Cannot be updated.</value>
        [DataMember(Name = "ports", EmitDefaultValue = false)]
        public List<IoK8sApiCoreV1ContainerPort> Ports { get; set; }

        /// <summary>
        /// Gets or Sets ReadinessProbe
        /// </summary>
        [DataMember(Name = "readinessProbe", EmitDefaultValue = false)]
        public IoK8sApiCoreV1Probe ReadinessProbe { get; set; }

        /// <summary>
        /// Gets or Sets Resources
        /// </summary>
        [DataMember(Name = "resources", EmitDefaultValue = false)]
        public IoK8sApiCoreV1ResourceRequirements Resources { get; set; }

        /// <summary>
        /// Gets or Sets SecurityContext
        /// </summary>
        [DataMember(Name = "securityContext", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecurityContext SecurityContext { get; set; }

        /// <summary>
        /// Gets or Sets StartupProbe
        /// </summary>
        [DataMember(Name = "startupProbe", EmitDefaultValue = false)]
        public IoK8sApiCoreV1Probe StartupProbe { get; set; }

        /// <summary>
        /// Whether this container should allocate a buffer for stdin in the container runtime. If this is not set, reads from stdin in the container will always result in EOF. Default is false.
        /// </summary>
        /// <value>Whether this container should allocate a buffer for stdin in the container runtime. If this is not set, reads from stdin in the container will always result in EOF. Default is false.</value>
        [DataMember(Name = "stdin", EmitDefaultValue = true)]
        public bool Stdin { get; set; }

        /// <summary>
        /// Whether the container runtime should close the stdin channel after it has been opened by a single attach. When stdin is true the stdin stream will remain open across multiple attach sessions. If stdinOnce is set to true, stdin is opened on container start, is empty until the first client attaches to stdin, and then remains open and accepts data until the client disconnects, at which time stdin is closed and remains closed until the container is restarted. If this flag is false, a container processes that reads from stdin will never receive an EOF. Default is false
        /// </summary>
        /// <value>Whether the container runtime should close the stdin channel after it has been opened by a single attach. When stdin is true the stdin stream will remain open across multiple attach sessions. If stdinOnce is set to true, stdin is opened on container start, is empty until the first client attaches to stdin, and then remains open and accepts data until the client disconnects, at which time stdin is closed and remains closed until the container is restarted. If this flag is false, a container processes that reads from stdin will never receive an EOF. Default is false</value>
        [DataMember(Name = "stdinOnce", EmitDefaultValue = true)]
        public bool StdinOnce { get; set; }

        /// <summary>
        /// Optional: Path at which the file to which the container&#39;s termination message will be written is mounted into the container&#39;s filesystem. Message written is intended to be brief final status, such as an assertion failure message. Will be truncated by the node if greater than 4096 bytes. The total message length across all containers will be limited to 12kb. Defaults to /dev/termination-log. Cannot be updated.
        /// </summary>
        /// <value>Optional: Path at which the file to which the container&#39;s termination message will be written is mounted into the container&#39;s filesystem. Message written is intended to be brief final status, such as an assertion failure message. Will be truncated by the node if greater than 4096 bytes. The total message length across all containers will be limited to 12kb. Defaults to /dev/termination-log. Cannot be updated.</value>
        [DataMember(Name = "terminationMessagePath", EmitDefaultValue = false)]
        public string TerminationMessagePath { get; set; }

        /// <summary>
        /// Whether this container should allocate a TTY for itself, also requires &#39;stdin&#39; to be true. Default is false.
        /// </summary>
        /// <value>Whether this container should allocate a TTY for itself, also requires &#39;stdin&#39; to be true. Default is false.</value>
        [DataMember(Name = "tty", EmitDefaultValue = true)]
        public bool Tty { get; set; }

        /// <summary>
        /// volumeDevices is the list of block devices to be used by the container.
        /// </summary>
        /// <value>volumeDevices is the list of block devices to be used by the container.</value>
        [DataMember(Name = "volumeDevices", EmitDefaultValue = false)]
        public List<IoK8sApiCoreV1VolumeDevice> VolumeDevices { get; set; }

        /// <summary>
        /// Pod volumes to mount into the container&#39;s filesystem. Cannot be updated.
        /// </summary>
        /// <value>Pod volumes to mount into the container&#39;s filesystem. Cannot be updated.</value>
        [DataMember(Name = "volumeMounts", EmitDefaultValue = false)]
        public List<IoK8sApiCoreV1VolumeMount> VolumeMounts { get; set; }

        /// <summary>
        /// Container&#39;s working directory. If not specified, the container runtime&#39;s default will be used, which might be configured in the container image. Cannot be updated.
        /// </summary>
        /// <value>Container&#39;s working directory. If not specified, the container runtime&#39;s default will be used, which might be configured in the container image. Cannot be updated.</value>
        [DataMember(Name = "workingDir", EmitDefaultValue = false)]
        public string WorkingDir { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1Container {\n");
            sb.Append("  Args: ").Append(Args).Append("\n");
            sb.Append("  Command: ").Append(Command).Append("\n");
            sb.Append("  Env: ").Append(Env).Append("\n");
            sb.Append("  EnvFrom: ").Append(EnvFrom).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  ImagePullPolicy: ").Append(ImagePullPolicy).Append("\n");
            sb.Append("  Lifecycle: ").Append(Lifecycle).Append("\n");
            sb.Append("  LivenessProbe: ").Append(LivenessProbe).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Ports: ").Append(Ports).Append("\n");
            sb.Append("  ReadinessProbe: ").Append(ReadinessProbe).Append("\n");
            sb.Append("  Resources: ").Append(Resources).Append("\n");
            sb.Append("  SecurityContext: ").Append(SecurityContext).Append("\n");
            sb.Append("  StartupProbe: ").Append(StartupProbe).Append("\n");
            sb.Append("  Stdin: ").Append(Stdin).Append("\n");
            sb.Append("  StdinOnce: ").Append(StdinOnce).Append("\n");
            sb.Append("  TerminationMessagePath: ").Append(TerminationMessagePath).Append("\n");
            sb.Append("  TerminationMessagePolicy: ").Append(TerminationMessagePolicy).Append("\n");
            sb.Append("  Tty: ").Append(Tty).Append("\n");
            sb.Append("  VolumeDevices: ").Append(VolumeDevices).Append("\n");
            sb.Append("  VolumeMounts: ").Append(VolumeMounts).Append("\n");
            sb.Append("  WorkingDir: ").Append(WorkingDir).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}