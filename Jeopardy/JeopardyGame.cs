using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing;

namespace Jeopardy
{
    class JeopardyGame
    {
        string _doc;
        Category[] _categories;
        Player[] _players;
        Color[] _colors = new Color[3] { Color.Red, Color.Lime, Color.DeepSkyBlue };

        private static JeopardyGame instance;

        public static JeopardyGame GetInstance(string path)
        {
            if (instance == null)
            {
                instance = new JeopardyGame(path);
            }
            return instance;
        }

        private JeopardyGame(string path)
        {
            _categories = new Category[5];
            if (File.Exists(path))
            {
                StreamReader myFile = new StreamReader(path, System.Text.Encoding.UTF8);
                _doc = myFile.ReadToEnd();
                myFile.Close();
            }
            readQuestions();
            _players = new Player[3];
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
                string sFirst = str.Split(new Char[] { '§' })[0];
                string sSecond = str.Split(new Char[] { '§' })[1];
                if (sFirst == "CAT")
                {
                    _categories[i] = new Category(sSecond);
                }
                else if (sFirst == "AUDIO" || sFirst == "IMAGE" || sFirst == "STRING")
                {
                    string sThird = str.Split(new Char[] { '§' })[2];
                    _categories[i].AddQuestion(sFirst, sSecond, sThird);
                }
            }
        }

        public void SetPlayer(int id, string name)
        {
            if (id >= _players.Length)
            {
                throw new IndexOutOfRangeException("Spieler-ID darf nicht größer als " + id + " sein.");
            }
            _players[id] = new Player(name, _colors[id]);
        }

        public Player GetPlayer(int id)
        {
            return _players[id];
        }

        public void correctAnswer(int player, int value)
        {
            _players[player].addScore(value);
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

        public Question getQuestion(int category, int question)
        {
            return _categories[category].GetQuestion(question);
        }
    }
}
