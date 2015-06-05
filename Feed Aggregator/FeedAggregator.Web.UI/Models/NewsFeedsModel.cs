using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedAggregator.Web.UI.Models
{
    public class NewsFeedsModel
    {
        public IEnumerable<FeedAggregator.Common.Entities.ItemWithScore> Items { get; set; }

        public IEnumerable<string> Categories { get; set; } 
    }
}
