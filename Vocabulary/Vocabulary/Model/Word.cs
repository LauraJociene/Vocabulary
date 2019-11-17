using System;
using System.Collections.Generic;
using System.Text;

namespace Vocabulary.Model
{
   abstract class Word
    {
        public int Id { get; set; }
        public string WordInSpecificLanguage { get; set; }

        public Word(string word) 
        {
            this.WordInSpecificLanguage = word;
        }

        public abstract void AddWord();

        public abstract void GetWord();

        public abstract void DeleteWord();

        public abstract void UpdateWord();

    }
}
