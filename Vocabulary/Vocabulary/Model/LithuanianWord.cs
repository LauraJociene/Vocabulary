using System;
using System.Collections.Generic;
using System.Text;

namespace Vocabulary.Model
{
    class LithuanianWord : Word
    {
        public LithuanianWord(string word) : base(word)
        {
            this.WordInSpecificLanguage = word;
        }

        public override void AddWord() { }

        public override void GetWord() { }

        public override void DeleteWord() { }

        public override void UpdateWord() { }


    }
}
