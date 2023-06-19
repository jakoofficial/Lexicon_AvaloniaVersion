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

        public Entry? tmpEntry { get; private set; } = new Entry();

        public EditEntryViewModel(Entry? entry = null, bool isNew = false) 
        {
            IsNew = isNew;
            //new Entry(0, 0, "EntryTest", "Hello", "Public");
            tmpEntry = entry;
        }

        public void CreateEntry()
        {

        }
    }
}
