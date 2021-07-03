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

namespace ArrayListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        ArrayList arrayList = new ArrayList();
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("ADD>>" + txtBox.Text);
            if (txtBox.Text.Equals(""))
            {
                MessageBox.Show("Please enter your data");
            }
            else
            {
                arrayList.Add(txtBox.Text);
                MessageBox.Show("Add Success");
            }
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Remove>>" + txtBox.Text);
            if (txtBox.Text.Equals(""))
            {
                MessageBox.Show("Please enter your data");
            }
            else
            {
                arrayList.Remove(txtBox.Text);
                MessageBox.Show("Remove Success");
            }
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            if (arrayList.Count <= 0)
            {
                MessageBox.Show("No data");
            }
            else
            {
                foreach (string data in arrayList)
                {
                    MessageBox.Show(data);
                }
            }
        }

        /*private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Add Data
            arrayList.Add(5);
            arrayList.Add(3);
            arrayList.Add(1);
            arrayList.Add(8);
            arrayList.Add(2);
            arrayList.Add(9);

            //Show Data
            foreach (int data in arrayList)
            {
                MessageBox.Show(data.ToString());
            }

            //Count
            MessageBox.Show("Count " + arrayList.Count.ToString());

            //Remove
            //arrayList.Remove(10); //Object
            //arrayList.RemoveAt(10); //index

            //Sort
            arrayList.Sort();

            //Clear
            arrayList.Clear();

        }*/

    }
}
