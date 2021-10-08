using Microsoft.VisualStudio.TestTools.UnitTesting;
using RichardSzalay.MockHttp;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Service.Layer.Tests
{
    [TestClass()]
    public class UserServiceTests
    {
        [TestMethod()]
        public void InitTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void onCreateTestAsync()
        {
            
        }

        [TestMethod()]
        public void onUpdateTest()
        {
            
        }

        [TestMethod()]
        public void onDeleteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void onGetUserByIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void onGetUserByNameTest()
        {
            //var httpClient = new HttpClient(new MockHttpMessageHandler());
            //httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //string accessToken = "fa114107311259f5f33e70a5d85de34a2499b4401da069af0b1d835cd5ec0d56";
            //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            //var content = await httpClient.GetStringAsync("https://gorest.co.in/public-api/users?name=Javas");
            //Assert.AreEqual("Content as string", content);

            var mockHttp = new MockHttpMessageHandler();

            // Setup a respond for the user api (including a wildcard in the URL)
            mockHttp.When("https://gorest.co.in/public-api/users/*")
                .Respond("application/json", "{'name' : 'Miss Javas Nambeesan'}"); // Respond with JSON

            // Inject the handler or client into your application code
            var client = mockHttp.ToHttpClient();

            //var response =  client.GetAsync("https://gorest.co.in/public-api/users?name=Miss");
            // or without async:
            var response = client.GetAsync("https://gorest.co.in/public-api/users/384").Result;

            var json = response;

            // No network connection required
            Console.Write(json); // {'name' : 'Miss Javas Nambeesan'}
            //Assert.IsNotNull(response);
            //Assert.AreEqual(response.StatusCode, HttpStatusCode.OK);
            //Assert.AreEqual("Miss Javas Nambeesan", json);
        }

        [TestMethod()]
        public void onGetUsersTest()
        {
            Assert.Fail();
        }
    }
}