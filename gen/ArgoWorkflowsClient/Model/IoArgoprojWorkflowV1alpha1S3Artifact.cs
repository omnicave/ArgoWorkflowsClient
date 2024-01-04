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
    /// S3Artifact is the location of an S3 artifact
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.S3Artifact")]
    public partial class IoArgoprojWorkflowV1alpha1S3Artifact : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1S3Artifact" /> class.
        /// </summary>
        /// <param name="accessKeySecret">accessKeySecret.</param>
        /// <param name="bucket">Bucket is the name of the bucket.</param>
        /// <param name="caSecret">caSecret.</param>
        /// <param name="createBucketIfNotPresent">createBucketIfNotPresent.</param>
        /// <param name="encryptionOptions">encryptionOptions.</param>
        /// <param name="endpoint">Endpoint is the hostname of the bucket endpoint.</param>
        /// <param name="insecure">Insecure will connect to the service with TLS.</param>
        /// <param name="key">Key is the key in the bucket where the artifact resides.</param>
        /// <param name="region">Region contains the optional bucket region.</param>
        /// <param name="roleARN">RoleARN is the Amazon Resource Name (ARN) of the role to assume..</param>
        /// <param name="secretKeySecret">secretKeySecret.</param>
        /// <param name="useSDKCreds">UseSDKCreds tells the driver to figure out credentials based on sdk defaults..</param>
        public IoArgoprojWorkflowV1alpha1S3Artifact(IoK8sApiCoreV1SecretKeySelector accessKeySecret = default(IoK8sApiCoreV1SecretKeySelector), string bucket = default(string), IoK8sApiCoreV1SecretKeySelector caSecret = default(IoK8sApiCoreV1SecretKeySelector), IoArgoprojWorkflowV1alpha1CreateS3BucketOptions createBucketIfNotPresent = default(IoArgoprojWorkflowV1alpha1CreateS3BucketOptions), IoArgoprojWorkflowV1alpha1S3EncryptionOptions encryptionOptions = default(IoArgoprojWorkflowV1alpha1S3EncryptionOptions), string endpoint = default(string), bool insecure = default(bool), string key = default(string), string region = default(string), string roleARN = default(string), IoK8sApiCoreV1SecretKeySelector secretKeySecret = default(IoK8sApiCoreV1SecretKeySelector), bool useSDKCreds = default(bool))
        {
            this.AccessKeySecret = accessKeySecret;
            this.Bucket = bucket;
            this.CaSecret = caSecret;
            this.CreateBucketIfNotPresent = createBucketIfNotPresent;
            this.EncryptionOptions = encryptionOptions;
            this.Endpoint = endpoint;
            this.Insecure = insecure;
            this.Key = key;
            this.Region = region;
            this.RoleARN = roleARN;
            this.SecretKeySecret = secretKeySecret;
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
        /// Gets or Sets CaSecret
        /// </summary>
        [DataMember(Name = "caSecret", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector CaSecret { get; set; }

        /// <summary>
        /// Gets or Sets CreateBucketIfNotPresent
        /// </summary>
        [DataMember(Name = "createBucketIfNotPresent", EmitDefaultValue = false)]
        public IoArgoprojWorkflowV1alpha1CreateS3BucketOptions CreateBucketIfNotPresent { get; set; }

        /// <summary>
        /// Gets or Sets EncryptionOptions
        /// </summary>
        [DataMember(Name = "encryptionOptions", EmitDefaultValue = false)]
        public IoArgoprojWorkflowV1alpha1S3EncryptionOptions EncryptionOptions { get; set; }

        /// <summary>
        /// Endpoint is the hostname of the bucket endpoint
        /// </summary>
        /// <value>Endpoint is the hostname of the bucket endpoint</value>
        [DataMember(Name = "endpoint", EmitDefaultValue = false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Insecure will connect to the service with TLS
        /// </summary>
        /// <value>Insecure will connect to the service with TLS</value>
        [DataMember(Name = "insecure", EmitDefaultValue = true)]
        public bool Insecure { get; set; }

        /// <summary>
        /// Key is the key in the bucket where the artifact resides
        /// </summary>
        /// <value>Key is the key in the bucket where the artifact resides</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Region contains the optional bucket region
        /// </summary>
        /// <value>Region contains the optional bucket region</value>
        [DataMember(Name = "region", EmitDefaultValue = false)]
        public string Region { get; set; }

        /// <summary>
        /// RoleARN is the Amazon Resource Name (ARN) of the role to assume.
        /// </summary>
        /// <value>RoleARN is the Amazon Resource Name (ARN) of the role to assume.</value>
        [DataMember(Name = "roleARN", EmitDefaultValue = false)]
        public string RoleARN { get; set; }

        /// <summary>
        /// Gets or Sets SecretKeySecret
        /// </summary>
        [DataMember(Name = "secretKeySecret", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector SecretKeySecret { get; set; }

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
            sb.Append("class IoArgoprojWorkflowV1alpha1S3Artifact {\n");
            sb.Append("  AccessKeySecret: ").Append(AccessKeySecret).Append("\n");
            sb.Append("  Bucket: ").Append(Bucket).Append("\n");
            sb.Append("  CaSecret: ").Append(CaSecret).Append("\n");
            sb.Append("  CreateBucketIfNotPresent: ").Append(CreateBucketIfNotPresent).Append("\n");
            sb.Append("  EncryptionOptions: ").Append(EncryptionOptions).Append("\n");
            sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  Insecure: ").Append(Insecure).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  RoleARN: ").Append(RoleARN).Append("\n");
            sb.Append("  SecretKeySecret: ").Append(SecretKeySecret).Append("\n");
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
