using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Homework_1.Model;

namespace WPF_Homework_1.ViewModel
{
    public class MenuViewModel
    {
        private ObservableCollection<MenuModel> menuItems;
        public ObservableCollection<MenuModel> MenuItems
        {
            get { return menuItems; }
            set { menuItems = value; }
        }


        public MenuViewModel()
        {
            MenuItems = new ObservableCollection<MenuModel>();
            MenuItems.Add(new MenuModel() { Icon = "\xe6a4", Content = "用户" });
            MenuItems.Add(new MenuModel() { Icon = "\xe8ae", Content = "财务" });
            MenuItems.Add(new MenuModel() { Icon = "\xe62b", Content = "积分" });
            MenuItems.Add(new MenuModel() { Icon = "\xe60c", Content = "市场" });
            MenuItems.Add(new MenuModel() { Icon = "\xe665", Content = "客服" });

        }

    }
}
