using Lexicon_AvaloniaVersion.Models;
using Lexicon_AvaloniaVersion.Views;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_AvaloniaVersion.ViewModels
{
    public class EntryViewModel : ViewModelBase
    {
        //Try a list
        ObservableCollection<Category> categories { get; set; } = new ObservableCollection<Category>();
        List<Entry> entries = new List<Entry>();
        Entry openedEntry = new Entry();

        public EntryViewModel()
        {
            OpenCloseCommand = ReactiveCommand.Create<int>(OpenClose);
            SetEntryCommand = ReactiveCommand.Create<int>(SetEntry);
            //Testing the category
            entries.Add(
                new Entry(1, 1, "catEntry", "as", "lask")
                );
            entries.Add(
                new Entry(2, 2, "Pizza", "as", "lask")
                );
            entries.Add(
                new Entry(3, 2, "Burger Rec", "as", "lask")
                );

            categories.Add(new Category(
                1, "TestCat", GetEntriesForCategory(1)));
            categories.Add(new Category(
                2, "TestCatsecond", GetEntriesForCategory(2)));
            categories.Add(new Category(
                3, "TestCatThirdOptionLengthTest", GetEntriesForCategory(3)));
        }

        /// <summary>
        /// Sets the entries for the category based on categoryId on the entry
        /// </summary>
        /// <param name="CategoryId">The Id of the category</param>
        /// <returns>List of entries for Category</returns>
        public List<Entry> GetEntriesForCategory(int CategoryId)
        {
            List<Entry> newTempEntryList = new();
            if (entries.Count != 0)
            {
                foreach (var entry in entries)
                {
                    Entry e = (Entry)entry;
                    if (e != null && entry.CategoryId == CategoryId)
                    {

                        newTempEntryList.Add(e);
                    }
                }
                return newTempEntryList;
            }
            return new List<Entry>();
        }

        public ReactiveCommand<int, Unit> SetEntryCommand { get; }
        public void SetEntry(int entryId)
        {
            Entry entry = entries[entryId-1];
        }
        public ReactiveCommand<int, Unit> OpenCloseCommand { get; }
        //public ReactiveCommand<Entry>
        public void OpenClose(int categoryId)
        {
            Category category = categories[categoryId-1];
            category.ShowCategory = !category.ShowCategory;
        }
    }
}
