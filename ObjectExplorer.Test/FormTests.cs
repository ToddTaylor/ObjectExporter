﻿using System;
using System.Collections.Generic;
using System.Threading;
using AccretionDynamics.ObjectExporter.VsPackage.UserInterface;
using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ObjectExporter.Core.Globals;
using ObjectExporter.UI;

namespace ObjectExplorer.Test
{
    [TestClass]
    public class FormTests
    {
        [TestMethod]
        public void LoadWindowGeneratedCode_CSharp()
        {
            var dic = new Dictionary<string, string>
            {
                {"test1", "var dic = new Dictionary<string, string>();"},
                {"test2", "public static int Complete() { return 2; }"},
            };

            FormDisplayGeneratedText form = new FormDisplayGeneratedText(dic, ExportType.CSharpObject);
            form.ShowDialog();

        }

        [TestMethod]
        public void LoadFilesCreatedDialog()
        {
            const string file = @"C:\Program Files (x86)\IIS Express\AppServer";
            FilesCreatedDialog dialog = new FilesCreatedDialog(file);
            dialog.ShowDialog();
        }

        [TestMethod]
        public void LoadWindowGeneratedCode_Xml()
        {
            var dic = new Dictionary<string, string>
            {
                {"test1", "var dic = new Dictionary<string, string>();"},
                {"test2", "public static int Complete() { return 2; }"},
            };

            FormDisplayGeneratedText form = new FormDisplayGeneratedText(dic, ExportType.Xml);
            form.ShowDialog();
        }

        [TestMethod]
        public void LoadWindowGeneratedCode_Json()
        {
            var dic = new Dictionary<string, string>
            {
                {"test1", "var dic = new Dictionary<string, string>();"},
                {"test2", TestResources.CurrentCustomerObject},
            };

            FormDisplayGeneratedText form = new FormDisplayGeneratedText(dic, ExportType.Json);
            form.ShowDialog();
        }

        [TestMethod]
        public void LoadFormSelectObjects()
        {
            Mock<Expression> expressionIsValidAlwaysReturnsTrue = new Mock<Expression>();
            expressionIsValidAlwaysReturnsTrue.Setup(x => x.IsValidValue).Returns(true);

            //FormSelectObjects form = new FormSelectObjects();
            //form.ShowDialog();
        }

        [TestMethod]
        public void LoadProgressDialog()
        {
            Mock<CancellationTokenSource> tksMock = new Mock<CancellationTokenSource>();
            ProgressDialog dialog = new ProgressDialog(tksMock.Object);
            dialog.ShowDialog();
        }
    }
}