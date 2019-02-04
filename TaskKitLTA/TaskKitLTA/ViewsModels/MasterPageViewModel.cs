using System;
using System.Collections.Generic;
using System.Text;
using TaskKitLTA.Models;
using TaskKitLTA.Views;

namespace TaskKitLTA.ViewsModels
{
    public class MasterPageViewModel : ViewModelBase
    {
        private List<MasterPageItem> _items;

        public List<MasterPageItem> Items
        {
            get { return _items; }
            set { SetProperty(ref _items, value); }
        }

        public MasterPageViewModel()
        {
            Items = new List<MasterPageItem>();
            Load();
        }

        private void Load()
        {
            Items.Add(new MasterPageItem
            {
                Title = "EJERCICIO 1",
                Icon = "l130.png",
                Target = typeof(PendientesPage)
            });

        }
    }
}
