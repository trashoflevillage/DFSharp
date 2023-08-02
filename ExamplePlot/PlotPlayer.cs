using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DFSharp.DiamondFire.DataStructures;
using DFSharp.DiamondFire.ID;

namespace DFSharp.ExamplePlot
{
    internal class PlotPlayer : GlobalPlayer
    {
        public override void Join(Player defaultTarget)
        {
            defaultTarget.GiveItems(new ItemStack(MaterialID.Stone, 45));
        }

        public override void DamagePlayer(Player damager, Player victim, int damageAmount)
        {
            damager.SetEquipmentItem(new ItemStack(MaterialID.DiamondSword), EquipmentSlot.Mainhand);
        }
    }
}