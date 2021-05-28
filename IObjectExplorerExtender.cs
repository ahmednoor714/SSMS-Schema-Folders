﻿using System.Collections.Generic;
using System.Windows.Forms;

namespace SsmsSchemaFolders
{
    public interface IObjectExplorerExtender
    {
        bool GetNodeExpanding(TreeNode node);
        string GetNodeUrnPath(TreeNode node);
        TreeView GetObjectExplorerTreeView();
        void RenameNode(TreeNode node);
        int ReorganizeNodes(TreeNode node, string nodeTag);
        //List<string> TestNode(string node);
        string[] Prefix(string node);
    }
}
