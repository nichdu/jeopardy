using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeopardy
{
    class Category
    {
        string _name;
        Question[] _questions;

        public Category(string name)
        {
            _questions = new Question[5];
            _name = name;
        }

        public void AddQuestion(string type, string content)
        {
            Enums.AnswerType atype = Enums.AnswerType.Text;
            switch (type)
            {
                case "AUDIO":
                    atype = Enums.AnswerType.Audio;
                    break;
                case "IMAGE":
                    atype = Enums.AnswerType.Image;
                    break;
                case "STRING":
                    atype = Enums.AnswerType.Text;
                    break;
            }
            int i = 0;
            while (_questions[i] != null)
            {
                ++i;
            }
            _questions[i] = new Question(atype, content);
        }

        public void AddQuestion(Enums.AnswerType type, string content)
        {
            int i = 0;
            while (_questions[i] != null)
            {
                ++i;
            }
            _questions[i] = new Question(type, content);
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public Enums.AnswerType AnswerType(int question)
        {
            return _questions[question].AnswerType();
        }

        public string GetContent(int question)
        {
            return _questions[question].GetContent();
        }
    }
}
