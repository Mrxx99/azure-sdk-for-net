// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Properties of the disk to attach. </summary>
    public partial class AttachDiskProperties
    {
        /// <summary> Initializes a new instance of AttachDiskProperties. </summary>
        public AttachDiskProperties()
        {
        }

        /// <summary> The resource ID of the Lab virtual machine to which the disk is attached. </summary>
        public string LeasedByLabVmId { get; set; }
    }
}
