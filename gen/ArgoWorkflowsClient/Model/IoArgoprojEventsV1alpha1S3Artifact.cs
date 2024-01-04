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
    /// IoArgoprojEventsV1alpha1S3Artifact
    /// </summary>
    [DataContract(Name = "io.argoproj.events.v1alpha1.S3Artifact")]
    public partial class IoArgoprojEventsV1alpha1S3Artifact : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojEventsV1alpha1S3Artifact" /> class.
        /// </summary>
        /// <param name="accessKey">accessKey.</param>
        /// <param name="bucket">bucket.</param>
        /// <param name="endpoint">endpoint.</param>
        /// <param name="events">events.</param>
        /// <param name="filter">filter.</param>
        /// <param name="insecure">insecure.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="region">region.</param>
        /// <param name="secretKey">secretKey.</param>
        public IoArgoprojEventsV1alpha1S3Artifact(IoK8sApiCoreV1SecretKeySelector accessKey = default(IoK8sApiCoreV1SecretKeySelector), IoArgoprojEventsV1alpha1S3Bucket bucket = default(IoArgoprojEventsV1alpha1S3Bucket), string endpoint = default(string), List<string> events = default(List<string>), IoArgoprojEventsV1alpha1S3Filter filter = default(IoArgoprojEventsV1alpha1S3Filter), bool insecure = default(bool), Dictionary<string, string> metadata = default(Dictionary<string, string>), string region = default(string), IoK8sApiCoreV1SecretKeySelector secretKey = default(IoK8sApiCoreV1SecretKeySelector))
        {
            this.AccessKey = accessKey;
            this.Bucket = bucket;
            this.Endpoint = endpoint;
            this.Events = events;
            this.Filter = filter;
            this.Insecure = insecure;
            this.Metadata = metadata;
            this.Region = region;
            this.SecretKey = secretKey;
        }

        /// <summary>
        /// Gets or Sets AccessKey
        /// </summary>
        [DataMember(Name = "accessKey", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector AccessKey { get; set; }

        /// <summary>
        /// Gets or Sets Bucket
        /// </summary>
        [DataMember(Name = "bucket", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1S3Bucket Bucket { get; set; }

        /// <summary>
        /// Gets or Sets Endpoint
        /// </summary>
        [DataMember(Name = "endpoint", EmitDefaultValue = false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name = "events", EmitDefaultValue = false)]
        public List<string> Events { get; set; }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1S3Filter Filter { get; set; }

        /// <summary>
        /// Gets or Sets Insecure
        /// </summary>
        [DataMember(Name = "insecure", EmitDefaultValue = true)]
        public bool Insecure { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name = "region", EmitDefaultValue = false)]
        public string Region { get; set; }

        /// <summary>
        /// Gets or Sets SecretKey
        /// </summary>
        [DataMember(Name = "secretKey", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretKeySelector SecretKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojEventsV1alpha1S3Artifact {\n");
            sb.Append("  AccessKey: ").Append(AccessKey).Append("\n");
            sb.Append("  Bucket: ").Append(Bucket).Append("\n");
            sb.Append("  Endpoint: ").Append(Endpoint).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Insecure: ").Append(Insecure).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  SecretKey: ").Append(SecretKey).Append("\n");
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
