using Microsoft.Build.Framework;
using Task = Microsoft.Build.Utilities.Task;

namespace JetBrains.Icons.build;

public class RenameSvgFiles : Task
{
    [Required] 
    public string SourceDirectory { get; set; }

    public override bool Execute()
    {
        try
        {
            foreach (var filePath in Directory.GetFiles(SourceDirectory, "*.svg", SearchOption.AllDirectories))
            {
                var fileName = Path.GetFileName(filePath);
                var newFileName = char.ToUpper(fileName[0]) + fileName.Substring(1);
                var newFilePath = Path.Combine(Path.GetDirectoryName(filePath), newFileName);
                File.Move(filePath, newFilePath);
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