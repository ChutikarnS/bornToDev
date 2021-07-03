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

namespace HashTable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //Add
            if(txtKey.Text.Equals("")){
                MessageBox.Show("Please enter your key");
            }else if (txtValue.Text.Equals(""))
            {
                MessageBox.Show("Please enter your value");
            }
            else
            {
                bool checkKey = hashtable.ContainsKey(txtKey.Text);
                Console.WriteLine("checkKey>>" + checkKey);
                if (checkKey)
                {
                    MessageBox.Show("have data");
                }
                else
                {
                    hashtable.Add(txtKey.Text, txtValue.Text);
                    MessageBox.Show("Add Success");
                }
            }
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            //Remove
            if (txtKey.Text.Equals(""))
            {
                MessageBox.Show("Please enter your key");
            }
            else
            {
                if (hashtable.Count <= 0)
                {
                    MessageBox.Show("No Data");
                }
                else
                {
                    hashtable.Remove(txtKey.Text);
                    MessageBox.Show("Remove Success");
                }
            }
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            ICollection icollection = hashtable.Keys;

            //Show All
            if (hashtable.Count <= 0)
            {
                MessageBox.Show("No Data");
            }
            else
            {
                foreach (string key in icollection)
                {
                    MessageBox.Show(hashtable[key].ToString());
                }
            }
        }
    }
}
