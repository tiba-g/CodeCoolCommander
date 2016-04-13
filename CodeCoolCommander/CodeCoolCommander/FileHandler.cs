using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCoolCommander.Controller
{
    public class FileHandle
    {

        private static bool DeleteFile(string filePath)
        {
            return false;
        }

        public static bool GetAllDrives()
        {
            return false;
        }

        public static bool GetAllFilesAndDictionary()
        {
            return false;
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

        public static bool CopyFile(string sourceFilePath, string destinationFilePath)
        {
            return false;
        }

        public static bool MoveFile(string filePath)
        {
            return false;
        }
 
        public static double GetOccupiedSpace(string filePath)
        {
            return 0;
        }

        public static bool SetFileAttributes(string filePath, FileProperty fileProperty)
        {
            return false;
        }
    }
}
