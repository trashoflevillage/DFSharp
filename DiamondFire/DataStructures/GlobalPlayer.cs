using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DFSharp.DiamondFire.DataStructures
{
    public abstract class GlobalPlayer
    {
        /// <summary>
        /// Triggers when a player joins the plot.
        /// <param name="defaultTarget">The player triggering the event.</param>
        /// </summary>
        public virtual void Join(Player defaultTarget) { }
        /// <summary>
        /// Triggers when a player leaves the plot.
        /// <param name="defaultTarget">The player triggering the event.</param>
        /// </summary>
        public virtual void Leave(Player defaultTarget) { }
        /// <summary>
        /// Triggers when a player runs a command.
        /// </summary>
        /// <param name="defaultTarget">The player triggering the event.</param>
        /// <param name="command">The command being ran. Does not include the '@'.</param>
        public virtual void Command(Player defaultTarget, string command) { }
        /// <summary>
        /// Triggers when a player right click.
        /// </summary>
        /// <param name="defaultTarget">The player triggering the event.</param>
        /// <param name="loc">The location being clicked.</param>
        public virtual void RightClick(Player defaultTarget, Vector3 loc) { }
        /// <summary>
        /// Triggers when a player left clicks.
        /// </summary>
        /// <param name="defaultTarget">The player triggering the event.</param>
        /// <param name="loc">The location being clicked.</param>
        public virtual void LeftClick(Player defaultTarget, Vector3 loc) { }
        /// <summary>
        /// Triggers when a player right clicks an entity.
        /// </summary>
        /// <param name="defaultTarget">The player triggering the event.</param>
        /// <param name="entity">The entity being clicked.</param>
        public virtual void RightClickEntity(Player defaultTarget, Entity entity) { }
        /// <summary>
        /// Triggers when a player right clicks another player.
        /// </summary>
        /// <param name="defaultTarget">The player triggering the event.</param>
        /// <param name="entity">The player being clicked.</param>
        public virtual void RightClickPlayer(Player defaultTarget, Player target) { }
        /// <summary>
        /// Triggers when a player places a block.
        /// </summary>
        /// <param name="defaultTarget">The player triggering the event.</param>
        /// <param name="loc">The location of the placed block.</param>
        public virtual void PlaceBlock(Player defaultTarget, Vector3 loc) { }
        /// <summary>
        /// Triggers when a player breaks a block.
        /// </summary>
        /// <param name="defaultTarget">The player triggering the event.</param>
        /// <param name="loc">The location of the broken block.</param>
        public virtual void BreakBlock(Player defaultTarget, Vector3 loc) { }
        public virtual void SwapHands(Player defaultTarget) { }
        public virtual void ChangeSlots(Player defaultTarget) { }
        public virtual void TameMob(Player defaultTarget, Entity entity) { }
        public virtual void Walk(Player defaultTarget) { }
        public virtual void Jump(Player defaultTarget) { }
        public virtual void Sneak(Player defaultTarget) { }
        public virtual void Unsneak(Player defaultTarget) { }
        public virtual void StartSprint(Player defaultTarget) { }
        public virtual void StopSprint(Player defaultTarget) { }
        public virtual void StartFlight(Player defaultTarget) { }
        public virtual void StopFlight(Player defaultTarget) { }
        public virtual void UseRiptide(Player defaultTarget) { }
        public virtual void DismountEntity(Player defaultTarget) { }
        public virtual void HorseJump(Player defaultTarget) { }
        public virtual void VehicleJump(Player defaultTarget) { }
        public virtual void ClickMenuSlot(Player defaultTarget, ItemStack item, ItemStack newItem, int slot) { }
        public virtual void ClickInvSlot(Player defaultTarget, ItemStack item, ItemStack newItem, int slot) { }
        public virtual void PickUpItem(Player defaultTarget, ItemStack item, Entity itemEntity) { }
        public virtual void DropItem(Player defaultTarget, ItemStack item) { }
        public virtual void ConsumeItem(Player defaultTarget, ItemStack item) { }
        public virtual void BreakItem(Player defaultTarget, ItemStack item) { }
        public virtual void CloseInv(Player defaultTarget) { }
        public virtual void Fish(Player defaultTarget) { }
        public virtual void TakeDamage(Player defaultTarget, int damageAmount) { }
        public virtual void DamagePlayer(Player damager, Player victim, int damageAmount) { }
        public virtual void DamageEntity(Player damager, Entity victim, int damageAmount) { }
        public virtual void DamagePlayer(Entity damager, Player victim, int damageAmount) { }
        public virtual void Heal(Player defaultTarget, int healAmount) { }
        public virtual void ShootBow(Player defaultTarget, Entity projectile) { }
        public virtual void ShootProjectile(Player defaultTarget, Entity projectile) { }
        public virtual void ProjectileHit(Player owner, Entity projectile) { }
        public virtual void ProjectileDamagePlayer(Entity projectile, Player victim) { }
        public virtual void CloudImbue(Entity effectCloud, Player victim) { }
        public virtual void Death(Player defaultTarget) { }
        public virtual void KillPlayer(Player killer, Player victim) { }
        public virtual void KillEntity(Player killer, Entity victim) { }
        public virtual void KillPlayer(Entity killer, Player victim) { }
        public virtual void Respawn(Player defaultTarget) { }
    }
}
