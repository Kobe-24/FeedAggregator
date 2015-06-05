using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FeedAggregator.Common;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //var items =  Redis.GetTopItems();

            // Redis.ExpirePoints();

            // clear database
            var connectionMultiplexer = Redis.Connection;
            var endpoints = connectionMultiplexer.GetEndPoints();
            var server = connectionMultiplexer.GetServer(endpoints.First());
            //FlushDatabase didn't work for me: got error admin mode not enabled error
            //server.FlushDatabase();
            var keys = server.Keys();
            foreach (var key in keys)
            {
                Console.WriteLine("Removing Key {0} from cache", key.ToString());                
                Redis.Database.KeyDelete(key);
            }
        }
    }
}
