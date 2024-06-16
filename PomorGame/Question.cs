using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomorGame
{
    public struct Question
    {
        public string Quest;
        public string Ans1;
        public string Ans2;
        public string Ans3;
        public string Ans4;
        public string RealAns;
        public bool OnePicture;
        public List<Bitmap> Pics;

        public Question(string v1, string v2, string v3, string v4, string v5, string v6, bool v7, List<Bitmap> v8) : this()
        {
            Quest = v1;
            Ans1 = v2;
            Ans2 = v3;
            Ans3 = v4;
            Ans4 = v5;
            RealAns = v6;
            OnePicture = v7;
            Pics = v8;
        }
    }
}
