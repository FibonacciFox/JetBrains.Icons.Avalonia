using System;
using System.IO;
using System.Linq;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace BuildTasks
{
    public class GenerateJetBrainsIconKindEnum : Task
    {
        [Required]
        public string SourceDirectory { get; set; }

        [Required]
        public string OutputFile { get; set; }

        public override bool Execute()
        {
            try
            {
                Log.LogMessage(MessageImportance.High, $"Generating enum for SVG files in {SourceDirectory}");

                var svgFiles = Directory.GetFiles(SourceDirectory, "*.svg", SearchOption.AllDirectories);

                var iconNames = svgFiles
                    .Select(filePath => Path.GetFileNameWithoutExtension(filePath))
                    .Select(name => name.Replace("-", "_")
                        .Replace(" ", "_")
                        .Replace("_v2", "V2")
                        .Replace("@16x16", "16")
                        .Replace("@20x20", "20") // Replace special characters with
                        .Replace("@14x14", "14") // Replace special characters with
                        .Replace("@12x12", "12") // Replace special characters with
                        .Replace("@24x24", "24") // Replace special characters with
                        .Replace("@34x34", "34") // Replace special characters with
                        .Replace("@64x64", "64") // Replace special characters with
                        .Replace("+", "Plus")) // Replace special characters with
                    .Distinct()
                    .OrderBy(name => name)
                    .ToList();

                using (var writer = new StreamWriter(OutputFile))
                {
                    writer.WriteLine("namespace JetBrains.Icons");
                    writer.WriteLine("{");
                    writer.WriteLine("    public enum JetBrainsIconKind");
                    writer.WriteLine("    {");

                    foreach (var iconName in iconNames)
                    {
                        writer.WriteLine($"        {iconName},");
                    }

                    writer.WriteLine("    }");
                    writer.WriteLine("}");

                    Log.LogMessage(MessageImportance.High, $"Enum JetBrainsIconKind generated with {iconNames.Count} entries.");
                }

                return true;
            }
            catch (Exception ex)
            {
                Log.LogErrorFromException(ex);
                return false;
            }
        }
    }
}