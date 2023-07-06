using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carniceria
{
    public class BDExcepciones : Exception
    {
        public List<Exception> InnerExceptions { get; }

        public BDExcepciones(string message, List<Exception> innerExceptions) : base(message)
        {
            InnerExceptions = innerExceptions;
        }

    }

    public class ArchivosExcepciones : Exception
    {
        public List<Exception> InnerExceptions { get; }

        public ArchivosExcepciones(string message, List<Exception> innerExceptions) : base(message)
        {
            InnerExceptions = innerExceptions;
        }

    }
}
