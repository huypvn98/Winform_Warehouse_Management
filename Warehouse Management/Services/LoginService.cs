using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Warehouse_Management.Models;
using Warehouse_Management.Utils;

namespace Warehouse_Management.Services
{
    public class LoginService : ServiceBase
    {
        private string client_id = "desktopApp";

        public bool? Login(string username, string password)
        {
            GlobalSetting.IsLogged = false;
            List<KeyValuePair<string, string>> postData = new List<KeyValuePair<string, string>>
                                                              {
                                                                  new KeyValuePair<string, string>("grant_type", "password"),
                                                                  new KeyValuePair<string, string>("client_id", client_id),
                                                                  new KeyValuePair<string, string>("username", username),
                                                                  new KeyValuePair<string, string>("password", password)
                                                              };
            return Task.Run(async () => await _Login(postData, password)).Result;
        }
        private async Task<bool?> _Login(List<KeyValuePair<string, string>> postData, string pwd)
        {
            string requestUri = "token";
            try
            {
                using (HttpClient client = CreateHttpClient())
                {
                    FormUrlEncodedContent content = new FormUrlEncodedContent(postData);
                    HttpResponseMessage httpResponseMessage = await client.PostAsync(requestUri, content);
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        dynamic val = JsonConvert.DeserializeObject(await httpResponseMessage.Content.ReadAsStringAsync());
                        GlobalSetting.AccessToken = val.access_token;
                        GlobalSetting.Username = val.userName;
                        if (pwd != null)
                        {
                            GlobalSetting.Password = Helper.ToSecureString(pwd);
                        }
                        GlobalSetting.RefreshToken = val.refresh_token;
                        GlobalSetting.IsLogged = true;
                        bool flag = val.isAdmin;
                        GlobalSetting.IsAdmin = GlobalSetting.Username?.ToLower() == "admin" || flag;
                        GlobalSetting.IsInternal = val.isInternal;
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                //if (!Helper.ExceptionLog(ex))
                //{
                //    return null;
                //}
            }
            return false;
        }
        public bool? RefreshToken()
        {
            GlobalSetting.IsLogged = false;
            List<KeyValuePair<string, string>> postData = SetPostData(GlobalSetting.RefreshToken);
            return Task.Run(async () => await _Login(postData, null)).Result;
        }

        private List<KeyValuePair<string, string>> SetPostData(string refreshtoken)
        {
            return new List<KeyValuePair<string, string>>
                        {
                            new KeyValuePair<string, string>("refresh_token", refreshtoken),
                            new KeyValuePair<string, string>("grant_type", "refresh_token"),
                            new KeyValuePair<string, string>("client_id", client_id)
                        };
        }

        public List<PermissionUser> GetPermission(string featureCode = null)
        {
            string uri = "api/account/getpermission2?userName=" + Helper.EscapeDataString(GlobalSetting.Username) + "&featureCode=" + Helper.EscapeDataString(featureCode);
            return Task.Run(async () => await Get<List<PermissionUser>>(uri)).Result;
        }
    }
}
