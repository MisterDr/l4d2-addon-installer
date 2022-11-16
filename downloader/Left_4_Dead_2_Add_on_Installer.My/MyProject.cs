using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Left_4_Dead_2_Add_on_Installer.My
{
    [HideModuleName]
    [GeneratedCode("MyTemplate", "8.0.0.0")]
    [StandardModule]
    internal sealed class MyProject
    {
        [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal sealed class MyForms
        {
            public frmAbout m_frmAbout;

            public frmAddOnFeedManager m_frmAddOnFeedManager;

            public frmAddOnProperties m_frmAddOnProperties;

            public frmAddOnURLs m_frmAddOnURLs;

            public frmDownloadCache m_frmDownloadCache;

            public frmInstallUnmanagedAddOn m_frmInstallUnmanagedAddOn;

            public frmMain m_frmMain;

            public frmOptions m_frmOptions;

            public frmSplashScreen m_frmSplashScreen;

            [ThreadStatic]
            private static Hashtable m_FormBeingCreated;

            public frmAbout frmAbout
            {
                get
                {
                    m_frmAbout = Create__Instance__(m_frmAbout);
                    return m_frmAbout;
                }
                set
                {
                    if (value != m_frmAbout)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmAbout);
                    }
                }
            }

            public frmAddOnFeedManager frmAddOnFeedManager
            {
                get
                {
                    m_frmAddOnFeedManager = Create__Instance__(m_frmAddOnFeedManager);
                    return m_frmAddOnFeedManager;
                }
                set
                {
                    if (value != m_frmAddOnFeedManager)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmAddOnFeedManager);
                    }
                }
            }

            public frmAddOnProperties frmAddOnProperties
            {
                get
                {
                    m_frmAddOnProperties = Create__Instance__(m_frmAddOnProperties);
                    return m_frmAddOnProperties;
                }
                set
                {
                    if (value != m_frmAddOnProperties)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmAddOnProperties);
                    }
                }
            }

            public frmAddOnURLs frmAddOnURLs
            {
                get
                {
                    m_frmAddOnURLs = Create__Instance__(m_frmAddOnURLs);
                    return m_frmAddOnURLs;
                }
                set
                {
                    if (value != m_frmAddOnURLs)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmAddOnURLs);
                    }
                }
            }

            public frmDownloadCache frmDownloadCache
            {
                get
                {
                    m_frmDownloadCache = Create__Instance__(m_frmDownloadCache);
                    return m_frmDownloadCache;
                }
                set
                {
                    if (value != m_frmDownloadCache)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmDownloadCache);
                    }
                }
            }

            public frmInstallUnmanagedAddOn frmInstallUnmanagedAddOn
            {
                get
                {
                    m_frmInstallUnmanagedAddOn = Create__Instance__(m_frmInstallUnmanagedAddOn);
                    return m_frmInstallUnmanagedAddOn;
                }
                set
                {
                    if (value != m_frmInstallUnmanagedAddOn)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmInstallUnmanagedAddOn);
                    }
                }
            }

            public frmMain frmMain
            {
                get
                {
                    m_frmMain = Create__Instance__(m_frmMain);
                    return m_frmMain;
                }
                set
                {
                    if (value != m_frmMain)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmMain);
                    }
                }
            }

            public frmOptions frmOptions
            {
                get
                {
                    m_frmOptions = Create__Instance__(m_frmOptions);
                    return m_frmOptions;
                }
                set
                {
                    if (value != m_frmOptions)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmOptions);
                    }
                }
            }

            public frmSplashScreen frmSplashScreen
            {
                get
                {
                    m_frmSplashScreen = Create__Instance__(m_frmSplashScreen);
                    return m_frmSplashScreen;
                }
                set
                {
                    if (value != m_frmSplashScreen)
                    {
                        if (value != null)
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        Dispose__Instance__(ref m_frmSplashScreen);
                    }
                }
            }

            [DebuggerHidden]
            private static T Create__Instance__<T>(T Instance) where T : Form, new()
            {
                //Discarded unreachable code: IL_00dc
                if (Instance == null || Instance.IsDisposed)
                {
                    if (m_FormBeingCreated != null)
                    {
                        if (m_FormBeingCreated.ContainsKey(typeof(T)))
                        {
                            throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
                        }
                    }
                    else
                    {
                        m_FormBeingCreated = new Hashtable();
                    }
                    m_FormBeingCreated.Add(typeof(T), null);
                    try
                    {
                        return new T();
                    }
                    catch (TargetInvocationException ex) when (((Func<bool>)delegate
                    {
                        // Could not convert BlockContainer to single expression
                        ProjectData.SetProjectError(ex);
                        return ex.InnerException != null;
                    }).Invoke())
                    {
                        string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message);
                        throw new InvalidOperationException(resourceString, ex.InnerException);
                    }
                    finally
                    {
                        m_FormBeingCreated.Remove(typeof(T));
                    }
                }
                return Instance;
            }

            [DebuggerHidden]
            private void Dispose__Instance__<T>(ref T instance) where T : Form
            {
                instance.Dispose();
                instance = null;
            }

            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public MyForms()
            {
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override bool Equals(object o)
            {
                return base.Equals(RuntimeHelpers.GetObjectValue(o));
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            internal new Type GetType()
            {
                return typeof(MyForms);
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override string ToString()
            {
                return base.ToString();
            }
        }

        [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal sealed class MyWebServices
        {
            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public override bool Equals(object o)
            {
                return base.Equals(RuntimeHelpers.GetObjectValue(o));
            }

            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            internal new Type GetType()
            {
                return typeof(MyWebServices);
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            [DebuggerHidden]
            public override string ToString()
            {
                return base.ToString();
            }

            [DebuggerHidden]
            private static T Create__Instance__<T>(T instance) where T : new()
            {
                if (instance == null)
                {
                    return new T();
                }
                return instance;
            }

            [DebuggerHidden]
            private void Dispose__Instance__<T>(ref T instance)
            {
                instance = default(T);
            }

            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public MyWebServices()
            {
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [ComVisible(false)]
        internal sealed class ThreadSafeObjectProvider<T> where T : new()
        {
            [CompilerGenerated]
            [ThreadStatic]
            private static T m_ThreadStaticValue;

            internal T GetInstance
            {
                [DebuggerHidden]
                get
                {
                    if (m_ThreadStaticValue == null)
                    {
                        m_ThreadStaticValue = new T();
                    }
                    return m_ThreadStaticValue;
                }
            }

            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public ThreadSafeObjectProvider()
            {
            }
        }

        private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();

        private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();

        private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider = new ThreadSafeObjectProvider<User>();

        private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();

        private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

        [HelpKeyword("My.Computer")]
        internal static MyComputer Computer
        {
            [DebuggerHidden]
            get
            {
                return m_ComputerObjectProvider.GetInstance;
            }
        }

        [HelpKeyword("My.Application")]
        internal static MyApplication Application
        {
            [DebuggerHidden]
            get
            {
                return m_AppObjectProvider.GetInstance;
            }
        }

        [HelpKeyword("My.User")]
        internal static User User
        {
            [DebuggerHidden]
            get
            {
                return m_UserObjectProvider.GetInstance;
            }
        }

        [HelpKeyword("My.Forms")]
        internal static MyForms Forms
        {
            [DebuggerHidden]
            get
            {
                return m_MyFormsObjectProvider.GetInstance;
            }
        }

        [HelpKeyword("My.WebServices")]
        internal static MyWebServices WebServices
        {
            [DebuggerHidden]
            get
            {
                return m_MyWebServicesObjectProvider.GetInstance;
            }
        }
    }
}
