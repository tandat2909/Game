using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using UnityEngine;

namespace Assets.Data
{
   public class Score : IComparable<Score>
    {
        
        private string name; 
        private float values;
        public string Name { set => name = value ; get => name; }
        public float Values { set => values = value; get => values; }
        public Score(string name, float values)
        {
            this.Name = name;
            this.Values = values;
        }
        public Score()
        {
            this.Name = "";
            this.Values = 0;
        }

        public int CompareTo( Score other)
        {
            try
            {
                return this.Values <= other.Values ? 1 : this.Values == other.Values ? 0 : -1;
            }
            catch { return 0; }
        }
        public override string ToString()
        {
            return Name + "\t" + values;
        }
        public string ToString(int a)
        {
            return "Name: " + Name + "\tScore: " + Values;
        }
    }
}
