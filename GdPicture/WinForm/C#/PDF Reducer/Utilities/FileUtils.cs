using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using GdPicture14;


namespace pdfReducer.Utilities
{
    internal static class FileUtils
    {
        public static List<FileToProcess> CollectFiles(string[] data, bool inputIsFolder, GdPicture14.DocumentFormat[] formats)
        {
            List<FileToProcess> collectedFiles = new List<FileToProcess>();

            if (!inputIsFolder)
            {
                foreach (string path in data)
                {
                    if (File.Exists(path))
                    {
                        GdPicture14.DocumentFormat documentFormat = GdPictureDocumentUtilities.GetDocumentFormatFromFileName(path);
                        if (IsOneOf(formats, documentFormat))
                        {
                            collectedFiles.Add(new FileToProcess(path, Path.GetFileName(path)));
                        }
                    }
                }
            }
            else
            {
                DirSearch(collectedFiles, data[0], "", formats);
            }


            return collectedFiles;
        }


        private static void DirSearch(List<FileToProcess> collectedFiles, string dir, string destDir, GdPicture14.DocumentFormat[] supportedFormats)
        {
            try
            {
                foreach (string file in Directory.GetFiles(dir))
                {
                    GdPicture14.DocumentFormat documentFormat = GdPictureDocumentUtilities.GetDocumentFormatFromFileName(file);
                    if (IsOneOf(supportedFormats, documentFormat))
                    {
                        collectedFiles.Add(new FileToProcess(file, Path.Combine(destDir, Path.GetFileName(file))));
                    }

                }
            }
            catch (Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }


        private static bool IsOneOf(GdPicture14.DocumentFormat[] data, GdPicture14.DocumentFormat candidate)
        {
            foreach (GdPicture14.DocumentFormat entry in data)
            {
                if (entry == candidate)
                {
                    return true;
                }
            }

            return false;
        }
    }
}