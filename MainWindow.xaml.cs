using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Budget_WPF
{
    public partial class MainWindow : Window
    {
        public static List<string> types = new List<string>();
        List<Note> filtered;
        int? note_index;

        public MainWindow()
        {
            InitializeComponent();
            Note.notes = DeSerialize.Deserialize<List<Note>>();
            DeSerialize.Deserialize_type();
            Date.Text = DateTime.Today.ToString();
            Type.ItemsSource = types;
            List_by_date();
        }

        private void Button_add_type_Click(object sender, RoutedEventArgs e)
        {
            Type.ItemsSource = types;
            AddTypeWindow addTypeWindow = new AddTypeWindow();
            addTypeWindow.Show();
        }

        private void Button_add_Click(object sender, RoutedEventArgs e)
        {
            Note.Create_note(Convert.ToDateTime(Date.Text), Note_name.Text, Type.Text, Convert.ToInt32(Sum.Text));
            DeSerialize.Serialize(Note.notes);
            Refresh();

        }

        private void Button_change_Click(object sender, RoutedEventArgs e)
        {
            Note.Update_note(note_index, Convert.ToDateTime(Date.Text), Note_name.Text, Type.Text, Convert.ToInt32(Sum.Text));
            DeSerialize.Serialize(Note.notes);
            List_by_date();
            note_index = null;
            Refresh();
        }

        private void Button_delete_Click(object sender, RoutedEventArgs e)
        {
            Note.Delete_note(note_index);
            DeSerialize.Serialize(Note.notes);
            Refresh();
        }

        private void Date_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void List_by_date()
        {
            Type.ItemsSource = types;
            filtered = Note.notes.Where(n => n.Date.Date == Convert.ToDateTime(Date.Text).Date).ToList();
            Data.ItemsSource = null;
            Data.ItemsSource = filtered;
        }

        private void Data_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Type.ItemsSource = types;
            if (Data.SelectedIndex >= 0)
            {
                for (int i = 0; i < Note.notes.Count(); i++)
                {
                    if (filtered[Data.SelectedIndex].Date == Note.notes[i].Date)
                    {
                        if (filtered[Data.SelectedIndex].Name == Note.notes[i].Name)
                        {
                            if (filtered[Data.SelectedIndex].Type == Note.notes[i].Type)
                            {
                                if (filtered[Data.SelectedIndex].Sum == Note.notes[i].Sum)
                                {
                                    note_index = i;
                                    Note_name.Text = Note.notes[i].Name;
                                    Type.Text = Note.notes[i].Type;
                                    if (Note.notes[i].IsInCome == false)
                                    {
                                        Sum.Text = Convert.ToString(Note.notes[i].Sum * (-1));
                                    }
                                    else
                                    {
                                        Sum.Text = Convert.ToString(Note.notes[i].Sum);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private string Count_total()
        {
            string total = "Итог: 0";
            int total_sum = 0;
            for (int i = 0; i < Note.notes.Count(); i++)
            {
                if (Note.notes[i].IsInCome == false)
                {
                    total_sum -= Note.notes[i].Sum;
                    total = "Итог: " + total_sum;
                }
                else
                {
                    total_sum += Note.notes[i].Sum;
                    total = "Итог: " + total_sum;
                }
            }
            return total;
        }

        public void Refresh()
        {
            List_by_date();
            Note_name.Text = "";
            Type.Text = "";
            Sum.Text = "";
            Total.Text = Count_total();
        }
    }
}
