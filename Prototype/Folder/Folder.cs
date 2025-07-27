using System.Text;

namespace Prototype.Folder;

public class Folder : IClone<Folder>
{
    private readonly IList<Folder> _folders = new List<Folder>();
    private readonly IList<File> _files = new List<File>();


    public string Name { get; set; }
    public void Add(Folder folder)
    {
        if (folder == null)
        {
            throw new ArgumentNullException(nameof(folder));
        }
        _folders.Add(folder);
    }

    public void Add(File file)
    {
        if (file == null)
        {
            throw new ArgumentNullException(nameof(file));
        }
        _files.Add(file);
    }

    public Folder GetFolder(string name)
    {
        var folder = _folders.FirstOrDefault(x => x.Name == name);
        if (folder == null)
        {
            throw new ArgumentException($"Folder {name} does not exist.");
        }
        return folder;
    }

    public Folder Clone()
    {
        var result = new Folder();
        result.Name = Name;
        foreach (Folder folder in this._folders)
        {
            result.Add(folder.Clone());
        }

        foreach (File file in this._files)
        {
            result.Add(file.Clone());
        }
        
        return result;
    }

    public override string ToString()
    {
        var result = new StringBuilder();
        ToStringHelper(result, 2);
        
        return result.ToString();
    }

    private void ToStringHelper(StringBuilder sb, int indent)
    {
        sb.AppendLine($"{new string(' ', indent)}{Name}/");
        foreach (var folder in this._folders)
        {
            folder.ToStringHelper(sb, indent + 2);
        }

        foreach (var file in this._files)
        {
            sb.AppendLine($"{new string(' ', indent + 2)}{file.ToString()}");
        }
    }
}