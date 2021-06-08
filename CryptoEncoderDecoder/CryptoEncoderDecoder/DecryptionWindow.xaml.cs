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

namespace CryptoEncoderDecoder
{
    /// <summary>
    /// Interaction logic for EncryptionWindow.xaml
    /// </summary>
    public partial class DecryptionWindow : Window
    {
        public DecryptionWindow()
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

        public static string DecryptData(string PlainText, string KeyInput)
        {
            string EndResult = "";
            if (PlainText == null || PlainText.Length <= 0)//if theres no input refuse to work and simply return that its not a valid input.
            {
                EndResult = "Not a valid input";
                return EndResult;
            }
            else if (KeyInput == null || KeyInput.Length <= 0)
            {//if theres no key say then refuse to work and return that theres no key.
                EndResult = "No key provided";
                return EndResult;
            }
            List<char> CurrentStringBuffer = new List<char>();//create a dynamic list to allow for an unknown amount of items to be added!
            Char Seperator = (" ").ToCharArray()[0]; //i really dont know any way to do this, but this is how i created a space character...
            string[] SplitUpHexValues = PlainText.Split(Seperator);//Splits it up into chunks.

            try //if a user inputs invalid hexadecimal data it may end up erroring out, this stops it from crashing the program
            {
                for (int Index = 0; Index < SplitUpHexValues.Length; Index++)//creates a loop which will go through 0 to the length of plaintext this will be used to loop through the characters of the input string.
                {
                    int CharacterID = int.Parse(SplitUpHexValues[Index], System.Globalization.NumberStyles.HexNumber);//Grabs the value from the table, and converts the hexadecimal back into an integer.
                    int CharValue = CharacterID / (int)(KeyInput[((Index * 2) % KeyInput.Length)]);//Converts the Hexadecimal value back into a character, by doing the reverse formula of what the encryption does (since this is a symmetrical encryption mechanism)
                    char ConvertedCharValue = (char)CharValue;//convert from number back into character via ascii values.
                    CurrentStringBuffer.Add(ConvertedCharValue);//add to the array
                }
                EndResult = string.Join("", CurrentStringBuffer);//join all the items of the array together.
            } catch
            {
                EndResult = "Invalid Input data.";  //alerts the user that the data inputted is invalid.
            }
            


            return EndResult;//returns data
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string InputtedValue = MainInput.Text;//grabs main input
            string InputtedKey = KeyInput.Text;//grabs inputted key
            string EndResult = DecryptData(InputtedValue, InputtedKey);//Decrypts the data and returns it into EndResult

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
