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

namespace GradeSuccess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GradeCategory quiz = new GradeCategory(0.25f, "quiz");
            Assignment first = new Assignment("first", quiz, 93, 100);
            Assignment second = new Assignment("second", quiz, 87, 100);
            Assignment third = new Assignment("third", quiz, 97, 100);
            Assignment fourth = new Assignment("fourth", quiz, 96, 100);

            quiz.AddAssignment(first);
            quiz.AddAssignment(second);
            quiz.AddAssignment(third);
            quiz.AddAssignment(fourth);

            Console.WriteLine(quiz);
        }
    }
}
