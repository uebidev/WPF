using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulCrud
{
    public class DataVenda : INotifyPropertyChanged
    {
        private DateTime dtVenda;

        public DateTime DtVenda
        {
            get { return dtVenda; }
            set
            {
                if (value != dtVenda)
                {
                    dtVenda = value;
                    NotifyPropertyChanged(nameof(DtVenda));
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public DataVenda(DateTime dtVenda)
        {
            this.dtVenda = dtVenda;
        }
    }
}
