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
                    var directoryName = new DirectoryInfo(Path.GetDirectoryName(filePath)).Name;

                    // Ensure the first character of the directory name is uppercase
                    if (directoryName.Length > 0)
                    {
                        directoryName = char.ToUpper(directoryName[0]) + directoryName.Substring(1);
                    }

                    // Generate new file name with the directory name appended
                    var baseFileName = Path.GetFileNameWithoutExtension(fileName);
                    var extension = Path.GetExtension(fileName);

                    var modifiedName = baseFileName.Replace("_dark", "Dark");
                    if (!modifiedName.Contains(directoryName))
                    {
                        modifiedName = $"{modifiedName}_{directoryName}";
                    }

                    modifiedName += extension;

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
