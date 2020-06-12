﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using Microsoft.Azure.Cosmos;

namespace Microsoft.Health.CosmosDb.Features.Storage
{
    /// <summary>
    /// Context used for executing a cosmos query.
    /// </summary>
    public interface ICosmosQueryContext
    {
        /// <summary>
        /// Gets the SQL query.
        /// </summary>
        QueryDefinition SqlQuerySpec { get; }

        /// <summary>
        /// Gets the options.
        /// </summary>
        QueryRequestOptions FeedOptions { get; }

        /// <summary>
        /// Gets the continuation token.
        /// </summary>
        string ContinuationToken { get; }
    }
}
