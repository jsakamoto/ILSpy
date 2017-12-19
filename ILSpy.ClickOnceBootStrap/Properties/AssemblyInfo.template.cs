#region Using directives

using System;
using System.Resources;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;

#endregion

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("ILSpy - ClickOnce Bootstrap")]
[assembly: AssemblyDescription(".NET assembly inspector and decompiler")]
[assembly: AssemblyCompany("ic#code")]
[assembly: AssemblyProduct("ILSpy")]
[assembly: AssemblyCopyright("Copyright 2011-2016 AlphaSierraPapa for the SharpDevelop Team")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// This sets the default COM visibility of types in the assembly to invisible.
// If you need to expose a type to COM, use [ComVisible(true)] on that type.
[assembly: ComVisible(false)]

[assembly: AssemblyVersion(RevisionClass.Major + "." + RevisionClass.Minor + "." + RevisionClass.Build + "." + RevisionClass.Revision)]
[assembly: NeutralResourcesLanguage("en-US")]

internal static class RevisionClass
{
    public const string Major = "3";
    public const string Minor = "0";
    public const string Build = "0";
    public const string Revision = "$INSERTREVISION$";
    public const string VersionName = null;

    public const string FullVersion = Major + "." + Minor + "." + Build + ".$INSERTREVISION$$INSERTBRANCHPOSTFIX$$INSERTVERSIONNAMEPOSTFIX$";
}
