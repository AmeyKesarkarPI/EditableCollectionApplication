using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditableCollectionApplication
{
    public class EditableCar : EditableCollectionViewModel
    {
        public ObservableCollection<object> Cars1 { get; set; }
        public EditableCar(ObservableCollection<object> Cars) : base (Cars)
        {
            Cars1 = Cars;
        }

        protected override string DisplayList(object item)
        {
            Car car = (Car)item;
            if (SelectedFilterText == car.CarName)
            {
                SelectedItem = new EditableCar(new ObservableCollection<object>() { car});
            }
            OnPropertyChange(nameof(SelectedItem));
            return car.CarName;
        }

        protected override bool ValidateSearch(object item)
        {
            Car car = (Car)item;
            return car?.CarName.ToLower().Contains(FilterText?.ToLower() ?? "") ?? false;
        }

    }
}
