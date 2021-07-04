using System;
using System.Collections;
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

namespace SQLiteApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataAccess.InitializeDatabase();
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            String data = "";
            List<string> list = DataAccess.GetData();


            foreach (string value in list)
            {
                data += value + "\n";
            }

            MessageBox.Show("DataList \n" + data);
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!txtAdd.Text.Equals(""))
            {
                DataAccess.AddData(txtAdd.Text);
                MessageBox.Show("Add Success");
            }
            else
            {
                MessageBox.Show("Please enter your value");
            }
            
        }
    }
}
