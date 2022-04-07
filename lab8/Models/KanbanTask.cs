using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Avalonia.Media.Imaging;

namespace lab8.Models
{
    public class KanbanTask : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        internal void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public KanbanTask(string status = "todo")
        {
            this.Header = "Header";
            this.Task = "Task";
            this.ImagePath = "../../../Assets/note.png";
            this.Image = new Bitmap(ImagePath);
            this.Status = status;
        }
        public string Header { get; set; }
        public string Status { get; set; }
        public string Task { get; set; }
        private Bitmap image;
        public string ImagePath { get; set; }
        public Bitmap Image
        {
            get => image;
            set
            {
                image = value;
                NotifyPropertyChanged();
            }
        }
    }
}