using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace LeetCode.Util
{
    public class HashTableBase
    {
        protected int _bucket;
        protected List<int>[] _table;
        protected int _base;

        public HashTableBase(int Bucket)
        {
            _bucket = Bucket;
            _base = Bucket; 
            _table = new List<int>[Bucket];

            for (int i = 0; i < Bucket; i++)
                _table[i] = new List<int>();
        }

        protected virtual int HashFunction(int value)
        {
            return value % _base;
        }

        public virtual void InsertItem(int key, int? value)
        {
            int id = HashFunction(key);
            _table[id].Add(value ?? 0); 
        }
    }
}