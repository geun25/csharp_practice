using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerTest
{
    class MyCache
    {
        // Dictionary : Key => Value
        private Dictionary<string, string> cache;

        //private Dictionary<string, string> extracache;

        public MyCache()
        {
            cache = new Dictionary<string, string>();

            // Default Cache Values
            cache.Add("Debug", "false");
            cache.Add("Logging", "true");
        }

        public void Add(string key, string value)
        {
            if(!cache.ContainsKey(key))
            {
                cache[key] = value;
            }
            else
            {
                throw new ApplicationException("Key already exists");
            }
        }

        public DateTime cacheExpires;

        // 일반적으로 속성은 필드값 접근
        public DateTime CacheExpires
        {
            get { return cacheExpires; }
            set { cacheExpires = value; }
        }

        // 인덱서는 컬렉션 데이터 중 특정요소 접근
        public string this[string key]
        {
            get
            {
                if (cache.ContainsKey(key))
                {
                    return cache[key];
                }

                return null;
            }
            set
            {
                if (cache.ContainsKey(key))
                {
                    cache[key] = value;
                }
                else
                {
                    throw new ApplicationException("Key not found");
                }
            }
        }

        public string Get(string key)
        {
            if(cache.ContainsKey(key))
            {
                return cache[key];
            }

            return null;
        }

        public void Set(string key, string value)
        {
            if (cache.ContainsKey(key))
            {
                cache[key] = value;
            }
            else
            {
                throw new ApplicationException("Key not found");
            }
        }
    }
}
