// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> Properties of a labeling job. </summary>
    public partial class LabelingJobMediaProperties
    {
        /// <summary> Initializes a new instance of LabelingJobMediaProperties. </summary>
        public LabelingJobMediaProperties()
        {
        }

        /// <summary> Initializes a new instance of LabelingJobMediaProperties. </summary>
        /// <param name="mediaType"> Media type of the job. </param>
        internal LabelingJobMediaProperties(MediaType mediaType)
        {
            MediaType = mediaType;
        }

        /// <summary> Media type of the job. </summary>
        internal MediaType MediaType { get; set; }
    }
}
