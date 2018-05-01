using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component fileSystem = new Directory("File System");
            Component diskC = new Directory("Disk C");
            Component pngFile = new File("12345.png");
            Component docxFile = new File("DataMining.docx");

            diskC.Add(pngFile);
            diskC.Add(docxFile);

            fileSystem.Add(diskC);

            fileSystem.Print();
            Console.WriteLine();

            //diskC.Remove(pngFile);

            Component docFolder = new Directory("My documents");
            Component txtFile = new File("readme.txt");
            Component csFile = new File("Program.cs");

            docFolder.Add(txtFile);
            docFolder.Add(csFile);

            diskC.Add(docFolder);

            fileSystem.Print();

            Console.Read();
        }
    }
}
