using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace BeautifulCrud.Data.Entidades
{
    public class Member : INotifyPropertyChanged
    {
        [Key]
        public int Id { get; set; }

        private string _character;
        private string _number;
        private string _name;
        private string _position;
        private string _email;
        private string _phone;
        private string _bgColor;
        private bool _isSelected;

        public string Character
        {
            get { return _character; }
            set { _character = value; OnPropertyChanged(); }
        }

        public string Number
        {
            get { return _number; }
            set { _number = value; OnPropertyChanged(); }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }

        public string Position
        {
            get { return _position; }
            set { _position = value; OnPropertyChanged(); }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; OnPropertyChanged(); }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; OnPropertyChanged(); }
        }

        public string BgColor
        {
            get { return _bgColor; }
            set { _bgColor = value; OnPropertyChanged(); }
        }
        [NotMapped]
        public bool IsSelected
        {
            get { return _isSelected; }
            set { _isSelected = value; OnPropertyChanged(); }
        }

        public List<Member> Members { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
