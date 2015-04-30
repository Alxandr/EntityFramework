﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.Data.Entity.ChangeTracking.Internal;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Metadata.Internal;
using Microsoft.Data.Entity.Query;
using Microsoft.Data.Entity.Relational;
using Microsoft.Data.Entity.Relational.Query;
using Microsoft.Data.Entity.Relational.Query.Methods;
using Microsoft.Data.Entity.Sqlite.Query;
using Microsoft.Data.Entity.Sqlite.Update;
using Microsoft.Framework.Logging;

namespace Microsoft.Data.Entity.Sqlite
{
    public class SqliteDataStore : RelationalDataStore, ISqliteDataStore
    {
        public SqliteDataStore(
            [NotNull] IModel model,
            [NotNull] IEntityKeyFactorySource entityKeyFactorySource,
            [NotNull] IEntityMaterializerSource entityMaterializerSource,
            [NotNull] IClrAccessorSource<IClrPropertyGetter> clrPropertyGetterSource,
            [NotNull] ISqliteConnection connection,
            [NotNull] ISqliteCommandBatchPreparer batchPreparer,
            [NotNull] ISqliteBatchExecutor batchExecutor,
            [NotNull] IDbContextOptions options,
            [NotNull] ILoggerFactory loggerFactory,
            [NotNull] ISqliteValueBufferFactoryFactory valueBufferFactoryFactory)
            : base(
                  model,
                  entityKeyFactorySource,
                  entityMaterializerSource,
                  clrPropertyGetterSource,
                  connection,
                  batchPreparer,
                  batchExecutor,
                  options,
                  loggerFactory,
                  valueBufferFactoryFactory)
        {
        }

        protected override RelationalQueryCompilationContext CreateQueryCompilationContext(
            ILinqOperatorProvider linqOperatorProvider,
            IResultOperatorHandler resultOperatorHandler,
            IQueryMethodProvider queryMethodProvider,
            IMethodCallTranslator methodCallTranslator) =>
            new SqliteQueryCompilationContext(
                Model,
                Logger,
                linqOperatorProvider,
                resultOperatorHandler,
                EntityMaterializerSource,
                ClrPropertyGetterSource,
                EntityKeyFactorySource,
                queryMethodProvider,
                methodCallTranslator,
                (ISqliteValueBufferFactoryFactory)ValueBufferFactoryFactory);
    }
}
