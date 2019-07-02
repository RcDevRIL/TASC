using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using StupidBot.Models;

namespace StupidBot_Test
{
    [TestClass]
    public class UnitTest_Bot
    {
        List<QuestionResponse> listQuestionsReponses = new List<QuestionResponse>
        {
            new QuestionResponse() {Question = "Wesh alors ?", Reponse = "On est pas tout seul"},
            new QuestionResponse() {Question = "Wesh alors ?", Reponse = "TG Jul"},
            new QuestionResponse() {Question = "Qui es tu ?", Reponse = "Je suis le grand Manitout"},
            new QuestionResponse() {Question = "Pose moi une énigme", Reponse = "Qu'est ce qui est petit et marron ?"},
            new QuestionResponse() {Question = "Un marron", Reponse = "Putain il est fort ce con !"},
            new QuestionResponse() {Question = "Omae wa mou shinderiu", Reponse = "Nani !?"}

        };

        [TestMethod]
        public void ReadAndAnswer()
        {
            var json = JsonConvert.SerializeObject(listQuestionsReponses);

            //Debug.WriteLine(json);

            var input = "Qui es tu ?";

            QuestionResponse test = new QuestionResponse();

            string response = test.GetResponse(input);

            Assert.IsTrue(response == "Je suis le grand Manitout");
        }

        [TestMethod]
        public void AddEntry()
        {
            QuestionResponse test = new QuestionResponse();

            test.AddResponse("test to add", "response added");

            string newResponse = test.GetResponse("test to add");
            Assert.IsTrue(newResponse == "response added");
        }

        [TestMethod]
        public void DeleteEntry()
        {
            QuestionResponse test = new QuestionResponse();

            test.DeleteResponse("test to add", "response added");

            string newResponse = test.GetResponse("test to add");
            Assert.IsTrue(newResponse == "Je ne saisi pas vos insinuations...");
        }

        [TestMethod]
        public void Dialog()
        {
            QuestionResponse test = new QuestionResponse();
            string input = "guten tag";

            string response = test.GetResponse(input);

            if (response == "Je ne saisi pas vos insinuations...")
            {
                string input2 = "konichawa";

                test.AddResponse(input, input2);
            }

            string newReponse = test.GetResponse(input);

            Assert.IsTrue(newReponse == "konichawa");
        }

        [TestMethod]
        public void LoadGif()
        {

        }
    }
}
