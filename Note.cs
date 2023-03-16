using System;
using System.Collections.Generic;

namespace Budget_WPF
{
    public class Note
    {
        public DateTime Date;
        public string Name { get; set; }
        public string Type { get; set; }
        public int Sum { get; set; }
        public bool IsInCome { get; set; }

        public static List<Note> notes = new List<Note>();

        public static void Create_note(DateTime date, string name, string type, int sum)
        {
            bool isInCome = false;
            if (sum > 0)
                isInCome = true;
            else
                sum = sum * (-1);
            notes.Add(new Note { Date = date, Name = name, Type = type, Sum = sum, IsInCome = isInCome });
        }

        public static void Update_note(int? note_index, DateTime date, string name, string type, int sum)
        {
            bool isInCome = false;
            if (sum > 0)
                isInCome = true;
            else
                sum = sum * (-1);
            notes[Convert.ToInt32(note_index)] = new Note { Date = date, Name = name, Type = type, Sum = sum, IsInCome = isInCome };
        }

        public static void Delete_note(int? note_index) 
        {
            notes.RemoveAt(Convert.ToInt32(note_index));
        }
    }
}