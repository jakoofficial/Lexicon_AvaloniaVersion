using Lexicon_AvaloniaVersion.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_AvaloniaVersion.ViewModels
{
    public class EntryViewModel : ViewModelBase
    {
        ObservableCollection<Category> categories { get; set; } = new ObservableCollection<Category>();
        List<Entry> entries = new List<Entry>();
        List<Entry> entries2 = new List<Entry>();

        public EntryViewModel()
        {
            //Testing the category
            entries.Add(
                new Entry(0, 0, "catEntry", "as", "lask")
                );
            entries2.Add(
                new Entry(0, 0, "Pizza", "as", "lask")
                );
            entries2.Add(
                new Entry(1, 0, "Burger Rec", "as", "lask")
                );

            categories.Add(new Category(
                0, "TestCat", entries2));
            categories.Add(new Category(
                1, "TestCatsecond", entries));
        }
    }
}
