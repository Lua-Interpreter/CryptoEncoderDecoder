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
using System.Windows.Shapes;

using System.Security.Cryptography; //using this to allow me to make use of the SHA-256 algorithm

namespace CryptoEncoderDecoder
{
    /// <summary>
    /// Interaction logic for HashingWindow.xaml
    /// </summary>
    public partial class HashingWindow : Window
    {
        public HashingWindow()
        {
            InitializeComponent();
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MWindow = new MainWindow();
            MWindow.Owner = this;
            this.Hide();
            MWindow.Show();
            //Closes this window and opens the Main Window with the instructions
        }

        private void OptionsBTN_Click(object sender, RoutedEventArgs e)
        {
            if (OptionsMenu.Visibility == Visibility.Hidden)
            {
                OptionsMenu.Visibility = Visibility.Visible;

            }
            else
            {
                OptionsMenu.Visibility = Visibility.Hidden;
            }
            //shows or hides the OptionsMenu based on the click of the Options button, acting a bit like a drop down menu.
        }

        public static string HashData(string PlainText)
        {
            string EndResult = "";
            if (PlainText == null || PlainText.Length <= 0)//if theres no input refuse to work and simply return that its not a valid input.
            {
                EndResult = "Not a valid input";
                return EndResult;
            }

            using (SHA256 HashAlgo = SHA256.Create()) //creates the SHA-256 algorithm and assigns it to a class.
            {

                try //When running the SHA256 algorithm it may error if the user puts in some strange data, this handles making sure the program does not crash.
                {
                    //Since SHA-256 operates on a byte level, i need to take the text and convert the text data to an array of binary data.
                    //after that is done, i can then compute it using the Hash algorithm.
                    byte[] bytes = HashAlgo.ComputeHash(Encoding.UTF8.GetBytes(PlainText));
                    List<string> CurrentStringBuffer = new List<string>();//create a dynamic list to allow for an unknown amount of characters to be added!
                    for (int i = 0; i < bytes.Length; i++)//loops through all the byte array items.
                    {
                        CurrentStringBuffer.Add(bytes[i].ToString("x2"));//adds the converted string data which was binary to the dynamic array.
                    }
                    EndResult = string.Join("", CurrentStringBuffer);//join all the items of the array together.
                }
                catch
                {
                    EndResult = "Invalid Input data.";  //alerts the user that the data inputted is invalid.
                }

            }

            return EndResult;//returns data
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string InputtedValue = MainInput.Text;//grabs main input
            string EndResult = HashData(InputtedValue);//Hashes the data and returns it into EndResult

            OutputField.Text = EndResult;//Output field text is set to the end result
        }


        private void EncryptionBTN_Click(object sender, RoutedEventArgs e)
        {
            EncryptionWindow EncryptWindow = new EncryptionWindow();
            EncryptWindow.Owner = this;
            this.Hide();
            EncryptWindow.Show();
            //hides this window and open the encryption window.
        }

        private void DecryptionBTN_Click(object sender, RoutedEventArgs e)
        {
            DecryptionWindow DecryptWindow = new DecryptionWindow();
            DecryptWindow.Owner = this;
            this.Hide();
            DecryptWindow.Show();
            //hides this window and open the decryption window.
        }

        private void KeyEncryptBTN_Click(object sender, RoutedEventArgs e)
        {
            KeylessEncryptionWindow KeylessEncryptWindow = new KeylessEncryptionWindow();
            KeylessEncryptWindow.Owner = this;
            this.Hide();
            KeylessEncryptWindow.Show();
            //hides this window and open the keyless encryption window.
        }

        private void KeyDecryptBTN_Click(object sender, RoutedEventArgs e)
        {
            KeylessDecryptionWindow KeylessDecryptWindow = new KeylessDecryptionWindow();
            KeylessDecryptWindow.Owner = this;
            this.Hide();
            KeylessDecryptWindow.Show();
            //hides this window and open the keyless decryption window.
        }

        private void HashingBTN_Click(object sender, RoutedEventArgs e)
        {

            HashingWindow HashWindow = new HashingWindow();
            HashWindow.Owner = this;
            this.Hide();
            HashWindow.Show();
            //hides this window and open the hashing window.
        }
    }
}

