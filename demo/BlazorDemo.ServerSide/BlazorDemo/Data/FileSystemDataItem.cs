using System;
using System.Collections.Generic;

namespace BlazorDemo.Data {
    public class FileSystemDataItem {
        public string Name { get; set; }
        public FileType Type { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public long Size { get; set; }

        public List<FileSystemDataItem> Children { get; set; }
        public bool HasChildren => Children != null && Children.Count > 0;
    }

    public enum FileType { File, Folder }
}

