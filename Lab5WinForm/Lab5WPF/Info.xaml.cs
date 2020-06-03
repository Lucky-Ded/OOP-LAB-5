using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Lab5WPF
{
    /// <summary>
    /// Логика взаимодействия для Info.xaml
    /// </summary>
    public partial class Info : UserControl
    {
        public Info()
        {
            InitializeComponent();
        }

        //имя
        public new static readonly DependencyProperty  NameProperty = DependencyProperty.Register(
            "NamePerson", //свойство, делегирующее работу с объектом LoginProperty
            typeof(string),
            typeof(Info),
            new PropertyMetadata(string.Empty, NameChanged));

        public string NamePerson
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        private static void NameChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args) //добавление текста в поле ввода логина
        {
            var NameForm = obj as Info;
            NameForm.PersName.Text = NameForm.NamePerson.ToString();
        }


        //фамилия
        public static readonly DependencyProperty SurnameProperty = DependencyProperty.Register(
            "SuramePerson",
            typeof(string),
            typeof(Info),
            new PropertyMetadata(string.Empty, SurnameChanged));

        public string SurnamePerson
        {
            get { return (string)GetValue(SurnameProperty); }
            set { SetValue(SurnameProperty, value); }
        }

        private static void SurnameChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var SurnameForm = obj as Info;
            SurnameForm.PersSurname.Text = SurnameForm.SurnamePerson.ToString();
        }


        //возраст
        public static readonly DependencyProperty AgeProperty = DependencyProperty.Register(
           "AgePerson",
           typeof(string),
           typeof(Info),
           new PropertyMetadata(string.Empty, AgeChanged));

        public string AgePerson
        {
            get { return (string)GetValue(AgeProperty); }
            set { SetValue(AgeProperty, value); }
        }

        private static void AgeChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var AgeForm = obj as Info;
            AgeForm.PersAge.Text = AgeForm.AgePerson.ToString();
        }

        //компания
        public static readonly DependencyProperty CompanyProperty = DependencyProperty.Register(
           "CompanyPerson",
           typeof(string),
           typeof(Info),
           new PropertyMetadata(string.Empty, CompanyChanged));

        public string CompanyPerson
        {
            get { return (string)GetValue(CompanyProperty); }
            set { SetValue(CompanyProperty, value); }
        }

        private static void CompanyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var CompanyForm = obj as Info;
            CompanyForm.PersCompany.Text = CompanyForm.CompanyPerson.ToString();
        }

        //должность
        public static readonly DependencyProperty ProfessionProperty = DependencyProperty.Register(
           "ProfessionPerson",
           typeof(string),
           typeof(Info),
           new PropertyMetadata(string.Empty, ProfessionChanged));

        public string ProfessionPerson
        {
            get { return (string)GetValue(ProfessionProperty); }
            set { SetValue(ProfessionProperty, value); }
        }

        private static void ProfessionChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var ProfessionForm = obj as Info;
            ProfessionForm.PersProf.Text = ProfessionForm.ProfessionPerson.ToString();
        }

        //аватарка
        public static readonly DependencyProperty ImgProperty = DependencyProperty.Register(
           "ImgPerson",
           typeof(string),
           typeof(Info),
           new PropertyMetadata(string.Empty, ImgChanged));

        public string ImgPerson
        {
            get { return (string)GetValue(ImgProperty); }
            set { SetValue(ImgProperty, value); }
        }

        private static void ImgChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var ImgForm = obj as Info;
            ImgForm.EmpImg.Source = new BitmapImage(new Uri($"pack://application:,,,/{ImgForm.ImgPerson}"));
        }

        private void CallBt_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("звонок", " идет Звонок");
        }

        private void WriteBt_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("напистаь письмо ", "Написать письмо");
        }

        private void AddBt_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("добавить запись", "Добавить запись");
        }

    }
}
