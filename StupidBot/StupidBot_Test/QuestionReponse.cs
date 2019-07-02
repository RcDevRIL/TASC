using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidBot_Test
{
    internal class QuestionReponse
    {
        public string Question { get; set; }
        public string Reponse { get; set; }

        public QuestionReponse() { }

        public QuestionReponse (string question, string reponse)
        {
            Question = question;
            Reponse = reponse;
        }
    }
}
