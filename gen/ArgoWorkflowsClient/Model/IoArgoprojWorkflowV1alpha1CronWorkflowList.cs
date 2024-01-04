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
    /// CronWorkflowList is list of CronWorkflow resources
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.CronWorkflowList")]
    public partial class IoArgoprojWorkflowV1alpha1CronWorkflowList : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1CronWorkflowList" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IoArgoprojWorkflowV1alpha1CronWorkflowList() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1CronWorkflowList" /> class.
        /// </summary>
        /// <param name="apiVersion">APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.io.k8s.community/contributors/devel/sig-architecture/api-conventions.md#resources.</param>
        /// <param name="items">items (required).</param>
        /// <param name="kind">Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.io.k8s.community/contributors/devel/sig-architecture/api-conventions.md#types-kinds.</param>
        /// <param name="metadata">metadata (required).</param>
        public IoArgoprojWorkflowV1alpha1CronWorkflowList(string apiVersion = default(string), List<IoArgoprojWorkflowV1alpha1CronWorkflow> items = default(List<IoArgoprojWorkflowV1alpha1CronWorkflow>), string kind = default(string), IoK8sApimachineryPkgApisMetaV1ListMeta metadata = default(IoK8sApimachineryPkgApisMetaV1ListMeta))
        {
            // to ensure "items" is required (not null)
            if (items == null)
            {
                throw new ArgumentNullException("items is a required property for IoArgoprojWorkflowV1alpha1CronWorkflowList and cannot be null");
            }
            this.Items = items;
            // to ensure "metadata" is required (not null)
            if (metadata == null)
            {
                throw new ArgumentNullException("metadata is a required property for IoArgoprojWorkflowV1alpha1CronWorkflowList and cannot be null");
            }
            this.Metadata = metadata;
            this.ApiVersion = apiVersion;
            this.Kind = kind;
        }

        /// <summary>
        /// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.io.k8s.community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </summary>
        /// <value>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.io.k8s.community/contributors/devel/sig-architecture/api-conventions.md#resources</value>
        [DataMember(Name = "apiVersion", EmitDefaultValue = false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", IsRequired = true, EmitDefaultValue = true)]
        public List<IoArgoprojWorkflowV1alpha1CronWorkflow> Items { get; set; }

        /// <summary>
        /// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.io.k8s.community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        /// <value>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.io.k8s.community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</value>
        [DataMember(Name = "kind", EmitDefaultValue = false)]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", IsRequired = true, EmitDefaultValue = true)]
        public IoK8sApimachineryPkgApisMetaV1ListMeta Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1CronWorkflowList {\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
