// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ManagedClusterSKU
    {
        /// <summary>
        /// Initializes a new instance of the ManagedClusterSKU class.
        /// </summary>
        public ManagedClusterSKU()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedClusterSKU class.
        /// </summary>
        /// <param name="name">Name of a managed cluster SKU. Possible values
        /// include: 'Basic'</param>
        /// <param name="tier">Tier of a managed cluster SKU. Possible values
        /// include: 'Paid', 'Free'</param>
        public ManagedClusterSKU(string name = default(string), string tier = default(string))
        {
            Name = name;
            Tier = tier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of a managed cluster SKU. Possible values
        /// include: 'Basic'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets tier of a managed cluster SKU. Possible values
        /// include: 'Paid', 'Free'
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

    }
}
