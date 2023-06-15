using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_AvaloniaVersion.Models
{
    public class Entry
    {
        public int EntryId { get; set; }
        public int CategoryId { get; set; }
        public string EntryName { get; private set; }
        public string Title { get; set; }
        public string EntryText { get; set; }
        public string CodeArea { get; set; }

        public Entry(int entryId, int categoryId, string title, string entryText, string codeArea)
        {
            EntryId = entryId;
            CategoryId = categoryId;
            Title = title;
            EntryName = $"{title}_{entryId}";
            EntryText = entryText;
            CodeArea = codeArea;
        }
    }
}
