using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFSharp.DiamondFire.ID
{
    internal class IDGenerator
    {
        public static void GenerateIDCode(string items)
        {
            string[] itemsArray = items.Replace("minecraft:", "").Split("\r\n");
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
                Console.WriteLine("public static readonly string " + string.Join(null, varName) + " = \"" + i + "\";");
            }
        }
    }
}
