using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using ObservableCollectionExample.Models;
using ObservableCollectionExample.Helpers;

namespace ObservableCollectionExample.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public ObservableCollection<Person> List { get; set; }

        public DelegateCommand AddNewPersonCommand { get; set; }

        private void AddNewPersonExecute()
        {
            List.Add(new Person() { Name = string.Format("Example Name #{0}", List.Count + 1), Age = _rand.Next(0 , 130) });
        }

        private Random _rand = new Random();

        public MainWindowViewModel()
        {
            this.List = new ObservableCollection<Person>();
            this.AddNewPersonCommand = new DelegateCommand(AddNewPersonExecute);
        }
    }
}
