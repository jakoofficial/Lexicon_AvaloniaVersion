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

        public EntryViewModel()
        {
            OpenCloseCommand = ReactiveCommand.Create<int>(OpenClose);
            //Testing the category
            entries.Add(
                new Entry(0, 1, "catEntry", "as", "lask")
                );
            entries.Add(
                new Entry(0, 2, "Pizza", "as", "lask")
                );
            entries.Add(
                new Entry(1, 2, "Burger Rec", "as", "lask")
                );

            categories.Add(new Category(
                1, "TestCat", GetEntriesForCategory(1)));
            categories.Add(new Category(
                2, "TestCatsecond", GetEntriesForCategory(2)));
        }

        public List<Entry> GetEntriesForCategory(int CategoryId)
        {
            List<Entry> listOfEntries = entries;
            if (listOfEntries.Count != 0)
            {
                foreach (var entry in listOfEntries)
                {
                    Entry e = (Entry)entry;
                    if (e != null && entry.CategoryId == CategoryId)
                    {

                        listOfEntries.Add(e);
                    }
                }
                return listOfEntries;
            }
            return new List<Entry>();
        }

        public ReactiveCommand<int, Unit> OpenCloseCommand { get; }
        //public ReactiveCommand<Entry>
        public string Hello { get; set; } = "Yay!";
        public void OpenClose(int categoryId)
        {
            Category category = categories[categoryId-1];
            category.ShowCategory = !category.ShowCategory;
        }
    }
}
