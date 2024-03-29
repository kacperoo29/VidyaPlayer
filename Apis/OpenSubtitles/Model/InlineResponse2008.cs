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
    /// InlineResponse2008
    /// </summary>
    [DataContract]
    public partial class InlineResponse2008 :  IEquatable<InlineResponse2008>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2008" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineResponse2008() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2008" /> class.
        /// </summary>
        /// <param name="link">link (required).</param>
        /// <param name="fname">fname (required).</param>
        /// <param name="requests">requests (required).</param>
        /// <param name="allowed">allowed (required).</param>
        /// <param name="remaining">remaining (required).</param>
        /// <param name="message">message (required).</param>
        public InlineResponse2008(string link = default(string), string fname = default(string), decimal requests = default(decimal), decimal allowed = default(decimal), decimal remaining = default(decimal), string message = default(string))
        {
            // to ensure "link" is required (not null)
            if (link == null)
            {
                throw new InvalidDataException("link is a required property for InlineResponse2008 and cannot be null");
            }
            else
            {
                this.Link = link;
            }

            // to ensure "fname" is required (not null)
            if (fname == null)
            {
                throw new InvalidDataException("fname is a required property for InlineResponse2008 and cannot be null");
            }
            else
            {
                this.Fname = fname;
            }

            // to ensure "requests" is required (not null)
            if (requests == null)
            {
                throw new InvalidDataException("requests is a required property for InlineResponse2008 and cannot be null");
            }
            else
            {
                this.Requests = requests;
            }

            // to ensure "allowed" is required (not null)
            if (allowed == null)
            {
                throw new InvalidDataException("allowed is a required property for InlineResponse2008 and cannot be null");
            }
            else
            {
                this.Allowed = allowed;
            }

            // to ensure "remaining" is required (not null)
            if (remaining == null)
            {
                throw new InvalidDataException("remaining is a required property for InlineResponse2008 and cannot be null");
            }
            else
            {
                this.Remaining = remaining;
            }

            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new InvalidDataException("message is a required property for InlineResponse2008 and cannot be null");
            }
            else
            {
                this.Message = message;
            }

        }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name="link", EmitDefaultValue=true)]
        public string Link { get; set; }

        /// <summary>
        /// Gets or Sets Fname
        /// </summary>
        [DataMember(Name="fname", EmitDefaultValue=true)]
        public string Fname { get; set; }

        /// <summary>
        /// Gets or Sets Requests
        /// </summary>
        [DataMember(Name="requests", EmitDefaultValue=true)]
        public decimal Requests { get; set; }

        /// <summary>
        /// Gets or Sets Allowed
        /// </summary>
        [DataMember(Name="allowed", EmitDefaultValue=true)]
        public decimal Allowed { get; set; }

        /// <summary>
        /// Gets or Sets Remaining
        /// </summary>
        [DataMember(Name="remaining", EmitDefaultValue=true)]
        public decimal Remaining { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=true)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2008 {\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Fname: ").Append(Fname).Append("\n");
            sb.Append("  Requests: ").Append(Requests).Append("\n");
            sb.Append("  Allowed: ").Append(Allowed).Append("\n");
            sb.Append("  Remaining: ").Append(Remaining).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as InlineResponse2008);
        }

        /// <summary>
        /// Returns true if InlineResponse2008 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse2008 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2008 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Link == input.Link ||
                    (this.Link != null &&
                    this.Link.Equals(input.Link))
                ) && 
                (
                    this.Fname == input.Fname ||
                    (this.Fname != null &&
                    this.Fname.Equals(input.Fname))
                ) && 
                (
                    this.Requests == input.Requests ||
                    (this.Requests != null &&
                    this.Requests.Equals(input.Requests))
                ) && 
                (
                    this.Allowed == input.Allowed ||
                    (this.Allowed != null &&
                    this.Allowed.Equals(input.Allowed))
                ) && 
                (
                    this.Remaining == input.Remaining ||
                    (this.Remaining != null &&
                    this.Remaining.Equals(input.Remaining))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Link != null)
                    hashCode = hashCode * 59 + this.Link.GetHashCode();
                if (this.Fname != null)
                    hashCode = hashCode * 59 + this.Fname.GetHashCode();
                if (this.Requests != null)
                    hashCode = hashCode * 59 + this.Requests.GetHashCode();
                if (this.Allowed != null)
                    hashCode = hashCode * 59 + this.Allowed.GetHashCode();
                if (this.Remaining != null)
                    hashCode = hashCode * 59 + this.Remaining.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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

            // Link (string) minLength
            if(this.Link != null && this.Link.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Link, length must be greater than 1.", new [] { "Link" });
            }


            // Fname (string) minLength
            if(this.Fname != null && this.Fname.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Fname, length must be greater than 1.", new [] { "Fname" });
            }

            yield break;
        }
    }

}
