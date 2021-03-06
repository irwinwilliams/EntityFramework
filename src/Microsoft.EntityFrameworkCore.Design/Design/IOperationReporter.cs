﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;

namespace Microsoft.EntityFrameworkCore.Design
{
    public interface IOperationReporter
    {
        void WriteWarning([NotNull] string message);
        void WriteInformation([NotNull] string message);
        void WriteVerbose([NotNull] string message);
    }
}
