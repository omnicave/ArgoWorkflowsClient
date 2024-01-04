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
    /// Represents a StorageOS persistent volume resource.
    /// </summary>
    [DataContract(Name = "io.k8s.api.core.v1.StorageOSVolumeSource")]
    public partial class IoK8sApiCoreV1StorageOSVolumeSource : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1StorageOSVolumeSource" /> class.
        /// </summary>
        /// <param name="fsType">Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \&quot;ext4\&quot;, \&quot;xfs\&quot;, \&quot;ntfs\&quot;. Implicitly inferred to be \&quot;ext4\&quot; if unspecified..</param>
        /// <param name="varReadOnly">Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts..</param>
        /// <param name="secretRef">secretRef.</param>
        /// <param name="volumeName">VolumeName is the human-readable name of the StorageOS volume.  Volume names are only unique within a namespace..</param>
        /// <param name="volumeNamespace">VolumeNamespace specifies the scope of the volume within StorageOS.  If no namespace is specified then the Pod&#39;s namespace will be used.  This allows the Kubernetes name scoping to be mirrored within StorageOS for tighter integration. Set VolumeName to any name to override the default behaviour. Set to \&quot;default\&quot; if you are not using namespaces within StorageOS. Namespaces that do not pre-exist within StorageOS will be created..</param>
        public IoK8sApiCoreV1StorageOSVolumeSource(string fsType = default(string), bool varReadOnly = default(bool), IoK8sApiCoreV1LocalObjectReference secretRef = default(IoK8sApiCoreV1LocalObjectReference), string volumeName = default(string), string volumeNamespace = default(string))
        {
            this.FsType = fsType;
            this.VarReadOnly = varReadOnly;
            this.SecretRef = secretRef;
            this.VolumeName = volumeName;
            this.VolumeNamespace = volumeNamespace;
        }

        /// <summary>
        /// Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \&quot;ext4\&quot;, \&quot;xfs\&quot;, \&quot;ntfs\&quot;. Implicitly inferred to be \&quot;ext4\&quot; if unspecified.
        /// </summary>
        /// <value>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \&quot;ext4\&quot;, \&quot;xfs\&quot;, \&quot;ntfs\&quot;. Implicitly inferred to be \&quot;ext4\&quot; if unspecified.</value>
        [DataMember(Name = "fsType", EmitDefaultValue = false)]
        public string FsType { get; set; }

        /// <summary>
        /// Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
        /// </summary>
        /// <value>Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</value>
        [DataMember(Name = "readOnly", EmitDefaultValue = true)]
        public bool VarReadOnly { get; set; }

        /// <summary>
        /// Gets or Sets SecretRef
        /// </summary>
        [DataMember(Name = "secretRef", EmitDefaultValue = false)]
        public IoK8sApiCoreV1LocalObjectReference SecretRef { get; set; }

        /// <summary>
        /// VolumeName is the human-readable name of the StorageOS volume.  Volume names are only unique within a namespace.
        /// </summary>
        /// <value>VolumeName is the human-readable name of the StorageOS volume.  Volume names are only unique within a namespace.</value>
        [DataMember(Name = "volumeName", EmitDefaultValue = false)]
        public string VolumeName { get; set; }

        /// <summary>
        /// VolumeNamespace specifies the scope of the volume within StorageOS.  If no namespace is specified then the Pod&#39;s namespace will be used.  This allows the Kubernetes name scoping to be mirrored within StorageOS for tighter integration. Set VolumeName to any name to override the default behaviour. Set to \&quot;default\&quot; if you are not using namespaces within StorageOS. Namespaces that do not pre-exist within StorageOS will be created.
        /// </summary>
        /// <value>VolumeNamespace specifies the scope of the volume within StorageOS.  If no namespace is specified then the Pod&#39;s namespace will be used.  This allows the Kubernetes name scoping to be mirrored within StorageOS for tighter integration. Set VolumeName to any name to override the default behaviour. Set to \&quot;default\&quot; if you are not using namespaces within StorageOS. Namespaces that do not pre-exist within StorageOS will be created.</value>
        [DataMember(Name = "volumeNamespace", EmitDefaultValue = false)]
        public string VolumeNamespace { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1StorageOSVolumeSource {\n");
            sb.Append("  FsType: ").Append(FsType).Append("\n");
            sb.Append("  VarReadOnly: ").Append(VarReadOnly).Append("\n");
            sb.Append("  SecretRef: ").Append(SecretRef).Append("\n");
            sb.Append("  VolumeName: ").Append(VolumeName).Append("\n");
            sb.Append("  VolumeNamespace: ").Append(VolumeNamespace).Append("\n");
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
