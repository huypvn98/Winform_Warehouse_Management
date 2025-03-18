using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse_Management.Models;
using Warehouse_Management.Services;
using Warehouse_Management.Utils;

namespace Warehouse_Management.Views
{
    public partial class LoginView : Form
    {
        private LoginService _loginService = new LoginService();
        private string _configUsername = "Username";
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!CanLogin())
            {
                return;
            }
            bool? flag = _loginService.Login(tbUsername.Text.Trim(), tbPassword.Text);
            if (flag == false)
            {
                //Helper.ShowNotifyIcon("Tên đăng nhâ\u0323p hoă\u0323c mâ\u0323t khâ\u0309u không chi\u0301nh xa\u0301c.");
                tbPassword.Focus();
                return;
            }
            if (flag == true)
            {
                FactoryService factoryService = new FactoryService();
                GlobalSetting.Factories = factoryService.GetFactory();
                Response<OrgResp> organization = factoryService.GetOrganization();
                if (organization != null && organization.IsSuccessful)
                {
                    GlobalSetting.Organizations = organization.Data.FromOrgs;
                    GlobalSetting.ToOrganizations = organization.Data.ToOrgs;
                    GlobalSetting.AllOrganizations = organization.Data.AllOrgs;
                }
                GlobalSetting.AllOrgsForPrint = factoryService.GetAllOrgsForPrint();
                WarehouseService warehouseService = new WarehouseService();
                GlobalSetting.Warehouses = warehouseService.GetWarehouse();
                GlobalSetting.WarehouseMaterials = warehouseService.GetWarehouseMaterial();
                GlobalSetting.AllWarehouses = warehouseService.GetAllWarehouses();
                ORGANIZATION org = GlobalSetting.AllOrganizations?.FirstOrDefault();
                if (org != null)
                {
                    FACTORY fACTORY = GlobalSetting.Factories?.Where((FACTORY s) => s.Code == org.MaNhaMay).FirstOrDefault();
                    if (fACTORY != null)
                    {
                        GlobalSetting.FactoryName = fACTORY.FactoryName;
                    }
                }
                GlobalSetting.Permissions = _loginService.GetPermission();
                Response<PrintLabelTemplate> printLabelTemplate = new VoucherService().GetPrintLabelTemplate();
                if (printLabelTemplate != null)
                {
                    if (printLabelTemplate.IsSuccessful)
                    {
                        GlobalSetting.PrintLabelTemplate = printLabelTemplate.Data;
                    }
                    else if (!string.IsNullOrWhiteSpace(printLabelTemplate.Message))
                    {
                        //Helper.ShowNotifyIcon(printLabelTemplate.Message);
                    }
                }
                try
                {
                    Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    KeyValueConfigurationCollection settings = configuration.AppSettings.Settings;
                    if (settings[_configUsername].Value != tbUsername.Text.Trim())
                    {
                        settings[_configUsername].Value = tbUsername.Text.Trim();
                        configuration.Save(ConfigurationSaveMode.Modified);
                        ConfigurationManager.RefreshSection(configuration.AppSettings.SectionInformation.Name);
                    }
                }
                catch (Exception)
                {
                }
                Close();
            }
        }

        private bool CanLogin()
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                //Helper.ShowNotifyIcon("Bạn cần nhập Tên đăng nhập.");
                tbUsername.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                //Helper.ShowNotifyIcon("Bạn cần nhập Mật khẩu.");
                tbUsername.Focus();
                return false;
            }
            return true;
        }

    }
}
