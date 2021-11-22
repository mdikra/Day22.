using System;
using System.Runtime.Serialization;

namespace MoodAnalyser
{
    [Serializable]
    internal class MoodAnalysisException : Exception
    {
        private object enteredNull;
        private string v;

        public MoodAnalysisException()
        {
        }

        public MoodAnalysisException(string message) : base(message)
        {
        }

        public MoodAnalysisException(object enteredNull, string v)
        {
            this.enteredNull = enteredNull;
            this.v = v;
        }

        public MoodAnalysisException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MoodAnalysisException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public static object ExceptionType { get; internal set; }
    }
}