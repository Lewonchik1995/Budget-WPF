using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
namespace Budget_WPF
{
    public partial class AddTypeWindow : Window
    {
        public AddTypeWindow()
        {
            InitializeComponent();
        }

        private void Button_save_type_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.types.Add(Type_name.Text);
            DeSerialize.Serialize_type();
            Close();
        }
    }
}
