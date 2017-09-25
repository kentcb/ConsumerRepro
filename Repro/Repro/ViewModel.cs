using ReactiveUI;

namespace Repro
{
    public class ViewModel : ReactiveObject
    {
        private readonly ObservableAsPropertyHelper<string> name;
        private string lastName;
        private string firstName;

        public ViewModel()
        {
            this.name = this
                .WhenAnyValue(x => x.FirstName, x => x.LastName, (first, last) => last + ", " + first)
                .ToProperty(this, x => x.Name);
        }

        public string Name => this.name.Value;

        public string FirstName
        {
            get => this.firstName;
            set => this.RaiseAndSetIfChanged(ref this.firstName, value);
        }

        public string LastName
        {
            get => this.lastName;
            set => this.RaiseAndSetIfChanged(ref this.lastName, value);
        }
    }
}