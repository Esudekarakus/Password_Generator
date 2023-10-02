using System.DirectoryServices.ActiveDirectory;

namespace odev_rastgelesifre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> parolalar = new List<string>();

        string[] ozelKarakterler = { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+", "-", "=", "[","]", "{", "}", "|", ";", ":", "'", "/", ".", "?", "+", "<", ">" };
        string[] harfler= {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};

        int sayac=0;
        string sifre = string.Empty;
        Random rnd = new Random();
        private void btnSifreUret_Click(object sender, EventArgs e)
        {
            decimal sifreUzunluk = numericUpDown1.Value;
            decimal sifreSayisi = numericUpDown2.Value;

            while(sayac<sifreSayisi)
            {
                for (int i = 0; i < sifreUzunluk;)
                {
                    int indis = rnd.Next(0, 28);
                    int indish = rnd.Next(0, 26);
                    if (cboxRakam.Checked)
                    {
                        string sayi = rnd.Next(0, 10).ToString();
                        sifre = sifre + sayi;
                        i++;
                        if(i == sifreSayisi)
                            break;
                    }
                    if (cboxOzel.Checked)
                    {
                        sifre = sifre + ozelKarakterler[indis];
                        i++;
                        if (i == sifreSayisi)
                            break;
                    }
                    if (cboxKucukHarf.Checked)
                    {
                        sifre = sifre + harfler[indish].ToLower();
                        i++;
                        if (i == sifreSayisi)
                            break;
                    }
                    if(cboxBuyukHarf.Checked)
                    {
                        sifre = sifre + harfler[indish];
                        i++;
                        if (i == sifreSayisi)
                            break;
                    }




                }


                parolalar.Add(sifre);
                sayac++;


               


                
               

            

            }

            Form2 form2 = new Form2(parolalar);



            form2.Show();

        }
    }
}