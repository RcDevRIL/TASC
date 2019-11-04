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


        //[TestMethod]
        //public void AddQuestion()
        //{
        //    string input = "test ajout question";

        //    QuestionResponse test = new QuestionResponse();

        //    test.AddQuestion(input);

        //    string response = test.GetResponse(input);

        //    Assert.IsTrue(response == "");
        //}

        //[TestMethod]
        //public void AddResponse()
        //{
        //    string input = "test ajout question";

        //    string input2 = "test modif reponse";

        //    QuestionResponse test = new QuestionResponse();

        //    test.ModifyResponse(input, input2);

        //    string response = test.GetResponse(input);

        //    Assert.IsTrue(response == input2);

        //}

        [TestMethod]
        public void AddEntry()
        {
            QuestionResponse test = new QuestionResponse();

            test.AddQuestionResponse("test to add", "response added");

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
                string input2 = "konichiwa";

                test.ModifyResponse(input, input2);
            }

            string newReponse = test.GetResponse(input);

            Assert.IsTrue(newReponse == "konichiwa");
        }
    }
}
