using System.Collections.Generic;
using Lemure.Collections.Comparable;

namespace Lemure.Collections.Comparer
{
    public class CarComparer : IComparer <Car>
    {
        public enum SortBy
        {
            Name,
            MaxSpeed
        }
        private SortBy compareField = SortBy.Name;

        public int Compare(Car? x, Car? y)
        {
            throw new System.NotImplementedException();
        }
    }
}