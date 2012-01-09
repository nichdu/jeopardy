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

        public Question(Enums.AnswerType atype, string content)
        {
            _atype = atype;
            _content = content;
        }

        public Enums.AnswerType AnswerType()
        {
            return _atype;
        }

        public string GetContent()
        {
            return _content;
        }
    }
}
