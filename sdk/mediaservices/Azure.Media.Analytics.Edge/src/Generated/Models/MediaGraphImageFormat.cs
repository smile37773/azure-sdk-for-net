// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Media.Analytics.Edge.Models
{
    /// <summary> Encoding settings for an image. </summary>
    public partial class MediaGraphImageFormat
    {
        /// <summary> Initializes a new instance of MediaGraphImageFormat. </summary>
        public MediaGraphImageFormat()
        {
        }

        /// <summary> Initializes a new instance of MediaGraphImageFormat. </summary>
        /// <param name="type"> The discriminator for derived types. </param>
        internal MediaGraphImageFormat(string type)
        {
            Type = type;
        }

        /// <summary> The discriminator for derived types. </summary>
        internal string Type { get; set; }
    }
}
