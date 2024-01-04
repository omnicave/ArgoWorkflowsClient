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
    /// HDFSArtifact is the location of an HDFS artifact
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.HDFSArtifact")]
    public partial class IoArgoprojWorkflowV1alpha1HDFSArtifact : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1HDFSArtifact" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IoArgoprojWorkflowV1alpha1HDFSArtifact() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1HDFSArtifact" /> class.
        /// </summary>
        /// <param name="addresses">Addresses is accessible addresses of HDFS name nodes.</param>
        /// <param name="force">Force copies a file forcibly even if it exists.</param>
        /// <param name="hdfsUser">HDFSUser is the user to access HDFS file system. It is ignored if either ccache or keytab is used..</param>
        /// <param name="krbCCacheSecret">krbCCacheSecret.</param>
        /// <param name="krbConfigConfigMap">krbConfigConfigMap.</param>
        /// <param name="krbKeytabSecret">krbKeytabSecret.</param>
        /// <param name="krbRealm">KrbRealm is the Kerberos realm used with Kerberos keytab It must be set if keytab is used..</param>
        /// <param name="krbServicePrincipalName">KrbServicePrincipalName is the principal name of Kerberos service It must be set if either ccache or keytab is used..</param>
        /// <param name="krbUsername">KrbUsername is the Kerberos username used with Kerberos keytab It must be set if keytab is used..</param>
        /// <param name="path">Path is a file path in HDFS (required).</param>
        public IoArgoprojWorkflowV1alpha1HDFSArtifact(List<string> addresses = default(List<string>), bool force = default(bool), string hdfsUser = default(string), IoK8sApiCoreV1SecretKeySelector krbCCacheSecret = default(IoK8sApiCoreV1SecretKeySelector), IoK8sApiCoreV1ConfigMapKeySelector krbConfigConfigMap = default(IoK8sApiCoreV1ConfigMapKeySelector), IoK8sApiCoreV1SecretKeySelector krbKeytabSecret = default(IoK8sApiCoreV1SecretKeySelector), string krbRealm = default(string), string krbServicePrincipalName = default(string), string krbUsername = default(string), string path = default(string))
        {
            // to ensure "path" is required (not null)
            if (path == null)
            {
                throw new ArgumentNullException("path is a required property for IoArgoprojWorkflowV1alpha1HDFSArtifact and cannot be null");
            }
            this.Path = path;
            this.Addresses = addresses;
            this.Force = force;
            this.HdfsUser = hdfsUser;
            this.KrbCCacheSecret = krbCCacheSecret;
            this.KrbConfigConfigMap = krbConfigConfigMap;
            this.KrbKeytabSecret = krbKeytabSecret;
            this.KrbRealm = krbRealm;
            this.KrbServicePrincipalName = krbServicePrincipalName;
            this.KrbUsername = krbUsername;
        }

        /// <summary>
        /// Addresses is accessible addresses of HDFS name nodes
        /// </summary>
        /// <value>Addresses is accessible addresses of HDFS name nodes</value>
        [DataMember(Name = "addresses", EmitDefaultValue = false)]
        public List<string> Addresses { get; set; }

        /// <summary>
        /// Force copies a file forcibly even if it exists
        /// </summary>
        /// <value>Force copies a file forcibly even if it exists</value>
        [DataMember(Name = "force", EmitDefaultValue = true)]
        public bool Force { get; set; }

        /// <summary>
        /// HDFSUser is the user to access HDFS file system. It is ignored if either ccache or keytab is used.
        /// </summary>
        /// <value>HDFSUser is the user to access HDFS file system. It is ignored if either ccache or keytab is used.</value>
        [DataMember(Name = "hdfsUser", EmitDefaultValue = false)]
        public string HdfsUser { get; set; }

        /// <summary>
        /// Gets or Sets KrbCCacheSecret
        /// </summary>
        [DataMember(Name = "krbCCacheSecret", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector KrbCCacheSecret { get; set; }

        /// <summary>
        /// Gets or Sets KrbConfigConfigMap
        /// </summary>
        [DataMember(Name = "krbConfigConfigMap", EmitDefaultValue = false)]
        public IoK8sApiCoreV1ConfigMapKeySelector KrbConfigConfigMap { get; set; }

        /// <summary>
        /// Gets or Sets KrbKeytabSecret
        /// </summary>
        [DataMember(Name = "krbKeytabSecret", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector KrbKeytabSecret { get; set; }

        /// <summary>
        /// KrbRealm is the Kerberos realm used with Kerberos keytab It must be set if keytab is used.
        /// </summary>
        /// <value>KrbRealm is the Kerberos realm used with Kerberos keytab It must be set if keytab is used.</value>
        [DataMember(Name = "krbRealm", EmitDefaultValue = false)]
        public string KrbRealm { get; set; }

        /// <summary>
        /// KrbServicePrincipalName is the principal name of Kerberos service It must be set if either ccache or keytab is used.
        /// </summary>
        /// <value>KrbServicePrincipalName is the principal name of Kerberos service It must be set if either ccache or keytab is used.</value>
        [DataMember(Name = "krbServicePrincipalName", EmitDefaultValue = false)]
        public string KrbServicePrincipalName { get; set; }

        /// <summary>
        /// KrbUsername is the Kerberos username used with Kerberos keytab It must be set if keytab is used.
        /// </summary>
        /// <value>KrbUsername is the Kerberos username used with Kerberos keytab It must be set if keytab is used.</value>
        [DataMember(Name = "krbUsername", EmitDefaultValue = false)]
        public string KrbUsername { get; set; }

        /// <summary>
        /// Path is a file path in HDFS
        /// </summary>
        /// <value>Path is a file path in HDFS</value>
        [DataMember(Name = "path", IsRequired = true, EmitDefaultValue = true)]
        public string Path { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1HDFSArtifact {\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  Force: ").Append(Force).Append("\n");
            sb.Append("  HdfsUser: ").Append(HdfsUser).Append("\n");
            sb.Append("  KrbCCacheSecret: ").Append(KrbCCacheSecret).Append("\n");
            sb.Append("  KrbConfigConfigMap: ").Append(KrbConfigConfigMap).Append("\n");
            sb.Append("  KrbKeytabSecret: ").Append(KrbKeytabSecret).Append("\n");
            sb.Append("  KrbRealm: ").Append(KrbRealm).Append("\n");
            sb.Append("  KrbServicePrincipalName: ").Append(KrbServicePrincipalName).Append("\n");
            sb.Append("  KrbUsername: ").Append(KrbUsername).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
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
