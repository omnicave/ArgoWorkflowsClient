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
    /// IoArgoprojWorkflowV1alpha1UpdateCronWorkflowRequest
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.UpdateCronWorkflowRequest")]
    public partial class IoArgoprojWorkflowV1alpha1UpdateCronWorkflowRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1UpdateCronWorkflowRequest" /> class.
        /// </summary>
        /// <param name="cronWorkflow">cronWorkflow.</param>
        /// <param name="name">DEPRECATED: This field is ignored..</param>
        /// <param name="varNamespace">varNamespace.</param>
        public IoArgoprojWorkflowV1alpha1UpdateCronWorkflowRequest(IoArgoprojWorkflowV1alpha1CronWorkflow cronWorkflow = default(IoArgoprojWorkflowV1alpha1CronWorkflow), string name = default(string), string varNamespace = default(string))
        {
            this.CronWorkflow = cronWorkflow;
            this.Name = name;
            this.VarNamespace = varNamespace;
        }

        /// <summary>
        /// Gets or Sets CronWorkflow
        /// </summary>
        [DataMember(Name = "cronWorkflow", EmitDefaultValue = false)]
        public IoArgoprojWorkflowV1alpha1CronWorkflow CronWorkflow { get; set; }

        /// <summary>
        /// DEPRECATED: This field is ignored.
        /// </summary>
        /// <value>DEPRECATED: This field is ignored.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets VarNamespace
        /// </summary>
        [DataMember(Name = "namespace", EmitDefaultValue = false)]
        public string VarNamespace { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1UpdateCronWorkflowRequest {\n");
            sb.Append("  CronWorkflow: ").Append(CronWorkflow).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  VarNamespace: ").Append(VarNamespace).Append("\n");
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