using System;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace DebugWordwrap
{
    public class GridData 
    {
        public GridData()
        {
            this.RecordUid = new Guid();
            this.Item = "Physician Orders for Life-Sustaining Treatment (POLST)";
            this.EnteredBy = "User Name";
            this.ReceivedDate = DateTime.UtcNow.AddDays(-3);
            this.ReceivedDateString = FormatDate(this.ReceivedDate);
            this.EndDate = FormatDate(DateTime.UtcNow.AddDays(30));
            this.CopyOnFile = "No";
            this.Notes = "This is MAUI Advance Directives Testing.";
            this.IsDeleteButtonVisible = true;
            this.IsEditButtonVisible = true;
        }

        public Guid RecordUid { get; set; }

        public string Item { get; set; }

        public string EnteredBy { get; set; }

        public string ReceivedDateString { get; set; }

        public DateTime ReceivedDate { get; set; }

        public string EndDate { get; set; }

        public string CopyOnFile { get; set; }

        public string Notes { get; set; }

        public bool IsDeleteButtonVisible { get; set; }

        public bool IsEditButtonVisible { get; set; }

        public Color EditIconTintColor => Color.FromArgb("00FF00");

        public bool IsDeleted { get; set; }

        private string FormatDate(DateTime? date)
        {
            if (date == null || date.Value == DateTime.MinValue)
            {
                return string.Empty;
            }

            return date.Value.ToShortDateString();
        }

    }
}