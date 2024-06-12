using DFSharp.DiamondFire.ID;

namespace DFSharp
{
    public class DFSharp
    {
        private static string entities = "allay,axolotl,bat,camel,cat,chicken,cod,cow,donkey,fox,frog,glow_squid,horse,mooshroom,mule,ocelot,parrot,pig,pufferfish,rabbit,salmon,sheep,skeleton_horse,snow_golem,squid,strider,tadpole,tropical_fish,turtle,villager,wandering_trader,bee,cave_spider,dolphin,enderman,goat,iron_golem,llama,panda,piglin,polar_bear,spider,trader_llama,wolf,zombified_piglin,blaze,creeper,drowned,elder_guardian,endermite,evoker,ghast,guardian,hoglin,husk,magma_cube,phantom,piglin_brute,pillager,ravager,shulker,silverfish,skeleton,slime,stray,vex,vindicator,warden,witch,wither_skeleton,zoglin,zombie,zombie_villager,ender_dragon,wither,illusioner";

        public static void Main(string[] args)
        {
            GenerateIDCode(entities);
        }
        private static void GenerateIDCode(string items)
        {
            string[] itemsArray = items.Replace("minecraft:", "").Split(",");
            string[] varName;
            string a;
            string b;
            foreach (string i in itemsArray)
            {
                varName = i.Split('_');
                foreach (string s in varName)
                {
                    varName[Array.IndexOf(varName, s)] = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(s.ToLower());
                }
                Console.WriteLine("public static readonly string " + string.Join(null, varName) + " = MaterialID." + string.Join(null, varName) + "SpawnEgg;");
            }
        }
    }
}