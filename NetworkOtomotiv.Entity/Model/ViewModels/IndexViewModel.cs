using NetworkOtomotiv.Entity.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkOtomotiv.Entity.Model.ViewModels
{
    public class IndexViewModel
    {
        public List<BodyType> BodyTypes { get; set; } = new List<BodyType>();
        public List<Car> Cars { get; set; } = new List<Car>();
    }
}
