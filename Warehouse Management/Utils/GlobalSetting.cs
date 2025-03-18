using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Warehouse_Management.Models;

namespace Warehouse_Management.Utils
{
    internal class GlobalSetting
    {
        public const string Config_DomainAPI = "DomainAPI";

        public const string Config_IsWorkOrderScreen = "IsWorkOrderScreen";

        public const string Config_Validation = "Validation";

        public const string Config_KindOfWeighing = "KindOfWeighing";

        public const string Config_ScannerSOPort = "ScannerSO.Port";

        public const string Config_WeighingKienPort = "WeighingKien.Port";

        public const string Config_WeighingStable = "WeighingStable";

        public const string Config_PrintAuto = "PrintAuto";

        public const string Config_PrinterKien = "PrinterKien";

        public const string Config_PrinterCuon = "PrinterCuon";

        public const string Config_WorkOrderAutoSave = "WorkOrderAutoSave";

        public const string Config_Weighing_AutoSearchingPort = "Weighing.AutoSearchingPort";

        public const string Config_WO_Org = "WO.Org";

        public const string Config_SO_Org = "SO.Org";

        public const string Config_Warehouse = "WarehouseCode";

        public const string Config_SOSubmitWarning2 = "SOSubmitWarning2";

        public const string Config_InitZebraScanner = "InitZebraScanner";

        public const string Config_GiaoHang_TenCty = "GiaoHang_TenCty";

        public const string Config_AutoSavePrintCuon = "AutoSavePrintCuon";

        public const string Config_UseLabel100x60 = "UseLabel100x60";

        public const string Folder_Fonts = "Fonts";

        public const string Folder_Update = "Update";

        public static Color ColorErrorRow = Color.FromArgb(255, 62, 62);

        public static Color ColorNormalRow = Color.FromArgb(0, 0, 0);

        public static Color ColorSelectedRow = Color.FromArgb(255, 255, 255);

        public static Color ColorHighlightRow = SystemColors.Highlight;

        public static Brush BrushHeading1Clm = new SolidBrush(Color.SteelBlue);

        public static Brush BrushHeading2LeftClm = new SolidBrush(Color.FromArgb(90, 113, 55));

        public static Brush BrushHeading2RightClm = new SolidBrush(Color.FromArgb(113, 141, 64));

        public static Color ColorClosedRow = SystemColors.Highlight;

        public static Color ColorCancelledRow = Color.Firebrick;

        private static bool _ValidationWO;

        public static bool IsLogged { get; set; }

        public static string Username { get; set; }

        public static SecureString Password { get; set; }

        public static string FactoryName { get; set; }

        public static string AccessToken { get; set; }

        public static string RefreshToken { get; set; }

        public static List<FACTORY> Factories { get; set; }

        public static List<ORGANIZATION> Organizations { get; set; }

        public static List<ORGANIZATION> ToOrganizations { get; set; }

        public static List<ORGANIZATION> AllOrganizations { get; set; }

        public static List<ORGANIZATION> AllOrgsForPrint { get; set; }

        public static List<Warehouse> Warehouses { get; set; }

        public static List<Warehouse> WarehouseMaterials { get; set; }

        public static List<Warehouse> AllWarehouses { get; set; }

        //public static KindOfScreens CurrentScreen { get; set; }

        public static string FolderSaveError { get; set; }

        public static string FolderImportExport { get; set; }

        public static string Operator { get; set; }

        public static bool IsInternal { get; set; }

        public static bool IsAdmin { get; set; }

        public static bool IsAdminName => Username?.ToLower() == "admin";

        public static List<PermissionUser> Permissions { get; set; }

        public static PrintLabelTemplate PrintLabelTemplate { get; set; }

        //public static Rectangle PrintLabelNhapHH
        //{
        //    get
        //    {
        //        if (PrintLabelTemplate != null)
        //        {
        //            return new Rectangle(0, 0, PrintLabelTemplate.WidthLabel, PrintLabelTemplate.HeightLabel);
        //        }
        //        return new Rectangle(0, 0, 412, 225);
        //    }
        //}

        public static Rectangle PrintLabel100x60 => new Rectangle(0, 0, 377, 226);

