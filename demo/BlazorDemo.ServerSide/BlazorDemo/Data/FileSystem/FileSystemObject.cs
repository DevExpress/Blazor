using System.Collections.Generic;

namespace BlazorDemo.Data.FileSystem;

public class FileSystemObject {
    public string Name { get; private set; }
    public bool? Checked { get; private set; } = false;
    public string FileNameExtension { get; private set; }
    public string IconCssClass { get; private set; }
    public FileElementType Type { get; private set; }
    public List<FileSystemObject> Content { get; private set; }

    public FileSystemObject(string name, string type, List<FileSystemObject> content = null) {
        Name = AssignName(name, type);
        FileNameExtension = type;
        Type = AssignType(type);
        IconCssClass = DefaultIcon();
        Content = content;
    }

    public FileSystemObject(string name, string type, string iconCssClass, List<FileSystemObject> content = null) {
        Name = AssignName(name, type);
        FileNameExtension = type;
        Type = AssignType(type);
        IconCssClass = iconCssClass;
        Content = content;
    }

    string AssignName(string name, string type) {
        string extension = type == "folder" ? "" : "." + type;
        return (name + extension);
    }

    private FileElementType AssignType(string type) {
        FileElementType fileType = FileElementType.FileFolder;
        if(FileSettings.types.TryGetValue(type, out FileElementType value)) {
            fileType = value;
        }

        return fileType;
    }

    public string DefaultIcon() {
        return FileSettings.defaultIcons[Type];
    }
}
