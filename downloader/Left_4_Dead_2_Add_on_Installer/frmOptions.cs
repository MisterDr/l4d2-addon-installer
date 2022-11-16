using AOICL;
using Left_4_Dead_2_Add_on_Installer.My;
using Microsoft.VisualBasic;
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
    public class frmOptions : Form
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

        [AccessedThroughProperty("CheckBox2")]
        private CheckBox _CheckBox2;

        [AccessedThroughProperty("CheckBox1")]
        private CheckBox _CheckBox1;

        [AccessedThroughProperty("Button2")]
        private Button _Button2;

        [AccessedThroughProperty("Button1")]
        private Button _Button1;

        [AccessedThroughProperty("TextBox1")]
        private TextBox _TextBox1;

        [AccessedThroughProperty("Label1")]
        private Label _Label1;

        [AccessedThroughProperty("cmbHUMAO")]
        private CheckBox _cmbHUMAO;

        [AccessedThroughProperty("cmbHOOD")]
        private CheckBox _cmbHOOD;

        [AccessedThroughProperty("Button4")]
        private Button _Button4;

        [AccessedThroughProperty("Button3")]
        private Button _Button3;

        [AccessedThroughProperty("ColorDialog1")]
        private ColorDialog _ColorDialog1;

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

        internal virtual CheckBox CheckBox2
        {
            get
            {
                return _CheckBox2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _CheckBox2 = value;
            }
        }

        internal virtual CheckBox CheckBox1
        {
            get
            {
                return _CheckBox1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _CheckBox1 = value;
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

        internal virtual TextBox TextBox1
        {
            get
            {
                return _TextBox1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _TextBox1 = value;
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

        internal virtual CheckBox cmbHUMAO
        {
            get
            {
                return _cmbHUMAO;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _cmbHUMAO = value;
            }
        }

        internal virtual CheckBox cmbHOOD
        {
            get
            {
                return _cmbHOOD;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _cmbHOOD = value;
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
                EventHandler value2 = Button4_Click;
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

        internal virtual ColorDialog ColorDialog1
        {
            get
            {
                return _ColorDialog1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ColorDialog1 = value;
            }
        }

        public frmOptions()
        {
            base.Load += frmOptions_Load;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Left_4_Dead_2_Add_on_Installer.frmOptions));
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OK_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.cmbHUMAO = new System.Windows.Forms.CheckBox();
            this.cmbHOOD = new System.Windows.Forms.CheckBox();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.ColorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.TableLayoutPanel1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.SuspendLayout();
            this.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            System.Drawing.Point point2 = (this.TableLayoutPanel1.Location = new System.Drawing.Point(277, 319));
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
            point2 = (this.TabControl1.Location = new System.Drawing.Point(12, 12));
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            size2 = (this.TabControl1.Size = new System.Drawing.Size(411, 301));
            this.TabControl1.TabIndex = 7;
            this.TabPage1.Controls.Add(this.Button4);
            this.TabPage1.Controls.Add(this.Button3);
            this.TabPage1.Controls.Add(this.cmbHUMAO);
            this.TabPage1.Controls.Add(this.cmbHOOD);
            this.TabPage1.Controls.Add(this.CheckBox2);
            this.TabPage1.Controls.Add(this.CheckBox1);
            this.TabPage1.Controls.Add(this.Button2);
            this.TabPage1.Controls.Add(this.Button1);
            this.TabPage1.Controls.Add(this.TextBox1);
            this.TabPage1.Controls.Add(this.Label1);
            point2 = (this.TabPage1.Location = new System.Drawing.Point(4, 22));
            this.TabPage1.Name = "TabPage1";
            System.Windows.Forms.Padding padding2 = (this.TabPage1.Padding = new System.Windows.Forms.Padding(3));
            size2 = (this.TabPage1.Size = new System.Drawing.Size(403, 275));
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "General";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.cmbHUMAO.AutoSize = true;
            point2 = (this.cmbHUMAO.Location = new System.Drawing.Point(9, 143));
            this.cmbHUMAO.Name = "cmbHUMAO";
            size2 = (this.cmbHUMAO.Size = new System.Drawing.Size(169, 17));
            this.cmbHUMAO.TabIndex = 14;
            this.cmbHUMAO.Text = "Highlight Unmanaged AddOns";
            this.cmbHUMAO.UseVisualStyleBackColor = true;
            this.cmbHOOD.AutoSize = true;
            point2 = (this.cmbHOOD.Location = new System.Drawing.Point(9, 120));
            this.cmbHOOD.Name = "cmbHOOD";
            size2 = (this.cmbHOOD.Size = new System.Drawing.Size(166, 17));
            this.cmbHOOD.TabIndex = 13;
            this.cmbHOOD.Text = "Highlight Out of Date AddOns";
            this.cmbHOOD.UseVisualStyleBackColor = true;
            this.CheckBox2.AutoSize = true;
            point2 = (this.CheckBox2.Location = new System.Drawing.Point(9, 97));
            this.CheckBox2.Name = "CheckBox2";
            size2 = (this.CheckBox2.Size = new System.Drawing.Size(215, 17));
            this.CheckBox2.TabIndex = 12;
            this.CheckBox2.Text = "Rescan Add-Ons Folder After Download";
            this.CheckBox2.UseVisualStyleBackColor = true;
            this.CheckBox1.AutoSize = true;
            point2 = (this.CheckBox1.Location = new System.Drawing.Point(9, 74));
            this.CheckBox1.Name = "CheckBox1";
            size2 = (this.CheckBox1.Size = new System.Drawing.Size(177, 17));
            this.CheckBox1.TabIndex = 11;
            this.CheckBox1.Text = "Show Spash Screen On Startup";
            this.CheckBox1.UseVisualStyleBackColor = true;
            point2 = (this.Button2.Location = new System.Drawing.Point(9, 45));
            this.Button2.Name = "Button2";
            size2 = (this.Button2.Size = new System.Drawing.Size(388, 23));
            this.Button2.TabIndex = 10;
            this.Button2.Text = "Auto Detect";
            this.Button2.UseVisualStyleBackColor = true;
            point2 = (this.Button1.Location = new System.Drawing.Point(307, 19));
            this.Button1.Name = "Button1";
            size2 = (this.Button1.Size = new System.Drawing.Size(90, 23));
            this.Button1.TabIndex = 9;
            this.Button1.Text = "Browse";
            this.Button1.UseVisualStyleBackColor = true;
            point2 = (this.TextBox1.Location = new System.Drawing.Point(9, 19));
            this.TextBox1.Name = "TextBox1";
            size2 = (this.TextBox1.Size = new System.Drawing.Size(292, 20));
            this.TextBox1.TabIndex = 8;
            this.Label1.AutoSize = true;
            point2 = (this.Label1.Location = new System.Drawing.Point(6, 3));
            this.Label1.Name = "Label1";
            size2 = (this.Label1.Size = new System.Drawing.Size(66, 13));
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Install Folder";
            this.ColorDialog1.FullOpen = true;
            point2 = (this.Button3.Location = new System.Drawing.Point(181, 116));
            this.Button3.Name = "Button3";
            size2 = (this.Button3.Size = new System.Drawing.Size(126, 23));
            this.Button3.TabIndex = 15;
            this.Button3.Text = "Select colour";
            this.Button3.UseVisualStyleBackColor = true;
            point2 = (this.Button4.Location = new System.Drawing.Point(181, 139));
            this.Button4.Name = "Button4";
            size2 = (this.Button4.Size = new System.Drawing.Size(126, 23));
            this.Button4.TabIndex = 16;
            this.Button4.Text = "Select colour";
            this.Button4.UseVisualStyleBackColor = true;
            this.AcceptButton = this.OK_Button;
            System.Drawing.SizeF sizeF2 = (this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f));
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            size2 = (this.ClientSize = new System.Drawing.Size(435, 360));
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.ResumeLayout(false);
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            MySettingsProperty.Settings.L4D2InstallFolder = TextBox1.Text;
            MySettingsProperty.Settings.ShowSplashScreen = CheckBox1.Checked;
            MySettingsProperty.Settings.FSWEnabled = CheckBox2.Checked;
            MySettingsProperty.Settings.highlightoutofdateaddons = cmbHOOD.Checked;
            MySettingsProperty.Settings.highlightunmanagedaddons = cmbHUMAO.Checked;
            MySettingsProperty.Settings.Save();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            TextBox1.Text = folderBrowserDialog.SelectedPath;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string text = SteamFunctions.SteamPathFromRegistry();
            if (text == null)
            {
                Interaction.MsgBox("Cannot detect Left 4 Dead 2, is it installed? you must manually browse for the l4d2 folder");
                return;
            }
            DirectoryInfo directoryInfo = new DirectoryInfo(text);
            if (directoryInfo.Exists)
            {
                string text2 = Path.Combine(directoryInfo.FullName, "steamapps\\common\\left 4 dead 2");
                if (Directory.Exists(text2))
                {
                    if (Interaction.MsgBox("Left 4 Dead 2 was detected as being installed in: \r\n\r\n" + text2 + "\r\n\r\nIs this correct?", MsgBoxStyle.YesNo | MsgBoxStyle.Question) == MsgBoxResult.Yes)
                    {
                        TextBox1.Text = text2;
                    }
                }
                else
                {
                    Interaction.MsgBox("Cannot detect Left 4 Dead 2, is it installed? you must manually browse for the l4d2 folder");
                }
            }
            else
            {
                Interaction.MsgBox("Cannot Detect l4d2, is it installed? you must manually browse for the l4d2 folder");
            }
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            TextBox1.Text = MySettingsProperty.Settings.L4D2InstallFolder;
            CheckBox1.Checked = MySettingsProperty.Settings.ShowSplashScreen;
            CheckBox2.Checked = MySettingsProperty.Settings.FSWEnabled;
            cmbHOOD.Checked = MySettingsProperty.Settings.highlightoutofdateaddons;
            cmbHUMAO.Checked = MySettingsProperty.Settings.highlightunmanagedaddons;
            Button4.BackColor = MySettingsProperty.Settings.UnmanagedAddOnColour;
            Button3.BackColor = MySettingsProperty.Settings.OutofDateAddOnColour;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ColorDialog1.Color = MySettingsProperty.Settings.OutofDateAddOnColour;
            if (ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                MySettingsProperty.Settings.OutofDateAddOnColour = ColorDialog1.Color;
                Button3.BackColor = MySettingsProperty.Settings.OutofDateAddOnColour;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ColorDialog1.Color = MySettingsProperty.Settings.UnmanagedAddOnColour;
            if (ColorDialog1.ShowDialog() == DialogResult.OK)
            {
                MySettingsProperty.Settings.UnmanagedAddOnColour = ColorDialog1.Color;
                Button4.BackColor = MySettingsProperty.Settings.UnmanagedAddOnColour;
            }
        }
    }
}
