using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace WindowsOOBERecreation.Properties
{
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [DebuggerNonUserCode]
    [CompilerGenerated]
    internal class Resources
    {
        internal Resources()
        {
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager
        {
            get
            {
                if (Resources.resourceMan == null)
                {
                    Resources.resourceMan = new ResourceManager("WindowsOOBERecreation.Properties.Resources", typeof(Resources).Assembly);
                }
                return Resources.resourceMan;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            get
            {
                return Resources.resourceCulture;
            }
            set
            {
                Resources.resourceCulture = value;
            }
        }

        internal static Bitmap _1024768
        {
            get
            {
                return (Bitmap)Resources.ResourceManager.GetObject("1024768", Resources.resourceCulture);
            }
        }

        internal static Bitmap _12801024
        {
            get
            {
                return (Bitmap)Resources.ResourceManager.GetObject("12801024", Resources.resourceCulture);
            }
        }

        internal static Bitmap _16001200
        {
            get
            {
                return (Bitmap)Resources.ResourceManager.GetObject("16001200", Resources.resourceCulture);
            }
        }

        internal static Bitmap _19201200
        {
            get
            {
                return (Bitmap)Resources.ResourceManager.GetObject("19201200", Resources.resourceCulture);
            }
        }

        internal static Bitmap _7681280
        {
            get
            {
                return (Bitmap)Resources.ResourceManager.GetObject("7681280", Resources.resourceCulture);
            }
        }

        internal static byte[] backallowed
        {
            get
            {
                return (byte[])Resources.ResourceManager.GetObject("backallowed", Resources.resourceCulture);
            }
        }

        internal static byte[] backhovered
        {
            get
            {
                return (byte[])Resources.ResourceManager.GetObject("backhovered", Resources.resourceCulture);
            }
        }

        internal static byte[] backnotallowed
        {
            get
            {
                return (byte[])Resources.ResourceManager.GetObject("backnotallowed", Resources.resourceCulture);
            }
        }

        internal static byte[] backpressed
        {
            get
            {
                return (byte[])Resources.ResourceManager.GetObject("backpressed", Resources.resourceCulture);
            }
        }

        internal static Bitmap branding
        {
            get
            {
                return (Bitmap)Resources.ResourceManager.GetObject("branding", Resources.resourceCulture);
            }
        }

        internal static Bitmap image
        {
            get
            {
                return (Bitmap)Resources.ResourceManager.GetObject("image", Resources.resourceCulture);
            }
        }

        internal static string password
        {
            get
            {
                return Resources.ResourceManager.GetString("password", Resources.resourceCulture);
            }
        }

        internal static string username
        {
            get
            {
                return Resources.ResourceManager.GetString("username", Resources.resourceCulture);
            }
        }

        internal static Bitmap wysi_icon_10
        {
            get
            {
                return (Bitmap)Resources.ResourceManager.GetObject("wysi_icon-10", Resources.resourceCulture);
            }
        }

        private static ResourceManager resourceMan;

        private static CultureInfo resourceCulture;
    }
}
