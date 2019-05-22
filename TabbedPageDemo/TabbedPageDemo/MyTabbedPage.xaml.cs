using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedPageDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyTabbedPage : TabbedPage
    {
        public MyTabbedPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            MessagingCenter.Subscribe<object>(this, "Pop", (sender) =>
            {
                Navigation.PopAsync();
            });
        }
    }
}