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
    /// IoArgoprojEventsV1alpha1StripeEventSource
    /// </summary>
    [DataContract(Name = "io.argoproj.events.v1alpha1.StripeEventSource")]
    public partial class IoArgoprojEventsV1alpha1StripeEventSource : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojEventsV1alpha1StripeEventSource" /> class.
        /// </summary>
        /// <param name="apiKey">apiKey.</param>
        /// <param name="createWebhook">createWebhook.</param>
        /// <param name="eventFilter">eventFilter.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="webhook">webhook.</param>
        public IoArgoprojEventsV1alpha1StripeEventSource(IoK8sApiCoreV1SecretKeySelector apiKey = default(IoK8sApiCoreV1SecretKeySelector), bool createWebhook = default(bool), List<string> eventFilter = default(List<string>), Dictionary<string, string> metadata = default(Dictionary<string, string>), IoArgoprojEventsV1alpha1WebhookContext webhook = default(IoArgoprojEventsV1alpha1WebhookContext))
        {
            this.ApiKey = apiKey;
            this.CreateWebhook = createWebhook;
            this.EventFilter = eventFilter;
            this.Metadata = metadata;
            this.Webhook = webhook;
        }

        /// <summary>
        /// Gets or Sets ApiKey
        /// </summary>
        [DataMember(Name = "apiKey", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector ApiKey { get; set; }

        /// <summary>
        /// Gets or Sets CreateWebhook
        /// </summary>
        [DataMember(Name = "createWebhook", EmitDefaultValue = true)]
        public bool CreateWebhook { get; set; }

        /// <summary>
        /// Gets or Sets EventFilter
        /// </summary>
        [DataMember(Name = "eventFilter", EmitDefaultValue = false)]
        public List<string> EventFilter { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

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
            sb.Append("class IoArgoprojEventsV1alpha1StripeEventSource {\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
            sb.Append("  CreateWebhook: ").Append(CreateWebhook).Append("\n");
            sb.Append("  EventFilter: ").Append(EventFilter).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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