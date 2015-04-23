// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.Data.Entity.FunctionalTests;

namespace Microsoft.Data.Entity.InMemory.FunctionalTests
{
    public class AsNoTrackingInMemoryTest : AsNoTrackingTestBase<NorthwindQueryInMemoryFixture>
    {
        public override void Applied_to_projection()
        {
            base.Applied_to_projection();
        }

        public AsNoTrackingInMemoryTest(NorthwindQueryInMemoryFixture fixture)
            : base(fixture)
        {
        }
    }
}
