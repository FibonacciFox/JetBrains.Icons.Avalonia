using System;
using System.IO;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace BuildTasks
{
    public class RenameSvgFiles : Task
    {
        [Required]
        public string SourceDirectory { get; set; }

        public override bool Execute()
        {
            try
            {
                Log.LogMessage(MessageImportance.High, $"Starting to rename .svg files in {SourceDirectory}");

                foreach (var filePath in Directory.GetFiles(SourceDirectory, "*.svg", SearchOption.AllDirectories))
                {
                    var fileName = Path.GetFileName(filePath);
                    var modifiedName = fileName.Replace("_dark", "Dark");

                    // Ensure the first character is uppercase
                    if (modifiedName.Length > 0)
                    {
                        modifiedName = char.ToUpper(modifiedName[0]) + modifiedName.Substring(1);
                    }

                    var newFilePath = Path.Combine(Path.GetDirectoryName(filePath), modifiedName);

                    if (fileName != modifiedName)
                    {
                        File.Move(filePath, newFilePath);
                        Log.LogMessage(MessageImportance.Normal, $"Renamed file {fileName} to {modifiedName}");
                    }
                    else
                    {
                        Log.LogMessage(MessageImportance.Low, $"File {fileName} does not require renaming.");
                    }
                }

                Log.LogMessage(MessageImportance.High, "Renaming of .svg files completed successfully.");
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