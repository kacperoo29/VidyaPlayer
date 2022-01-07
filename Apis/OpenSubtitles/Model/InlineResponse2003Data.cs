/*
 * OpenSubtitles API
 *
 * Explore subtitles API here
 *
 * The version of the OpenAPI document: 1.0.1
 * Contact: support@opensubtitles.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = OpenSubtitles.Client.OpenAPIDateConverter;

namespace OpenSubtitles.Model
{
    /// <summary>
    /// InlineResponse2003Data
    /// </summary>
    [DataContract]
    public partial class InlineResponse2003Data :  IEquatable<InlineResponse2003Data>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2003Data" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineResponse2003Data() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2003Data" /> class.
        /// </summary>
        /// <param name="allowedDownloads">allowedDownloads (required).</param>
        /// <param name="level">level (required).</param>
        /// <param name="userId">userId (required).</param>
        /// <param name="extInstalled">extInstalled (required).</param>
        /// <param name="vip">vip (required).</param>
        /// <param name="downloadsCount">downloadsCount (required).</param>
        /// <param name="remainingDownloads">remainingDownloads (required).</param>
        public InlineResponse2003Data(decimal allowedDownloads = default(decimal), string level = default(string), decimal userId = default(decimal), bool extInstalled = default(bool), bool vip = default(bool), decimal downloadsCount = default(decimal), decimal remainingDownloads = default(decimal))
        {
            // to ensure "allowedDownloads" is required (not null)
            if (allowedDownloads == null)
            {
                throw new InvalidDataException("allowedDownloads is a required property for InlineResponse2003Data and cannot be null");
            }
            else
            {
                this.AllowedDownloads = allowedDownloads;
            }

            // to ensure "level" is required (not null)
            if (level == null)
            {
                throw new InvalidDataException("level is a required property for InlineResponse2003Data and cannot be null");
            }
            else
            {
                this.Level = level;
            }

            // to ensure "userId" is required (not null)
            if (userId == null)
            {
                throw new InvalidDataException("userId is a required property for InlineResponse2003Data and cannot be null");
            }
            else
            {
                this.UserId = userId;
            }

            // to ensure "extInstalled" is required (not null)
            if (extInstalled == null)
            {
                throw new InvalidDataException("extInstalled is a required property for InlineResponse2003Data and cannot be null");
            }
            else
            {
                this.ExtInstalled = extInstalled;
            }

            // to ensure "vip" is required (not null)
            if (vip == null)
            {
                throw new InvalidDataException("vip is a required property for InlineResponse2003Data and cannot be null");
            }
            else
            {
                this.Vip = vip;
            }

            // to ensure "downloadsCount" is required (not null)
            if (downloadsCount == null)
            {
                throw new InvalidDataException("downloadsCount is a required property for InlineResponse2003Data and cannot be null");
            }
            else
            {
                this.DownloadsCount = downloadsCount;
            }

            // to ensure "remainingDownloads" is required (not null)
            if (remainingDownloads == null)
            {
                throw new InvalidDataException("remainingDownloads is a required property for InlineResponse2003Data and cannot be null");
            }
            else
            {
                this.RemainingDownloads = remainingDownloads;
            }

        }

        /// <summary>
        /// Gets or Sets AllowedDownloads
        /// </summary>
        [DataMember(Name="allowed_downloads", EmitDefaultValue=true)]
        public decimal AllowedDownloads { get; set; }

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name="level", EmitDefaultValue=true)]
        public string Level { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=true)]
        public decimal UserId { get; set; }

        /// <summary>
        /// Gets or Sets ExtInstalled
        /// </summary>
        [DataMember(Name="ext_installed", EmitDefaultValue=true)]
        public bool ExtInstalled { get; set; }

        /// <summary>
        /// Gets or Sets Vip
        /// </summary>
        [DataMember(Name="vip", EmitDefaultValue=true)]
        public bool Vip { get; set; }

        /// <summary>
        /// Gets or Sets DownloadsCount
        /// </summary>
        [DataMember(Name="downloads_count", EmitDefaultValue=true)]
        public decimal DownloadsCount { get; set; }

        /// <summary>
        /// Gets or Sets RemainingDownloads
        /// </summary>
        [DataMember(Name="remaining_downloads", EmitDefaultValue=true)]
        public decimal RemainingDownloads { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2003Data {\n");
            sb.Append("  AllowedDownloads: ").Append(AllowedDownloads).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ExtInstalled: ").Append(ExtInstalled).Append("\n");
            sb.Append("  Vip: ").Append(Vip).Append("\n");
            sb.Append("  DownloadsCount: ").Append(DownloadsCount).Append("\n");
            sb.Append("  RemainingDownloads: ").Append(RemainingDownloads).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as InlineResponse2003Data);
        }

        /// <summary>
        /// Returns true if InlineResponse2003Data instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse2003Data to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2003Data input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllowedDownloads == input.AllowedDownloads ||
                    (this.AllowedDownloads != null &&
                    this.AllowedDownloads.Equals(input.AllowedDownloads))
                ) && 
                (
                    this.Level == input.Level ||
                    (this.Level != null &&
                    this.Level.Equals(input.Level))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.ExtInstalled == input.ExtInstalled ||
                    (this.ExtInstalled != null &&
                    this.ExtInstalled.Equals(input.ExtInstalled))
                ) && 
                (
                    this.Vip == input.Vip ||
                    (this.Vip != null &&
                    this.Vip.Equals(input.Vip))
                ) && 
                (
                    this.DownloadsCount == input.DownloadsCount ||
                    (this.DownloadsCount != null &&
                    this.DownloadsCount.Equals(input.DownloadsCount))
                ) && 
                (
                    this.RemainingDownloads == input.RemainingDownloads ||
                    (this.RemainingDownloads != null &&
                    this.RemainingDownloads.Equals(input.RemainingDownloads))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AllowedDownloads != null)
                    hashCode = hashCode * 59 + this.AllowedDownloads.GetHashCode();
                if (this.Level != null)
                    hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.ExtInstalled != null)
                    hashCode = hashCode * 59 + this.ExtInstalled.GetHashCode();
                if (this.Vip != null)
                    hashCode = hashCode * 59 + this.Vip.GetHashCode();
                if (this.DownloadsCount != null)
                    hashCode = hashCode * 59 + this.DownloadsCount.GetHashCode();
                if (this.RemainingDownloads != null)
                    hashCode = hashCode * 59 + this.RemainingDownloads.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {

            // Level (string) minLength
            if(this.Level != null && this.Level.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Level, length must be greater than 1.", new [] { "Level" });
            }

            yield break;
        }
    }

}