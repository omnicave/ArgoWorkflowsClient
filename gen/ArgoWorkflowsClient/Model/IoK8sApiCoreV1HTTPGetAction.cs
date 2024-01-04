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
    /// HTTPGetAction describes an action based on HTTP Get requests.
    /// </summary>
    [DataContract(Name = "io.k8s.api.core.v1.HTTPGetAction")]
    public partial class IoK8sApiCoreV1HTTPGetAction : IValidatableObject
    {
        /// <summary>
        /// Scheme to use for connecting to the host. Defaults to HTTP.  Possible enum values:  - &#x60;\&quot;HTTP\&quot;&#x60; means that the scheme used will be http://  - &#x60;\&quot;HTTPS\&quot;&#x60; means that the scheme used will be https://
        /// </summary>
        /// <value>Scheme to use for connecting to the host. Defaults to HTTP.  Possible enum values:  - &#x60;\&quot;HTTP\&quot;&#x60; means that the scheme used will be http://  - &#x60;\&quot;HTTPS\&quot;&#x60; means that the scheme used will be https://</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SchemeEnum
        {
            /// <summary>
            /// Enum HTTP for value: HTTP
            /// </summary>
            [EnumMember(Value = "HTTP")]
            HTTP = 1,

            /// <summary>
            /// Enum HTTPS for value: HTTPS
            /// </summary>
            [EnumMember(Value = "HTTPS")]
            HTTPS = 2
        }


        /// <summary>
        /// Scheme to use for connecting to the host. Defaults to HTTP.  Possible enum values:  - &#x60;\&quot;HTTP\&quot;&#x60; means that the scheme used will be http://  - &#x60;\&quot;HTTPS\&quot;&#x60; means that the scheme used will be https://
        /// </summary>
        /// <value>Scheme to use for connecting to the host. Defaults to HTTP.  Possible enum values:  - &#x60;\&quot;HTTP\&quot;&#x60; means that the scheme used will be http://  - &#x60;\&quot;HTTPS\&quot;&#x60; means that the scheme used will be https://</value>
        [DataMember(Name = "scheme", EmitDefaultValue = false)]
        public SchemeEnum? Scheme { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1HTTPGetAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IoK8sApiCoreV1HTTPGetAction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1HTTPGetAction" /> class.
        /// </summary>
        /// <param name="host">Host name to connect to, defaults to the pod IP. You probably want to set \&quot;Host\&quot; in httpHeaders instead..</param>
        /// <param name="httpHeaders">Custom headers to set in the request. HTTP allows repeated headers..</param>
        /// <param name="path">Path to access on the HTTP server..</param>
        /// <param name="port">port (required).</param>
        /// <param name="scheme">Scheme to use for connecting to the host. Defaults to HTTP.  Possible enum values:  - &#x60;\&quot;HTTP\&quot;&#x60; means that the scheme used will be http://  - &#x60;\&quot;HTTPS\&quot;&#x60; means that the scheme used will be https://.</param>
        public IoK8sApiCoreV1HTTPGetAction(string host = default(string), List<IoK8sApiCoreV1HTTPHeader> httpHeaders = default(List<IoK8sApiCoreV1HTTPHeader>), string path = default(string), string port = default(string), SchemeEnum? scheme = default(SchemeEnum?))
        {
            // to ensure "port" is required (not null)
            if (port == null)
            {
                throw new ArgumentNullException("port is a required property for IoK8sApiCoreV1HTTPGetAction and cannot be null");
            }
            this.Port = port;
            this.Host = host;
            this.HttpHeaders = httpHeaders;
            this.Path = path;
            this.Scheme = scheme;
        }

        /// <summary>
        /// Host name to connect to, defaults to the pod IP. You probably want to set \&quot;Host\&quot; in httpHeaders instead.
        /// </summary>
        /// <value>Host name to connect to, defaults to the pod IP. You probably want to set \&quot;Host\&quot; in httpHeaders instead.</value>
        [DataMember(Name = "host", EmitDefaultValue = false)]
        public string Host { get; set; }

        /// <summary>
        /// Custom headers to set in the request. HTTP allows repeated headers.
        /// </summary>
        /// <value>Custom headers to set in the request. HTTP allows repeated headers.</value>
        [DataMember(Name = "httpHeaders", EmitDefaultValue = false)]
        public List<IoK8sApiCoreV1HTTPHeader> HttpHeaders { get; set; }

        /// <summary>
        /// Path to access on the HTTP server.
        /// </summary>
        /// <value>Path to access on the HTTP server.</value>
        [DataMember(Name = "path", EmitDefaultValue = false)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or Sets Port
        /// </summary>
        [DataMember(Name = "port", IsRequired = true, EmitDefaultValue = true)]
        public string Port { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1HTTPGetAction {\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  HttpHeaders: ").Append(HttpHeaders).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  Scheme: ").Append(Scheme).Append("\n");
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
