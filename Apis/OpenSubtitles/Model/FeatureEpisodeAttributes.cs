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
    /// FeatureEpisodeAttributes
    /// </summary>
    [DataContract]
    public partial class FeatureEpisodeAttributes :  IEquatable<FeatureEpisodeAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureEpisodeAttributes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FeatureEpisodeAttributes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeatureEpisodeAttributes" /> class.
        /// </summary>
        /// <param name="title">title (required).</param>
        /// <param name="originalTitle">originalTitle.</param>
        /// <param name="year">year (required).</param>
        /// <param name="parentImdbId">parentImdbId.</param>
        /// <param name="parentTitle">parentTitle (required).</param>
        /// <param name="seasonNumber">seasonNumber (required).</param>
        /// <param name="episodeNumber">episodeNumber (required).</param>
        /// <param name="imdbId">imdbId (required).</param>
        /// <param name="tmdbId">tmdbId (required).</param>
        /// <param name="titleAka">titleAka (required).</param>
        /// <param name="featureId">featureId (required).</param>
        /// <param name="url">url (required).</param>
        /// <param name="imgUrl">imgUrl (required).</param>
        /// <param name="subtitlesCounts">subtitlesCounts (required).</param>
        /// <param name="subtitlesCount">subtitlesCount (required).</param>
        public FeatureEpisodeAttributes(string title = default(string), Object originalTitle = default(Object), string year = default(string), Object parentImdbId = default(Object), string parentTitle = default(string), decimal seasonNumber = default(decimal), decimal episodeNumber = default(decimal), decimal imdbId = default(decimal), decimal tmdbId = default(decimal), List<Object> titleAka = default(List<Object>), string featureId = default(string), string url = default(string), string imgUrl = default(string), FeatureEpisodeAttributesSubtitlesCounts subtitlesCounts = default(FeatureEpisodeAttributesSubtitlesCounts), decimal subtitlesCount = default(decimal))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for FeatureEpisodeAttributes and cannot be null");
            }
            else
            {
                this.Title = title;
            }

            // to ensure "year" is required (not null)
            if (year == null)
            {
                throw new InvalidDataException("year is a required property for FeatureEpisodeAttributes and cannot be null");
            }
            else
            {
                this.Year = year;
            }

            // to ensure "parentTitle" is required (not null)
            if (parentTitle == null)
            {
                throw new InvalidDataException("parentTitle is a required property for FeatureEpisodeAttributes and cannot be null");
            }
            else
            {
                this.ParentTitle = parentTitle;
            }

            // to ensure "seasonNumber" is required (not null)
            if (seasonNumber == null)
            {
                throw new InvalidDataException("seasonNumber is a required property for FeatureEpisodeAttributes and cannot be null");
            }
            else
            {
                this.SeasonNumber = seasonNumber;
            }

            // to ensure "episodeNumber" is required (not null)
            if (episodeNumber == null)
            {
                throw new InvalidDataException("episodeNumber is a required property for FeatureEpisodeAttributes and cannot be null");
            }
            else
            {
                this.EpisodeNumber = episodeNumber;
            }

            // to ensure "imdbId" is required (not null)
            if (imdbId == null)
            {
                throw new InvalidDataException("imdbId is a required property for FeatureEpisodeAttributes and cannot be null");
            }
            else
            {
                this.ImdbId = imdbId;
            }

            // to ensure "tmdbId" is required (not null)
            if (tmdbId == null)
            {
                throw new InvalidDataException("tmdbId is a required property for FeatureEpisodeAttributes and cannot be null");
            }
            else
            {
                this.TmdbId = tmdbId;
            }

            // to ensure "titleAka" is required (not null)
            if (titleAka == null)
            {
                throw new InvalidDataException("titleAka is a required property for FeatureEpisodeAttributes and cannot be null");
            }
            else
            {
                this.TitleAka = titleAka;
            }

            // to ensure "featureId" is required (not null)
            if (featureId == null)
            {
                throw new InvalidDataException("featureId is a required property for FeatureEpisodeAttributes and cannot be null");
            }
            else
            {
                this.FeatureId = featureId;
            }

            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new InvalidDataException("url is a required property for FeatureEpisodeAttributes and cannot be null");
            }
            else
            {
                this.Url = url;
            }

            // to ensure "imgUrl" is required (not null)
            if (imgUrl == null)
            {
                throw new InvalidDataException("imgUrl is a required property for FeatureEpisodeAttributes and cannot be null");
            }
            else
            {
                this.ImgUrl = imgUrl;
            }

            // to ensure "subtitlesCounts" is required (not null)
            if (subtitlesCounts == null)
            {
                throw new InvalidDataException("subtitlesCounts is a required property for FeatureEpisodeAttributes and cannot be null");
            }
            else
            {
                this.SubtitlesCounts = subtitlesCounts;
            }

            // to ensure "subtitlesCount" is required (not null)
            if (subtitlesCount == null)
            {
                throw new InvalidDataException("subtitlesCount is a required property for FeatureEpisodeAttributes and cannot be null");
            }
            else
            {
                this.SubtitlesCount = subtitlesCount;
            }

            this.OriginalTitle = originalTitle;
            this.ParentImdbId = parentImdbId;
        }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets OriginalTitle
        /// </summary>
        [DataMember(Name="original_title", EmitDefaultValue=false)]
        public Object OriginalTitle { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name="year", EmitDefaultValue=true)]
        public string Year { get; set; }

        /// <summary>
        /// Gets or Sets ParentImdbId
        /// </summary>
        [DataMember(Name="parent_imdb_id", EmitDefaultValue=false)]
        public Object ParentImdbId { get; set; }

        /// <summary>
        /// Gets or Sets ParentTitle
        /// </summary>
        [DataMember(Name="parent_title", EmitDefaultValue=true)]
        public string ParentTitle { get; set; }

        /// <summary>
        /// Gets or Sets SeasonNumber
        /// </summary>
        [DataMember(Name="season_number", EmitDefaultValue=true)]
        public decimal SeasonNumber { get; set; }

        /// <summary>
        /// Gets or Sets EpisodeNumber
        /// </summary>
        [DataMember(Name="episode_number", EmitDefaultValue=true)]
        public decimal EpisodeNumber { get; set; }

        /// <summary>
        /// Gets or Sets ImdbId
        /// </summary>
        [DataMember(Name="imdb_id", EmitDefaultValue=true)]
        public decimal? ImdbId { get; set; }

        /// <summary>
        /// Gets or Sets TmdbId
        /// </summary>
        [DataMember(Name="tmdb_id", EmitDefaultValue=true)]
        public decimal? TmdbId { get; set; }

        /// <summary>
        /// Gets or Sets TitleAka
        /// </summary>
        [DataMember(Name="title_aka", EmitDefaultValue=true)]
        public List<Object> TitleAka { get; set; }

        /// <summary>
        /// Gets or Sets FeatureId
        /// </summary>
        [DataMember(Name="feature_id", EmitDefaultValue=true)]
        public string FeatureId { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=true)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets ImgUrl
        /// </summary>
        [DataMember(Name="img_url", EmitDefaultValue=true)]
        public string ImgUrl { get; set; }

        /// <summary>
        /// Gets or Sets SubtitlesCounts
        /// </summary>
        [DataMember(Name="subtitles_counts", EmitDefaultValue=true)]
        public FeatureEpisodeAttributesSubtitlesCounts SubtitlesCounts { get; set; }

        /// <summary>
        /// Gets or Sets SubtitlesCount
        /// </summary>
        [DataMember(Name="subtitles_count", EmitDefaultValue=true)]
        public decimal SubtitlesCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeatureEpisodeAttributes {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  OriginalTitle: ").Append(OriginalTitle).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  ParentImdbId: ").Append(ParentImdbId).Append("\n");
            sb.Append("  ParentTitle: ").Append(ParentTitle).Append("\n");
            sb.Append("  SeasonNumber: ").Append(SeasonNumber).Append("\n");
            sb.Append("  EpisodeNumber: ").Append(EpisodeNumber).Append("\n");
            sb.Append("  ImdbId: ").Append(ImdbId).Append("\n");
            sb.Append("  TmdbId: ").Append(TmdbId).Append("\n");
            sb.Append("  TitleAka: ").Append(TitleAka).Append("\n");
            sb.Append("  FeatureId: ").Append(FeatureId).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  ImgUrl: ").Append(ImgUrl).Append("\n");
            sb.Append("  SubtitlesCounts: ").Append(SubtitlesCounts).Append("\n");
            sb.Append("  SubtitlesCount: ").Append(SubtitlesCount).Append("\n");
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
            return this.Equals(input as FeatureEpisodeAttributes);
        }

        /// <summary>
        /// Returns true if FeatureEpisodeAttributes instances are equal
        /// </summary>
        /// <param name="input">Instance of FeatureEpisodeAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeatureEpisodeAttributes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.OriginalTitle == input.OriginalTitle ||
                    (this.OriginalTitle != null &&
                    this.OriginalTitle.Equals(input.OriginalTitle))
                ) && 
                (
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
                ) && 
                (
                    this.ParentImdbId == input.ParentImdbId ||
                    (this.ParentImdbId != null &&
                    this.ParentImdbId.Equals(input.ParentImdbId))
                ) && 
                (
                    this.ParentTitle == input.ParentTitle ||
                    (this.ParentTitle != null &&
                    this.ParentTitle.Equals(input.ParentTitle))
                ) && 
                (
                    this.SeasonNumber == input.SeasonNumber ||
                    (this.SeasonNumber != null &&
                    this.SeasonNumber.Equals(input.SeasonNumber))
                ) && 
                (
                    this.EpisodeNumber == input.EpisodeNumber ||
                    (this.EpisodeNumber != null &&
                    this.EpisodeNumber.Equals(input.EpisodeNumber))
                ) && 
                (
                    this.ImdbId == input.ImdbId ||
                    (this.ImdbId != null &&
                    this.ImdbId.Equals(input.ImdbId))
                ) && 
                (
                    this.TmdbId == input.TmdbId ||
                    (this.TmdbId != null &&
                    this.TmdbId.Equals(input.TmdbId))
                ) && 
                (
                    this.TitleAka == input.TitleAka ||
                    this.TitleAka != null &&
                    input.TitleAka != null &&
                    this.TitleAka.SequenceEqual(input.TitleAka)
                ) && 
                (
                    this.FeatureId == input.FeatureId ||
                    (this.FeatureId != null &&
                    this.FeatureId.Equals(input.FeatureId))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.ImgUrl == input.ImgUrl ||
                    (this.ImgUrl != null &&
                    this.ImgUrl.Equals(input.ImgUrl))
                ) && 
                (
                    this.SubtitlesCounts == input.SubtitlesCounts ||
                    (this.SubtitlesCounts != null &&
                    this.SubtitlesCounts.Equals(input.SubtitlesCounts))
                ) && 
                (
                    this.SubtitlesCount == input.SubtitlesCount ||
                    (this.SubtitlesCount != null &&
                    this.SubtitlesCount.Equals(input.SubtitlesCount))
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.OriginalTitle != null)
                    hashCode = hashCode * 59 + this.OriginalTitle.GetHashCode();
                if (this.Year != null)
                    hashCode = hashCode * 59 + this.Year.GetHashCode();
                if (this.ParentImdbId != null)
                    hashCode = hashCode * 59 + this.ParentImdbId.GetHashCode();
                if (this.ParentTitle != null)
                    hashCode = hashCode * 59 + this.ParentTitle.GetHashCode();
                if (this.SeasonNumber != null)
                    hashCode = hashCode * 59 + this.SeasonNumber.GetHashCode();
                if (this.EpisodeNumber != null)
                    hashCode = hashCode * 59 + this.EpisodeNumber.GetHashCode();
                if (this.ImdbId != null)
                    hashCode = hashCode * 59 + this.ImdbId.GetHashCode();
                if (this.TmdbId != null)
                    hashCode = hashCode * 59 + this.TmdbId.GetHashCode();
                if (this.TitleAka != null)
                    hashCode = hashCode * 59 + this.TitleAka.GetHashCode();
                if (this.FeatureId != null)
                    hashCode = hashCode * 59 + this.FeatureId.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.ImgUrl != null)
                    hashCode = hashCode * 59 + this.ImgUrl.GetHashCode();
                if (this.SubtitlesCounts != null)
                    hashCode = hashCode * 59 + this.SubtitlesCounts.GetHashCode();
                if (this.SubtitlesCount != null)
                    hashCode = hashCode * 59 + this.SubtitlesCount.GetHashCode();
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


            // Year (string) minLength
            if(this.Year != null && this.Year.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Year, length must be greater than 1.", new [] { "Year" });
            }


            // ParentTitle (string) minLength
            if(this.ParentTitle != null && this.ParentTitle.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ParentTitle, length must be greater than 1.", new [] { "ParentTitle" });
            }


            // FeatureId (string) minLength
            if(this.FeatureId != null && this.FeatureId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FeatureId, length must be greater than 1.", new [] { "FeatureId" });
            }


            // Url (string) minLength
            if(this.Url != null && this.Url.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Url, length must be greater than 1.", new [] { "Url" });
            }


            // ImgUrl (string) minLength
            if(this.ImgUrl != null && this.ImgUrl.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ImgUrl, length must be greater than 1.", new [] { "ImgUrl" });
            }

            yield break;
        }
    }

}
