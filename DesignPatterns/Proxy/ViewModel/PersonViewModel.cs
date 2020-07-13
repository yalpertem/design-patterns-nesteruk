using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Text;

namespace DesignPatterns.Proxy.ViewModel
{
    public class PersonViewModel
        : INotifyPropertyChanged
    {
        private readonly Person _person;
        public PersonViewModel(Person person)
        {
            _person = person;
        }

        public string FirstName
        {
            get => _person.FirstName;
            set
            {
                if (_person.FirstName == value) return;
                _person.FirstName = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FullName));
            }
        }

        public string LastName
        {
            get => _person.LastName;
            set
            {
                if (_person.LastName == value) return;
                _person.LastName = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FullName));
            }
        }

        // Decorator functionality (augments original object)
        // Project two properties together into, e.g., an edit box.
        public string FullName
        {
            get => $"{FirstName} {LastName}".Trim();
            set
            {
                if (value == null)
                {
                    FirstName = LastName = null;
                    return;
                }
                var items = value.Split();
                if (items.Length > 0)
                    FirstName = items[0]; // may cause npc
                if (items.Length > 1)
                    LastName = items[1];
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(
          [CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this,
              new PropertyChangedEventArgs(propertyName));
        }
    }
}
