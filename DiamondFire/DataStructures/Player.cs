using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DFSharp.DiamondFire.DataStructures
{
    public class Player
    {
        readonly public int maxHealth;
        readonly public int health;
        readonly public int absorption;
        readonly public int hunger;
        readonly public int saturation;
        readonly public int exhaustion;
        readonly public int attackDamage;
        readonly public int attackSpeed;
        readonly public int armor;
        readonly public int armorToughness;
        readonly public int invulnerabilityTicks;
        readonly public int level;
        readonly public int levelProgress;
        readonly public int fireTicks;
        readonly public int freezeTicks;
        readonly public int air;
        readonly public float fallDistance;
        readonly public int heldSlot;
        readonly public int ping;
        readonly public float steerSidewaysMovement;
        readonly public float steerForwardsMovement;
        readonly public float itemUsageProgress;
        readonly public string username;
        readonly public string uuid;

        /// <summary>
        /// Gives the player an itemstack.
        /// </summary>
        /// <param name="item">Item(s) to give.</param>
        public void GiveItems(ItemStack item) { }
        /// <summary>
        /// Sets a slot in the player's inventory.
        /// </summary>
        /// <param name="item">Item to set slot to.</param>
        /// <param name="slot">The slot to set.</param>
        public void SetItemInSlot(ItemStack item, int slot) { }
        /// <summary>
        /// Sets an equipment slot in the player's inventory.
        /// Use the EquipmentSlot enum to define the slot.
        /// </summary>
        /// <param name="item">Item to set slot to.</param>
        /// <param name="slot">The equipment slot to set.</param>
        public void SetEquipmentItem(ItemStack item, EquipmentSlot slot) { }
        public void ReplaceItems(ItemStack replace, ItemStack replaceWith) { }
        public void ReplaceItems(ItemStack replace, ItemStack replaceWith, int amount) { }
        public void RemoveItem(ItemStack item) { }
        public void ClearItem(ItemStack item) { }
        public void ClearInv() { }
        public void SetCursorItem(ItemStack item) { }
        public void SaveInv() { }
        public void LoadInv() { }
        public void SetItemCooldown(string material, int cooldown) { }
    }

    public enum EquipmentSlot
    {
        Mainhand,
        Offhand,
        Head,
        Chest,
        Legs,
        Feet
    }
}
