using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Lexicon_AvaloniaVersion.Models
{
    public class Category : ReactiveObject
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        
        public List<Entry>? Entries { get; set; } = new List<Entry>();
        private bool _showCategory = false;

        public bool ShowCategory
        {
            get => _showCategory;
            set => this.RaiseAndSetIfChanged(ref _showCategory, value);
        }

        public Category(int categoryId, string categoryName, List<Entry>? entries)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
            Entries = entries;
        }
    }
}
