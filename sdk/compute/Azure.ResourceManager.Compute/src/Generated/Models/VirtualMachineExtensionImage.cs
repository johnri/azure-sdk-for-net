// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a Virtual Machine Extension Image. </summary>
    public partial class VirtualMachineExtensionImage : Resource
    {
        /// <summary> Initializes a new instance of VirtualMachineExtensionImage. </summary>
        /// <param name="location"> Resource location. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        public VirtualMachineExtensionImage(string location) : base(location)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }
        }

        /// <summary> Initializes a new instance of VirtualMachineExtensionImage. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="operatingSystem"> The operating system this extension supports. </param>
        /// <param name="computeRole"> The type of role (IaaS or PaaS) this extension supports. </param>
        /// <param name="handlerSchema"> The schema defined by publisher, where extension consumers should provide settings in a matching schema. </param>
        /// <param name="vmScaleSetEnabled"> Whether the extension can be used on xRP VMScaleSets. By default existing extensions are usable on scalesets, but there might be cases where a publisher wants to explicitly indicate the extension is only enabled for CRP VMs but not VMSS. </param>
        /// <param name="supportsMultipleExtensions"> Whether the handler can support multiple extensions. </param>
        internal VirtualMachineExtensionImage(string id, string name, string type, string location, IDictionary<string, string> tags, string operatingSystem, string computeRole, string handlerSchema, bool? vmScaleSetEnabled, bool? supportsMultipleExtensions) : base(id, name, type, location, tags)
        {
            OperatingSystem = operatingSystem;
            ComputeRole = computeRole;
            HandlerSchema = handlerSchema;
            VmScaleSetEnabled = vmScaleSetEnabled;
            SupportsMultipleExtensions = supportsMultipleExtensions;
        }

        /// <summary> The operating system this extension supports. </summary>
        public string OperatingSystem { get; set; }
        /// <summary> The type of role (IaaS or PaaS) this extension supports. </summary>
        public string ComputeRole { get; set; }
        /// <summary> The schema defined by publisher, where extension consumers should provide settings in a matching schema. </summary>
        public string HandlerSchema { get; set; }
        /// <summary> Whether the extension can be used on xRP VMScaleSets. By default existing extensions are usable on scalesets, but there might be cases where a publisher wants to explicitly indicate the extension is only enabled for CRP VMs but not VMSS. </summary>
        public bool? VmScaleSetEnabled { get; set; }
        /// <summary> Whether the handler can support multiple extensions. </summary>
        public bool? SupportsMultipleExtensions { get; set; }
    }
}
