using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BeautifulCrud
{
    /// <summary>
    /// Interação lógica para DatePickerMaskedOri.xam
    /// </summary>
    public partial class DatePickerMaskedOri : UserControl, INotifyPropertyChanged
    {
        public DatePickerMaskedOri()
        {
            InitializeComponent();
            SelectedDate = DateTime.Now;
            Text = DateTime.Now.ToString();
            ISOFormattedDate = DateTime.Now.ToString();
            SetDate(DateTime.Now);
        }

        // public string Text { get { return DateTextBox.Text; } }
        #region Text

        //public DateTime? Text
        //{
        //    get { return (DateTime?)GetValue(TextProperty); }
        //    set { SetValue(TextProperty, value); NotifyPropertyChanged(); }
        //}

        //public static readonly DependencyProperty TextProperty =
        //        DependencyProperty.Register(
        //     "Text",
        //     typeof(DateTime?),
        //     typeof(DatePickerMaskedOri),
        //     new FrameworkPropertyMetadata(
        //         null,
        //         FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
        //         OnTextPropertyChanged
        //     )
        // );

        //private static void OnTextPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        //{
        //    if (d is DatePickerMaskedOri datePicker)
        //    {
        //        datePicker.NotifyPropertyChanged(nameof(Text));
        //        datePicker.SetDate(datePicker.Text);
        //    }
        //}

        #endregion

        #region Text2
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); NotifyPropertyChanged(); }
        }

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register(
                "Text",
                typeof(string),
                typeof(DatePickerMaskedOri),
                new FrameworkPropertyMetadata(
                    "",
                    FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                    OnTextPropertyChanged
                )
            );

        private static void OnTextPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DatePickerMaskedOri datePicker)
            {
                datePicker.NotifyPropertyChanged(nameof(Text));
            }
        }

        #endregion

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion

        #region Label
        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); NotifyPropertyChanged(); }
        }

        public static readonly DependencyProperty LabelProperty = DependencyProperty.Register("Label", typeof(string), typeof(DatePickerMaskedOri), new PropertyMetadata());

        #endregion

        #region SelectedDate
        public static readonly DependencyProperty SelectedDateProperty =
         DependencyProperty.Register(
             "SelectedDate",
             typeof(DateTime?),
             typeof(DatePickerMaskedOri),
             new FrameworkPropertyMetadata(
                 null,
                 FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                 OnSelectedDatePropertyChanged
             )
         );

        public DateTime? SelectedDate
        {
            get { return (DateTime?)GetValue(SelectedDateProperty); }
            set { SetValue(SelectedDateProperty, value); }
        }

        private static void OnSelectedDatePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DatePickerMaskedOri datePicker)
            {
                datePicker.NotifyPropertyChanged(nameof(SelectedDate));
                datePicker.SetDate(datePicker.SelectedDate);
            }
        }
        #endregion

        #region ISOformattedDate

        public string ISOFormattedDate
        {
            get { return (string)GetValue(ISOFormattedDateProperty); }
            set
            {
                SetValue(ISOFormattedDateProperty, value);
                NotifyPropertyChanged();
            }
        }

        public static readonly DependencyProperty ISOFormattedDateProperty =
            DependencyProperty.Register("ISOFormattedDate", typeof(string), typeof(DatePickerMaskedOri), new PropertyMetadata("", OnISOFormattedDatePropertyChanged));

        private static void OnISOFormattedDatePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DatePickerMaskedOri datePicker)
            {
                datePicker.NotifyPropertyChanged(nameof(datePicker.ISOFormattedDate));
            }
        }

     

        #endregion


        #region Ações Calendario/TextBox
        private void CalendarControl_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedDate = CalendarControl.SelectedDate;
            DateTextBox.Text = CalendarControl.SelectedDate?.ToString("dd/MM/yyyy");
           // ISOFormattedDate = CalendarControl.SelectedDate?.ToString("yyyy/MM/dd");
            CalendarPane.IsOpen = false;
        }

        private void DateTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                var dateStr = DateTextBox.Text.Split("/");
                var date = new DateTime(int.Parse(dateStr[2]), int.Parse(dateStr[1]), int.Parse(dateStr[0]));
                SelectedDate = date;
                string dataJunta = dateStr[2] + "/" + dateStr[1] + "/" + dateStr[0];
                ISOFormattedDate = dataJunta;
                DateTime teste = DateTime.Parse(dataJunta);
                Text = date.ToString();
                SetDate(date);

                Debug.WriteLine("o Valor de Text é: " +Text);
                Debug.WriteLine("o Valor de SelectedDate é: " +SelectedDate);
                Debug.WriteLine("o Valor de Iso é: " +ISOFormattedDate);
            }
            catch
            {
                SelectedDate = DateTime.Now;
            }
        }

        public void SetDate(DateTime? date)
        {
            CalendarControl.SelectedDate = date;
            if (date != null)
                CalendarControl.DisplayDate = date.Value;
        }
   

        private void DateTextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                e.MoverProximo();
                e.Handled = true;
            }
        }

        private void DateTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            DateTextBox.SelectAll();
        }

        private void DateTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var regex = new Regex("[^0-9/]");
            e.Handled = regex.IsMatch(e.Text);
        }
        #endregion
    }
}
