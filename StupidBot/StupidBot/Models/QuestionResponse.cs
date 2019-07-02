﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidBot.Models
{

    public class QuestionResponse
    {
        private string jsonPath = "D:/Code/CESi/Projet_Informatique/TASC/StupidBot/StupidBot/Resources/QuestionReponse.json";
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
            List<QuestionResponse> reponses = list.Where(q => q.Question == question).ToList();

            string reponse = "Je ne saisi pas vous insinuation...";

            if (reponses.Count == 1)
            {
                reponse = reponses.First().Reponse;
            }

            if (reponses.Count > 1)
            {
                Random rand = new Random();
                reponse = reponses.ElementAt(rand.Next(0, reponses.Count)).Reponse;
            }

            return reponse;
        }

        public void AddResponse(string question, string reponse)
        {
            var list = FindAllQuestionsResponses();

            list.Add(new QuestionResponse(question, reponse));
            var convertedJson = JsonConvert.SerializeObject(list, Formatting.Indented);

            File.WriteAllText(jsonPath, convertedJson);

        }

        public void DeleteResponse(string question, string reponse)
        {
            var list = FindAllQuestionsResponses();
            QuestionResponse questionResponse = list.Where(q => q.Question == question).Where(r => r.Reponse == reponse).FirstOrDefault();
            list.RemoveAll(l=>l.Question == questionResponse.Question && l.Reponse == questionResponse.Reponse);
            var convertedJson = JsonConvert.SerializeObject(list, Formatting.Indented);

            File.WriteAllText(jsonPath, convertedJson);
        }
    }
}
