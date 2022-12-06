using System;
using System.Collections.Generic;
using System.IO;

class Program{

    static void Main(string[] args)
    {   
        Dir dir = new Dir();
        string path = Directory.GetCurrentDirectory();
    
        dir.GetAllSubdirectories(path);

        Console.Write("\n\n---------------------------------------------------\n\n");

        dir.GetAllFilesInCurrentDirectory(path);

        Console.Write("\n\n---------------------------------------------------\n\n");

        dir.GetAllFilesInCurrentDirectoryAndSubdirectories(path);

        Console.Write("\n\n---------------------------------------------------\n\n");

        dir.GetCurrentFileInfo(path);

        Directory.CreateDirectory(Path.Combine(path, "created_by_src"));
    }

}
