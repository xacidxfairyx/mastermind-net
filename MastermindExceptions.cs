using System;

namespace Softklin.Mastermind
{
    /// <summary>
    /// Mastermind exception from which all other Mastermind related exceptions inherit
    /// </summary>
    [Serializable]
    public class MastermindException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the MastermindException class.
        /// </summary>
        public MastermindException() { }
        /// <summary>
        /// Initializes a new instance of the MastermindException class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public MastermindException(string message) : base(message) { }
        /// <summary>
        /// Initializes a new instance of the MastermindException class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="inner">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified. </param>
        public MastermindException(string message, Exception inner) : base(message, inner) { }
        /// <summary>
        /// Initializes a new instance of the MastermindException class with serialized data.
        /// </summary>
        /// <param name="info">The SerializationInfo that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The StreamingContext that contains contextual information about the source or destination.</param>
        protected MastermindException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

    /// <summary>
    /// Exceptions related with the Board Class
    /// </summary>
    [Serializable]
    public class MastermindBoardException : MastermindException
    {   
        /// <summary>
        /// Initializes a new instance of the MastermindBoardException class.
        /// </summary>
        public MastermindBoardException() { }
        /// <summary>
        /// Initializes a new instance of the MastermindBoardException class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public MastermindBoardException(string message) : base(message) { }
        /// <summary>
        /// Initializes a new instance of the MastermindBoardException class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="inner">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified. </param>
        public MastermindBoardException(string message, Exception inner) : base(message, inner) { }
        /// <summary>
        /// Initializes a new instance of the MastermindBoardException class with serialized data.
        /// </summary>
        /// <param name="info">The SerializationInfo that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The StreamingContext that contains contextual information about the source or destination.</param>
        protected MastermindBoardException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }


    /// <summary>
    /// Exceptions related with the MastermindGame Class
    /// </summary>
    [Serializable]
    public class MastermindGameException : MastermindException
    {
        /// <summary>
        /// Initializes a new instance of the MastermindGameException class.
        /// </summary>
        public MastermindGameException() { }
        /// <summary>
        /// Initializes a new instance of the MastermindGameException class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public MastermindGameException(string message) : base(message) { }
        /// <summary>
        /// Initializes a new instance of the MastermindGameException class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="inner">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified. </param>
        public MastermindGameException(string message, Exception inner) : base(message, inner) { }
        /// <summary>
        /// Initializes a new instance of the MastermindGameException class with serialized data.
        /// </summary>
        /// <param name="info">The SerializationInfo that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The StreamingContext that contains contextual information about the source or destination.</param>
        protected MastermindGameException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }


    /// <summary>
    /// Exception realted with ColoredPegRow Class
    /// </summary>
    [Serializable]
    public class MastermindColoredPegRowException : MastermindException
    {
        /// <summary>
        /// Initializes a new instance of the MastermindColoredPegRowException class.
        /// </summary>
        public MastermindColoredPegRowException() { }
        /// <summary>
        /// Initializes a new instance of the MastermindColoredPegRowException class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public MastermindColoredPegRowException(string message) : base(message) { }
        /// <summary>
        /// Initializes a new instance of the MastermindColoredPegRowException class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="inner">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified. </param>
        public MastermindColoredPegRowException(string message, Exception inner) : base(message, inner) { }
        /// <summary>
        /// Initializes a new instance of the MastermindColoredPegRowException class with serialized data.
        /// </summary>
        /// <param name="info">The SerializationInfo that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The StreamingContext that contains contextual information about the source or destination.</param>
        protected MastermindColoredPegRowException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }


    /// <summary>
    /// Exceptions related with the Player Class
    /// </summary>
    [Serializable]
    public class MastermindPlayerException : MastermindException
    {
        /// <summary>
        /// Initializes a new instance of the MastermindPlayerException class.
        /// </summary>
        public MastermindPlayerException() { }
        /// <summary>
        /// Initializes a new instance of the MastermindPlayerException class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public MastermindPlayerException(string message) : base(message) { }
        /// <summary>
        /// Initializes a new instance of the MastermindPlayerException class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="inner">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified. </param>
        public MastermindPlayerException(string message, Exception inner) : base(message, inner) { }
        /// <summary>
        /// Initializes a new instance of the MastermindPlayerException class with serialized data.
        /// </summary>
        /// <param name="info">The SerializationInfo that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The StreamingContext that contains contextual information about the source or destination.</param>
        protected MastermindPlayerException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }


    /// <summary>
    /// Exceptions related with the ScoreCard Class
    /// </summary>
    [Serializable]
    public class MastermindScoreCardException : MastermindException
    {
        /// <summary>
        /// Initializes a new instance of the MastermindScoreCardException class.
        /// </summary>
        public MastermindScoreCardException() { }
        /// <summary>
        /// Initializes a new instance of the MastermindScoreCardException class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public MastermindScoreCardException(string message) : base(message) { }
        /// <summary>
        /// Initializes a new instance of the MastermindScoreCardException class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="inner">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified. </param>
        public MastermindScoreCardException(string message, Exception inner) : base(message, inner) { }
        /// <summary>
        /// Initializes a new instance of the MastermindScoreCardException class with serialized data.
        /// </summary>
        /// <param name="info">The SerializationInfo that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The StreamingContext that contains contextual information about the source or destination.</param>
        protected MastermindScoreCardException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
