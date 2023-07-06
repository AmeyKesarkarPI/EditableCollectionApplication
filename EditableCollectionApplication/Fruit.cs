using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditableCollectionApplication
{
    public class Fruit
    {
        public EditableCollectionViewModel viewModel { get; set; }
        public int FruitID { get; set; }
        public string FruitName
        {
            get
            {
                return fruitName;
            }
            set
            {
                fruitName = value;
                if (viewModel != null)
                {
                    viewModel.SelectedFilterText = value;
                }
            }
        }

        private string fruitName { get; set; }
        public string FruitTaste { get; set; }
        public string FruitColor { get; set; }
    }
}
