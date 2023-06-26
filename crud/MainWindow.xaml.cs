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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace crud
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e) 
        {
            ListViewItem newitem = new ListViewItem(TextBox.Text);
            newitem.SubItems.Add(TextBox1.Text);
            newitem.SubItems.Add(TextBox2.Text);
            ListView.Items.Add(newitem);    
        }

        private void ListView_Click(object sender, EventArgs e)
        {
            TextBox.Text = ListView.SelectedItems[0].SubItems[0].Text;
            TextBox1.Text = ListView.SelectedItems[0].SubItems[1].Text;
            TextBox2.Text = ListView.SelectedItems[0].SubItems[2].Text;
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            if(ListView.SelectedItems.Count >0)
            {
                ListView.SelectedItems[0].SubItems[0].Text = TextBox.Text;
                ListView.SelectedItems[0].SubItems[1].Text = TextBox1.Text;
                ListView.SelectedItems[0].SubItems[2].Text = TextBox2.Text;
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ListView.SelectedItems.Count > 0)
            {
                ListView.Items.Remove(ListView.SelectedItems[0]);
            }
        }

    }
}
