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
    /// SensorLogEntry
    /// </summary>
    [DataContract(Name = "sensor.LogEntry")]
    public partial class SensorLogEntry : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SensorLogEntry" /> class.
        /// </summary>
        /// <param name="dependencyName">dependencyName.</param>
        /// <param name="eventContext">eventContext.</param>
        /// <param name="level">level.</param>
        /// <param name="msg">msg.</param>
        /// <param name="varNamespace">varNamespace.</param>
        /// <param name="sensorName">sensorName.</param>
        /// <param name="time">Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers..</param>
        /// <param name="triggerName">triggerName.</param>
        public SensorLogEntry(string dependencyName = default(string), string eventContext = default(string), string level = default(string), string msg = default(string), string varNamespace = default(string), string sensorName = default(string), DateTime time = default(DateTime), string triggerName = default(string))
        {
            this.DependencyName = dependencyName;
            this.EventContext = eventContext;
            this.Level = level;
            this.Msg = msg;
            this.VarNamespace = varNamespace;
            this.SensorName = sensorName;
            this.Time = time;
            this.TriggerName = triggerName;
        }

        /// <summary>
        /// Gets or Sets DependencyName
        /// </summary>
        [DataMember(Name = "dependencyName", EmitDefaultValue = false)]
        public string DependencyName { get; set; }

        /// <summary>
        /// Gets or Sets EventContext
        /// </summary>
        [DataMember(Name = "eventContext", EmitDefaultValue = false)]
        public string EventContext { get; set; }

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name = "level", EmitDefaultValue = false)]
        public string Level { get; set; }

        /// <summary>
        /// Gets or Sets Msg
        /// </summary>
        [DataMember(Name = "msg", EmitDefaultValue = false)]
        public string Msg { get; set; }

        /// <summary>
        /// Gets or Sets VarNamespace
        /// </summary>
        [DataMember(Name = "namespace", EmitDefaultValue = false)]
        public string VarNamespace { get; set; }

        /// <summary>
        /// Gets or Sets SensorName
        /// </summary>
        [DataMember(Name = "sensorName", EmitDefaultValue = false)]
        public string SensorName { get; set; }

        /// <summary>
        /// Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.
        /// </summary>
        /// <value>Time is a wrapper around time.Time which supports correct marshaling to YAML and JSON.  Wrappers are provided for many of the factory methods that the time package offers.</value>
        [DataMember(Name = "time", EmitDefaultValue = false)]
        public DateTime Time { get; set; }

        /// <summary>
        /// Gets or Sets TriggerName
        /// </summary>
        [DataMember(Name = "triggerName", EmitDefaultValue = false)]
        public string TriggerName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SensorLogEntry {\n");
            sb.Append("  DependencyName: ").Append(DependencyName).Append("\n");
            sb.Append("  EventContext: ").Append(EventContext).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Msg: ").Append(Msg).Append("\n");
            sb.Append("  VarNamespace: ").Append(VarNamespace).Append("\n");
            sb.Append("  SensorName: ").Append(SensorName).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  TriggerName: ").Append(TriggerName).Append("\n");
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
