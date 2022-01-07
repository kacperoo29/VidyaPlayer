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
    /// InlineResponse2005
    /// </summary>
    [DataContract]
    public partial class InlineResponse2005 :  IEquatable<InlineResponse2005>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2005" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineResponse2005() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2005" /> class.
        /// </summary>
        /// <param name="totalPages">totalPages (required).</param>
        /// <param name="totalCount">totalCount (required).</param>
        /// <param name="page">page (required).</param>
        /// <param name="data">data (required).</param>
        public InlineResponse2005(decimal totalPages = default(decimal), decimal totalCount = default(decimal), decimal page = default(decimal), List<Subtitle> data = default(List<Subtitle>))
        {
            // to ensure "totalPages" is required (not null)
            if (totalPages == null)
            {
                throw new InvalidDataException("totalPages is a required property for InlineResponse2005 and cannot be null");
            }
            else
            {
                this.TotalPages = totalPages;
            }

            // to ensure "totalCount" is required (not null)
            if (totalCount == null)
            {
                throw new InvalidDataException("totalCount is a required property for InlineResponse2005 and cannot be null");
            }
            else
            {
                this.TotalCount = totalCount;
            }

            // to ensure "page" is required (not null)
            if (page == null)
            {
                throw new InvalidDataException("page is a required property for InlineResponse2005 and cannot be null");
            }
            else
            {
                this.Page = page;
            }

            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new InvalidDataException("data is a required property for InlineResponse2005 and cannot be null");
            }
            else
            {
                this.Data = data;
            }

        }

        /// <summary>
        /// Gets or Sets TotalPages
        /// </summary>
        [DataMember(Name="total_pages", EmitDefaultValue=true)]
        public decimal TotalPages { get; set; }

        /// <summary>
        /// Gets or Sets TotalCount
        /// </summary>
        [DataMember(Name="total_count", EmitDefaultValue=true)]
        public decimal TotalCount { get; set; }

        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [DataMember(Name="page", EmitDefaultValue=true)]
        public decimal Page { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=true)]
        public List<Subtitle> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2005 {\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as InlineResponse2005);
        }

        /// <summary>
        /// Returns true if InlineResponse2005 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse2005 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2005 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalPages == input.TotalPages ||
                    (this.TotalPages != null &&
                    this.TotalPages.Equals(input.TotalPages))
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
                ) && 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
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
                if (this.TotalPages != null)
                    hashCode = hashCode * 59 + this.TotalPages.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
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
