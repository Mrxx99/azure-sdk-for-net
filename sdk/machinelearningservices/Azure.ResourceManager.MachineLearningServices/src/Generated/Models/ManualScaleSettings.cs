// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> The ManualScaleSettings. </summary>
    public partial class ManualScaleSettings : OnlineScaleSettings
    {
        /// <summary> Initializes a new instance of ManualScaleSettings. </summary>
        public ManualScaleSettings()
        {
            ScaleType = ScaleType.Manual;
        }

        /// <summary> Initializes a new instance of ManualScaleSettings. </summary>
        /// <param name="maxInstances"> . </param>
        /// <param name="minInstances"> . </param>
        /// <param name="scaleType"> . </param>
        /// <param name="instanceCount"> . </param>
        internal ManualScaleSettings(int? maxInstances, int? minInstances, ScaleType scaleType, int? instanceCount) : base(maxInstances, minInstances, scaleType)
        {
            InstanceCount = instanceCount;
            ScaleType = scaleType;
        }

        public int? InstanceCount { get; set; }
    }
}
