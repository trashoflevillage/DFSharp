using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFSharp.DiamondFire.DataStructures
{
    public class ItemStack
    {
        public string material;
        public int stackSize;

        public ItemStack(string material, int stackSize = 1) {
            this.material = material;
            this.stackSize = stackSize;
        }
    }
}
