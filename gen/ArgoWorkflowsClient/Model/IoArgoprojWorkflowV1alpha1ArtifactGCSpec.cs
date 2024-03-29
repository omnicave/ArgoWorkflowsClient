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
    /// ArtifactGCSpec specifies the Artifacts that need to be deleted
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.ArtifactGCSpec")]
    public partial class IoArgoprojWorkflowV1alpha1ArtifactGCSpec : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1ArtifactGCSpec" /> class.
        /// </summary>
        /// <param name="artifactsByNode">ArtifactsByNode maps Node name to information pertaining to Artifacts on that Node.</param>
        public IoArgoprojWorkflowV1alpha1ArtifactGCSpec(Dictionary<string, IoArgoprojWorkflowV1alpha1ArtifactNodeSpec> artifactsByNode = default(Dictionary<string, IoArgoprojWorkflowV1alpha1ArtifactNodeSpec>))
        {
            this.ArtifactsByNode = artifactsByNode;
        }

        /// <summary>
        /// ArtifactsByNode maps Node name to information pertaining to Artifacts on that Node
        /// </summary>
        /// <value>ArtifactsByNode maps Node name to information pertaining to Artifacts on that Node</value>
        [DataMember(Name = "artifactsByNode", EmitDefaultValue = false)]
        public Dictionary<string, IoArgoprojWorkflowV1alpha1ArtifactNodeSpec> ArtifactsByNode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1ArtifactGCSpec {\n");
            sb.Append("  ArtifactsByNode: ").Append(ArtifactsByNode).Append("\n");
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
