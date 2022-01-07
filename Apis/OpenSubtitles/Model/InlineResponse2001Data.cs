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
    /// InlineResponse2001Data
    /// </summary>
    [DataContract]
    public partial class InlineResponse2001Data :  IEquatable<InlineResponse2001Data>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2001Data" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineResponse2001Data() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2001Data" /> class.
        /// </summary>
        /// <param name="outputFormats">outputFormats (required).</param>
        public InlineResponse2001Data(List<Object> outputFormats = default(List<Object>))
        {
            // to ensure "outputFormats" is required (not null)
            if (outputFormats == null)
            {
                throw new InvalidDataException("outputFormats is a required property for InlineResponse2001Data and cannot be null");
            }
            else
            {
                this.OutputFormats = outputFormats;
            }

        }

        /// <summary>
        /// Gets or Sets OutputFormats
        /// </summary>
        [DataMember(Name="output_formats", EmitDefaultValue=true)]
        public List<Object> OutputFormats { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2001Data {\n");
            sb.Append("  OutputFormats: ").Append(OutputFormats).Append("\n");
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
            return this.Equals(input as InlineResponse2001Data);
        }

        /// <summary>
        /// Returns true if InlineResponse2001Data instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse2001Data to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2001Data input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OutputFormats == input.OutputFormats ||
                    this.OutputFormats != null &&
                    input.OutputFormats != null &&
                    this.OutputFormats.SequenceEqual(input.OutputFormats)
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
                if (this.OutputFormats != null)
                    hashCode = hashCode * 59 + this.OutputFormats.GetHashCode();
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