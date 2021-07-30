using Lemure.Collections;

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
        
    }
}