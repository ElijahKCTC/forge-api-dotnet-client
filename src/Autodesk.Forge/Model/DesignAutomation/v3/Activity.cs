/* 
 * Forge SDK
 *
 * The Forge Platform contains an expanding collection of web service components that can be used with Autodesk cloud-based products or your own technologies. Take advantage of Autodesk�s expertise in design and engineering.
 *
 * OpenAPI spec version: 0.1.0
 * Contact: forge.help@autodesk.com 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Autodesk.Forge.Model.DesignAutomation.v3
{
    /// <summary>
    /// Defines an Activity, a type of work, a function: input/outputs, instructions. An Activity is an action that can be executed within an engine. For example, for AutoCAD engine this might be plotting a DWG to PDF or update the CAD standards in a drawing file.
    /// </summary>
    [DataContract]
    public partial class Activity :  IEquatable<Activity>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Activity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Activity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Activity" /> class.
        /// </summary>
        /// <param name="CommandLine">Gets CommandLine. (required).</param>
        /// <param name="Parameters">Parameters.</param>
        /// <param name="Engine">Engine (required).</param>
        /// <param name="Appbundles">Appbundles.</param>
        /// <param name="Settings">The url/string Settings for a given appbundles..</param>
        /// <param name="Description">Human readable description of the object..</param>
        /// <param name="Version">Version.</param>
        /// <param name="Id">Id.</param>
        public Activity(List<string> CommandLine = null, Dictionary<string, ModelParameter> Parameters = null, string Engine = null, List<string> Appbundles = null, Dictionary<string, dynamic> Settings = null, string Description = null, int? Version = null, string Id = null)
        {
            // to ensure "CommandLine" is required (not null)
            if (CommandLine == null)
            {
                throw new InvalidDataException("CommandLine is a required property for Activity and cannot be null");
            }
            else
            {
                this.CommandLine = CommandLine;
            }
            // to ensure "Engine" is required (not null)
            if (Engine == null)
            {
                throw new InvalidDataException("Engine is a required property for Activity and cannot be null");
            }
            else
            {
                this.Engine = Engine;
            }
            this.Parameters = Parameters;
            this.Appbundles = Appbundles;
            this.Settings = Settings;
            this.Description = Description;
            this.Version = Version;
            this.Id = Id;
        }
        
        /// <summary>
        /// Gets CommandLine.
        /// </summary>
        /// <value>Gets CommandLine.</value>
        [DataMember(Name="commandLine", EmitDefaultValue=false)]
        public List<string> CommandLine { get; set; }
        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public Dictionary<string, ModelParameter> Parameters { get; set; }
        /// <summary>
        /// Gets or Sets Engine
        /// </summary>
        [DataMember(Name="engine", EmitDefaultValue=false)]
        public string Engine { get; set; }
        /// <summary>
        /// Gets or Sets Appbundles
        /// </summary>
        [DataMember(Name="appbundles", EmitDefaultValue=false)]
        public List<string> Appbundles { get; set; }
        /// <summary>
        /// The url/string Settings for a given appbundles.
        /// </summary>
        /// <value>The url/string Settings for a given appbundles.</value>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public Dictionary<string, dynamic> Settings { get; set; }
        /// <summary>
        /// Human readable description of the object.
        /// </summary>
        /// <value>Human readable description of the object.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Activity {\n");
            sb.Append("  CommandLine: ").Append(CommandLine).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Engine: ").Append(Engine).Append("\n");
            sb.Append("  Appbundles: ").Append(Appbundles).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Activity);
        }

        /// <summary>
        /// Returns true if Activity instances are equal
        /// </summary>
        /// <param name="other">Instance of Activity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Activity other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CommandLine == other.CommandLine ||
                    this.CommandLine != null &&
                    this.CommandLine.SequenceEqual(other.CommandLine)
                ) && 
                (
                    this.Parameters == other.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(other.Parameters)
                ) && 
                (
                    this.Engine == other.Engine ||
                    this.Engine != null &&
                    this.Engine.Equals(other.Engine)
                ) && 
                (
                    this.Appbundles == other.Appbundles ||
                    this.Appbundles != null &&
                    this.Appbundles.SequenceEqual(other.Appbundles)
                ) && 
                (
                    this.Settings == other.Settings ||
                    this.Settings != null &&
                    this.Settings.SequenceEqual(other.Settings)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.CommandLine != null)
                    hash = hash * 59 + this.CommandLine.GetHashCode();
                if (this.Parameters != null)
                    hash = hash * 59 + this.Parameters.GetHashCode();
                if (this.Engine != null)
                    hash = hash * 59 + this.Engine.GetHashCode();
                if (this.Appbundles != null)
                    hash = hash * 59 + this.Appbundles.GetHashCode();
                if (this.Settings != null)
                    hash = hash * 59 + this.Settings.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                return hash;
            }
        }
    }

}

