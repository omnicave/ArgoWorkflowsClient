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
    /// IoArgoprojEventsV1alpha1AzureEventHubsTrigger
    /// </summary>
    [DataContract(Name = "io.argoproj.events.v1alpha1.AzureEventHubsTrigger")]
    public partial class IoArgoprojEventsV1alpha1AzureEventHubsTrigger : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojEventsV1alpha1AzureEventHubsTrigger" /> class.
        /// </summary>
        /// <param name="fqdn">fqdn.</param>
        /// <param name="hubName">hubName.</param>
        /// <param name="parameters">parameters.</param>
        /// <param name="payload">Payload is the list of key-value extracted from an event payload to construct the request payload..</param>
        /// <param name="sharedAccessKey">sharedAccessKey.</param>
        /// <param name="sharedAccessKeyName">sharedAccessKeyName.</param>
        public IoArgoprojEventsV1alpha1AzureEventHubsTrigger(string fqdn = default(string), string hubName = default(string), List<IoArgoprojEventsV1alpha1TriggerParameter> parameters = default(List<IoArgoprojEventsV1alpha1TriggerParameter>), List<IoArgoprojEventsV1alpha1TriggerParameter> payload = default(List<IoArgoprojEventsV1alpha1TriggerParameter>), IoK8sApiCoreV1SecretKeySelector sharedAccessKey = default(IoK8sApiCoreV1SecretKeySelector), IoK8sApiCoreV1SecretKeySelector sharedAccessKeyName = default(IoK8sApiCoreV1SecretKeySelector))
        {
            this.Fqdn = fqdn;
            this.HubName = hubName;
            this.Parameters = parameters;
            this.Payload = payload;
            this.SharedAccessKey = sharedAccessKey;
            this.SharedAccessKeyName = sharedAccessKeyName;
        }

        /// <summary>
        /// Gets or Sets Fqdn
        /// </summary>
        [DataMember(Name = "fqdn", EmitDefaultValue = false)]
        public string Fqdn { get; set; }

        /// <summary>
        /// Gets or Sets HubName
        /// </summary>
        [DataMember(Name = "hubName", EmitDefaultValue = false)]
        public string HubName { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name = "parameters", EmitDefaultValue = false)]
        public List<IoArgoprojEventsV1alpha1TriggerParameter> Parameters { get; set; }

        /// <summary>
        /// Payload is the list of key-value extracted from an event payload to construct the request payload.
        /// </summary>
        /// <value>Payload is the list of key-value extracted from an event payload to construct the request payload.</value>
        [DataMember(Name = "payload", EmitDefaultValue = false)]
        public List<IoArgoprojEventsV1alpha1TriggerParameter> Payload { get; set; }

        /// <summary>
        /// Gets or Sets SharedAccessKey
        /// </summary>
        [DataMember(Name = "sharedAccessKey", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector SharedAccessKey { get; set; }

        /// <summary>
        /// Gets or Sets SharedAccessKeyName
        /// </summary>
        [DataMember(Name = "sharedAccessKeyName", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector SharedAccessKeyName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojEventsV1alpha1AzureEventHubsTrigger {\n");
            sb.Append("  Fqdn: ").Append(Fqdn).Append("\n");
            sb.Append("  HubName: ").Append(HubName).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  SharedAccessKey: ").Append(SharedAccessKey).Append("\n");
            sb.Append("  SharedAccessKeyName: ").Append(SharedAccessKeyName).Append("\n");
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
