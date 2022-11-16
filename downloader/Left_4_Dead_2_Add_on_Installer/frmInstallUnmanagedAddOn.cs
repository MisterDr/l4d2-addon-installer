using AOI;
using AOICL;
using AOICL.Functions.Windows;
using Left_4_Dead_2_Add_on_Installer.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace Left_4_Dead_2_Add_on_Installer
{
    [DesignerGenerated]
    public class frmInstallUnmanagedAddOn : Form
    {
        private IContainer components;

        [AccessedThroughProperty("TableLayoutPanel1")]
        private TableLayoutPanel _TableLayoutPanel1;

        [AccessedThroughProperty("OK_Button")]
        private Button _OK_Button;

        [AccessedThroughProperty("Cancel_Button")]
        private Button _Cancel_Button;

        [AccessedThroughProperty("Button1")]
        private Button _Button1;

        [AccessedThroughProperty("ListView1")]
        private ListView _ListView1;

        [AccessedThroughProperty("ColumnHeader1")]
        private ColumnHeader _ColumnHeader1;

        [AccessedThroughProperty("ColumnHeader2")]
        private ColumnHeader _ColumnHeader2;

        [AccessedThroughProperty("Button2")]
        private Button _Button2;

        [AccessedThroughProperty("Button3")]
        private Button _Button3;

        [AccessedThroughProperty("ContextMenuStrip1")]
        private ContextMenuStrip _ContextMenuStrip1;

        [AccessedThroughProperty("EditToolStripMenuItem")]
        private ToolStripMenuItem _EditToolStripMenuItem;

        [AccessedThroughProperty("Button4")]
        private Button _Button4;

        private List<string> installactions;

        private string filename;

        [AccessedThroughProperty("aoiig")]
        private InstallGenerator2 _aoiig;

        internal virtual TableLayoutPanel TableLayoutPanel1
        {
            get
            {
                return _TableLayoutPanel1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _TableLayoutPanel1 = value;
            }
        }

        internal virtual Button OK_Button
        {
            get
            {
                return _OK_Button;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = OK_Button_Click;
                if (_OK_Button != null)
                {
                    _OK_Button.Click -= value2;
                }
                _OK_Button = value;
                if (_OK_Button != null)
                {
                    _OK_Button.Click += value2;
                }
            }
        }

        internal virtual Button Cancel_Button
        {
            get
            {
                return _Cancel_Button;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = Cancel_Button_Click;
                if (_Cancel_Button != null)
                {
                    _Cancel_Button.Click -= value2;
                }
                _Cancel_Button = value;
                if (_Cancel_Button != null)
                {
                    _Cancel_Button.Click += value2;
                }
            }
        }

        internal virtual Button Button1
        {
            get
            {
                return _Button1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = Button1_Click;
                if (_Button1 != null)
                {
                    _Button1.Click -= value2;
                }
                _Button1 = value;
                if (_Button1 != null)
                {
                    _Button1.Click += value2;
                }
            }
        }

        internal virtual ListView ListView1
        {
            get
            {
                return _ListView1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ListView1 = value;
            }
        }

        internal virtual ColumnHeader ColumnHeader1
        {
            get
            {
                return _ColumnHeader1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ColumnHeader1 = value;
            }
        }

        internal virtual ColumnHeader ColumnHeader2
        {
            get
            {
                return _ColumnHeader2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ColumnHeader2 = value;
            }
        }

        internal virtual Button Button2
        {
            get
            {
                return _Button2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = Button2_Click;
                if (_Button2 != null)
                {
                    _Button2.Click -= value2;
                }
                _Button2 = value;
                if (_Button2 != null)
                {
                    _Button2.Click += value2;
                }
            }
        }

        internal virtual Button Button3
        {
            get
            {
                return _Button3;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = Button3_Click;
                if (_Button3 != null)
                {
                    _Button3.Click -= value2;
                }
                _Button3 = value;
                if (_Button3 != null)
                {
                    _Button3.Click += value2;
                }
            }
        }

        internal virtual ContextMenuStrip ContextMenuStrip1
        {
            get
            {
                return _ContextMenuStrip1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ContextMenuStrip1 = value;
            }
        }

        internal virtual ToolStripMenuItem EditToolStripMenuItem
        {
            get
            {
                return _EditToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = EditToolStripMenuItem_Click;
                if (_EditToolStripMenuItem != null)
                {
                    _EditToolStripMenuItem.Click -= value2;
                }
                _EditToolStripMenuItem = value;
                if (_EditToolStripMenuItem != null)
                {
                    _EditToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual Button Button4
        {
            get
            {
                return _Button4;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = Button4_Click_1;
                if (_Button4 != null)
                {
                    _Button4.Click -= value2;
                }
                _Button4 = value;
                if (_Button4 != null)
                {
                    _Button4.Click += value2;
                }
            }
        }

        public virtual InstallGenerator2 aoiig
        {
            get
            {
                return _aoiig;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _aoiig = value;
            }
        }

        public frmInstallUnmanagedAddOn()
        {
            base.FormClosing += frmInstallUnmanagedAddOn_FormClosing;
            base.Load += frmInstallUnmanagedAddOn_Load;
            installactions = new List<string>();
            aoiig = new InstallGenerator2();
            InitializeComponent();
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        [System.Diagnostics.DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Left_4_Dead_2_Add_on_Installer.frmInstallUnmanagedAddOn));
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.TableLayoutPanel1.SuspendLayout();
            this.ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            this.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            System.Drawing.Point point2 = (this.TableLayoutPanel1.Location = new System.Drawing.Point(489, 221));
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
            System.Drawing.Size size2 = (this.TableLayoutPanel1.Size = new System.Drawing.Size(146, 29));
            this.TableLayoutPanel1.TabIndex = 0;
            this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            point2 = (this.OK_Button.Location = new System.Drawing.Point(3, 3));
            this.OK_Button.Name = "OK_Button";
            size2 = (this.OK_Button.Size = new System.Drawing.Size(67, 23));
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "OK";
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            point2 = (this.Cancel_Button.Location = new System.Drawing.Point(76, 3));
            this.Cancel_Button.Name = "Cancel_Button";
            size2 = (this.Cancel_Button.Size = new System.Drawing.Size(67, 23));
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.Button1.Image = (System.Drawing.Image)resources.GetObject("Button1.Image");
            point2 = (this.Button1.Location = new System.Drawing.Point(12, 12));
            this.Button1.Name = "Button1";
            size2 = (this.Button1.Size = new System.Drawing.Size(205, 41));
            this.Button1.TabIndex = 4;
            this.Button1.Text = "Install from Archive";
            this.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button1.UseVisualStyleBackColor = true;
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2] { this.ColumnHeader1, this.ColumnHeader2 });
            this.ListView1.ContextMenuStrip = this.ContextMenuStrip1;
            point2 = (this.ListView1.Location = new System.Drawing.Point(12, 59));
            this.ListView1.Name = "ListView1";
            size2 = (this.ListView1.Size = new System.Drawing.Size(629, 145));
            this.ListView1.TabIndex = 5;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ColumnHeader1.Text = "File Name";
            this.ColumnHeader1.Width = 173;
            this.ColumnHeader2.Text = "Install Location";
            this.ColumnHeader2.Width = 285;
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.EditToolStripMenuItem });
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            size2 = (this.ContextMenuStrip1.Size = new System.Drawing.Size(95, 26));
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            size2 = (this.EditToolStripMenuItem.Size = new System.Drawing.Size(94, 22));
            this.EditToolStripMenuItem.Text = "&Edit";
            this.Button2.Image = (System.Drawing.Image)resources.GetObject("Button2.Image");
            point2 = (this.Button2.Location = new System.Drawing.Point(225, 12));
            this.Button2.Name = "Button2";
            size2 = (this.Button2.Size = new System.Drawing.Size(205, 41));
            this.Button2.TabIndex = 6;
            this.Button2.Text = "Install from Folder";
            this.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button2.UseVisualStyleBackColor = true;
            point2 = (this.Button3.Location = new System.Drawing.Point(225, 210));
            this.Button3.Name = "Button3";
            size2 = (this.Button3.Size = new System.Drawing.Size(205, 41));
            this.Button3.TabIndex = 7;
            this.Button3.Text = "Install Add-On";
            this.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button3.UseVisualStyleBackColor = true;
            this.Button4.Image = (System.Drawing.Image)resources.GetObject("Button4.Image");
            point2 = (this.Button4.Location = new System.Drawing.Point(436, 12));
            this.Button4.Name = "Button4";
            size2 = (this.Button4.Size = new System.Drawing.Size(205, 41));
            this.Button4.TabIndex = 8;
            this.Button4.Text = "Install from URL";
            this.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button4.UseVisualStyleBackColor = true;
            this.AcceptButton = this.OK_Button;
            System.Drawing.SizeF sizeF2 = (this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f));
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            size2 = (this.ClientSize = new System.Drawing.Size(647, 262));
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.Button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInstallUnmanagedAddOn";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Install Unmanaged Add-On";
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            if (Operators.CompareString(folderBrowserDialog.SelectedPath, "", TextCompare: false) == 0)
            {
                return;
            }
            filename = folderBrowserDialog.SelectedPath;
            installactions = aoiig.GenerateActionListForFolder(folderBrowserDialog.SelectedPath);
            foreach (string installaction in installactions)
            {
                ListViewItem listViewItem = new ListViewItem("   ");
                listViewItem.SubItems.Add(installaction);
                ListView1.Items.Add(listViewItem);
            }
        }

        private void frmInstallUnmanagedAddOn_FormClosing(object sender, FormClosingEventArgs e)
        {
            ListView1.Items.Clear();
        }

        private void frmInstallUnmanagedAddOn_Load(object sender, EventArgs e)
        {
            if (!UAC.IsUserAdmin())
            {
                Button B = Button3;
                UAC.AddShieldToButton(ref B);
                Button3 = B;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Zip Files|*.zip|Rar Files|*.rar";
            ListView1.Items.Clear();
            openFileDialog.ShowDialog();
            List<string> list = new List<string>();
            if (Operators.CompareString(openFileDialog.FileName, "", TextCompare: false) == 0)
            {
                return;
            }
            installactions = aoiig.GenerateActionListForArchive(openFileDialog.FileName);
            filename = openFileDialog.FileName;
            foreach (string installaction in installactions)
            {
                ListViewItem listViewItem = new ListViewItem("   ");
                listViewItem.SubItems.Add(installaction);
                ListView1.Items.Add(listViewItem);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(MySettingsProperty.Settings.L4D2InstallFolder);
            if (!Directory.Exists(AOIPaths.TasksPath()))
            {
                Directory.CreateDirectory(AOIPaths.TasksPath());
            }
            InstallFileGeneratorTasks installFileGeneratorTasks = new InstallFileGeneratorTasks();
            InstallFileGeneratorTask installFileGeneratorTask = new InstallFileGeneratorTask();
            installFileGeneratorTask.TaskType = InstallFileGeneratorTaskType.Install;
            AddOn addOn = new AddOn(filename);
            addOn.Downloads.Add(new AddOnDownload(filename));
            installFileGeneratorTask.AddOn = addOn;
            installFileGeneratorTasks.Tasks.Add(installFileGeneratorTask);
            string text = InstallFileGenerator.CreateJobFile(installFileGeneratorTasks, Path.Combine(AOIPaths.TasksPath(), Guid.NewGuid().ToString() + ".xml"));
            if (!UAC.IsUserAdmin())
            {
                Process process = new Process();
                try
                {
                    ProcessStartInfo processStartInfo2 = (process.StartInfo = new ProcessStartInfo("AOI.exe", "\"" + text + "\" \"" + MySettingsProperty.Settings.L4D2InstallFolder + "\""));
                    process.StartInfo.UseShellExecute = true;
                    process.Start();
                    int id = process.Id;
                    Hide();
                    while (Process.GetProcessById(id) != null)
                    {
                        Thread.Sleep(100);
                        MyProject.Application.DoEvents();
                    }
                    Show();
                    Interaction.AppActivate(Process.GetCurrentProcess().Id);
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    Exception ex2 = ex;
                    Show();
                    Interaction.AppActivate(Process.GetCurrentProcess().Id);
                    process = null;
                    ProjectData.ClearProjectError();
                }
                process = null;
            }
            else
            {
                Form1 form = new Form1(text, MySettingsProperty.Settings.L4D2InstallFolder);
                form.ShowDialog(this);
                form = null;
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (ListView1.SelectedItems.Count == 1)
            {
                num = ListView1.SelectedItems[0].Index;
                string defaultResponse = installactions[num];
                string value = Interaction.InputBox("Change Action", "Change Action", defaultResponse);
                installactions[num] = value;
                ListView1.Items[num].SubItems[1].Text = value;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(filename);
            Stream stream = File.OpenWrite(fileInfo.Name + ".xml");
            FileInfo fileInfo2 = new FileInfo(fileInfo.Name + ".xml");
            if (fileInfo2.Exists)
            {
                fileInfo2.Delete();
            }
            StreamWriter streamWriter = new StreamWriter(stream);
            foreach (string installaction in installactions)
            {
                streamWriter.WriteLine(installaction);
            }
            stream.Close();
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            InstallFileGeneratorTasks installFileGeneratorTasks = new InstallFileGeneratorTasks();
            InstallFileGeneratorTask installFileGeneratorTask = new InstallFileGeneratorTask();
            installFileGeneratorTask.TaskType = InstallFileGeneratorTaskType.Install;
            AddOn addOn = new AddOn(filename);
            string uRL = Interaction.InputBox("ENTER A URL", "URL INSTALL");
            addOn.Downloads.Add(new AddOnDownload(uRL));
            installFileGeneratorTask.AddOn = addOn;
            installFileGeneratorTasks.Tasks.Add(installFileGeneratorTask);
            string text = InstallFileGenerator.CreateJobFile(installFileGeneratorTasks, Path.Combine(AOIPaths.TasksPath(), Guid.NewGuid().ToString() + ".xml"));
            if (!UAC.IsUserAdmin())
            {
                Process process = new Process();
                try
                {
                    ProcessStartInfo processStartInfo2 = (process.StartInfo = new ProcessStartInfo("AOI.exe", text + " \"" + MySettingsProperty.Settings.L4D2InstallFolder + "\""));
                    process.Start();
                    while (!process.HasExited)
                    {
                        Thread.Sleep(100);
                        MyProject.Application.DoEvents();
                    }
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    Exception ex2 = ex;
                    process = null;
                    ProjectData.ClearProjectError();
                }
                process = null;
            }
            else
            {
                Form1 form = new Form1(text, MySettingsProperty.Settings.L4D2InstallFolder);
                form.ShowDialog(this);
                form = null;
            }
        }
    }
}
