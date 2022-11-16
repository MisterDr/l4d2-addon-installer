using AOICL;
using AOICL.Functions.Windows;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Left_4_Dead_2_Add_on_Installer
{
    [DesignerGenerated]
    public class frmConfirmInstall : Form
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

        [AccessedThroughProperty("Label1")]
        private Label _Label1;

        [AccessedThroughProperty("ColumnHeader1")]
        private ColumnHeader _ColumnHeader1;

        [AccessedThroughProperty("ColumnHeader2")]
        private ColumnHeader _ColumnHeader2;

        private InstallFileGeneratorTasks jjj;

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
                _ListView1 = value;
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
            this.Label1 = new System.Windows.Forms.Label();
            this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            this.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
            System.Drawing.Point point2 = (this.TableLayoutPanel1.Location = new System.Drawing.Point(243, 131));
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
            System.Drawing.Size size2 = (this.TableLayoutPanel1.Size = new System.Drawing.Size(180, 29));
            this.TableLayoutPanel1.TabIndex = 0;
            this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            point2 = (this.OK_Button.Location = new System.Drawing.Point(3, 3));
            this.OK_Button.Name = "OK_Button";
            size2 = (this.OK_Button.Size = new System.Drawing.Size(84, 23));
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "Install";
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            point2 = (this.Cancel_Button.Location = new System.Drawing.Point(95, 3));
            this.Cancel_Button.Name = "Cancel_Button";
            size2 = (this.Cancel_Button.Size = new System.Drawing.Size(79, 23));
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2] { this.ColumnHeader1, this.ColumnHeader2 });
            point2 = (this.ListView1.Location = new System.Drawing.Point(12, 25));
            this.ListView1.Name = "ListView1";
            size2 = (this.ListView1.Size = new System.Drawing.Size(411, 97));
            this.ListView1.TabIndex = 1;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            point2 = (this.Label1.Location = new System.Drawing.Point(12, 9));
            this.Label1.Name = "Label1";
            size2 = (this.Label1.Size = new System.Drawing.Size(170, 13));
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Install the following add-ons:";
            this.ColumnHeader1.Text = "Add-On Name";
            this.ColumnHeader1.Width = 265;
            this.ColumnHeader2.Text = "Version";
            this.ColumnHeader2.Width = 125;
            this.AcceptButton = this.OK_Button;
            System.Drawing.SizeF sizeF2 = (this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f));
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            size2 = (this.ClientSize = new System.Drawing.Size(435, 172));
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfirmInstall";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Install Add-On?";
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
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

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        public static void AddShieldToButton(ref Button B)
        {
            int num = 5632;
            checked
            {
                int num2 = num + 12;
                B.FlatStyle = FlatStyle.System;
                SendMessage(B.Handle, (uint)num2, (IntPtr)0, (IntPtr)(-1));
            }
        }

        private void frmConfirmInstall_Load(object sender, EventArgs e)
        {
            if (!UAC.IsUserAdmin())
            {
                Button B = OK_Button;
                AddShieldToButton(ref B);
                OK_Button = B;
            }
            foreach (InstallFileGeneratorTask task in jjj.Tasks)
            {
                ListViewItem listViewItem = new ListViewItem(task.AddOn.DisplayName);
                listViewItem.SubItems.Add(task.AddOn.Version);
                ListView1.Items.Add(listViewItem);
            }
        }

        public frmConfirmInstall(InstallFileGeneratorTasks j)
        {
            base.Load += frmConfirmInstall_Load;
            jjj = j;
            InitializeComponent();
        }
    }
}
