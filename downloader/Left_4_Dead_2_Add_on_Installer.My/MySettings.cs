using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Left_4_Dead_2_Add_on_Installer.My
{
    [CompilerGenerated]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed class MySettings : ApplicationSettingsBase
    {
        private static MySettings defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());

        private static bool addedHandler;

        private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());

        public static MySettings Default
        {
            get
            {
                if (!addedHandler)
                {
                    object obj = addedHandlerLockObject;
                    ObjectFlowControl.CheckForSyncLockOnValueType(obj);
                    Monitor.Enter(obj);
                    try
                    {
                        if (!addedHandler)
                        {
                            MyProject.Application.Shutdown += delegate
                            {
                                if (MyProject.Application.SaveMySettingsOnExit)
                                {
                                    MySettingsProperty.Settings.Save();
                                }
                            };
                            addedHandler = true;
                        }
                    }
                    finally
                    {
                        Monitor.Exit(obj);
                    }
                }
                return defaultInstance;
            }
        }

        [DefaultSettingValue("")]
        [DebuggerNonUserCode]
        [UserScopedSetting]
        public string L4D2InstallFolder
        {
            get
            {
                return Conversions.ToString(this["L4D2InstallFolder"]);
            }
            set
            {
                this["L4D2InstallFolder"] = value;
            }
        }

        [DefaultSettingValue("True")]
        [UserScopedSetting]
        [DebuggerNonUserCode]
        public bool HideInstalledAddOns
        {
            get
            {
                return Conversions.ToBoolean(this["HideInstalledAddOns"]);
            }
            set
            {
                this["HideInstalledAddOns"] = value;
            }
        }

        [DefaultSettingValue("False")]
        [DebuggerNonUserCode]
        [UserScopedSetting]
        public bool OnlyShowManagedAddOns
        {
            get
            {
                return Conversions.ToBoolean(this["OnlyShowManagedAddOns"]);
            }
            set
            {
                this["OnlyShowManagedAddOns"] = value;
            }
        }

        [DebuggerNonUserCode]
        [UserScopedSetting]
        [DefaultSettingValue("True")]
        public bool ShowSplashScreen
        {
            get
            {
                return Conversions.ToBoolean(this["ShowSplashScreen"]);
            }
            set
            {
                this["ShowSplashScreen"] = value;
            }
        }

        [DebuggerNonUserCode]
        [UserScopedSetting]
        [DefaultSettingValue("LightPink")]
        public Color UnmanagedAddOnColour
        {
            get
            {
                object obj = this["UnmanagedAddOnColour"];
                Color result = default(Color);
                if (obj == null)
                {
                    return result;
                }
                return (Color)obj;
            }
            set
            {
                this["UnmanagedAddOnColour"] = value;
            }
        }

        [DefaultSettingValue("True")]
        [DebuggerNonUserCode]
        [UserScopedSetting]
        public bool FSWEnabled
        {
            get
            {
                return Conversions.ToBoolean(this["FSWEnabled"]);
            }
            set
            {
                this["FSWEnabled"] = value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("True")]
        public bool highlightunmanagedaddons
        {
            get
            {
                return Conversions.ToBoolean(this["highlightunmanagedaddons"]);
            }
            set
            {
                this["highlightunmanagedaddons"] = value;
            }
        }

        [UserScopedSetting]
        [DefaultSettingValue("True")]
        [DebuggerNonUserCode]
        public bool highlightoutofdateaddons
        {
            get
            {
                return Conversions.ToBoolean(this["highlightoutofdateaddons"]);
            }
            set
            {
                this["highlightoutofdateaddons"] = value;
            }
        }

        [DefaultSettingValue("Yellow")]
        [DebuggerNonUserCode]
        [UserScopedSetting]
        public Color OutofDateAddOnColour
        {
            get
            {
                object obj = this["OutofDateAddOnColour"];
                Color result = default(Color);
                if (obj == null)
                {
                    return result;
                }
                return (Color)obj;
            }
            set
            {
                this["OutofDateAddOnColour"] = value;
            }
        }

        [DebuggerNonUserCode]
        [UserScopedSetting]
        [DefaultSettingValue("False")]
        public bool SettingsUpgraded
        {
            get
            {
                return Conversions.ToBoolean(this["SettingsUpgraded"]);
            }
            set
            {
                this["SettingsUpgraded"] = value;
            }
        }

        [UserScopedSetting]
        [DefaultSettingValue("True")]
        [DebuggerNonUserCode]
        public bool ShowBanners
        {
            get
            {
                return Conversions.ToBoolean(this["ShowBanners"]);
            }
            set
            {
                this["ShowBanners"] = value;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [DebuggerNonUserCode]
        private static void AutoSaveSettings(object sender, EventArgs e)
        {
            if (MyProject.Application.SaveMySettingsOnExit)
            {
                MySettingsProperty.Settings.Save();
            }
        }
    }
}
