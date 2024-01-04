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
    /// S3EncryptionOptions used to determine encryption options during s3 operations
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.S3EncryptionOptions")]
    public partial class IoArgoprojWorkflowV1alpha1S3EncryptionOptions : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1S3EncryptionOptions" /> class.
        /// </summary>
        /// <param name="enableEncryption">EnableEncryption tells the driver to encrypt objects if set to true. If kmsKeyId and serverSideCustomerKeySecret are not set, SSE-S3 will be used.</param>
        /// <param name="kmsEncryptionContext">KmsEncryptionContext is a json blob that contains an encryption context. See https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context for more information.</param>
        /// <param name="kmsKeyId">KMSKeyId tells the driver to encrypt the object using the specified KMS Key..</param>
        /// <param name="serverSideCustomerKeySecret">serverSideCustomerKeySecret.</param>
        public IoArgoprojWorkflowV1alpha1S3EncryptionOptions(bool enableEncryption = default(bool), string kmsEncryptionContext = default(string), string kmsKeyId = default(string), IoK8sApiCoreV1SecretKeySelector serverSideCustomerKeySecret = default(IoK8sApiCoreV1SecretKeySelector))
        {
            this.EnableEncryption = enableEncryption;
            this.KmsEncryptionContext = kmsEncryptionContext;
            this.KmsKeyId = kmsKeyId;
            this.ServerSideCustomerKeySecret = serverSideCustomerKeySecret;
        }

        /// <summary>
        /// EnableEncryption tells the driver to encrypt objects if set to true. If kmsKeyId and serverSideCustomerKeySecret are not set, SSE-S3 will be used
        /// </summary>
        /// <value>EnableEncryption tells the driver to encrypt objects if set to true. If kmsKeyId and serverSideCustomerKeySecret are not set, SSE-S3 will be used</value>
        [DataMember(Name = "enableEncryption", EmitDefaultValue = true)]
        public bool EnableEncryption { get; set; }

        /// <summary>
        /// KmsEncryptionContext is a json blob that contains an encryption context. See https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context for more information
        /// </summary>
        /// <value>KmsEncryptionContext is a json blob that contains an encryption context. See https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context for more information</value>
        [DataMember(Name = "kmsEncryptionContext", EmitDefaultValue = false)]
        public string KmsEncryptionContext { get; set; }

        /// <summary>
        /// KMSKeyId tells the driver to encrypt the object using the specified KMS Key.
        /// </summary>
        /// <value>KMSKeyId tells the driver to encrypt the object using the specified KMS Key.</value>
        [DataMember(Name = "kmsKeyId", EmitDefaultValue = false)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Gets or Sets ServerSideCustomerKeySecret
        /// </summary>
        [DataMember(Name = "serverSideCustomerKeySecret", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector ServerSideCustomerKeySecret { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1S3EncryptionOptions {\n");
            sb.Append("  EnableEncryption: ").Append(EnableEncryption).Append("\n");
            sb.Append("  KmsEncryptionContext: ").Append(KmsEncryptionContext).Append("\n");
            sb.Append("  KmsKeyId: ").Append(KmsKeyId).Append("\n");
            sb.Append("  ServerSideCustomerKeySecret: ").Append(ServerSideCustomerKeySecret).Append("\n");
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
