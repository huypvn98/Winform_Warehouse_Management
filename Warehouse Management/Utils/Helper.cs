using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Warehouse_Management.Properties;

namespace Warehouse_Management.Utils
{
    public class Helper
    {
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

        //public static bool ExceptionLog(Exception ex)
        //{
        //    if (ex == null || ex.InnerException == null)
        //    {
        //        return true;
        //    }
        //    WebException ex2 = ex.InnerException as WebException;
        //    if (ex2 == null && ex.InnerException != null)
        //    {
        //        ex2 = ex.InnerException.InnerException as WebException;
        //    }
        //    if (ex2 != null && (ex2.Status == WebExceptionStatus.NameResolutionFailure || ex2.Status == WebExceptionStatus.ConnectFailure))
        //    {
        //        ShowNotifyIcon(Resources.NoInternetConnection);
        //        return false;
        //    }
        //    try
        //    {
        //        string text = ex.ToString();
        //        string path = AppDomain.CurrentDomain.BaseDirectory + "\\error.log";
        //        if (!File.Exists(path))
        //        {
        //            File.Create(path).Dispose();
        //        }
        //        text = "--- " + DateTime.Now.ToString("yyyy/MM/dd HH:mm") + " ---------------------------------------------------\n" + text;
        //        File.AppendAllText(path, text + Environment.NewLine + Environment.NewLine);
        //    }
        //    catch (Exception)
        //    {
        //    }
        //    return true;
        //}
    }
}
