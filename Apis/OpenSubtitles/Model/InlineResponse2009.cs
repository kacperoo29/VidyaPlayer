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
    /// InlineResponse2009
    /// </summary>
    [DataContract]
    public partial class InlineResponse2009 :  IEquatable<InlineResponse2009>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2009" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineResponse2009() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2009" /> class.
        /// </summary>
        /// <param name="title">title (required).</param>
        /// <param name="year">year (required).</param>
        /// <param name="language">language (required).</param>
        /// <param name="subtitleLanguage">subtitleLanguage (required).</param>
        /// <param name="screenSize">screenSize (required).</param>
        /// <param name="streamingService">streamingService (required).</param>
        /// <param name="source">source (required).</param>
        /// <param name="other">other (required).</param>
        /// <param name="audioCodec">audioCodec (required).</param>
        /// <param name="audioChannels">audioChannels (required).</param>
        /// <param name="videoCodec">videoCodec (required).</param>
        /// <param name="releaseGroup">releaseGroup (required).</param>
        /// <param name="type">type (required).</param>
        public InlineResponse2009(string title = default(string), decimal year = default(decimal), string language = default(string), string subtitleLanguage = default(string), string screenSize = default(string), string streamingService = default(string), string source = default(string), string other = default(string), string audioCodec = default(string), string audioChannels = default(string), string videoCodec = default(string), string releaseGroup = default(string), string type = default(string))
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for InlineResponse2009 and cannot be null");
            }
            else
            {
                this.Title = title;
            }

            // to ensure "year" is required (not null)
            if (year == null)
            {
                throw new InvalidDataException("year is a required property for InlineResponse2009 and cannot be null");
            }
            else
            {
                this.Year = year;
            }

            // to ensure "language" is required (not null)
            if (language == null)
            {
                throw new InvalidDataException("language is a required property for InlineResponse2009 and cannot be null");
            }
            else
            {
                this.Language = language;
            }

            // to ensure "subtitleLanguage" is required (not null)
            if (subtitleLanguage == null)
            {
                throw new InvalidDataException("subtitleLanguage is a required property for InlineResponse2009 and cannot be null");
            }
            else
            {
                this.SubtitleLanguage = subtitleLanguage;
            }

            // to ensure "screenSize" is required (not null)
            if (screenSize == null)
            {
                throw new InvalidDataException("screenSize is a required property for InlineResponse2009 and cannot be null");
            }
            else
            {
                this.ScreenSize = screenSize;
            }

            // to ensure "streamingService" is required (not null)
            if (streamingService == null)
            {
                throw new InvalidDataException("streamingService is a required property for InlineResponse2009 and cannot be null");
            }
            else
            {
                this.StreamingService = streamingService;
            }

            // to ensure "source" is required (not null)
            if (source == null)
            {
                throw new InvalidDataException("source is a required property for InlineResponse2009 and cannot be null");
            }
            else
            {
                this.Source = source;
            }

            // to ensure "other" is required (not null)
            if (other == null)
            {
                throw new InvalidDataException("other is a required property for InlineResponse2009 and cannot be null");
            }
            else
            {
                this.Other = other;
            }

            // to ensure "audioCodec" is required (not null)
            if (audioCodec == null)
            {
                throw new InvalidDataException("audioCodec is a required property for InlineResponse2009 and cannot be null");
            }
            else
            {
                this.AudioCodec = audioCodec;
            }

            // to ensure "audioChannels" is required (not null)
            if (audioChannels == null)
            {
                throw new InvalidDataException("audioChannels is a required property for InlineResponse2009 and cannot be null");
            }
            else
            {
                this.AudioChannels = audioChannels;
            }

            // to ensure "videoCodec" is required (not null)
            if (videoCodec == null)
            {
                throw new InvalidDataException("videoCodec is a required property for InlineResponse2009 and cannot be null");
            }
            else
            {
                this.VideoCodec = videoCodec;
            }

            // to ensure "releaseGroup" is required (not null)
            if (releaseGroup == null)
            {
                throw new InvalidDataException("releaseGroup is a required property for InlineResponse2009 and cannot be null");
            }
            else
            {
                this.ReleaseGroup = releaseGroup;
            }

            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for InlineResponse2009 and cannot be null");
            }
            else
            {
                this.Type = type;
            }

        }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name="year", EmitDefaultValue=true)]
        public decimal Year { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=true)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or Sets SubtitleLanguage
        /// </summary>
        [DataMember(Name="subtitle_language", EmitDefaultValue=true)]
        public string SubtitleLanguage { get; set; }

        /// <summary>
        /// Gets or Sets ScreenSize
        /// </summary>
        [DataMember(Name="screen_size", EmitDefaultValue=true)]
        public string ScreenSize { get; set; }

        /// <summary>
        /// Gets or Sets StreamingService
        /// </summary>
        [DataMember(Name="streaming_service", EmitDefaultValue=true)]
        public string StreamingService { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=true)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or Sets Other
        /// </summary>
        [DataMember(Name="other", EmitDefaultValue=true)]
        public string Other { get; set; }

        /// <summary>
        /// Gets or Sets AudioCodec
        /// </summary>
        [DataMember(Name="audio_codec", EmitDefaultValue=true)]
        public string AudioCodec { get; set; }

        /// <summary>
        /// Gets or Sets AudioChannels
        /// </summary>
        [DataMember(Name="audio_channels", EmitDefaultValue=true)]
        public string AudioChannels { get; set; }

        /// <summary>
        /// Gets or Sets VideoCodec
        /// </summary>
        [DataMember(Name="video_codec", EmitDefaultValue=true)]
        public string VideoCodec { get; set; }

        /// <summary>
        /// Gets or Sets ReleaseGroup
        /// </summary>
        [DataMember(Name="release_group", EmitDefaultValue=true)]
        public string ReleaseGroup { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2009 {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  SubtitleLanguage: ").Append(SubtitleLanguage).Append("\n");
            sb.Append("  ScreenSize: ").Append(ScreenSize).Append("\n");
            sb.Append("  StreamingService: ").Append(StreamingService).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Other: ").Append(Other).Append("\n");
            sb.Append("  AudioCodec: ").Append(AudioCodec).Append("\n");
            sb.Append("  AudioChannels: ").Append(AudioChannels).Append("\n");
            sb.Append("  VideoCodec: ").Append(VideoCodec).Append("\n");
            sb.Append("  ReleaseGroup: ").Append(ReleaseGroup).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as InlineResponse2009);
        }

        /// <summary>
        /// Returns true if InlineResponse2009 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse2009 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2009 input)
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
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.SubtitleLanguage == input.SubtitleLanguage ||
                    (this.SubtitleLanguage != null &&
                    this.SubtitleLanguage.Equals(input.SubtitleLanguage))
                ) && 
                (
                    this.ScreenSize == input.ScreenSize ||
                    (this.ScreenSize != null &&
                    this.ScreenSize.Equals(input.ScreenSize))
                ) && 
                (
                    this.StreamingService == input.StreamingService ||
                    (this.StreamingService != null &&
                    this.StreamingService.Equals(input.StreamingService))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Other == input.Other ||
                    (this.Other != null &&
                    this.Other.Equals(input.Other))
                ) && 
                (
                    this.AudioCodec == input.AudioCodec ||
                    (this.AudioCodec != null &&
                    this.AudioCodec.Equals(input.AudioCodec))
                ) && 
                (
                    this.AudioChannels == input.AudioChannels ||
                    (this.AudioChannels != null &&
                    this.AudioChannels.Equals(input.AudioChannels))
                ) && 
                (
                    this.VideoCodec == input.VideoCodec ||
                    (this.VideoCodec != null &&
                    this.VideoCodec.Equals(input.VideoCodec))
                ) && 
                (
                    this.ReleaseGroup == input.ReleaseGroup ||
                    (this.ReleaseGroup != null &&
                    this.ReleaseGroup.Equals(input.ReleaseGroup))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Year != null)
                    hashCode = hashCode * 59 + this.Year.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.SubtitleLanguage != null)
                    hashCode = hashCode * 59 + this.SubtitleLanguage.GetHashCode();
                if (this.ScreenSize != null)
                    hashCode = hashCode * 59 + this.ScreenSize.GetHashCode();
                if (this.StreamingService != null)
                    hashCode = hashCode * 59 + this.StreamingService.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.Other != null)
                    hashCode = hashCode * 59 + this.Other.GetHashCode();
                if (this.AudioCodec != null)
                    hashCode = hashCode * 59 + this.AudioCodec.GetHashCode();
                if (this.AudioChannels != null)
                    hashCode = hashCode * 59 + this.AudioChannels.GetHashCode();
                if (this.VideoCodec != null)
                    hashCode = hashCode * 59 + this.VideoCodec.GetHashCode();
                if (this.ReleaseGroup != null)
                    hashCode = hashCode * 59 + this.ReleaseGroup.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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


            // Language (string) minLength
            if(this.Language != null && this.Language.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Language, length must be greater than 1.", new [] { "Language" });
            }


            // SubtitleLanguage (string) minLength
            if(this.SubtitleLanguage != null && this.SubtitleLanguage.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SubtitleLanguage, length must be greater than 1.", new [] { "SubtitleLanguage" });
            }


            // ScreenSize (string) minLength
            if(this.ScreenSize != null && this.ScreenSize.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ScreenSize, length must be greater than 1.", new [] { "ScreenSize" });
            }


            // StreamingService (string) minLength
            if(this.StreamingService != null && this.StreamingService.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StreamingService, length must be greater than 1.", new [] { "StreamingService" });
            }


            // Source (string) minLength
            if(this.Source != null && this.Source.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Source, length must be greater than 1.", new [] { "Source" });
            }


            // Other (string) minLength
            if(this.Other != null && this.Other.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Other, length must be greater than 1.", new [] { "Other" });
            }


            // AudioCodec (string) minLength
            if(this.AudioCodec != null && this.AudioCodec.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AudioCodec, length must be greater than 1.", new [] { "AudioCodec" });
            }


            // AudioChannels (string) minLength
            if(this.AudioChannels != null && this.AudioChannels.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AudioChannels, length must be greater than 1.", new [] { "AudioChannels" });
            }


            // VideoCodec (string) minLength
            if(this.VideoCodec != null && this.VideoCodec.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VideoCodec, length must be greater than 1.", new [] { "VideoCodec" });
            }


            // ReleaseGroup (string) minLength
            if(this.ReleaseGroup != null && this.ReleaseGroup.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReleaseGroup, length must be greater than 1.", new [] { "ReleaseGroup" });
            }


            // Type (string) minLength
            if(this.Type != null && this.Type.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, length must be greater than 1.", new [] { "Type" });
            }

            yield break;
        }
    }

}
