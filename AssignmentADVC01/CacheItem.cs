using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentADVC01
{
    internal class CacheItem<TValue>
    {
        public TValue Value { get; }
        public DateTime ExpirationTime { get; }

        public CacheItem(TValue value, TimeSpan duration)
        {
            Value = value;
            ExpirationTime = DateTime.UtcNow.Add(duration);
        }

        public bool IsExpired => DateTime.UtcNow > ExpirationTime;
    
}
}
