using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGoodDevelopper.Exceptions
{
    /// <summary>
    /// <c>LogNotFoundException</c> handles Log Not Found.
    /// </summary>
    internal class LogNotFoundException : FileNotFoundException
    {
        internal LogNotFoundException() : base() { }
        internal LogNotFoundException(string message) : base(message) { }
    }
}