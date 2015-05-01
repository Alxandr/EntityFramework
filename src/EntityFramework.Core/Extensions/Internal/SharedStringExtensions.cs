// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Data.Entity.Utilities;
using JetBrains.Annotations;

namespace Microsoft.Data.Entity.Extensions.Internal
{
    public static class SharedStringExtensions
    {
        public static bool IsGeneratedName([NotNull] this string argument)
        {
            Check.NotNull(argument, nameof(argument));

            return argument.StartsWith("<generated>_");
        }
    }
}
