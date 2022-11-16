using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace Left_4_Dead_2_Add_on_Installer.My
{
    [GeneratedCode("MyTemplate", "8.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal class MyApplication : WindowsFormsApplicationBase
    {
        public ProtocolHandler Protocol;

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [DebuggerHidden]
        [STAThread]
        internal static void Main(string[] Args)
        {
            try
            {
                Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
            }
            finally
            {
            }
            MyProject.Application.Run(Args);
        }

        protected override bool OnInitialize(ReadOnlyCollection<string> commandLineArgs)
        {
            if (!MySettingsProperty.Settings.SettingsUpgraded)
            {
                MySettingsProperty.Settings.Upgrade();
                MySettingsProperty.Settings.SettingsUpgraded = true;
                MySettingsProperty.Settings.Save();
            }
            bool result = default(bool);
            try
            {
                bool flag = MySettingsProperty.Settings.ShowSplashScreen;
                foreach (string commandLineArg in commandLineArgs)
                {
                    if (Operators.CompareString(commandLineArg.ToLower().Trim(), "-splash", TextCompare: false) == 0)
                    {
                        flag = false;
                        break;
                    }
                    if (commandLineArg.StartsWith("-protocol="))
                    {
                        Protocol.ProtocolString = commandLineArg;
                    }
                }
                if (flag)
                {
                    MyProject.Application.SplashScreen = new frmSplashScreen();
                }
                result = base.OnInitialize(commandLineArgs);
                return result;
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
                return result;
            }
        }

        private void MyApplication_StartupNextInstance(object sender, StartupNextInstanceEventArgs e)
        {
            foreach (string item in e.CommandLine)
            {
                if (item.StartsWith("-protocol="))
                {
                    Protocol.ProtocolString = item;
                }
            }
        }

        [DebuggerStepThrough]
        public MyApplication()
            : base(AuthenticationMode.Windows)
        {
            base.StartupNextInstance += MyApplication_StartupNextInstance;
            Protocol = new ProtocolHandler();
            IsSingleInstance = true;
            EnableVisualStyles = true;
            SaveMySettingsOnExit = true;
            ShutdownStyle = ShutdownMode.AfterMainFormCloses;
        }

        [DebuggerStepThrough]
        protected override void OnCreateMainForm()
        {
            MainForm = MyProject.Forms.frmMain;
        }
    }
}
