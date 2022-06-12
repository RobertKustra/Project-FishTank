using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTank.Domain.Exceptions
{
    internal class FishException : Exception
    {
        public FishException(string fishname, Exception e) : base($"Your Fish\"{ fishname }\" has died. Shame of you.", e)
        {

        }
    }
}
