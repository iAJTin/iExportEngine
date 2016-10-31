using System;
using System.Runtime.InteropServices;
using System.Security;

namespace iTin.Export
{
    /// <summary>
    /// Static class than contains extension methods for objects of type <see cref="System.Security.SecureString" />.
    /// </summary>
    public static class SecureStringExtensions
    {
        /// <summary>
        /// Determines whether input secure string is disposed.
        /// </summary>
        /// <param name="target">Input secure string.</param>
        /// <returns>
        /// <c>true</c> if input secure string is disposed; Otherwise <c>false</c>.
        /// </returns>
        public static bool Disposed(this SecureString target)
        {
            var disposed = false;
            try
            {
                var test = target.Length;
            }
            catch (ObjectDisposedException)
            {
                disposed = true;
            }

            return disposed;
        }

        /// <summary>
        /// Returns the value stored in the specified secure string
        /// </summary>
        /// <param name="target">Input secure string.</param>
        /// <returns>
        /// A <see cref="T:System.String"/> which contains stored value into secure string.
        /// </returns>
        public static string Value(this SecureString target)
        {
            var disposed = target.Disposed();
            if (disposed)
            {
                return null;
            }

            var pointerToTarget = Marshal.SecureStringToBSTR(target);
            var text = Marshal.PtrToStringBSTR(pointerToTarget);
            Marshal.FreeBSTR(pointerToTarget);

            return text;
        }
    }
}
