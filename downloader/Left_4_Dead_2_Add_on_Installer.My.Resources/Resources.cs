using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Left_4_Dead_2_Add_on_Installer.My.Resources
{
    [StandardModule]
    [CompilerGenerated]
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [HideModuleName]
    [DebuggerNonUserCode]
    internal sealed class Resources
    {
        private static ResourceManager resourceMan;

        private static CultureInfo resourceCulture;

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    ResourceManager resourceManager = (resourceMan = new ResourceManager("Left_4_Dead_2_Add_on_Installer.Resources", typeof(Resources).Assembly));
                }
                return resourceMan;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        internal static Bitmap info
        {
            get
            {
                object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("info", resourceCulture));
                return (Bitmap)objectValue;
            }
        }

        internal static Bitmap Properties_32x32
        {
            get
            {
                object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Properties_32x32", resourceCulture));
                return (Bitmap)objectValue;
            }
        }
    }
}
