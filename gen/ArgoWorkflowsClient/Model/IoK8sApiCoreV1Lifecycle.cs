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
    /// Lifecycle describes actions that the management system should take in response to container lifecycle events. For the PostStart and PreStop lifecycle handlers, management of the container blocks until the action is complete, unless the container process fails, in which case the handler is aborted.
    /// </summary>
    [DataContract(Name = "io.k8s.api.core.v1.Lifecycle")]
    public partial class IoK8sApiCoreV1Lifecycle : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1Lifecycle" /> class.
        /// </summary>
        /// <param name="postStart">postStart.</param>
        /// <param name="preStop">preStop.</param>
        public IoK8sApiCoreV1Lifecycle(IoK8sApiCoreV1LifecycleHandler postStart = default(IoK8sApiCoreV1LifecycleHandler), IoK8sApiCoreV1LifecycleHandler preStop = default(IoK8sApiCoreV1LifecycleHandler))
        {
            this.PostStart = postStart;
            this.PreStop = preStop;
        }

        /// <summary>
        /// Gets or Sets PostStart
        /// </summary>
        [DataMember(Name = "postStart", EmitDefaultValue = false)]
        public IoK8sApiCoreV1LifecycleHandler PostStart { get; set; }

        /// <summary>
        /// Gets or Sets PreStop
        /// </summary>
        [DataMember(Name = "preStop", EmitDefaultValue = false)]
        public IoK8sApiCoreV1LifecycleHandler PreStop { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1Lifecycle {\n");
            sb.Append("  PostStart: ").Append(PostStart).Append("\n");
            sb.Append("  PreStop: ").Append(PreStop).Append("\n");
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