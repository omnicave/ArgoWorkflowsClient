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
    /// IoArgoprojEventsV1alpha1GitRemoteConfig
    /// </summary>
    [DataContract(Name = "io.argoproj.events.v1alpha1.GitRemoteConfig")]
    public partial class IoArgoprojEventsV1alpha1GitRemoteConfig : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojEventsV1alpha1GitRemoteConfig" /> class.
        /// </summary>
        /// <param name="name">Name of the remote to fetch from..</param>
        /// <param name="urls">URLs the URLs of a remote repository. It must be non-empty. Fetch will always use the first URL, while push will use all of them..</param>
        public IoArgoprojEventsV1alpha1GitRemoteConfig(string name = default(string), List<string> urls = default(List<string>))
        {
            this.Name = name;
            this.Urls = urls;
        }

        /// <summary>
        /// Name of the remote to fetch from.
        /// </summary>
        /// <value>Name of the remote to fetch from.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// URLs the URLs of a remote repository. It must be non-empty. Fetch will always use the first URL, while push will use all of them.
        /// </summary>
        /// <value>URLs the URLs of a remote repository. It must be non-empty. Fetch will always use the first URL, while push will use all of them.</value>
        [DataMember(Name = "urls", EmitDefaultValue = false)]
        public List<string> Urls { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojEventsV1alpha1GitRemoteConfig {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Urls: ").Append(Urls).Append("\n");
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
