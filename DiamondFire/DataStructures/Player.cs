using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
        readonly public string username = "Player";
        readonly public string uuid = "PlayerUUID";
        /// <summary>
        /// Sets items in a player's hotbar.
        /// </summary>
        /// <param name="item">Item(s) to set</param>
        public void SetHotbar(ItemStack item) { }

        /// <summary>
        /// When enabled, a player won't be able to see their coordinates, block info, or other info.
        /// </summary>
        public void SetReducedDebug() { }

        /// <summary>
        /// Closes a player's inventory.
        /// </summary>
        public void CloseInv() { }

        /// <summary>
        /// Gives a player all of the items in the chest.
        /// </summary>
        /// <param name="item">Item(s) to give</param>
        /// <param name="num">Amount to give</param>
        public void GiveItems(ItemStack item, double num = 1) { }

        /// <summary>
        ///
        /// </summary>
        public void NoKeepInv() { }

        /// <summary>
        /// Creates or modifies a custom boss health bar at the top of a player's screen.
        /// </summary>
        /// <param name="text">Title</param>
        /// <param name="num">Current health</param>
        /// <param name="num2">Maximum health</param>
        public void BossBar(string text, double num, double num2) { }

        /// <summary>
        /// Displays a sphere of particles at a location to a player.
        /// </summary>
        /// <param name="particle">Effect</param>
        /// <param name="loc">Center location</param>
        /// <param name="num">Diameter</param>
        public void ParticleSphere(Particle particle, Vector3 loc, double num) { }

        /// <summary>
        /// Sets a player's attack speed.
        /// </summary>
        /// <param name="num">Attack speed</param>
        public void SetAtkSpeed(double num) { }

        /// <summary>
        /// Sets a player's movement velocity.
        /// </summary>
        /// <param name="vec">New velocity</param>
        public void SetVelocity(Vector3 vec) { }

        /// <summary>
        /// Displays a particle effect to a player.
        /// </summary>
        /// <param name="particle">Effect</param>
        /// <param name="loc">Effect location</param>
        public void Particle(Particle particle, Vector3 loc) { }

        /// <summary>
        /// Adds a row to the bottom of a player's current inventory menu.
        /// </summary>
        /// <param name="item">Items to display</param>
        public void AddInvRow(ItemStack item) { }

        /// <summary>
        ///
        /// </summary>
        public void DisablePvp() { }

        /// <summary>
        ///
        /// </summary>
        public void NoNatRegen() { }

        /// <summary>
        /// Displays a silent lightning strike effect to a player.
        /// </summary>
        /// <param name="loc">Strike location</param>
        public void DisplayLightning(Vector3 loc) { }

        /// <summary>
        ///
        /// </summary>
        public void ReplaceProj() { }

        /// <summary>
        /// Damages a player.
        /// </summary>
        /// <param name="num">Damage to inflict</param>
        /// <param name="text">Damage source</param>
        public void Damage(double num, string text) { }

        /// <summary>
        /// Sets a player's experience level, points or progress.
        /// </summary>
        /// <param name="num">Experience to set</param>
        public void SetExp(double num) { }

        /// <summary>
        /// Makes a player perform an animation.
        /// </summary>
        public void SendAnimation() { }

        /// <summary>
        /// Sets the XP progress bar to a certain percentage.
        /// </summary>
        /// <param name="num">Progress % (0-100)</param>
        public void SetXPProg(double num) { }

        /// <summary>
        /// Sets items in a player's upper inventory.
        /// </summary>
        /// <param name="item">Item(s) to set</param>
        public void SetInventory(ItemStack item) { }

        /// <summary>
        /// Teleports a player to multiple locations, with a delay between each teleport.
        /// </summary>
        /// <param name="loc">Locations toteleport to</param>
        /// <param name="num">Teleport delay (ticks,default = 60)</param>
        public void TpSequence(Vector3 loc, double num) { }

        /// <summary>
        /// Restores a player's health.
        /// </summary>
        /// <param name="num">Amount to heal</param>
        public void Heal(double num) { }

        /// <summary>
        /// Restores a player's health.
        /// </summary>
        /// <param name="">Heals to full health</param>
        public void Heal() { }

        /// <summary>
        /// Sets the location a player will spawn when they die and respawn.
        /// </summary>
        /// <param name="loc">The new spawn location</param>
        public void SetSpawnPoint(Vector3 loc) { }

        /// <summary>
        /// Sets the location a player will spawn when they die and respawn.
        /// </summary>
        /// <param name="">Plot spawn)</param>
        public void SetSpawnPoint() { }

        /// <summary>
        /// Displays a spiral of particles at a location to a player.
        /// </summary>
        /// <param name="particle">Effect</param>
        /// <param name="loc">Base location</param>
        /// <param name="num">Length</param>
        /// <param name="num2">Diameter</param>
        /// <param name="num3">Effect count</param>
        /// <param name="num4">Rotations</param>
        public void ParticleSpiral(Particle particle, Vector3 loc, double num, double num2, double num3, double num4) { }

        /// <summary>
        /// Sets whether a player's inventory is kept after death.
        /// </summary>
        public void SetInventoryKept() { }

        /// <summary>
        /// Sets whether a player is able to enter and exit flight mode by double tapping jump.
        /// </summary>
        public void SetAllowFlight() { }

        /// <summary>
        /// Launches a player up or down.
        /// </summary>
        /// <param name="num">Launch power</param>
        public void LaunchUp(double num) { }

        /// <summary>
        /// Sets a player's maximum health.
        /// </summary>
        /// <param name="num">Maximum health</param>
        public void SetMaxHealth(double num) { }

        /// <summary>
        /// Removes a boss health bar from a player's screen.
        /// </summary>
        /// <param name="num">Boss bar position</param>
        public void RemoveBossBar(double num) { }

        /// <summary>
        ///
        /// </summary>
        /// <param name="">Removes all boss bars)</param>
        public void GetTargetEntity() { }

        /// <summary>
        /// Sets a player's game mode to Adventure.
        /// </summary>
        /// <param name="">Removes all boss bars)</param>
        public void AdventureMode() { }

        /// <summary>
        /// Forces a player to start or stop flying.
        /// </summary>
        /// <param name="">Removes all boss bars)</param>
        public void ForceFlight() { }

        /// <summary>
        /// Loads a player's inventory.
        /// </summary>
        /// <param name="">Removes all boss bars)</param>
        public void LoadInv() { }

        /// <summary>
        /// Sets a player's game mode to Spectator.
        /// </summary>
        /// <param name="">Removes all boss bars)</param>
        public void SpectatorMode() { }

        /// <summary>
        /// Removes all active potion effects from a player.
        /// </summary>
        /// <param name="">Removes all boss bars)</param>
        public void ClearPotions() { }

        /// <summary>
        /// Kicks a player from the plot.
        /// </summary>
        /// <param name="">Removes all boss bars)</param>
        public void Kick() { }

        /// <summary>
        /// Sets the text to be displayed above or below a player's player list shown when pressing Tab.
        /// </summary>
        /// <param name="text">Header/footer text</param>
        public void SetTabListInfo(string text) { }

        /// <summary>
        ///
        /// </summary>
        public void EnablePvp() { }

        /// <summary>
        ///
        /// </summary>
        public void ProjColl() { }

        /// <summary>
        ///
        /// </summary>
        public void HideDisguise() { }

        /// <summary>
        /// Makes a player spectate another player or entity.
        /// </summary>
        /// <param name="text">Target UUID</param>
        public void SpectateTarget(string text) { }

        /// <summary>
        /// Sets a player's game mode to Survival.
        /// </summary>
        /// <param name="">Stops spectating</param>
        public void SurvivalMode() { }

        /// <summary>
        /// Creates or modifies a custom boss health bar at the top of a player's screen.
        /// </summary>
        /// <param name="text">Title</param>
        /// <param name="num">Current health</param>
        /// <param name="num2">Maximum health</param>
        /// <param name="num3">Boss bar position</param>
        public void SetBossBar(string text, double num, double num2, double num3) { }

        /// <summary>
        /// Sets the player's skin.
        /// </summary>
        /// <param name="item">Player head</param>
        public void SetSkin(ItemStack item) { }

        /// <summary>
        /// Sets the player's game status, which is used to display information about what the player is doing in the game.
        /// </summary>
        /// <param name="text">Game Status</param>
        public void SetStatus(string text) { }

        /// <summary>
        /// Sets the currently remaining ticks until a player can next be hurt.
        /// </summary>
        /// <param name="num">Ticks</param>
        public void SetInvulTicks(double num) { }

        /// <summary>
        /// Sets the item on a player's cursor.
        /// </summary>
        /// <param name="item">Item to set</param>
        public void SetCursorItem(ItemStack item) { }

        /// <summary>
        /// Sets a player's absorption health (golden hearts).
        /// </summary>
        /// <param name="num">Absorption health</param>
        public void SetAbsorption(double num) { }

        /// <summary>
        /// Sets the remaining time a player is on fire for.
        /// </summary>
        /// <param name="num">Ticks</param>
        public void SetFireTicks(double num) { }

        /// <summary>
        ///
        /// </summary>
        public void SetGamemode() { }

        /// <summary>
        /// Removes the given number of rows from the bottom of a player's current inventory menu.
        /// </summary>
        /// <param name="num">Rows to remove</param>
        public void RemoveInvRow(double num) { }

        /// <summary>
        ///
        /// </summary>
        public void EnableFlight() { }

        /// <summary>
        /// Prevents a player from placing and breaking certain blocks.
        /// </summary>
        /// <param name="block">Blocks to disallow</param>
        public void DisableBlocks(Block block) { }

        /// <summary>
        ///
        /// </summary>
        public void LSetHealth() { }

        /// <summary>
        ///
        /// </summary>
        public void ParticleEffect() { }

        /// <summary>
        /// Empties a player's inventory.
        /// </summary>
        public void ClearInv() { }

        /// <summary>
        /// Sets the player's current freeze ticks
        /// </summary>
        /// <param name="num">Ticks</param>
        public void SetFreezeTicks(double num) { }

        /// <summary>
        /// Sets whether a player is gliding with elytra.
        /// </summary>
        public void SetGliding() { }

        /// <summary>
        /// Changes a player's pitch and yaw.
        /// </summary>
        /// <param name="num">Pitch (-90 to 90)</param>
        /// <param name="num2">Yaw (-180 to 180)</param>
        public void SetRotation(double num, double num2) { }

        /// <summary>
        ///
        /// </summary>
        public void DisallowDrops() { }

        /// <summary>
        /// Displays a circle of particles to a player.
        /// </summary>
        /// <param name="particle">Effect</param>
        /// <param name="loc">Center location</param>
        /// <param name="num">Diameter</param>
        public void ParticleCircle(Particle particle, Vector3 loc, double num) { }

        /// <summary>
        /// Removes all of an item from a player.
        /// </summary>
        /// <param name="item">Item(s) to clear</param>
        public void ClearItems(ItemStack item) { }

        /// <summary>
        /// Displays a block at a location to a player.
        /// </summary>
        /// <param name="block">Block to display</param>
        /// <param name="loc">Block location,or start of region</param>
        /// <param name="loc2">End of region</param>
        /// <param name="blockTag">Block data</param>
        public void DisplayBlock(Block block, Vector3 loc, Vector3 loc2, BlockTag blockTag) { }

        /// <summary>
        /// Mounts a player on top of another player or entity.
        /// </summary>
        /// <param name="text">Name or UUID oftarget to ride</param>
        public void RideEntity(string text) { }

        /// <summary>
        ///
        /// </summary>
        /// <param name="">Dismounts player</param>
        public void WeatherRain() { }

        /// <summary>
        /// Sets whether a player is flying.
        /// </summary>
        /// <param name="">Dismounts player</param>
        public void SetFlying() { }

        /// <summary>
        /// Removes a player's world border.
        /// </summary>
        /// <param name="">Dismounts player</param>
        public void RmWorldBorder() { }

        /// <summary>
        /// Displays a container block at a location as being open or closed to a player.
        /// </summary>
        /// <param name="loc">Block location</param>
        public void DisplayBlockOpen(Vector3 loc) { }

        /// <summary>
        ///
        /// </summary>
        public void SetHandItem() { }

        /// <summary>
        /// Displays a custom advancement popup to a player.
        /// </summary>
        /// <param name="text">Advancement name</param>
        /// <param name="item">Advancement icon</param>
        public void SendAdvancement(string text, ItemStack item) { }

        /// <summary>
        /// Teleports a player to a location.
        /// </summary>
        /// <param name="loc">New position</param>
        public void Teleport(Vector3 loc) { }

        /// <summary>
        ///
        /// </summary>
        public void ClearChat() { }

        /// <summary>
        /// Sets whether a player can hurt or be hurt by other players.
        /// </summary>
        public void SetAllowPVP() { }

        /// <summary>
        /// Sets the item in a slot of a player's current inventory menu.
        /// </summary>
        /// <param name="num">Slot</param>
        /// <param name="item">Item to set</param>
        public void SetMenuItem(double num, ItemStack item) { }

        /// <summary>
        /// Launches a player toward or away from a location.
        /// </summary>
        /// <param name="loc">Launch destination</param>
        /// <param name="num">Launch power</param>
        public void LaunchToward(Vector3 loc, double num) { }

        /// <summary>
        /// Sets a player's armor items. Place the armor in slots 1-4 of the chest, with 1 being the helmet and 4 being the boots.
        /// </summary>
        /// <param name="item">Armor to set</param>
        public void SetArmor(ItemStack item) { }

        /// <summary>
        /// Displays a vertical beam on an end gateway to a player.
        /// </summary>
        /// <param name="loc">Gateway location</param>
        public void DisplayGateway(Vector3 loc) { }

        /// <summary>
        ///
        /// </summary>
        public void DisableFlight() { }

        /// <summary>
        /// Sets a player's ability to see their own disguise. It is recommended that it is almost always hidden.
        /// </summary>
        public void SetDisguiseVisible() { }

        /// <summary>
        /// Sets the amount of arrows sticking out of a player's character model.
        /// </summary>
        /// <param name="num">Arrow Count</param>
        public void SetArrowsStuck(double num) { }

        /// <summary>
        /// Adds experience points or levels to a player.
        /// </summary>
        /// <param name="num">Experience to give</param>
        public void GiveExp(double num) { }

        /// <summary>
        /// Rotates a player to look toward a location without teleporting them.
        /// </summary>
        /// <param name="loc">Location to face</param>
        public void FaceLocation(Vector3 loc) { }

        /// <summary>
        ///
        /// </summary>
        public void SetItems() { }

        /// <summary>
        ///
        /// </summary>
        public void KeepInv() { }

        /// <summary>
        /// Replaces items in a player's inventory with the given item.
        /// </summary>
        /// <param name="item">Item(s) to replace</param>
        /// <param name="item2">Item to replace with</param>
        /// <param name="num">Amount of items toreplace</param>
        public void ReplaceItems(ItemStack item, ItemStack item2, double num) { }

        /// <summary>
        /// Displays text directly above a player's hotbar.
        /// </summary>
        /// <param name="text">Message to send</param>
        public void ActionBar(string text) { }

        /// <summary>
        /// Sets a player's chat tag.
        /// </summary>
        /// <param name="text">Chat tag</param>
        public void SetChatTag(string text) { }

        /// <summary>
        /// Sends a chat message to a player.
        /// </summary>
        /// <param name="text">Message to send</param>
        public void SendMessage(string text) { }

        /// <summary>
        /// Changes a player's world border size if they have one active.
        /// </summary>
        /// <param name="num">New radius</param>
        /// <param name="num2">Blocks per second</param>
        public void ShiftWorldBorder(double num, double num2) { }

        /// <summary>
        /// Sets the item in a slot of a player's inventory.
        /// </summary>
        /// <param name="item">Item to set</param>
        /// <param name="num">Slot to set</param>
        public void SetSlotItem(ItemStack item, double num) { }

        /// <summary>
        /// Plays a sequence of sounds to a player, with a delay between each sound.
        /// </summary>
        /// <param name="sound">Sounds to play</param>
        /// <param name="num">Sound delay (ticks,default = 60)</param>
        /// <param name="loc">Playback location</param>
        public void PlaySoundSeq(Sound sound, double num, Vector3 loc) { }

        /// <summary>
        /// Displays an animated line of particles between two locations to a player.
        /// </summary>
        /// <param name="particle">Effect</param>
        /// <param name="loc">Start location</param>
        /// <param name="loc2">End location</param>
        /// <param name="num">Effect spacing</param>
        /// <param name="num2">Animation duration</param>
        public void ParticleLineA(Particle particle, Vector3 loc, Vector3 loc2, double num, double num2) { }

        /// <summary>
        /// Displays text on a sign to a player.
        /// </summary>
        /// <param name="loc">Sign location</param>
        /// <param name="text">Text line(s)</param>
        public void DisplaySignText(Vector3 loc, string text) { }

        /// <summary>
        ///
        /// </summary>
        public void Respawn() { }

        /// <summary>
        /// Sets a player's walking and/or flight speed.
        /// </summary>
        /// <param name="num">Movement speedpercentage (0% to 1000%)</param>
        public void SetSpeed(double num) { }

        /// <summary>
        /// Adds 3 more rows to a player's current inventory menu using the contents of the chest.
        /// </summary>
        /// <param name="item">Items to display</param>
        public void ExpandInv(ItemStack item) { }

        /// <summary>
        /// Renames a player's current inventory menu.
        /// </summary>
        /// <param name="text">Inventory name</param>
        public void SetInvName(string text) { }

        /// <summary>
        /// Launches a projectile from a player.
        /// </summary>
        /// <param name="proj">Projectile tolaunch</param>
        /// <param name="loc">Launch point</param>
        /// <param name="text">Projectile name</param>
        /// <param name="num">Speed</param>
        /// <param name="num2">Inaccuracy</param>
        public void LaunchProj(Projectile proj, Vector3 loc, string text, double num, double num2) { }

        /// <summary>
        /// Applies a cooldown visual effect to an item type.
        /// </summary>
        /// <param name="item">Item type to affect</param>
        /// <param name="num">Cooldown in ticks</param>
        public void SetItemCooldown(ItemStack item, double num) { }

        /// <summary>
        /// Sets the type of weather visible to a player.
        /// </summary>
        public void SetPlayerWeather() { }

        /// <summary>
        /// Sends a message to a player. When the player moves over it with their cursor, a second message appears.
        /// </summary>
        /// <param name="text">Message to send in chat</param>
        /// <param name="text2">Message to see on hover</param>
        public void SendHover(string text, string text2) { }

        /// <summary>
        ///
        /// </summary>
        public void NoProjColl() { }

        /// <summary>
        ///
        /// </summary>
        public void ShowDisguise() { }

        /// <summary>
        /// Sets a player's remaining breath ticks.
        /// </summary>
        /// <param name="num">Breath ticks</param>
        public void SetAirTicks(double num) { }

        /// <summary>
        /// Displays a pickup animation of one entity being collected by another entity.
        /// </summary>
        /// <param name="text">Entity UUID</param>
        /// <param name="text2">Collector UUID</param>
        public void DisplayPickup(string text, string text2) { }

        /// <summary>
        /// Displays an animated particle cuboid to a player.
        /// </summary>
        /// <param name="particle">Effect</param>
        /// <param name="loc">Corner 1</param>
        /// <param name="loc2">Corner 2</param>
        /// <param name="num">Effect spacing</param>
        /// <param name="num2">Animation duration</param>
        public void ParticleCuboidA(Particle particle, Vector3 loc, Vector3 loc2, double num, double num2) { }

        /// <summary>
        /// Sets a player's chat color.
        /// </summary>
        /// <param name="text">New chat color</param>
        public void ChatColor(string text) { }

        /// <summary>
        /// Creates a world border only visible to a player.
        /// </summary>
        /// <param name="loc">Center position</param>
        /// <param name="num">Radius in blocks</param>
        /// <param name="num2">Warning distance</param>
        public void SetWorldBorder(Vector3 loc, double num, double num2) { }

        /// <summary>
        /// Sets the time of day visible to a player.
        /// </summary>
        /// <param name="num">Daylight ticks)</param>
        public void SetPlayerTime(double num) { }

        /// <summary>
        ///
        /// </summary>
        /// <param name="">Resets player time</param>
        public void NatRegen() { }

        /// <summary>
        /// Gives one or more potion effects to a player.
        /// </summary>
        /// <param name="effect">Effect(s)to give</param>
        public void GivePotion(StatusEffect effect) { }

        /// <summary>
        /// Plays a sound for a player.
        /// </summary>
        /// <param name="sound">Sound to play</param>
        /// <param name="loc">Playback location</param>
        public void PlaySound(Sound sound, Vector3 loc) { }

        /// <summary>
        /// Sets the location compasses point to for a player.
        /// </summary>
        /// <param name="loc">New Target</param>
        public void SetCompass(Vector3 loc) { }

        /// <summary>
        /// Removes items from a player.
        /// </summary>
        /// <param name="item">Item(s) to remove</param>
        public void RemoveItems(ItemStack item) { }

        /// <summary>
        /// Teleports a player to a random location in the chest.
        /// </summary>
        /// <param name="loc">Locations tochoose from</param>
        public void RngTeleport(Vector3 loc) { }

        /// <summary>
        /// Boosts a player's elytra using a firework rocket.
        /// </summary>
        /// <param name="item">Firework</param>
        public void BoostElytra(ItemStack item) { }

        /// <summary>
        /// Saves a player's inventory. It can be loaded later with 'Load Saved Inventory'.
        /// </summary>
        public void SaveInv() { }

        /// <summary>
        /// Opens a written book menu for a player.
        /// </summary>
        /// <param name="item">Book item</param>
        public void OpenBook(ItemStack item) { }

        /// <summary>
        /// Sets a player's current health.
        /// </summary>
        /// <param name="num">Current health</param>
        public void SetHealth(double num) { }

        /// <summary>
        /// Disguises a player as a mob.
        /// </summary>
        /// <param name="entity">Mob disguise</param>
        /// <param name="text">Disguise name</param>
        public void MobDisguise(Entity entity, string text) { }

        /// <summary>
        /// Disguises a player as a block.
        /// </summary>
        /// <param name="block">Block disguise</param>
        /// <param name="text">Name of disguise</param>
        public void BlockDisguise(Block block, string text) { }

        /// <summary>
        ///
        /// </summary>
        public void NoDeathDrops() { }

        /// <summary>
        /// Allows a player to place and break certain blocks.
        /// </summary>
        /// <param name="block">Blocks to allow</param>
        public void EnableBlocks(Block block) { }

        /// <summary>
        /// Sets a player's walk speed.
        /// </summary>
        /// <param name="num">% of normalwalk speed (0 to 500)</param>
        public void WalkSpeed(double num) { }

        /// <summary>
        /// Opens a container's inventory. Also works with crafting tables.
        /// </summary>
        /// <param name="loc">Container location</param>
        public void OpenBlockInv(Vector3 loc) { }

        /// <summary>
        /// Sets whether a player is able to collide with other entities.
        /// </summary>
        public void SetCollidable() { }

        /// <summary>
        /// Launches a player forward or backward.
        /// </summary>
        /// <param name="num">Launch power</param>
        public void LaunchFwd(double num) { }

        /// <summary>
        /// Displays an animated circle of particles to a player.
        /// </summary>
        /// <param name="particle">Effect</param>
        /// <param name="loc">Center location</param>
        /// <param name="num">Diameter</param>
        /// <param name="num2">Animation duration</param>
        public void ParticleCircleA(Particle particle, Vector3 loc, double num, double num2) { }

        /// <summary>
        ///
        /// </summary>
        public void RemoveBossBar() { }

        /// <summary>
        /// Sets a player's fall distance, affecting fall damage upon landing.
        /// </summary>
        /// <param name="num">Fall distance (blocks)</param>
        public void SetFallDistance(double num) { }

        /// <summary>
        /// Sets a player's game mode to Creative.
        /// </summary>
        public void CreativeMode() { }

        /// <summary>
        /// Sets the item in one of the equipment slots (armor and held items) of a player.
        /// </summary>
        /// <param name="item">Item to set</param>
        public void SetEquipment(ItemStack item) { }

        /// <summary>
        /// Makes a player perform an attack animation.
        /// </summary>
        public void AttackAnimation() { }

        /// <summary>
        ///
        /// </summary>
        public void GiveRngItem() { }

        /// <summary>
        /// Sets whether a player drops their items when dead.
        /// </summary>
        public void SetDropsEnabled() { }

        /// <summary>
        /// Removes one or more potion effects from a player.
        /// </summary>
        /// <param name="effect">Effect(s)to remove</param>
        public void RemovePotion(StatusEffect effect) { }

        /// <summary>
        /// Displays a floating name tag at a location to a player.
        /// </summary>
        /// <param name="loc">Display location</param>
        public void DisplayHologram(Vector3 loc) { }

        /// <summary>
        /// Displays a block fracture effect at a location to a player.
        /// </summary>
        /// <param name="loc">Block(s) tofracture</param>
        /// <param name="num">Fracture level</param>
        public void DisplayFracture(Vector3 loc, double num) { }

        /// <summary>
        /// Sets if an entity is hidden to a target.
        /// </summary>
        /// <param name="text">Entity UUID</param>
        public void SetEntityHidden(string text) { }

        /// <summary>
        ///
        /// </summary>
        public void AllowDrops() { }

        /// <summary>
        ///
        /// </summary>
        public void DeathDrops() { }

        /// <summary>
        /// Opens a custom inventory for a player.
        /// </summary>
        /// <param name="item">Items to display</param>
        public void ShowInv(ItemStack item) { }

        /// <summary>
        /// Sets a player's selected hotbar slot.
        /// </summary>
        /// <param name="num">New slot</param>
        public void SetSlot(double num) { }

        /// <summary>
        /// Displays a ray of particles to a player.
        /// </summary>
        /// <param name="particle">Effect</param>
        /// <param name="loc">Ray location</param>
        /// <param name="vec">Ray vector</param>
        /// <param name="num">Effect spacing</param>
        public void ParticleRay(Particle particle, Vector3 loc, Vector3 vec, double num) { }

        /// <summary>
        /// Sets a player's food hunger level.
        /// </summary>
        /// <param name="num">Food level(0-20)</param>
        public void SetFoodLevel(double num) { }

        /// <summary>
        /// Disguises a player as another player.
        /// </summary>
        /// <param name="text">Disguise player name</param>
        /// <param name="item">Disguise skin</param>
        public void PlayerDisguise(string text, ItemStack item) { }

        /// <summary>
        /// Displays a particle cuboid as a solid, hollow or wireframe shape to a player.
        /// </summary>
        /// <param name="particle">Effect</param>
        /// <param name="loc">Corner 1</param>
        /// <param name="loc2">Corner 2</param>
        /// <param name="num">Effect spacing</param>
        public void ParticleCuboid(Particle particle, Vector3 loc, Vector3 loc2, double num) { }

        /// <summary>
        /// Sends a series of messages in chat to a player, with a delay after each message.
        /// </summary>
        /// <param name="text">Messages to send</param>
        /// <param name="num">Message delay ticks</param>
        public void SendMessageSeq(string text, double num) { }

        /// <summary>
        /// Sets a player's saturation level.
        /// </summary>
        /// <param name="num">Saturation level(1-20)</param>
        public void SetSaturation(double num) { }

        /// <summary>
        ///
        /// </summary>
        public void WeatherClear() { }

        /// <summary>
        /// Removes a player's disguise.
        /// </summary>
        public void Undisguise() { }

        /// <summary>
        /// Displays an animated spiral of particles to a player.
        /// </summary>
        /// <param name="particle">Effect</param>
        /// <param name="loc">Base location</param>
        /// <param name="num">Length</param>
        /// <param name="num2">Diameter</param>
        /// <param name="num3">Particle count</param>
        /// <param name="num4">Rotations</param>
        /// <param name="num5">Animation duration</param>
        public void ParticleSpiralA(Particle particle, Vector3 loc, double num, double num2, double num3, double num4, double num5) { }

        /// <summary>
        /// Displays text in the center of a player's screen.
        /// </summary>
        /// <param name="text">Title text</param>
        /// <param name="text2">Subtitle text</param>
        /// <param name="num">Title duration</param>
        /// <param name="num2">Fade in length</param>
        /// <param name="num3">Fade out length</param>
        public void SendTitle(string text, string text2, double num, double num2, double num3) { }

        /// <summary>
        /// Sets if a player is instantly respawned upon dying.
        /// </summary>
        public void InstantRespawn() { }

        /// <summary>
        /// Stops all or specific sounds for a player.
        /// </summary>
        /// <param name="sound">Sounds to stop</param>
        public void StopSound(Sound sound) { }

        /// <summary>
        /// Sets the color a player's name tag appears in.
        /// </summary>
        /// <param name="text">Name color</param>
        public void SetNameColor(string text) { }

        /// <summary>
        /// Displays a line of particles between two locations to a player.
        /// </summary>
        /// <param name="particle">Effect</param>
        /// <param name="loc">Start location</param>
        /// <param name="loc2">End location</param>
        /// <param name="num">Effect spacing</param>
        public void ParticleLine(Particle particle, Vector3 loc, Vector3 loc2, double num) { }
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
