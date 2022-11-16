using AOI;
using AOICL;
using AOICL.Branding;
using AOICL.Functions.Left4Dead2;
using AOICL.Functions.Windows;
using Kjs.AppLife.Update.Controller;
using Left_4_Dead_2_Add_on_Installer.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace Left_4_Dead_2_Add_on_Installer
{
    [DesignerGenerated]
    public class frmMain : Form
    {
        public delegate void VLSDelegate(ref ListView l, int i);

        private IContainer components;

        [AccessedThroughProperty("MenuStrip1")]
        private MenuStrip _MenuStrip1;

        [AccessedThroughProperty("ToolsToolStripMenuItem")]
        private ToolStripMenuItem _ToolsToolStripMenuItem;

        [AccessedThroughProperty("OptionsToolStripMenuItem")]
        private ToolStripMenuItem _OptionsToolStripMenuItem;

        [AccessedThroughProperty("HelpToolStripMenuItem")]
        private ToolStripMenuItem _HelpToolStripMenuItem;

        [AccessedThroughProperty("CheckForupdatesToolStripMenuItem")]
        private ToolStripMenuItem _CheckForupdatesToolStripMenuItem;

        [AccessedThroughProperty("FileToolStripMenuItem")]
        private ToolStripMenuItem _FileToolStripMenuItem;

        [AccessedThroughProperty("ExitToolStripMenuItem")]
        private ToolStripMenuItem _ExitToolStripMenuItem;

        [AccessedThroughProperty("StatusStrip1")]
        private StatusStrip _StatusStrip1;

        [AccessedThroughProperty("ContextMenuStrip1")]
        private ContextMenuStrip _ContextMenuStrip1;

        [AccessedThroughProperty("PropertiesToolStripMenuItem")]
        private ToolStripMenuItem _PropertiesToolStripMenuItem;

        [AccessedThroughProperty("ToolStripMenuItem1")]
        private ToolStripSeparator _ToolStripMenuItem1;

        [AccessedThroughProperty("AboutL4DAOIToolStripMenuItem")]
        private ToolStripMenuItem _AboutL4DAOIToolStripMenuItem;

        [AccessedThroughProperty("InstallUnmanagedAddOnToolStripMenuItem")]
        private ToolStripMenuItem _InstallUnmanagedAddOnToolStripMenuItem;

        [AccessedThroughProperty("UpdateController1")]
        private UpdateController _UpdateController1;

        [AccessedThroughProperty("ContextMenuStrip2")]
        private ContextMenuStrip _ContextMenuStrip2;

        [AccessedThroughProperty("InstallToolStripMenuItem")]
        private ToolStripMenuItem _InstallToolStripMenuItem;

        [AccessedThroughProperty("UpdateAddonListToolStripMenuItem")]
        private ToolStripMenuItem _UpdateAddonListToolStripMenuItem;

        [AccessedThroughProperty("ToolStripMenuItem2")]
        private ToolStripSeparator _ToolStripMenuItem2;

        [AccessedThroughProperty("ViewToolStripMenuItem")]
        private ToolStripMenuItem _ViewToolStripMenuItem;

        [AccessedThroughProperty("AddOnFeedsToolStripMenuItem")]
        private ToolStripMenuItem _AddOnFeedsToolStripMenuItem;

        [AccessedThroughProperty("HideUnmanagedAddOnsToolStripMenuItem")]
        private ToolStripMenuItem _HideUnmanagedAddOnsToolStripMenuItem;

        [AccessedThroughProperty("ToolStripMenuItem3")]
        private ToolStripSeparator _ToolStripMenuItem3;

        [AccessedThroughProperty("HideInstalledAddonsToolStripMenuItem")]
        private ToolStripMenuItem _HideInstalledAddonsToolStripMenuItem;

        [AccessedThroughProperty("ApplicationFoldersToolStripMenuItem")]
        private ToolStripMenuItem _ApplicationFoldersToolStripMenuItem;

        [AccessedThroughProperty("AppDataFolderToolStripMenuItem")]
        private ToolStripMenuItem _AppDataFolderToolStripMenuItem;

        [AccessedThroughProperty("TempFolderToolStripMenuItem")]
        private ToolStripMenuItem _TempFolderToolStripMenuItem;

        [AccessedThroughProperty("LogFolderToolStripMenuItem")]
        private ToolStripMenuItem _LogFolderToolStripMenuItem;

        [AccessedThroughProperty("FeedsFolderToolStripMenuItem")]
        private ToolStripMenuItem _FeedsFolderToolStripMenuItem;

        [AccessedThroughProperty("ToolStripMenuItem5")]
        private ToolStripSeparator _ToolStripMenuItem5;

        [AccessedThroughProperty("DownloadFolderToolStripMenuItem")]
        private ToolStripMenuItem _DownloadFolderToolStripMenuItem;

        [AccessedThroughProperty("ToolStripMenuItem6")]
        private ToolStripMenuItem _ToolStripMenuItem6;

        [AccessedThroughProperty("BinnyButtonToolStripMenuItem")]
        private ToolStripMenuItem _BinnyButtonToolStripMenuItem;

        [AccessedThroughProperty("ToolStripMenuItem7")]
        private ToolStripSeparator _ToolStripMenuItem7;

        [AccessedThroughProperty("Left4Dead2ToolStripMenuItem")]
        private ToolStripMenuItem _Left4Dead2ToolStripMenuItem;

        [AccessedThroughProperty("RunLeft4Dead2ToolStripMenuItem")]
        private ToolStripMenuItem _RunLeft4Dead2ToolStripMenuItem;

        [AccessedThroughProperty("ToolStripMenuItem8")]
        private ToolStripSeparator _ToolStripMenuItem8;

        [AccessedThroughProperty("ToolStripMenuItem9")]
        private ToolStripSeparator _ToolStripMenuItem9;

        [AccessedThroughProperty("HomepageToolStripMenuItem")]
        private ToolStripMenuItem _HomepageToolStripMenuItem;

        [AccessedThroughProperty("NotifyIcon1")]
        private NotifyIcon _NotifyIcon1;

        [AccessedThroughProperty("cmsNotifyIcon")]
        private ContextMenuStrip _cmsNotifyIcon;

        [AccessedThroughProperty("ExitToolStripMenuItem1")]
        private ToolStripMenuItem _ExitToolStripMenuItem1;

        [AccessedThroughProperty("DownloadCacheManagerToolStripMenuItem")]
        private ToolStripMenuItem _DownloadCacheManagerToolStripMenuItem;

        [AccessedThroughProperty("UpdateToolStripMenuItem")]
        private ToolStripMenuItem _UpdateToolStripMenuItem;

        [AccessedThroughProperty("ToolStripStatusLabel1")]
        private ToolStripStatusLabel _ToolStripStatusLabel1;

        [AccessedThroughProperty("ToolStripMenuItem4")]
        private ToolStripMenuItem _ToolStripMenuItem4;

        [AccessedThroughProperty("BToolStripMenuItem")]
        private ToolStripMenuItem _BToolStripMenuItem;

        [AccessedThroughProperty("TeamSAOToolStripMenuItem")]
        private ToolStripMenuItem _TeamSAOToolStripMenuItem;

        [AccessedThroughProperty("HomePageToolStripMenuItem1")]
        private ToolStripMenuItem _HomePageToolStripMenuItem1;

        [AccessedThroughProperty("ToolStripMenuItem10")]
        private ToolStripSeparator _ToolStripMenuItem10;

        [AccessedThroughProperty("ForumsToolStripMenuItem")]
        private ToolStripMenuItem _ForumsToolStripMenuItem;

        [AccessedThroughProperty("NewsToolStripMenuItem")]
        private ToolStripMenuItem _NewsToolStripMenuItem;

        [AccessedThroughProperty("ToolStripProgressBar1")]
        private ToolStripProgressBar _ToolStripProgressBar1;

        [AccessedThroughProperty("RegisterProtocolToolStripMenuItem")]
        private ToolStripMenuItem _RegisterProtocolToolStripMenuItem;

        [AccessedThroughProperty("ToolStripMenuItem11")]
        private ToolStripSeparator _ToolStripMenuItem11;

        [AccessedThroughProperty("SplitContainer1")]
        private SplitContainer _SplitContainer1;

        [AccessedThroughProperty("TabControl1")]
        private TabControl _TabControl1;

        [AccessedThroughProperty("TabPage1")]
        private TabPage _TabPage1;

        [AccessedThroughProperty("ToolStrip2")]
        private ToolStrip _ToolStrip2;

        [AccessedThroughProperty("ToolStripButton3")]
        private ToolStripButton _ToolStripButton3;

        [AccessedThroughProperty("ToolStripButton4")]
        private ToolStripButton _ToolStripButton4;

        [AccessedThroughProperty("ToolStripButton2")]
        private ToolStripButton _ToolStripButton2;

        [AccessedThroughProperty("ListView1")]
        private LVNF _ListView1;

        [AccessedThroughProperty("ColumnHeader1")]
        private ColumnHeader _ColumnHeader1;

        [AccessedThroughProperty("ColumnHeader3")]
        private ColumnHeader _ColumnHeader3;

        [AccessedThroughProperty("ColumnHeader9")]
        private ColumnHeader _ColumnHeader9;

        [AccessedThroughProperty("ColumnHeader7")]
        private ColumnHeader _ColumnHeader7;

        [AccessedThroughProperty("ColumnHeader2")]
        private ColumnHeader _ColumnHeader2;

        [AccessedThroughProperty("TabPage2")]
        private TabPage _TabPage2;

        [AccessedThroughProperty("ListView2")]
        private LVNF _ListView2;

        [AccessedThroughProperty("ColumnHeader4")]
        private ColumnHeader _ColumnHeader4;

        [AccessedThroughProperty("ColumnHeader5")]
        private ColumnHeader _ColumnHeader5;

        [AccessedThroughProperty("ColumnHeader6")]
        private ColumnHeader _ColumnHeader6;

        [AccessedThroughProperty("ColumnHeader8")]
        private ColumnHeader _ColumnHeader8;

        [AccessedThroughProperty("ToolStrip1")]
        private ToolStrip _ToolStrip1;

        [AccessedThroughProperty("ToolStripButton1")]
        private ToolStripButton _ToolStripButton1;

        [AccessedThroughProperty("PictureBox2")]
        private PictureBox _PictureBox2;

        [AccessedThroughProperty("AddOnFeedsReCacheNowToolStripMenuItem")]
        private ToolStripMenuItem _AddOnFeedsReCacheNowToolStripMenuItem;

        [AccessedThroughProperty("ToolStripMenuItem12")]
        private ToolStripSeparator _ToolStripMenuItem12;

        private int installselected;

        private int propselected;

        private int pid;

        private Process AOIProcess;

        private AddOn SelectedInstallAddOn;

        private AddOn2 SelectedInstallAddOn2;

        [AccessedThroughProperty("br")]
        private BannerRotator _br;

        [AccessedThroughProperty("ProtocolDispatcher")]
        private ProtocolHandler _ProtocolDispatcher;

        [AccessedThroughProperty("AddOnManager")]
        private AddOnManager _AddOnManager;

        public string BrandingURL;

        private bool AOIActive;

        private string vpkcreatedpath;

        internal virtual MenuStrip MenuStrip1
        {
            get
            {
                return _MenuStrip1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                ToolStripItemClickedEventHandler value2 = MenuStrip1_ItemClicked;
                if (_MenuStrip1 != null)
                {
                    _MenuStrip1.ItemClicked -= value2;
                }
                _MenuStrip1 = value;
                if (_MenuStrip1 != null)
                {
                    _MenuStrip1.ItemClicked += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem ToolsToolStripMenuItem
        {
            get
            {
                return _ToolsToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ToolsToolStripMenuItem = value;
            }
        }

        internal virtual ToolStripMenuItem OptionsToolStripMenuItem
        {
            get
            {
                return _OptionsToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = OptionsToolStripMenuItem_Click;
                if (_OptionsToolStripMenuItem != null)
                {
                    _OptionsToolStripMenuItem.Click -= value2;
                }
                _OptionsToolStripMenuItem = value;
                if (_OptionsToolStripMenuItem != null)
                {
                    _OptionsToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem HelpToolStripMenuItem
        {
            get
            {
                return _HelpToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _HelpToolStripMenuItem = value;
            }
        }

        internal virtual ToolStripMenuItem CheckForupdatesToolStripMenuItem
        {
            get
            {
                return _CheckForupdatesToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = CheckForupdatesToolStripMenuItem_Click;
                if (_CheckForupdatesToolStripMenuItem != null)
                {
                    _CheckForupdatesToolStripMenuItem.Click -= value2;
                }
                _CheckForupdatesToolStripMenuItem = value;
                if (_CheckForupdatesToolStripMenuItem != null)
                {
                    _CheckForupdatesToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem FileToolStripMenuItem
        {
            get
            {
                return _FileToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _FileToolStripMenuItem = value;
            }
        }

        internal virtual ToolStripMenuItem ExitToolStripMenuItem
        {
            get
            {
                return _ExitToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = ExitToolStripMenuItem_Click;
                if (_ExitToolStripMenuItem != null)
                {
                    _ExitToolStripMenuItem.Click -= value2;
                }
                _ExitToolStripMenuItem = value;
                if (_ExitToolStripMenuItem != null)
                {
                    _ExitToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual StatusStrip StatusStrip1
        {
            get
            {
                return _StatusStrip1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                ToolStripItemClickedEventHandler value2 = StatusStrip1_ItemClicked;
                if (_StatusStrip1 != null)
                {
                    _StatusStrip1.ItemClicked -= value2;
                }
                _StatusStrip1 = value;
                if (_StatusStrip1 != null)
                {
                    _StatusStrip1.ItemClicked += value2;
                }
            }
        }

        internal virtual ContextMenuStrip ContextMenuStrip1
        {
            get
            {
                return _ContextMenuStrip1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ContextMenuStrip1 = value;
            }
        }

        internal virtual ToolStripMenuItem PropertiesToolStripMenuItem
        {
            get
            {
                return _PropertiesToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = PropertiesToolStripMenuItem_Click;
                if (_PropertiesToolStripMenuItem != null)
                {
                    _PropertiesToolStripMenuItem.Click -= value2;
                }
                _PropertiesToolStripMenuItem = value;
                if (_PropertiesToolStripMenuItem != null)
                {
                    _PropertiesToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripSeparator ToolStripMenuItem1
        {
            get
            {
                return _ToolStripMenuItem1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ToolStripMenuItem1 = value;
            }
        }

        internal virtual ToolStripMenuItem AboutL4DAOIToolStripMenuItem
        {
            get
            {
                return _AboutL4DAOIToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = AboutL4DAOIToolStripMenuItem_Click;
                if (_AboutL4DAOIToolStripMenuItem != null)
                {
                    _AboutL4DAOIToolStripMenuItem.Click -= value2;
                }
                _AboutL4DAOIToolStripMenuItem = value;
                if (_AboutL4DAOIToolStripMenuItem != null)
                {
                    _AboutL4DAOIToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem InstallUnmanagedAddOnToolStripMenuItem
        {
            get
            {
                return _InstallUnmanagedAddOnToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = InstallUnmanagedAddOnToolStripMenuItem_Click;
                if (_InstallUnmanagedAddOnToolStripMenuItem != null)
                {
                    _InstallUnmanagedAddOnToolStripMenuItem.Click -= value2;
                }
                _InstallUnmanagedAddOnToolStripMenuItem = value;
                if (_InstallUnmanagedAddOnToolStripMenuItem != null)
                {
                    _InstallUnmanagedAddOnToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual UpdateController UpdateController1
        {
            get
            {
                return _UpdateController1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _UpdateController1 = value;
            }
        }

        internal virtual ContextMenuStrip ContextMenuStrip2
        {
            get
            {
                return _ContextMenuStrip2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                CancelEventHandler value2 = ContextMenuStrip2_Opening;
                if (_ContextMenuStrip2 != null)
                {
                    _ContextMenuStrip2.Opening -= value2;
                }
                _ContextMenuStrip2 = value;
                if (_ContextMenuStrip2 != null)
                {
                    _ContextMenuStrip2.Opening += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem InstallToolStripMenuItem
        {
            get
            {
                return _InstallToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = InstallToolStripMenuItem_Click;
                if (_InstallToolStripMenuItem != null)
                {
                    _InstallToolStripMenuItem.Click -= value2;
                }
                _InstallToolStripMenuItem = value;
                if (_InstallToolStripMenuItem != null)
                {
                    _InstallToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem UpdateAddonListToolStripMenuItem
        {
            get
            {
                return _UpdateAddonListToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = UpdateAddonListToolStripMenuItem_Click;
                if (_UpdateAddonListToolStripMenuItem != null)
                {
                    _UpdateAddonListToolStripMenuItem.Click -= value2;
                }
                _UpdateAddonListToolStripMenuItem = value;
                if (_UpdateAddonListToolStripMenuItem != null)
                {
                    _UpdateAddonListToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripSeparator ToolStripMenuItem2
        {
            get
            {
                return _ToolStripMenuItem2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ToolStripMenuItem2 = value;
            }
        }

        internal virtual ToolStripMenuItem ViewToolStripMenuItem
        {
            get
            {
                return _ViewToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ViewToolStripMenuItem = value;
            }
        }

        internal virtual ToolStripMenuItem AddOnFeedsToolStripMenuItem
        {
            get
            {
                return _AddOnFeedsToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = AddOnFeedsToolStripMenuItem_Click;
                if (_AddOnFeedsToolStripMenuItem != null)
                {
                    _AddOnFeedsToolStripMenuItem.Click -= value2;
                }
                _AddOnFeedsToolStripMenuItem = value;
                if (_AddOnFeedsToolStripMenuItem != null)
                {
                    _AddOnFeedsToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem HideUnmanagedAddOnsToolStripMenuItem
        {
            get
            {
                return _HideUnmanagedAddOnsToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = HideUnmanagedAddOnsToolStripMenuItem_Click;
                if (_HideUnmanagedAddOnsToolStripMenuItem != null)
                {
                    _HideUnmanagedAddOnsToolStripMenuItem.Click -= value2;
                }
                _HideUnmanagedAddOnsToolStripMenuItem = value;
                if (_HideUnmanagedAddOnsToolStripMenuItem != null)
                {
                    _HideUnmanagedAddOnsToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripSeparator ToolStripMenuItem3
        {
            get
            {
                return _ToolStripMenuItem3;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ToolStripMenuItem3 = value;
            }
        }

        internal virtual ToolStripMenuItem HideInstalledAddonsToolStripMenuItem
        {
            get
            {
                return _HideInstalledAddonsToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _HideInstalledAddonsToolStripMenuItem = value;
            }
        }

        internal virtual ToolStripMenuItem ApplicationFoldersToolStripMenuItem
        {
            get
            {
                return _ApplicationFoldersToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = ApplicationFoldersToolStripMenuItem_Click;
                if (_ApplicationFoldersToolStripMenuItem != null)
                {
                    _ApplicationFoldersToolStripMenuItem.Click -= value2;
                }
                _ApplicationFoldersToolStripMenuItem = value;
                if (_ApplicationFoldersToolStripMenuItem != null)
                {
                    _ApplicationFoldersToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem AppDataFolderToolStripMenuItem
        {
            get
            {
                return _AppDataFolderToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = AppDataFolderToolStripMenuItem_Click;
                if (_AppDataFolderToolStripMenuItem != null)
                {
                    _AppDataFolderToolStripMenuItem.Click -= value2;
                }
                _AppDataFolderToolStripMenuItem = value;
                if (_AppDataFolderToolStripMenuItem != null)
                {
                    _AppDataFolderToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem TempFolderToolStripMenuItem
        {
            get
            {
                return _TempFolderToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = TempFolderToolStripMenuItem_Click;
                if (_TempFolderToolStripMenuItem != null)
                {
                    _TempFolderToolStripMenuItem.Click -= value2;
                }
                _TempFolderToolStripMenuItem = value;
                if (_TempFolderToolStripMenuItem != null)
                {
                    _TempFolderToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem LogFolderToolStripMenuItem
        {
            get
            {
                return _LogFolderToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = LogFolderToolStripMenuItem_Click;
                if (_LogFolderToolStripMenuItem != null)
                {
                    _LogFolderToolStripMenuItem.Click -= value2;
                }
                _LogFolderToolStripMenuItem = value;
                if (_LogFolderToolStripMenuItem != null)
                {
                    _LogFolderToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem FeedsFolderToolStripMenuItem
        {
            get
            {
                return _FeedsFolderToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = FeedsFolderToolStripMenuItem_Click;
                if (_FeedsFolderToolStripMenuItem != null)
                {
                    _FeedsFolderToolStripMenuItem.Click -= value2;
                }
                _FeedsFolderToolStripMenuItem = value;
                if (_FeedsFolderToolStripMenuItem != null)
                {
                    _FeedsFolderToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripSeparator ToolStripMenuItem5
        {
            get
            {
                return _ToolStripMenuItem5;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ToolStripMenuItem5 = value;
            }
        }

        internal virtual ToolStripMenuItem DownloadFolderToolStripMenuItem
        {
            get
            {
                return _DownloadFolderToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = DownloadFolderToolStripMenuItem_Click;
                if (_DownloadFolderToolStripMenuItem != null)
                {
                    _DownloadFolderToolStripMenuItem.Click -= value2;
                }
                _DownloadFolderToolStripMenuItem = value;
                if (_DownloadFolderToolStripMenuItem != null)
                {
                    _DownloadFolderToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem ToolStripMenuItem6
        {
            get
            {
                return _ToolStripMenuItem6;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ToolStripMenuItem6 = value;
            }
        }

        internal virtual ToolStripMenuItem BinnyButtonToolStripMenuItem
        {
            get
            {
                return _BinnyButtonToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = BinnyButtonToolStripMenuItem_Click;
                if (_BinnyButtonToolStripMenuItem != null)
                {
                    _BinnyButtonToolStripMenuItem.Click -= value2;
                }
                _BinnyButtonToolStripMenuItem = value;
                if (_BinnyButtonToolStripMenuItem != null)
                {
                    _BinnyButtonToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripSeparator ToolStripMenuItem7
        {
            get
            {
                return _ToolStripMenuItem7;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ToolStripMenuItem7 = value;
            }
        }

        internal virtual ToolStripMenuItem Left4Dead2ToolStripMenuItem
        {
            get
            {
                return _Left4Dead2ToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = Left4Dead2ToolStripMenuItem_Click;
                if (_Left4Dead2ToolStripMenuItem != null)
                {
                    _Left4Dead2ToolStripMenuItem.Click -= value2;
                }
                _Left4Dead2ToolStripMenuItem = value;
                if (_Left4Dead2ToolStripMenuItem != null)
                {
                    _Left4Dead2ToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem RunLeft4Dead2ToolStripMenuItem
        {
            get
            {
                return _RunLeft4Dead2ToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = RunLeft4Dead2ToolStripMenuItem_Click;
                if (_RunLeft4Dead2ToolStripMenuItem != null)
                {
                    _RunLeft4Dead2ToolStripMenuItem.Click -= value2;
                }
                _RunLeft4Dead2ToolStripMenuItem = value;
                if (_RunLeft4Dead2ToolStripMenuItem != null)
                {
                    _RunLeft4Dead2ToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripSeparator ToolStripMenuItem8
        {
            get
            {
                return _ToolStripMenuItem8;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ToolStripMenuItem8 = value;
            }
        }

        internal virtual ToolStripSeparator ToolStripMenuItem9
        {
            get
            {
                return _ToolStripMenuItem9;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ToolStripMenuItem9 = value;
            }
        }

        internal virtual ToolStripMenuItem HomepageToolStripMenuItem
        {
            get
            {
                return _HomepageToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = HomepageToolStripMenuItem_Click;
                if (_HomepageToolStripMenuItem != null)
                {
                    _HomepageToolStripMenuItem.Click -= value2;
                }
                _HomepageToolStripMenuItem = value;
                if (_HomepageToolStripMenuItem != null)
                {
                    _HomepageToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual NotifyIcon NotifyIcon1
        {
            get
            {
                return _NotifyIcon1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                MouseEventHandler value2 = NotifyIcon1_MouseDoubleClick;
                EventHandler value3 = NotifyIcon1_Click;
                if (_NotifyIcon1 != null)
                {
                    _NotifyIcon1.MouseDoubleClick -= value2;
                    _NotifyIcon1.Click -= value3;
                }
                _NotifyIcon1 = value;
                if (_NotifyIcon1 != null)
                {
                    _NotifyIcon1.MouseDoubleClick += value2;
                    _NotifyIcon1.Click += value3;
                }
            }
        }

        internal virtual ContextMenuStrip cmsNotifyIcon
        {
            get
            {
                return _cmsNotifyIcon;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _cmsNotifyIcon = value;
            }
        }

        internal virtual ToolStripMenuItem ExitToolStripMenuItem1
        {
            get
            {
                return _ExitToolStripMenuItem1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = ExitToolStripMenuItem1_Click;
                if (_ExitToolStripMenuItem1 != null)
                {
                    _ExitToolStripMenuItem1.Click -= value2;
                }
                _ExitToolStripMenuItem1 = value;
                if (_ExitToolStripMenuItem1 != null)
                {
                    _ExitToolStripMenuItem1.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem DownloadCacheManagerToolStripMenuItem
        {
            get
            {
                return _DownloadCacheManagerToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = DownloadCacheManagerToolStripMenuItem_Click;
                if (_DownloadCacheManagerToolStripMenuItem != null)
                {
                    _DownloadCacheManagerToolStripMenuItem.Click -= value2;
                }
                _DownloadCacheManagerToolStripMenuItem = value;
                if (_DownloadCacheManagerToolStripMenuItem != null)
                {
                    _DownloadCacheManagerToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem UpdateToolStripMenuItem
        {
            get
            {
                return _UpdateToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = UpdateToolStripMenuItem_Click;
                if (_UpdateToolStripMenuItem != null)
                {
                    _UpdateToolStripMenuItem.Click -= value2;
                }
                _UpdateToolStripMenuItem = value;
                if (_UpdateToolStripMenuItem != null)
                {
                    _UpdateToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripStatusLabel ToolStripStatusLabel1
        {
            get
            {
                return _ToolStripStatusLabel1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = ToolStripStatusLabel1_Click_1;
                if (_ToolStripStatusLabel1 != null)
                {
                    _ToolStripStatusLabel1.Click -= value2;
                }
                _ToolStripStatusLabel1 = value;
                if (_ToolStripStatusLabel1 != null)
                {
                    _ToolStripStatusLabel1.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem ToolStripMenuItem4
        {
            get
            {
                return _ToolStripMenuItem4;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ToolStripMenuItem4 = value;
            }
        }

        internal virtual ToolStripMenuItem BToolStripMenuItem
        {
            get
            {
                return _BToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = BToolStripMenuItem_Click_1;
                if (_BToolStripMenuItem != null)
                {
                    _BToolStripMenuItem.Click -= value2;
                }
                _BToolStripMenuItem = value;
                if (_BToolStripMenuItem != null)
                {
                    _BToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem TeamSAOToolStripMenuItem
        {
            get
            {
                return _TeamSAOToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _TeamSAOToolStripMenuItem = value;
            }
        }

        internal virtual ToolStripMenuItem HomePageToolStripMenuItem1
        {
            get
            {
                return _HomePageToolStripMenuItem1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = HomePageToolStripMenuItem1_Click;
                if (_HomePageToolStripMenuItem1 != null)
                {
                    _HomePageToolStripMenuItem1.Click -= value2;
                }
                _HomePageToolStripMenuItem1 = value;
                if (_HomePageToolStripMenuItem1 != null)
                {
                    _HomePageToolStripMenuItem1.Click += value2;
                }
            }
        }

        internal virtual ToolStripSeparator ToolStripMenuItem10
        {
            get
            {
                return _ToolStripMenuItem10;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ToolStripMenuItem10 = value;
            }
        }

        internal virtual ToolStripMenuItem ForumsToolStripMenuItem
        {
            get
            {
                return _ForumsToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = ForumsToolStripMenuItem_Click;
                if (_ForumsToolStripMenuItem != null)
                {
                    _ForumsToolStripMenuItem.Click -= value2;
                }
                _ForumsToolStripMenuItem = value;
                if (_ForumsToolStripMenuItem != null)
                {
                    _ForumsToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem NewsToolStripMenuItem
        {
            get
            {
                return _NewsToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = NewsToolStripMenuItem_Click;
                if (_NewsToolStripMenuItem != null)
                {
                    _NewsToolStripMenuItem.Click -= value2;
                }
                _NewsToolStripMenuItem = value;
                if (_NewsToolStripMenuItem != null)
                {
                    _NewsToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripProgressBar ToolStripProgressBar1
        {
            get
            {
                return _ToolStripProgressBar1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ToolStripProgressBar1 = value;
            }
        }

        internal virtual ToolStripMenuItem RegisterProtocolToolStripMenuItem
        {
            get
            {
                return _RegisterProtocolToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = RegisterProtocolToolStripMenuItem_Click;
                if (_RegisterProtocolToolStripMenuItem != null)
                {
                    _RegisterProtocolToolStripMenuItem.Click -= value2;
                }
                _RegisterProtocolToolStripMenuItem = value;
                if (_RegisterProtocolToolStripMenuItem != null)
                {
                    _RegisterProtocolToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripSeparator ToolStripMenuItem11
        {
            get
            {
                return _ToolStripMenuItem11;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ToolStripMenuItem11 = value;
            }
        }

        internal virtual SplitContainer SplitContainer1
        {
            get
            {
                return _SplitContainer1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                PaintEventHandler value2 = SplitContainer1_Panel1_Paint;
                if (_SplitContainer1 != null)
                {
                    _SplitContainer1.Panel1.Paint -= value2;
                }
                _SplitContainer1 = value;
                if (_SplitContainer1 != null)
                {
                    _SplitContainer1.Panel1.Paint += value2;
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

        internal virtual ToolStrip ToolStrip2
        {
            get
            {
                return _ToolStrip2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ToolStrip2 = value;
            }
        }

        internal virtual ToolStripButton ToolStripButton3
        {
            get
            {
                return _ToolStripButton3;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ToolStripButton3 = value;
            }
        }

        internal virtual ToolStripButton ToolStripButton4
        {
            get
            {
                return _ToolStripButton4;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = ToolStripButton4_Click_1;
                if (_ToolStripButton4 != null)
                {
                    _ToolStripButton4.Click -= value2;
                }
                _ToolStripButton4 = value;
                if (_ToolStripButton4 != null)
                {
                    _ToolStripButton4.Click += value2;
                }
            }
        }

        internal virtual ToolStripButton ToolStripButton2
        {
            get
            {
                return _ToolStripButton2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = ToolStripButton2_Click_1;
                if (_ToolStripButton2 != null)
                {
                    _ToolStripButton2.Click -= value2;
                }
                _ToolStripButton2 = value;
                if (_ToolStripButton2 != null)
                {
                    _ToolStripButton2.Click += value2;
                }
            }
        }

        internal virtual LVNF ListView1
        {
            get
            {
                return _ListView1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                RetrieveVirtualItemEventHandler value2 = ListView1_RetrieveVirtualItem1;
                ListViewItemSelectionChangedEventHandler value3 = ListView1_ItemSelectionChanged;
                ColumnClickEventHandler value4 = ListView1_ColumnClick;
                EventHandler value5 = ListView1_SelectedIndexChanged;
                if (_ListView1 != null)
                {
                    _ListView1.RetrieveVirtualItem -= value2;
                    _ListView1.ItemSelectionChanged -= value3;
                    _ListView1.ColumnClick -= value4;
                    _ListView1.SelectedIndexChanged -= value5;
                }
                _ListView1 = value;
                if (_ListView1 != null)
                {
                    _ListView1.RetrieveVirtualItem += value2;
                    _ListView1.ItemSelectionChanged += value3;
                    _ListView1.ColumnClick += value4;
                    _ListView1.SelectedIndexChanged += value5;
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

        internal virtual ColumnHeader ColumnHeader9
        {
            get
            {
                return _ColumnHeader9;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ColumnHeader9 = value;
            }
        }

        internal virtual ColumnHeader ColumnHeader7
        {
            get
            {
                return _ColumnHeader7;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ColumnHeader7 = value;
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

        internal virtual TabPage TabPage2
        {
            get
            {
                return _TabPage2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _TabPage2 = value;
            }
        }

        internal virtual LVNF ListView2
        {
            get
            {
                return _ListView2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = ListView2_SelectedIndexChanged;
                SearchForVirtualItemEventHandler value3 = ListView2_SearchForVirtualItem;
                RetrieveVirtualItemEventHandler value4 = ListView2_RetrieveVirtualItem;
                ListViewItemSelectionChangedEventHandler value5 = ListView2_ItemSelectionChanged;
                ItemCheckEventHandler value6 = ListView2_ItemCheck;
                ColumnClickEventHandler value7 = ListView2_ColumnClick;
                if (_ListView2 != null)
                {
                    _ListView2.SelectedIndexChanged -= value2;
                    _ListView2.SearchForVirtualItem -= value3;
                    _ListView2.RetrieveVirtualItem -= value4;
                    _ListView2.ItemSelectionChanged -= value5;
                    _ListView2.ItemCheck -= value6;
                    _ListView2.ColumnClick -= value7;
                }
                _ListView2 = value;
                if (_ListView2 != null)
                {
                    _ListView2.SelectedIndexChanged += value2;
                    _ListView2.SearchForVirtualItem += value3;
                    _ListView2.RetrieveVirtualItem += value4;
                    _ListView2.ItemSelectionChanged += value5;
                    _ListView2.ItemCheck += value6;
                    _ListView2.ColumnClick += value7;
                }
            }
        }

        internal virtual ColumnHeader ColumnHeader4
        {
            get
            {
                return _ColumnHeader4;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ColumnHeader4 = value;
            }
        }

        internal virtual ColumnHeader ColumnHeader5
        {
            get
            {
                return _ColumnHeader5;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ColumnHeader5 = value;
            }
        }

        internal virtual ColumnHeader ColumnHeader6
        {
            get
            {
                return _ColumnHeader6;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ColumnHeader6 = value;
            }
        }

        internal virtual ColumnHeader ColumnHeader8
        {
            get
            {
                return _ColumnHeader8;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ColumnHeader8 = value;
            }
        }

        internal virtual ToolStrip ToolStrip1
        {
            get
            {
                return _ToolStrip1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ToolStrip1 = value;
            }
        }

        internal virtual ToolStripButton ToolStripButton1
        {
            get
            {
                return _ToolStripButton1;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = ToolStripButton1_Click_1;
                if (_ToolStripButton1 != null)
                {
                    _ToolStripButton1.Click -= value2;
                }
                _ToolStripButton1 = value;
                if (_ToolStripButton1 != null)
                {
                    _ToolStripButton1.Click += value2;
                }
            }
        }

        internal virtual PictureBox PictureBox2
        {
            get
            {
                return _PictureBox2;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = PictureBox2_Click;
                if (_PictureBox2 != null)
                {
                    _PictureBox2.Click -= value2;
                }
                _PictureBox2 = value;
                if (_PictureBox2 != null)
                {
                    _PictureBox2.Click += value2;
                }
            }
        }

        internal virtual ToolStripMenuItem AddOnFeedsReCacheNowToolStripMenuItem
        {
            get
            {
                return _AddOnFeedsReCacheNowToolStripMenuItem;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler value2 = AddOnFeedsReCacheNowToolStripMenuItem_Click;
                if (_AddOnFeedsReCacheNowToolStripMenuItem != null)
                {
                    _AddOnFeedsReCacheNowToolStripMenuItem.Click -= value2;
                }
                _AddOnFeedsReCacheNowToolStripMenuItem = value;
                if (_AddOnFeedsReCacheNowToolStripMenuItem != null)
                {
                    _AddOnFeedsReCacheNowToolStripMenuItem.Click += value2;
                }
            }
        }

        internal virtual ToolStripSeparator ToolStripMenuItem12
        {
            get
            {
                return _ToolStripMenuItem12;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ToolStripMenuItem12 = value;
            }
        }

        public virtual BannerRotator br
        {
            get
            {
                return _br;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                BannerRotator.OnNextImageEventHandler obj = br_OnNextImage;
                if (_br != null)
                {
                    _br.OnNextImage -= obj;
                }
                _br = value;
                if (_br != null)
                {
                    _br.OnNextImage += obj;
                }
            }
        }

        public virtual ProtocolHandler ProtocolDispatcher
        {
            get
            {
                return _ProtocolDispatcher;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                ProtocolHandler.ProtocolMessageDispatchEventHandler obj = ProtocolDispatcher_ProtocolMessageDispatch;
                if (_ProtocolDispatcher != null)
                {
                    _ProtocolDispatcher.ProtocolMessageDispatch -= obj;
                }
                _ProtocolDispatcher = value;
                if (_ProtocolDispatcher != null)
                {
                    _ProtocolDispatcher.ProtocolMessageDispatch += obj;
                }
            }
        }

        public virtual AddOnManager AddOnManager
        {
            get
            {
                return _AddOnManager;
            }
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                AddOnManager.NewAddOnDetectedEventHandler obj = AddOnManager_NewAddOnDetected;
                AddOnManager.FeedCacheCompleteEventHandler obj2 = AddOnManager_FeedCacheComplete;
                AddOnManager.AddOnListChangedEventHandler obj3 = AddOnManager_AddOnListChanged;
                AddOnManager.FeedCacheStartedEventHandler obj4 = AddOnManager_FeedCacheStarted;
                if (_AddOnManager != null)
                {
                    _AddOnManager.NewAddOnDetected -= obj;
                    _AddOnManager.FeedCacheComplete -= obj2;
                    _AddOnManager.AddOnListChanged -= obj3;
                    _AddOnManager.FeedCacheStarted -= obj4;
                }
                _AddOnManager = value;
                if (_AddOnManager != null)
                {
                    _AddOnManager.NewAddOnDetected += obj;
                    _AddOnManager.FeedCacheComplete += obj2;
                    _AddOnManager.AddOnListChanged += obj3;
                    _AddOnManager.FeedCacheStarted += obj4;
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Left_4_Dead_2_Add_on_Installer.frmMain));
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddOnFeedsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DownloadCacheManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HideUnmanagedAddOnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.HideInstalledAddonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplicationFoldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AppDataFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.DownloadFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FeedsFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TempFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.Left4Dead2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateAddonListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InstallUnmanagedAddOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.RunLeft4Dead2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.RegisterProtocolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
            this.OptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckForupdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutL4DAOIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.BinnyButtonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.TeamSAOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HomePageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.NewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ForumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.InstallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.HomepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateController1 = new Kjs.AppLife.Update.Controller.UpdateController(this.components);
            this.NotifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.ToolStrip2 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.ListView1 = new Left_4_Dead_2_Add_on_Installer.LVNF();
            this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.ListView2 = new Left_4_Dead_2_Add_on_Installer.LVNF();
            this.ColumnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.AddOnFeedsReCacheNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem12 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.ContextMenuStrip1.SuspendLayout();
            this.ContextMenuStrip2.SuspendLayout();
            this.cmsNotifyIcon.SuspendLayout();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.ToolStrip2.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
            this.SuspendLayout();
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[8] { this.FileToolStripMenuItem, this.ViewToolStripMenuItem, this.ToolsToolStripMenuItem, this.HelpToolStripMenuItem, this.ToolStripMenuItem6, this.BinnyButtonToolStripMenuItem, this.ToolStripMenuItem4, this.TeamSAOToolStripMenuItem });
            System.Drawing.Point point2 = (this.MenuStrip1.Location = new System.Drawing.Point(0, 0));
            this.MenuStrip1.Name = "MenuStrip1";
            System.Drawing.Size size2 = (this.MenuStrip1.Size = new System.Drawing.Size(891, 24));
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "MenuStrip1";
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.ExitToolStripMenuItem });
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            size2 = (this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20));
            this.FileToolStripMenuItem.Text = "&File";
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            size2 = (this.ExitToolStripMenuItem.Size = new System.Drawing.Size(92, 22));
            this.ExitToolStripMenuItem.Text = "E&xit";
            this.ViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[9] { this.AddOnFeedsToolStripMenuItem, this.AddOnFeedsReCacheNowToolStripMenuItem, this.ToolStripMenuItem12, this.DownloadCacheManagerToolStripMenuItem, this.HideUnmanagedAddOnsToolStripMenuItem, this.ToolStripMenuItem3, this.HideInstalledAddonsToolStripMenuItem, this.ApplicationFoldersToolStripMenuItem, this.BToolStripMenuItem });
            this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            size2 = (this.ViewToolStripMenuItem.Size = new System.Drawing.Size(44, 20));
            this.ViewToolStripMenuItem.Text = "&View";
            this.AddOnFeedsToolStripMenuItem.Name = "AddOnFeedsToolStripMenuItem";
            size2 = (this.AddOnFeedsToolStripMenuItem.Size = new System.Drawing.Size(232, 22));
            this.AddOnFeedsToolStripMenuItem.Text = "Add-On Feeds";
            this.DownloadCacheManagerToolStripMenuItem.Name = "DownloadCacheManagerToolStripMenuItem";
            size2 = (this.DownloadCacheManagerToolStripMenuItem.Size = new System.Drawing.Size(232, 22));
            this.DownloadCacheManagerToolStripMenuItem.Text = "Download Cache Manager";
            this.HideUnmanagedAddOnsToolStripMenuItem.Name = "HideUnmanagedAddOnsToolStripMenuItem";
            size2 = (this.HideUnmanagedAddOnsToolStripMenuItem.Size = new System.Drawing.Size(232, 22));
            this.HideUnmanagedAddOnsToolStripMenuItem.Text = "Hide Unmanaged Add-Ons";
            this.HideUnmanagedAddOnsToolStripMenuItem.Visible = false;
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            size2 = (this.ToolStripMenuItem3.Size = new System.Drawing.Size(229, 6));
            this.HideInstalledAddonsToolStripMenuItem.Name = "HideInstalledAddonsToolStripMenuItem";
            size2 = (this.HideInstalledAddonsToolStripMenuItem.Size = new System.Drawing.Size(232, 22));
            this.HideInstalledAddonsToolStripMenuItem.Text = "Hide Installed Add-Ons";
            this.HideInstalledAddonsToolStripMenuItem.Visible = false;
            this.ApplicationFoldersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[8] { this.AppDataFolderToolStripMenuItem, this.ToolStripMenuItem5, this.DownloadFolderToolStripMenuItem, this.FeedsFolderToolStripMenuItem, this.LogFolderToolStripMenuItem, this.TempFolderToolStripMenuItem, this.ToolStripMenuItem7, this.Left4Dead2ToolStripMenuItem });
            this.ApplicationFoldersToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("ApplicationFoldersToolStripMenuItem.Image");
            this.ApplicationFoldersToolStripMenuItem.Name = "ApplicationFoldersToolStripMenuItem";
            size2 = (this.ApplicationFoldersToolStripMenuItem.Size = new System.Drawing.Size(232, 22));
            this.ApplicationFoldersToolStripMenuItem.Text = "Application Folders";
            this.AppDataFolderToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("AppDataFolderToolStripMenuItem.Image");
            this.AppDataFolderToolStripMenuItem.Name = "AppDataFolderToolStripMenuItem";
            size2 = (this.AppDataFolderToolStripMenuItem.Size = new System.Drawing.Size(164, 22));
            this.AppDataFolderToolStripMenuItem.Text = "AppData Folder";
            this.ToolStripMenuItem5.Name = "ToolStripMenuItem5";
            size2 = (this.ToolStripMenuItem5.Size = new System.Drawing.Size(161, 6));
            this.DownloadFolderToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("DownloadFolderToolStripMenuItem.Image");
            this.DownloadFolderToolStripMenuItem.Name = "DownloadFolderToolStripMenuItem";
            size2 = (this.DownloadFolderToolStripMenuItem.Size = new System.Drawing.Size(164, 22));
            this.DownloadFolderToolStripMenuItem.Text = "Download Folder";
            this.FeedsFolderToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("FeedsFolderToolStripMenuItem.Image");
            this.FeedsFolderToolStripMenuItem.Name = "FeedsFolderToolStripMenuItem";
            size2 = (this.FeedsFolderToolStripMenuItem.Size = new System.Drawing.Size(164, 22));
            this.FeedsFolderToolStripMenuItem.Text = "Feeds Folder";
            this.LogFolderToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("LogFolderToolStripMenuItem.Image");
            this.LogFolderToolStripMenuItem.Name = "LogFolderToolStripMenuItem";
            size2 = (this.LogFolderToolStripMenuItem.Size = new System.Drawing.Size(164, 22));
            this.LogFolderToolStripMenuItem.Text = "Log Folder";
            this.TempFolderToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("TempFolderToolStripMenuItem.Image");
            this.TempFolderToolStripMenuItem.Name = "TempFolderToolStripMenuItem";
            size2 = (this.TempFolderToolStripMenuItem.Size = new System.Drawing.Size(164, 22));
            this.TempFolderToolStripMenuItem.Text = "Temp Folder";
            this.ToolStripMenuItem7.Name = "ToolStripMenuItem7";
            size2 = (this.ToolStripMenuItem7.Size = new System.Drawing.Size(161, 6));
            this.Left4Dead2ToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("Left4Dead2ToolStripMenuItem.Image");
            this.Left4Dead2ToolStripMenuItem.Name = "Left4Dead2ToolStripMenuItem";
            size2 = (this.Left4Dead2ToolStripMenuItem.Size = new System.Drawing.Size(164, 22));
            this.Left4Dead2ToolStripMenuItem.Text = "Left 4 Dead 2";
            this.BToolStripMenuItem.Name = "BToolStripMenuItem";
            size2 = (this.BToolStripMenuItem.Size = new System.Drawing.Size(232, 22));
            this.BToolStripMenuItem.Text = "Hide/Show Banners";
            this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[8] { this.UpdateAddonListToolStripMenuItem, this.InstallUnmanagedAddOnToolStripMenuItem, this.ToolStripMenuItem2, this.RunLeft4Dead2ToolStripMenuItem, this.ToolStripMenuItem8, this.RegisterProtocolToolStripMenuItem, this.ToolStripMenuItem11, this.OptionsToolStripMenuItem });
            this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            size2 = (this.ToolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20));
            this.ToolsToolStripMenuItem.Text = "&Tools";
            this.UpdateAddonListToolStripMenuItem.Name = "UpdateAddonListToolStripMenuItem";
            size2 = (this.UpdateAddonListToolStripMenuItem.Size = new System.Drawing.Size(219, 22));
            this.UpdateAddonListToolStripMenuItem.Text = "Update Add-on List";
            this.UpdateAddonListToolStripMenuItem.Visible = false;
            this.InstallUnmanagedAddOnToolStripMenuItem.Name = "InstallUnmanagedAddOnToolStripMenuItem";
            size2 = (this.InstallUnmanagedAddOnToolStripMenuItem.Size = new System.Drawing.Size(219, 22));
            this.InstallUnmanagedAddOnToolStripMenuItem.Text = "Install Unmanaged Add-On";
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            size2 = (this.ToolStripMenuItem2.Size = new System.Drawing.Size(216, 6));
            this.RunLeft4Dead2ToolStripMenuItem.Name = "RunLeft4Dead2ToolStripMenuItem";
            size2 = (this.RunLeft4Dead2ToolStripMenuItem.Size = new System.Drawing.Size(219, 22));
            this.RunLeft4Dead2ToolStripMenuItem.Text = "Binny Button";
            this.ToolStripMenuItem8.Name = "ToolStripMenuItem8";
            size2 = (this.ToolStripMenuItem8.Size = new System.Drawing.Size(216, 6));
            this.RegisterProtocolToolStripMenuItem.Name = "RegisterProtocolToolStripMenuItem";
            size2 = (this.RegisterProtocolToolStripMenuItem.Size = new System.Drawing.Size(219, 22));
            this.RegisterProtocolToolStripMenuItem.Text = "Register Filetypes";
            this.ToolStripMenuItem11.Name = "ToolStripMenuItem11";
            size2 = (this.ToolStripMenuItem11.Size = new System.Drawing.Size(216, 6));
            this.OptionsToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("OptionsToolStripMenuItem.Image");
            this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
            size2 = (this.OptionsToolStripMenuItem.Size = new System.Drawing.Size(219, 22));
            this.OptionsToolStripMenuItem.Text = "&Options...";
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.CheckForupdatesToolStripMenuItem, this.ToolStripMenuItem1, this.AboutL4DAOIToolStripMenuItem });
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            size2 = (this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20));
            this.HelpToolStripMenuItem.Text = "&Help";
            this.CheckForupdatesToolStripMenuItem.Name = "CheckForupdatesToolStripMenuItem";
            size2 = (this.CheckForupdatesToolStripMenuItem.Size = new System.Drawing.Size(179, 22));
            this.CheckForupdatesToolStripMenuItem.Text = "Check for &updates...";
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            size2 = (this.ToolStripMenuItem1.Size = new System.Drawing.Size(176, 6));
            this.AboutL4DAOIToolStripMenuItem.Name = "AboutL4DAOIToolStripMenuItem";
            size2 = (this.AboutL4DAOIToolStripMenuItem.Size = new System.Drawing.Size(179, 22));
            this.AboutL4DAOIToolStripMenuItem.Text = "&About L4DAOI";
            this.ToolStripMenuItem6.Name = "ToolStripMenuItem6";
            size2 = (this.ToolStripMenuItem6.Size = new System.Drawing.Size(22, 20));
            this.ToolStripMenuItem6.Text = "|";
            this.BinnyButtonToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("BinnyButtonToolStripMenuItem.Image");
            this.BinnyButtonToolStripMenuItem.Name = "BinnyButtonToolStripMenuItem";
            size2 = (this.BinnyButtonToolStripMenuItem.Size = new System.Drawing.Size(127, 20));
            this.BinnyButtonToolStripMenuItem.Text = "Run Left 4 Dead 2";
            this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
            size2 = (this.ToolStripMenuItem4.Size = new System.Drawing.Size(22, 20));
            this.ToolStripMenuItem4.Text = "|";
            this.TeamSAOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[4] { this.HomePageToolStripMenuItem1, this.ToolStripMenuItem10, this.NewsToolStripMenuItem, this.ForumsToolStripMenuItem });
            this.TeamSAOToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("TeamSAOToolStripMenuItem.Image");
            this.TeamSAOToolStripMenuItem.Name = "TeamSAOToolStripMenuItem";
            size2 = (this.TeamSAOToolStripMenuItem.Size = new System.Drawing.Size(99, 20));
            this.TeamSAOToolStripMenuItem.Text = "MisterDr";
            this.HomePageToolStripMenuItem1.Image = (System.Drawing.Image)resources.GetObject("HomePageToolStripMenuItem1.Image");
            this.HomePageToolStripMenuItem1.Name = "HomePageToolStripMenuItem1";
            size2 = (this.HomePageToolStripMenuItem1.Size = new System.Drawing.Size(136, 22));
            this.HomePageToolStripMenuItem1.Text = "Home Page";
            this.ToolStripMenuItem10.Name = "ToolStripMenuItem10";
            size2 = (this.ToolStripMenuItem10.Size = new System.Drawing.Size(133, 6));
            this.NewsToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("NewsToolStripMenuItem.Image");
            this.NewsToolStripMenuItem.Name = "NewsToolStripMenuItem";
            size2 = (this.NewsToolStripMenuItem.Size = new System.Drawing.Size(136, 22));
            this.NewsToolStripMenuItem.Text = "News";
            this.ForumsToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("ForumsToolStripMenuItem.Image");
            this.ForumsToolStripMenuItem.Name = "ForumsToolStripMenuItem";
            size2 = (this.ForumsToolStripMenuItem.Size = new System.Drawing.Size(136, 22));
            this.ForumsToolStripMenuItem.Text = "Forums";
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.ToolStripStatusLabel1, this.ToolStripProgressBar1 });
            point2 = (this.StatusStrip1.Location = new System.Drawing.Point(0, 487));
            this.StatusStrip1.Name = "StatusStrip1";
            size2 = (this.StatusStrip1.Size = new System.Drawing.Size(891, 22));
            this.StatusStrip1.TabIndex = 2;
            this.StatusStrip1.Text = "StatusStrip1";
            this.ToolStripStatusLabel1.Image = (System.Drawing.Image)resources.GetObject("ToolStripStatusLabel1.Image");
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            size2 = (this.ToolStripStatusLabel1.Size = new System.Drawing.Size(169, 17));
            this.ToolStripStatusLabel1.Text = "There is an update availible.";
            this.ToolStripStatusLabel1.Visible = false;
            this.ToolStripProgressBar1.Name = "ToolStripProgressBar1";
            size2 = (this.ToolStripProgressBar1.Size = new System.Drawing.Size(100, 16));
            this.ToolStripProgressBar1.ToolTipText = "Updating AddOn Feeds";
            this.ToolStripProgressBar1.Visible = false;
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[2] { this.UpdateToolStripMenuItem, this.PropertiesToolStripMenuItem });
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            size2 = (this.ContextMenuStrip1.Size = new System.Drawing.Size(128, 48));
            this.UpdateToolStripMenuItem.Enabled = false;
            this.UpdateToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("UpdateToolStripMenuItem.Image");
            this.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            size2 = (this.UpdateToolStripMenuItem.Size = new System.Drawing.Size(127, 22));
            this.UpdateToolStripMenuItem.Text = "Update";
            this.PropertiesToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("PropertiesToolStripMenuItem.Image");
            this.PropertiesToolStripMenuItem.Name = "PropertiesToolStripMenuItem";
            size2 = (this.PropertiesToolStripMenuItem.Size = new System.Drawing.Size(127, 22));
            this.PropertiesToolStripMenuItem.Text = "&Properties";
            this.ContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.InstallToolStripMenuItem, this.ToolStripMenuItem9, this.HomepageToolStripMenuItem });
            this.ContextMenuStrip2.Name = "ContextMenuStrip2";
            size2 = (this.ContextMenuStrip2.Size = new System.Drawing.Size(134, 54));
            this.InstallToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("InstallToolStripMenuItem.Image");
            this.InstallToolStripMenuItem.Name = "InstallToolStripMenuItem";
            size2 = (this.InstallToolStripMenuItem.Size = new System.Drawing.Size(133, 22));
            this.InstallToolStripMenuItem.Text = "Install";
            this.ToolStripMenuItem9.Name = "ToolStripMenuItem9";
            size2 = (this.ToolStripMenuItem9.Size = new System.Drawing.Size(130, 6));
            this.HomepageToolStripMenuItem.Image = (System.Drawing.Image)resources.GetObject("HomepageToolStripMenuItem.Image");
            this.HomepageToolStripMenuItem.Name = "HomepageToolStripMenuItem";
            size2 = (this.HomepageToolStripMenuItem.Size = new System.Drawing.Size(133, 22));
            this.HomepageToolStripMenuItem.Text = "Homepage";
            System.Guid guid2 = (this.UpdateController1.ApplicationId = new System.Guid("54e1db27-bad1-472c-aa35-b010b1a1a73e"));
            this.UpdateController1.BypassProxyOnLocal = true;
            this.UpdateController1.CurrentUpdate = null;
            this.UpdateController1.CustomHttpHeaderValue = "";
            this.UpdateController1.ElevationType = Kjs.AppLife.Update.Controller.UpdateElevationType.Uac;
            this.UpdateController1.PublicKeyToken = resources.GetString("UpdateController1.PublicKeyToken");
            this.UpdateController1.UpdateLocation = "http://teamsao.pjusolutions.com/l4d2/";
            this.UpdateController1.UseHostAssemblyVersion = true;
            this.UpdateController1.WebRequestKeepAlive = true;
            this.NotifyIcon1.ContextMenuStrip = this.cmsNotifyIcon;
            this.NotifyIcon1.Icon = (System.Drawing.Icon)resources.GetObject("NotifyIcon1.Icon");
            this.NotifyIcon1.Text = "Left 4 Dead Add-On Installer";
            this.NotifyIcon1.Visible = true;
            this.cmsNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.ExitToolStripMenuItem1 });
            this.cmsNotifyIcon.Name = "cmsNotifyIcon";
            size2 = (this.cmsNotifyIcon.Size = new System.Drawing.Size(93, 26));
            this.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1";
            size2 = (this.ExitToolStripMenuItem1.Size = new System.Drawing.Size(92, 22));
            this.ExitToolStripMenuItem1.Text = "Exit";
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.SplitContainer1.IsSplitterFixed = true;
            point2 = (this.SplitContainer1.Location = new System.Drawing.Point(0, 24));
            this.SplitContainer1.Name = "SplitContainer1";
            this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.SplitContainer1.Panel1.Controls.Add(this.TabControl1);
            this.SplitContainer1.Panel2.Controls.Add(this.PictureBox2);
            this.SplitContainer1.Panel2MinSize = 75;
            size2 = (this.SplitContainer1.Size = new System.Drawing.Size(891, 463));
            this.SplitContainer1.SplitterDistance = 387;
            this.SplitContainer1.SplitterWidth = 1;
            this.SplitContainer1.TabIndex = 5;
            this.TabControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            point2 = (this.TabControl1.Location = new System.Drawing.Point(12, 3));
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            size2 = (this.TabControl1.Size = new System.Drawing.Size(867, 379));
            this.TabControl1.TabIndex = 3;
            this.TabPage1.Controls.Add(this.ToolStrip2);
            this.TabPage1.Controls.Add(this.ListView1);
            point2 = (this.TabPage1.Location = new System.Drawing.Point(4, 22));
            this.TabPage1.Name = "TabPage1";
            System.Windows.Forms.Padding padding2 = (this.TabPage1.Padding = new System.Windows.Forms.Padding(3));
            size2 = (this.TabPage1.Size = new System.Drawing.Size(859, 353));
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Installed";
            this.TabPage1.UseVisualStyleBackColor = true;
            this.ToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[3] { this.ToolStripButton3, this.ToolStripButton4, this.ToolStripButton2 });
            point2 = (this.ToolStrip2.Location = new System.Drawing.Point(3, 3));
            this.ToolStrip2.Name = "ToolStrip2";
            size2 = (this.ToolStrip2.Size = new System.Drawing.Size(853, 25));
            this.ToolStrip2.TabIndex = 6;
            this.ToolStrip2.Text = "ToolStrip2";
            this.ToolStripButton3.Image = (System.Drawing.Image)resources.GetObject("ToolStripButton3.Image");
            this.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton3.Name = "ToolStripButton3";
            size2 = (this.ToolStripButton3.Size = new System.Drawing.Size(66, 22));
            this.ToolStripButton3.Text = "Refresh";
            this.ToolStripButton4.Enabled = false;
            this.ToolStripButton4.Image = (System.Drawing.Image)resources.GetObject("ToolStripButton4.Image");
            this.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton4.Name = "ToolStripButton4";
            size2 = (this.ToolStripButton4.Size = new System.Drawing.Size(65, 22));
            this.ToolStripButton4.Text = "Update";
            this.ToolStripButton2.Enabled = false;
            this.ToolStripButton2.Image = (System.Drawing.Image)resources.GetObject("ToolStripButton2.Image");
            this.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton2.Name = "ToolStripButton2";
            size2 = (this.ToolStripButton2.Size = new System.Drawing.Size(80, 22));
            this.ToolStripButton2.Text = "Properties";
            this.TabPage2.Controls.Add(this.ListView2);
            this.TabPage2.Controls.Add(this.ToolStrip1);
            point2 = (this.TabPage2.Location = new System.Drawing.Point(4, 22));
            this.TabPage2.Name = "TabPage2";
            padding2 = (this.TabPage2.Padding = new System.Windows.Forms.Padding(3));
            size2 = (this.TabPage2.Size = new System.Drawing.Size(859, 353));
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Availible";
            this.TabPage2.UseVisualStyleBackColor = true;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.ToolStripButton1 });
            point2 = (this.ToolStrip1.Location = new System.Drawing.Point(3, 3));
            this.ToolStrip1.Name = "ToolStrip1";
            size2 = (this.ToolStrip1.Size = new System.Drawing.Size(853, 25));
            this.ToolStrip1.TabIndex = 5;
            this.ToolStrip1.Text = "Install";
            this.ToolStripButton1.Enabled = false;
            this.ToolStripButton1.Image = (System.Drawing.Image)resources.GetObject("ToolStripButton1.Image");
            this.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton1.Name = "ToolStripButton1";
            size2 = (this.ToolStripButton1.Size = new System.Drawing.Size(58, 22));
            this.ToolStripButton1.Text = "Install";
            this.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            this.PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox2.Image = (System.Drawing.Image)resources.GetObject("PictureBox2.Image");
            point2 = (this.PictureBox2.Location = new System.Drawing.Point(253, -6));
            this.PictureBox2.Name = "PictureBox2";
            size2 = (this.PictureBox2.Size = new System.Drawing.Size(398, 75));
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 0;
            this.PictureBox2.TabStop = false;
            this.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[5] { this.ColumnHeader1, this.ColumnHeader3, this.ColumnHeader9, this.ColumnHeader7, this.ColumnHeader2 });
            this.ListView1.ContextMenuStrip = this.ContextMenuStrip1;
            this.ListView1.FullRowSelect = true;
            point2 = (this.ListView1.Location = new System.Drawing.Point(3, 31));
            this.ListView1.MultiSelect = false;
            this.ListView1.Name = "ListView1";
            this.ListView1.ShowGroups = false;
            size2 = (this.ListView1.Size = new System.Drawing.Size(853, 316));
            this.ListView1.TabIndex = 2;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.VirtualMode = true;
            this.ColumnHeader1.Text = "Title";
            this.ColumnHeader1.Width = 200;
            this.ColumnHeader3.Text = "Author";
            this.ColumnHeader3.Width = 125;
            this.ColumnHeader9.Text = "Installed";
            this.ColumnHeader9.Width = 75;
            this.ColumnHeader7.Text = "Online";
            this.ColumnHeader7.Width = 75;
            this.ColumnHeader2.Text = "Tags";
            this.ColumnHeader2.Width = 150;
            this.ListView2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.ListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[4] { this.ColumnHeader4, this.ColumnHeader5, this.ColumnHeader6, this.ColumnHeader8 });
            this.ListView2.ContextMenuStrip = this.ContextMenuStrip2;
            this.ListView2.FullRowSelect = true;
            point2 = (this.ListView2.Location = new System.Drawing.Point(3, 32));
            this.ListView2.Name = "ListView2";
            this.ListView2.ShowGroups = false;
            size2 = (this.ListView2.Size = new System.Drawing.Size(853, 312));
            this.ListView2.TabIndex = 3;
            this.ListView2.UseCompatibleStateImageBehavior = false;
            this.ListView2.View = System.Windows.Forms.View.Details;
            this.ListView2.VirtualMode = true;
            this.ColumnHeader4.Text = "Title";
            this.ColumnHeader4.Width = 89;
            this.ColumnHeader5.Text = "Version";
            this.ColumnHeader5.Width = 117;
            this.ColumnHeader6.Text = "URL";
            this.ColumnHeader6.Width = 141;
            this.ColumnHeader8.Text = "Download Size";
            this.ColumnHeader8.Width = 109;
            this.AddOnFeedsReCacheNowToolStripMenuItem.Name = "AddOnFeedsReCacheNowToolStripMenuItem";
            size2 = (this.AddOnFeedsReCacheNowToolStripMenuItem.Size = new System.Drawing.Size(232, 22));
            this.AddOnFeedsReCacheNowToolStripMenuItem.Text = "Add-On Feeds Re-Cache Now";
            this.ToolStripMenuItem12.Name = "ToolStripMenuItem12";
            size2 = (this.ToolStripMenuItem12.Size = new System.Drawing.Size(229, 6));
            System.Drawing.SizeF sizeF2 = (this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f));
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            size2 = (this.ClientSize = new System.Drawing.Size(891, 509));
            this.Controls.Add(this.SplitContainer1);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.MenuStrip1);
            this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this.MainMenuStrip = this.MenuStrip1;
            size2 = (this.MinimumSize = new System.Drawing.Size(650, 400));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Left 4 Dead Add-On Installer";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ContextMenuStrip1.ResumeLayout(false);
            this.ContextMenuStrip2.ResumeLayout(false);
            this.cmsNotifyIcon.ResumeLayout(false);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            this.SplitContainer1.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.ToolStrip2.ResumeLayout(false);
            this.ToolStrip2.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void OptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyProject.Forms.frmOptions.ShowDialog();
        }

        public void SetUpAdvertBanner()
        {
            //br.Rotation = BannerRotation.InOrder;
            //br._Banners.Add(new Banner("http://www.teamsao.com/L4D2AOI/casuallykilling.jpg", "http://www.teamsao.com", 15));
            //br._Banners.Add(new Banner("http://www.teamsao.com/L4D2AOI/chocolatedonate.jpg", "https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=scne14435%40blueyonder%2eco%2euk&lc=US&item_name=Donate%20to%20Team%20%5bSAO%5d&currency_code=USD&bn=PP%2dDonationsBF%3abtn_donateCC_LG%2egif%3aNonHostedGuest", 15));
            //br._Banners.Add(new Banner("http://www.teamsao.com/L4D2AOI/joininforums.jpg", "http://teamsao.com/index.php?option=com_comprofiler&task=registers", 15));
            //br.picturebox = PictureBox2;
            //br.Start();
        }

        public void StartUP()
        {
            AddOnManager.StartWatchingAddOnFolder(Path.Combine(MySettingsProperty.Settings.L4D2InstallFolder, "left4dead2\\addons"));
            GetAvailibleAddOnsXML();
            ScanForAddOns();
        }

        private void GetAvailibleAddOnsXML()
        {
            //Discarded unreachable code: IL_0068
            try
            {
                AddOnManager.AddOnFeedManager.Load(Path.Combine(AOIPaths.FeedsPath(), "Feeds.xml"));
                foreach (AddOn getAddOn in AddOnManager.AddOnFeedManager.GetAddOns)
                {
                    AddOnManager.AddOnList.AddAddon(getAddOn);
                }
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
            foreach (AddOn addOn in AddOnScanner.GetAddOnsFromXMLFile(Path.Combine(AOIPaths.FeedsPath(), "Cache.xml")).AddOns)
            {
                addOn.IsManaged = true;
                addOn.IsInstalled = false;
                AddOnManager.AddOnList.AddAddon(addOn);
            }
            foreach (AddOn addOn2 in AddOnScanner.GetAddOnsFromXMLFile(Path.Combine(MyProject.Application.Info.DirectoryPath, "AddOns.xml")).AddOns)
            {
                addOn2.IsManaged = true;
                addOn2.IsInstalled = false;
                AddOnManager.AddOnList.AddAddon(addOn2);
            }
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            br.Stop();
        }

        private void CheckPaths()
        {
            if (Checkl4dpath())
            {
                return;
            }
            bool flag = true;
            DialogResult dialogResult = default(DialogResult);
            while (flag)
            {
                if (Checkl4dpath())
                {
                    flag = false;
                    continue;
                }
                Form form = new Form();
                form.TopMost = true;
                dialogResult = MessageBox.Show(form, "You need to set the directory Left 4 Dead 2 is install to. Do you wish to set it now?", "Set Installtaion Directory?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dialogResult == DialogResult.Yes)
                {
                    MyProject.Forms.frmOptions.ShowDialog(form);
                }
                else
                {
                    flag = false;
                }
                form.Dispose();
                form = null;
            }
            if (dialogResult == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SplitContainer1.Panel2Collapsed = !MySettingsProperty.Settings.ShowBanners;
            InstallGenerator2 installGenerator = new InstallGenerator2();
            installGenerator.GetActionForFile("t\\ttt\\");
            installGenerator.GetActionForFile("t\\ttt\\yyy.txt");
            SplitContainer1.SplitterDistance = 375;
            string path = AOIPaths.AppDataPath();
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }
            UpdateController1.Version = MyProject.Application.Info.Version;
            CheckPaths();
            Thread thread = new Thread(StartUP);
            thread.Start();
            while (thread.IsAlive)
            {
                MyProject.Application.DoEvents();
            }
            try
            {
                //Thread thread2 = new Thread(SetUpAdvertBanner);
                //thread2.Start();
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
            ListView l = ListView1;
            VLS(ref l, AddOnManager.AddOnList.GetInstalledAddOns.Count());
            ListView1 = (LVNF)l;
            l = ListView2;
            VLS(ref l, AddOnManager.AddOnList.GetAvailibleAddOns.Count());
            ListView2 = (LVNF)l;
            AddOnManager.AddOnList.SorttAvailibledAddOns();
            AddOnManager.AddOnList.AdvancedAddOns.SortInstalledAddOnsByName();
            ListView1.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            ListView2.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        public bool Checkl4dpath()
        {
            try
            {
                if (Directory.Exists(MySettingsProperty.Settings.L4D2InstallFolder))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                bool result = false;
                ProjectData.ClearProjectError();
                return result;
            }
        }

        public void ScanForAddOns()
        {
            foreach (AddOn item in AddOnScanner.GetAddOnsFromAddOnFolder(Path.Combine(MySettingsProperty.Settings.L4D2InstallFolder, "left4dead2\\addons")))
            {
                AddOnManager.AddOnList.AddAddon(item);
            }
        }

        private void ListView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            string value = ListView1.Columns[e.Column].Text;
            switch (Strings.LCase(value))
            {
                case "title":
                    AddOnManager.AddOnList.AdvancedAddOns.SortInstalledAddOnsByName();
                    break;
                case "online":
                    AddOnManager.AddOnList.AdvancedAddOns.SortInstalledAddOnsByLatestOnlineVersion();
                    break;
                case "installed":
                    AddOnManager.AddOnList.AdvancedAddOns.SortInstalledAddOnsByLatestInstalledVersion();
                    break;
            }
            ListView1.Refresh();
        }

        private void ListView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            propselected = e.ItemIndex;
            SelectedInstallAddOn = AddOnManager.AddOnList.AdvancedAddOns.AddOnsInstalled.ElementAtOrDefault(e.ItemIndex);
            SelectedInstallAddOn2 = (AddOn2)AddOnManager.AddOnList.AdvancedAddOns.GetAddOn2ByName(SelectedInstallAddOn.Title);
            ToolStripButton2.Enabled = true;
            if (SelectedInstallAddOn2.LatestOnlineVersion > SelectedInstallAddOn.InstalledVersion)
            {
                ToolStripButton4.Enabled = true;
                UpdateToolStripMenuItem.Enabled = true;
            }
            else
            {
                ToolStripButton4.Enabled = false;
                UpdateToolStripMenuItem.Enabled = false;
            }
        }

        private void ListView1_RetrieveVirtualItem1(object sender, RetrieveVirtualItemEventArgs e)
        {
            try
            {
                AddOn addOn = AddOnManager.AddOnList.GetInstalledAddOns.ElementAtOrDefault(e.ItemIndex);
                AddOn2 addOn2 = (AddOn2)AddOnManager.AddOnList.AdvancedAddOns.GetAddOn2ByName(addOn.Title);
                AddOnInfo addOnInfo = addOn.AddOnInfo;
                string text = "Unknown";
                string text2 = "Unknown";
                string text3 = "";
                if (addOnInfo == null)
                {
                    addOnInfo = addOnInfo;
                }
                else
                {
                    text = addOnInfo.Author;
                    text2 = AddOnManager.AddOnList.GetAddOnName(addOnInfo.Title);
                    text3 = addOn.AddOnInfo.Tags;
                }
                ListViewItem listViewItem = new ListViewItem(text2);
                listViewItem.SubItems.Add(text);
                listViewItem.SubItems.Add(addOn.Version);
                if ((addOn2.LatestOnlineVersion > addOn2.LatestInstalledVersion) & MySettingsProperty.Settings.highlightoutofdateaddons)
                {
                    listViewItem.BackColor = MySettingsProperty.Settings.OutofDateAddOnColour;
                }
                if (!AddOnManager.AddOnList.IsManaged(addOn.Title) & MySettingsProperty.Settings.highlightunmanagedaddons)
                {
                    listViewItem.BackColor = MySettingsProperty.Settings.UnmanagedAddOnColour;
                    listViewItem.SubItems.Add("N/A");
                }
                else
                {
                    listViewItem.SubItems.Add(addOn2.LatestOnlineVersion.ToString());
                }
                listViewItem.SubItems.Add(text3);
                e.Item = listViewItem;
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                e.Item = new ListViewItem(ex2.ToString());
                ProjectData.ClearProjectError();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void InstallUnmanagedAddOnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyProject.Forms.frmInstallUnmanagedAddOn.ShowDialog();
        }

        private void ListView2_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            string value = ListView2.Columns[e.Column].Text;
            string left = Strings.LCase(value);
            if (Operators.CompareString(left, "title", TextCompare: false) == 0)
            {
                AddOnManager.AddOnList.SorttAvailibledAddOns();
                ListView2.Refresh();
            }
            ListView2.Refresh();
        }

        private void ListView2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
        }

        private void ListView2_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            installselected = e.ItemIndex;
            ToolStripButton1.Enabled = true;
        }

        private void ListView2_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            AddOn addOn = AddOnManager.AddOnList.GetAvailibleAddOns.ElementAtOrDefault(e.ItemIndex);
            AddOn2 addOn2 = AddOnManager.AddOnList.AdvancedAddOns.GetAddOnByTitle(addOn.DisplayName);
            ListViewItem listViewItem = new ListViewItem(addOn.DisplayName);
            AddOn getLatestOnlineVersion = addOn2.GetLatestOnlineVersion;
            Version latestInstalledVersion = addOn2.LatestInstalledVersion;
            listViewItem.SubItems.Add(getLatestOnlineVersion.VersionV.ToString());
            listViewItem.SubItems.Add(getLatestOnlineVersion.Downloads[0].URL);
            listViewItem.SubItems.Add(getLatestOnlineVersion.SizeS);
            if ((addOn2.LatestOnlineVersion > addOn2.LatestInstalledVersion) & MySettingsProperty.Settings.highlightoutofdateaddons & addOn2.IsInstalled)
            {
                listViewItem.BackColor = MySettingsProperty.Settings.OutofDateAddOnColour;
            }
            e.Item = listViewItem;
        }

        private void ListView2_SearchForVirtualItem(object sender, SearchForVirtualItemEventArgs e)
        {
        }

        private void ListView2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void HideInstalledAddOnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MySettingsProperty.Settings.HideInstalledAddOns)
            {
                MySettingsProperty.Settings.HideInstalledAddOns = false;
            }
            else
            {
                MySettingsProperty.Settings.HideInstalledAddOns = true;
            }
            MySettingsProperty.Settings.Save();
        }

        private void CheckForupdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateController1.UpdateInteractive();
        }

        private void StatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private InstallFileGeneratorTasks buildifgtListView2()
        {
            return InstallFileGeneratorTasks.CreateFromAddOnList(from object o in ListView2.SelectedIndices
                                                                 select Conversions.ToInteger(o) into o
                                                                 select AddOnManager.AddOnList.GetAvailibleAddOns.ElementAtOrDefault(o));
        }

        private InstallFileGeneratorTasks buildifgtUpdate()
        {
            InstallFileGeneratorTasks installFileGeneratorTasks = new InstallFileGeneratorTasks();
            string text = "Install the following Add-Ons:\r\n\r\n";
            InstallFileGeneratorTask installFileGeneratorTask = new InstallFileGeneratorTask();
            installFileGeneratorTask.TaskType = InstallFileGeneratorTaskType.Install;
            installFileGeneratorTask.AddOn = SelectedInstallAddOn2.GetLatestOnlineVersion;
            installFileGeneratorTasks.Tasks.Add(installFileGeneratorTask);
            return installFileGeneratorTasks;
        }

        private void installselectedaddon(InstallFileGeneratorTasks jjj)
        {
            frmConfirmInstall frmConfirmInstall2 = new frmConfirmInstall(jjj);
            DialogResult dialogResult = frmConfirmInstall2.ShowDialog(this);
            frmConfirmInstall2 = null;
            if (dialogResult != DialogResult.OK)
            {
                return;
            }
            if (!Directory.Exists(AOIPaths.TasksPath()))
            {
                Directory.CreateDirectory(AOIPaths.TasksPath());
            }
            string text = InstallFileGenerator.CreateJobFile(jjj, Path.Combine(AOIPaths.TasksPath(), Guid.NewGuid().ToString() + ".xml"));
            if (!UAC.IsUserAdmin())
            {
                AOIProcess = new Process();
                try
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo("AOI.exe", "\"" + text + "\" \"" + MySettingsProperty.Settings.L4D2InstallFolder + "\"");
                    AOIProcess.StartInfo = startInfo;
                    AOIProcess.StartInfo.UseShellExecute = true;
                    AOIProcess.Start();
                    pid = AOIProcess.Id;
                    Hide();
                    NotifyIcon1.ShowBalloonTip(50000, "Installing Add-On", "L4D2AOI is currently installing an add-on.", ToolTipIcon.Info);
                    while (Process.GetProcessById(pid) != null)
                    {
                        AOIActive = true;
                        Thread.Sleep(100);
                        MyProject.Application.DoEvents();
                    }
                    Show();
                    Interaction.AppActivate(Process.GetCurrentProcess().Id);
                    AOIActive = false;
                }
                catch (Exception ex)
                {
                    ProjectData.SetProjectError(ex);
                    Exception ex2 = ex;
                    Show();
                    Interaction.AppActivate(Process.GetCurrentProcess().Id);
                    AOIActive = false;
                    AOIProcess = null;
                    ProjectData.ClearProjectError();
                }
                AOIProcess = null;
            }
            else
            {
                Form1 form = new Form1(text, MySettingsProperty.Settings.L4D2InstallFolder);
                form.ShowDialog(this);
                form = null;
                GC.Collect();
            }
        }

        private void InstallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            installselectedaddon(buildifgtListView2());
        }

        private void UpdateAddonListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interaction.MsgBox("HERE GOES THE CODE TO DL UPDATED ADDON LIST FROM THE INTERWEB");
        }

        private void AboutL4DAOIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyProject.Forms.frmAbout.ShowDialog(this);
        }

        private void ListView3_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            installselected = e.ItemIndex;
        }

        private void ListView3_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            AddOn addOn = AddOnManager.AddOnList.AddOns[e.ItemIndex];
            ListViewItem listViewItem = new ListViewItem(addOn.Name);
            listViewItem.SubItems.Add(addOn.InstalledVersion.ToString());
            listViewItem.SubItems.Add(addOn.OnlineVersion.ToString());
            e.Item = listViewItem;
        }

        public void VLS(ref ListView l, int i)
        {
            if (l.InvokeRequired)
            {
                l.Invoke(new VLSDelegate(VLS), l, i);
            }
            else
            {
                l.VirtualListSize = i;
                l.Refresh();
            }
        }

        private void ListView3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void InstallUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void AddOnFeedsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyProject.Forms.frmAddOnFeedManager.ShowDialog(this);
            foreach (AddOn addOn in AddOnScanner.GetAddOnsFromXMLFile(Path.Combine(AOIPaths.FeedsPath(), "Cache.xml")).AddOns)
            {
                addOn.IsManaged = true;
                addOn.IsInstalled = false;
                AddOnManager.AddOnList.AddAddon(addOn);
            }
        }

        private void HideUnmanagedAddOnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MySettingsProperty.Settings.OnlyShowManagedAddOns = !MySettingsProperty.Settings.OnlyShowManagedAddOns;
            MySettingsProperty.Settings.Save();
            HideInstalledAddonsToolStripMenuItem.Checked = MySettingsProperty.Settings.OnlyShowManagedAddOns;
            AddOnManager_AddOnListChanged();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            installselectedaddon(buildifgtListView2());
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            AddOn addon = AddOnManager.AddOnList.AdvancedAddOns.AddOnsInstalled.ElementAtOrDefault(propselected);
            frmAddOnProperties frmAddOnProperties2 = new frmAddOnProperties(addon);
            frmAddOnProperties2.ShowDialog(this);
            frmAddOnProperties2 = null;
        }

        private void SendErrorLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void AppDataFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(AOIPaths.AppDataPath());
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
        }

        private void DownloadFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(AOIPaths.DownloadsPath());
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
        }

        private void FeedsFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(AOIPaths.FeedsPath());
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
        }

        private void LogFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(AOIPaths.LogPath());
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
        }

        private void TempFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(AOIPaths.TempDataPath());
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
        }

        public frmMain()
        {
            base.Resize += frmMain_Resize;
            base.Activated += frmMain_Activated;
            base.FormClosing += frmMain_FormClosing;
            base.Load += frmMain_Load;
            installselected = 0;
            propselected = 0;
            pid = -1;
            AOIProcess = null;
            SelectedInstallAddOn = null;
            SelectedInstallAddOn2 = null;
            br = new BannerRotator();
            ProtocolDispatcher = MyProject.Application.Protocol;
            AddOnManager = new AddOnManager();
            BrandingURL = "http://files.official-instructions.com/banners.xml";
            AOIActive = false;
            vpkcreatedpath = null;
            InitializeComponent();
        }

        private void BinnyButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("steam://run/550");
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
        }

        private void PropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOn addon = AddOnManager.AddOnList.AdvancedAddOns.AddOnsInstalled.ElementAtOrDefault(propselected);
            frmAddOnProperties frmAddOnProperties2 = new frmAddOnProperties(addon);
            frmAddOnProperties2.ShowDialog(this);
            frmAddOnProperties2 = null;
        }

        private void Left4Dead2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(MySettingsProperty.Settings.L4D2InstallFolder);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
        }

        private void RunLeft4Dead2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = "MM";
            text = ((!File.Exists(Path.Combine(MySettingsProperty.Settings.L4D2InstallFolder, "left4dead2\\pak02_000.vpk"))) ? "Oh Noes :/ Your as dumb as [SAO] Binny\r\nPlease open Steam and on the tools tab install the Left 4 Dead 2 Add-on Support Tool" : "Congratulations!!!\r\nYou sucessfully outsmarted [SAO] Binny by installing the Left 4 Dead 2 Add-on Support Tool");
            Interaction.MsgBox(text);
        }

        private void ContextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            if (ListView2.SelectedIndices.Count != 1)
            {
                HomepageToolStripMenuItem.Enabled = false;
                return;
            }
            AddOn addOn = AddOnManager.AddOnList.AdvancedAddOns.AddOnsAvailible(OnlyReturnLatestVersion: true).ElementAtOrDefault(installselected);
            if (Operators.CompareString(addOn.Homepage, null, TextCompare: false) != 0)
            {
                HomepageToolStripMenuItem.Enabled = true;
                HomepageToolStripMenuItem.Tag = addOn.Homepage;
            }
            else
            {
                HomepageToolStripMenuItem.Enabled = false;
            }
        }

        private void HomepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Type typeFromHandle = typeof(Process);
                object[] array = new object[1];
                ToolStripMenuItem homepageToolStripMenuItem = HomepageToolStripMenuItem;
                array[0] = RuntimeHelpers.GetObjectValue(homepageToolStripMenuItem.Tag);
                object[] array2 = array;
                bool[] array3 = new bool[1] { true };
                NewLateBinding.LateCall(null, typeFromHandle, "Start", array2, null, null, array3, IgnoreReturn: true);
                if (array3[0])
                {
                    homepageToolStripMenuItem.Tag = RuntimeHelpers.GetObjectValue(array2[0]);
                }
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
        }

        private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
        {
        }

        private void FileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
        }

        public void scannewaddon()
        {
            string vpkpath = vpkcreatedpath;
            Thread.Sleep(500);
            AddOnInfo ai = (AddOnInfo)Left4Dead2Functions.AddOnInfoFromVPK(vpkpath);
            lock (AddOnManager.AddOnList)
            {
                AddOnManager.AddOnList.AddAddon(AddOn.CreateAddOnFromAddOnInfo(ai));
            }
            ListView l = ListView1;
            VLS(ref l, AddOnManager.AddOnList.AdvancedAddOns.AddOnsInstalled.Count());
            ListView1 = (LVNF)l;
        }

        private void FileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            vpkcreatedpath = e.FullPath;
            Thread thread = new Thread(scannewaddon);
            thread.Start();
        }

        private void FileSystemWatcher1_Renamed(object sender, RenamedEventArgs e)
        {
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            ScanForAddOns();
            ListView1.VirtualListSize = AddOnManager.AddOnList.AdvancedAddOns.AddOnsInstalled.Count();
        }

        private void ApplicationFoldersToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!AOIActive)
            {
                Application.Exit();
            }
        }

        private void DownloadCacheManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyProject.Forms.frmDownloadCache.ShowDialog(this);
        }

        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            installselectedaddon(buildifgtUpdate());
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            installselectedaddon(buildifgtUpdate());
        }

        private void ToolStripButton1_Click_1(object sender, EventArgs e)
        {
            installselectedaddon(buildifgtListView2());
        }

        private void ToolStripButton4_Click_1(object sender, EventArgs e)
        {
            installselectedaddon(buildifgtUpdate());
        }

        private void ToolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {
            UpdateController1.UpdateInteractive();
        }

        private void BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SplitContainer1.Panel2Collapsed = !SplitContainer1.Panel2Collapsed;
        }

        private void BToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SplitContainer1.Panel2Collapsed = !SplitContainer1.Panel2Collapsed;
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            PictureBox2.Left = checked((int)Math.Round((double)(Width - PictureBox2.Width) / 2.0));
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(br._Banners[br.bannerindex]._LinkURL);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
        }

        private void HomePageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("http://bans.official-instructions.com");
        }

        private void ForumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://bans.official-instructions.com");
        }

        private void NewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://bans.official-instructions.com");
        }

        private void br_OnNextImage()
        {
            PictureBox PictureBox = PictureBox2;
            Stream ImageData = br._Banners[br.bannerindex].ImageStream;
            changebanner(ref PictureBox, ref ImageData);
            PictureBox2 = PictureBox;
        }

        private void changebanner(ref PictureBox PictureBox, ref Stream ImageData)
        {
            try
            {
                if (PictureBox.InvokeRequired)
                {
                    PictureBox.Invoke(new BannerRotator.SetPictureBoxImage(changebanner), PictureBox, ImageData);
                    return;
                }
                if (PictureBox.Image != null)
                {
                    PictureBox.Image.Dispose();
                }
                try
                {
                    // PictureBox.Image = Image.FromStream(ImageData);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                GC.Collect();
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
        }

        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void NotifyIcon1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void ToolStripButton2_Click_1(object sender, EventArgs e)
        {
            AddOn addon = AddOnManager.AddOnList.AdvancedAddOns.AddOnsInstalled.ElementAtOrDefault(propselected);
            frmAddOnProperties frmAddOnProperties2 = new frmAddOnProperties(addon);
            frmAddOnProperties2.ShowDialog(this);
            frmAddOnProperties2 = null;
        }

        private void AddOnManager_AddOnListChanged()
        {
            ListView l = ListView1;
            VLS(ref l, AddOnManager.AddOnList.GetInstalledAddOns.Count());
            ListView1 = (LVNF)l;
            l = ListView2;
            VLS(ref l, AddOnManager.AddOnList.GetAvailibleAddOns.Count());
            ListView2 = (LVNF)l;
        }

        private void RegisterProtocolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("Protocol.exe");
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
        }

        private void ProtocolDispatcher_ProtocolMessageDispatch(string p)
        {
            string expression = Strings.LCase(Strings.Replace(Strings.LCase(p), "-protocol=l4d2aoi://", ""));
            string[] source = Strings.Split(expression, "/");
            try
            {
                string left = source.First();
                if (Operators.CompareString(left, "update", TextCompare: false) == 0)
                {
                    UpdateController1.UpdateInteractive();
                }
                else if (Operators.CompareString(left, "installurl", TextCompare: false) == 0)
                {
                    string uRL = Strings.Replace(expression, "installurl/", "");
                    Activate();
                    installurl(uRL);
                }
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                Exception ex2 = ex;
                ProjectData.ClearProjectError();
            }
        }

        public void installurl(string URL)
        {
            InstallFileGeneratorTasks installFileGeneratorTasks = new InstallFileGeneratorTasks();
            InstallFileGeneratorTask installFileGeneratorTask = new InstallFileGeneratorTask();
            installFileGeneratorTask.TaskType = InstallFileGeneratorTaskType.Install;
            AddOn addOn = new AddOn(URL);
            addOn.Downloads.Add(new AddOnDownload(URL));
            installFileGeneratorTask.AddOn = addOn;
            installFileGeneratorTasks.Tasks.Add(installFileGeneratorTask);
            installselectedaddon(installFileGeneratorTasks);
        }

        private void AddOnManager_FeedCacheComplete()
        {
            ListView lv = ListView2;
            ControlDelegates.RefreshListView(ref lv);
            ListView2 = (LVNF)lv;
        }

        private void AddOnManager_FeedCacheStarted()
        {
        }

        private void AddOnManager_NewAddOnDetected(string name)
        {
            NotifyIcon1.ShowBalloonTip(5000, "New AddOn Detected", "Found new addon: " + name, ToolTipIcon.Info);
        }

        private void OutlookBar1_Load(object sender, EventArgs e)
        {
        }

        private void AddOnFeedsReCacheNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOnManager.FTC();
        }
    }
}
