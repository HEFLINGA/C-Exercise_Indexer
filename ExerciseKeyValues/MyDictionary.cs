using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseKeyValues
{
    public class MyDictionary
    {
        public int stored;
        private KeyValue[] keyValues = new KeyValue[3];

        public object this[string key]
        {
            get
            {
                for (int i = 0; i < keyValues.Length; i++)
                {
                    if (key == keyValues[i].Key)
                    {
                        return keyValues[i].Value;
                    }
                }
                
                throw new KeyNotFoundException("Key was not found");
            }
            set
            {
                for (int i = 0; i < keyValues.Length; i++)
                {
                    if (key == keyValues[i].Key)
                    {
                        keyValues[i] = new KeyValue();
                        stored++;
                    }
                    if (i == keyValues.Length - 1)
                    {
                        keyValues[stored + 1] = new KeyValue(key, value);
                        stored++;
                    }
                }
            }
        }
    }
}
