using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.Extensions.DependencyModel;

public static class DependencyCopier
{
    public static void CopyAllRuntimeDependencies(string targetDirectory)
    {
        if (!Directory.Exists(targetDirectory))
            Directory.CreateDirectory(targetDirectory);

        var deps = DependencyContext.Default;

        foreach (var lib in deps.RuntimeLibraries)
        {
            foreach (var group in lib.RuntimeAssemblyGroups)
            {
                foreach (var path in group.AssetPaths)
                {
                    var assemblyPath = ResolveAssemblyPath(path);
                    if (assemblyPath != null)
                    {
                        var destFile = Path.Combine(targetDirectory, Path.GetFileName(assemblyPath));
                        File.Copy(assemblyPath, destFile, overwrite: true);
                        Console.WriteLine($"✔ Copied: {Path.GetFileName(assemblyPath)}");
                    }
                }
            }
        }
    }

    private static string? ResolveAssemblyPath(string relativePath)
    {
        var baseDirs = new[]
        {
            // Local NuGet global package cache
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), ".nuget", "packages"),
            // Shared .NET framework folders (might contain some runtime deps)
            Path.Combine(System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory())
        };

        foreach (var baseDir in baseDirs)
        {
            var possible = Directory.GetFiles(baseDir, Path.GetFileName(relativePath), SearchOption.AllDirectories)
                                    .FirstOrDefault();

            if (possible != null)
                return possible;
        }

        return null; // couldn't resolve
    }
}