﻿// <copyright company="Aspose Pty Ltd">
//   Copyright (C) 2011-2020 GroupDocs. All Rights Reserved.
// </copyright>

namespace GroupDocs.Metadata.Examples.CSharp.AdvancedUsage.ManagingMetadataForSpecificFormats.Document.Spreadsheet
{
    using System;
    using Formats.Document;

    /// <summary>
    /// This code snippet demonstrates how to extract built-in metadata properties from a spreadsheet.
    /// </summary>
    public static class SpreadsheetReadBuiltInProperties
    {
        public static void Run()
        {
            using (Metadata metadata = new Metadata(Constants.InputXlsx))
            {
                var root = metadata.GetRootPackage<SpreadsheetRootPackage>();

                Console.WriteLine(root.DocumentProperties.Author);
                Console.WriteLine(root.DocumentProperties.CreatedTime);
                Console.WriteLine(root.DocumentProperties.Company);
                Console.WriteLine(root.DocumentProperties.Category);
                Console.WriteLine(root.DocumentProperties.Keywords);
                Console.WriteLine(root.DocumentProperties.Language);
                Console.WriteLine(root.DocumentProperties.ContentType);

                // ... 
            }
        }
    }
}
