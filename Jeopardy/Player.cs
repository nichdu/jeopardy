using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Jeopardy
{
    class Player
    {
        string _name;
        int _score;
        Color _color;

        public Player(string name, Color color)
        {
            _name = name;
            _score = 0;
            _color = color;
        }

        public Player(string name, Color color, int score)
        {
            _name = name;
            _score = score;
            _color = color;
        }

        public Player(Player previous)
        {
            _name = previous._name;
            _score = previous._score;
            _color = previous._color;
        }

        public void addScore(int score)
        {
            _score += score;
        }

        public void setScore(int score)
        {
            _score = score;
        }

        public int GetScore()
        {
            return _score;
        }

        public string GetName()
        {
            return _name;
        }

        public Color GetColor()
        {
            return _color;
        }
    }
}
