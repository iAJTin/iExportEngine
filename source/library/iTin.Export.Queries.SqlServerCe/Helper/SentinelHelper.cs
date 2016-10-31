using System;
using System.Diagnostics;

namespace iTin.Export.Queries.SqlServerCe
{
    /// <summary>
    /// Static class than contains methods for perform tests and validate data types and parameters.
    /// <para><strong>- Warning -</strong></para>
    /// This class is temporary and will be replaced in future versions by using <a href="http://research.microsoft.com/en-us/projects/contracts/">code contracts</a>, 
    /// obtaining the same results, but with type checking at compile time (if an exception may occur 
    /// at runtime will not compile the application) while avoiding possible exceptions in run time.    
    /// </summary>
    public static class SentinelHelper
    {
        /// <summary>
        /// Performs a test on the method argument, and throws an exception of type <exception cref="ArgumentNullException" /> if is <strong>null</strong>.
        /// </summary>
        /// <typeparam name="T">Type of the argument to be checked</typeparam>
        /// <param name="argument">Argument value.</param>
        public static void ArgumentNull<T>(T argument) where T : class
        {
            ArgumentNull(argument, string.Empty);
        }

        /// <summary>
        /// Performs a test on the method argument, and throws an exception of type <exception cref="ArgumentNullException" /> with specified error message if is <strong>null</strong>.
        /// </summary>
        /// <typeparam name="T">Type of the argument to be checked</typeparam>
        /// <param name="argument">Argument value.</param>
        /// <param name="message">Error message.</param>
        /// <exception cref="System.ArgumentNullException">If <paramref name="argument" /> is <strong>null</strong>.</exception>
        public static void ArgumentNull<T>(T argument, string message) where T : class
        {
            if (argument == null)
            {
                if (string.IsNullOrEmpty(message))
                {
                    throw new ArgumentNullException("argument");
                }

                throw new ArgumentNullException("argument", message);
            }
        }

        /// <summary>
        /// Performs a test on the method argument, and throws an exception of type <exception cref="ArgumentOutOfRangeException" /> if less than the specified threshold.
        /// </summary>
        /// <typeparam name="T">Type of the argument to be checked.</typeparam>
        /// <param name="parameter">Parameter name.</param>
        /// <param name="argument">Argument value.</param>
        /// <param name="threshold">Threshold value.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">If <paramref name="argument" /> is less than the specified threshold.</exception>
        /// <remarks>
        /// The value of the <paramref name="argument" /> must be greater or equal to the threshold indicated.
        /// </remarks>
        [Conditional("DEBUG")]
        public static void ArgumentLessThan<T>(string parameter, T argument, T threshold) where T : IComparable<T>
        {
            if (argument.CompareTo(threshold) < 0)
            {
                throw new ArgumentOutOfRangeException(parameter);
            }
        }

        /// <summary>
        /// Performs a test on the method argument, and throws an exception of type <exception cref="ArgumentOutOfRangeException" /> if greater than the specified threshold.
        /// </summary>
        /// <typeparam name="T">Type of the argument to be checked.</typeparam>
        /// <param name="parameter">Parameter name.</param>
        /// <param name="argument">Argument value.</param>
        /// <param name="threshold">Threshold value.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">If <paramref name="argument" /> is greater than the specified threshold.</exception>
        /// <remarks>
        /// The argument value must be less than or equal to the specified threshold.
        /// </remarks>
        [Conditional("DEBUG")]
        public static void ArgumentGreaterThan<T>(string parameter, T argument, T threshold) where T : IComparable<T>
        {
            if (argument.CompareTo(threshold) > 0)
            {
                throw new ArgumentOutOfRangeException(parameter);
            }
        }

        /// <summary>
        /// Performs a test on the method argument, and throws an exception of type <exception cref="ArgumentOutOfRangeException" />
        /// if is over the maximum specified, or is less than the specified minimum value.
        /// </summary>
        /// <typeparam name="T">Type of the argument to be checked.</typeparam>
        /// <param name="parameter">Parameter name.</param>
        /// <param name="argument">Argument value.</param>
        /// <param name="min">Value Minimum permitted.</param>
        /// <param name="max">Value Maximum permitted.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">If <paramref name="argument" /> is over the maximum specified, or is less than the specified minimum value.</exception>
        [Conditional("DEBUG")]
        public static void ArgumentOutOfRange<T>(string parameter, T argument, T min, T max) where T : IComparable<T>
        {
            ArgumentOutOfRange(parameter, argument, min, max, string.Empty);
        }

