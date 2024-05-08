using System.Diagnostics;

namespace shifr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char[] cyrillicChars = {
        'À', 'Á', 'Â', 'Ã', 'Ä', 'Å', '¨', 'Æ', 'Ç', 'È', 'É', 'Ê', 'Ë', 'Ì',
        'Í', 'Î', 'Ï', 'Ð', 'Ñ', 'Ò', 'Ó', 'Ô', 'Õ', 'Ö', '×', 'Ø', 'Ù', 'Ú',
        'Û', 'Ü', 'Ý', 'Þ', 'ß', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
        '.', ',', ':', '(', ')', '?', '!', '"', ';'};

        string[] morseAlphabetCyrillic = {
          ".-",    // À
          "-...",  // Á
          ".--",   // Â
          "--.",   // Ã
          "-..",   // Ä
          ".",     // Å
          "...-",  // Æ
          "--..",  // Ç
          "..",    // È
          ".---",  // É
          "-.-",   // Ê
          ".-..",  // Ë
          "--",    // Ì
          "-.",    // Í
          "---",   // Î
          ".--.",  // Ï
          ".-.",   // Ð
          "...",   // Ñ
          "-",     // Ò
          "..-",   // Ó
          "...-",  // Ô
          "----",  // Õ
          "-.-.",  // Ö
          "..-..", // ×
          "--.-",  // Ø
          "-.--",  // Û
          "-..-",  // Ü
          "--.-.", // Ý
          "..-.",  // Þ
          ".-.-",  // ß
          "-----", // 0
          ".----", // 1
          "..---", // 2
          "...--", // 3
          "....-", // 4
          ".....", // 5
          "-....", // 6
          "--...", // 7
          "---..", // 8
          "----.",  // 9
          "......",  // .
          "-.-.-.",  // ,
          "---...",  // :
          "-.--.-",  // (
          "-.--.-",  // )
          "..--..",  // ?
          "--..--",  // !
          ".-..-.",  // "
          "-.-.-.",  // ;
          };

        private void button1_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text.ToUpper();
            char[] charArray = inputText.ToCharArray();
            foreach (char c in charArray)
            {
                for (int p = 0; p < cyrillicChars.Length; p++)
                {
                    if (c == cyrillicChars[p])
                    {
                        textBox2.AppendText(morseAlphabetCyrillic[p]);
                        textBox2.AppendText(", ");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string inputText = textBox1.Text.ToUpper();
            char[] charArray = inputText.ToCharArray();
            string a = "";

            foreach (char c in charArray)
            {
                if (Convert.ToString(c) != ",")
                {
                    a += c;
                }
                else
                {
                    for (int p = 0; p < morseAlphabetCyrillic.Length; p++)
                    {
                        if (a == morseAlphabetCyrillic[p])
                        {
                            textBox2.AppendText(Convert.ToString(cyrillicChars[p]));
                        }
                    }
                    a = "";
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}