using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics.Course_Content
{
    public class FileOperations
    {
        void fileOperationsMain()
        {
            // File Operations
            string path = ""; 

            //Reading Text Files
            if (File.Exists(path))
            {
                string content = File.ReadAllText(path);
                Console.WriteLine("File Content:");
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("File not found.");
            }


            //Writing Text Files (overwrite)
            string writeContent = "File written successfully.";
            File.WriteAllText(path, writeContent);

            //Writing Text Files (Add/Append)
            string appendContent = "\nFile appended successfully.";
            File.AppendAllText(path, appendContent);


            // File & Directory Operations
            string basePath = "";
            string filePath = Path.Combine(basePath, "newExample.txt");

            if (!Directory.Exists(basePath))
            {
                Directory.CreateDirectory(basePath);
                Console.WriteLine("Directory created.");
            }

            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "New content is written inside this file.");
                Console.WriteLine("File created inside the directory.");
            }


            // File Streams

            // Writing to a file using FileStream  
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                byte[] data = System.Text.Encoding.UTF8.GetBytes("Stream-based file writing.");
                fs.Write(data, 0, data.Length);
                Console.WriteLine("Stream completed.");
            }

            // Reading from a file using FileStream  
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                byte[] buffer = new byte[fs.Length];
                fs.Read(buffer, 0, buffer.Length);
                string content = System.Text.Encoding.UTF8.GetString(buffer);
                Console.WriteLine($"Read Content: {content}");
            }
        }
    }
}
