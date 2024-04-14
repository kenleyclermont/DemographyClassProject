using Demographie.Maui.Views;

namespace Demographie.Maui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }
        public void RegisterRoutes()
        {
            Routing.RegisterRoute(nameof(PersonnesPage), typeof(PersonnesPage));
            Routing.RegisterRoute(nameof(AddPersonnePage), typeof(AddPersonnePage));
        }
    }
}
