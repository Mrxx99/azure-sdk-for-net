// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> The resource requirements for the container (cpu and memory). </summary>
    public partial class ContainerResourceRequirements
    {
        /// <summary> Initializes a new instance of ContainerResourceRequirements. </summary>
        public ContainerResourceRequirements()
        {
        }

        /// <summary> Initializes a new instance of ContainerResourceRequirements. </summary>
        /// <param name="cpu">
        /// The minimum amount of CPU cores to be used by the container. More info:
        /// https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/.
        /// </param>
        /// <param name="cpuLimit">
        /// The maximum amount of CPU cores allowed to be used by the container. More info:
        /// https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/.
        /// </param>
        /// <param name="memoryInGB">
        /// The minimum amount of memory (in GB) to be used by the container. More info:
        /// https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/.
        /// </param>
        /// <param name="memoryInGBLimit">
        /// The maximum amount of memory (in GB) allowed to be used by the container. More info:
        /// https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/.
        /// </param>
        /// <param name="gpu"> The number of GPU cores in the container. </param>
        /// <param name="fpga"> The number of FPGA PCIE devices exposed to the container. Must be multiple of 2. </param>
        internal ContainerResourceRequirements(double? cpu, double? cpuLimit, double? memoryInGB, double? memoryInGBLimit, int? gpu, int? fpga)
        {
            Cpu = cpu;
            CpuLimit = cpuLimit;
            MemoryInGB = memoryInGB;
            MemoryInGBLimit = memoryInGBLimit;
            Gpu = gpu;
            Fpga = fpga;
        }

        /// <summary>
        /// The minimum amount of CPU cores to be used by the container. More info:
        /// https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/.
        /// </summary>
        public double? Cpu { get; set; }
        /// <summary>
        /// The maximum amount of CPU cores allowed to be used by the container. More info:
        /// https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/.
        /// </summary>
        public double? CpuLimit { get; set; }
        /// <summary>
        /// The minimum amount of memory (in GB) to be used by the container. More info:
        /// https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/.
        /// </summary>
        public double? MemoryInGB { get; set; }
        /// <summary>
        /// The maximum amount of memory (in GB) allowed to be used by the container. More info:
        /// https://kubernetes.io/docs/concepts/configuration/manage-compute-resources-container/.
        /// </summary>
        public double? MemoryInGBLimit { get; set; }
        /// <summary> The number of GPU cores in the container. </summary>
        public int? Gpu { get; set; }
        /// <summary> The number of FPGA PCIE devices exposed to the container. Must be multiple of 2. </summary>
        public int? Fpga { get; set; }
    }
}
