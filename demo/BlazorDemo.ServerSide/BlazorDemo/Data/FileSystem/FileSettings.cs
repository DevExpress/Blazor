using System.Collections.Generic;
using System.Linq;

namespace BlazorDemo.Data.FileSystem;

public static class FileSettings {
    public static Dictionary<string, FileElementType> types => TypesCollection().ToDictionary(x => x.Key, x => x.Value);

    public static Dictionary<FileElementType, string> defaultIcons => IconsCollection().ToDictionary(x => x.Key, x => x.Value);

    static IEnumerable<KeyValuePair<string, FileElementType>> TypesCollection() {
        yield return new KeyValuePair<string, FileElementType>("txt", FileElementType.DocumentFile);
        yield return new KeyValuePair<string, FileElementType>("docx", FileElementType.DocumentFile);
        yield return new KeyValuePair<string, FileElementType>("pptx", FileElementType.DocumentFile);
        yield return new KeyValuePair<string, FileElementType>("xlsx", FileElementType.DocumentFile);
        yield return new KeyValuePair<string, FileElementType>("pdf", FileElementType.DocumentFile);
        yield return new KeyValuePair<string, FileElementType>("mp3", FileElementType.AudioFile);
        yield return new KeyValuePair<string, FileElementType>("mp4", FileElementType.AudioFile);
        yield return new KeyValuePair<string, FileElementType>("mov", FileElementType.VideoFile);
        yield return new KeyValuePair<string, FileElementType>("jpg", FileElementType.ImageFile);
        yield return new KeyValuePair<string, FileElementType>("jpeg", FileElementType.ImageFile);
        yield return new KeyValuePair<string, FileElementType>("png", FileElementType.ImageFile);
        yield return new KeyValuePair<string, FileElementType>("folder", FileElementType.FileFolder);
    }

    static IEnumerable<KeyValuePair<FileElementType, string>> IconsCollection() {
        string treeviewIcon = "treeview-icon";

        yield return new KeyValuePair<FileElementType, string>(FileElementType.AudioFile, $"{treeviewIcon} {treeviewIcon}-music");
        yield return new KeyValuePair<FileElementType, string>(FileElementType.DocumentFile, $"{treeviewIcon} {treeviewIcon}-document");
        yield return new KeyValuePair<FileElementType, string>(FileElementType.FileFolder, $"{treeviewIcon} {treeviewIcon}-folder");
        yield return new KeyValuePair<FileElementType, string>(FileElementType.ImageFile, $"{treeviewIcon} {treeviewIcon}-image");
        yield return new KeyValuePair<FileElementType, string>(FileElementType.VideoFile, $"{treeviewIcon} {treeviewIcon}-video");
    }
}
