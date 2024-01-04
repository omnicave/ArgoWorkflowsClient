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
    /// AzureDisk represents an Azure Data Disk mount on the host and bind mount to the pod.
    /// </summary>
    [DataContract(Name = "io.k8s.api.core.v1.AzureDiskVolumeSource")]
    public partial class IoK8sApiCoreV1AzureDiskVolumeSource : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1AzureDiskVolumeSource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IoK8sApiCoreV1AzureDiskVolumeSource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1AzureDiskVolumeSource" /> class.
        /// </summary>
        /// <param name="cachingMode">Host Caching mode: None, Read Only, Read Write..</param>
        /// <param name="diskName">The Name of the data disk in the blob storage (required).</param>
        /// <param name="diskURI">The URI the data disk in the blob storage (required).</param>
        /// <param name="fsType">Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \&quot;ext4\&quot;, \&quot;xfs\&quot;, \&quot;ntfs\&quot;. Implicitly inferred to be \&quot;ext4\&quot; if unspecified..</param>
        /// <param name="kind">Expected values Shared: multiple blob disks per storage account  Dedicated: single blob disk per storage account  Managed: azure managed data disk (only in managed availability set). defaults to shared.</param>
        /// <param name="varReadOnly">Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts..</param>
        public IoK8sApiCoreV1AzureDiskVolumeSource(string cachingMode = default(string), string diskName = default(string), string diskURI = default(string), string fsType = default(string), string kind = default(string), bool varReadOnly = default(bool))
        {
            // to ensure "diskName" is required (not null)
            if (diskName == null)
            {
                throw new ArgumentNullException("diskName is a required property for IoK8sApiCoreV1AzureDiskVolumeSource and cannot be null");
            }
            this.DiskName = diskName;
            // to ensure "diskURI" is required (not null)
            if (diskURI == null)
            {
                throw new ArgumentNullException("diskURI is a required property for IoK8sApiCoreV1AzureDiskVolumeSource and cannot be null");
            }
            this.DiskURI = diskURI;
            this.CachingMode = cachingMode;
            this.FsType = fsType;
            this.Kind = kind;
            this.VarReadOnly = varReadOnly;
        }

        /// <summary>
        /// Host Caching mode: None, Read Only, Read Write.
        /// </summary>
        /// <value>Host Caching mode: None, Read Only, Read Write.</value>
        [DataMember(Name = "cachingMode", EmitDefaultValue = false)]
        public string CachingMode { get; set; }

        /// <summary>
        /// The Name of the data disk in the blob storage
        /// </summary>
        /// <value>The Name of the data disk in the blob storage</value>
        [DataMember(Name = "diskName", IsRequired = true, EmitDefaultValue = true)]
        public string DiskName { get; set; }

        /// <summary>
        /// The URI the data disk in the blob storage
        /// </summary>
        /// <value>The URI the data disk in the blob storage</value>
        [DataMember(Name = "diskURI", IsRequired = true, EmitDefaultValue = true)]
        public string DiskURI { get; set; }

        /// <summary>
        /// Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \&quot;ext4\&quot;, \&quot;xfs\&quot;, \&quot;ntfs\&quot;. Implicitly inferred to be \&quot;ext4\&quot; if unspecified.
        /// </summary>
        /// <value>Filesystem type to mount. Must be a filesystem type supported by the host operating system. Ex. \&quot;ext4\&quot;, \&quot;xfs\&quot;, \&quot;ntfs\&quot;. Implicitly inferred to be \&quot;ext4\&quot; if unspecified.</value>
        [DataMember(Name = "fsType", EmitDefaultValue = false)]
        public string FsType { get; set; }

        /// <summary>
        /// Expected values Shared: multiple blob disks per storage account  Dedicated: single blob disk per storage account  Managed: azure managed data disk (only in managed availability set). defaults to shared
        /// </summary>
        /// <value>Expected values Shared: multiple blob disks per storage account  Dedicated: single blob disk per storage account  Managed: azure managed data disk (only in managed availability set). defaults to shared</value>
        [DataMember(Name = "kind", EmitDefaultValue = false)]
        public string Kind { get; set; }

        /// <summary>
        /// Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.
        /// </summary>
        /// <value>Defaults to false (read/write). ReadOnly here will force the ReadOnly setting in VolumeMounts.</value>
        [DataMember(Name = "readOnly", EmitDefaultValue = true)]
        public bool VarReadOnly { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1AzureDiskVolumeSource {\n");
            sb.Append("  CachingMode: ").Append(CachingMode).Append("\n");
            sb.Append("  DiskName: ").Append(DiskName).Append("\n");
            sb.Append("  DiskURI: ").Append(DiskURI).Append("\n");
            sb.Append("  FsType: ").Append(FsType).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  VarReadOnly: ").Append(VarReadOnly).Append("\n");
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
