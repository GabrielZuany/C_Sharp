using System;
using System.IO;

public class Dir
{

    public void GetAllSubdirectories(string path){
        // get all subdirectories in the current directory.
        Console.WriteLine("Getting all subdirectories in the current directory");

        IEnumerable<string> Folders = Directory.EnumerateDirectories(path);
        foreach (var folder in Folders){
            Console.WriteLine(folder);
        }
    }

    public void GetAllFilesInCurrentDirectory(string path){
        // get all files in the current directory.
        Console.WriteLine("Getting all files in the current directory");

        IEnumerable<string> MainFiles = Directory.EnumerateFiles(path);

        foreach (var file in MainFiles){
            Console.WriteLine(file);
        }
    }

    public void GetAllFilesInCurrentDirectoryAndSubdirectories(string path){
        // get all files in current directory, including in subdirectories.
        Console.WriteLine("Getting all files in current directory, including in subdirectories");
        IEnumerable<string> AllFiles = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
        
        foreach (var file in AllFiles){
            if(file.EndsWith("file1.txt")){
                Console.Write("TXT -> "); 
            }else{
                Console.Write("NOT TXT -> "); 
            }
            Console.WriteLine(file);
        }
    }

    public void GetCurrentFileInfo(string path){
        // get the current folder info.
        string file = path + Path.DirectorySeparatorChar + "Program.cs";
        FileInfo info = new FileInfo(file);
        Console.Write($"Full Name: {info.FullName}\n");
        Console.Write($"Directory: {info.Directory}\n");
        Console.Write($"Extension: {info.Extension}\n");
        Console.Write($"Created: {info.CreationTime}\n");

    }

}