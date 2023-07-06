using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace EditableCollectionApplication
{
    public class EditablePerson : EditableCollectionViewModel
    {
        public EditablePerson(ObservableCollection<object> Persons) : base(Persons)
        {
        }

        protected override string DisplayList(object item)
        {
            Person person = (Person)item;
            return person.PersonName;
        }

        protected override bool ValidateSelectedItem(object item)
        {
            Person person = (Person)item;
            return SelectedFilterText == person.PersonName;
        }

        protected override void AddSelectedItem(object item, EditableCollectionViewModel viewModel)
        {
            SelectedItemList = new ObservableCollection<object>();
            Person person = (Person)item;
            person.viewModel = viewModel; 
            SelectedItemList.Add(person);
        }

        protected override bool ValidateSearch(object item)
        {
            Person person = (Person)item;
            return person?.PersonName.ToLower().Contains(FilterText?.ToLower() ?? "") ?? false;
        }
    }
}
