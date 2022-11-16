using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AOI.My;
using AOICL.Installer;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AOI
{
	[DesignerGenerated]
	public class Form1 : Form
	{
		private delegate void LogErrorDelegate(string text);

		private delegate void SetLabelTextDelegate(ref Label l, string t);

		private delegate void upd(ref ProgressBar p, int i);

		private delegate void cfd();

		private delegate void cfd2();

		private delegate void cbd();

		private delegate int gbwd();

		private delegate int lwd();

		private delegate object lld(int i);

		private IContainer components;

		[AccessedThroughProperty("pgCurrentTask")]
		private ProgressBar _pgCurrentTask;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("GroupBox1")]
		private GroupBox _GroupBox1;

		[AccessedThroughProperty("ListBox1")]
		private ListBox _ListBox1;

		[AccessedThroughProperty("TableLayoutPanel1")]
		private TableLayoutPanel _TableLayoutPanel1;

		[AccessedThroughProperty("OK_Button")]
		private Button _OK_Button;

		[AccessedThroughProperty("Cancel_Button")]
		private Button _Cancel_Button;

		[AccessedThroughProperty("GroupBox2")]
		private GroupBox _GroupBox2;

		[AccessedThroughProperty("BackgroundWorker1")]
		private BackgroundWorker _BackgroundWorker1;

		[AccessedThroughProperty("AddOnInstaller")]
		private AddOnInstaller _AddOnInstaller;

		private bool finished;

		private string f;

		private List<string> i;

		private string d;

		private bool canceled;

		private bool firederrorevent;

		internal virtual ProgressBar pgCurrentTask
		{
			[DebuggerNonUserCode]
			get
			{
				return _pgCurrentTask;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				_pgCurrentTask = value;
			}
		}

		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return _Label1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				EventHandler value2 = Label1_TextChanged;
				EventHandler value3 = Label1_Click;
				if (_Label1 != null)
				{
					_Label1.TextChanged -= value2;
					_Label1.Click -= value3;
				}
				_Label1 = value;
				if (_Label1 != null)
				{
					_Label1.TextChanged += value2;
					_Label1.Click += value3;
				}
			}
		}

		internal virtual GroupBox GroupBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return _GroupBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				_GroupBox1 = value;
			}
		}

		internal virtual ListBox ListBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return _ListBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				EventHandler value2 = ListBox1_SelectedIndexChanged;
				EventHandler value3 = ListBox1_DoubleClick;
				if (_ListBox1 != null)
				{
					_ListBox1.SelectedIndexChanged -= value2;
					_ListBox1.DoubleClick -= value3;
				}
				_ListBox1 = value;
				if (_ListBox1 != null)
				{
					_ListBox1.SelectedIndexChanged += value2;
					_ListBox1.DoubleClick += value3;
				}
			}
		}

		internal virtual TableLayoutPanel TableLayoutPanel1
		{
			[DebuggerNonUserCode]
			get
			{
				return _TableLayoutPanel1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				_TableLayoutPanel1 = value;
			}
		}

		internal virtual Button OK_Button
		{
			[DebuggerNonUserCode]
			get
			{
				return _OK_Button;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
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
			[DebuggerNonUserCode]
			get
			{
				return _Cancel_Button;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
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

		internal virtual GroupBox GroupBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return _GroupBox2;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				_GroupBox2 = value;
			}
		}

		internal virtual BackgroundWorker BackgroundWorker1
		{
			[DebuggerNonUserCode]
			get
			{
				return _BackgroundWorker1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				DoWorkEventHandler value2 = BackgroundWorker1_DoWork;
				if (_BackgroundWorker1 != null)
				{
					_BackgroundWorker1.DoWork -= value2;
				}
				_BackgroundWorker1 = value;
				if (_BackgroundWorker1 != null)
				{
					_BackgroundWorker1.DoWork += value2;
				}
			}
		}

		public virtual AddOnInstaller AddOnInstaller
		{
			[DebuggerNonUserCode]
			get
			{
				return _AddOnInstaller;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				AddOnInstaller.TaskStartedEventHandler obj = AddOnInstaller_TaskStarted;
				AddOnInstaller.TaskProgressChangedEventHandler obj2 = AddOnInstaller_TaskProgressChanged;
				AddOnInstaller.TaskCompleteEventHandler obj3 = AddOnInstaller_TaskComplete;
				AddOnInstaller.LogMessageEventHandler obj4 = AddOnInstaller_LogMessage;
				AddOnInstaller.InstallerTaskMessageEventHandler obj5 = AddOnInstaller_InstallerTaskMessage;
				AddOnInstaller.InstallerStartedEventHandler obj6 = AddOnInstaller_InstallerStarted;
				AddOnInstaller.InstallerProgressChangedEventHandler obj7 = AddOnInstaller_InstallerProgressChanged;
				AddOnInstaller.InstallerErrorEventHandler obj8 = AddOnInstaller_InstallerError;
				AddOnInstaller.InstallerCompleteEventHandler obj9 = AddOnInstaller_InstallerComplete;
				if (_AddOnInstaller != null)
				{
					_AddOnInstaller.TaskStarted -= obj;
					_AddOnInstaller.TaskProgressChanged -= obj2;
					_AddOnInstaller.TaskComplete -= obj3;
					_AddOnInstaller.LogMessage -= obj4;
					_AddOnInstaller.InstallerTaskMessage -= obj5;
					_AddOnInstaller.InstallerStarted -= obj6;
					_AddOnInstaller.InstallerProgressChanged -= obj7;
					_AddOnInstaller.InstallerError -= obj8;
					_AddOnInstaller.InstallerComplete -= obj9;
				}
				_AddOnInstaller = value;
				if (_AddOnInstaller != null)
				{
					_AddOnInstaller.TaskStarted += obj;
					_AddOnInstaller.TaskProgressChanged += obj2;
					_AddOnInstaller.TaskComplete += obj3;
					_AddOnInstaller.LogMessage += obj4;
					_AddOnInstaller.InstallerTaskMessage += obj5;
					_AddOnInstaller.InstallerStarted += obj6;
					_AddOnInstaller.InstallerProgressChanged += obj7;
					_AddOnInstaller.InstallerError += obj8;
					_AddOnInstaller.InstallerComplete += obj9;
				}
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AOI.Form1));
			this.pgCurrentTask = new System.Windows.Forms.ProgressBar();
			this.Label1 = new System.Windows.Forms.Label();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.ListBox1 = new System.Windows.Forms.ListBox();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.OK_Button = new System.Windows.Forms.Button();
			this.Cancel_Button = new System.Windows.Forms.Button();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.GroupBox1.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.SuspendLayout();
			this.pgCurrentTask.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			System.Drawing.Point point2 = (this.pgCurrentTask.Location = new System.Drawing.Point(6, 32));
			this.pgCurrentTask.Name = "pgCurrentTask";
			System.Drawing.Size size2 = (this.pgCurrentTask.Size = new System.Drawing.Size(487, 29));
			this.pgCurrentTask.TabIndex = 0;
			this.Label1.AutoSize = true;
			point2 = (this.Label1.Location = new System.Drawing.Point(200, 16));
			this.Label1.Name = "Label1";
			size2 = (this.Label1.Size = new System.Drawing.Size(50, 13));
			this.Label1.TabIndex = 4;
			this.Label1.Text = "STATUS";
			this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.GroupBox1.Controls.Add(this.ListBox1);
			point2 = (this.GroupBox1.Location = new System.Drawing.Point(12, 85));
			this.GroupBox1.Name = "GroupBox1";
			size2 = (this.GroupBox1.Size = new System.Drawing.Size(499, 201));
			this.GroupBox1.TabIndex = 7;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Log";
			this.ListBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.ListBox1.FormattingEnabled = true;
			point2 = (this.ListBox1.Location = new System.Drawing.Point(6, 19));
			this.ListBox1.Name = "ListBox1";
			size2 = (this.ListBox1.Size = new System.Drawing.Size(487, 173));
			this.ListBox1.TabIndex = 0;
			this.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
			point2 = (this.TableLayoutPanel1.Location = new System.Drawing.Point(365, 292));
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 1;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
			size2 = (this.TableLayoutPanel1.Size = new System.Drawing.Size(146, 29));
			this.TableLayoutPanel1.TabIndex = 8;
			this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.OK_Button.Enabled = false;
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
			this.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.GroupBox2.Controls.Add(this.pgCurrentTask);
			this.GroupBox2.Controls.Add(this.Label1);
			point2 = (this.GroupBox2.Location = new System.Drawing.Point(12, 12));
			this.GroupBox2.Name = "GroupBox2";
			size2 = (this.GroupBox2.Size = new System.Drawing.Size(499, 67));
			this.GroupBox2.TabIndex = 9;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Progress";
			this.BackgroundWorker1.WorkerReportsProgress = true;
			this.BackgroundWorker1.WorkerSupportsCancellation = true;
			System.Drawing.SizeF sizeF2 = (this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Cancel_Button;
			size2 = (this.ClientSize = new System.Drawing.Size(523, 333));
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.TableLayoutPanel1);
			this.Controls.Add(this.GroupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Install Add-On";
			this.GroupBox1.ResumeLayout(false);
			this.TableLayoutPanel1.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.ResumeLayout(false);
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (AddOnInstaller != null && AddOnInstaller.CurrentStep != null && !(AddOnInstaller.Canceled | AddOnInstaller.CurrentStep.HasError | AddOnInstaller.CurrentStep.IsComplete))
			{
				if (Interaction.MsgBox("Are you sure you wish to stop installing this addon?", MsgBoxStyle.YesNo, "Exit Install") == MsgBoxResult.Yes)
				{
					AddOnInstaller.CancelInstall();
					AddOnInstaller.Dispose();
					AddOnInstaller = null;
				}
				else
				{
					e.Cancel = true;
				}
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			BackgroundWorker1.RunWorkerAsync();
		}

		public Form1()
		{
			base.Load += Form1_Load;
			base.FormClosing += Form1_FormClosing;
			AddOnInstaller = null;
			finished = false;
			f = null;
			canceled = false;
			firederrorevent = false;
			InitializeComponent();
			try
			{
				f = MyProject.Application.CommandLineArgs[0];
				d = MyProject.Application.CommandLineArgs[1];
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox("PROBLEM WITH COMMAND ARGS");
				ProjectData.ClearProjectError();
			}
		}

		public Form1(string fname, string dir)
		{
			base.Load += Form1_Load;
			base.FormClosing += Form1_FormClosing;
			AddOnInstaller = null;
			finished = false;
			f = null;
			canceled = false;
			firederrorevent = false;
			InitializeComponent();
			f = fname;
			d = dir;
		}

		private void LogError(string text)
		{
			try
			{
				ListBox1 = ListBox1;
				if (ListBox1.InvokeRequired)
				{
					if (ListBox1 != null)
					{
						ListBox1.Invoke(new LogErrorDelegate(LogError), text);
					}
				}
				else
				{
					ListBox1.Items.Add(text);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void SetLabelText(ref Label l, string t)
		{
			if (l.InvokeRequired)
			{
				l.Invoke(new SetLabelTextDelegate(SetLabelText), l, t);
			}
			else
			{
				l.Text = t;
			}
		}

		public void up(ref ProgressBar p, int i)
		{
			if (p.InvokeRequired)
			{
				p.Invoke(new upd(up), p, i);
			}
			else
			{
				p.Value = i;
			}
		}

		private void cf()
		{
			if (OK_Button.InvokeRequired)
			{
				OK_Button.Invoke(new cfd(cf));
			}
			else
			{
				OK_Button.Enabled = true;
			}
		}

		private void cf2()
		{
			try
			{
				if (InvokeRequired)
				{
					Invoke(new cfd2(cf2));
				}
				else
				{
					Close();
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			if (!AddOnInstaller.Canceled)
			{
				cf2();
			}
		}

		private void OK_Button_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ListBox1_DoubleClick(object sender, EventArgs e)
		{
			Interaction.MsgBox(RuntimeHelpers.GetObjectValue(ListBox1.SelectedItem));
		}

		private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void Label1_Click(object sender, EventArgs e)
		{
		}

		private void Label1_TextChanged(object sender, EventArgs e)
		{
			int num = GroupBox2.Width;
			Label1.Left = checked((int)Math.Round((double)(num - Label1.Width) / 2.0));
		}

		private void Label2_Click(object sender, EventArgs e)
		{
		}

		private void AddOnInstaller_InstallerComplete()
		{
			finished = true;
			cd();
			cf();
		}

		private void cd()
		{
			if (Cancel_Button.InvokeRequired)
			{
				Cancel_Button.Invoke(new cbd(cd));
			}
			else
			{
				Cancel_Button.Enabled = false;
			}
		}

		private void AddOnInstaller_InstallerError(string EM)
		{
			if (!firederrorevent)
			{
				LogError(EM);
				if (!canceled)
				{
					Interaction.MsgBox(EM);
				}
				finished = true;
			}
			canceled = true;
			firederrorevent = true;
		}

		private void AddOnInstaller_InstallerProgressChanged(int PercentageComplete)
		{
			ProgressBar p = pgCurrentTask;
			up(ref p, PercentageComplete);
			pgCurrentTask = p;
		}

		private void AddOnInstaller_InstallerStarted()
		{
		}

		private void AddOnInstaller_InstallerTaskMessage(string m)
		{
			Label l = Label1;
			SetLabelText(ref l, m);
			Label1 = l;
		}

		private void AddOnInstaller_LogMessage(string m)
		{
			LogError(m);
		}

		private void AddOnInstaller_TaskComplete()
		{
		}

		private void AddOnInstaller_TaskProgressChanged(int PercentageComplete)
		{
			ProgressBar p = pgCurrentTask;
			up(ref p, PercentageComplete);
			pgCurrentTask = p;
		}

		private void AddOnInstaller_TaskStarted(string TaskName)
		{
			Label l = Label1;
			SetLabelText(ref l, TaskName);
			Label1 = l;
		}

		private int gbw()
		{
			if (GroupBox2.InvokeRequired)
			{
				return Conversions.ToInteger(GroupBox2.Invoke(new gbwd(gbw)));
			}
			return GroupBox2.Width;
		}

		private int lw()
		{
			if (Label1.InvokeRequired)
			{
				return Conversions.ToInteger(Label1.Invoke(new lwd(lw)));
			}
			return Label1.Width;
		}

		private object ll(int i)
		{
			if (Label1.InvokeRequired)
			{
				return Label1.Invoke(new lld(ll), i);
			}
			return Label1.Left == i;
		}

		private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{
				int num = gbw();
				ll(checked((int)Math.Round((double)(num - lw()) / 2.0)));
				AddOnInstaller = new AddOnInstaller(f, d);
				AddOnInstaller.DoInstall();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox(ex2.ToString());
				ProjectData.ClearProjectError();
			}
		}
	}
}
