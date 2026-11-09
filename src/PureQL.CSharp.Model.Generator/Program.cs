namespace PureQL.CSharp.Model.Generator;

// Generates the PureQL.CSharp.Model sources from the pinned PureQL specification.
//
//   dotnet run --project PureQL.CSharp.Model.Generator
//       [-- [--schema <PureQL-Specification.json>] [--output <project directory>]]
//
// Without --schema the schema is fetched from SchemaUrl. Every .cs file of the output
// directory is replaced: the model project holds only generated code.
internal static class Program
{
    /// <summary>The PureQL specification tag the model mirrors.</summary>
    public const string SchemaTag = "0.1.0-preview.2.0.1";

    public const string SchemaUrl =
        "https://raw.githubusercontent.com/kudima03/PureQL-Specification/"
        + SchemaTag
        + "/PureQL-Specification.json";

    public static async Task<int> Main(string[] args)
    {
        string? schemaPath = Option(args, "--schema");
        string output = Path.GetFullPath(
            Option(args, "--output") ?? "PureQL.CSharp.Model"
        );
        if (!File.Exists(Path.Combine(output, "PureQL.CSharp.Model.csproj")))
        {
            await Console
                .Error.WriteLineAsync(
                    $"{output} is not the PureQL.CSharp.Model project directory."
                )
                .ConfigureAwait(false);
            return 1;
        }

        string text = schemaPath is null
            ? await Download().ConfigureAwait(false)
            : await File.ReadAllTextAsync(schemaPath).ConfigureAwait(false);
        JsonMap schema =
            Json.Parse(text) as JsonMap
            ?? throw new InvalidOperationException("The schema is not a JSON object.");
        if (schema["version"] is string version && version != SchemaTag)
        {
            await Console
                .Error.WriteLineAsync(
                    $"The schema is version {version}, the generator pins {SchemaTag}."
                )
                .ConfigureAwait(false);
            return 1;
        }

        SortedDictionary<string, string> files = new ModelEmitter(
            SchemaNormalizer.Normalize(schema)
        ).Emit();

        foreach (string stale in Sources(output))
        {
            File.Delete(stale);
        }
        foreach (string directory in Directory.GetDirectories(output))
        {
            if (Directory.GetFileSystemEntries(directory).Length == 0)
            {
                Directory.Delete(directory);
            }
        }
        foreach (KeyValuePair<string, string> file in files)
        {
            string path = Path.Combine(output, file.Key);
            _ = Directory.CreateDirectory(Path.GetDirectoryName(path)!);
            await File.WriteAllTextAsync(path, file.Value).ConfigureAwait(false);
        }
        Console.WriteLine($"Wrote {files.Count} files to {output}.");
        return 0;
    }

    private static string? Option(string[] args, string name)
    {
        int index = Array.IndexOf(args, name);
        return index >= 0 && index + 1 < args.Length ? args[index + 1] : null;
    }

    private static async Task<string> Download()
    {
        using HttpClient client = new HttpClient();
        return await client.GetStringAsync(new Uri(SchemaUrl)).ConfigureAwait(false);
    }

    // The model's sources: every .cs file outside the build output.
    private static IEnumerable<string> Sources(string project)
    {
        string bin = Path.Combine(project, "bin") + Path.DirectorySeparatorChar;
        string obj = Path.Combine(project, "obj") + Path.DirectorySeparatorChar;
        return
        [
            .. Directory
                .EnumerateFiles(project, "*.cs", SearchOption.AllDirectories)
                .Where(path =>
                    !path.StartsWith(bin, StringComparison.Ordinal)
                    && !path.StartsWith(obj, StringComparison.Ordinal)
                ),
        ];
    }
}
