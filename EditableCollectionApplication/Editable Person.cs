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
        public ObservableCollection<object> Persons1 { get; set; }
        public EditablePerson(ObservableCollection<object> Persons) : base(Persons)
        {
            Persons1 = Persons;
        }

        protected override string DisplayList(object item)
        {
            Person person = (Person)item;
            if (SelectedFilterText == person.PersonName)
            {
                SelectedItem = new EditablePerson(new ObservableCollection<object>() { person});
            }

            OnPropertyChange(nameof(SelectedItem));
            OnPropertyChange(nameof(SelectedItemList));
            return person.PersonName;
        }

        protected override bool ValidateSearch(object item)
        {
            Person person = (Person)item;
            return person?.PersonName.ToLower().Contains(FilterText?.ToLower() ?? "") ?? false;
        }
    }
}
