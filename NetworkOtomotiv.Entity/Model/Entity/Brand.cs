using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkOtomotiv.Entity.Model.Entity
{
    public class Brand : Entity
    {
        public Brand():base()
        {
        }

        //public Brand(string name, /*int bodyTypeId,*/ BodyType? bodyType) :base(name)
        //{
        //    //BodyTypeId = bodyTypeId;
        //    BodyType = bodyType;
        //}
        //public int BodyTypeId { get; set; }
        //public BodyType? BodyType { get; set; }
        public Brand(string name):base()
        {
            
        }
        public List<Car> Cars { get; set; }
    }
}
