using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace hashtable_ass
{
    internal class Hashtable
    {
        private Dictionary<string, string> keyValue = new Dictionary<string, string>();
        public void Add(String  key, String value)
        {
            keyValue[key] = value;
        }
        public object Get(String key)
        {
            return keyValue[key];
            
        }
        public bool Contains(String key)
        {
            return keyValue.ContainsKey(key);

        }
        public bool Remove(String key)
        {
            return keyValue.Remove(key);
        }
        public void display()
        {
          
            foreach (var item in keyValue)
            {
                Console.WriteLine("Value = {0}", item);
            }
        }
    }
}
