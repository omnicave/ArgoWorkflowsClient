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
    /// OSSArtifact is the location of an Alibaba Cloud OSS artifact
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.OSSArtifact")]
    public partial class IoArgoprojWorkflowV1alpha1OSSArtifact : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1OSSArtifact" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IoArgoprojWorkflowV1alpha1OSSArtifact() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1OSSArtifact" /> class.
        /// </summary>
        /// <param name="accessKeySecret">accessKeySecret.</param>
        /// <param name="bucket">Bucket is the name of the bucket.</param>
        /// <param name="createBucketIfNotPresent">CreateBucketIfNotPresent tells the driver to attempt to create the OSS bucket for output artifacts, if it doesn&#39;t exist.</param>
        /// <param name="endpoint">Endpoint is the hostname of the bucket endpoint.</param>
        /// <param name="key">Key is the path in the bucket where the artifact resides (required).</param>
        /// <param name="lifecycleRule">lifecycleRule.</param>
        /// <param name="secretKeySecret">secretKeySecret.</param>
        /// <param name="securityToken">SecurityToken is the user&#39;s temporary security token. For more details, check out: https://www.alibabacloud.com/help/doc-detail/100624.htm.</param>
        /// <param name="useSDKCreds">UseSDKCreds tells the driver to figure out credentials based on sdk defaults..</param>
        public IoArgoprojWorkflowV1alpha1OSSArtifact(IoK8sApiCoreV1SecretKeySelector accessKeySecret = default(IoK8sApiCoreV1SecretKeySelector), string bucket = default(string), bool createBucketIfNotPresent = default(bool), string endpoint = default(string), string key = default(string), IoArgoprojWorkflowV1alpha1OSSLifecycleRule lifecycleRule = default(IoArgoprojWorkflowV1alpha1OSSLifecycleRule), IoK8sApiCoreV1SecretKeySelector secretKeySecret = default(IoK8sApiCoreV1SecretKeySelector), string securityToken = default(string), bool useSDKCreds = default(bool))
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new ArgumentNullException("key is a required property for IoArgoprojWorkflowV1alpha1OSSArtifact and cannot be null");
            }
            this.Key = key;
            this.AccessKeySecret = accessKeySecret;
            this.Bucket = bucket;
            this.CreateBucketIfNotPresent = createBucketIfNotPresent;
            this.Endpoint = endpoint;
            this.LifecycleRule = lifecycleRule;
            this.SecretKeySecret = secretKeySecret;
            this.SecurityToken = securityToken;
            this.UseSDKCreds = useSDKCreds;
        }

        /// <summary>
        /// Gets or Sets AccessKeySecret
        /// </summary>
        [DataMember(Name = "accessKeySecret", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector AccessKeySecret { get; set; }

        /// <summary>
        /// Bucket is the name of the bucket
        /// </summary>
        /// <value>Bucket is the name of the bucket</value>
        [DataMember(Name = "bucket", EmitDefaultValue = false)]
        public string Bucket { get; set; }

        /// <summary>
        /// CreateBucketIfNotPresent tells the driver to attempt to create the OSS bucket for output artifacts, if it doesn&#39;t exist
        /// </summary>
        /// <value>CreateBucketIfNotPresent tells the driver to attempt to create the OSS bucket for output artifacts, if it doesn&#39;t exist</value>
        [DataMember(Name = "createBucketIfNotPresent", EmitDefaultValue = true)]
        public bool CreateBucketIfNotPresent { get; set; }

        /// <summary>
        /// Endpoint is the hostname of the bucket endpoint
        /// </summary>
        /// <value>Endpoint is the hostname of the bucket endpoint</value>
        [DataMember(Name = "endpoint", EmitDefaultValue = false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Key is the path in the bucket where the artifact resides
        /// </summary>
        /// <value>Key is the path in the bucket where the artifact resides</value>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets LifecycleRule
        /// </summary>
        [DataMember(Name = "lifecycleRule", EmitDefaultValue = false)]
        public IoArgoprojWorkflowV1alpha1OSSLifecycleRule LifecycleRule { get; set; }

        /// <summary>
        /// Gets or Sets SecretKeySecret
        /// </summary>
        [DataMember(Name = "secretKeySecret", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector SecretKeySecret { get; set; }

        /// <summary>
        /// SecurityToken is the user&#39;s temporary security token. For more details, check out: https://www.alibabacloud.com/help/doc-detail/100624.htm
        /// </summary>
        /// <value>SecurityToken is the user&#39;s temporary security token. For more details, check out: https://www.alibabacloud.com/help/doc-detail/100624.htm</value>
        [DataMember(Name = "securityToken", EmitDefaultValue = false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// UseSDKCreds tells the driver to figure out credentials based on sdk defaults.
        /// </summary>
        /// <value>UseSDKCreds tells the driver to figure out credentials based on sdk defaults.</value>
        [DataMember(Name = "useSDKCreds", EmitDefaultValue = true)]
        public bool UseSDKCreds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1OSSArtifact {\n");
            sb.Append("  AccessKeySecret: ").Append(AccessKeySecret).Append("\n");
            sb.Append("  Bucket: ").Append(Bucket).Append("\n");
            sb.Append("  CreateBucketIfNotPresent: ").Append(CreateBucketIfNotPresent).Append("\n");
            sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  LifecycleRule: ").Append(LifecycleRule).Append("\n");
            sb.Append("  SecretKeySecret: ").Append(SecretKeySecret).Append("\n");
            sb.Append("  SecurityToken: ").Append(SecurityToken).Append("\n");
            sb.Append("  UseSDKCreds: ").Append(UseSDKCreds).Append("\n");
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
