using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace MvcApplication1.Models
{
    [DataContract]
    public class Post
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string tags { get; set; }
        [DataMember]
        public string created_at { get; set; }
        [DataMember]
        public string creator_id { get; set; }
        [DataMember]
        public string author { get; set; }
        [DataMember]
        public string change { get; set; }
        [DataMember]
        public string source { get; set; }
        [DataMember]
        public string score { get; set; }
        [DataMember]
        public string md5 { get; set; }
        [DataMember]
        public string file_size { get; set; }
        [DataMember]
        public string file_url { get; set; }
        [DataMember]
        public string is_shown_in_index { get; set; }
        [DataMember]
        public string preview_url { get; set; }
        [DataMember]
        public string preview_width { get; set; }
        [DataMember]
        public string preview_height { get; set; }
        [DataMember]
        public string actual_preview_width { get; set; }
        [DataMember]
        public string actual_preview_height { get; set; }
        [DataMember]
        public string sample_url { get; set; }
        [DataMember]
        public string sample_width { get; set; }
        [DataMember]
        public string sample_height { get; set; }
        [DataMember]
        public string sample_file_size { get; set; }
        [DataMember]
        public string jpeg_url { get; set; }
        [DataMember]
        public string jpeg_width { get; set; }
        [DataMember]
        public string jpeg_height { get; set; }
        [DataMember]
        public string jpeg_file_size { get; set; }
        [DataMember]
        public string rating { get; set; }
        [DataMember]
        public string has_children { get; set; }
        [DataMember]
        public string parent_id { get; set; }
        [DataMember]
        public string status { get; set; }
        [DataMember]
        public string width { get; set; }
        [DataMember]
        public string height { get; set; }
        [DataMember]
        public string is_held { get; set; }
        [DataMember]
        public string frames_pending_string { get; set; }
        [DataMember]
        public string frames_pending { get; set; }
        [DataMember]
        public string frames_string { get; set; }
        [DataMember]
        public string frames { get; set; }
    }
}
