using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCoolCommander.Controller
{
    public class FileHandle
    {

        private static bool DeleteFile(string filePath)
        {
            bool successfull;
            try
            {
                File.Delete(filePath);
                successfull = true;
            }
            catch (Exception)
            {
                successfull = false;
            }
            return successfull;
        }

        public static DriveInfo[] GetAllDrives()
        {
            DriveInfo[] allDrives;
            try
            {
                allDrives = DriveInfo.GetDrives();
            }
            catch (Exception)
            {
                allDrives = null;
            }
            return allDrives;
        }

        public static string GetAllFilesAndDirectories(string dirPath)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(dirPath);
            DirectoryInfo[] dirs = dirInfo.GetDirectories();
            FileInfo fileInfo = new FileInfo(dirPath);
            FileInfo[] files = dirInfo.GetFiles();

            return null;


        }

        public static bool CompressFiles(List<string> filePath)
        {
            return false;
        }

        public static bool DeCompressFiles(List<string> filePath)
        {
            return false;
        }

        public static bool EncryptFile(string filePath)
        {
            return false;
        }

        public static bool DecryptFile(string filePath)
        {
            return false;
        }

        public static List<string> Search(string regularExpression)
        {
            return null;
        }

        public static string GetTXTFileContent(string filePath)
        {
            return null;
        }

        public static bool CopyFile(string sourceFilePath, string destinationFilePath, bool overwrite)
        {
            bool successfull;
            try
            {
                File.Copy(sourceFilePath, destinationFilePath, overwrite);
                successfull = true;
            }
            catch (Exception)
            {
                successfull = false;
            }
            return successfull;
        }

        public static bool MoveFile(string sourceFilePath, string destinationFilePath)
        {
            bool successfull;
            try
            {
                File.Move(sourceFilePath, destinationFilePath);
                successfull = true;
            }
            catch (Exception)
            {
                successfull = false;
            }
            return successfull;
        }

        public static double GetOccupiedSpace(string filePath)
        {
            return 0;
        }
    }
}
