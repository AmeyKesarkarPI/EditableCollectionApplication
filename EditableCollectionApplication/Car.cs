using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditableCollectionApplication
{
    public class Car
    {
        public EditableCollectionViewModel viewModel { get; set; }

        public int CarID { get; set; }
        public string CarName
        {
            get
            {
                return carName;
            }
            set
            {
                carName = value;
                if (viewModel != null)
                {
                    viewModel.SelectedFilterText = value;
                }
            }
        }

        private string carName { get;set ; }
        public string ModelName { get; set; }
        public string Color { get; set; }

    }
}
