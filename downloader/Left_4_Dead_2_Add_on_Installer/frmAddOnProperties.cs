using AOICL;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Left_4_Dead_2_Add_on_Installer
{
    [DesignerGenerated]
    public class frmAddOnProperties : Form
    {
        private IContainer components;

        [AccessedThroughProperty("TableLayoutPanel1")]
        private TableLayoutPanel _TableLayoutPanel1;

        [AccessedThroughProperty("OK_Button")]
        private Button _OK_Button;

        [AccessedThroughProperty("Cancel_Button")]
        private Button _Cancel_Button;

        [AccessedThroughProperty("TabControl1")]
        private TabControl _TabControl1;

        [AccessedThroughProperty("TabPage1")]
        private TabPage _TabPage1;

        [AccessedThroughProperty("TabPage2")]
        private TabPage _TabPage2;

        [AccessedThroughProperty("ListView1")]
        private ListView _ListView1;

        [AccessedThroughProperty("ColumnHeader1")]
        private ColumnHeader _ColumnHeader1;

        [AccessedThroughProperty("ColumnHeader2")]
        private ColumnHeader _ColumnHeader2;

        [AccessedThroughProperty("LinkLabel1")]
        private LinkLabel _LinkLabel1;

        [AccessedThroughProperty("Label4")]
        private Label _Label4;

        [AccessedThroughProperty("Label3")]
        private Label _Label3;

        [AccessedThroughProperty("Label2")]
        private Label _Label2;

        [AccessedThroughProperty("Label1")]
        private Label _Label1;

        private AddOn a;

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

        internal virtual TabControl TabControl1
        {
            get
            {
                return _TabControl1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _TabControl1 = value;
            }
        }

        internal virtual TabPage TabPage1
        {
            get
            {
                return _TabPage1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _TabPage1 = value;
            }
        }

        internal virtual TabPage TabPage2
        {
            get
            {
                return _TabPage2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _TabPage2 = value;
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

        internal virtual LinkLabel LinkLabel1
        {
            get
            {
                return _LinkLabel1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                LinkLabelLinkClickedEventHandler value2 = LinkLabel1_LinkClicked;
                if (_LinkLabel1 != null)
                {
                    _LinkLabel1.LinkClicked -= value2;
                }
                _LinkLabel1 = value;
                if (_LinkLabel1 != null)
                {
                    _LinkLabel1.LinkClicked += value2;
                }
            }
        }

        internal virtual Label Label4
        {
            get
            {
                return _Label4;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _Label4 = value;
            }
        }

        internal virtual Label Label3
        {
            get
            {
                return _Label3;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _Label3 = value;
            }
        }

        internal virtual Label Label2
        {
            get
            {
                return _Label2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _Label2 = value;
            }
        }

        internal virtual Label Label1
        {
            get
            {
                return _Label1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _Label1 = value;
            }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Left_4_Dead_2_Add_on_Installer.frmAddOnProperties));
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.TableLayoutPanel1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.SuspendLayout();
            this.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            System.Drawing.Point point2 = (this.TableLayoutPanel1.Location = new System.Drawing.Point(277, 274));
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
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            point2 = (this.TabControl1.Location = new System.Drawing.Point(12, 12));
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            size2 = (this.TabControl1.Size = new System.Drawing.Size(411, 256));
            this.TabControl1.TabIndex = 1;
            this.TabPage1.Controls.Add(this.LinkLabel1);
            this.TabPage1.Controls.Add(this.Label4);
            this.TabPage1.Controls.Add(this.Label3);
            this.TabPage1.Controls.Add(this.Label2);
            this.TabPage1.Controls.Add(this.Label1);
            point2 = (this.TabPage1.Location = new System.Drawing.Point(4, 22));
            this.TabPage1.Name = "TabPage1";
            System.Windows.Forms.Padding padding2 = (this.TabPage1.Padding = new System.Windows.Forms.Padding(3));
            size2 = (this.TabPage1.Size = new System.Drawing.Size(403, 230));
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "General";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.LinkLabel1.AutoSize = true;
            point2 = (this.LinkLabel1.Location = new System.Drawing.Point(6, 55));
            this.LinkLabel1.Name = "LinkLabel1";
            size2 = (this.LinkLabel1.Size = new System.Drawing.Size(59, 13));
            this.LinkLabel1.TabIndex = 4;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "LinkLabel1";
            this.Label4.AutoSize = true;
            point2 = (this.Label4.Location = new System.Drawing.Point(6, 42));
            this.Label4.Name = "Label4";
            size2 = (this.Label4.Size = new System.Drawing.Size(39, 13));
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Label4";
            this.Label3.AutoSize = true;
            point2 = (this.Label3.Location = new System.Drawing.Point(6, 29));
            this.Label3.Name = "Label3";
            size2 = (this.Label3.Size = new System.Drawing.Size(39, 13));
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Label3";
            this.Label2.AutoSize = true;
            point2 = (this.Label2.Location = new System.Drawing.Point(6, 16));
            this.Label2.Name = "Label2";
            size2 = (this.Label2.Size = new System.Drawing.Size(39, 13));
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Label2";
            this.Label1.AutoSize = true;
            point2 = (this.Label1.Location = new System.Drawing.Point(6, 3));
            this.Label1.Name = "Label1";
            size2 = (this.Label1.Size = new System.Drawing.Size(39, 13));
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Label1";
            this.TabPage2.Controls.Add(this.ListView1);
            point2 = (this.TabPage2.Location = new System.Drawing.Point(4, 22));
            this.TabPage2.Name = "TabPage2";
            padding2 = (this.TabPage2.Padding = new System.Windows.Forms.Padding(3));
            size2 = (this.TabPage2.Size = new System.Drawing.Size(403, 230));
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Add-On Info";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2] { this.ColumnHeader1, this.ColumnHeader2 });
            this.ListView1.FullRowSelect = true;
            point2 = (this.ListView1.Location = new System.Drawing.Point(6, 6));
            this.ListView1.Name = "ListView1";
            size2 = (this.ListView1.Size = new System.Drawing.Size(391, 218));
            this.ListView1.TabIndex = 0;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ColumnHeader1.Text = "Key";
            this.ColumnHeader1.Width = 129;
            this.ColumnHeader2.Text = "Value";
            this.AcceptButton = this.OK_Button;
            System.Drawing.SizeF sizeF2 = (this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f));
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            size2 = (this.ClientSize = new System.Drawing.Size(435, 315));
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddOnProperties";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Properties";
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
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

        private void frmAddOnProperties_Load(object sender, EventArgs e)
        {
            Label1.Text = "Title: " + a.Title;
            Label2.Text = "Author: " + a.AddOnInfo.Author;
            Label3.Text = "File Path: " + a.VpkFilePath;
            Label4.Text = "Size: UNKNOWN";
            try
            {
                LinkLabel1.Text = "Add-On Homepage: " + a.AddOnInfo.URL;
                LinkLabel1.Links.Add(0, LinkLabel1.Text.Length, a.AddOnInfo.URL);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                LinkLabel1.Text = "No URL Defined";
                ProjectData.ClearProjectError();
            }
            foreach (KeyValuePair<string, string> addOnDatum in a.AddOnInfo.AddOnData)
            {
                ListViewItem listViewItem = new ListViewItem(addOnDatum.Key);
                listViewItem.SubItems.Add(addOnDatum.Value);
                ListView1.Items.Add(listViewItem);
            }
        }

        public frmAddOnProperties()
        {
            base.Load += frmAddOnProperties_Load;
            InitializeComponent();
        }

        public frmAddOnProperties(AddOn Addon)
        {
            base.Load += frmAddOnProperties_Load;
            InitializeComponent();
            a = Addon;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(a.AddOnInfo.URL);
        }
    }
}
