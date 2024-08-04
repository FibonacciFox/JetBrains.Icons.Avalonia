using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;

namespace JetBrains.Icons.Avalonia.Demo.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _searchText;
        private ObservableCollection<JetBrainsIconKind> _filteredIconKinds;
        
        public MainWindowViewModel()
        {
            IconKinds = new ObservableCollection<JetBrainsIconKind>(Enum.GetValues(typeof(JetBrainsIconKind)).Cast<JetBrainsIconKind>());
            FilteredIconKinds = new ObservableCollection<JetBrainsIconKind>(IconKinds);
            
            this.WhenAnyValue(x => x.SearchText)
                .Throttle(TimeSpan.FromMilliseconds(300))
                .DistinctUntilChanged()
                .Select(FilterIcons)
                .ObserveOn(RxApp.MainThreadScheduler)
                .Subscribe(UpdateFilteredIcons);
        }
        
        public ObservableCollection<JetBrainsIconKind> IconKinds { get; }
        
        public ObservableCollection<JetBrainsIconKind> FilteredIconKinds
        {
            get => _filteredIconKinds;
            set => this.RaiseAndSetIfChanged(ref _filteredIconKinds, value);
        }

        public string SearchText
        {
            get => _searchText;
            set => this.RaiseAndSetIfChanged(ref _searchText, value);
        }

        private void UpdateFilteredIcons(ObservableCollection<JetBrainsIconKind> filteredIcons)
        {
            FilteredIconKinds = filteredIcons;
        }

        private ObservableCollection<JetBrainsIconKind> FilterIcons(string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                return new ObservableCollection<JetBrainsIconKind>(IconKinds);
            }

            var filteredIcons = IconKinds
                .Where(icon => icon.ToString().Contains(searchText, StringComparison.InvariantCultureIgnoreCase))
                .ToList();

            return new ObservableCollection<JetBrainsIconKind>(filteredIcons);
        }
    }
}
