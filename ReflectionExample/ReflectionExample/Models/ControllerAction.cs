using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReflectionExample.Models
{
    public class ControllerAction
    {
        public string Controller { get; set; }
        public string Action { get; set; }
        public string ReturnType { get; set; }
}
}