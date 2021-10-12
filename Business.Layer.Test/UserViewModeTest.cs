using Data.Access.Layer;
using NUnit.Framework;
using Service.Layer;

namespace Business.Layer.Test
{
    [TestFixture]
    public class UserViewModeTest
    {
        public IUserService Service;
        [SetUp]
        public void SetUp()
        {
            Service = new UserService();
            Service.Init();

        }

        [Test]
        public void Test_Create_New_User()
        {
            var viewModel = new UserViewModel();
            var data = new UserModel()
            {
                Name = "Test User",
                Email = "User@gmail.com",
                Gender = "Male",
                Status = "Active"
            };

            viewModel.User = data;

            Assert.IsTrue(viewModel.SaveCommand.CanExecute(null));
        }

        [Test]
        public void Test_Update_User()
        {
            var viewModel = new UserViewModel();
            var data = new UserModel()
            {
                Id = 101,
                Name = "Test User",
                Email = "User@gmail.com",
                Gender = "Male",
                Status = "Active"
            };

            viewModel.User = data;

            Assert.IsTrue(viewModel.UpdateCommand.CanExecute(null));
        }


    }
}
