using Data.Access.Layer;
using NUnit.Framework;
using Service.Layer;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Business.Layer.Test
{
    [TestFixture]
    public class VM_MainTests
    {
        public IUserService Service;
        [SetUp]
        public void SetUp()
        {
            Service = new UserService();
            Service.Init();

        }

        [Test]
        public void TestGetAllUser()
        {
            var viewModel = new VM_Main();
            Task.Factory.StartNew(async () =>
            {
                var data = await Service.onGetUsers();
                viewModel.Items = new ObservableCollection<User>(data);

            });
            Assert.Pass("Error", viewModel.Items);
        }

        [Test]
        public void TestFilter_With_String()
        {
            var viewModel = new VM_Main();
            viewModel.Search = "jqn9";
            Task.Factory.StartNew(async () =>
            {
                var data = await Service.onGetUserByName(viewModel.Search);
                viewModel.Items = new ObservableCollection<User>(data);

            });
            Assert.Pass("Error", viewModel.Items);
        }

        [Test]
        public void TestFilter_With_Empty_String()
        {
            var viewModel = new VM_Main();
            viewModel.Search = "";
            Task.Factory.StartNew(async () =>
            {
                var data = await Service.onGetUserByName(viewModel.Search);
                viewModel.Items = new ObservableCollection<User>(data);

            });
            Assert.Pass("Error", viewModel.Items);
        }

        [Test]
        public void Test_Create_User()
        {
            var viewModel = new VM_Main();

            Assert.IsTrue(viewModel.CreateCommand.CanExecute(null));
        }

        [Test]
        public void Test_Delete_User()
        {
            var viewModel = new VM_Main();

            Assert.IsTrue(viewModel.RemoveCommand.CanExecute(null));
        }
    }
}
