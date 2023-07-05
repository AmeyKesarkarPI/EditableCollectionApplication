using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation.Peers;

namespace EditableCollectionApplication
{
    public class EditableCollectionViewModel : BaseWindowViewModel
    {

        public EditableCollectionViewModel SelectedItem { get; set; }

        private string selectedFilterText { get; set; }

        public string SelectedFilterText
        {
            get
            {
                return selectedFilterText;
            }
            set
            {
                if (filterText != value)
                {
                    selectedFilterText = value;
                    FilterText = selectedFilterText;
                    OnPropertyChange(nameof(FilterText));
                }
            }
        }


        public string FilterText
        {
            get
            {
                return filterText;
            }
            set
            {
                filterText = value;
                OnPropertyChange(nameof(EditableCollectionList));
                FilterList();
            }
        }

        private string filterText;

        public ObservableCollection<string> EditableCollectionList { get; set; }

        private ObservableCollection<object> editableCollectionList { get; set; }

        public ObservableCollection<object> SelectedItemList { get; set; }
        
        private ObservableCollection<string> selectedItemList { get; set; }


        public void FilterList()
        {
            EditableCollectionList = new ObservableCollection<string>();
            foreach (var item in editableCollectionList)
            {
                if (ValidateSearch(item))
                {
                    EditableCollectionList.Add(DisplayList(item));
                }
            }

            OnPropertyChange(nameof(EditableCollectionList));
        }


        protected virtual string DisplayList(object item)
        {
            return item.ToString();
        }

        protected virtual bool ValidateSearch(object item)
        {
            return item?.ToString().ToLower().Contains(FilterText?.ToLower() ?? "") ?? false;
        }


        public EditableCollectionViewModel(ObservableCollection<object> Editable)
        {
            editableCollectionList = new ObservableCollection<object>(Editable);
            FilterList();
        }
    }
}
