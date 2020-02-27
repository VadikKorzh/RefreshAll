using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Vek.IO
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetDriveInfo();
            //DirectoryInfoForFun();
            //DirectoryStaticFun();
            //FileInfoForFun();
            //StreamForFun();

            EncodingForFun();
        }

        private static void StreamForFun()
        {
            using (var fStr = File.Open(@"D:\Worker\IO\DirectoryInfo\data.txt", FileMode.OpenOrCreate))
            {
                String text = "Team explorer home";
                var bytes = Encoding.ASCII.GetBytes(text);
                fStr.Write(bytes, 0, bytes.Length);

                fStr.Position = 0;

                List<Byte> bytesOut = new List<byte>();
                for (int i = 0; i < bytes.Length; i++)
                {
                    bytesOut.Add((Byte)fStr.ReadByte());
                }

                Console.WriteLine(Encoding.UTF32.GetString(bytesOut.ToArray()));
            }
        }

        private static void EncodingForFun()
        {
            String testText = "Vadik Korzh";
            foreach (var encoding in Encoding.GetEncodings())
            {
                Console.WriteLine(encoding.Name);
                Console.WriteLine(encoding.DisplayName);
                Console.WriteLine(encoding.CodePage);
                var encodingInstance = encoding.GetEncoding();
                foreach (var b in encodingInstance.GetBytes(testText))
                {
                    Console.Write(b + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        private static void FileInfoForFun()
        {
            var fileNames = new[] { "file.txt", "file_1.cmd", "img.bmp" };
            var dirPath = @"D:\Worker\IO\DirectoryInfo\SubFolder3\Folder1";

            //foreach (var fn in fileNames)
            //{
            //    var fi1 = new FileInfo(Path.Combine(dirPath, fn));
            //    fi1.Create();
            //}

            var fi = new FileInfo(Path.Combine(dirPath, fileNames[0]));
            using (var fStr = fi.Open(FileMode.Append, FileAccess.Write, FileShare.Write))
            {
                using (var wrtr = new StreamWriter(fStr))
                {
                    //wrtr.NewLine = "*********";
                    wrtr.WriteLine("wwwwww");
                }
            }

            fi.Replace(Path.Combine(dirPath, fileNames[1]), Path.Combine(dirPath, fileNames[2]));
            //ShowFileInfo(fi);
        }

        private static void DirectoryStaticFun()
        {
            var drives = Directory.GetLogicalDrives();

            foreach (var drive in drives)
            {
                Console.WriteLine(drive);
            }

            Directory.SetCreationTime(@"D:\Worker\IO\DirectoryInfo\SubFolder2\f1 — копия (4).txt",
                DateTime.Now.AddYears(100));
        }

        private static void DirectoryInfoForFun()
        {
            // create a directory
            var dirInfo = new DirectoryInfo(@"D:\Worker\IO\DirectoryInfo");
            dirInfo.Create();

            // simple creation of subdirectories
            var subDir = dirInfo.CreateSubdirectory("SubFolder1");
            subDir.CreateSubdirectory("SubFolder2");
            dirInfo.CreateSubdirectory("SubFolder2");

            // all the intermediate directories are created
            dirInfo.CreateSubdirectory(@"SubFolder3\Folder1\Folder1");

            // chain
            dirInfo.CreateSubdirectory("SubFolder4").CreateSubdirectory("Folder1");

            // directory removal
            subDir.Delete(true);

            // moving to a new place
            //dirInfo.MoveTo(@"d:\aaa");

            var options = new EnumerationOptions
            {
                MatchType = MatchType.Simple,
                MatchCasing = MatchCasing.CaseSensitive,
                RecurseSubdirectories = true
            };

            foreach (var dir in dirInfo.EnumerateDirectories("*Folder?", options))
            {
                ShowDirInfo(dir);
            }
        }

        private static void ShowFileInfo(FileInfo fileInfo)
        {
            Console.WriteLine($"{nameof(fileInfo.Name)}: {fileInfo.Name}");
            Console.WriteLine($"{nameof(fileInfo.FullName)}: {fileInfo.FullName}");
            Console.WriteLine($"{nameof(fileInfo.Extension)}: {fileInfo.Extension}");
            Console.WriteLine($"{nameof(fileInfo.Length)}: {fileInfo.Length}");
            Console.WriteLine($"{nameof(fileInfo.IsReadOnly)}: {fileInfo.IsReadOnly}");
            Console.WriteLine($"{nameof(fileInfo.Attributes)}: {fileInfo.Attributes}");
            Console.WriteLine();
        }

        private static void ShowDirInfo(DirectoryInfo dirInfo)
        {
            Console.WriteLine($"{nameof(dirInfo.Name)}: {dirInfo.Name}");
            Console.WriteLine($"{nameof(dirInfo.FullName)}: {dirInfo.FullName}");
            Console.WriteLine($"{nameof(dirInfo.Parent)}: {dirInfo.Parent}");
            Console.WriteLine($"{nameof(dirInfo.Root)}: {dirInfo.Root}");
            Console.WriteLine($"{nameof(dirInfo.CreationTime)}: {dirInfo.CreationTime}");
            Console.WriteLine($"{nameof(dirInfo.LastAccessTime)}: {dirInfo.LastAccessTime}");
            Console.WriteLine($"{nameof(dirInfo.Attributes)}: {dirInfo.Attributes}");
            Console.WriteLine();

            foreach (var file in dirInfo.GetFiles("*.txt", SearchOption.AllDirectories))
            {
                ShowFileInfo(file);
            }
        }

        private static void GetDriveInfo()
        {
            var localDrives = DriveInfo.GetDrives();

            foreach (var drive in localDrives)
            {
                Console.WriteLine($"{nameof(drive.Name)}: {drive.Name}");
                Console.WriteLine($"{nameof(drive.VolumeLabel)}: {drive.VolumeLabel}");
                Console.WriteLine($"{nameof(drive.DriveType)}: {drive.DriveType}");
                Console.WriteLine($"{nameof(drive.DriveFormat)}: {drive.DriveFormat}");
                Console.WriteLine($"{nameof(drive.RootDirectory)}: {drive.RootDirectory}");
                Console.WriteLine($"{nameof(drive.TotalFreeSpace)}: {drive.TotalFreeSpace}");
                Console.WriteLine($"{nameof(drive.TotalSize)}: {drive.TotalSize}");
                Console.WriteLine($"{nameof(drive.IsReady)}: {drive.IsReady}");
                Console.WriteLine();
            }
        }
    }
}
