// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.InMemory;
using Microsoft.Data.Entity.Utilities;

// ReSharper disable once CheckNamespace

namespace Microsoft.Data.Entity
{
    public static class InMemoryDbContextOptionsExtensions
    {
        public static void UseInMemoryStore([NotNull] this DbContextOptionsBuilder optionsBuilder, bool persist = true)
            => ((IOptionsBuilderExtender)Check.NotNull(optionsBuilder, nameof(optionsBuilder)))
                .AddOrUpdateExtension(
                    new InMemoryOptionsExtension { Persist = persist });
    }
}
