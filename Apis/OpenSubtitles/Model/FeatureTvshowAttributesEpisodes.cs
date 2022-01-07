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
    /// FeatureTvshowAttributesEpisodes
    /// </summary>
    [DataContract]
    public partial class FeatureTvshowAttributesEpisodes :  IEquatable<FeatureTvshowAttributesEpisodes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureTvshowAttributesEpisodes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FeatureTvshowAttributesEpisodes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureTvshowAttributesEpisodes" /> class.
        /// </summary>
        /// <param name="episodeNumber">episodeNumber (required).</param>
        /// <param name="title">title (required).</param>
        /// <param name="featureId">featureId (required).</param>
        /// <param name="featureImdbId">featureImdbId (required).</param>
        public FeatureTvshowAttributesEpisodes(decimal episodeNumber = default(decimal), string title = default(string), decimal featureId = default(decimal), decimal featureImdbId = default(decimal))
        {
            // to ensure "episodeNumber" is required (not null)
            if (episodeNumber == null)
            {
                throw new InvalidDataException("episodeNumber is a required property for FeatureTvshowAttributesEpisodes and cannot be null");
            }
            else
            {
                this.EpisodeNumber = episodeNumber;
            }

            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for FeatureTvshowAttributesEpisodes and cannot be null");
            }
            else
            {
                this.Title = title;
            }

            // to ensure "featureId" is required (not null)
            if (featureId == null)
            {
                throw new InvalidDataException("featureId is a required property for FeatureTvshowAttributesEpisodes and cannot be null");
            }
            else
            {
                this.FeatureId = featureId;
            }

            // to ensure "featureImdbId" is required (not null)
            if (featureImdbId == null)
            {
                throw new InvalidDataException("featureImdbId is a required property for FeatureTvshowAttributesEpisodes and cannot be null");
            }
            else
            {
                this.FeatureImdbId = featureImdbId;
            }

        }

        /// <summary>
        /// Gets or Sets EpisodeNumber
        /// </summary>
        [DataMember(Name="episode_number", EmitDefaultValue=true)]
        public decimal EpisodeNumber { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets FeatureId
        /// </summary>
        [DataMember(Name="feature_id", EmitDefaultValue=true)]
        public decimal FeatureId { get; set; }

        /// <summary>
        /// Gets or Sets FeatureImdbId
        /// </summary>
        [DataMember(Name="feature_imdb_id", EmitDefaultValue=true)]
        public decimal FeatureImdbId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeatureTvshowAttributesEpisodes {\n");
            sb.Append("  EpisodeNumber: ").Append(EpisodeNumber).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  FeatureId: ").Append(FeatureId).Append("\n");
            sb.Append("  FeatureImdbId: ").Append(FeatureImdbId).Append("\n");
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
            return this.Equals(input as FeatureTvshowAttributesEpisodes);
        }

        /// <summary>
        /// Returns true if FeatureTvshowAttributesEpisodes instances are equal
        /// </summary>
        /// <param name="input">Instance of FeatureTvshowAttributesEpisodes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeatureTvshowAttributesEpisodes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EpisodeNumber == input.EpisodeNumber ||
                    (this.EpisodeNumber != null &&
                    this.EpisodeNumber.Equals(input.EpisodeNumber))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.FeatureId == input.FeatureId ||
                    (this.FeatureId != null &&
                    this.FeatureId.Equals(input.FeatureId))
                ) && 
                (
                    this.FeatureImdbId == input.FeatureImdbId ||
                    (this.FeatureImdbId != null &&
                    this.FeatureImdbId.Equals(input.FeatureImdbId))
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
                if (this.EpisodeNumber != null)
                    hashCode = hashCode * 59 + this.EpisodeNumber.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.FeatureId != null)
                    hashCode = hashCode * 59 + this.FeatureId.GetHashCode();
                if (this.FeatureImdbId != null)
                    hashCode = hashCode * 59 + this.FeatureImdbId.GetHashCode();
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

            // Title (string) minLength
            if(this.Title != null && this.Title.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be greater than 1.", new [] { "Title" });
            }

            yield break;
        }
    }

}