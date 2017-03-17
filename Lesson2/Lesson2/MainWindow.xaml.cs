
using System.Windows;
using System.Windows.Controls;


namespace Lesson2
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ButAddInDel.Content = ">>";
            ButAddInList.Content = "<<";
        }

 
        public class Student
        {
            public string FIO { get; set; }
            public string Group { get; set; }
            public string Phone { get; set; }
            
        }
    }
}
