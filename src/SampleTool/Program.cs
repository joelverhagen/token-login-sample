using System.Reflection;

var versionString = Assembly
    .GetEntryAssembly()?
    .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
    .InformationalVersion
    .ToString();

Console.WriteLine($"Running version: {versionString ?? "(unknown)"}");
