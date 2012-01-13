using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jeopardy
{
    class Question
    {
        Enums.AnswerType _atype;
        string _content;
        string _q;

        public Question(Question previous)
        {
            _atype = previous._atype;
            _content = previous._content;
            _q = previous._q;
        }

        public Question(Enums.AnswerType atype, string content, string q)
        {
            _atype = atype;
            _content = content;
            _q = q;
        }

        public Enums.AnswerType AnswerType()
        {
            return _atype;
        }

        public string GetContent()
        {
            return _content;
        }

        public string GetQuestion()
        {
            return _q;
        }
    }
}
