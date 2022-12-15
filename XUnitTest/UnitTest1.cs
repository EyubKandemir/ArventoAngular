using ang.Controllers;
using System.Net;

namespace XUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public async void LoginTest()
        {
            var url = new Uri("http://localhost:5117/Login/LoginUser?username=eyyub&password=123456");
            HttpClient cli = new HttpClient();
            cli.BaseAddress = url;
            var res = await cli.GetAsync(url);
            Assert.Equal(HttpStatusCode.OK,res.StatusCode);
        }
    }
}