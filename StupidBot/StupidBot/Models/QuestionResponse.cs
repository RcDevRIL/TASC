using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace StupidBot.Models
{
    
    public class QuestionResponse
    {
        //private string jsonPath = "C:/code/TASC/StupidBot/StupidBot/Resources/QuestionReponse.json";
        //private string jsonPath = @"Resources/QuestionReponse.json";
        private string jsonPath = AppDomain.CurrentDomain.BaseDirectory + "/Resources/QuestionReponse.json";
        public string Question { get; set; }
        public string Reponse { get; set; }

        public QuestionResponse() { }

        public QuestionResponse(string question, string reponse)
        {
            Question = question;
            Reponse = reponse;
        }

        public List<QuestionResponse> FindAllQuestionsResponses()
        {
            string file = File.ReadAllText(jsonPath);
            List<QuestionResponse> all = JsonConvert.DeserializeObject<List<QuestionResponse>>(file);
            return all;

        }

        public string GetResponse(string question)
        {
            List<QuestionResponse> list = FindAllQuestionsResponses();
            List<QuestionResponse> reponses = list.Where(q => q.Question.ToLower() == question.ToLower()).ToList();

            string reponse = "";

            if (reponses.Count > 1)
            {
                Random rand = new Random();
                reponse = reponses.ElementAt(rand.Next(0, reponses.Count)).Reponse;
            }

            if (reponses.Count == 1)
            {
                reponse = reponses.First().Reponse;
            }

            if (reponses.Count == 0)
            {
                var test = list.Where(r => r.Reponse== "").ToList();
                if (test.Count() != 0)
                {
                    ModifyResponse(test.First().Question, question);
                    reponse = "Merci de votre aide";
                }
                else
                {
                    AddQuestion(question);
                    reponse = "Je ne saisi pas vos insinuations...";
                    var listtest = FindAllQuestionsResponses();
                }
               
            }

            return reponse;
        }

        public void AddQuestion(string question)
        {
            var list = FindAllQuestionsResponses();

            list.Add(new QuestionResponse(question, ""));
            var convertedJson = JsonConvert.SerializeObject(list, Formatting.Indented);

            File.WriteAllText(jsonPath, convertedJson);

        }
        /*
        public void ModifyResponse(string question, string reponse)
        {
            QuestionResponse questionResponse = FindAllQuestionsResponses().Where(q => q.Question == question).Where(r => r.Reponse == "").First();

            questionResponse.Reponse = reponse;

            //list.Add(new QuestionResponse(question, reponse));
            var convertedJson = JsonConvert.SerializeObject(questionResponse, Formatting.Indented);

            File.WriteAllText(jsonPath, convertedJson);

        }
        */
        public void ModifyResponse(string question, string reponse)
        {
            DeleteResponse(question, "");
            AddQuestionResponse(question, reponse);
        }

        public void AddQuestionResponse(string question, string reponse)
        {
            Console.WriteLine(jsonPath);
            var list = FindAllQuestionsResponses();

            list.Add(new QuestionResponse(question, reponse));
            var convertedJson = JsonConvert.SerializeObject(list, Formatting.Indented);

            File.WriteAllText(jsonPath, convertedJson);

        }

        public void DeleteResponse(string question, string reponse)
        {
            var list = FindAllQuestionsResponses();
            QuestionResponse questionResponse = list.Where(q => q.Question == question).Where(r => r.Reponse == reponse).FirstOrDefault();
            list.RemoveAll(l => l.Question == questionResponse.Question && l.Reponse == questionResponse.Reponse);
            //list.Remove(questionResponse);
            string convertedJson = JsonConvert.SerializeObject(list, Formatting.Indented);

            File.WriteAllText(jsonPath, convertedJson);
        }
    }
}
