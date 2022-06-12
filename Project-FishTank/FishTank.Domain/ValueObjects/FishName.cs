using FishTank.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTank.Domain.ValueObjects
{
    public class FishName : ValueObject
    {
        public string Name { get; set; }
        public string LatinName { get; set; }

        public override string ToString()
        {
            return $"{Name} {LatinName}";
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name;
            yield return LatinName;
        }
    }
}
