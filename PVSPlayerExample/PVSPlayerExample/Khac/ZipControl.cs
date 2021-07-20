using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace PVSPlayerExample
{
    internal class ZipControl
    {
        public bool StartZipFile(string sourcePath, string zipFilePath)
        {
            var success = true;
            try {
                ZipFile.CreateFromDirectory(sourcePath, zipFilePath);
            } catch (Exception ex)
            {
                success = false;
            }
            return success;
        }

        public bool StartUnzip(string zipFilePath, string destinationPath)
        {
            var success = true;
            try
            {
                ZipFile.ExtractToDirectory(zipFilePath, destinationPath);
            }
            catch (Exception ex)
            {
                success = false;
            }
            return success;
        }
    }
}
