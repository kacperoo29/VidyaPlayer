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
    /// FeatureTvshowAttributesSeasons
    /// </summary>
    [DataContract]
    public partial class FeatureTvshowAttributesSeasons :  IEquatable<FeatureTvshowAttributesSeasons>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureTvshowAttributesSeasons" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FeatureTvshowAttributesSeasons() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureTvshowAttributesSeasons" /> class.
        /// </summary>
        /// <param name="seasonNumber">seasonNumber (required).</param>
        /// <param name="episodes">episodes.</param>
        public FeatureTvshowAttributesSeasons(decimal seasonNumber = default(decimal), List<FeatureTvshowAttributesEpisodes> episodes = default(List<FeatureTvshowAttributesEpisodes>))
        {
            // to ensure "seasonNumber" is required (not null)
            if (seasonNumber == null)
            {
                throw new InvalidDataException("seasonNumber is a required property for FeatureTvshowAttributesSeasons and cannot be null");
            }
            else
            {
                this.SeasonNumber = seasonNumber;
            }

            this.Episodes = episodes;
        }

        /// <summary>
        /// Gets or Sets SeasonNumber
        /// </summary>
        [DataMember(Name="season_number", EmitDefaultValue=true)]
        public decimal SeasonNumber { get; set; }

        /// <summary>
        /// Gets or Sets Episodes
        /// </summary>
        [DataMember(Name="episodes", EmitDefaultValue=false)]
        public List<FeatureTvshowAttributesEpisodes> Episodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeatureTvshowAttributesSeasons {\n");
            sb.Append("  SeasonNumber: ").Append(SeasonNumber).Append("\n");
            sb.Append("  Episodes: ").Append(Episodes).Append("\n");
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
            return this.Equals(input as FeatureTvshowAttributesSeasons);
        }

        /// <summary>
        /// Returns true if FeatureTvshowAttributesSeasons instances are equal
        /// </summary>
        /// <param name="input">Instance of FeatureTvshowAttributesSeasons to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeatureTvshowAttributesSeasons input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SeasonNumber == input.SeasonNumber ||
                    (this.SeasonNumber != null &&
                    this.SeasonNumber.Equals(input.SeasonNumber))
                ) && 
                (
                    this.Episodes == input.Episodes ||
                    this.Episodes != null &&
                    input.Episodes != null &&
                    this.Episodes.SequenceEqual(input.Episodes)
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
                if (this.SeasonNumber != null)
                    hashCode = hashCode * 59 + this.SeasonNumber.GetHashCode();
                if (this.Episodes != null)
                    hashCode = hashCode * 59 + this.Episodes.GetHashCode();
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


            yield break;
        }
    }

}
