using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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

namespace Projekt_Ekstraklasa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataEkstraklasaDataContext dc = new DataEkstraklasaDataContext(Properties.Settings.Default.C__USERS_DARIU_APPDATA_LOCAL_MICROSOFT_VISUALSTUDIO_SSDT_EKSTRAKLASA_MDFConnectionString);



        public MainWindow()
        {
            InitializeComponent();

            if (dc.DatabaseExists())
            {

                Druzyny.ItemsSource = dc.DRUZYNies;
            }
        }

        private void DG1_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            string headername = e.Column.Header.ToString();

            //Cancel the column you don't want to generate
            if (headername == "PILKARZEs" || headername == "SPOTKANIAs" || headername == "TRENERZies" || headername == "SPOTKANIAs1" || headername == "BRAMKIs" || headername == "BRAMKIs1" || headername == "PILKARZEs"
                || headername == "KARTKIs" || headername == "DRUZYNY" || headername == "PILKARZE" || headername == "PILKARZE1" || headername == "SPOTKANIA" || headername == "SEDZIOWIE" || headername == "SPOTKANIAs" || headername == "DRUZYNY1"
                || headername == "SEDZIOWIEs")
            {
                e.Cancel = true;
                
            }
        }


        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Zapisano");
            Druzyny.ItemsSource = null;
            Druzyny.ItemsSource = dc.DRUZYNies;
            dc.SubmitChanges();
        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (Druzyny.SelectedItem == null)
            return;
            else
            {
                var index = Druzyny.SelectedIndex;
                switch (val)
                {
                    case 0:
                        var id = dc.DRUZYNies.ToList().ElementAtOrDefault(index).Id;
                        var delet = dc.DRUZYNies.SingleOrDefault(x => x.Id == id);
                        dc.DRUZYNies.DeleteOnSubmit(delet);
                        
                        break;
                    case 1:
                        var id1 = dc.PILKARZEs.ToList().ElementAtOrDefault(index).Id;
                        var delet1 = dc.PILKARZEs.SingleOrDefault(x => x.Id == id1);
                        dc.PILKARZEs.DeleteOnSubmit(delet1);
                        break;
                    case 2:
                        var id2 = dc.BRAMKIs.ToList().ElementAtOrDefault(index).Id;
                        var delet2 = dc.BRAMKIs.SingleOrDefault(x => x.Id == id2);
                        dc.BRAMKIs.DeleteOnSubmit(delet2);
                        break;
                    case 3:
                        var id3 = dc.KARTKIs.ToList().ElementAtOrDefault(index).Id_kart;
                        var delet3 = dc.KARTKIs.SingleOrDefault(x => x.Id_kart == id3);
                        dc.KARTKIs.DeleteOnSubmit(delet3);
                        break;
                    case 4:
                        var id4 = dc.SEDZIOWIEs.ToList().ElementAtOrDefault(index).Id;
                        var delet4 = dc.SEDZIOWIEs.SingleOrDefault(x => x.Id == id4);
                        dc.SEDZIOWIEs.DeleteOnSubmit(delet4);
                        break;
                    case 5:
                        var id5 = dc.SPOTKANIAs.ToList().ElementAtOrDefault(index).Id;
                        var delet5 = dc.SPOTKANIAs.SingleOrDefault(x => x.Id == id5);
                        dc.SPOTKANIAs.DeleteOnSubmit(delet5);
                        break;
                    case 6:
                        var id6 = dc.TRENERZies.ToList().ElementAtOrDefault(index).Id;
                        var delet6 = dc.TRENERZies.Single(x => x.Id == id6);
                        dc.TRENERZies.DeleteOnSubmit(delet6);
 
                        break;
                }
                dc.SubmitChanges();
                MessageBox.Show("Usunięto");


            }
        }


        private void ButtonDruzyny_Click(object sender, RoutedEventArgs e)
        {
            if (dc.DatabaseExists()) Druzyny.ItemsSource = dc.DRUZYNies;
            val = 0;
        }
        private void ButtonPilkarze_Click(object sender, RoutedEventArgs e)
        {
            if (dc.DatabaseExists()) Druzyny.ItemsSource = dc.PILKARZEs;
            val = 1;
        }
        private void ButtonBramki_Click(object sender, RoutedEventArgs e)
        {
            if (dc.DatabaseExists()) Druzyny.ItemsSource = dc.BRAMKIs;
            val = 2;
        }
        private void ButtonKartki_Click(object sender, RoutedEventArgs e)
        {
            if (dc.DatabaseExists()) Druzyny.ItemsSource = dc.KARTKIs;
            val = 3;
        }
        private void ButtonSedziowie_Click(object sender, RoutedEventArgs e)
        {
            if (dc.DatabaseExists()) Druzyny.ItemsSource = dc.SEDZIOWIEs;
            val = 4;
        }
        private void ButtonSpotkania_Click(object sender, RoutedEventArgs e)
        {
            if (dc.DatabaseExists()) Druzyny.ItemsSource = dc.SPOTKANIAs;
            val = 5;
        }
        private void ButtonTrenerzy_Click(object sender, RoutedEventArgs e)
        {
            if (dc.DatabaseExists()) Druzyny.ItemsSource = dc.TRENERZies;
            val = 6;
        }

        private int val = 0;
        private bool handle = true;
        private void ComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (handle) Handle();
            handle = true;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            handle = !cmb.IsDropDownOpen;
            Handle();
        }

        private void Handle()
        {
            switch (comboBox.SelectedItem.ToString().Split(new string[] { ": " }, StringSplitOptions.None).Last())
            {
                case "Lista zawodników danej drużyny":
                    if (dc.DatabaseExists())
                    {

                        int x;
                        int.TryParse(textBox.Text.Trim(), out x);
                        

                        var Zapytanie1 = from PILKARZE in dc.GetTable<PILKARZE>()
                                         join DRUZYNY in dc.GetTable<DRUZYNY>() on PILKARZE.Id_Drużyny equals DRUZYNY.Id
                                    
                                         where PILKARZE.Id_Drużyny == x
                                         orderby PILKARZE.Id_Drużyny
                                         select new {
                                             PILKARZE.Imię,
                                             PILKARZE.Nazwisko,
                                             Druzyna = DRUZYNY.Nazwa,
                                             Data_Urodzenia = DateTime.Parse(PILKARZE.Data_Urodzenia.ToString()).ToShortDateString(),
                                             PILKARZE.Ilość_Meczy,
                                             PILKARZE.Strzelone_Gole,
                                             PILKARZE.Pozycja,
                                         };
                                         
                        Druzyny.ItemsSource = Zapytanie1;

                    }
                    break;
                case "Średni wiek zawodników drużyny":
                    if (dc.DatabaseExists())
                    {
                        DateTime today = DateTime.Today;
                        int x;
                        int.TryParse(textBox.Text.Trim(), out x);

                        var Zapytanie2 = (from PILKARZE in dc.GetTable<PILKARZE>()
                                              where PILKARZE.Id_Drużyny == x
                                         let years = DateTime.Now.Year - PILKARZE.Data_Urodzenia.Value.Year
                                         let birthdayThisYear = PILKARZE.Data_Urodzenia.Value.AddYears(years)
                                         select new 
                                         {
                                             Wiek = birthdayThisYear > DateTime.Now ? years - 1 : years
                                         }).ToList();

                            var y = Math.Round(Zapytanie2.Average(s => s.Wiek));
                            var wrappedData = from str in new List<string>() { "Średni wiek drużyny " + x, y.ToString() }
                                              select new StringWrapper { Text = str };

                            Druzyny.ItemsSource = wrappedData;




                    }

                    break;
                case "Lista rankingów aktywnych zawodników ekstraklasy":
                    if (dc.DatabaseExists())
                    {

                        var Zapytanie3 = from PILKARZE in dc.GetTable<PILKARZE>()
                                         join DRUZYNY in dc.GetTable<DRUZYNY>() on PILKARZE.Id_Drużyny equals DRUZYNY.Id

                                         orderby PILKARZE.Pozycja, PILKARZE.Ilość_Meczy descending
                                         select new
                                         {
                                             PILKARZE.Imię,
                                             PILKARZE.Nazwisko,
                                             Druzyna = DRUZYNY.Nazwa,
                                             PILKARZE.Ilość_Meczy,
                                             PILKARZE.Strzelone_Gole,
                                             PILKARZE.Pozycja,
                                         };
                        Druzyny.ItemsSource = Zapytanie3;
                    }

                    break;
                case "Lista skutecznych bramkarzy ekstraklasy":
                    if (dc.DatabaseExists())
                    {
                        var Zapytanie4 = from PILKARZE in dc.GetTable<PILKARZE>()
                                         join DRUZYNY in dc.GetTable<DRUZYNY>() on PILKARZE.Id_Drużyny equals DRUZYNY.Id

                                         where PILKARZE.Pozycja == "Bramkarz"
                                         orderby PILKARZE.Wpuszczone_Piłki
                                         select new {
                                             PILKARZE.Imię,
                                             PILKARZE.Nazwisko,
                                             Druzyna = DRUZYNY.Nazwa,
                                             PILKARZE.Ilość_Meczy,
                                             PILKARZE.Wpuszczone_Piłki,
                                         };

                        Druzyny.ItemsSource = Zapytanie4;

                    }

                    break;
                case "Aktualny ranking króla strzelców ekstraklasy":
                    if (dc.DatabaseExists())
                    {
                        var Zapytanie5 = from PILKARZE in dc.GetTable<PILKARZE>()
                                         join DRUZYNY in dc.GetTable<DRUZYNY>() on PILKARZE.Id_Drużyny equals DRUZYNY.Id

                                         orderby PILKARZE.Strzelone_Gole descending
                                         select new
                                         {
                                             PILKARZE.Imię,
                                             PILKARZE.Nazwisko,
                                             Druzyna = DRUZYNY.Nazwa,
                                             PILKARZE.Strzelone_Gole,
                                         };

                        Druzyny.ItemsSource = Zapytanie5;

                    }
                    break;
                case "Listy przyszłych kolejek":
                    if (dc.DatabaseExists())
                    {
                        var Zapytanie6 = from SPOTKANIA in dc.GetTable<SPOTKANIA>()
                                         join DRUZYNY in dc.GetTable<DRUZYNY>() on SPOTKANIA.Id_Gospodarza  equals DRUZYNY.Id
                                         where SPOTKANIA.Data_Spotkania > DateTime.Now

                                         select new
                                         {
                                             SPOTKANIA.Id_Gospodarza,
                                             SPOTKANIA.Id_Gościa,
                                             SPOTKANIA.Data_Spotkania,
                                             SPOTKANIA.Miejsce_Spotkania,
                                         };

                        Druzyny.ItemsSource = Zapytanie6;

                    }
                    break;
                case "Lista wyników dowolnej rozegranej kolejki":
                    if (dc.DatabaseExists())

                    {
                        DateTime d1 = new DateTime(2018, 08, 10);
                        DateTime d2 = new DateTime(2019, 12, 15);
                        var Zapytanie7 = from SPOTKANIA in dc.GetTable<SPOTKANIA>()
                                       
                                         where SPOTKANIA.Data_Spotkania > d1 && SPOTKANIA.Data_Spotkania < d2
                                         select new
                                         {
                                             SPOTKANIA.Id_Gospodarza,
                                             SPOTKANIA.Id_Gościa,
                                             SPOTKANIA.Data_Spotkania,
                                             SPOTKANIA.Miejsce_Spotkania,
                                             SPOTKANIA.Wynik_Gospodarza,
                                             SPOTKANIA.Wynik_Gościa,
                                         };

                        Druzyny.ItemsSource = Zapytanie7;

                    }


                    break;
                case "Aktualny ranking drużyn":
                    if (dc.DatabaseExists())
                    {
                        var Zapytanie8 = from DRUZYNY in dc.GetTable<DRUZYNY>()
                                         orderby DRUZYNY.Punkty descending
                                         select new {
                                             DRUZYNY.Nazwa,
                                             DRUZYNY.Rozegrane_Mecze,
                                             DRUZYNY.Punkty,
                                             DRUZYNY.Strzelone_Gole,
                                         };
                        Druzyny.ItemsSource = Zapytanie8;

                    }


                    break;
                case "Lista brutalnych piłkarzy":
                    if (dc.DatabaseExists())
                    {
                        var Zapytanie9 = from PILKARZE in dc.GetTable<PILKARZE>()
                                         join DRUZYNY in dc.GetTable<DRUZYNY>() on PILKARZE.Id_Drużyny equals DRUZYNY.Id
                                         orderby PILKARZE.Czerwone_Kartki descending
                                         select new
                                         {
                                             PILKARZE.Imię,
                                             PILKARZE.Nazwisko,
                                             DRUZYNY.Nazwa,
                                             PILKARZE.Czerwone_Kartki,
                                             PILKARZE.Ilość_Meczy,
                                         };

                        Druzyny.ItemsSource = Zapytanie9;

                    }

                    break;
                case "Raport meczy prowadzonych przez sędziego":
                    if (dc.DatabaseExists())

                    {
                        int x;
                        int.TryParse(textBox.Text.Trim(), out x);

                        var Zapytanie10 = from SPOTKANIA in dc.GetTable<SPOTKANIA>()
                                          join SEDZIOWIE in dc.GetTable<SEDZIOWIE>() on SPOTKANIA.Id equals SEDZIOWIE.Id_Spotkania
                                          where SEDZIOWIE.Id == x
                                          select new
                                         {
                                             SPOTKANIA.Id_Gospodarza,
                                             SPOTKANIA.Id_Gościa,
                                             SPOTKANIA.Data_Spotkania,
                                             SPOTKANIA.Miejsce_Spotkania,
                                             SEDZIOWIE.Imie,
                                             SEDZIOWIE.Nazwisko,
                                             SEDZIOWIE.Ilość_Kartek,
                                            
                                         };

                        Druzyny.ItemsSource = Zapytanie10;

                    }
                    break;
            }
        }

        private void Druzyny_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }
    }

    internal class StringWrapper
    {
        public string Text { get; set; }
    }
}
