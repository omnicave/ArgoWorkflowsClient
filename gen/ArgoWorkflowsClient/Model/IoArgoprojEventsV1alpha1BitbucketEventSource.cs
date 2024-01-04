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
    /// IoArgoprojEventsV1alpha1BitbucketEventSource
    /// </summary>
    [DataContract(Name = "io.argoproj.events.v1alpha1.BitbucketEventSource")]
    public partial class IoArgoprojEventsV1alpha1BitbucketEventSource : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojEventsV1alpha1BitbucketEventSource" /> class.
        /// </summary>
        /// <param name="auth">auth.</param>
        /// <param name="deleteHookOnFinish">deleteHookOnFinish.</param>
        /// <param name="events">Events this webhook is subscribed to..</param>
        /// <param name="filter">filter.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="owner">owner.</param>
        /// <param name="projectKey">projectKey.</param>
        /// <param name="repositories">repositories.</param>
        /// <param name="repositorySlug">repositorySlug.</param>
        /// <param name="webhook">webhook.</param>
        public IoArgoprojEventsV1alpha1BitbucketEventSource(IoArgoprojEventsV1alpha1BitbucketAuth auth = default(IoArgoprojEventsV1alpha1BitbucketAuth), bool deleteHookOnFinish = default(bool), List<string> events = default(List<string>), IoArgoprojEventsV1alpha1EventSourceFilter filter = default(IoArgoprojEventsV1alpha1EventSourceFilter), Dictionary<string, string> metadata = default(Dictionary<string, string>), string owner = default(string), string projectKey = default(string), List<IoArgoprojEventsV1alpha1BitbucketRepository> repositories = default(List<IoArgoprojEventsV1alpha1BitbucketRepository>), string repositorySlug = default(string), IoArgoprojEventsV1alpha1WebhookContext webhook = default(IoArgoprojEventsV1alpha1WebhookContext))
        {
            this.Auth = auth;
            this.DeleteHookOnFinish = deleteHookOnFinish;
            this.Events = events;
            this.Filter = filter;
            this.Metadata = metadata;
            this.Owner = owner;
            this.ProjectKey = projectKey;
            this.Repositories = repositories;
            this.RepositorySlug = repositorySlug;
            this.Webhook = webhook;
        }

        /// <summary>
        /// Gets or Sets Auth
        /// </summary>
        [DataMember(Name = "auth", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1BitbucketAuth Auth { get; set; }

        /// <summary>
        /// Gets or Sets DeleteHookOnFinish
        /// </summary>
        [DataMember(Name = "deleteHookOnFinish", EmitDefaultValue = true)]
        public bool DeleteHookOnFinish { get; set; }

        /// <summary>
        /// Events this webhook is subscribed to.
        /// </summary>
        /// <value>Events this webhook is subscribed to.</value>
        [DataMember(Name = "events", EmitDefaultValue = false)]
        public List<string> Events { get; set; }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1EventSourceFilter Filter { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name = "owner", EmitDefaultValue = false)]
        public string Owner { get; set; }

        /// <summary>
        /// Gets or Sets ProjectKey
        /// </summary>
        [DataMember(Name = "projectKey", EmitDefaultValue = false)]
        public string ProjectKey { get; set; }

        /// <summary>
        /// Gets or Sets Repositories
        /// </summary>
        [DataMember(Name = "repositories", EmitDefaultValue = false)]
        public List<IoArgoprojEventsV1alpha1BitbucketRepository> Repositories { get; set; }

        /// <summary>
        /// Gets or Sets RepositorySlug
        /// </summary>
        [DataMember(Name = "repositorySlug", EmitDefaultValue = false)]
        public string RepositorySlug { get; set; }

        /// <summary>
        /// Gets or Sets Webhook
        /// </summary>
        [DataMember(Name = "webhook", EmitDefaultValue = false)]
        public IoArgoprojEventsV1alpha1WebhookContext Webhook { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojEventsV1alpha1BitbucketEventSource {\n");
            sb.Append("  Auth: ").Append(Auth).Append("\n");
            sb.Append("  DeleteHookOnFinish: ").Append(DeleteHookOnFinish).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  ProjectKey: ").Append(ProjectKey).Append("\n");
            sb.Append("  Repositories: ").Append(Repositories).Append("\n");
            sb.Append("  RepositorySlug: ").Append(RepositorySlug).Append("\n");
            sb.Append("  Webhook: ").Append(Webhook).Append("\n");
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
