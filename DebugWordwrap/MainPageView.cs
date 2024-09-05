using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace DebugWordwrap
{
    public class MainPageViewModel : INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MainPageViewModel() 
        {
            Initialize();
        }

        public ICommand EditAdvancedDirectivesCommand { get; private set; }
        public ICommand DeleteAdvancedDirectivesCommand { get; private set; }


        public List<AdvanceDirectivesGridData> Items
        {
            get; set;
        }

        public int EditColumnWidth
        {
            get => HasPermissonToEditAdvanceDirective ? 75 : 0;
        }

        public int DeleteColumnWidth
        {
            get => HasPermissonToDeleteAdvanceDirective ? 75 : 0;
        }

        public bool HasPermissonToEditAdvanceDirective
        {
            get => true;
        }

        public bool HasPermissonToDeleteAdvanceDirective
        {
            get => true;
        }

        public AdvanceDirectivesGridData SelectedAdvanceDirective
        {
            get; set;
        }

        private void Initialize()
        {
            this.Items = new List<AdvanceDirectivesGridData>();

            Items.Add(new AdvanceDirectivesGridData());

            this.EditAdvancedDirectivesCommand = new Command<AdvanceDirectivesGridData>(EditAdvanceDirectives);

            this.DeleteAdvancedDirectivesCommand = new Command<AdvanceDirectivesGridData>(DeleteAdvanceDirectives);

        }

        private async void EditAdvanceDirectives(AdvanceDirectivesGridData advanceDirectivesGridData)
        {
            //ignore tap events
        }

        private async void DeleteAdvanceDirectives(AdvanceDirectivesGridData advanceDirectivesGridData)
        {
            //ignore tap events
        }

        protected void OnPropertyChanged(string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}