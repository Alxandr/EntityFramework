// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.Data.Entity.Metadata.Builders;
using Microsoft.Data.Entity.Utilities;

namespace Microsoft.Data.Entity
{
    public static class RelationalReferenceReferenceBuilderExtensions
    {
        public static ReferenceReferenceBuilder Name(
            [NotNull] this ReferenceReferenceBuilder referenceReferenceBuilder,
            [CanBeNull] string name)
        {
            Check.NotNull(referenceReferenceBuilder, nameof(referenceReferenceBuilder));
            Check.NullButNotEmpty(name, nameof(name));

            referenceReferenceBuilder.Metadata.Relational().Name = name;

            return referenceReferenceBuilder;
        }

        public static ReferenceReferenceBuilder<TEntity, TRelatedEntity> Name<TEntity, TRelatedEntity>(
            [NotNull] this ReferenceReferenceBuilder<TEntity, TRelatedEntity> referenceReferenceBuilder,
            [CanBeNull] string name)
            where TEntity : class
            => (ReferenceReferenceBuilder<TEntity, TRelatedEntity>)Name(
                (ReferenceReferenceBuilder)referenceReferenceBuilder, name);
    }
}
