using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADVC01
{
    internal class Cache<TKey, TValue>
    {
        private readonly Dictionary<TKey, CacheItem<TValue>> _storage = new Dictionary<TKey, CacheItem<TValue>>();

        public void Add(TKey key, TValue value, TimeSpan duration)
        {
            _storage[key] = new CacheItem<TValue>(value, duration);
        }

        public bool Contains(TKey key)
        {
            if (_storage.TryGetValue(key, out var item))
            {
                if (!item.IsExpired)
                {
                    return true;
                }
                _storage.Remove(key);
            }
            return false;
        }

        public TValue Get(TKey key)
        {
            if (Contains(key))
            {
                return _storage[key].Value;
            }
            return default(TValue);
        }

        public bool Remove(TKey key)
        {
            return _storage.Remove(key);
        }
    }
}
