using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Left_4_Dead_2_Add_on_Installer
{
    [DesignerGenerated]
    public class frmSplashScreen : Form
    {
        private IContainer components;

        [AccessedThroughProperty("MainLayoutPanel")]
        private TableLayoutPanel _MainLayoutPanel;

        internal virtual TableLayoutPanel MainLayoutPanel
        {
            get
            {
                return _MainLayoutPanel;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                PaintEventHandler value2 = MainLayoutPanel_Paint;
                if (_MainLayoutPanel != null)
                {
                    _MainLayoutPanel.Paint -= value2;
                }
                _MainLayoutPanel = value;
                if (_MainLayoutPanel != null)
                {
                    _MainLayoutPanel.Paint += value2;
                }
            }
        }

        public frmSplashScreen()
        {
            base.Load += frmSplashScreen_Load;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Left_4_Dead_2_Add_on_Installer.frmSplashScreen));
            this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            this.MainLayoutPanel.BackgroundImage = (System.Drawing.Image)resources.GetObject("logo");
            this.MainLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MainLayoutPanel.ColumnCount = 2;
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 243f));
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100f));
            this.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            System.Drawing.Point point2 = (this.MainLayoutPanel.Location = new System.Drawing.Point(0, 0));
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 218f));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38f));
            System.Drawing.Size size2 = (this.MainLayoutPanel.Size = new System.Drawing.Size(496, 303));
            this.MainLayoutPanel.TabIndex = 0;
            System.Drawing.SizeF sizeF2 = (this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f));
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            size2 = (this.ClientSize = new System.Drawing.Size(496, 303));
            this.ControlBox = false;
            this.Controls.Add(this.MainLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSplashScreen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.ResumeLayout(false);
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
        }

        private void MainLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ApplicationTitle_Click(object sender, EventArgs e)
        {
        }

        private void Version_Click(object sender, EventArgs e)
        {
        }
    }
}
