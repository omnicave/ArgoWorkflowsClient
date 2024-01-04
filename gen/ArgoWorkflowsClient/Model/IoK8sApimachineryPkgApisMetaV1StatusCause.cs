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
    /// StatusCause provides more information about an api.Status failure, including cases when multiple errors are encountered.
    /// </summary>
    [DataContract(Name = "io.k8s.apimachinery.pkg.apis.meta.v1.StatusCause")]
    public partial class IoK8sApimachineryPkgApisMetaV1StatusCause : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApimachineryPkgApisMetaV1StatusCause" /> class.
        /// </summary>
        /// <param name="field">The field of the resource that has caused this error, as named by its JSON serialization. May include dot and postfix notation for nested attributes. Arrays are zero-indexed.  Fields may appear more than once in an array of causes due to fields having multiple errors. Optional.  Examples:   \&quot;name\&quot; - the field \&quot;name\&quot; on the current resource   \&quot;items[0].name\&quot; - the field \&quot;name\&quot; on the first array entry in \&quot;items\&quot;.</param>
        /// <param name="message">A human-readable description of the cause of the error.  This field may be presented as-is to a reader..</param>
        /// <param name="reason">A machine-readable description of the cause of the error. If this value is empty there is no information available..</param>
        public IoK8sApimachineryPkgApisMetaV1StatusCause(string field = default(string), string message = default(string), string reason = default(string))
        {
            this.Field = field;
            this.Message = message;
            this.Reason = reason;
        }

        /// <summary>
        /// The field of the resource that has caused this error, as named by its JSON serialization. May include dot and postfix notation for nested attributes. Arrays are zero-indexed.  Fields may appear more than once in an array of causes due to fields having multiple errors. Optional.  Examples:   \&quot;name\&quot; - the field \&quot;name\&quot; on the current resource   \&quot;items[0].name\&quot; - the field \&quot;name\&quot; on the first array entry in \&quot;items\&quot;
        /// </summary>
        /// <value>The field of the resource that has caused this error, as named by its JSON serialization. May include dot and postfix notation for nested attributes. Arrays are zero-indexed.  Fields may appear more than once in an array of causes due to fields having multiple errors. Optional.  Examples:   \&quot;name\&quot; - the field \&quot;name\&quot; on the current resource   \&quot;items[0].name\&quot; - the field \&quot;name\&quot; on the first array entry in \&quot;items\&quot;</value>
        [DataMember(Name = "field", EmitDefaultValue = false)]
        public string Field { get; set; }

        /// <summary>
        /// A human-readable description of the cause of the error.  This field may be presented as-is to a reader.
        /// </summary>
        /// <value>A human-readable description of the cause of the error.  This field may be presented as-is to a reader.</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// A machine-readable description of the cause of the error. If this value is empty there is no information available.
        /// </summary>
        /// <value>A machine-readable description of the cause of the error. If this value is empty there is no information available.</value>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public string Reason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoK8sApimachineryPkgApisMetaV1StatusCause {\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
