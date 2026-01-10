using System;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public string Title { get; }
        public int Year { get; }
        public List<string> Authors { get; }

        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = new List<string>(authors);
        }

        public int CompareTo(Book other)
        {
            if (other == null) return 1;

            // First compare by year
            int yearComparison = this.Year.CompareTo(other.Year);
            if (yearComparison == 0)
            {
                // If years are equal, compare by title
                return this.Title.CompareTo(other.Title);
            }

            return yearComparison;
        }

        public override string ToString()
        {
            return $"{Title} - {Year}";
        }
    }
}
