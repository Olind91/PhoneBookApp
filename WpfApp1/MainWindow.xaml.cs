using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfApp1.Models;
using WpfApp1.Services;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Contacts> contacts = new ObservableCollection<Contacts>();
        private readonly FileService file = new();


        public MainWindow() //DO NOT TOUCH CONSTRUCTOR 
        {
            InitializeComponent();
            file.FilePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\content.json";
            GetContactsFromJson();
        }


        private void GetContactsFromJson()
        {
            try
            {
                var items = JsonConvert.DeserializeObject<ObservableCollection<Contacts>>(file.Read());
                if (items != null)
                {
                    contacts = items;
                }
            }
            catch { }

            lv_Contacts.ItemsSource = contacts;
        }





        private void Btn_Add_Click(object sender, RoutedEventArgs e)
        {
            contacts.Add(new Contacts
            {
                FirstName = tb_FirstName.Text,
                LastName = tb_LastName.Text,
                Email = tb_Email.Text,
                PhoneNumber = tb_PhoneNumber.Text,
                City = tb_City.Text,

            });
            file.Save(JsonConvert.SerializeObject(contacts));
            ClearForm();
        }

        private void ClearForm()
        {
            tb_FirstName.Text = "";
            tb_LastName.Text = "";
            tb_Email.Text = "";
            tb_PhoneNumber.Text = "";
            tb_City.Text = "";
        }

    }
}
