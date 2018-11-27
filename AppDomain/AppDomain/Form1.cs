using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using AppDomainLoadManager;
using InteropAsm;

namespace AppDomainTest {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK) {
                    AppDomainSetup setup = new AppDomainSetup();
                    setup.ApplicationBase = Path.GetDirectoryName(openFileDialog1.FileName);
                    setup.ApplicationName = Guid.NewGuid().ToString();
                    setup.ShadowCopyDirectories = Path.GetDirectoryName(openFileDialog1.FileName) + ";";
                    setup.CachePath = Path.Combine(Path.GetDirectoryName(openFileDialog1.FileName), "Shadow");
                    setup.DisallowCodeDownload = false;
                    setup.ShadowCopyFiles = "true";
                    setup.ConfigurationFile = openFileDialog1.FileName + ".config";
                    AppDomain domain = AppDomain.CreateDomain(Guid.NewGuid().ToString(), null, setup);
                    Type manager = typeof(LoadManager);
                    LoadManager addInManager = (LoadManager)domain.CreateInstanceAndUnwrap(manager.Assembly.FullName, manager.FullName);
                    IAddIn addIn = addInManager.LoadAddIn(openFileDialog1.FileName, "ClassLibrary1.Class1");

                    ListViewItem li = new ListViewItem(new string[] { addIn.Text, addInManager.GetAssemblyVersionNonLocking(openFileDialog1.FileName).ToString(), openFileDialog1.FileName, addInManager.GetAssemblyLastLoadedAssemblyPath() });
                    li.Group = listView1.Groups[0];
                    li.Tag = domain;
                    listView1.Items.Add(li);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if(listView1.SelectedIndices.Count > 0) {
                foreach(ListViewItem li in listView1.SelectedItems) {
                    AppDomain ad = li.Tag as AppDomain;
                    if(ad != null) {
                        li.Group = listView1.Groups[1];
                        string cachePath = ad.SetupInformation.CachePath;
                        AppDomain.Unload(ad);
                        Directory.Delete(GetRootAppShadowPath(li.SubItems[3].Text), true);
                    }
                }
            }
        }
        string GetRootAppShadowPath(string text) {
            for (int i = 0; i < 5; i++)
                text = Path.GetDirectoryName(text);
            return text;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0) {
                foreach(ListViewItem li in listView1.SelectedItems) {
                    AppDomain ad = li.Tag as AppDomain;
                    if(ad != null) {
                        MessageBox.Show(ad.ShadowCopyFiles.ToString()+"\r\n"+ad.SetupInformation.CachePath);
                    }
                }
            }
        }
    }
}