using System;
using System.Collections.Generic;
using System.Linq;

namespace SubItemSummary
{
    public class SubItemSummary
    {
    }

    public class Item
    {
        public IEnumerable<Item> GetSubItems()
        {
            throw new NotImplementedException("stub");
        }
    }

    public class ChallengeThree
    {
        /// <summary>
        /// Gets a sub-item summary for a given item number.
        /// </summary>
        /// <param name="itemNumber">The item number of the item to get the sub-item summary of.</param>
        public SubItemSummary[] GetSubItemSummary(string itemNumber)
        {
            IEnumerable<Item> subItems = GetSubItems(itemNumber);

            List<SubItemSummary> subItemSummary = new List<SubItemSummary>();

            foreach (Item item in subItems)
            {
                IEnumerable<SubItemSummary> tempSummaries = TransformSubItems(item, item.GetSubItems());
        
                subItemSummary.AddRange(tempSummaries);
            }

            return subItemSummary.ToArray();
        }

        public SubItemSummary[] GetSubItemSummary2(string itemNumber)
        {
            return GetSubItems(itemNumber)?
                .SelectMany(item => TransformSubItems(item, item.GetSubItems()))
                .ToArray()
                ?? new SubItemSummary[0];
        }

        private IEnumerable<Item> GetSubItems(string itemNumber)
        {
            throw new NotImplementedException("stub");
        }
        
        private IEnumerable<SubItemSummary> TransformSubItems(Item item, IEnumerable<Item> subItems)
        {
            throw new NotImplementedException("stub");
        }
    }
}
