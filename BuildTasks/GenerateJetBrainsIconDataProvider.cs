using System;
using System.IO;
using System.Linq;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace BuildTasks
{
    public class GenerateJetBrainsIconDataProvider : Task
    {
        [Required]
        public string SourceDirectory { get; set; }

        [Required]
        public string OutputFile { get; set; }

        public override bool Execute()
        {
            try
            {
                Log.LogMessage(MessageImportance.High, $"Generating JetBrainsIconDataProvider class for SVG files in {SourceDirectory}");

                var svgFiles = Directory.GetFiles(SourceDirectory, "*.svg", SearchOption.AllDirectories);

                var iconData = svgFiles
                    .Select(filePath => new
                    {
                        FileName = Path.GetFileNameWithoutExtension(filePath),
                        FilePath = filePath
                    })
                    .Select(data => new
                    {
                        EnumName = data.FileName.Replace("-", "_").Replace(" ", "_").Replace("@20x20", "Bold"),
                        FilePath = data.FilePath.Replace(@"\", "/")
                    })
                    .Distinct()
                    .OrderBy(data => data.EnumName)
                    .ToList();

                using (var writer = new StreamWriter(OutputFile))
                {
                    writer.WriteLine("using System;");
                    writer.WriteLine("using System.Collections.Generic;");
                    writer.WriteLine("using System.Runtime.CompilerServices;");
                    writer.WriteLine();
                    writer.WriteLine("namespace JetBrains.Icons");
                    writer.WriteLine("{");
                    writer.WriteLine("    public partial class JetBrainsIconDataProvider");
                    writer.WriteLine("    {");
                    writer.WriteLine("        [MethodImpl(MethodImplOptions.AggressiveInlining)]");
                    writer.WriteLine("        public virtual partial List<JetBrainsIconData> ProvideData(JetBrainsIconKind kind)");
                    writer.WriteLine("        {");
                    writer.WriteLine("            return kind switch");
                    writer.WriteLine("            {");

                    foreach (var data in iconData)
                    {
                        var relativePath = data.FilePath.Replace(SourceDirectory.Replace(@"\", "/"), "")
                                                       .TrimStart('/');

                        writer.WriteLine($"                JetBrainsIconKind.{data.EnumName} => new List<JetBrainsIconData>");
                        writer.WriteLine("                {");
                        writer.WriteLine($"                    new JetBrainsIconData(\"avares://JetBrains.Icons/Assets/{relativePath}\")");
                        writer.WriteLine("                },");
                    }

                    writer.WriteLine("                _ => new List<JetBrainsIconData>()");
                    writer.WriteLine("            };");
                    writer.WriteLine("        }");
                    writer.WriteLine("    }");
                    writer.WriteLine("}");

                    Log.LogMessage(MessageImportance.High, $"Class JetBrainsIconDataProvider generated with {iconData.Count} icon data entries.");
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

    public class JetBrainsIconData
    {
        public string Path { get; }

        public JetBrainsIconData(string path)
        {
            Path = path;
        }
    }
}
