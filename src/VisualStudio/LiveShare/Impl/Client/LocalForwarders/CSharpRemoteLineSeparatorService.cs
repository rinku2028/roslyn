﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.Host;
using Microsoft.CodeAnalysis.Host.Mef;
using Microsoft.CodeAnalysis.Editor;
using System.Composition;

namespace Microsoft.VisualStudio.LanguageServices.LiveShare.Client.LocalForwarders
{
    [ExportLanguageServiceFactory(typeof(ILineSeparatorService), StringConstants.CSharpLspLanguageName), Shared]
    internal class CSharpLspLineSeparatorServiceFactory : ILanguageServiceFactory
    {
        [ImportingConstructor]
        public CSharpLspLineSeparatorServiceFactory()
        {
        }

        public ILanguageService CreateLanguageService(HostLanguageServices languageServices)
        {
            return languageServices.GetOriginalLanguageService<ILineSeparatorService>();
        }
    }
}
