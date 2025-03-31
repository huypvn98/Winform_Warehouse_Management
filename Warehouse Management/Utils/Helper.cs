using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse_Management.Properties;

namespace Warehouse_Management.Utils
{
    public class Helper
    {
        public static int NumberDigits = 2;

        public static string NumberDigitFormat = "N" + NumberDigits;

        public static int NumberDigits_Cuon = 2;

        public static string NumberDigitFormat_Cuon = "N" + NumberDigits_Cuon;

        public static int QtyDigits = 0;

        public static string QtyDigitFormat = "N" + QtyDigits;

        public static Font FontColumnHeaders = new Font("Arial", 8f, FontStyle.Bold);

        private static byte mOrgTypeSanXuat = 0;

        private static byte mOrgTypeNVL = 3;

        public static string ConvertDouble(double? val)
        {
            if (!val.HasValue)
            {
                return null;
            }
            return val.Value.ToString(NumberDigitFormat);
        }
        public static SecureString ToSecureString(string input)
        {
            SecureString secureString = new SecureString();
            int length = input.Length;
            char[] array = input.ToCharArray(0, length);
            foreach (char c in array)
            {
                secureString.AppendChar(c);
            }
            return secureString;
        }

        public static string ToString(SecureString value)
        {
            IntPtr intPtr = IntPtr.Zero;
            try
            {
                intPtr = Marshal.SecureStringToGlobalAllocUnicode(value);
                return Marshal.PtrToStringUni(intPtr);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(intPtr);
            }
        }

        public static string EscapeDataString(string str)
        {
            if (str == null)
            {
                return null;
            }
            return Uri.EscapeDataString(str);
        }

        public static Control FindFocusedControl(Control control)
        {
            for (IContainerControl containerControl = control as IContainerControl; containerControl != null; containerControl = control as IContainerControl)
            {
                control = containerControl.ActiveControl;
            }
            return control;
        }
        public static bool IsTamLuoi(string unit)
        {
            if (!CompareUpper(unit, "KG"))
            {
                return true;
            }
            return false;
        }

        public static bool CompareUpper(string s1, string s2)
        {
            return s1?.ToUpper() == s2?.ToUpper();
        }

        public static double RoundDouble_Cuon(double val)
        {
            return Math.Round(val, NumberDigits_Cuon);
        }

        public static double RoundDouble(double val)
        {
            return Math.Round(val, NumberDigits);
        }

        public static bool ExceptionLog(Exception ex)
        {
            if (ex == null || ex.InnerException == null)
            {
                return true;
            }
            WebException ex2 = ex.InnerException as WebException;
            if (ex2 == null && ex.InnerException != null)
            {
                ex2 = ex.InnerException.InnerException as WebException;
            }
            if (ex2 != null && (ex2.Status == WebExceptionStatus.NameResolutionFailure || ex2.Status == WebExceptionStatus.ConnectFailure))
            {
                ShowNotifyIcon(Resources.NoInternetConnection);
                return false;
            }
            try
            {
                string text = ex.ToString();
                string path = AppDomain.CurrentDomain.BaseDirectory + "\\error.log";
                if (!File.Exists(path))
                {
                    File.Create(path).Dispose();
                }
                text = "--- " + DateTime.Now.ToString("yyyy/MM/dd HH:mm") + " ---------------------------------------------------\n" + text;
                File.AppendAllText(path, text + Environment.NewLine + Environment.NewLine);
            }
            catch (Exception)
            {
            }
            return true;
        }
        public static void ShowNotifyIcon(string tipText, int timeout = 300, ToolTipIcon tipIcon = ToolTipIcon.Warning)
        {
            if (string.IsNullOrWhiteSpace(tipText))
            {
                return;
            }

            using (NotifyIcon notifyIcon = new NotifyIcon())
            {
                notifyIcon.Icon = Resources.siam_icon;
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(timeout, Resources.InfoTitle_Caption, tipText, tipIcon);
            }
        }

        public static EANType GetEANType(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                return EANType.EC;
            }
            if (code.ToUpper() == "EC")
            {
                return EANType.EC;
            }
            return EANType.KFS;
        }

        public static bool IsMet(string unit)
        {
            if (CompareUpper(unit, "M") || CompareUpper(unit, "MET"))
            {
                return true;
            }
            return false;
        }

        public static string ConvertInt(int? val)
        {
            if (!val.HasValue)
            {
                return null;
            }
            return val.Value.ToString("N0");
        }
        public static string ConvertDouble_Cuon(double? val)
        {
            if (!val.HasValue)
            {
                return null;
            }
            return val.Value.ToString(NumberDigitFormat_Cuon);
        }

    }
}
