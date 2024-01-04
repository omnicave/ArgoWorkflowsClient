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
    /// IoArgoprojEventsV1alpha1ConditionsResetCriteria
    /// </summary>
    [DataContract(Name = "io.argoproj.events.v1alpha1.ConditionsResetCriteria")]
    public partial class IoArgoprojEventsV1alpha1ConditionsResetCriteria : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojEventsV1alpha1ConditionsResetCriteria" /> class.
        /// </summary>
        /// <param name="byTime">byTime.</param>
        public IoArgoprojEventsV1alpha1ConditionsResetCriteria(IoArgoprojEventsV1alpha1ConditionsResetByTime byTime = default(IoArgoprojEventsV1alpha1ConditionsResetByTime))
        {
            this.ByTime = byTime;
        }

        /// <summary>
        /// Gets or Sets ByTime
        /// </summary>
        [DataMember(Name = "byTime", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1ConditionsResetByTime ByTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojEventsV1alpha1ConditionsResetCriteria {\n");
            sb.Append("  ByTime: ").Append(ByTime).Append("\n");
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
