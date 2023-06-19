using Avalonia.Controls;
using Avalonia.Media;
using Lexicon_AvaloniaVersion.Models;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive;

namespace Lexicon_AvaloniaVersion.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        ViewModelBase content;

        public ViewModelBase Content
        {
            get => content;
            private set => this.RaiseAndSetIfChanged(ref content, value);
        }

        public ViewModelBase[] viewArr =
        {
            new EntryViewModel(),
            new EditEntryViewModel(),
            new EditCategoryViewModel()
        };

        public ReactiveCommand<string, Unit> GoToViewCommand { get; }

        public MainWindowViewModel()
        {
            GoToViewCommand = ReactiveCommand.Create<string>(GoToView);
            Content = viewArr[0];
        }

        public void NewEntry()
        {
            Content = new EditEntryViewModel(new Entry(), true);
        }
        public void EditEntry(Entry entry)
        {
            Entry tmpEntry = new();
            if ((Entry)entry != null)
            {
                tmpEntry = entry;
            }
            Content = new EditEntryViewModel(tmpEntry, false);
        }
        public void EditCategory()
        {
            Content = new EditCategoryViewModel();
        }
        public void GoToView(string viewpage)
        {
            int.TryParse(viewpage, out int viewId);
            Content = viewArr[viewId];
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