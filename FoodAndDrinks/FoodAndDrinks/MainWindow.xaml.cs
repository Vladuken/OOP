﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;

using System.Reflection;

using FoodAndDrinks.Classes;
using Microsoft.Win32;
using System.Runtime.Serialization.Json;

namespace FoodAndDrinks
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Dish> Dishes { get; set; }

        //делегатикиивентики
        public delegate void AddDishDelegate(Dish dish);
        AddDishDelegate AddDishHandler;
        private Dish _selectedDish;

        private Interfaces.IPlugin currentplugin;

        public MainWindow()
        {
            InitializeComponent();
            Dishes = new List<Dish>();
            AddDishHandler = AddDishToList;

            Dishes.Add(new Dessert("Icecream", 200));
            Dishes.Add(new Dessert("Pie", 700));
            Dishes.Add(new MainDish("Baked Potato", 300));



            AdditiveList list = new AdditiveList();
            list.Add(new AdditiveClass("Sugar"));
            list.Add(new AdditiveClass("Pepper"));
            list.Add(new AdditiveClass("Salt"));
            list.Add(new AdditiveClass("Cheese"));
            list.Add(new AdditiveClass("Topping"));
            list.Add(new AdditiveClass("Sauce"));



            foreach (var additive in list.AdsList)
            {
                cbAdditive.Items.Add(additive.Name);
            }
            cbAdditive.SelectedIndex = 0;

            dgUpdate();


            //Dish d = new StarterDish("Pepe",123);
            //d.AddAdditive(list);
            //d.AdsList.Add(Additive.Sauce);
        }

        private void AddDishBtn_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                AddDish form = new AddDish(null,AddDishHandler);
                form.ShowDialog();
            }
            catch (Exception) { }

            dgUpdate();
        }

        private void EditDishBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AddDish form = new AddDish(_selectedDish, AddDishHandler);
                form.ShowDialog();
            }
            catch (Exception) { }

            dgUpdate();
        }

        public void dgUpdate()
        {
            //Dishes
            int dgSelect = dgDishes.SelectedIndex;
            dgDishes.ItemsSource = null;
            dgDishes.ItemsSource = Dishes;

            dgDishes.SelectedIndex = dgSelect;
        }

        public void AddDishToList(Dish dish)
        {
            Dishes.Add(dish);
        }

        private void dgDishes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _selectedDish = dgDishes.SelectedItem as Dish;
        }

        private void DeleteDishBtn_Click(object sender, RoutedEventArgs e)
        {
            Dishes.Remove(_selectedDish);
            dgUpdate();
        }

        private void binSerializeBtn_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlgSaveFile = new SaveFileDialog();
            BinaryFormatter serializer = new BinaryFormatter();

            dlgSaveFile.Filter = "dat files (*.dat)|*.dat";
            //serialize
            if (dlgSaveFile.ShowDialog() == true && dlgSaveFile.FileName != "")
            {
                try
                {
                    using (Stream stream = File.Open(dlgSaveFile.FileName, FileMode.Create))
                    {
                        serializer.Serialize(stream, Dishes);
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Cannot serialize data.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            dgUpdate();
        }

        private void binSerializeBtn1_Click(object sender, RoutedEventArgs e)
        {

            OpenFileDialog dlgOpenFile = new OpenFileDialog();
            BinaryFormatter deserializer = new BinaryFormatter();

            Stream stream = null;

            dlgOpenFile.Filter = "dat files (*.dat)|*.dat";
            if (dlgOpenFile.ShowDialog() == true && dlgOpenFile.FileName != "")
            {
                try
                {
                    if((stream = dlgOpenFile.OpenFile()) != null)
                    {
                        using (stream)
                        {
                            Dishes.Clear();
                            Dishes = (List<Dish>) deserializer.Deserialize(stream);

                        }
                    }
                }
                catch(IOException)
                {
                    MessageBox.Show("Cannot deserialize data.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            dgUpdate();
        }

        private void xmlSerializeBtn_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlgSaveFile = new SaveFileDialog();

            Type tDish = typeof(Dish);
            Type[] dishtypes = Assembly.GetAssembly(tDish).GetTypes()
                .Where(type => (type.IsSubclassOf(tDish) && !type.IsAbstract)).ToArray();


             XmlSerializer serializer = new XmlSerializer(typeof(List<Dish>), dishtypes);

            //DataContractSerializer serializer = new DataContractSerializer(typeof(List<Employee>), jobs);

            dlgSaveFile.Filter = "xml files (*.xml)|*.xml";

            if (dlgSaveFile.ShowDialog() == true && dlgSaveFile.FileName != "")
            {
                try
                {
                    using (FileStream stream = File.Open(dlgSaveFile.FileName, FileMode.Create))
                    {
                        serializer.Serialize(stream, Dishes);
                        //serializer.WriteObject(stream, Employees);
                    }
                    //XMLToTXTTransformer.XMLToTXTTransformer a = new XMLToTXTTransformer.XMLToTXTTransformer();
                    //XMLToJSONTransformer.XMLToJSONTransformer a = new XMLToJSONTransformer.XMLToJSONTransformer();
                    //XMLToHTML.XMLToHTMLTransformer a = new XMLToHTML.XMLToHTMLTransformer();
                    // a.Transform(dlgSaveFile.FileName);

                    if (currentplugin != null)
                    {
                        currentplugin.Transform(dlgSaveFile.FileName);
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Cannot serialize data.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            dgUpdate();
        }

        private void xmlDeserializeBtn_Click(object sender, RoutedEventArgs e)
        {
            Stream stream = null;
            OpenFileDialog dlgOpenFile = new OpenFileDialog();

            Type tDish = typeof(Dish);
            Type[] dishtypes = Assembly.GetAssembly(tDish).GetTypes()
            .Where(type => (type.IsSubclassOf(tDish) && !type.IsAbstract)).ToArray();

            XmlSerializer serializer = new XmlSerializer(typeof(List<Dish>),dishtypes);

            dlgOpenFile.Filter = "xml files (*.xml)|*.xml";

            if (dlgOpenFile.ShowDialog() == true)
            {
                try
                {
                    if ((stream = dlgOpenFile.OpenFile()) != null)
                    {
                        using (stream)
                        {
                            Dishes.Clear();
                            Dishes = (List<Dish>)serializer.Deserialize(stream);
                        }
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Cannot deserialize data.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            dgUpdate();
        }

        private void btnJSONSerialize_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlgSaveFile = new SaveFileDialog();

            Type tDish = typeof(Dish);
            Type[] dishestypes = Assembly.GetAssembly(tDish).GetTypes()
                .Where(type => (type.IsSubclassOf(tDish) && !type.IsAbstract)).ToArray();

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Dish>), dishestypes);

            dlgSaveFile.Filter = "json files (*.json)|*.json";

            if (dlgSaveFile.ShowDialog() == true && dlgSaveFile.FileName != "")
            {
                try
                {
                    using (Stream stream = File.Open(dlgSaveFile.FileName, FileMode.Create))
                    {
                        serializer.WriteObject(stream, Dishes);
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Cannot serialize data.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            dgUpdate();
        }

        private void btnJSONdeserialize_Click(object sender, RoutedEventArgs e)
        {
            Stream stream = null;

            Type tDish = typeof(Dish);
            Type[] dishestypes = Assembly.GetAssembly(tDish).GetTypes()
                .Where(type => (type.IsSubclassOf(tDish) && !type.IsAbstract)).ToArray();

            OpenFileDialog dlgOpenFile = new OpenFileDialog();
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Dish>),dishestypes);


            dlgOpenFile.Filter = "json files (*.json)|*.json";

            if (dlgOpenFile.ShowDialog() == true)
            {
                try
                {
                    if ((stream = dlgOpenFile.OpenFile()) != null)
                    {
                        using (stream)
                        {
                            Dishes.Clear();
                            Dishes = (List<Dish>)serializer.ReadObject(stream);
                        }
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Cannot deserialize data.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            dgUpdate();
        }

        private void btnAddAdditive_Click(object sender, RoutedEventArgs e)
        {
            if (dgDishes.SelectedIndex != -1)
            {
                if (_selectedDish.AdsList == null)
                {
                    _selectedDish.AdsList = new AdditiveList();

                    _selectedDish.AdsList.Add(new AdditiveClass(cbAdditive.SelectedItem.ToString()));
                    //_selectedDish.AdsList.Add((AdditiveClass)cbAdditive.SelectedIndex);

                }
                else
                {
                    _selectedDish.AdsList.Add(new AdditiveClass(cbAdditive.SelectedItem.ToString()));
                    //_selectedDish.AdsList.Add((Additive)cbAdditive.SelectedIndex);

                }
            }
            dgUpdate();
        }

        private void btnremoveAdditive_Click(object sender, RoutedEventArgs e)
        {
            if (dgDishes.SelectedIndex != -1)
            {
                if (_selectedDish.AdsList == null)
                {
                    _selectedDish.AdsList = new AdditiveList();

                }
                else
                {
                    _selectedDish.AdsList.Remove(cbAdditive.SelectedItem.ToString());
                }
            }
            dgUpdate();
        }

        private void btnChooseDLL_Click(object sender, RoutedEventArgs e)
        {
            ////////////////////////////////////////////////////////////////////////////////
            OpenFileDialog dlgOpenFile = new OpenFileDialog();
            int cnt = 0;
            dlgOpenFile.Filter = "Dll Files|*.dll";
            if (dlgOpenFile.ShowDialog() == true)
            {
                Assembly.Load(File.ReadAllBytes(dlgOpenFile.FileName));

                Assembly[] asm = AppDomain.CurrentDomain.GetAssemblies();

                foreach (Assembly a in AppDomain.CurrentDomain.GetAssemblies())
                {
                    foreach (Type t in a.GetTypes())
                    {
                        if (t.GetInterface("IPlugin") != null)
                        {
                            currentplugin = Activator.CreateInstance(t) as Interfaces.IPlugin;
                            lblPlugName.Content = currentplugin.PName();
                        }

                    }
                }
               
            }
            ////////////////////////////////////////////////////////////////////////////////////////
            dgUpdate();

        }

        private void btnActivateDLL_Click(object sender, RoutedEventArgs e)
        {
            currentplugin = null;
            lblPlugName.Content = "";
        }


        //adapter 
        private void eatbtn_Click(object sender, RoutedEventArgs e)
        {
            if (_selectedDish != null)
            {
                if (_selectedDish is Fluid)
                {
                    IFood fluidfood = new FluidToFoodAdapter(_selectedDish as Fluid);
                    fluidfood.Eat();
                }
                else
                {
                    _selectedDish.Eat();
                }
               
                
            }
        }

        private void proxyeatbtn_Click(object sender, RoutedEventArgs e)
        {
            if (_selectedDish != null)
            { 
                DishProxy proxy = new DishProxy(_selectedDish);
                proxy.Eat();
                

            }
        }

        private void singletonbtn_Click(object sender, RoutedEventArgs e)
        {
            if (_selectedDish != null)
            {
                SingletonDish d = SingletonDish.GetInstance(_selectedDish);
                singletonlbl.Content = d.Title + "  " + d.Calories.ToString();
            }
            
        }
    }
}
