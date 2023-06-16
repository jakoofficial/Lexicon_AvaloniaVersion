using Lexicon_AvaloniaVersion.Models;
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
        ObservableCollection<Category> categories { get; set; } = new ObservableCollection<Category>();
        List<Entry> entries = new List<Entry>();
        List<Entry> entries2 = new List<Entry>();

        public EntryViewModel()
        {
            OpenCloseCommand = ReactiveCommand.Create<int>(OpenClose);
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
                1, "TestCat", entries2));
            categories.Add(new Category(
                2, "TestCatsecond", entries));
        }

        //private bool _showCategory = false;

        //public bool ShowCategory
        //{
        //    get => _showCategory;
        //    set => this.RaiseAndSetIfChanged(ref _showCategory, value);
        //}

        public ReactiveCommand<int, Unit> OpenCloseCommand { get; }
        public string Hello { get; set; } = "Yay!";
        public void OpenClose(int categoryId)
        {
            Category category = categories[categoryId-1];
            //ShowCategory = !ShowCategory;
            category.ShowCategory = !category.ShowCategory;
        }
    }
}
