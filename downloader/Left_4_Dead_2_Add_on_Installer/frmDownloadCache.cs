using AOICL;
using AOICL.Downloads;
using AOICL.Functions.GenericFunctions;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Left_4_Dead_2_Add_on_Installer
{
    [DesignerGenerated]
    public class frmDownloadCache : Form
    {
        private IContainer components;

        [AccessedThroughProperty("TableLayoutPanel1")]
        private TableLayoutPanel _TableLayoutPanel1;

        [AccessedThroughProperty("OK_Button")]
        private Button _OK_Button;

        [AccessedThroughProperty("Cancel_Button")]
        private Button _Cancel_Button;

        [AccessedThroughProperty("ListView1")]
        private ListView _ListView1;

        [AccessedThroughProperty("ColumnHeader1")]
        private ColumnHeader _ColumnHeader1;

        [AccessedThroughProperty("ColumnHeader2")]
        private ColumnHeader _ColumnHeader2;

        [AccessedThroughProperty("ColumnHeader3")]
        private ColumnHeader _ColumnHeader3;

        [AccessedThroughProperty("Button1")]
        private Button _Button1;

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

        internal virtual ListView ListView1
        {
            get
            {
                return _ListView1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = ListView1_SelectedIndexChanged;
                if (_ListView1 != null)
                {
                    _ListView1.SelectedIndexChanged -= value2;
                }
                _ListView1 = value;
                if (_ListView1 != null)
                {
                    _ListView1.SelectedIndexChanged += value2;
                }
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

        internal virtual ColumnHeader ColumnHeader3
        {
            get
            {
                return _ColumnHeader3;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ColumnHeader3 = value;
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

        public frmDownloadCache()
        {
            base.Load += frmDownloadCache_Load;
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
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.Button1 = new System.Windows.Forms.Button();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            this.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            System.Drawing.Point point2 = (this.TableLayoutPanel1.Location = new System.Drawing.Point(277, 204));
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
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[3] { this.ColumnHeader1, this.ColumnHeader2, this.ColumnHeader3 });
            this.ListView1.FullRowSelect = true;
            point2 = (this.ListView1.Location = new System.Drawing.Point(12, 12));
            this.ListView1.MultiSelect = false;
            this.ListView1.Name = "ListView1";
            size2 = (this.ListView1.Size = new System.Drawing.Size(411, 183));
            this.ListView1.TabIndex = 1;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ColumnHeader1.Text = "URL";
            this.ColumnHeader1.Width = 109;
            this.ColumnHeader2.Text = "File Name";
            this.ColumnHeader2.Width = 137;
            this.ColumnHeader3.Text = "Size";
            this.ColumnHeader3.Width = 121;
            this.Button1.Enabled = false;
            point2 = (this.Button1.Location = new System.Drawing.Point(12, 201));
            this.Button1.Name = "Button1";
            size2 = (this.Button1.Size = new System.Drawing.Size(75, 23));
            this.Button1.TabIndex = 2;
            this.Button1.Text = "Delete";
            this.Button1.UseVisualStyleBackColor = true;
            this.AcceptButton = this.OK_Button;
            System.Drawing.SizeF sizeF2 = (this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f));
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            size2 = (this.ClientSize = new System.Drawing.Size(435, 245));
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDownloadCache";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Download Cache";
            this.TableLayoutPanel1.ResumeLayout(false);
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

        private void frmDownloadCache_Load(object sender, EventArgs e)
        {
            LoadDC();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ListView1.SelectedItems.Count > 0)
                {
                    Button1.Enabled = true;
                }
                else
                {
                    Button1.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
        }

        public void LoadDC()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "L4D2AOI");
            string text = Path.Combine(path, "Temp");
            string text2 = Path.Combine(path, "Downloads");
            ListView1.Items.Clear();
            foreach (DownloadCacheFile item in DownloadCache.Cache)
            {
                if (item.Exists)
                {
                    ListViewItem listViewItem = new ListViewItem(item.URL);
                    listViewItem.SubItems.Add(item.FileName);
                    if (!item.Exists)
                    {
                        listViewItem.BackColor = Color.Red;
                    }
                    else
                    {
                        listViewItem.SubItems.Add(BytesToSI.BytesToSI2(item.Size));
                    }
                    ListView1.Items.Add(listViewItem);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string text = ListView1.SelectedItems[0].SubItems[1].Text;
                if (Interaction.MsgBox("Are you sure you wish to delete the file: " + text + "?", MsgBoxStyle.YesNo) == MsgBoxResult.Yes)
                {
                    try
                    {
                        File.Delete(Path.Combine(AOIPaths.DownloadsPath(), text));
                    }
                    catch (Exception ex)
                    {
                        ProjectData.SetProjectError(ex);
                        Exception ex2 = ex;
                        ProjectData.ClearProjectError();
                    }
                }
            }
            catch (Exception ex3)
            {
                ProjectData.SetProjectError(ex3);
                Exception ex4 = ex3;
                ProjectData.ClearProjectError();
            }
            LoadDC();
        }
    }
}
