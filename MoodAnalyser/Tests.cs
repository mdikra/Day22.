using System;
using System.Reflection;

namespace MoodAnalyser.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Test Case 1.1 : Given "I am in Sad mood message", Test will pass if moodAnalyser Returns "Sad"
        /// </summary>
        [Test]
        public void GivenSadMood_ShouldReturnSad()
        {
            string expected = "Sad";
            string message = "I am in Sad mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string mood = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, mood);
        }

        /// <summary>
        /// Test Case 1.2 : Given "I am in any mood message", Test will pass if moodAnalyser Returns "Happy"
        /// </summary>
        [Test]
        public void GivenAnyMood_ShouldReturnHappy()
        {
            string expected = "Happy";
            string message = "I am in any mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string mood = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, mood);
        }

        /// <summary>
        /// Test Case 2.1 : Given null , Test will pass if moodAnalyser Returns "Happy" ** THIS TEST WILL FAIL ** To understand check Test Case 2.1
        /// </summary>
        [Test]
        public void GivenNullMood_ShouldReturnHappy()
        {
            string expected = "Happy";
            string message = null;
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string mood = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, mood);
        }

        /// <summary>
        /// Test Case 3.1 : Given null , Test will pass if moodAnalyser throws MoodAnalysisException
        /// </summary>
        [Test]
        public void GivenNullMood_ShouldThrowException()
        {
            string expected = "Enetered Null, Please Enter Proper Mood";
            string message = null;
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string mood = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, mood);
        }

        /// <summary>
        /// Test Case 3.2 : Given empty message , Test will pass if moodAnalyser throws MoodAnalysisException
        /// </summary>
        [Test]
        public void GivenEmptyMood_ShouldThrowException()
        {
            string expected = "Empty message, Please enter Proper Mood";
            string message = "";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string mood = moodAnalyser.AnalyseMood();
            Assert.AreEqual(expected, mood);
        }

        /// <summary>
        /// Test Case 4.1 : Given class name , Test will pass if Mood AnalyserFactory creates object of given class name
        /// </summary>
        [Test]
        public void GivenClassName_ShouldReturnObject()
        {
            object expected = new MoodAnalyser();
            string className = "MoodAnalyser";
            MoodAnalyserFactory moodAnalyserFactory = new MoodAnalyserFactory();
            object createdObject = moodAnalyserFactory.CreateObjectUsingClass(className);
            Object.Equals(expected, createdObject);
        }

        /// <summary>
        /// Test Case 4.2 : Given class name when imporper , Test will pass if Mood AnalyserFactory throws an exception
        /// </summary>
        [Test]
        public void GivenClassName_WhenImproper_ShouldthrowException()
        {
            string expected = "No Such class exists";
            string className = "Hello";
            MoodAnalyserFactory moodAnalyserFactory = new MoodAnalyserFactory();
            object createdObject = moodAnalyserFactory.CreateObjectUsingClass(className);
            Assert.AreEqual(expected, createdObject);
        }

        /// <summary>
        /// Test Case 4.3 : Given constructor when imporper , Test will pass if Mood AnalyserFactory throws an exception
        /// </summary>
        [Test]
        public void GivenConstructor_WhenImproper_ShouldthrowException()
        {
            string expected = "No Such Method exists";
            MoodAnalyserFactory moodAnalyserFactory = new MoodAnalyserFactory();
            ConstructorInfo constructor = moodAnalyserFactory.GetConstructor(2);
            object createdObject = moodAnalyserFactory.CreateObjectUsingConstructor(constructor, 1);
            Assert.AreEqual(expected, createdObject);
        }

        /// <summary>
        /// Test Case 5.1 : Given Mood Analyser class name , Test will pass if Mood AnalyserFactory creates object of given class name of paramterized contructor
        /// </summary>
        [Test]
        public void GivenMoodAnalyser_WhenProper_ShouldReturnObject()
        {
            object expected = new MoodAnalyser("I am in happy mood");
            string className = "MoodAnalyser";
            string parameter = "I am in happy mood";
            MoodAnalyserFactory moodAnalyserFactory = new MoodAnalyserFactory();
            ConstructorInfo constructor = moodAnalyserFactory.GetConstructor(1);
            object createdObject = moodAnalyserFactory.CreateObjectUsingParameterizedConstructor(className, constructor, parameter);
            Object.Equals(expected, createdObject);
        }

        /// <summary>
        /// Test Case 5.2 : Given wrong class name , Test will pass if Mood AnalyserFactory throws exception sayinh no such class
        /// </summary>
        [Test]
        public void GivenClass_WhenImproper_ShouldThrowException()
        {
            string expected = "No such class";
            string className = "Mood";
            string parameter = "I am in happy mood";
            MoodAnalyserFactory moodAnalyserFactory = new MoodAnalyserFactory();
            ConstructorInfo constructor = moodAnalyserFactory.GetConstructor(1);
            object createdObject = moodAnalyserFactory.CreateObjectUsingParameterizedConstructor(className, constructor, parameter);
            Assert.AreEqual(expected, createdObject);
        }

        /// <summary>
        /// Test Case 5.3 : Given wrong constructor paramter , Test will pass if Mood AnalyserFactory throws exception saying no such class
        /// </summary>
        [Test]
        public void GivenConstructor_WhenImproper_ShouldThrowException()
        {
            string expected = "No such Method Found";
            string className = "MoodAnalyser";
            string parameter = "I am in happy mood";
            MoodAnalyserFactory moodAnalyserFactory = new MoodAnalyserFactory();
            ConstructorInfo constructor = moodAnalyserFactory.GetConstructor(2);
            object createdObject = moodAnalyserFactory.CreateObjectUsingParameterizedConstructor(className, constructor, parameter);
            Assert.AreEqual(expected, createdObject);
        }

        /// <summary>
        /// Test Case 6.1 : Given Happy message should return Happy
        /// </summary>
        [Test]
        public void GivenHappyMessage_WhenProper_ShouldReturnHappy()
        {
            string expected = "Happy";
            MoodAnalyserFactory moodAnalyserFactory = new MoodAnalyserFactory();
            dynamic mood = moodAnalyserFactory.InvokeMoodAnalyser("AnalyseMood", "I am in happy mood");
            Assert.AreEqual(expected, mood);
        }

        // <summary>
        /// Test Case 6.1 : Given Happy message when improper should throw exception
        /// </summary>
        [Test]
        public void GivenHappyMessage_WhenImroper_ShouldThrowException()
        {
            string expected = "Error ! Cannot invoke MoodAnalyser";
            MoodAnalyserFactory moodAnalyserFactory = new MoodAnalyserFactory();
            dynamic mood = moodAnalyserFactory.InvokeMoodAnalyser("Mood", "I am in happy mood");
            Assert.AreEqual(expected, mood);
        }
    }
}