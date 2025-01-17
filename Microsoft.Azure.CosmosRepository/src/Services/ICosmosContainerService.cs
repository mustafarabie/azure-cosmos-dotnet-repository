﻿// Copyright (c) IEvangelist. All rights reserved.
// Licensed under the MIT License.
using System.Threading.Tasks;
using Microsoft.Azure.Cosmos;

namespace Microsoft.Azure.CosmosRepository.Services
{
    /// <summary>
    /// Responsible for providing functions to work with containers
    /// </summary>
    public interface ICosmosContainerService
    {
        /// <summary>
        /// Gets a container for an <see cref="IItem"/>
        /// </summary>
        /// <param name="forceContainerSync"></param>
        /// <returns></returns>
        Task<Container> GetContainerAsync<TItem>(bool forceContainerSync = false) where TItem : IItem;
    }
}