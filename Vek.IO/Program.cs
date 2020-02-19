using System;
using System.IO;
using System.Linq;

namespace Vek.IO
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetDriveInfo();
            DirectoryInfoForFun();
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

            var options = new EnumerationOptions
            {
                 MatchType = MatchType.Simple,
                 MatchCasing = MatchCasing.CaseSensitive
            };

            foreach (var dir in dirInfo.EnumerateDirectories("*Folder?", options))
            {
                ShowDirInfo(dir);
            }
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
