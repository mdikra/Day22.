using System;
using System.Reflection;

namespace MoodAnalyser
{
    public class MainClass
    {
        /// <summary>
        /// main method
        /// </summary>
        /// <param name="args"> no parameters </param>
        private static void Main(string[] args) { }
    }

    public class MoodAnalyser
    {
        /// <summary>
        /// private field message
        /// </summary>
        private string _message;

        /// <summary>
        /// getter and setter property for _message
        /// </summary>
        private string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        /// <summary>
        /// default constuctor
        /// </summary>
        public MoodAnalyser() { }

        /// <summary>
        /// parametrized constructor
        /// </summary>
        /// <param name="message"> string type message </param>
        public MoodAnalyser(string message)
        {
            this.Message = message;
        }


        public string AnalyseMood()
        {
            return NewMethod();
        }

        private string NewMethod()
        {
            try
            {
                if (this.Message == null)
                    throw new MoodAnalysisException
                        ("Enetered Null, Please Enter Proper Mood");

                if (this.Message.Length == 0)
                    throw new MoodAnalysisException
                        ("Empty message, Please enter Proper Mood");

                if (this.Message.Contains("sad", StringComparison.OrdinalIgnoreCase))
                    return "Sad";
                else
                    return "Happy";
            }
            catch (MoodAnalysisException exception)
            {
                return exception.Message;
            }
        }
    }
}