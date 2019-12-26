using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CodeSnippets.Classes
{
    public static class DirectoryLibrary
    {
        public static IEnumerable<FileInfo> GetFileList(string searchPattern, string rootFolderPath)
        {
            var rootDirectoryInfo = new DirectoryInfo(rootFolderPath);
            var dirListingDirectories = rootDirectoryInfo.GetDirectories("*", SearchOption.AllDirectories);

            return from directoriesWithFiles in ReturnFiles(dirListingDirectories, searchPattern).SelectMany(files => files)
                select directoriesWithFiles;
        }
        private static IEnumerable<FileInfo[]> ReturnFiles(DirectoryInfo[] dirList, string fileSearchPattern)
        {
            foreach (var directoryInfo in dirList)
            {
                yield return directoryInfo.GetFiles(fileSearchPattern, SearchOption.TopDirectoryOnly);
            }
        }
    }
}
