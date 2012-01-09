using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Jeopardy
{
    class JeopardyGame
    {
        string _doc;
        Category[] _categories;

        public JeopardyGame(string path)
        {
            _categories = new Category[5];
            if (File.Exists(path))
            {
                StreamReader myFile = new StreamReader(path, System.Text.Encoding.UTF8);
                _doc = myFile.ReadToEnd();
                myFile.Close();
            }
            readQuestions();
        }

        private void readQuestions()
        {
            int i = 0;
            foreach (string str in _doc.Split(new Char[] {'\n'}))
            {
                if (str == "NEWCAT")
                {
                    ++i;
                    continue;
                }
                string sFirst = str.Split(new Char[] {'#','#'})[0];
                string sSecond = str.Split(new Char[] { '#', '#' })[2];
                if (sFirst == "CAT")
                {
                    _categories[i] = new Category(sSecond);
                }
                else if (sFirst == "AUDIO" || sFirst == "IMAGE" || sFirst == "STRING")
                {
                    _categories[i].AddQuestion(sFirst, sSecond);
                }
            }
        }

        public string GetCategoryName(int category)
        {
            return _categories[category].GetName();
        }

        public bool isAnswerAudio(int category, int question)
        {
            return _categories[category].AnswerType(question) == Enums.AnswerType.Audio;
        }

        public bool isAnswerImage(int category, int question)
        {
            return _categories[category].AnswerType(question) == Enums.AnswerType.Image;
        }

        public string getAnswerContent(int category, int question)
        {
            return _categories[category].GetContent(question);
        }
    }
}
