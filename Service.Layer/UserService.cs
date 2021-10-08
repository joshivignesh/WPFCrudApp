using Data.Access.Layer;
using Newtonsoft.Json.Linq;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;


namespace Service.Layer
{
    /// <summary>
    /// Service calls to API using httpClient request and response
    /// </summary>
    public class UserService : IUserService
    {
        #region Private variables
        private readonly HttpClient httpClient = new HttpClient();
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        #endregion

        #region Public method

        public void Init()
        {
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.BaseAddress = new Uri("https://gorest.co.in/public-api/");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string accessToken = "fa114107311259f5f33e70a5d85de34a2499b4401da069af0b1d835cd5ec0d56";
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            //httpClient.DefaultRequestHeaders.Add("Authorization", string.Format("Bearer {0}", accessToken));
        }

        #endregion

        #region Public async method

        public async Task<HttpResponseMessage> onCreate(UserModel para)
        {
            HttpResponseMessage httpResponse = new HttpResponseMessage();
            try
            {
                UserServiceIns user = new UserServiceIns
                {
                    name = para.Name,
                    email = para.Email,
                    gender = para.Gender,
                    status = para.Status
                };
                httpResponse = await httpClient.PostAsJsonAsync($"users", user);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error occured in onCreate method in service layer");
            }
            return httpResponse;
        }

        public async Task<HttpResponseMessage> onUpdate(UserModel para)
        {
            HttpResponseMessage httpResponse = new HttpResponseMessage();
            try
            {
                UserServiceIns user = new UserServiceIns
                {
                    id = para.Id,
                    name = para.Name,
                    gender = para.Gender,
                    email = para.Email,
                    status = para.Status
                };
                httpResponse = await httpClient.PutAsJsonAsync($"users/{user.id}", user);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error occured in onUpdate method in service layer");
            }
            return httpResponse;
        }

        public async Task<HttpResponseMessage> onDelete(int user)
        {
            HttpResponseMessage httpResponse = new HttpResponseMessage();
            try
            {
                httpResponse = await httpClient.DeleteAsync($"users/{user}");
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error occured in onDelete method in service layer");
            }
            return httpResponse;
        }

        public async Task<User> onGetUserById(int id)
        {
            var response = await httpClient.GetStringAsync("users");
            User searchResults = new User();
            try
            {
                JObject Search = JObject.Parse(response);
                IList<JToken> results = Search["data"].Children().ToList();

                foreach (JToken result in results)
                {
                    User searchResult = result.ToObject<User>();
                    //searchResults.Add(searchResult);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error occured in onGetUserById method in service layer");
            }
            return searchResults;
        }

        public async Task<IList<User>> onGetUserByName(string name)
        {
            var response = await httpClient.GetStringAsync($"users?name={name}");
            IList<User> searchResults = new List<User>();
            try
            {
                JObject Search = JObject.Parse(response);
                IList<JToken> results = Search["data"].Children().ToList();

                if (results.Count > 0)
                {
                    foreach (JToken result in results)
                    {
                        User searchResult = result.ToObject<User>();
                        searchResults.Add(searchResult);
                    }
                }           
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error occured in onGetUserByName method in service layer");
            }
            return searchResults;
        }

        public async Task<IList<User>> onGetUsers()
        {
            var response = await httpClient.GetStringAsync("users");
            IList<User> searchResults = new List<User>();
            try
            {
                JObject Search = JObject.Parse(response);
                IList<JToken> results = Search["data"].Children().ToList();
               
                foreach (JToken result in results)
                {   
                    User searchResult = result.ToObject<User>();
                    searchResults.Add(searchResult);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Error occured in onGetUsers method in service layer");

            }
            return searchResults;
        }

        #endregion
    }
}
