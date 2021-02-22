// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Build", "CA1305:The behavior of 'string.Format(string, object, object)' could vary based on the current user's locale settings. Replace this call in 'CamelCaseFilter.IncrementToken()' with a call to 'string.Format(IFormatProvider, string, params object[])'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Indexing.CamelCaseFilter.IncrementToken~System.Boolean")]
[assembly: SuppressMessage("Build", "CA2000:Call System.IDisposable.Dispose on object created by 'new LowerCaseFilter(new CamelCaseFilter(new DotTokenizer(reader)))' before all references to it are out of scope.", Justification = "The responsibility to dispose the object is transferred to another object or wrapper that's created in the method and returned to the caller", Scope = "member", Target = "~M:NuGet.Indexing.DescriptionAnalyzer.TokenStream(System.String,System.IO.TextReader)~Lucene.Net.Analysis.TokenStream")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'IEnumerable<IPackageSearchMetadata> DownloadCountResultsIndexer.ProcessUnrankedEntries(IEnumerable<IPackageSearchMetadata> entries, IDictionary<string, long> ranking)', validate parameter 'ranking' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Indexing.DownloadCountResultsIndexer.ProcessUnrankedEntries(System.Collections.Generic.IEnumerable{NuGet.Protocol.Core.Types.IPackageSearchMetadata},System.Collections.Generic.IDictionary{System.String,System.Int64})~System.Collections.Generic.IEnumerable{NuGet.Protocol.Core.Types.IPackageSearchMetadata}")]
[assembly: SuppressMessage("Build", "CA2000:Call System.IDisposable.Dispose on object created by 'new CamelCaseFilter(new DotTokenizer(reader))' before all references to it are out of scope.", Justification = "The responsibility to dispose the object is transferred to another object or wrapper that's created in the method and returned to the caller", Scope = "member", Target = "~M:NuGet.Indexing.IdentifierAnalyzer.TokenStream(System.String,System.IO.TextReader)~Lucene.Net.Analysis.TokenStream")]
[assembly: SuppressMessage("Build", "CA2000:Call System.IDisposable.Dispose on object created by 'new KeywordTokenizer(reader)' before all references to it are out of scope.", Justification = "The responsibility to dispose the object is transferred to another object or wrapper that's created in the method and returned to the caller", Scope = "member", Target = "~M:NuGet.Indexing.IdentifierKeywordAnalyzer.TokenStream(System.String,System.IO.TextReader)~Lucene.Net.Analysis.TokenStream")]
[assembly: SuppressMessage("Build", "CA1308:In method 'ConstructQuery', replace the call to 'ToLowerInvariant' with 'ToUpperInvariant'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Indexing.NuGetQuery.ConstructQuery(System.Collections.Generic.Dictionary{System.String,System.Collections.Generic.HashSet{System.String}})~Lucene.Net.Search.Query")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'Query NuGetQuery.MakeQuery(string q)', validate parameter 'q' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Indexing.NuGetQuery.MakeQuery(System.String)~Lucene.Net.Search.Query")]
[assembly: SuppressMessage("Build", "CA2000:Call System.IDisposable.Dispose on object created by 'new KeywordTokenizer(reader)' before all references to it are out of scope.", Justification = "The responsibility to dispose the object is transferred to another object or wrapper that's created in the method and returned to the caller", Scope = "member", Target = "~M:NuGet.Indexing.OwnerAnalyzer.TokenStream(System.String,System.IO.TextReader)~Lucene.Net.Analysis.TokenStream")]
[assembly: SuppressMessage("Build", "CA2000:Call System.IDisposable.Dispose on object created by 'new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30)' before all references to it are out of scope.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Indexing.PackageAnalyzer.#ctor")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'IEnumerable<IPackageSearchMetadata> RelevanceSearchResultsIndexer.ProcessUnrankedEntries(IEnumerable<IPackageSearchMetadata> entries, IDictionary<string, long> ranking)', validate parameter 'ranking' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Indexing.RelevanceSearchResultsIndexer.ProcessUnrankedEntries(System.Collections.Generic.IEnumerable{NuGet.Protocol.Core.Types.IPackageSearchMetadata},System.Collections.Generic.IDictionary{System.String,System.Int64})~System.Collections.Generic.IEnumerable{NuGet.Protocol.Core.Types.IPackageSearchMetadata}")]
[assembly: SuppressMessage("Build", "CA2000:Call System.IDisposable.Dispose on object created by 'new DotTokenizer(reader)' before all references to it are out of scope.", Justification = "The responsibility to dispose the object is transferred to another object or wrapper that's created in the method and returned to the caller", Scope = "member", Target = "~M:NuGet.Indexing.TagsAnalyzer.TokenStream(System.String,System.IO.TextReader)~Lucene.Net.Analysis.TokenStream")]
[assembly: SuppressMessage("Build", "CA1305:The behavior of 'char.ToString()' could vary based on the current user's locale settings. Replace this call in 'TokenizingHelper.CamelCaseSplit(string)' with a call to 'char.ToString(IFormatProvider)'.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Indexing.TokenizingHelper.CamelCaseSplit(System.String)~System.Collections.Generic.IEnumerable{System.String}")]
[assembly: SuppressMessage("Build", "CA1062:In externally visible method 'IEnumerable<string> TokenizingHelper.CamelCaseSplit(string term)', validate parameter 'term' is non-null before using it. If appropriate, throw an ArgumentNullException when the argument is null or add a Code Contract precondition asserting non-null argument.", Justification = "<Pending>", Scope = "member", Target = "~M:NuGet.Indexing.TokenizingHelper.CamelCaseSplit(System.String)~System.Collections.Generic.IEnumerable{System.String}")]
[assembly: SuppressMessage("Build", "CA2000:Call System.IDisposable.Dispose on object created by 'new KeywordTokenizer(reader)' before all references to it are out of scope.", Justification = "The responsibility to dispose the object is transferred to another object or wrapper that's created in the method and returned to the caller", Scope = "member", Target = "~M:NuGet.Indexing.VersionAnalyzer.TokenStream(System.String,System.IO.TextReader)~Lucene.Net.Analysis.TokenStream")]
