using System;
using System.Collections.Generic;
using System.Text;

namespace Section15DictionaryProposedExercise.Entities
{
    class Candidate
    {
        public string Name { get; set; }
        public int Vote { get; set; }
        public Candidate(string name, int vote)
        {
            Name = name;
            Vote = vote;
        }
        //public override bool Equals(object obj)
        //{
        //    if (!(obj is Candidate))
        //    {
        //        return false;
        //    }
        //    Candidate other = obj as Candidate;
        //    return Name.Equals(other.Name);
        //}
        //public override int GetHashCode()
        //{
        //    return Name.GetHashCode();
        //}
    }
}
