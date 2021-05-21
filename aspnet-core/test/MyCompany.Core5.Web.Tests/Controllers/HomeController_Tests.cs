using System.Threading.Tasks;
using MyCompany.Core5.Models.TokenAuth;
using MyCompany.Core5.Web.Controllers;
using Shouldly;
using Xunit;

namespace MyCompany.Core5.Web.Tests.Controllers
{
    public class HomeController_Tests: Core5WebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}