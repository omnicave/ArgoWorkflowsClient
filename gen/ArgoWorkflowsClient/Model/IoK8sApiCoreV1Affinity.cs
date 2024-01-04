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
    /// Affinity is a group of affinity scheduling rules.
    /// </summary>
    [DataContract(Name = "io.k8s.api.core.v1.Affinity")]
    public partial class IoK8sApiCoreV1Affinity : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1Affinity" /> class.
        /// </summary>
        /// <param name="nodeAffinity">nodeAffinity.</param>
        /// <param name="podAffinity">podAffinity.</param>
        /// <param name="podAntiAffinity">podAntiAffinity.</param>
        public IoK8sApiCoreV1Affinity(IoK8sApiCoreV1NodeAffinity nodeAffinity = default(IoK8sApiCoreV1NodeAffinity), IoK8sApiCoreV1PodAffinity podAffinity = default(IoK8sApiCoreV1PodAffinity), IoK8sApiCoreV1PodAntiAffinity podAntiAffinity = default(IoK8sApiCoreV1PodAntiAffinity))
        {
            this.NodeAffinity = nodeAffinity;
            this.PodAffinity = podAffinity;
            this.PodAntiAffinity = podAntiAffinity;
        }

        /// <summary>
        /// Gets or Sets NodeAffinity
        /// </summary>
        [DataMember(Name = "nodeAffinity", EmitDefaultValue = false)]
        public IoK8sApiCoreV1NodeAffinity NodeAffinity { get; set; }

        /// <summary>
        /// Gets or Sets PodAffinity
        /// </summary>
        [DataMember(Name = "podAffinity", EmitDefaultValue = false)]
        public IoK8sApiCoreV1PodAffinity PodAffinity { get; set; }

        /// <summary>
        /// Gets or Sets PodAntiAffinity
        /// </summary>
        [DataMember(Name = "podAntiAffinity", EmitDefaultValue = false)]
        public IoK8sApiCoreV1PodAntiAffinity PodAntiAffinity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1Affinity {\n");
            sb.Append("  NodeAffinity: ").Append(NodeAffinity).Append("\n");
            sb.Append("  PodAffinity: ").Append(PodAffinity).Append("\n");
            sb.Append("  PodAntiAffinity: ").Append(PodAntiAffinity).Append("\n");
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
