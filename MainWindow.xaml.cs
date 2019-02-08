/* Quinn Parker-Joyes
 * Feb 6 2019
 * hello world!
 */
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

namespace _316968HelloWorld
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
        int counter = 0;

        private void btnGreeting_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;            
            lblMessage.Content = "Hello, " + name;           
            counter++;
            if(counter == 10)
            {
                MessageBox.Show("Hello World");
                counter = 0;
            }                                    
        }
    }
}
