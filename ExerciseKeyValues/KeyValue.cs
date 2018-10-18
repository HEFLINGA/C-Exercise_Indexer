using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseKeyValues
{
    public struct KeyValue
    {
        public readonly string Key;
        public readonly object Value;

        public KeyValue(string key, object value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
}
