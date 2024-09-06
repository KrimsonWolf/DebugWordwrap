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
            LoadGrid();
            SetCommands();
        }

        public ICommand EditCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }


        public List<GridData> Items
        {
            get; set;
        }

        public int EditColumnWidth
        {
            get => HasPermissonToEdit ? 75 : 0;
        }

        public int DeleteColumnWidth
        {
            get => HasPermissonToDelete ? 75 : 0;
        }

        public bool HasPermissonToEdit
        {
            get => true;
        }

        public bool HasPermissonToDelete
        {
            get => true;
        }

        public GridData SelectedRow
        {
            get; set;
        }

        private void LoadGrid()
        {
            this.Items = new List<GridData>();

            Items.Add(new GridData(0));
            Items.Add(new GridData(1));
            Items.Add(new GridData(2));
            Items.Add(new GridData(3));
        }

        private void SetCommands()
        { 
            this.EditCommand = new Command<GridData>(EditData);
            this.DeleteCommand = new Command<GridData>(DeleteData);
        }

        private void EditData(GridData gridData)
        {
            //ignore tap events
        }

        private void DeleteData(GridData gridData)
        {
            //ignore tap events
        }

        protected void OnPropertyChanged(string propertyName = "")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}