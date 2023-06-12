using Avalonia.Controls;
using Lexicon_AvaloniaVersion.ViewModels;

namespace Lexicon_AvaloniaVersion.Views
{
    public partial class EditEntryView : UserControl
    {
        public EditEntryView()
        {
            InitializeComponent();
        }

        public void Cancel()
        {
            Content = new EntryViewModel();
        }
    }
}
