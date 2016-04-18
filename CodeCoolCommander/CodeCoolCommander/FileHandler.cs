using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeCoolCommander.View;

namespace CodeCoolCommander.Controller
{
    public class FileHandler
    {

        private static long size = 0;

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

        public static FileInfo[] GetAllFiles(string dirPath)
        {
            DirectoryInfo dirInfo;
            FileInfo fileInfo;
            FileInfo[] files;
            try
            {
                dirInfo = new DirectoryInfo(dirPath);
                fileInfo = new FileInfo(dirPath);
                files = dirInfo.GetFiles();
                Array.Sort(files, delegate (FileInfo f1, FileInfo f2) {
                    return f1.Name.CompareTo(f2.Name);
                });
            }
            catch (Exception)

            { files = null; }

            return files;
        }

        public static DirectoryInfo[] GetAllDirectories(string dirPath)
        {
            DirectoryInfo dirinfo;
            DirectoryInfo[] dirs;
            try
            {
                dirinfo = new DirectoryInfo(dirPath);
                dirs = dirinfo.GetDirectories();

                Array.Sort(dirs, delegate(DirectoryInfo f1, DirectoryInfo f2) {
                    return f1.Name.CompareTo(f2.Name);
                });
            }
            catch (Exception)
            {
                dirs = null;
                MessageBox.Show("Can't open drive or folder!");
            }

            return dirs;
        }

        public static bool CompressFiles(List<string> filePath)
        {
            try
            {
                Stream zippedFiles = File.Create(@"c:\Test\test.zip");
                Stream zipStream = new GZipStream(zippedFiles, CompressionMode.Compress);

                for (int fil = 0; fil < filePath.Count; fil++)
                {
                    Stream input = File.OpenRead(filePath[fil]);
                    byte[] buffer = new byte[4096];
                    int sRead;

                    while ((sRead = input.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        zipStream.Write(buffer, 0, sRead);
                    }
                    input.Close();
                }
                zipStream.Close();
                zippedFiles.Close();

                return true;
            }
            catch (Exception)
            {

                MessageBox.Show("Failed to compress the file(s)!");

                return false;
            }
        }

        public static bool DeCompressFiles(List<string> filePathes)
        {
            try
            {
                Stream filesToUnzip = File.Create(@"c:\Test\");
                Stream zipStream = new GZipStream(filesToUnzip, CompressionMode.Decompress);

                for (int fil = 0; fil < filePathes.Count; fil++)
                {
                    Stream input = File.OpenRead(filePathes[fil]);
                    byte[] buffer = new byte[4096];
                    int sRead;

                    while ((sRead = input.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        zipStream.Write(buffer, 0, sRead);
                    }
                    input.Close();
                }
                zipStream.Close();
                filesToUnzip.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
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

        public static long GetDirectorySize(string filePath)
        {
            try
            {
                foreach (string dir in Directory.GetDirectories(filePath))
                {
                    GetDirectorySize(dir);
                }

                foreach (FileInfo file in new DirectoryInfo(filePath).GetFiles())
                {
                    size += file.Length;
                }

                return size / 1024;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public static long GetFileSize(string filePath)
        {
            try {
                long length = new System.IO.FileInfo(filePath).Length;

                return length / 1024;
            }
            catch ( Exception ex)
            {
                return -1;
            }
        }

        public static string GetSelectedItemPath(int index, bool right)
        {
            if (right)
            {
                if ((index + 1) > CCCForm.dirsRight.Length)
                {
                    return CCCForm.filesRight[index - CCCForm.dirsRight.Length].FullName;
                }
                else
                {
                    return CCCForm.dirsRight[index].FullName;
                }
            }
            else
            {
                if ((index + 1) > CCCForm.dirsLeft.Length)
                {
                    return CCCForm.filesLeft[index - CCCForm.dirsLeft.Length].FullName;
                }
                else
                {
                    return CCCForm.dirsLeft[index].FullName;
                }
            }
            
        }

        public void OpenTxtFile(string filePath)
        {

        }
    }
}
    

