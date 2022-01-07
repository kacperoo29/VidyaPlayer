using System.Runtime.Serialization;

namespace OpenSubtitles.Model
{
    public class RelatedLink
    {
        [DataMember(Name = "label", EmitDefaultValue = true)]
        public string Label { get; set; }

        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        [DataMember(Name = "img_url", EmitDefaultValue = true)]
        public string ImgUrl { get; set; }
    }
}