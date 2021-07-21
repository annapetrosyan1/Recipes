using Recipes.Service;
using Xamarin.Forms;

namespace Recipes
{
    public partial class App : Application
    {

        public App()
        {
            Service<IRecipesService>.RegisterService(new FakeRecipesService());
            Service<ICategoriesService>.RegisterService(new FakeCategoriesService());
            Service<IListFoodService>.RegisterService(new FakeListFoodService());
            Service<IFoodService>.RegisterService(new FakeFoodService());
            InitializeComponent();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}