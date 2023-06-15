using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorDemo.Data.FileSystem;

public class FileSystemObjects {
    private static readonly Lazy<List<FileSystemObject>> fileElements = new Lazy<List<FileSystemObject>>(() => {
        List<FileSystemObject> content = new List<FileSystemObject>() {
            new FileSystemObject("Documents", "folder", new List<FileSystemObject>() {
                new FileSystemObject("Work documents", "folder", new List<FileSystemObject>() {
                    new FileSystemObject("Blazor documentation", "docx"),
                    new FileSystemObject("Demo presentation", "pptx"),
                    new FileSystemObject("Specification", "docx"),
                    new FileSystemObject("Report-2022", "xlsx")
                }),
                new FileSystemObject("CV", "pdf"),
                new FileSystemObject("Document-1", "docx"),
                new FileSystemObject("Invoice", "pdf"),
                new FileSystemObject("Notes", "txt")
            }),
            new FileSystemObject("Music", "folder", new List<FileSystemObject>() {
                new FileSystemObject("hard rock", "mp3"),
                new FileSystemObject("smooth jazz", "mp3")
            }),
            new FileSystemObject("Pictures", "folder", new List<FileSystemObject>() {
                new FileSystemObject("Case Studies", "folder", new List<FileSystemObject>() {
                    new FileSystemObject("Image-1", "jpeg"),
                    new FileSystemObject("Image-2", "jpeg"),
                    new FileSystemObject("Logo", "png"),
                    new FileSystemObject("Screenshot-2384", "jpeg"),
                    new FileSystemObject("Screenshot-325", "jpeg")
                }),
                new FileSystemObject("Photos", "folder", new List<FileSystemObject>() {
                    new FileSystemObject("Visa photo", "jpeg"),
                    new FileSystemObject("Photo-1", "jpg"),
                    new FileSystemObject("Photo-2", "jpg"),
                    new FileSystemObject("Photo-3", "jpg"),
                    new FileSystemObject("Profile photo", "jpg")
                })
            }),
            new FileSystemObject("Video", "folder", new List<FileSystemObject>() {
                new FileSystemObject("Work", "folder", new List<FileSystemObject>() {
                    new FileSystemObject("demo meeting", "mov"),
                    new FileSystemObject("screen recording", "mov")
                }),
                new FileSystemObject("video-1", "mov")
            }),

        };
        return content;
    });

    public static List<FileSystemObject> Content { get { return fileElements.Value; } }
}
