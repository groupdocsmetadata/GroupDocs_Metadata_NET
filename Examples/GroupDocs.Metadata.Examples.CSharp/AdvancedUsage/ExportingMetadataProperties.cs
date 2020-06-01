﻿// <copyright company="Aspose Pty Ltd">
//   Copyright (C) 2011-2019 GroupDocs. All Rights Reserved.
// </copyright>

namespace GroupDocs.Metadata.Examples.CSharp.AdvancedUsage
{
    using GroupDocs.Metadata.Common;
    using GroupDocs.Metadata.Export;

    /// <summary>
    /// This example demonstrates how to export metadata properties to an Excel workbook.
    /// </summary>
    public class ExportingMetadataProperties
    {
        public static void Run()
        {
            using (Metadata metadata = new Metadata(Constants.InputDoc))
            {
                RootMetadataPackage root = metadata.GetRootPackage();
                if (root != null)
                {
                    // Initialize the export manager with the root metadata package to export the whole metadata tree
                    ExportManager manager = new ExportManager(root);

                    manager.Export(Constants.OutputXls, ExportFormat.Xls);
                }
            }
        }
    }
}
