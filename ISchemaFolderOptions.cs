
using System.Collections.Generic;
using System.Windows.Forms;

namespace SsmsSchemaFolders
{
    public interface ISchemaFolderOptions
    {
        bool Enabled { get; }
        bool AppendDot { get; }
        bool CloneParentNode { get; }
        bool UseObjectIcon { get; }
        bool RenameNode { get; }
        //List<string> TestNode { get; set; }
        string[] Prefix { get;  }

    }
}
