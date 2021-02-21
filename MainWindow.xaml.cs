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

namespace WpfApp1_ArrangList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList arrayList;
        public MainWindow()
        {
            InitializeComponent();
            arrayList = new ArrayList();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
                if (txtBox.Text == " ")
                {
                    MessageBox.Show("Please input data here");
                }
                else
                {
                    arrayList.Add(txtBox.Text);
                    MessageBox.Show(txtBox.Text);
                    txtBox.Text = " ";
                }
        }

        private void removeButton_Click(object sender, RoutedEventArgs e)
        {
            if (txtBox.Text == " ")
            {
                MessageBox.Show("Please input you data here");
            }
            else
            {
                arrayList.Remove(txtBox.Text);
                MessageBox.Show(txtBox.Text);
                txtBox.Text = " ";
            }
        }

        private void showButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (string data in arrayList)
            {
                MessageBox.Show(data.ToString());
            }
        }
    }
}
