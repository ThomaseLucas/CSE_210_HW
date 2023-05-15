using System.Collections.Generic;
using System;

#pragma warning restore format
namespace Develop02
{
    public class Journal 
    //The responsibility of the Journal class is to store entries
    {
        public List<Entry> entries; 
        public Journal()
        {
            entries = new List<Entry>();
        }
        public List<Entry> GetAllEntries()
        {
            return this.entries;
        }
        public void AddEntry(Entry entry)
        {
            if (!entries.Contains(entry))
            {
                entries.Add(entry);
            }
        }
        public List<Entry> GetEntriesByDate(DateTime date)
        {
            List<Entry> entriesByDate = new List<Entry>();
            foreach (Entry entry in entries)
            {
                if (entry.date == date.ToShortDateString())
                {
                    entriesByDate.Add(entry);
                }
            }
            return entriesByDate;
        }
    }
}