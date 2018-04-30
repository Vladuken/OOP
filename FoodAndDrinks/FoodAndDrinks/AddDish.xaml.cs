using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using System.Reflection;

using FoodAndDrinks.Classes;

namespace FoodAndDrinks
{
    /// <summary>
    /// Логика взаимодействия для AddDish.xaml
    /// </summary>
    public partial class AddDish : Window
    {
        private Type[] _dishes;

        private MainWindow.AddDishDelegate _adddish;
        public AddDish(Dish dish, MainWindow.AddDishDelegate AddDishHandler)
        {
            InitializeComponent();

            _adddish = AddDishHandler;

            //initialise ComboBox of types of dishes
            Type tDish = typeof(Dish);
            _dishes = Assembly.GetAssembly(tDish).GetTypes()
                .Where(type => (type.IsSubclassOf(tDish) && !type.IsAbstract)).ToArray();
            foreach (Type dishtype in _dishes)
            {
                cbType.Items.Add(dishtype.Name);
            }


            if (dish != null)
            {
                tbTitle.Text = dish.Title;
                tbCalories.Text = dish.Calories.ToString();
                //cbType.SelectedIndex = (int)dish.DishType;
            }
            else
            {
                tbTitle.Text = "";
                tbCalories.Text = "";
                
            }

            


        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            if (tbTitle.Text.Length == 0 || tbCalories.Text.Length == 0)
            {
                MessageBox.Show("Please, fill all fields.", "Save changes", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Type dishtype = null;
            if (cbType.SelectedIndex >= 0)
            {
                dishtype = _dishes[cbType.SelectedIndex];
            }
            else
            {
                MessageBox.Show("Please, choose dish type.", "Ok", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            string title = tbTitle.Text;

            int calories = 0;


            //парсинге калорий в строку

            if (Int32.TryParse(tbCalories.Text, out calories))
            {
            }
            else
            {
                MessageBox.Show("Please, write number in calories.", "Ok", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


            dynamic instance = Activator.CreateInstance(dishtype, title, calories);
            _adddish(instance);

            Close();
        }
    }
}
