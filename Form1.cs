using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberToWords
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl_terbilang.Visible = false;
        }

        private void btn_konv_Click(object sender, EventArgs e)
        {
            try
            {
                string Number = tb_angka.Text;
                string Terbilang = KonversiAngka(Number);
                lbl_terbilang.Text = Terbilang.First().ToString().ToUpper() + Terbilang.Substring(1);
                lbl_terbilang.Visible = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static String Satuan(String Number)
        {
            int _Number = Convert.ToInt32(Number);
            String Name = "";
            switch (_Number)
            {
                case 1:
                    Name = "satu"; break;
                case 2:
                    Name = "dua"; break;
                case 3:
                    Name = "tiga"; break;
                case 4:
                    Name = "empat"; break;
                case 5:
                    Name = "lima"; break;
                case 6:
                    Name = "enam"; break;
                case 7:
                    Name = "tujuh"; break;
                case 8:
                    Name = "delapan"; break;
                case 9:
                    Name = "sembilan"; break;
            }
            return Name;
        }

        private static String Puluhan(String Number)
        {
            int _Number = Convert.ToInt32(Number);
            String Name = null;
            switch (_Number)
            {
                case 10:
                    Name = "sepuluh"; break;
                case 11:
                    Name = "sebelas"; break;
                case 12:
                    Name = "dua belas"; break;
                case 13:
                    Name = "tiga belas"; break;
                case 14:
                    Name = "empat belas"; break;
                case 15:
                    Name = "lima belas"; break;
                case 16:
                    Name = "enam belas"; break;
                case 17:
                    Name = "tujuh belas"; break;
                case 18:
                    Name = "delapan belas"; break;
                case 19:
                    Name = "sembilan belas"; break;
                case 20:
                    Name = "dua puluh"; break;
                case 30:
                    Name = "tiga puluh"; break;
                case 40:
                    Name = "empat puluh"; break;
                case 50:
                    Name = "lima puluh"; break;
                case 60:
                    Name = "enam puluh"; break;
                case 70:
                    Name = "tujuh puluh"; break;
                case 80:
                    Name = "delapan puluh"; break;
                case 90:
                    Name = "sembilan puluh"; break;
                default:
                    if (_Number > 0)
                    {
                        Name = Puluhan(Number.Substring(0, 1) + "0") + " " + Satuan(Number.Substring(1));
                    } break;
            }
            return Name;
        }

        private static String KonversiAngka(String Number)
        {
            string Word = "";
            try
            {
                bool beginsZero = false;//tests for 0XX    
                bool isDone = false;//test if already translated    
                double dblAmt = (Convert.ToDouble(Number));
                //if ((dblAmt > 0) && number.StartsWith("0"))    
                if (dblAmt > 0)
                {//test for zero or digit zero in a numeric    
                    beginsZero = Number.StartsWith("0");

                    int numDigits = Number.Length;
                    int pos = 0;//store digit grouping    
                    String place = "";//digit grouping name:hundres,thousand,etc...    
                    switch (numDigits)
                    {
                        case 1://ones' range    

                            Word = Satuan(Number);
                            isDone = true;
                            break;
                        case 2://tens' range    
                            Word = Puluhan(Number);
                            isDone = true;
                            break;
                        case 3://hundreds' range    
                            pos = (numDigits % 3) + 1;
                            place = " ratus ";
                            break;
                        case 4://thousands' range    
                        case 5:
                        case 6:
                            pos = (numDigits % 4) + 1;
                            place = " ribu ";
                            break;
                        case 7://millions' range    
                        case 8:
                        case 9:
                            pos = (numDigits % 7) + 1;
                            place = " juta ";
                            break;
                        case 10://Billions's range    
                        case 11:
                        case 12:
                            pos = (numDigits % 10) + 1;
                            place = " miliar ";
                            break;
                        //add extra case options for anything above Billion...    
                        default:
                            isDone = true;
                            break;
                    }
                    if (!isDone)
                    {
                        // Untuk angka yang digit ke-1 sampai akhir bukan 0    
                        if (Number.Substring(0, pos) != "0" && Number.Substring(pos) != "0")
                        {
                            try
                            {
                                string TempWord;
                                // Agar pengecekan kondisi hanya berlaku untuk 100 dan 1000
                                if (Number.Substring(0, 1) == "1" && (numDigits == 3 || numDigits == 4))
                                {
                                    place = place.Remove(0, 1);
                                    TempWord = "se" + place;
                                }
                                else
                                {
                                    TempWord = KonversiAngka(Number.Substring(0, pos)) + place;
                                }
                                Word = TempWord + KonversiAngka(Number.Substring(pos));
                                Console.WriteLine("Baris 1 tercetak");
                            }
                            catch { }
                        }
                        else
                        {
                            // Untuk angka yang setelah digit ke-1 sampai akhir berupa 0
                            Word = KonversiAngka(Number.Substring(0, pos)) + KonversiAngka(Number.Substring(pos));
                        }
                        
                        //check for trailing zeros    
                        //if (beginsZero) word = " and " + word.Trim();    
                    }
                    Console.WriteLine("Baris 3 tercetak");
                    //ignore digit grouping names    
                    //if (Word.Trim().Equals(place.Trim())) Word = "";
                }
            }
            catch { }
                        
            return Word.Trim();
        }
    }
}
