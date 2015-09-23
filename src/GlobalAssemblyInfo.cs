/*
    Copyright © 2015 David Musgrove.
    Licensed under the terms of the MIT License.
*/

using System.Reflection;

[assembly: AssemblyCompany("David Musgrove")]
[assembly: AssemblyProduct("Ipify")]
[assembly: AssemblyCopyright("Copyright © 2015 David Musgrove")]
[assembly: AssemblyVersion("1.0.0.0")]
#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif