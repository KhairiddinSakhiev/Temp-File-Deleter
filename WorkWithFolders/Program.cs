using System.Diagnostics;

var temp = Path.GetTempPath();
var directs = Directory.GetDirectories(temp, "*.*", SearchOption.AllDirectories);
while (true)
{
    foreach (string filePath in directs)
    {
        try
        {
            FileInfo currentFile = new FileInfo(filePath);
            currentFile.Delete();
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Error on file: {0}\r\n   {1}", filePath, ex.Message);
        }
    }

    foreach (string filePath in directs)
    {
        try
        {
            DirectoryInfo currentDirect = new DirectoryInfo(filePath);
            currentDirect.Delete(true);
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Error on file: {0}\r\n   {1}", filePath, ex.Message);
        }
    }
    await Task.Delay(1000);
}