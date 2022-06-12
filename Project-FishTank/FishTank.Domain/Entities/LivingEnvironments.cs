using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTank.Domain.Entities
{
    public class LivingEnvironments
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string WaterType { get; set; }
        public ICollection<Fish> Fish { get; set; }
    }
}
