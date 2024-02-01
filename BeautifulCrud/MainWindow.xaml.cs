using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows.Media;
using System;
using System.ComponentModel;
using System.Windows.Data;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using BeautifulCrud.Data.Entidades;
using BeautifulCrud.Data;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;

namespace BeautifulCrud
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    #region Codigo anterior Itemselected
    //public partial class MainWindow : Window, INotifyPropertyChanged
    //{
    //    public MainWindow()
    //    {
    //        InitializeComponent();
    //        LoadMembersFromDatabase();
    //    }
    //    public ObservableCollection<Member> Members { get; set; } = new ObservableCollection<Member>();


    //    private Member _product;

    //    public Member Product
    //    {
    //        get { return _product; }
    //        set { _product = value; NotifyPropertyChanged(); }
    //    }



    //    private void Border_MouseDown(object sender, MouseButtonEventArgs e)
    //    {
    //        if (e.ChangedButton == MouseButton.Left)
    //        {
    //            this.DragMove();
    //        }
    //    }
    //    private bool IsMaximized = false;

    //    public event PropertyChangedEventHandler? PropertyChanged;
    //    protected void NotifyPropertyChanged([CallerMemberName] string name = null)
    //    {
    //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    //    }


    //    private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    //    {
    //        if (e.ClickCount == 2)
    //        {
    //            if (IsMaximized)
    //            {
    //                this.WindowState = WindowState.Normal;
    //                this.Width = 1080;
    //                this.Height = 720;
    //            }
    //            else
    //            {
    //                this.WindowState = WindowState.Maximized;
    //                IsMaximized = true;
    //            }
    //        }
    //    }

    //    private void BtnLogout_Click(object sender, RoutedEventArgs e)
    //    {
    //        Application.Current.Shutdown();

    //    }

    //    private void BtnCloseBorderTranparent_Click(object sender, RoutedEventArgs e)
    //    {
    //        BorderBackGroundTransparent.Visibility = Visibility.Collapsed;
    //    }

    //    private void BtnAddNewMember_Click(object sender, RoutedEventArgs e)
    //    {
    //        BtnSalvarEdit.Visibility = Visibility.Collapsed;
    //        BtnSalvar.Visibility = Visibility.Visible;
    //        BorderBackGroundTransparent.Visibility = Visibility.Visible;
    //        TxtName.Focus();
    //        ClearTextBoxes();
    //    }
    //    private string GetBrushHexColor(string brushColor)
    //    {
    //        try
    //        {
    //            if (brushColor != null && brushColor.StartsWith("#"))
    //            {
    //                return brushColor;
    //            }

    //            // Converte a cor do Brush para hexadecimal, você pode implementar conforme necessário
    //            // Este é um exemplo simples, ajuste conforme necessário
    //            var color = (Color)ColorConverter.ConvertFromString(brushColor);
    //            return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show(ex.Message);
    //        }
    //        return "";
    //    }

    //    private void BorderBackGroundTransparent_KeyDown(object sender, KeyEventArgs e)
    //    {
    //        if (e.Key == Key.Escape)
    //        {
    //            BorderBackGroundTransparent.Visibility = Visibility.Collapsed;
    //        }
    //    }


    //    private void LoadMembersFromDatabase()
    //    {
    //        using (var context = new DBContext())
    //        {
    //            Members.Clear(); // Limpa a coleção antes de carregar
    //            foreach (var member in context.Member.ToList())
    //            {
    //                Members.Add(member);
    //            }
    //        }
    //        membersDataGrid.ItemsSource = Members;
    //    }

    //    private void BtnSalvar_Click(object sender, RoutedEventArgs e)
    //    {
    //        try
    //        {
    //            using (var dbContext = new DBContext())
    //            {
    //                // Criar uma instância de Member
    //                Member newMember = new Member
    //                {
    //                    Name = TxtName.Text,
    //                    Character = TxtCharacter.Text,
    //                    BgColor = GetBrushHexColor(TxtBgColor.Text),
    //                    Number = TxtNumber.Text,
    //                    Position = TxtPosition.Text,
    //                    Email = TxtEmail.Text,
    //                    Phone = TxtPhone.Text
    //                };

    //                // Adicionar o novo membro à coleção e ao banco de dados
    //                Members.Add(newMember);
    //                dbContext.Member.Add(newMember);
    //                dbContext.SaveChanges();
    //            }

    //            // Limpar os TextBoxes e recarregar os membros do banco de dados
    //            ClearTextBoxes();
    //            LoadMembersFromDatabase();
    //        }
    //        catch (DbUpdateException ex)
    //        {
    //            Debug.WriteLine("Error saving changes. Inner exception details:");
    //            Debug.WriteLine(ex.InnerException?.Message);
    //        }
    //    }
    //    private void ClearTextBoxes()
    //    {
    //        foreach (var child in StackTexts.Children)
    //        {
    //            if (child is StackPanel stackPanel)
    //            {
    //                foreach (var textBox in stackPanel.Children.OfType<TextBox>())
    //                {
    //                    textBox.Clear();
    //                }
    //            }
    //        }
    //    }

    //    private void membersDataGrid_Loaded(object sender, RoutedEventArgs e)
    //    {
    //        LoadMembersFromDatabase();
    //    }
    //    private Member selectedMember;

    //    private Member newMember = new Member();
    //    private void BtnEdit_Click(object sender, RoutedEventArgs e)
    //    {
    //        BtnSalvar.Visibility = Visibility.Collapsed;
    //        BorderBackGroundTransparent.Visibility = Visibility.Visible;
    //        BtnSalvarEdit.Visibility = Visibility.Visible;

    //        // Obter o membro selecionado no DataGrid
    //        selectedMember = membersDataGrid.SelectedItem as Member;

    //        if (selectedMember != null)
    //        {
    //            // Exibir os dados na interface de edição
    //            TxtName.Text = selectedMember.Name;
    //            TxtCharacter.Text = selectedMember.Character;
    //            TxtBgColor.Text = selectedMember.BgColor;
    //            TxtNumber.Text = selectedMember.Number;
    //            TxtPosition.Text = selectedMember.Position;
    //            TxtEmail.Text = selectedMember.Email;
    //            TxtPhone.Text = selectedMember.Phone;
    //        }
    //    }

    //    private void BtnSalvarEdit_Click(object sender, RoutedEventArgs e)
    //    {
    //        if (selectedMember != null)
    //        {
    //            using (var dbContext = new DBContext())
    //            {
    //                // Atualizar o membro no banco de dados
    //                dbContext.Entry(selectedMember).State = EntityState.Modified;
    //                dbContext.SaveChanges();
    //            }

    //            BorderBackGroundTransparent.Visibility = Visibility.Collapsed;
    //            BtnSalvarEdit.Visibility = Visibility.Collapsed;

    //            LoadMembersFromDatabase();
    //        }
    //    }

    //    private void BtnDelete_Click(object sender, RoutedEventArgs e)
    //    {
    //        Member selectedMember = membersDataGrid.SelectedItem as Member;

    //        if (selectedMember != null)
    //        {
    //            MessageBoxResult result = MessageBox.Show("Deseja excluir este membro?", "Confirmação", MessageBoxButton.YesNo, MessageBoxImage.Question);

    //            if (result == MessageBoxResult.Yes)
    //            {
    //                using (var dbContext = new DBContext())
    //                {
    //                    dbContext.Entry(selectedMember).State = EntityState.Deleted;
    //                    dbContext.SaveChanges();
    //                }

    //                Members.Remove(selectedMember);
    //                LoadMembersFromDatabase();
    //            }
    //        }
    //    }
    //} 
    #endregion


    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadMembersFromDatabase();
        }
        public ObservableCollection<Member> Members { get; set; } = new ObservableCollection<Member>();


        private Member _member;

        public Member Member
        {
            get { return _member; }
            set { _member = value; NotifyPropertyChanged(); }
        }



        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        private bool IsMaximized = false;

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (IsMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 720;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;
                    IsMaximized = true;
                }
            }
        }

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        private void BtnCloseBorderTranparent_Click(object sender, RoutedEventArgs e)
        {
            BorderBackGroundTransparent.Visibility = Visibility.Collapsed;
        }

        private void BtnAddNewMember_Click(object sender, RoutedEventArgs e)
        {
            BtnSalvarEdit.Visibility = Visibility.Collapsed;
            BtnSalvar.Visibility = Visibility.Visible;
            BorderBackGroundTransparent.Visibility = Visibility.Visible;
            TxtName.Focus();
            ClearTextBoxes();
        }
        private string GetBrushHexColor(string brushColor)
        {
            try
            {
                if (brushColor != null && brushColor.StartsWith("#"))
                {
                    return brushColor;
                }

                // Converte a cor do Brush para hexadecimal, você pode implementar conforme necessário
                // Este é um exemplo simples, ajuste conforme necessário
                var color = (Color)ColorConverter.ConvertFromString(brushColor);
                return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return "";
        }

        private void BorderBackGroundTransparent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                BorderBackGroundTransparent.Visibility = Visibility.Collapsed;
            }
        }


        private void LoadMembersFromDatabase()
        {
            using (var context = new DBContext())
            {
                Members.Clear(); // Limpa a coleção antes de carregar
                foreach (var member in context.Member.ToList())
                {
                    Members.Add(member);
                }
            }
            membersDataGrid.ItemsSource = Members;
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var dbContext = new DBContext())
                {
                    // Criar uma instância de Member
                    Member newMember = new Member
                    {
                        Name = TxtName.Text,
                        Character = TxtCharacter.Text,
                        BgColor = GetBrushHexColor(TxtBgColor.Text),
                        Number = TxtNumber.Text,
                        Position = TxtPosition.Text,
                        Email = TxtEmail.Text,
                        Phone = TxtPhone.Text
                    };

                    // Adicionar o novo membro à coleção e ao banco de dados
                    Members.Add(newMember);
                    dbContext.Member.Add(newMember);
                    dbContext.SaveChanges();
                }

                // Limpar os TextBoxes e recarregar os membros do banco de dados
                ClearTextBoxes();
                LoadMembersFromDatabase();
            }
            catch (DbUpdateException ex)
            {
                Debug.WriteLine("Error saving changes. Inner exception details:");
                Debug.WriteLine(ex.InnerException?.Message);
            }
        }
        private void ClearTextBoxes()
        {
            foreach (var child in StackTexts.Children)
            {
                if (child is StackPanel stackPanel)
                {
                    foreach (var textBox in stackPanel.Children.OfType<TextBox>())
                    {
                        textBox.Clear();
                    }
                }
            }
        }

        private void membersDataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            LoadMembersFromDatabase();
        }
        private Member selectedMember;

        private Member newMember = new Member();
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            BtnSalvar.Visibility = Visibility.Collapsed;
            BorderBackGroundTransparent.Visibility = Visibility.Visible;
            BtnSalvarEdit.Visibility = Visibility.Visible;
            TxtName.Focus();

            var selectedMembers = Members.Where(m => m.IsSelected).ToList();

            if (selectedMembers.Count == 1)
            {

                selectedMember = selectedMembers[0];

                TxtName.Text = selectedMember.Name;
                TxtCharacter.Text = selectedMember.Character;
                TxtBgColor.Text = selectedMember.BgColor;
                TxtNumber.Text = selectedMember.Number;
                TxtPosition.Text = selectedMember.Position;
                TxtEmail.Text = selectedMember.Email;
                TxtPhone.Text = selectedMember.Phone;

                BorderBackGroundTransparent.Visibility = Visibility.Visible;
                BtnSalvar.Visibility = Visibility.Collapsed;
                BtnSalvarEdit.Visibility = Visibility.Visible;
                TxtName.Focus();
            }
            else
            {
                MessageBox.Show("Selecione exatamente um membro para editar.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }


        private void BtnSalvarEdit_Click(object sender, RoutedEventArgs e)
        {
            if (selectedMember != null)
            {
                selectedMember.Name = TxtName.Text;

                selectedMember.Character = TxtCharacter.Text;
                selectedMember.BgColor = TxtBgColor.Text;
                selectedMember.Number = TxtNumber.Text;
                selectedMember.Position = TxtPosition.Text;
                selectedMember.Email = TxtEmail.Text;
                selectedMember.Phone = TxtPhone.Text;


                using (var dbContext = new DBContext())
                {
                    
                    dbContext.Entry(selectedMember).State = EntityState.Modified;
                    dbContext.SaveChanges();
                }

                BorderBackGroundTransparent.Visibility = Visibility.Collapsed;
                BtnSalvarEdit.Visibility = Visibility.Collapsed;

                LoadMembersFromDatabase();
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            // Obter apenas os membros selecionados
            var selectedMembers = Members.Where(m => m.IsSelected).ToList();

            if (selectedMembers.Count > 0)
            {
                MessageBoxResult result = MessageBox.Show($"Deseja excluir {selectedMembers.Count} membros selecionados?", "Confirmação", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    using (var dbContext = new DBContext())
                    {
                        foreach (var selectedMember in selectedMembers)
                        {
                            // Remover o membro do banco de dados
                            dbContext.Entry(selectedMember).State = EntityState.Deleted;
                        }
                        dbContext.SaveChanges();
                    }

                    // Remover os membros excluídos da coleção
                    foreach (var selectedMember in selectedMembers)
                    {
                        Members.Remove(selectedMember);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione pelo menos um membro para excluir.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void membersDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (membersDataGrid.SelectedItem is Member selectedMember)
            {
                selectedMember.IsSelected = !selectedMember.IsSelected;
            }
        }
    }
}

