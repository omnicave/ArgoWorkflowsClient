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
    /// IoArgoprojWorkflowV1alpha1InfoResponse
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.InfoResponse")]
    public partial class IoArgoprojWorkflowV1alpha1InfoResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1InfoResponse" /> class.
        /// </summary>
        /// <param name="columns">columns.</param>
        /// <param name="links">links.</param>
        /// <param name="managedNamespace">managedNamespace.</param>
        /// <param name="modals">modals.</param>
        /// <param name="navColor">navColor.</param>
        public IoArgoprojWorkflowV1alpha1InfoResponse(List<IoArgoprojWorkflowV1alpha1Column> columns = default(List<IoArgoprojWorkflowV1alpha1Column>), List<IoArgoprojWorkflowV1alpha1Link> links = default(List<IoArgoprojWorkflowV1alpha1Link>), string managedNamespace = default(string), Dictionary<string, bool> modals = default(Dictionary<string, bool>), string navColor = default(string))
        {
            this.Columns = columns;
            this.Links = links;
            this.ManagedNamespace = managedNamespace;
            this.Modals = modals;
            this.NavColor = navColor;
        }

        /// <summary>
        /// Gets or Sets Columns
        /// </summary>
        [DataMember(Name = "columns", EmitDefaultValue = false)]
        public List<IoArgoprojWorkflowV1alpha1Column> Columns { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<IoArgoprojWorkflowV1alpha1Link> Links { get; set; }

        /// <summary>
        /// Gets or Sets ManagedNamespace
        /// </summary>
        [DataMember(Name = "managedNamespace", EmitDefaultValue = false)]
        public string ManagedNamespace { get; set; }

        /// <summary>
        /// Gets or Sets Modals
        /// </summary>
        [DataMember(Name = "modals", EmitDefaultValue = false)]
        public Dictionary<string, bool> Modals { get; set; }

        /// <summary>
        /// Gets or Sets NavColor
        /// </summary>
        [DataMember(Name = "navColor", EmitDefaultValue = false)]
        public string NavColor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1InfoResponse {\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  ManagedNamespace: ").Append(ManagedNamespace).Append("\n");
            sb.Append("  Modals: ").Append(Modals).Append("\n");
            sb.Append("  NavColor: ").Append(NavColor).Append("\n");
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
