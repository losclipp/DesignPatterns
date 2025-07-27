namespace Prototype.Folder;

public class File : IClone<File>
{
    public string Name { get; set; }
    public string Extension { get; set; }
    
    public File Clone()
    {
        return new File
        {
            Name = Name,
            Extension = Extension,
        };
    }

    public override string ToString()
    {
        return $"{Name}.{Extension}";
    }
}