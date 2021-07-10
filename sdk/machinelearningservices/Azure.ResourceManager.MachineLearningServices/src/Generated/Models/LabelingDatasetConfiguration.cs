// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> Labeling dataset configuration definition. </summary>
    public partial class LabelingDatasetConfiguration
    {
        /// <summary> Initializes a new instance of LabelingDatasetConfiguration. </summary>
        public LabelingDatasetConfiguration()
        {
        }

        /// <summary> Initializes a new instance of LabelingDatasetConfiguration. </summary>
        /// <param name="assetName"> Name of the data asset to perform labeling. </param>
        /// <param name="datasetVersion"> AML dataset version. </param>
        /// <param name="incrementalDatasetRefreshEnabled"> Indicates whether to enable incremental dataset refresh. </param>
        internal LabelingDatasetConfiguration(string assetName, string datasetVersion, bool? incrementalDatasetRefreshEnabled)
        {
            AssetName = assetName;
            DatasetVersion = datasetVersion;
            IncrementalDatasetRefreshEnabled = incrementalDatasetRefreshEnabled;
        }

        /// <summary> Name of the data asset to perform labeling. </summary>
        public string AssetName { get; set; }
        /// <summary> AML dataset version. </summary>
        public string DatasetVersion { get; set; }
        /// <summary> Indicates whether to enable incremental dataset refresh. </summary>
        public bool? IncrementalDatasetRefreshEnabled { get; set; }
    }
}
