using Left_4_Dead_2_Add_on_Installer.My;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Left_4_Dead_2_Add_on_Installer
{
    [DesignerGenerated]
    public class frmAbout : Form
    {
        [AccessedThroughProperty("TableLayoutPanel")]
        private TableLayoutPanel _TableLayoutPanel;

        [AccessedThroughProperty("LogoPictureBox")]
        private PictureBox _LogoPictureBox;

        [AccessedThroughProperty("LabelProductName")]
        private Label _LabelProductName;

        [AccessedThroughProperty("LabelVersion")]
        private Label _LabelVersion;

        [AccessedThroughProperty("LabelCompanyName")]
        private Label _LabelCompanyName;

        [AccessedThroughProperty("TextBoxDescription")]
        private TextBox _TextBoxDescription;

        [AccessedThroughProperty("OKButton")]
        private Button _OKButton;

        [AccessedThroughProperty("LabelCopyright")]
        private Label _LabelCopyright;

        private IContainer components;

        internal virtual TableLayoutPanel TableLayoutPanel
        {
            get
            {
                return _TableLayoutPanel;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _TableLayoutPanel = value;
            }
        }

        internal virtual PictureBox LogoPictureBox
        {
            get
            {
                return _LogoPictureBox;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LogoPictureBox = value;
            }
        }

        internal virtual Label LabelProductName
        {
            get
            {
                return _LabelProductName;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LabelProductName = value;
            }
        }

        internal virtual Label LabelVersion
        {
            get
            {
                return _LabelVersion;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LabelVersion = value;
            }
        }

        internal virtual Label LabelCompanyName
        {
            get
            {
                return _LabelCompanyName;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LabelCompanyName = value;
            }
        }

        internal virtual TextBox TextBoxDescription
        {
            get
            {
                return _TextBoxDescription;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _TextBoxDescription = value;
            }
        }

        internal virtual Button OKButton
        {
            get
            {
                return _OKButton;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = OKButton_Click;
                if (_OKButton != null)
                {
                    _OKButton.Click -= value2;
                }
                _OKButton = value;
                if (_OKButton != null)
                {
                    _OKButton.Click += value2;
                }
            }
        }

        internal virtual Label LabelCopyright
        {
            get
            {
                return _LabelCopyright;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _LabelCopyright = value;
            }
        }

        public frmAbout()
        {
            base.Load += frmAbout_Load;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Left_4_Dead_2_Add_on_Installer.frmAbout));
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.LabelProductName = new System.Windows.Forms.Label();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.LabelCopyright = new System.Windows.Forms.Label();
            this.LabelCompanyName = new System.Windows.Forms.Label();
            this.TextBoxDescription = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.LogoPictureBox).BeginInit();
            this.SuspendLayout();
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33f));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67f));
            this.TableLayoutPanel.Controls.Add(this.LogoPictureBox, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.LabelProductName, 1, 0);
            this.TableLayoutPanel.Controls.Add(this.LabelVersion, 1, 1);
            this.TableLayoutPanel.Controls.Add(this.LabelCopyright, 1, 2);
            this.TableLayoutPanel.Controls.Add(this.LabelCompanyName, 1, 3);
            this.TableLayoutPanel.Controls.Add(this.TextBoxDescription, 1, 4);
            this.TableLayoutPanel.Controls.Add(this.OKButton, 1, 5);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Drawing.Point point2 = (this.TableLayoutPanel.Location = new System.Drawing.Point(9, 9));
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 6;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10f));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10f));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10f));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10f));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10f));
            System.Drawing.Size size2 = (this.TableLayoutPanel.Size = new System.Drawing.Size(396, 258));
            this.TableLayoutPanel.TabIndex = 0;
            this.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoPictureBox.Image = (System.Drawing.Image)resources.GetObject("logo2");
            point2 = (this.LogoPictureBox.Location = new System.Drawing.Point(3, 3));
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.TableLayoutPanel.SetRowSpan(this.LogoPictureBox, 6);
            size2 = (this.LogoPictureBox.Size = new System.Drawing.Size(124, 252));
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            this.LabelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            point2 = (this.LabelProductName.Location = new System.Drawing.Point(136, 0));
            System.Windows.Forms.Padding padding2 = (this.LabelProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0));
            size2 = (this.LabelProductName.MaximumSize = new System.Drawing.Size(0, 17));
            this.LabelProductName.Name = "LabelProductName";
            size2 = (this.LabelProductName.Size = new System.Drawing.Size(257, 17));
            this.LabelProductName.TabIndex = 0;
            this.LabelProductName.Text = "Product Name";
            this.LabelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            point2 = (this.LabelVersion.Location = new System.Drawing.Point(136, 25));
            padding2 = (this.LabelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0));
            size2 = (this.LabelVersion.MaximumSize = new System.Drawing.Size(0, 17));
            this.LabelVersion.Name = "LabelVersion";
            size2 = (this.LabelVersion.Size = new System.Drawing.Size(257, 17));
            this.LabelVersion.TabIndex = 0;
            this.LabelVersion.Text = "Version";
            this.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            point2 = (this.LabelCopyright.Location = new System.Drawing.Point(136, 50));
            padding2 = (this.LabelCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0));
            size2 = (this.LabelCopyright.MaximumSize = new System.Drawing.Size(0, 17));
            this.LabelCopyright.Name = "LabelCopyright";
            size2 = (this.LabelCopyright.Size = new System.Drawing.Size(257, 17));
            this.LabelCopyright.TabIndex = 0;
            this.LabelCopyright.Text = "Copyright";
            this.LabelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            point2 = (this.LabelCompanyName.Location = new System.Drawing.Point(136, 75));
            padding2 = (this.LabelCompanyName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0));
            size2 = (this.LabelCompanyName.MaximumSize = new System.Drawing.Size(0, 17));
            this.LabelCompanyName.Name = "LabelCompanyName";
            size2 = (this.LabelCompanyName.Size = new System.Drawing.Size(257, 17));
            this.LabelCompanyName.TabIndex = 0;
            this.LabelCompanyName.Text = "Company Name";
            this.LabelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TextBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            point2 = (this.TextBoxDescription.Location = new System.Drawing.Point(136, 103));
            padding2 = (this.TextBoxDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3));
            this.TextBoxDescription.Multiline = true;
            this.TextBoxDescription.Name = "TextBoxDescription";
            this.TextBoxDescription.ReadOnly = true;
            this.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            size2 = (this.TextBoxDescription.Size = new System.Drawing.Size(257, 123));
            this.TextBoxDescription.TabIndex = 0;
            this.TextBoxDescription.TabStop = false;
            this.TextBoxDescription.Text = resources.GetString("TextBoxDescription.Text");
            this.OKButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            point2 = (this.OKButton.Location = new System.Drawing.Point(318, 232));
            this.OKButton.Name = "OKButton";
            size2 = (this.OKButton.Size = new System.Drawing.Size(75, 23));
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "&OK";
            System.Drawing.SizeF sizeF2 = (this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f));
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.OKButton;
            size2 = (this.ClientSize = new System.Drawing.Size(414, 276));
            this.Controls.Add(this.TableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            padding2 = (this.Padding = new System.Windows.Forms.Padding(9));
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About Left 4 Dead 2 Add-On Installer";
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.LogoPictureBox).EndInit();
            this.ResumeLayout(false);
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            string arg = ((Operators.CompareString(MyProject.Application.Info.Title, "", TextCompare: false) == 0) ? Path.GetFileNameWithoutExtension(MyProject.Application.Info.AssemblyName) : MyProject.Application.Info.Title);
            Text = $"About {arg}";
            LabelProductName.Text = MyProject.Application.Info.ProductName;
            LabelVersion.Text = $"Version {MyProject.Application.Info.Version.ToString()}";
            LabelCopyright.Text = MyProject.Application.Info.Copyright;
            LabelCompanyName.Text = MyProject.Application.Info.CompanyName;
            TextBoxDescription.Text = MyProject.Application.Info.Description;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
        }
    }
}
