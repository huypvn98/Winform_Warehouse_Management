using System;
using System.Configuration;
using System.Net.Http.Headers;
using System.Net.Http;
using Warehouse_Management.Utils;
using System.Threading.Tasks;
using System.Net;
using Warehouse_Management.Models;
using System.Windows.Forms;
using Warehouse_Management.Properties;

namespace Warehouse_Management.Services
{
    public abstract class ServiceBase
    {
        private string _domain = ConfigurationManager.AppSettings["DomainAPI"];

        /// <summary>
        /// Creates an instance of HttpClient with the base address and default request headers.
        /// </summary>
        /// <returns>The created HttpClient instance.</returns>
        protected HttpClient CreateHttpClient()
        {
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(_domain);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.Timeout = TimeSpan.FromSeconds(300.0);
            if (!string.IsNullOrEmpty(GlobalSetting.AccessToken))
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", "bearer " + GlobalSetting.AccessToken);
            }
            return httpClient;
        }

        protected async Task<T> Get<T>(string uri)
        {
            _ = 1;
            try
            {
                IsExpiredToken().Wait();
                using (HttpClient client = CreateHttpClient())
                {
                    HttpResponseMessage httpResponseMessage = await client.GetAsync(uri);
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        return await httpResponseMessage.Content.ReadAsAsync<T>();
                    }
                }
            }
            catch (Exception ex)
            {
                //if (!Helper.ExceptionLog(ex))
                //{
                //    return default(T);
                //}
            }
            return default(T);
        }

        private async Task<bool> IsExpiredToken()
        {
            LoginService loginService = new LoginService();
            using (HttpClient client = CreateHttpClient())
            {
                if ((await client.GetAsync("api/RefreshTokens")).StatusCode == HttpStatusCode.Unauthorized)
                {
                    loginService.RefreshToken();
                }
            }
            if (!GlobalSetting.IsLogged)
            {
                loginService.Login(GlobalSetting.Username, Helper.ToString(GlobalSetting.Password));
            }
            return false;
        }

        protected async Task<Response<T>> GetResp<T>(string uri, bool addToken = true)
        {
            _ = 1;
            try
            {
                if (addToken)
                {
                    IsExpiredToken().Wait();
                }
                using (HttpClient client = CreateHttpClient())
                {
                    return await ConvertResponse<T>(await client.GetAsync(uri));
                }
            }
            catch (Exception ex)
            {
                //if (!Helper.ExceptionLog(ex))
                //{
                //    return null;
                //}
            }
            return null;
        }

        private async Task<Response<T>> ConvertResponse<T>(HttpResponseMessage response)
        {
            Response<T> response2;
            if (response.IsSuccessStatusCode)
            {
                response2 = new Response<T>
                {
                    StatusCode = (int)response.StatusCode
                };
                Response<T> response3 = response2;
                response3.Data = await response.Content.ReadAsAsync<T>();
                return response2;
            }
            if (response.StatusCode == HttpStatusCode.InternalServerError)
            {
                //Helper.ShowNotifyIcon(Resources.CommonError, 300, ToolTipIcon.Error);
                //return null;
            }
            response2 = new Response<T>
            {
                StatusCode = (int)response.StatusCode
            };
            response2.Message = (await response.Content.ReadAsAsync<ErrorResponse>())?.Message;
            return response2;
        }

        protected async Task<T> Post<T, K>(string uri, K obj)
        {
            _ = 1;
            try
            {
                IsExpiredToken().Wait();
                using (HttpClient client = CreateHttpClient())
                {
                    HttpResponseMessage httpResponseMessage = await client.PostAsJsonAsync(uri, obj);
                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        return await httpResponseMessage.Content.ReadAsAsync<T>();
                    }
                }    

            }
            catch (Exception ex)
            {
                if (!Helper.ExceptionLog(ex))
                {
                    return default(T);
                }
            }
            return default(T);
        }
        protected async Task<Response<T>> PostResp<T, K>(string uri, K obj)
        {
            _ = 1;
            try
            {
                IsExpiredToken().Wait();
                using (HttpClient client = CreateHttpClient())
                {
                    return await ConvertResponse<T>(await client.PostAsJsonAsync(uri, obj));
                }
            }
            catch (Exception ex)
            {
                if (!Helper.ExceptionLog(ex))
                {
                    return null;
                }
            }
            return null;
        }

    }
}
