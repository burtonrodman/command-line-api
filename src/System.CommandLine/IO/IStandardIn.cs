﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace System.CommandLine.IO
{
    /// <summary>
    /// Represents a console's standard input stream.
    /// </summary>
    public interface IStandardIn
    {
        bool IsInputRedirected { get; }
    }
}