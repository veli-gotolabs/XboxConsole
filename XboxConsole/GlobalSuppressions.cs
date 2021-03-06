// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Scope = "member", Target = "Microsoft.Internal.GamesTest.Xbox.XboxConsoleAdapterFactory.#.cctor()", Justification = "The complexity is caused by the adapter lookup table which may grow by design as we add new adapters.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable", Scope = "type", Target = "Microsoft.Internal.GamesTest.Xbox.XboxPackage", Justification = "Based on an answer in the comments from Stephen Toub at http://blogs.msdn.com/b/pfxteam/archive/2012/03/25/10287435.aspx on 6 May 2012 10:16 PM, neither of the things that Stephen mentions about the CancellationTokenSource are done. The CTS can be cleaned up when it is garbage collected without explicit disposal.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Microsoft.Internal.GamesTest.Xbox.XboxConsole.#.cctor()", Justification = "Preventing any exceptions that relate to logging telemetry as the user should not care about telemetry failing.")]
