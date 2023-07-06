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
        public EditableCar(ObservableCollection<object> Cars) : base (Cars)
        {
        }

        protected override string DisplayList(object item)
        {
            Car car = (Car)item;
            return car.CarName;
        }


        protected override bool ValidateSelectedItem(object item)
        {
            Car car = (Car)item;
            return SelectedFilterText == car.CarName ;
        }

        protected override void AddSelectedItem(object item, EditableCollectionViewModel viewModel)
        {
            SelectedItemList = new ObservableCollection<object>();
            Car car = (Car)item;
            car.viewModel = viewModel;
            SelectedItemList.Add(car);
        }

        protected override bool ValidateSearch(object item)
        {
            Car car = (Car)item;
            return car?.CarName.ToLower().Contains(FilterText?.ToLower() ?? "") ?? false;
        }

    }
}
