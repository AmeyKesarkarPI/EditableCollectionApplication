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
        public ObservableCollection<object> Fruit1 { get; set; }
        public EditableFruit(ObservableCollection<object> Fruits) : base (Fruits)
        {
            Fruit1 = Fruits;
        }

        protected override string DisplayList(object item)
        {
            Fruit fruit = (Fruit)item;
            if (SelectedFilterText == fruit.FruitName)
            {
                SelectedItem = new EditableFruit(new ObservableCollection<object>() { fruit });
            }
            OnPropertyChange(nameof(SelectedItem));
            return fruit.FruitName;
        }

        protected override bool ValidateSearch(object item)
        {
            Fruit fruit = (Fruit)item;
            return fruit?.FruitName.ToLower().Contains(FilterText?.ToLower() ?? "") ?? false;
        }
    }
}
