using System;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace DebugWordwrap
{
    public class GridData 
    {
        public GridData(int record)
        {
            switch(record)
            {
                case 0:
                    setRecord0();
                    break;
                case 1:
                    setRecord1();
                    break;
                case 2:
                    setRecord2();
                    break;
                case 3:
                    setRecord3();
                    break;
                default:
                    setRecord0();
                    break;
            }
        }


        public void setRecord0()
        {
            this.RecordUid = new Guid();
            this.Item = "this is a field that ends with a parantheses string.....(like this)";
            this.EnteredBy = "User Name";
            this.ReceivedDate = DateTime.UtcNow.AddDays(-3);
            this.ReceivedDateString = FormatDate(this.ReceivedDate);
            this.EndDate = FormatDate(DateTime.UtcNow.AddDays(30));
            this.CopyOnFile = "No";
            this.Notes = "This is MAUI testing data ends with a dot.";
            this.IsDeleteButtonVisible = true;
            this.IsEditButtonVisible = true;
        }


        public void setRecord1()
        {
            this.RecordUid = new Guid();
            this.Item = "this is a field that ends with a parantheses (like this)";
            this.EnteredBy = "User Name";
            this.ReceivedDate = DateTime.UtcNow.AddDays(-3);
            this.ReceivedDateString = FormatDate(this.ReceivedDate);
            this.EndDate = FormatDate(DateTime.UtcNow.AddDays(30));
            this.CopyOnFile = "No";
            this.Notes = "This is MAUI testing data that ends with a dot.";
            this.IsDeleteButtonVisible = true;
            this.IsEditButtonVisible = true;
        }



        public void setRecord2()
        {
            this.RecordUid = new Guid();
            this.Item = "this is a field that ends with a parantheses (like this)";
            this.EnteredBy = "User Name";
            this.ReceivedDate = DateTime.UtcNow.AddDays(-3);
            this.ReceivedDateString = FormatDate(this.ReceivedDate);
            this.EndDate = FormatDate(DateTime.UtcNow.AddDays(30));
            this.CopyOnFile = "No";
            this.Notes = "This is MAUI testing data ends with a dot.";
            this.IsDeleteButtonVisible = true;
            this.IsEditButtonVisible = true;
        }

        public void setRecord3()
        {
            this.RecordUid = new Guid();
            this.Item = "this is a field that ends with a parantheses string.....(like this)";
            this.EnteredBy = "User Name";
            this.ReceivedDate = DateTime.UtcNow.AddDays(-3);
            this.ReceivedDateString = FormatDate(this.ReceivedDate);
            this.EndDate = FormatDate(DateTime.UtcNow.AddDays(30));
            this.CopyOnFile = "No";
            this.Notes = "This is MAUI testing data with a dot.";
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