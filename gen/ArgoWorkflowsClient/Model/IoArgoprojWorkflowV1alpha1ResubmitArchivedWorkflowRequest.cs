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
    /// IoArgoprojWorkflowV1alpha1ResubmitArchivedWorkflowRequest
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.ResubmitArchivedWorkflowRequest")]
    public partial class IoArgoprojWorkflowV1alpha1ResubmitArchivedWorkflowRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1ResubmitArchivedWorkflowRequest" /> class.
        /// </summary>
        /// <param name="memoized">memoized.</param>
        /// <param name="name">name.</param>
        /// <param name="varNamespace">varNamespace.</param>
        /// <param name="parameters">parameters.</param>
        /// <param name="uid">uid.</param>
        public IoArgoprojWorkflowV1alpha1ResubmitArchivedWorkflowRequest(bool memoized = default(bool), string name = default(string), string varNamespace = default(string), List<string> parameters = default(List<string>), string uid = default(string))
        {
            this.Memoized = memoized;
            this.Name = name;
            this.VarNamespace = varNamespace;
            this.Parameters = parameters;
            this.Uid = uid;
        }

        /// <summary>
        /// Gets or Sets Memoized
        /// </summary>
        [DataMember(Name = "memoized", EmitDefaultValue = true)]
        public bool Memoized { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets VarNamespace
        /// </summary>
        [DataMember(Name = "namespace", EmitDefaultValue = false)]
        public string VarNamespace { get; set; }

        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name = "parameters", EmitDefaultValue = false)]
        public List<string> Parameters { get; set; }

        /// <summary>
        /// Gets or Sets Uid
        /// </summary>
        [DataMember(Name = "uid", EmitDefaultValue = false)]
        public string Uid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1ResubmitArchivedWorkflowRequest {\n");
            sb.Append("  Memoized: ").Append(Memoized).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  VarNamespace: ").Append(VarNamespace).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
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
