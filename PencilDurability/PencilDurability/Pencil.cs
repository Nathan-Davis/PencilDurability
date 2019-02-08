using System;
using System.Text;

namespace PencilDurability
{
    public class Pencil
    {
        private readonly StringBuilder text;

        public Pencil()
        {
            text = new StringBuilder();
        }
        public string Write(string textToWrite)
        {
            return text.Append(textToWrite).ToString();
        }
    }
}
