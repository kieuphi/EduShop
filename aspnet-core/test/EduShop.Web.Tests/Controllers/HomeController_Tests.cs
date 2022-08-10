using System.Threading.Tasks;
using EduShop.Models.TokenAuth;
using EduShop.Web.Controllers;
using Shouldly;
using Xunit;

namespace EduShop.Web.Tests.Controllers
{
    public class HomeController_Tests: EduShopWebTestBase
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