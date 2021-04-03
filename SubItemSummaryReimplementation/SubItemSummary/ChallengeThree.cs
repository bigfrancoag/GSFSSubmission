using System;

namespace SubItemSummary
{
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
    }
}
