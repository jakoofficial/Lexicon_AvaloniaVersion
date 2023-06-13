using Avalonia.Controls;
using Lexicon_AvaloniaVersion.ViewModels;

namespace Lexicon_AvaloniaVersion.Views
{
    public partial class EntryView : UserControl
    {
        public EntryView()
        {
            DataContext = new EntryViewModel();
            InitializeComponent();
        }
    }
}
