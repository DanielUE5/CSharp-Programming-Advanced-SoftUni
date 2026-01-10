using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            // Compare by title (alphabetical order)
            int titleComparison = x.Title.CompareTo(y.Title);
            if (titleComparison != 0)
            {
                return titleComparison;
            }

            // If titles are the same, compare by year (newest to oldest)
            return y.Year.CompareTo(x.Year);
        }
    }
}