        public static Rectangle PrintLabelInnerOuter => new Rectangle(0, 0, 188, 56);

        public static bool IsWorkOrderScreen { get; private set; }

        public static bool ValidationWO
        {
            get
            {
                if (IsAdmin)
                {
                    return _ValidationWO;
                }
                return true;
            }
            set
            {
                _ValidationWO = value;
            }
        }

        public static int KindOfWeighing { get; private set; }

        public static string ScannerSOPort { get; private set; }

        public static string WeighingKienPort { get; internal set; }

        public static bool WeighingStable { get; private set; }

        public static bool PrintAuto { get; private set; }

        public static string PrinterKien { get; private set; }

        public static string PrinterCuon { get; private set; }

        public static bool WorkOrderAutoSave { get; private set; }

        public static bool Weighing_AutoSearchingPort { get; private set; }

        public static string WO_Org { get; internal set; }

        public static string SO_Org { get; internal set; }

        public static string WarehouseCode { get; internal set; }

        public static bool SOSubmitWarning2 { get; internal set; }

        public static bool InitZebraScanner { get; internal set; }

        public static string GiaoHang_TenCty { get; internal set; }

        public static bool AutoSavePrintCuon { get; internal set; }

        public static bool UsePrintLabel100x60 { get; internal set; }

        //public static void SetLogout()
        //{
        //    AccessToken = (RefreshToken = null);
        //    IsLogged = false;
        //    Password = null;
        //    Permissions = null;
        //}

        public static void GetConfig()
        {
            IsWorkOrderScreen = bool.Parse(ConfigurationManager.AppSettings["IsWorkOrderScreen"]);
            ValidationWO = bool.Parse(ConfigurationManager.AppSettings["Validation"]);
            KindOfWeighing = int.Parse(ConfigurationManager.AppSettings["KindOfWeighing"]);
            ScannerSOPort = ConfigurationManager.AppSettings["ScannerSO.Port"];
            WeighingKienPort = ConfigurationManager.AppSettings["WeighingKien.Port"];
            WeighingStable = bool.Parse(ConfigurationManager.AppSettings["WeighingStable"]);
            PrintAuto = bool.Parse(ConfigurationManager.AppSettings["PrintAuto"]);
            PrinterKien = ConfigurationManager.AppSettings["PrinterKien"];
            PrinterCuon = ConfigurationManager.AppSettings["PrinterCuon"];
            WorkOrderAutoSave = bool.Parse(ConfigurationManager.AppSettings["WorkOrderAutoSave"]);
            try
            {
                Weighing_AutoSearchingPort = bool.Parse(ConfigurationManager.AppSettings["Weighing.AutoSearchingPort"]);
            }
            catch
            {
                Weighing_AutoSearchingPort = false;
            }
            try
            {
                WO_Org = ConfigurationManager.AppSettings["WO.Org"];
                SO_Org = ConfigurationManager.AppSettings["SO.Org"];
                WarehouseCode = ConfigurationManager.AppSettings["WarehouseCode"];
            }
            catch
            {
            }
            try
            {
                SOSubmitWarning2 = bool.Parse(ConfigurationManager.AppSettings["SOSubmitWarning2"]);
            }
            catch
            {
                SOSubmitWarning2 = true;
            }
            try
            {
                InitZebraScanner = bool.Parse(ConfigurationManager.AppSettings["InitZebraScanner"]);
            }
            catch
            {
                InitZebraScanner = true;
            }
            try
            {
                GiaoHang_TenCty = ConfigurationManager.AppSettings["GiaoHang_TenCty"];
            }
            catch
            {
                GiaoHang_TenCty = "SIAM TRADING (CTDH2)";
            }
            try
            {
                AutoSavePrintCuon = bool.Parse(ConfigurationManager.AppSettings["AutoSavePrintCuon"]);
            }
            catch
            {
                AutoSavePrintCuon = true;
            }
            try
            {
                UsePrintLabel100x60 = bool.Parse(ConfigurationManager.AppSettings["UseLabel100x60"]);
            }
            catch
            {
                UsePrintLabel100x60 = false;
            }
        }
    }
}
