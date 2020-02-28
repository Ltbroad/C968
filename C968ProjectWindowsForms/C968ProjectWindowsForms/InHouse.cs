using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968ProjectWindowsForms
{
    public class InHouse : Part
    {
        private int machineID;
        public new int MachineID
        {
            get
            {
                return machineID;
            }
            set
            {
                machineID = value;
            }
        }
        public InHouse(int partID, string name, decimal price, int inStock, int min, int max)
            : base (partID, name, price, inStock, min, max)
        {
            
        }

        public InHouse(int partID, string name, decimal price, int inStock, int max, int min, int machineID)
            : base (partID, name, price, inStock, max, min, machineID)
        {
            isOutsourced = false;
        }

        public InHouse() { }
    }
}
