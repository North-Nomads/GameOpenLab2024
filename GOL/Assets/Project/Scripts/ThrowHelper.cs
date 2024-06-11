using System;
using System.Diagnostics.CodeAnalysis;

namespace NorthNomads.GOL
{
    /// <summary>
    /// Represents a helper type for the exception throwing purposes.
    /// </summary>
    /// <remarks>
    /// By default, all the methods that throws exceptions can't be optimized because of the potential exceptional cases.
    /// To handle this, the <see cref="ThrowHelper"/> exception incapsulates the exception throwal and restores optimization for the caller methods.
    /// </remarks>
	public static class ThrowHelper
	{
        /// <summary>
        /// Throws a new instance of the <see cref="ArgumentException"/> exception.
        /// </summary>
        /// <param name="message">The exception message to show.</param>
        /// <exception cref="ArgumentException">An exception that is thrown from this method.</exception>
        [DoesNotReturn]
		public static void ThrowArgumentException(string message = null) 
		{
			throw new ArgumentException(message);
		}

        /// <summary>
        /// Throws a new instance of the <see cref="ArgumentException"/> exception.
        /// </summary>
        /// <typeparam name="T">Excepted type for the caller method return expression.</typeparam>
        /// <param name="message">The exception message to show.</param>
        /// <exception cref="ArgumentException">An exception that is thrown from this method.</exception>
        [DoesNotReturn]
		public static T ThrowArgumentException<T>(string message = null)
        {
			throw new ArgumentException(message);
		}

        /// <summary>
        /// Throws a new instance of the <see cref="ArgumentException"/> exception.
        /// </summary>
        /// <param name="message">The exception message to show.</param>
        /// <exception cref="ArgumentException">An exception that is thrown from this method.</exception>
        [DoesNotReturn]
		public static void ThrowArgumentException(string message, string paramName)
        {
			throw new ArgumentException(message, paramName);
		}

        /// <summary>
        /// Throws a new instance of the <see cref="ArgumentException"/> exception.
        /// </summary>
        /// <typeparam name="T">Excepted type for the caller method return expression.</typeparam>
        /// <param name="message">The exception message to show.</param>
        /// <exception cref="ArgumentException">An exception that is thrown from this method.</exception>
        [DoesNotReturn]
		public static T ThrowArgumentException<T>(string message, string paramName)
        {
			throw new ArgumentException(message, paramName);
		}

        /// <summary>
        /// Throws a new instance of the <see cref="ArgumentOutOfRangeException"/> exception.
        /// </summary>
        /// <param name="message">The exception message to show.</param>
        /// <exception cref="ArgumentOutOfRangeException">An exception that is thrown from this method.</exception>
        [DoesNotReturn]
        public static void ThrowArgumentOutOfRangeException(string message = null)
        {
            throw new ArgumentOutOfRangeException(message);
        }

        /// <summary>
        /// Throws a new instance of the <see cref="ArgumentOutOfRangeException"/> exception.
        /// </summary>
        /// <typeparam name="T">Excepted type for the caller method return expression.</typeparam>
        /// <param name="message">The exception message to show.</param>
        /// <exception cref="ArgumentOutOfRangeException">An exception that is thrown from this method.</exception>
        [DoesNotReturn]
        public static T ThrowArgumentOutOfRangeException<T>(string message = null)
        {
            throw new ArgumentOutOfRangeException(message);
        }

        /// <summary>
        /// Throws a new instance of the <see cref="ArgumentOutOfRangeException"/> exception.
        /// </summary>
        /// <param name="message">The exception message to show.</param>
        /// <exception cref="ArgumentOutOfRangeException">An exception that is thrown from this method.</exception>
        [DoesNotReturn]
        public static void ThrowArgumentOutOfRangeException(string message, string paramName)
        {
            throw new ArgumentOutOfRangeException(message, paramName);
        }

        /// <summary>
        /// Throws a new instance of the <see cref="ArgumentOutOfRangeException"/> exception.
        /// </summary>
        /// <typeparam name="T">Excepted type for the caller method return expression.</typeparam>
        /// <param name="message">The exception message to show.</param>
        /// <exception cref="ArgumentOutOfRangeException">An exception that is thrown from this method.</exception>
        [DoesNotReturn]
        public static T ThrowArgumentOutOfRangeException<T>(string message, string paramName)
        {
            throw new ArgumentOutOfRangeException(message, paramName);
        }

        /// <summary>
        /// Throws a new instance of the <see cref="ArgumentNullException"/> exception.
        /// </summary>
        /// <param name="message">The exception message to show.</param>
        /// <exception cref="ArgumentNullException">An exception that is thrown from this method.</exception>
        [DoesNotReturn]
        public static void ThrowArgumentNullException(string message = null)
        {
            throw new ArgumentNullException(message);
        }

        /// <summary>
        /// Throws a new instance of the <see cref="ArgumentNullException"/> exception.
        /// </summary>
        /// <typeparam name="T">Excepted type for the caller method return expression.</typeparam>
        /// <param name="message">The exception message to show.</param>
        /// <exception cref="ArgumentNullException">An exception that is thrown from this method.</exception>
        [DoesNotReturn]
        public static T ThrowArgumentNullException<T>(string message = null)
        {
            throw new ArgumentNullException(message);
        }

        /// <summary>
        /// Throws a new instance of the <see cref="ArgumentNullException"/> exception.
        /// </summary>
        /// <param name="message">The exception message to show.</param>
        /// <exception cref="ArgumentNullException">An exception that is thrown from this method.</exception>
        [DoesNotReturn]
        public static void ThrowArgumentNullException(string message, string paramName)
        {
            throw new ArgumentNullException(message, paramName);
        }

        /// <summary>
        /// Throws a new instance of the <see cref="ArgumentNullException"/> exception.
        /// </summary>
        /// <typeparam name="T">Excepted type for the caller method return expression.</typeparam>
        /// <param name="message">The exception message to show.</param>
        /// <exception cref="ArgumentNullException">An exception that is thrown from this method.</exception>
        [DoesNotReturn]
        public static T ThrowArgumentNullException<T>(string message, string paramName)
        {
            throw new ArgumentNullException(message, paramName);
        }

        /// <summary>
        /// Throws a new instance of the <see cref="InvalidOperationException"/> exception.
        /// </summary>
        /// <param name="message">The exception message to show.</param>
        /// <exception cref="InvalidOperationException">An exception that is thrown from this method.</exception>
        [DoesNotReturn]
        public static void ThrowInvalidOperationException(string message = null)
        {
            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Throws a new instance of the <see cref="InvalidOperationException"/> exception.
        /// </summary>
        /// <typeparam name="T">Excepted type for the caller method return expression.</typeparam>
        /// <param name="message">The exception message to show.</param>
        /// <exception cref="InvalidOperationException">An exception that is thrown from this method.</exception>
        [DoesNotReturn]
        public static T ThrowInvalidOperationException<T>(string message = null)
        {
            throw new InvalidOperationException(message);
        }
    }
}