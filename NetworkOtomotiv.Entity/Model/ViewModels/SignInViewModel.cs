using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkOtomotiv.Entity.Model.ViewModels
{
    public class SignInViewModel
    {
        public string UserNameOrEmail { get; set; }
        public string Password { get; set; }
        public Boolean RememberMe { get; set; }
    }
}
