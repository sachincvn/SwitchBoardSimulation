using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SwitchBoard
{
    internal class Appliance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public Appliance(int id, string name, bool status)
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
        }
    }
}
