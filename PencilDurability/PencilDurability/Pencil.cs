using System;
using System.Text;

namespace PencilDurability
{
    public class Pencil
    {
        private readonly StringBuilder _text;
        private int _durability;

        public Pencil(int durability)
        {
            _text = new StringBuilder();
            _durability = durability;
        }
        public string Write(string textToWrite)
        {
            foreach (var character in textToWrite)
            {
                if (Char.IsUpper(character) && _durability > 1)
                {
                    _durability -= 2;
                    _text.Append(character);
                }
                else if (!Char.IsUpper(character) && _durability > 0 && character != ' ')
                {
                    _durability--;
                    _text.Append(character);
                }
                else
                {
                    _text.Append(' ');
                }
            }

            return _text.ToString();
        }
    }
}
