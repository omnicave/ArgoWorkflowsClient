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
    /// IoArgoprojEventsV1alpha1EventDependency
    /// </summary>
    [DataContract(Name = "io.argoproj.events.v1alpha1.EventDependency")]
    public partial class IoArgoprojEventsV1alpha1EventDependency : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojEventsV1alpha1EventDependency" /> class.
        /// </summary>
        /// <param name="eventName">eventName.</param>
        /// <param name="eventSourceName">eventSourceName.</param>
        /// <param name="filters">filters.</param>
        /// <param name="filtersLogicalOperator">FiltersLogicalOperator defines how different filters are evaluated together. Available values: and (&amp;&amp;), or (||) Is optional and if left blank treated as and (&amp;&amp;)..</param>
        /// <param name="name">name.</param>
        /// <param name="transform">transform.</param>
        public IoArgoprojEventsV1alpha1EventDependency(string eventName = default(string), string eventSourceName = default(string), IoArgoprojEventsV1alpha1EventDependencyFilter filters = default(IoArgoprojEventsV1alpha1EventDependencyFilter), string filtersLogicalOperator = default(string), string name = default(string), IoArgoprojEventsV1alpha1EventDependencyTransformer transform = default(IoArgoprojEventsV1alpha1EventDependencyTransformer))
        {
            this.EventName = eventName;
            this.EventSourceName = eventSourceName;
            this.Filters = filters;
            this.FiltersLogicalOperator = filtersLogicalOperator;
            this.Name = name;
            this.Transform = transform;
        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name = "eventName", EmitDefaultValue = false)]
        public string EventName { get; set; }

        /// <summary>
        /// Gets or Sets EventSourceName
        /// </summary>
        [DataMember(Name = "eventSourceName", EmitDefaultValue = false)]
        public string EventSourceName { get; set; }

        /// <summary>
        /// Gets or Sets Filters
        /// </summary>
        [DataMember(Name = "filters", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1EventDependencyFilter Filters { get; set; }

        /// <summary>
        /// FiltersLogicalOperator defines how different filters are evaluated together. Available values: and (&amp;&amp;), or (||) Is optional and if left blank treated as and (&amp;&amp;).
        /// </summary>
        /// <value>FiltersLogicalOperator defines how different filters are evaluated together. Available values: and (&amp;&amp;), or (||) Is optional and if left blank treated as and (&amp;&amp;).</value>
        [DataMember(Name = "filtersLogicalOperator", EmitDefaultValue = false)]
        public string FiltersLogicalOperator { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Transform
        /// </summary>
        [DataMember(Name = "transform", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1EventDependencyTransformer Transform { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojEventsV1alpha1EventDependency {\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  EventSourceName: ").Append(EventSourceName).Append("\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  FiltersLogicalOperator: ").Append(FiltersLogicalOperator).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Transform: ").Append(Transform).Append("\n");
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
