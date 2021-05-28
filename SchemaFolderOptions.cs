﻿namespace SsmsSchemaFolders
{
    using System.ComponentModel;
    using Localization;
    using Microsoft.VisualStudio.Shell;
    using System.Windows.Forms;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System;
    using System.Reflection;

    public class SchemaFolderOptions : DialogPage, ISchemaFolderOptions
    {
        //public static string filePath = @"C:\Users\ahmed.noor\Desktop\SSMS-Schema-Folders\Prefix.txt";

        static string filePath = Resource.txtFile;

        [CategoryResources(nameof(SchemaFolderOptions) + "Active")]
        [DisplayNameResources(nameof(SchemaFolderOptions) + nameof(Enabled))]
        [DescriptionResources(nameof(SchemaFolderOptions) + nameof(Enabled))]
        [DefaultValue(true)]
        public bool Enabled { get; set; } = true;

        [CategoryResources(nameof(SchemaFolderOptions) + "FolderDisplayOptions")]
        [DisplayNameResources(nameof(SchemaFolderOptions) + nameof(AppendDot))]
        [DescriptionResources(nameof(SchemaFolderOptions) + nameof(AppendDot))]
        [DefaultValue(true)]
        public bool AppendDot { get; set; } = true;

        [CategoryResources(nameof(SchemaFolderOptions) + "FolderDisplayOptions")]
        [DisplayNameResources(nameof(SchemaFolderOptions) + nameof(CloneParentNode))]
        [DescriptionResources(nameof(SchemaFolderOptions) + nameof(CloneParentNode))]
        [DefaultValue(true)]
        public bool CloneParentNode { get; set; } = true;

        [CategoryResources(nameof(SchemaFolderOptions) + "FolderDisplayOptions")]
        [DisplayNameResources(nameof(SchemaFolderOptions) + nameof(UseObjectIcon))]
        [DescriptionResources(nameof(SchemaFolderOptions) + nameof(UseObjectIcon))]
        [DefaultValue(true)]
        public bool UseObjectIcon { get; set; } = true;

        [CategoryResources(nameof(SchemaFolderOptions) + "ObjectDisplayOptions")]
        [DisplayNameResources(nameof(SchemaFolderOptions) + nameof(RenameNode))]
        [DescriptionResources(nameof(SchemaFolderOptions) + nameof(RenameNode))]
        [DefaultValue(false)]
        public bool RenameNode { get; set; } = false;

        [CategoryResources(nameof(SchemaFolderOptions) + "FolderDisplayOptions")]
        [DisplayNameResources(nameof(SchemaFolderOptions) + nameof(Prefix))]
        [DescriptionResources(nameof(SchemaFolderOptions) + nameof(Prefix))]
        [DefaultValue("dbo")]
        public string[] Prefix { get; set; } = File.ReadAllLines(filePath);


    }
}
 