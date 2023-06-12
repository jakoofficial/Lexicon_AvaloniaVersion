using Avalonia.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Lexicon_AvaloniaVersion.Models;

namespace Lexicon_AvaloniaVersion.ViewModels
{
    public class EditEntryViewModel : ViewModelBase
    {
        public bool IsNew { get; private set; }

        public Entry tmpEntry { get; private set; }

        public EditEntryViewModel(bool isNew = false) 
        {
            IsNew = isNew;
            tmpEntry = new Entry(0, 0, "EntryTest", "Hello", "Public");
        }

        public void CreateEntry()
        {

        }
    }
}
