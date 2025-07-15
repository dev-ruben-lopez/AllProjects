try
{
    var types = Assembly.LoadFrom("SomePlugin.dll").GetExportedTypes();
    foreach (var type in types)
    {
        Console.WriteLine(type.FullName);
    }
}
catch (ReflectionTypeLoadException ex)
{
    Console.WriteLine("Some types could not be loaded:");
    foreach (var t in ex.Types.Where(t => t != null))
    {
        Console.WriteLine("  Loaded type: " + t.FullName);
    }

    foreach (var loaderEx in ex.LoaderExceptions)
    {
        Console.WriteLine("  Loader error: " + loaderEx?.Message);
    }
}