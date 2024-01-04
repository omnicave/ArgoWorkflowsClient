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
    /// Memoization enables caching for the Outputs of the template
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.Memoize")]
    public partial class IoArgoprojWorkflowV1alpha1Memoize : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1Memoize" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IoArgoprojWorkflowV1alpha1Memoize() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1Memoize" /> class.
        /// </summary>
        /// <param name="cache">cache (required).</param>
        /// <param name="key">Key is the key to use as the caching key (required).</param>
        /// <param name="maxAge">MaxAge is the maximum age (e.g. \&quot;180s\&quot;, \&quot;24h\&quot;) of an entry that is still considered valid. If an entry is older than the MaxAge, it will be ignored. (required).</param>
        public IoArgoprojWorkflowV1alpha1Memoize(IoArgoprojWorkflowV1alpha1Cache cache = default(IoArgoprojWorkflowV1alpha1Cache), string key = default(string), string maxAge = default(string))
        {
            // to ensure "cache" is required (not null)
            if (cache == null)
            {
                throw new ArgumentNullException("cache is a required property for IoArgoprojWorkflowV1alpha1Memoize and cannot be null");
            }
            this.Cache = cache;
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new ArgumentNullException("key is a required property for IoArgoprojWorkflowV1alpha1Memoize and cannot be null");
            }
            this.Key = key;
            // to ensure "maxAge" is required (not null)
            if (maxAge == null)
            {
                throw new ArgumentNullException("maxAge is a required property for IoArgoprojWorkflowV1alpha1Memoize and cannot be null");
            }
            this.MaxAge = maxAge;
        }

        /// <summary>
        /// Gets or Sets Cache
        /// </summary>
        [DataMember(Name = "cache", IsRequired = true, EmitDefaultValue = true)]
        public IoArgoprojWorkflowV1alpha1Cache Cache { get; set; }

        /// <summary>
        /// Key is the key to use as the caching key
        /// </summary>
        /// <value>Key is the key to use as the caching key</value>
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// MaxAge is the maximum age (e.g. \&quot;180s\&quot;, \&quot;24h\&quot;) of an entry that is still considered valid. If an entry is older than the MaxAge, it will be ignored.
        /// </summary>
        /// <value>MaxAge is the maximum age (e.g. \&quot;180s\&quot;, \&quot;24h\&quot;) of an entry that is still considered valid. If an entry is older than the MaxAge, it will be ignored.</value>
        [DataMember(Name = "maxAge", IsRequired = true, EmitDefaultValue = true)]
        public string MaxAge { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1Memoize {\n");
            sb.Append("  Cache: ").Append(Cache).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  MaxAge: ").Append(MaxAge).Append("\n");
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
