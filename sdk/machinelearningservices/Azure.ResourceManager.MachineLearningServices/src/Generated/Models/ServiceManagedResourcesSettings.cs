// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> The ServiceManagedResourcesSettings. </summary>
    public partial class ServiceManagedResourcesSettings
    {
        /// <summary> Initializes a new instance of ServiceManagedResourcesSettings. </summary>
        public ServiceManagedResourcesSettings()
        {
        }

        /// <summary> Initializes a new instance of ServiceManagedResourcesSettings. </summary>
        /// <param name="cosmosDb"> The settings for the service managed cosmosdb account. </param>
        internal ServiceManagedResourcesSettings(CosmosDbSettings cosmosDb)
        {
            CosmosDb = cosmosDb;
        }

        /// <summary> The settings for the service managed cosmosdb account. </summary>
        public CosmosDbSettings CosmosDb { get; set; }
    }
}
