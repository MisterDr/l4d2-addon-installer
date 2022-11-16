using AOICL;
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
    public class frmAddOnFeedManager : Form
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

        [AccessedThroughProperty("Button2")]
        private Button _Button2;

        [AccessedThroughProperty("Button3")]
        private Button _Button3;

        [AccessedThroughProperty("CheckedListBox1")]
        private CheckedListBox _CheckedListBox1;

        private int selected;

        private AddOnFeedManager FM;

        private string cp;

        private bool isloading;

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

        internal virtual CheckedListBox CheckedListBox1
        {
            get
            {
                return _CheckedListBox1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = CheckedListBox1_SelectedIndexChanged;
                ItemCheckEventHandler value3 = CheckedListBox1_ItemCheck;
                if (_CheckedListBox1 != null)
                {
                    _CheckedListBox1.SelectedIndexChanged -= value2;
                    _CheckedListBox1.ItemCheck -= value3;
                }
                _CheckedListBox1 = value;
                if (_CheckedListBox1 != null)
                {
                    _CheckedListBox1.SelectedIndexChanged += value2;
                    _CheckedListBox1.ItemCheck += value3;
                }
            }
        }

        public frmAddOnFeedManager()
        {
            base.Load += frmAddOnFeedManager_Load;
            selected = -1;
            FM = new AddOnFeedManager();
            cp = Path.Combine(AOIPaths.FeedsPath(), "Feeds.xml");
            isloading = true;
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
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.CheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            this.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            System.Drawing.Point point2 = (this.TableLayoutPanel1.Location = new System.Drawing.Point(277, 134));
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
            this.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            point2 = (this.Button1.Location = new System.Drawing.Point(12, 137));
            this.Button1.Name = "Button1";
            size2 = (this.Button1.Size = new System.Drawing.Size(75, 23));
            this.Button1.TabIndex = 2;
            this.Button1.Text = "Add";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.Button2.Enabled = false;
            point2 = (this.Button2.Location = new System.Drawing.Point(93, 137));
            this.Button2.Name = "Button2";
            size2 = (this.Button2.Size = new System.Drawing.Size(75, 23));
            this.Button2.TabIndex = 3;
            this.Button2.Text = "Edit";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.Button3.Enabled = false;
            point2 = (this.Button3.Location = new System.Drawing.Point(174, 137));
            this.Button3.Name = "Button3";
            size2 = (this.Button3.Size = new System.Drawing.Size(75, 23));
            this.Button3.TabIndex = 4;
            this.Button3.Text = "Remove";
            this.Button3.UseVisualStyleBackColor = true;
            this.CheckedListBox1.FormattingEnabled = true;
            point2 = (this.CheckedListBox1.Location = new System.Drawing.Point(12, 12));
            this.CheckedListBox1.Name = "CheckedListBox1";
            size2 = (this.CheckedListBox1.Size = new System.Drawing.Size(411, 109));
            this.CheckedListBox1.TabIndex = 5;
            this.AcceptButton = this.OK_Button;
            System.Drawing.SizeF sizeF2 = (this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f));
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            size2 = (this.ClientSize = new System.Drawing.Size(435, 175));
            this.Controls.Add(this.CheckedListBox1);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddOnFeedManager";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add-On Feed Manager";
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(AOIPaths.FeedsPath()))
            {
                Directory.CreateDirectory(AOIPaths.FeedsPath());
            }
            FM.Save(cp);
            FM.Cache();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = CheckedListBox1.SelectedIndex;
            Button2.Enabled = true;
            Button3.Enabled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string text = Interaction.InputBox("Enter the Add-On Feed URL", "Edit Feed URL");
            if (text.Length > 0)
            {
                CheckedListBox1.Items.Add(text, isChecked: true);
                AddOnFeed addOnFeed = new AddOnFeed();
                addOnFeed.URL = text;
                addOnFeed.Enabled = true;
                FM.Feeds.Add(addOnFeed);
            }
        }

        private void frmAddOnFeedManager_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(AOIPaths.FeedsPath()))
            {
                Directory.CreateDirectory(AOIPaths.FeedsPath());
            }
            if (File.Exists(cp))
            {
                FM.Load(cp);
            }
            CheckedListBox1.Items.Clear();
            foreach (AddOnFeed feed in FM.Feeds)
            {
                CheckedListBox1.Items.Add(feed.URL, feed.Enabled);
            }
            isloading = false;
        }

        private void CheckedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!((selected == -1) | isloading))
            {
                if (e.NewValue == CheckState.Checked)
                {
                    FM.Feeds[selected].Enabled = true;
                }
                else
                {
                    FM.Feeds[selected].Enabled = false;
                }
            }
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = CheckedListBox1.SelectedIndex;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string text = Interaction.InputBox("Enter the Add-On Feed URL", "Edit Feed URL", CheckedListBox1.Items[selected].ToString());
            FM.Feeds[selected].URL = text;
            CheckedListBox1.Items[selected] = text;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CheckedListBox1.Items.RemoveAt(selected);
            FM.Feeds.RemoveAt(selected);
        }
    }
}
