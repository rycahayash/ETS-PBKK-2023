using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
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

namespace CurrencyConverter_API
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Create an object of root class
        Root val = new Root();

        //Root class is a main class. API return rates in a rates it return all currency name with Value.
        public class Root
        {
            //Get all record in rates and set in Rate class as currency name wise
            public Rate rates { get; set; }
        }
        //Make sure API return value that name and where you want to store that name are same. Like in API get response INR then set it with INR name.
        public class Rate
        {
            public double AED { get; set; }
            public double AFN { get; set; }
            public double ALL { get; set; }
            public double AMD { get; set; }
            public double ANG { get; set; }
            public double AOA { get; set; }
            public double ARS { get; set; }
            public double AUD { get; set; }
            public double AWG { get; set; }
            public double AZN { get; set; }
            public double BAM { get; set; }
            public double BBD { get; set; }
            public double BDT { get; set; }
            public double BGN { get; set; }
            public double BHD { get; set; }
            public double BIF { get; set; }
            public double BMD { get; set; }
            public double BND { get; set; }
            public double BOB { get; set; }
            public double BRL { get; set; }
            public double BSD { get; set; }
            public double BTC { get; set; }
            public double BTN { get; set; }
            public double BWP { get; set; }
            public double BYN { get; set; }
            public double BZD { get; set; }
            public double CAD { get; set; }
            public double CDF { get; set; }
            public double CHF { get; set; }
            public double CLF { get; set; }
            public double CLP { get; set; }
            public double CNH { get; set; }
            public double CNY { get; set; }
            public double COP { get; set; }
            public double CRC { get; set; }
            public double CUC { get; set; }
            public double CUP { get; set; }
            public double CVE { get; set; }
            public double CZK { get; set; }
            public double DJF { get; set; }
            public double DKK { get; set; }
            public double DOP { get; set; }
            public double DZD { get; set; }
            public double EGP { get; set; }
            public double ERN { get; set; }
            public double ETB { get; set; }
            public double EUR { get; set; }
            public double FJD { get; set; }
            public double FKP { get; set; }
            public double GBP { get; set; }
            public double GEL { get; set; }
            public double GGP { get; set; }
            public double GHS { get; set; }
            public double GIP { get; set; }
            public double GMD { get; set; }
            public double GNF { get; set; }
            public double GTQ { get; set; }
            public double GYD { get; set; }
            public double HKD { get; set; }
            public double HNL { get; set; }
            public double HRK { get; set; }
            public double HTG { get; set; }
            public double HUF { get; set; }
            public double IDR { get; set; }
            public double ILS { get; set; }
            public double IMP { get; set; }
            public double INR { get; set; }
            public double IQD { get; set; }
            public double IRR { get; set; }
            public double ISK { get; set; }
            public double JEP { get; set; }
            public double JMD { get; set; }
            public double JOD { get; set; }
            public double JPY { get; set; }
            public double KES { get; set; }
            public double KGS { get; set; }
            public double KHR { get; set; }
            public double KMF { get; set; }
            public double KPW { get; set; }
            public double KRW { get; set; }
            public double KWD { get; set; }
            public double KYD { get; set; }
            public double KZT { get; set; }
            public double LAK { get; set; }
            public double LBP { get; set; }
            public double LKR { get; set; }
            public double LRD { get; set; }
            public double LSL { get; set; }
            public double LYD { get; set; }
            public double MAD { get; set; }
            public double MDL { get; set; }
            public double MGA { get; set; }
            public double MKD { get; set; }
            public double MMK { get; set; }
            public double MNT { get; set; }
            public double MOP { get; set; }
            public double MRU { get; set; }
            public double MUR { get; set; }
            public double MVR { get; set; }
            public double MWK { get; set; }
            public double MXN { get; set; }
            public double MYR { get; set; }
            public double MZN { get; set; }
            public double NAD { get; set; }
            public double NGN { get; set; }
            public double NIO { get; set; }
            public double NOK { get; set; }
            public double NPR { get; set; }
            public double NZD { get; set; }
            public double OMR { get; set; }
            public double PAB { get; set; }
            public double PEN { get; set; }
            public double PGK { get; set; }
            public double PHP { get; set; }
            public double PKR { get; set; }
            public double PLN { get; set; }
            public double PYG { get; set; }
            public double QAR { get; set; }
            public double RON { get; set; }
            public double RSD { get; set; }
            public double RUB { get; set; }
            public double RWF { get; set; }
            public double SAR { get; set; }
            public double SBD { get; set; }
            public double SCR { get; set; }
            public double SDG { get; set; }
            public double SEK { get; set; }
            public double SGD { get; set; }
            public double SHP { get; set; }
            public double SLL { get; set; }
            public double SOS { get; set; }
            public double SRD { get; set; }
            public double SSP { get; set; }
            public double STD { get; set; }
            public double STN { get; set; }
            public double SVC { get; set; }
            public double SYP { get; set; }
            public double SZL { get; set; }
            public double THB { get; set; }
            public double TJS { get; set; }
            public double TMT { get; set; }
            public double TND { get; set; }
            public double TOP { get; set; }
            public double TRY { get; set; }
            public double TTD { get; set; }
            public double TWD { get; set; }
            public double TZS { get; set; }
            public double UAH { get; set; }
            public double UGX { get; set; }
            public double USD { get; set; }
            public double UYU { get; set; }
            public double UZS { get; set; }
            public double VES { get; set; }
            public double VND { get; set; }
            public double VUV { get; set; }
            public double WST { get; set; }
            public double XAF { get; set; }
            public double XAG { get; set; }
            public double XAU { get; set; }
            public double XCD { get; set; }
            public double XDR { get; set; }
            public double XOF { get; set; }
            public double XPD { get; set; }
            public double XPF { get; set; }
            public double XPT { get; set; }
            public double YER { get; set; }
            public double ZAR { get; set; }
            public double ZMW { get; set; }
            public double ZWL { get; set; }
        }

        public MainWindow()
        {
            InitializeComponent();
            ClearControls();
            GetValue();
        }

        private async void GetValue()
        {
            val = await GetDataGetMethod<Root>("https://openexchangerates.org/api/latest.json?app_id=69cb235f2fe74f03baeec270066587cf"); //API Link
            BindCurrency();
        }

        public static async Task<Root> GetDataGetMethod<T>(string url)
        {
            var ss = new Root();
            try
            {
                //HttpClient class provides a base class for sending/receiving the HTTP requests/responses from a URL.
                using (var client = new HttpClient())
                {
                    //The timespan to wait before the request times out.
                    client.Timeout = TimeSpan.FromMinutes(1);

                    //HttpResponseMessage is a way of returning a message/data from your action.
                    HttpResponseMessage response = await client.GetAsync(url);

                    //Check API response status code ok
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        //Serialize the HTTP content to a string as an asynchronous operation.
                        var ResponceString = await response.Content.ReadAsStringAsync();


                        //JsonConvert.DeserializeObject to deserialize Json to a C#
                        var ResponceObject = JsonConvert.DeserializeObject<Root>(ResponceString);
                        return ResponceObject;  //Return API responce
                    }
                    return ss;
                }
            }
            catch
            {
                return ss;
            }
        }

        #region Bind Currency From and To Combobox
        private void BindCurrency()
        {
            //Create an object Datatable
            DataTable dt = new DataTable();

            //Add display column in DataTable
            dt.Columns.Add("Text");

            //Add value column in DataTable
            dt.Columns.Add("Rate");

            //Add rows in Datatable with text and value. Set a value which fetch from API
            dt.Rows.Add("--SELECT--", 0);
            dt.Rows.Add("AED (United Arab Emirates Dirham)", val.rates.AED);
            dt.Rows.Add("AFN (Afghan Afghani)", val.rates.AFN);
            dt.Rows.Add("ALL (Albanian Lek)", val.rates.ALL);
            dt.Rows.Add("AMD (Armenian Dram)", val.rates.AMD);
            dt.Rows.Add("ANG (Netherlands Antillean Guilder)", val.rates.ANG);
            dt.Rows.Add("AOA (Angolan Kwanza)", val.rates.AOA);
            dt.Rows.Add("ARS (Argentine Peso)", val.rates.ARS);
            dt.Rows.Add("AUD (Australian Dollar)", val.rates.AUD);
            dt.Rows.Add("AWG (Aruban Florin)", val.rates.AWG);
            dt.Rows.Add("AZN (Azerbaijani Manat)", val.rates.AZN);
            dt.Rows.Add("BAM (Bosnia-Herzegovina Convertible Mark)", val.rates.BAM);
            dt.Rows.Add("BBD (Barbadian Dollar)", val.rates.BBD);
            dt.Rows.Add("BDT (Bangladeshi Taka)", val.rates.BDT);
            dt.Rows.Add("BGN (Bulgarian Lev)", val.rates.BGN);
            dt.Rows.Add("BHD (Bahraini Dinar)", val.rates.BHD);
            dt.Rows.Add("BIF (Burundian Franc)", val.rates.BIF);
            dt.Rows.Add("BMD (Bermudan Dollar)", val.rates.BMD);
            dt.Rows.Add("BND (Brunei Dollar)", val.rates.BND);
            dt.Rows.Add("BOB (Bolivian Boliviano)", val.rates.BOB);
            dt.Rows.Add("BRL (Brazilian Real)", val.rates.BRL);
            dt.Rows.Add("BSD (Bahamian Dollar)", val.rates.BSD);
            dt.Rows.Add("BTC (Bitcoin)", val.rates.BTC);
            dt.Rows.Add("BTN (Bhutanese Ngultrum)", val.rates.BTN);
            dt.Rows.Add("BWP (Botswanan Pula)", val.rates.BWP);
            dt.Rows.Add("BYN (Belarusian Ruble)", val.rates.BYN);
            dt.Rows.Add("BZD (Belize Dollar)", val.rates.BZD);
            dt.Rows.Add("CAD (Canadian Dollar)", val.rates.CAD);
            dt.Rows.Add("CDF (Congolese Franc)", val.rates.CDF);
            dt.Rows.Add("CHF (Swiss Franc)", val.rates.CHF);
            dt.Rows.Add("CLF (Chilean Unit of Account)", val.rates.CLF);
            dt.Rows.Add("CLP (Chilean Peso)", val.rates.CLP);
            dt.Rows.Add("CNH (Chinese Yuan (Offshore))", val.rates.CNH);
            dt.Rows.Add("CNY (Chinese Yuan)", val.rates.CNY);
            dt.Rows.Add("COP (Colombian Peso)", val.rates.COP);
            dt.Rows.Add("CRC (Costa Rican Colón)", val.rates.CRC);
            dt.Rows.Add("CUC (Kuba Convertible Peso)", val.rates.CUC);
            dt.Rows.Add("CUP (Cuban Peso)", val.rates.CUP);
            dt.Rows.Add("CVE (Cape Verdean Escudo)", val.rates.CVE);
            dt.Rows.Add("CZK (Czech Koruna)", val.rates.CZK);
            dt.Rows.Add("DJF (Djiboutian Franc)", val.rates.DJF);
            dt.Rows.Add("DKK (Danis Krone)", val.rates.DKK);
            dt.Rows.Add("DOP (Dominican Peso)", val.rates.DOP);
            dt.Rows.Add("DZD (Algerian Dinar)", val.rates.DZD);
            dt.Rows.Add("EGP (Egyptian Pound)", val.rates.EGP);
            dt.Rows.Add("ERN (Eritrean Nakfa)", val.rates.ERN);
            dt.Rows.Add("ETB (Ethiopian Birr)", val.rates.ETB);
            dt.Rows.Add("EUR (Euro)", val.rates.EUR);
            dt.Rows.Add("FJD (Fijian Dollar)", val.rates.FJD);
            dt.Rows.Add("FKP (Falkland Island Pound)", val.rates.FKP);
            dt.Rows.Add("GBP (Pound sterling)", val.rates.GBP);
            dt.Rows.Add("GEL (Georgian Lari)", val.rates.GEL);
            dt.Rows.Add("GGP (Guernsey Pound)", val.rates.GGP);
            dt.Rows.Add("GHS (Ghanaian Cedi)", val.rates.GHS);
            dt.Rows.Add("GIP (Gibraltar Pound)", val.rates.GIP);
            dt.Rows.Add("GMD (Gambian Dalasi)", val.rates.GMD);
            dt.Rows.Add("GNF (Guinean Franc)", val.rates.GNF);
            dt.Rows.Add("GTQ (Guatemalan Quetzal)", val.rates.GTQ);
            dt.Rows.Add("GYD (Guyanaese Dollar)", val.rates.GYD);
            dt.Rows.Add("HKD (Hong Kong Dollar)", val.rates.HKD);
            dt.Rows.Add("HNL (Honduran Lempira)", val.rates.HNL);
            dt.Rows.Add("HRK (Croatian Kuna)", val.rates.HRK);
            dt.Rows.Add("HTG (Haitian Gourde)", val.rates.HTG);
            dt.Rows.Add("HUF (Hungarian Forint)", val.rates.HUF);
            dt.Rows.Add("IDR (Indonesian Rupiah)", val.rates.IDR);
            dt.Rows.Add("ILS (Israeli New Shekel)", val.rates.ILS);
            dt.Rows.Add("IMP (Isle of Man Pound)", val.rates.IMP);
            dt.Rows.Add("INR (Indian Rupee)", val.rates.INR);
            dt.Rows.Add("IQD (Iraqi Dinar)", val.rates.IQD);
            dt.Rows.Add("IRR (Iranian Rial)", val.rates.IRR);
            dt.Rows.Add("ISK (Icelandic Króna)", val.rates.ISK);
            dt.Rows.Add("JEP (Jersey Pound)", val.rates.JEP);
            dt.Rows.Add("JMD (Jamaican Dollar)", val.rates.JMD);
            dt.Rows.Add("JOD (Jordanian Dinar)", val.rates.JOD);
            dt.Rows.Add("JPY (Japanese Yen)", val.rates.JPY);
            dt.Rows.Add("KES (Kenyan Shilling)", val.rates.KES);
            dt.Rows.Add("KGS (Kyrgystani Som)", val.rates.KGS);
            dt.Rows.Add("KHR (Cambodian riel)", val.rates.KHR);
            dt.Rows.Add("KMF (Comorian Franc)", val.rates.KMF);
            dt.Rows.Add("KPW (North Korean Won)", val.rates.KPW);
            dt.Rows.Add("KRW (South Korean won)", val.rates.KRW);
            dt.Rows.Add("KWD (Kuwaiti Dinar)", val.rates.KWD);
            dt.Rows.Add("KYD (Cayman Islands Dollar)", val.rates.KYD);
            dt.Rows.Add("KZT (Kazakhstani Tenge)", val.rates.KZT);
            dt.Rows.Add("LAK (Laotian Kip)", val.rates.LAK);
            dt.Rows.Add("LBP (Lebanese pound)", val.rates.LBP);
            dt.Rows.Add("LKR (Sri Lankan Rupee)", val.rates.LKR);
            dt.Rows.Add("LRD (Liberian Dollar)", val.rates.LRD);
            dt.Rows.Add("LSL (Lesotho Loti)", val.rates.LSL);
            dt.Rows.Add("LYD (Libyan Dinar)", val.rates.LYD);
            dt.Rows.Add("MAD (Moroccan Dirham)", val.rates.MAD);
            dt.Rows.Add("MDL (Moldovan Leu)", val.rates.MDL);
            dt.Rows.Add("MGA (Malagasy Ariary)", val.rates.MGA);
            dt.Rows.Add("MKD (Macedonian Denar)", val.rates.MKD);
            dt.Rows.Add("MMK (Myanmar Kyat)", val.rates.MMK);
            dt.Rows.Add("MNT (Mongolian Tughrik)", val.rates.MNT);
            dt.Rows.Add("MOP (Macanese Pataca)", val.rates.MOP);
            dt.Rows.Add("MRU (Mauritanian ouguiyas)", val.rates.MRU);
            dt.Rows.Add("MUR (Mauritian Rupee)", val.rates.MUR);
            dt.Rows.Add("MVR (Maldivian Rufiyaa)", val.rates.MVR);
            dt.Rows.Add("MWK (Malawian Kwacha)", val.rates.MWK);
            dt.Rows.Add("MXN (Mexican Peso)", val.rates.MXN);
            dt.Rows.Add("MYR (Malaysian Ringgit)", val.rates.MYR);
            dt.Rows.Add("MZN (Mozambican metical)", val.rates.MZN);
            dt.Rows.Add("NAD (Namibian Dollar)", val.rates.NAD);
            dt.Rows.Add("NGN (Nigerian Naira)", val.rates.NGN);
            dt.Rows.Add("NIO (Nicaraguan Córdoba)", val.rates.NIO);
            dt.Rows.Add("NOK (Norwegian Krone)", val.rates.NOK);
            dt.Rows.Add("NPR (Nepalese Rupee)", val.rates.NPR);
            dt.Rows.Add("NZD (New Zealand Dollar)", val.rates.NZD);
            dt.Rows.Add("OMR (Omani Rial)", val.rates.OMR);
            dt.Rows.Add("PAB (Panamanian Balboa)", val.rates.PAB);
            dt.Rows.Add("PEN (Peruvian Sol)", val.rates.PEN);
            dt.Rows.Add("PGK (Papua New Guinean Kina)", val.rates.PGK);
            dt.Rows.Add("PHP (Philippine Peso)", val.rates.PHP);
            dt.Rows.Add("PKR (Pakistani Rupee)", val.rates.PKR);
            dt.Rows.Add("PLN (Polish Zloty)", val.rates.PLN);
            dt.Rows.Add("PYG (Paraguayan Guarani)", val.rates.PYG);
            dt.Rows.Add("QAR (Qatari Riyal)", val.rates.QAR);
            dt.Rows.Add("RON (Romanian Leu)", val.rates.RON);
            dt.Rows.Add("RSD (Serbian Dinar)", val.rates.RSD);
            dt.Rows.Add("RUB (Russian Ruble)", val.rates.RUB);
            dt.Rows.Add("RWF (Rwandan Franc)", val.rates.RWF);
            dt.Rows.Add("SAR (Saudi Riyal)", val.rates.SAR);
            dt.Rows.Add("SBD (Solomon Islands Dollar)", val.rates.SBD);
            dt.Rows.Add("SCR (Seychellois Rupee)", val.rates.SCR);
            dt.Rows.Add("SDG (Sudanese pound)", val.rates.SDG);
            dt.Rows.Add("SEK (Swedish Krona)", val.rates.SEK);
            dt.Rows.Add("SGD (Singapore Dollar)", val.rates.SGD);
            dt.Rows.Add("SHP (Saint Helenian Pound)", val.rates.SHP);
            dt.Rows.Add("SLL (Sierra Leonean Leone)", val.rates.SLL);
            dt.Rows.Add("SOS (Somali Shilling)", val.rates.SOS);
            dt.Rows.Add("SRD (Surinamese Dollar)", val.rates.SRD);
            dt.Rows.Add("SSP (South Sudanese Pound)", val.rates.SSP);
            dt.Rows.Add("STD", val.rates.STD);
            dt.Rows.Add("STN (Sao Tomean Dobra)", val.rates.STN);
            dt.Rows.Add("SVC (Salvadoran Colón)", val.rates.SVC);
            dt.Rows.Add("SYP (Syrian Pound)", val.rates.SYP);
            dt.Rows.Add("SZL (Swazi Lilangeni)", val.rates.SZL);
            dt.Rows.Add("THB (Thai Baht)", val.rates.THB);
            dt.Rows.Add("TJS (Tajikistani Somoni)", val.rates.TJS);
            dt.Rows.Add("TMT (Turkmenistani Manat)", val.rates.TMT);
            dt.Rows.Add("TND (Tunisian Dinar)", val.rates.TND);
            dt.Rows.Add("TOP (Tongan Paʻanga)", val.rates.TOP);
            dt.Rows.Add("TRY (Turkish lira)", val.rates.TRY);
            dt.Rows.Add("TTD (Trinidad & Tobago Dollar)", val.rates.TTD);
            dt.Rows.Add("TWD (New Taiwan dollar)", val.rates.TWD);
            dt.Rows.Add("TZS (Tanzanian Shilling)", val.rates.TZS);
            dt.Rows.Add("UAH (Ukrainian hryvnia)", val.rates.UAH);
            dt.Rows.Add("UGX (Ugandan Shilling)", val.rates.UGX);
            dt.Rows.Add("USD (United States Dollar)", val.rates.USD);
            dt.Rows.Add("UYU (Uruguayan Peso)", val.rates.UYU);
            dt.Rows.Add("UZS (Uzbekistani Som)", val.rates.UZS);
            dt.Rows.Add("VES (Venezuelan Bolívar)", val.rates.VES);
            dt.Rows.Add("VND (Vietnamese dong)", val.rates.VND);
            dt.Rows.Add("VUV (Ni-Vanuatu Vatu)", val.rates.VUV);
            dt.Rows.Add("WST (Samoan Tala)", val.rates.WST);
            dt.Rows.Add("XAF (Central African CFA franc)", val.rates.XAF);
            dt.Rows.Add("XAG (Silver Ounce)", val.rates.XAG);
            dt.Rows.Add("XAU (Gold Ounce)", val.rates.XAU);
            dt.Rows.Add("XCD (East Caribbean Dollar)", val.rates.XCD);
            dt.Rows.Add("XDR (IMF Special Drawing Rights)", val.rates.XDR);
            dt.Rows.Add("XOF (West African CFA franc)", val.rates.XOF);
            dt.Rows.Add("XPD (Palladium Ounce)", val.rates.XPD);
            dt.Rows.Add("XPF (CFP Franc)", val.rates.XPF);
            dt.Rows.Add("XPT (Platinum Ounce)", val.rates.XPT);
            dt.Rows.Add("YER (Yemeni Rial)", val.rates.YER);
            dt.Rows.Add("ZAR (South African Rand)", val.rates.ZAR);
            dt.Rows.Add("ZMW (Zambian Kwacha)", val.rates.ZMW);
            dt.Rows.Add("ZWL (Zimbabwean Dollar)", val.rates.ZWL);



            //Datatable data assign From currency Combobox
            cmbFromCurrency.ItemsSource = dt.DefaultView;

            //DisplayMemberPath property is used to display data in Combobox
            cmbFromCurrency.DisplayMemberPath = "Text";

            //SelectedValuePath property is used to set value in Combobox
            cmbFromCurrency.SelectedValuePath = "Rate";

            //SelectedIndex property is used for when bind Combobox it's default selected item is first
            cmbFromCurrency.SelectedIndex = 0;

            //All Property Set For To Currency Combobox As From Currency Combobox
            cmbToCurrency.ItemsSource = dt.DefaultView;
            cmbToCurrency.DisplayMemberPath = "Text";
            cmbToCurrency.SelectedValuePath = "Rate";
            cmbToCurrency.SelectedIndex = 0;
        }
        #endregion

        #region Extra Events

        //ClearControls used for clear all controls input which user entered
        private void ClearControls()
        {
            txtCurrency.Text = string.Empty;
            if (cmbFromCurrency.Items.Count > 0)
                cmbFromCurrency.SelectedIndex = 0;
            if (cmbToCurrency.Items.Count > 0)
                cmbToCurrency.SelectedIndex = 0;
            lblCurrency.Content = "";
            txtCurrency.Focus();
        }

        //Allow only integer in textbox
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        #endregion

        #region Button Click Event

        //Assign convert button click event
        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            //Declare ConvertedValue with double DataType for store currency converted value
            double ConvertedValue;

            //Check amount textbox is Null or Blank
            if (txtCurrency.Text == null || txtCurrency.Text.Trim() == "")
            {
                //If amount textbox is Null or Blank then show this message box
                MessageBox.Show("Please Enter Currency", "Information", MessageBoxButton.OK, MessageBoxImage.Information);

                //After click on Messagebox OK set focus on amount textbox
                txtCurrency.Focus();
                return;
            }
            //Else if currency From is not selected or default text --SELECT--
            else if (cmbFromCurrency.SelectedValue == null || cmbFromCurrency.SelectedIndex == 0 || cmbFromCurrency.Text == "--SELECT--")
            {
                //Then show message box
                MessageBox.Show("Please Select Currency From", "Information", MessageBoxButton.OK, MessageBoxImage.Information);

                //Set focus on From Combobox
                cmbFromCurrency.Focus();
                return;
            }
            //Else if currency To is not selected or default text --SELECT--
            else if (cmbToCurrency.SelectedValue == null || cmbToCurrency.SelectedIndex == 0 || cmbToCurrency.Text == "--SELECT--")
            {
                //Then show message
                MessageBox.Show("Please Select Currency To", "Information", MessageBoxButton.OK, MessageBoxImage.Information);

                //Set focus on To Combobox
                cmbToCurrency.Focus();
                return;
            }

            //If From and To Combobox selects same value
            if (cmbFromCurrency.Text == cmbToCurrency.Text)
            {
                //Amount textbox value set in ConvertedValue. double.parse is used to change Datatype String To Double. Textbox text have String and ConvertedValue is double datatype
                ConvertedValue = double.Parse(txtCurrency.Text);

                //Show in label converted currency and converted currency name. And ToString("N3") is used for placing 000 after dot(.)
                lblCurrency.Content = cmbToCurrency.Text + " " + ConvertedValue.ToString("N3");
            }
            else
            {
                //Calculation for currency converter is From currency value is multiplied(*) with amount textbox value and then that total is divided(/) with To currency value.                
                ConvertedValue = (double.Parse(cmbToCurrency.SelectedValue.ToString()) * double.Parse(txtCurrency.Text)) / double.Parse(cmbFromCurrency.SelectedValue.ToString());

                //Show the label converted currency and converted currency name.
                lblCurrency.Content = cmbToCurrency.Text + " " + ConvertedValue.ToString("N3");
            }
        }

        //Assign a clear button click event
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            //ClearControls method is used to clear all control values
            ClearControls();
        }
        #endregion
    }
}
