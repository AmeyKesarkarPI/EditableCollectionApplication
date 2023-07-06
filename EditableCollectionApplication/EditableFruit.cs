using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditableCollectionApplication
{
    public class EditableFruit : EditableCollectionViewModel
    {
        public EditableFruit(ObservableCollection<object> Fruits) : base (Fruits)
        {
        }

        protected override string DisplayList(object item)
        {
            Fruit fruit = (Fruit)item;
            return fruit.FruitName;
        }

        protected override bool ValidateSelectedItem(object item)
        {
            Fruit fruit = (Fruit)item;
            return SelectedFilterText == fruit.FruitName;
        }

        protected override void AddSelectedItem(object item, EditableCollectionViewModel viewModel)
        {
            SelectedItemList = new ObservableCollection<object>();
            Fruit fruit = (Fruit)item;
            fruit.viewModel = viewModel;
            SelectedItemList.Add(fruit);
        }

        protected override bool ValidateSearch(object item)
        {
            Fruit fruit = (Fruit)item;
            return fruit?.FruitName.ToLower().Contains(FilterText?.ToLower() ?? "") ?? false;
        }
    }
}
