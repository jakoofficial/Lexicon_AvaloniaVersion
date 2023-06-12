using Avalonia.Controls;
using Avalonia.Media;
using Lexicon_AvaloniaVersion.Models;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Lexicon_AvaloniaVersion.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        ViewModelBase content;
        ObservableCollection<Category> categories { get; set; } = new ObservableCollection<Category>();
        List<Entry> entries = new List<Entry>();

        public ViewModelBase Content 
        { 
            get => content; 
            private set => this.RaiseAndSetIfChanged(ref content, value); 
        }

        public MainWindowViewModel()
        {
            Content = new EntryViewModel();

            //Testing the category
            entries.Add(
                new Entry(0, 0, "as", "as", "lask")
                );

            categories.Add(new Category(
                0, "TestCat", entries));
            categories.Add(new Category(
                0, "TestCatsecond", entries));
            
        }

        public void NewEntry()
        {
            Content = new EditEntryViewModel(true);
        }
        public void EditEntry()
        {
            Content = new EditEntryViewModel(false);
        }
        public void GoBack()
        {
            Content = new EntryViewModel();
        }

        public bool isCatOpen = false;

        public void OpenCloseCategory()
        {
            isCatOpen = !isCatOpen;
            if (isCatOpen)
            {

            }
        }

    }
}