        /// <summary>
        /// Performs a test on the method argument, and throws an exception of type <exception cref="ArgumentOutOfRangeException" />
        /// if is over the maximum specified, or is less than the specified minimum value.
        /// </summary>
        /// <typeparam name="T">Type of the argument to be checked.</typeparam>
        /// <param name="parameter">Parameter name.</param>
        /// <param name="argument">Argument value.</param>
        /// <param name="min">Value Minimum permitted.</param>
        /// <param name="max">Value Maximum permitted.</param>
        /// <param name="message">Error message.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">If <paramref name="argument" /> is over the maximum specified, or is less than the specified minimum value.</exception>
        [Conditional("DEBUG")]
        public static void ArgumentOutOfRange<T>(string parameter, T argument, T min, T max, string message) where T : IComparable<T>
        {
            if ((argument.CompareTo(min) >= 0) && (argument.CompareTo(max) <= 0))
            {
                return;
            }

            if (string.IsNullOrEmpty(message))
            {
                throw new ArgumentOutOfRangeException(parameter);
            }

            throw new ArgumentOutOfRangeException(parameter, message);
        }

        /// <summary>
        /// Performs a test on the method argument, and throws an exception of type <exception cref="InvalidOperationException" /> if the specified expression is <strong>false</strong>.
        /// </summary>
        /// <param name="expression">Expression to evaluate.</param>
        /// <exception cref="System.InvalidOperationException">If the result is <strong>false</strong></exception>
        [Conditional("DEBUG")]
        public static void IsFalse(bool expression)
        {
            IsFalse(expression, string.Empty);
        }

        /// <summary>
        /// Performs a test on the method argument, and throws an exception of type <exception cref="InvalidOperationException" /> if the specified expression is <strong>false</strong>.
        /// </summary>
        /// <param name="expression">Expression to evaluate.</param>
        /// <param name="message">Error message.</param>
        /// <exception cref="System.InvalidOperationException">If the result is <strong>false</strong></exception>
        [Conditional("DEBUG")]
        public static void IsFalse(bool expression, string message)
        {
            if (expression)
            {
                return;
            }

            if (string.IsNullOrEmpty(message))
            {
                throw new InvalidOperationException();
            }

            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Performs a test on the method argument, and throws an specified exception if the specified expression is <strong>false</strong>.
        /// </summary>
        /// <param name="expression">Expression to evaluate.</param>
        /// <param name="exception">Error message.</param>
        /// <exception cref="System.InvalidOperationException">If the <paramref name="exception"/> is <strong>null</strong>.</exception>
        [Conditional("DEBUG")]
        public static void IsFalse(bool expression, Exception exception)
        {
            if (expression)
            {
                return;
            }

            if (exception == null)
            {
                throw new InvalidOperationException();
            }

            throw exception;
        }

        /// <summary>
        /// Performs a test on the method argument, and throws an exception of type <exception cref="InvalidOperationException" /> if the specified expression is <strong>true</strong>.
        /// </summary>
        /// <param name="expression">Expression to evaluate.</param>
        /// <exception cref="System.InvalidOperationException">If the result is <strong>true</strong></exception>
        [Conditional("DEBUG")]
        public static void IsTrue(bool expression)
        {
            IsTrue(expression, string.Empty);
        }

        /// <summary>
        /// Performs a test on the method argument, and throws an exception of type <exception cref="InvalidOperationException" /> if the specified expression is <strong>true</strong>.
        /// </summary>
        /// <param name="expression">Expression to evaluate.</param>
        /// <param name="message">Error message.</param>
        /// <exception cref="System.InvalidOperationException">If the result is <strong>true</strong></exception>
        [Conditional("DEBUG")]
        public static void IsTrue(bool expression, string message)
        {
            if (!expression)
            {
                return;
            }

            if (string.IsNullOrEmpty(message))
            {
                throw new InvalidOperationException();
            }
         
            throw new InvalidOperationException(message);
        }

        /// <summary>
        /// Performs a test on the method argument, and throws an specified exception if the specified expression is <strong>true</strong>.
        /// </summary>
        /// <param name="expression">Expression to evaluate.</param>
        /// <param name="exception">Error message.</param>
        /// <exception cref="System.InvalidOperationException">If the <paramref name="exception"/> is <strong>null</strong>.</exception>
        [Conditional("DEBUG")]
        public static void IsTrue(bool expression, Exception exception)
        {
            if (!expression)
            {
                return;
            }

            if (exception == null)
            {
                throw new InvalidOperationException();
            }

            throw exception;
        }

        /// <summary>
        /// Performs a test on the method argument, if not null is returned, otherwise throws an <exception cref="ArgumentNullException" /> type.
        /// </summary>
        /// <typeparam name="T">Type of the argument to be checked</typeparam>
        /// <param name="argument">Argument value.</param>
        /// <returns>
        /// Original object.
        /// </returns>
        public static T PassThroughNonNull<T>(T argument) where T : class
        {
            ArgumentNull(argument);
            return argument;
        }
    }
}
