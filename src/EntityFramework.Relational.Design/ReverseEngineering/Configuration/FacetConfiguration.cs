﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.Data.Entity.Utilities;

namespace Microsoft.Data.Entity.Relational.Design.ReverseEngineering.Configuration
{
    public class FacetConfiguration
    {
        public FacetConfiguration([NotNull]string methodBody)
        {
            Check.NotNull(methodBody, nameof(methodBody));

            MethodBody = methodBody;
        }

        public FacetConfiguration([NotNull]string @for, [NotNull]string methodBody)
        {
            Check.NotNull(@for, nameof(@for));
            Check.NotNull(methodBody, nameof(methodBody));

            For = @for;
            MethodBody = methodBody;
        }

        public virtual string For { get;[param: NotNull]private set; }
        public virtual string MethodBody { get;[param: NotNull]private set; }

        public override string ToString()
        {
            return (For == null ? MethodBody : For + "()." + MethodBody);
        }
    }
}
