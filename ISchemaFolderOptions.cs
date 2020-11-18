﻿
namespace SsmsSchemaFolders
{
    public interface ISchemaFolderOptions
    {
        bool Enabled { get; }
        bool AppendDot { get; }
        bool CloneParentNode { get; }
        bool UseObjectIcon { get; }
        bool RenameNode { get; }
        string TestNode { get; }
    }
}
