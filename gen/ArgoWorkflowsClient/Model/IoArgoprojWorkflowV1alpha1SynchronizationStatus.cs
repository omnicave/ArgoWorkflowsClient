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
    /// SynchronizationStatus stores the status of semaphore and mutex.
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.SynchronizationStatus")]
    public partial class IoArgoprojWorkflowV1alpha1SynchronizationStatus : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1SynchronizationStatus" /> class.
        /// </summary>
        /// <param name="mutex">mutex.</param>
        /// <param name="semaphore">semaphore.</param>
        public IoArgoprojWorkflowV1alpha1SynchronizationStatus(IoArgoprojWorkflowV1alpha1MutexStatus mutex = default(IoArgoprojWorkflowV1alpha1MutexStatus), IoArgoprojWorkflowV1alpha1SemaphoreStatus semaphore = default(IoArgoprojWorkflowV1alpha1SemaphoreStatus))
        {
            this.Mutex = mutex;
            this.Semaphore = semaphore;
        }

        /// <summary>
        /// Gets or Sets Mutex
        /// </summary>
        [DataMember(Name = "mutex", EmitDefaultValue = false)]
        public IoArgoprojWorkflowV1alpha1MutexStatus Mutex { get; set; }

        /// <summary>
        /// Gets or Sets Semaphore
        /// </summary>
        [DataMember(Name = "semaphore", EmitDefaultValue = false)]
        public IoArgoprojWorkflowV1alpha1SemaphoreStatus Semaphore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1SynchronizationStatus {\n");
            sb.Append("  Mutex: ").Append(Mutex).Append("\n");
            sb.Append("  Semaphore: ").Append(Semaphore).Append("\n");
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
