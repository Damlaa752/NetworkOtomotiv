using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkOtomotiv.Entity.Model.Entity
{
    public class BodyType : Entity
    {
        public BodyType():base()
        {
            
        }
        public BodyType(string name) : base(name)
        {
          
        }
        public List<Car> Cars { get; set; } = new List<Car>();
    }
}
