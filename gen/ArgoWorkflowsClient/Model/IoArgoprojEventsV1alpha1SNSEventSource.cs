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
    /// IoArgoprojEventsV1alpha1SNSEventSource
    /// </summary>
    [DataContract(Name = "io.argoproj.events.v1alpha1.SNSEventSource")]
    public partial class IoArgoprojEventsV1alpha1SNSEventSource : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojEventsV1alpha1SNSEventSource" /> class.
        /// </summary>
        /// <param name="accessKey">accessKey.</param>
        /// <param name="endpoint">endpoint.</param>
        /// <param name="filter">filter.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="region">region.</param>
        /// <param name="roleARN">roleARN.</param>
        /// <param name="secretKey">secretKey.</param>
        /// <param name="topicArn">topicArn.</param>
        /// <param name="validateSignature">validateSignature.</param>
        /// <param name="webhook">webhook.</param>
        public IoArgoprojEventsV1alpha1SNSEventSource(IoK8sApiCoreV1SecretKeySelector accessKey = default(IoK8sApiCoreV1SecretKeySelector), string endpoint = default(string), IoArgoprojEventsV1alpha1EventSourceFilter filter = default(IoArgoprojEventsV1alpha1EventSourceFilter), Dictionary<string, string> metadata = default(Dictionary<string, string>), string region = default(string), string roleARN = default(string), IoK8sApiCoreV1SecretKeySelector secretKey = default(IoK8sApiCoreV1SecretKeySelector), string topicArn = default(string), bool validateSignature = default(bool), IoArgoprojEventsV1alpha1WebhookContext webhook = default(IoArgoprojEventsV1alpha1WebhookContext))
        {
            this.AccessKey = accessKey;
            this.Endpoint = endpoint;
            this.Filter = filter;
            this.Metadata = metadata;
            this.Region = region;
            this.RoleARN = roleARN;
            this.SecretKey = secretKey;
            this.TopicArn = topicArn;
            this.ValidateSignature = validateSignature;
            this.Webhook = webhook;
        }

        /// <summary>
        /// Gets or Sets AccessKey
        /// </summary>
        [DataMember(Name = "accessKey", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector AccessKey { get; set; }

        /// <summary>
        /// Gets or Sets Endpoint
        /// </summary>
        [DataMember(Name = "endpoint", EmitDefaultValue = false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1EventSourceFilter Filter { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name = "region", EmitDefaultValue = false)]
        public string Region { get; set; }

        /// <summary>
        /// Gets or Sets RoleARN
        /// </summary>
        [DataMember(Name = "roleARN", EmitDefaultValue = false)]
        public string RoleARN { get; set; }

        /// <summary>
        /// Gets or Sets SecretKey
        /// </summary>
        [DataMember(Name = "secretKey", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector SecretKey { get; set; }

        /// <summary>
        /// Gets or Sets TopicArn
        /// </summary>
        [DataMember(Name = "topicArn", EmitDefaultValue = false)]
        public string TopicArn { get; set; }

        /// <summary>
        /// Gets or Sets ValidateSignature
        /// </summary>
        [DataMember(Name = "validateSignature", EmitDefaultValue = true)]
        public bool ValidateSignature { get; set; }

        /// <summary>
        /// Gets or Sets Webhook
        /// </summary>
        [DataMember(Name = "webhook", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1WebhookContext Webhook { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojEventsV1alpha1SNSEventSource {\n");
            sb.Append("  AccessKey: ").Append(AccessKey).Append("\n");
            sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  RoleARN: ").Append(RoleARN).Append("\n");
            sb.Append("  SecretKey: ").Append(SecretKey).Append("\n");
            sb.Append("  TopicArn: ").Append(TopicArn).Append("\n");
            sb.Append("  ValidateSignature: ").Append(ValidateSignature).Append("\n");
            sb.Append("  Webhook: ").Append(Webhook).Append("\n");
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