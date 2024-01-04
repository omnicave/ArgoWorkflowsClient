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
    /// Artifact indicates an artifact to place at a specified path
    /// </summary>
    [DataContract(Name = "io.argoproj.workflow.v1alpha1.Artifact")]
    public partial class IoArgoprojWorkflowV1alpha1Artifact : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1Artifact" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IoArgoprojWorkflowV1alpha1Artifact() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IoArgoprojWorkflowV1alpha1Artifact" /> class.
        /// </summary>
        /// <param name="archive">archive.</param>
        /// <param name="archiveLogs">ArchiveLogs indicates if the container logs should be archived.</param>
        /// <param name="artifactGC">artifactGC.</param>
        /// <param name="artifactory">artifactory.</param>
        /// <param name="azure">azure.</param>
        /// <param name="deleted">Has this been deleted?.</param>
        /// <param name="from">From allows an artifact to reference an artifact from a previous step.</param>
        /// <param name="fromExpression">FromExpression, if defined, is evaluated to specify the value for the artifact.</param>
        /// <param name="gcs">gcs.</param>
        /// <param name="git">git.</param>
        /// <param name="globalName">GlobalName exports an output artifact to the global scope, making it available as &#39;{{io.argoproj.workflow.v1alpha1.outputs.artifacts.XXXX}} and in workflow.status.outputs.artifacts.</param>
        /// <param name="hdfs">hdfs.</param>
        /// <param name="http">http.</param>
        /// <param name="mode">mode bits to use on this file, must be a value between 0 and 0777 set when loading input artifacts..</param>
        /// <param name="name">name of the artifact. must be unique within a template&#39;s inputs/outputs. (required).</param>
        /// <param name="optional">Make Artifacts optional, if Artifacts doesn&#39;t generate or exist.</param>
        /// <param name="oss">oss.</param>
        /// <param name="path">Path is the container path to the artifact.</param>
        /// <param name="raw">raw.</param>
        /// <param name="recurseMode">If mode is set, apply the permission recursively into the artifact if it is a folder.</param>
        /// <param name="s3">s3.</param>
        /// <param name="subPath">SubPath allows an artifact to be sourced from a subpath within the specified source.</param>
        public IoArgoprojWorkflowV1alpha1Artifact(IoArgoprojWorkflowV1alpha1ArchiveStrategy archive = default(IoArgoprojWorkflowV1alpha1ArchiveStrategy), bool archiveLogs = default(bool), IoArgoprojWorkflowV1alpha1ArtifactGC artifactGC = default(IoArgoprojWorkflowV1alpha1ArtifactGC), IoArgoprojWorkflowV1alpha1ArtifactoryArtifact artifactory = default(IoArgoprojWorkflowV1alpha1ArtifactoryArtifact), IoArgoprojWorkflowV1alpha1AzureArtifact azure = default(IoArgoprojWorkflowV1alpha1AzureArtifact), bool deleted = default(bool), string from = default(string), string fromExpression = default(string), IoArgoprojWorkflowV1alpha1GCSArtifact gcs = default(IoArgoprojWorkflowV1alpha1GCSArtifact), IoArgoprojWorkflowV1alpha1GitArtifact git = default(IoArgoprojWorkflowV1alpha1GitArtifact), string globalName = default(string), IoArgoprojWorkflowV1alpha1HDFSArtifact hdfs = default(IoArgoprojWorkflowV1alpha1HDFSArtifact), IoArgoprojWorkflowV1alpha1HTTPArtifact http = default(IoArgoprojWorkflowV1alpha1HTTPArtifact), int mode = default(int), string name = default(string), bool optional = default(bool), IoArgoprojWorkflowV1alpha1OSSArtifact oss = default(IoArgoprojWorkflowV1alpha1OSSArtifact), string path = default(string), IoArgoprojWorkflowV1alpha1RawArtifact raw = default(IoArgoprojWorkflowV1alpha1RawArtifact), bool recurseMode = default(bool), IoArgoprojWorkflowV1alpha1S3Artifact s3 = default(IoArgoprojWorkflowV1alpha1S3Artifact), string subPath = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for IoArgoprojWorkflowV1alpha1Artifact and cannot be null");
            }
            this.Name = name;
            this.Archive = archive;
            this.ArchiveLogs = archiveLogs;
            this.ArtifactGC = artifactGC;
            this.Artifactory = artifactory;
            this.Azure = azure;
            this.Deleted = deleted;
            this.From = from;
            this.FromExpression = fromExpression;
            this.Gcs = gcs;
            this.Git = git;
            this.GlobalName = globalName;
            this.Hdfs = hdfs;
            this.Http = http;
            this.Mode = mode;
            this.Optional = optional;
            this.Oss = oss;
            this.Path = path;
            this.Raw = raw;
            this.RecurseMode = recurseMode;
            this.S3 = s3;
            this.SubPath = subPath;
        }

        /// <summary>
        /// Gets or Sets Archive
        /// </summary>
        [DataMember(Name = "archive", EmitDefaultValue = false)]
        public IoArgoprojWorkflowV1alpha1ArchiveStrategy Archive { get; set; }

        /// <summary>
        /// ArchiveLogs indicates if the container logs should be archived
        /// </summary>
        /// <value>ArchiveLogs indicates if the container logs should be archived</value>
        [DataMember(Name = "archiveLogs", EmitDefaultValue = true)]
        public bool ArchiveLogs { get; set; }

        /// <summary>
        /// Gets or Sets ArtifactGC
        /// </summary>
        [DataMember(Name = "artifactGC", EmitDefaultValue = false)]
        public IoArgoprojWorkflowV1alpha1ArtifactGC ArtifactGC { get; set; }

        /// <summary>
        /// Gets or Sets Artifactory
        /// </summary>
        [DataMember(Name = "artifactory", EmitDefaultValue = false)]
        public IoArgoprojWorkflowV1alpha1ArtifactoryArtifact Artifactory { get; set; }

        /// <summary>
        /// Gets or Sets Azure
        /// </summary>
        [DataMember(Name = "azure", EmitDefaultValue = false)]
        public IoArgoprojWorkflowV1alpha1AzureArtifact Azure { get; set; }

        /// <summary>
        /// Has this been deleted?
        /// </summary>
        /// <value>Has this been deleted?</value>
        [DataMember(Name = "deleted", EmitDefaultValue = true)]
        public bool Deleted { get; set; }

        /// <summary>
        /// From allows an artifact to reference an artifact from a previous step
        /// </summary>
        /// <value>From allows an artifact to reference an artifact from a previous step</value>
        [DataMember(Name = "from", EmitDefaultValue = false)]
        public string From { get; set; }

        /// <summary>
        /// FromExpression, if defined, is evaluated to specify the value for the artifact
        /// </summary>
        /// <value>FromExpression, if defined, is evaluated to specify the value for the artifact</value>
        [DataMember(Name = "fromExpression", EmitDefaultValue = false)]
        public string FromExpression { get; set; }

        /// <summary>
        /// Gets or Sets Gcs
        /// </summary>
        [DataMember(Name = "gcs", EmitDefaultValue = false)]
        public IoArgoprojWorkflowV1alpha1GCSArtifact Gcs { get; set; }

        /// <summary>
        /// Gets or Sets Git
        /// </summary>
        [DataMember(Name = "git", EmitDefaultValue = false)]
        public IoArgoprojWorkflowV1alpha1GitArtifact Git { get; set; }

        /// <summary>
        /// GlobalName exports an output artifact to the global scope, making it available as &#39;{{io.argoproj.workflow.v1alpha1.outputs.artifacts.XXXX}} and in workflow.status.outputs.artifacts
        /// </summary>
        /// <value>GlobalName exports an output artifact to the global scope, making it available as &#39;{{io.argoproj.workflow.v1alpha1.outputs.artifacts.XXXX}} and in workflow.status.outputs.artifacts</value>
        [DataMember(Name = "globalName", EmitDefaultValue = false)]
        public string GlobalName { get; set; }

        /// <summary>
        /// Gets or Sets Hdfs
        /// </summary>
        [DataMember(Name = "hdfs", EmitDefaultValue = false)]
        public IoArgoprojWorkflowV1alpha1HDFSArtifact Hdfs { get; set; }

        /// <summary>
        /// Gets or Sets Http
        /// </summary>
        [DataMember(Name = "http", EmitDefaultValue = false)]
        public IoArgoprojWorkflowV1alpha1HTTPArtifact Http { get; set; }

        /// <summary>
        /// mode bits to use on this file, must be a value between 0 and 0777 set when loading input artifacts.
        /// </summary>
        /// <value>mode bits to use on this file, must be a value between 0 and 0777 set when loading input artifacts.</value>
        [DataMember(Name = "mode", EmitDefaultValue = false)]
        public int Mode { get; set; }

        /// <summary>
        /// name of the artifact. must be unique within a template&#39;s inputs/outputs.
        /// </summary>
        /// <value>name of the artifact. must be unique within a template&#39;s inputs/outputs.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Make Artifacts optional, if Artifacts doesn&#39;t generate or exist
        /// </summary>
        /// <value>Make Artifacts optional, if Artifacts doesn&#39;t generate or exist</value>
        [DataMember(Name = "optional", EmitDefaultValue = true)]
        public bool Optional { get; set; }

        /// <summary>
        /// Gets or Sets Oss
        /// </summary>
        [DataMember(Name = "oss", EmitDefaultValue = false)]
        public IoArgoprojWorkflowV1alpha1OSSArtifact Oss { get; set; }

        /// <summary>
        /// Path is the container path to the artifact
        /// </summary>
        /// <value>Path is the container path to the artifact</value>
        [DataMember(Name = "path", EmitDefaultValue = false)]
        public string Path { get; set; }

        /// <summary>
        /// Gets or Sets Raw
        /// </summary>
        [DataMember(Name = "raw", EmitDefaultValue = false)]
        public IoArgoprojWorkflowV1alpha1RawArtifact Raw { get; set; }

        /// <summary>
        /// If mode is set, apply the permission recursively into the artifact if it is a folder
        /// </summary>
        /// <value>If mode is set, apply the permission recursively into the artifact if it is a folder</value>
        [DataMember(Name = "recurseMode", EmitDefaultValue = true)]
        public bool RecurseMode { get; set; }

        /// <summary>
        /// Gets or Sets S3
        /// </summary>
        [DataMember(Name = "s3", EmitDefaultValue = false)]
        public IoArgoprojWorkflowV1alpha1S3Artifact S3 { get; set; }

        /// <summary>
        /// SubPath allows an artifact to be sourced from a subpath within the specified source
        /// </summary>
        /// <value>SubPath allows an artifact to be sourced from a subpath within the specified source</value>
        [DataMember(Name = "subPath", EmitDefaultValue = false)]
        public string SubPath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IoArgoprojWorkflowV1alpha1Artifact {\n");
            sb.Append("  Archive: ").Append(Archive).Append("\n");
            sb.Append("  ArchiveLogs: ").Append(ArchiveLogs).Append("\n");
            sb.Append("  ArtifactGC: ").Append(ArtifactGC).Append("\n");
            sb.Append("  Artifactory: ").Append(Artifactory).Append("\n");
            sb.Append("  Azure: ").Append(Azure).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  FromExpression: ").Append(FromExpression).Append("\n");
            sb.Append("  Gcs: ").Append(Gcs).Append("\n");
            sb.Append("  Git: ").Append(Git).Append("\n");
            sb.Append("  GlobalName: ").Append(GlobalName).Append("\n");
            sb.Append("  Hdfs: ").Append(Hdfs).Append("\n");
            sb.Append("  Http: ").Append(Http).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Optional: ").Append(Optional).Append("\n");
            sb.Append("  Oss: ").Append(Oss).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Raw: ").Append(Raw).Append("\n");
            sb.Append("  RecurseMode: ").Append(RecurseMode).Append("\n");
            sb.Append("  S3: ").Append(S3).Append("\n");
            sb.Append("  SubPath: ").Append(SubPath).Append("\n");
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
