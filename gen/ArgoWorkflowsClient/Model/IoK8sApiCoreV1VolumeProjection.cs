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
    /// Projection that may be projected along with other supported volume types
    /// </summary>
    [DataContract(Name = "io.k8s.api.core.v1.VolumeProjection")]
    public partial class IoK8sApiCoreV1VolumeProjection : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoK8sApiCoreV1VolumeProjection" /> class.
        /// </summary>
        /// <param name="configMap">configMap.</param>
        /// <param name="downwardAPI">downwardAPI.</param>
        /// <param name="secret">secret.</param>
        /// <param name="serviceAccountToken">serviceAccountToken.</param>
        public IoK8sApiCoreV1VolumeProjection(IoK8sApiCoreV1ConfigMapProjection configMap = default(IoK8sApiCoreV1ConfigMapProjection), IoK8sApiCoreV1DownwardAPIProjection downwardAPI = default(IoK8sApiCoreV1DownwardAPIProjection), IoK8sApiCoreV1SecretProjection secret = default(IoK8sApiCoreV1SecretProjection), IoK8sApiCoreV1ServiceAccountTokenProjection serviceAccountToken = default(IoK8sApiCoreV1ServiceAccountTokenProjection))
        {
            this.ConfigMap = configMap;
            this.DownwardAPI = downwardAPI;
            this.Secret = secret;
            this.ServiceAccountToken = serviceAccountToken;
        }

        /// <summary>
        /// Gets or Sets ConfigMap
        /// </summary>
        [DataMember(Name = "configMap", EmitDefaultValue = false)]
        public IoK8sApiCoreV1ConfigMapProjection ConfigMap { get; set; }

        /// <summary>
        /// Gets or Sets DownwardAPI
        /// </summary>
        [DataMember(Name = "downwardAPI", EmitDefaultValue = false)]
        public IoK8sApiCoreV1DownwardAPIProjection DownwardAPI { get; set; }

        /// <summary>
        /// Gets or Sets Secret
        /// </summary>
        [DataMember(Name = "secret", EmitDefaultValue = false)]
        public IoK8sApiCoreV1SecretProjection Secret { get; set; }

        /// <summary>
        /// Gets or Sets ServiceAccountToken
        /// </summary>
        [DataMember(Name = "serviceAccountToken", EmitDefaultValue = false)]
        public IoK8sApiCoreV1ServiceAccountTokenProjection ServiceAccountToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoK8sApiCoreV1VolumeProjection {\n");
            sb.Append("  ConfigMap: ").Append(ConfigMap).Append("\n");
            sb.Append("  DownwardAPI: ").Append(DownwardAPI).Append("\n");
            sb.Append("  Secret: ").Append(Secret).Append("\n");
            sb.Append("  ServiceAccountToken: ").Append(ServiceAccountToken).Append("\n");
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
