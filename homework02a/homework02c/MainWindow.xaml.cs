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

namespace homework02c
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /* args[0] = path of the document
         * args[1] = command line argument[0]
         * args[2] = command line argument[1]
         * the number of command line arguments should be two, or the result would be wrong
         * the default arguments are "argument01" and "argument02" 
         */
        string[] args = Environment.GetCommandLineArgs();

        /* @button "Hello"
         * create a button "Hello_Click" in mainwindow
         * if you click this button, messagebox will print "hello world"
         */
        private void Hello_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        /* @button "HelloWithArgs"
         * create a button "HelloWithArgs_Click" in mainwindow
         * if you click this button, messagebox will print "hello world" and the arguments of command line
         */
        private void HelloWithArgs_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World! The input arguments of command line are " + args[1] + args[2]);
        }
    }
}
