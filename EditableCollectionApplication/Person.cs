using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditableCollectionApplication
{
    public class Person
    {
        public EditableCollectionViewModel viewModel { get; set; }


        public int PersonID { get; set; }

        public string PersonName
        {
            get
            {
                return personName;
            }
            set
            {
                personName = value;
                if (viewModel != null)
                {
                    viewModel.SelectedFilterText = value;
                }
            }
        }

        public int PersonAge { get; set; }

        private string personName { get; set; }
    }
}
