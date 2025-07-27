// See https://aka.ms/new-console-template for more information



using Prototype.Folder;
using File = Prototype.Folder.File;


var folder1 = new Folder()
{
    Name = "root"
};
var folder2 = new Folder()
{
    Name = "folder1 lvl 1"
};
var folder3 = new Folder()
{
    Name = "folder2 lvl 1"
};
var folder4 = new Folder()
{
    Name = "folder1 lvl 2"
};

var file1 = new File
{
    Name = "file1 lvl 1",
    Extension = "pdf"
};
var file2 = new File
{
    Name = "file2 lvl 2",
    Extension = "exe"
};

folder2.Add(folder4);
folder2.Add(file2);
folder1.Add(file1);
folder1.Add(folder2);
folder1.Add(folder3);


var clonedFolder = folder1.Clone();



var lvl1Folder = clonedFolder.GetFolder("folder1 lvl 1");

lvl1Folder.Add(new File
{
    Name = "new File",
    Extension = "doc"
});


lvl1Folder.Name = "New Name";

Console.WriteLine(folder1.ToString());

Console.WriteLine("Cloned");
Console.WriteLine(clonedFolder.ToString());



Console.WriteLine("Hello, World!");