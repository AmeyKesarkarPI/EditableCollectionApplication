using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditableCollectionApplication
{
    public class MainWindowViewModel : BaseWindowViewModel
    {
        public EditableCollectionViewModel EditableCarVM { get; set; }
        public EditableCollectionViewModel EditablePersonVM { get; set; }
        public EditableCollectionViewModel EditableFruitVM { get; set; }

        public MainWindowViewModel()
        {
            EditableCarVM = new EditableCar(new ObservableCollection<object>()
            {
                new Car() { CarID = 1, CarName = "BMW", ModelName = "M5", Color = "Silver"},
                new Car() { CarID = 2, CarName = "Mercedes" , Color = "Olive Green", ModelName = "Maybach"},
                new Car() { CarID = 3, CarName = "Jaguar", ModelName = "FPace", Color = "Matt Blue"},
                new Car() { CarID = 4, CarName = "Jeep", ModelName = "Compass", Color = "Black"},
                new Car() { CarID = 5, CarName = "Land Rover", ModelName = "KT", Color = "Silver"},
                new Car() { CarID = 6, CarName = "Range Rover", ModelName = "BT", Color = "Silver"},
                new Car() { CarID = 7, CarName = "Koeneigseg", ModelName = "Tiger", Color = "Black"},
                new Car() { CarID = 8, CarName = "Dodge", ModelName = "Challenger GT", Color = "White"},
                new Car() { CarID = 9, CarName = "Mustang", ModelName = "GT", Color = "Maroon"},
                new Car() { CarID = 10, CarName = "Bugatti", ModelName = "Chiron", Color = "Deep Blue"},
                new Car() { CarID = 11, CarName = "Lamborghini", ModelName = "Aventador", Color = "Violet"},
            });

            EditablePersonVM = new EditablePerson(new ObservableCollection<object>()
            {
                new Person { PersonID = 1, PersonName = "Shaam", PersonAge = 30},
                new Person { PersonID = 2, PersonName = "Baburao", PersonAge = 50},
                new Person { PersonID = 3, PersonName = "Raju", PersonAge = 32},
                new Person { PersonID = 4, PersonName = "Bunty", PersonAge = 26},
                new Person { PersonID = 5, PersonName = "Jones", PersonAge = 28},
                new Person { PersonID = 6, PersonName = "Mohan", PersonAge = 21},
                new Person { PersonID = 7, PersonName = "Sanjana", PersonAge = 19},
                new Person { PersonID = 8, PersonName = "Prakash", PersonAge = 19},
                new Person { PersonID = 9, PersonName = "Jayesh", PersonAge = 21},
                new Person { PersonID = 10, PersonName = "Kaushik", PersonAge = 40},
                new Person { PersonID = 11, PersonName = "Aman", PersonAge = 45},
            });


            EditableFruitVM = new EditableFruit(new ObservableCollection<object>
            {
                new Fruit() { FruitID = 1, FruitName = "Apple" , FruitTaste = "Sweet", FruitColor = "Green"},
                new Fruit() { FruitID = 2, FruitName = "Mango" , FruitTaste = "Sweet", FruitColor = "Orange"},
                new Fruit() { FruitID = 3, FruitName = "Banana" , FruitTaste = "Sweet", FruitColor = "Yellow"},
                new Fruit() { FruitID = 4, FruitName = "Jackfruit" , FruitTaste = "Sweet", FruitColor = "Green"},
                new Fruit() { FruitID = 5, FruitName = "Grapes" , FruitTaste = "Sweet", FruitColor = "Green"},
                new Fruit() { FruitID = 6, FruitName = "Jamun" , FruitTaste = "Sweet", FruitColor = "Violet"},
                new Fruit() { FruitID = 7, FruitName = "Fig" , FruitTaste = "Sweet", FruitColor = "Maroon"},
                new Fruit() { FruitID = 8, FruitName = "Guava" , FruitTaste = "Sweet", FruitColor = "Green"},
                new Fruit() { FruitID = 9, FruitName = "Pineapple" , FruitTaste = "Sour", FruitColor = "Yellow"},
                new Fruit() { FruitID = 10, FruitName = "Kiwi" , FruitTaste = "Bitter", FruitColor = "Brown"},
                new Fruit() { FruitID = 11, FruitName = "Avocado" , FruitTaste = "Sweet", FruitColor = "Green"},
            });

        }
    }
}
