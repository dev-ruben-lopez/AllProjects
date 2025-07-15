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



public static class AssemblyExtensions
{
    public static Type[] SafeGetExportedTypes(this Assembly assembly)
    {
        try
        {
            return assembly.GetExportedTypes();
        }
        catch (ReflectionTypeLoadException ex)
        {
            Console.WriteLine($"⚠ Warning: Could not load all types from {assembly.FullName}");

            foreach (var loaderEx in ex.LoaderExceptions)
                Console.WriteLine("  - " + loaderEx?.Message);

            return ex.Types.Where(t => t != null).ToArray(); // Return the types that loaded
        }
        catch (Exception ex)
        {
            Console.WriteLine($"⛔ Failed to load types from {assembly.FullName}: {ex.Message}");
            return Array.Empty<Type>();
        }
    }
}

