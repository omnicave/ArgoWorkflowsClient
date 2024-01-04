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
    /// TypedLocalObjectReference contains enough information to let you locate the typed referenced object inside the same namespace.
    /// </summary>
    [DataContract(Name = "io.k8s.api.core.v1.TypedLocalObjectReference")]
    public partial class IoK8sApiCoreV1TypedLocalObjectReference : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1TypedLocalObjectReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IoK8sApiCoreV1TypedLocalObjectReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1TypedLocalObjectReference" /> class.
        /// </summary>
        /// <param name="apiGroup">APIGroup is the group for the resource being referenced. If APIGroup is not specified, the specified Kind must be in the core API group. For any other third-party types, APIGroup is required..</param>
        /// <param name="kind">Kind is the type of resource being referenced (required).</param>
        /// <param name="name">Name is the name of resource being referenced (required).</param>
        public IoK8sApiCoreV1TypedLocalObjectReference(string apiGroup = default(string), string kind = default(string), string name = default(string))
        {
            // to ensure "kind" is required (not null)
            if (kind == null)
            {
                throw new ArgumentNullException("kind is a required property for IoK8sApiCoreV1TypedLocalObjectReference and cannot be null");
            }
            this.Kind = kind;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for IoK8sApiCoreV1TypedLocalObjectReference and cannot be null");
            }
            this.Name = name;
            this.ApiGroup = apiGroup;
        }

        /// <summary>
        /// APIGroup is the group for the resource being referenced. If APIGroup is not specified, the specified Kind must be in the core API group. For any other third-party types, APIGroup is required.
        /// </summary>
        /// <value>APIGroup is the group for the resource being referenced. If APIGroup is not specified, the specified Kind must be in the core API group. For any other third-party types, APIGroup is required.</value>
        [DataMember(Name = "apiGroup", EmitDefaultValue = false)]
        public string ApiGroup { get; set; }

        /// <summary>
        /// Kind is the type of resource being referenced
        /// </summary>
        /// <value>Kind is the type of resource being referenced</value>
        [DataMember(Name = "kind", IsRequired = true, EmitDefaultValue = true)]
        public string Kind { get; set; }

        /// <summary>
        /// Name is the name of resource being referenced
        /// </summary>
        /// <value>Name is the name of resource being referenced</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1TypedLocalObjectReference {\n");
            sb.Append("  ApiGroup: ").Append(ApiGroup).Append("\n");
            sb.Append("  Kind: ").Append(Kind).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
