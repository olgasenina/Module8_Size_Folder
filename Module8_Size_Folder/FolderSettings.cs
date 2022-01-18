using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Module8_Size_Folder
{
    public static class FolderSettings
    {
        /// <summary>
        /// Считает размер папки на диске (вместе со всеми вложенными папками и файлами). На вход метод принимает URL директории, в ответ — размер в байтах.
        /// </summary>
        public static long SizeFolder(DirectoryInfo d)
        {
            long size = 0;

            FileInfo[] fis = d.GetFiles();
            foreach(FileInfo fi in fis)
            {
                size += fi.Length;
            }

            DirectoryInfo[] dis = d.GetDirectories();
            foreach(DirectoryInfo di in dis)
            {
                size += SizeFolder(di);
            }

            return size;
        }
    }
}
