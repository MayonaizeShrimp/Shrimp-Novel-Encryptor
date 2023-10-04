using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shrimp_Novel_Encryptor
{
    public partial class frmMain : Form
    {
        //======================================//
        //                                      //
        //          VARIABLE DECLARATION        //
        //            MayonaizeShrimp           //
        //                                      //
        //======================================//

        //About the Program
        string applicationName = "Udang Scrambler";
        string versionNumber = "1.0.0";
        string Author = "MayonaizeShrimp / udangmayones";

        //Normal alphabet
        char[] normal = {'a', 'b', 'c', 'd', 'e',
            'f', 'g', 'h', 'i', 'j',
            'k', 'l', 'm', 'n', 'o',
            'p', 'q', 'r', 's', 't',
            'u', 'v', 'w', 'x', 'y', 'z'
        };

        //Alphabet for substitution purposes
        char[] substitute = {'a', 'b', 'c', 'd', 'e',
            'f', 'g', 'h', 'i', 'j',
            'k', 'l', 'm', 'n', 'o',
            'p', 'q', 'r', 's', 't',
            'u', 'v', 'w', 'x', 'y', 'z'
        };

        
        string encType = "NONE";
        string pattern = "NONE";

        //======================================//
        //                                      //
        //               FUNCTIONS              //
        //            MayonaizeShrimp           //
        //                                      //
        //======================================//

        //Dump the content of the array of char for debug purposes
        private void dumpChar(char[] a)
        {
            String temp = "";
            foreach (char b in a)
            {
                temp += b;
            }

            MessageBox.Show(temp);
        }

        //Resize every objects in main form
        private void resizeEverything()
        {
            //Pindahkan posisi pembatas di setengahnya split container
            splitContainerMain.SplitterDistance = splitContainerMain.Width / 2;
            splitContainerLeft.SplitterDistance = splitContainerLeft.Width / 2;
            splitContainerRight.SplitterDistance = splitContainerRight.Width / 2;
        }

        //Copy the text into clipboard
        private void copyToClipboard(int flag)
        {
            if (flag == 1)
            {
                Clipboard.SetText(txtInputLeft.Text);
            }
            else if (flag == 2)
            {
                Clipboard.SetText(txtInputRight.Text);
            }
            else
            {
                MessageBox.Show("ERROR: nilai flag dari clipboard = " + flag);
            }
        }

        //=================PROGRESS BAR===================//
        private void resetProgressBar()
        {
            lblProgressBar.Text = "";
        }

        private void showProgress(long current, long total)
        {
            double progress = (current + 1 ) * 100 / total;
            lblProgressBar.Text = "PROGRESS: " + Math.Round(progress, 2) + "%";
        }

        //================ENCRYPT AND DECRYPT================//
        //Character Substitution for Encrypt
        private char switchCharacterE(char input)
        {
            char temp = input;

            for (int i = 0; i < 26; i++)
            {
                if (input.Equals(normal[i]))
                {

                    string sample = temp.ToString() + "[" + i + "] => " + substitute[i].ToString() + "[" + i + "]";

                    temp = substitute[i];
                    
                    break;
                }
            }

            return temp;
        }

        //Character Substitution for Decrypt
        private char switchCharacterD(char input)
        {
            char temp = input;

            for (int i = 0; i < 26; i++)
            {
                if (input.Equals(substitute[i]))
                {
                    temp = normal[i];
                    break;
                }
            }

            return temp;
        }
        
        //Encrypt Substitution
        private void encrypt()
        {
            String ori = txtInputLeft.Text;
            String hasil = "";
            long inputLength = ori.Length;
            long currentPosition = 0;

            disableEverything();
            resetProgressBar();

            //loop untuk setiap karakter
            foreach (char huruf in ori)
            {
                hasil += switchCharacterE(huruf);
                showProgress(currentPosition++, inputLength);
            }

            txtInputRight.Text = "[" + encType + "]";
            txtInputRight.Text += hasil;

            enableEverything();
        }

        //Decrypt Substitution
        private void decrypt()
        {
            String ori = txtInputRight.Text;
            String hasil = "";
            long inputLength = ori.Length;
            long currentPosition = 0;

            disableEverything();
            resetProgressBar();

            //loop untuk setiap karakter
            foreach (char huruf in ori)
            {
                hasil += switchCharacterD(huruf);
                showProgress(currentPosition++, inputLength);
            }

            txtInputLeft.Text = "[ORIGINAL]";
            txtInputLeft.Text += hasil;

            enableEverything();
        }
        
        //================FILE MANIPULATION================//
        //read file
        private void readFile()
        {
            DialogResult result = openFile.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFile.FileName;
                try
                {
                    //Display encryption type
                    encType = openFile.SafeFileName.ToUpper();
                    lblEncryptType.Text = "Enc Type: " + encType;

                    //read file content
                    string content = File.ReadAllText(file);

                    //split the possibly multiline text into list of strings
                    List<String> list = new List<String>(content.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries));

                    //just taking the first 2 lines
                    int lineNum = 0;
                    foreach (String text in list)
                    {
                        if (lineNum == 0)
                        {
                            int counter = 0;

                            //dividing each characters in the String
                            char[] temp = text.ToCharArray(0, text.Length);

                            //replace the substitue
                            foreach (char huruf in temp)
                            {
                                substitute[counter++] = huruf;
                                if (counter == 26) break;
                            }
                            
                            lineNum = 1;
                        }
                        else if (lineNum == 1)
                        {
                            List<string> line2 = new List<string>(text.Split('#'));

                            pattern = line2.LastOrDefault();

                            //finish after 2 lines
                            break; //remove everything else
                        }

                        
                    }

                    //readFile(fileName);
                }
                catch (IOException)
                {
                    MessageBox.Show("ERROR: Opening file error");
                }
            }
        }

        //======================================//
        //                                      //
        //        FORM OBJECTS INTERACTION      //
        //             MayonaizeShrimp          //
        //                                      //
        //======================================//

        
        //==================Constructor===================//
        public frmMain()
        {
            InitializeComponent();
        }


        //=========GENERAL OBJECTS MANIPULATIONS==========//
        //Disable Everything
        private void disableEverything()
        {
            menuGeneralMain.Enabled = false;
            btnEncrypt.Enabled = false;
        }

        //Enable Everything
        private void enableEverything()
        {
            menuGeneralMain.Enabled = true;
            btnEncrypt.Enabled = true;
        }
        
        //when the form is resized
        private void frmMain_Resize(object sender, EventArgs e)
        {
            resizeEverything();
        }

        //just the normal things
        private void frmMain_Load(object sender, EventArgs e)
        {
            //Change Title
            this.Text = applicationName + " v" + versionNumber;

            //ketika start, resize semuanya
            resizeEverything();
        }

        
        //============BUTTONS INTERACTIONS===============//
        private void btnCopyToClipboardLeft_Click(object sender, EventArgs e)
        {
            copyToClipboard(1);
        }

        private void btnCopyToClipboardRight_Click(object sender, EventArgs e)
        {
            copyToClipboard(2);
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            
            encrypt();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            decrypt();
        }

        private void btnClearLeft_Click(object sender, EventArgs e)
        {
            txtInputLeft.Text = "";
        }

        private void btnClearRight_Click(object sender, EventArgs e)
        {
            txtInputRight.Text = "";
        }



        //==============MENU BAR INTERACTIONS============//
        private void menuNew_Click(object sender, EventArgs e)
        {
            var createNewPatternWindow = new frmCreatePattern();
            createNewPatternWindow.Show();
        }

        private void menuCreateCrypt_Click(object sender, EventArgs e)
        {
            readFile();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuShowKey_Click(object sender, EventArgs e)
        {
            try
            {
                if (pattern.Equals("NONE"))
                {
                    MessageBox.Show("No Pattern Selected");
                }
                else
                {
                    MessageBox.Show("Please make a new font following pattern:\n" + pattern);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("ERROR: Reading pattern");
            }
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            string about =
                "App Name: " + applicationName +
                "\nVer Nmbr\t: " + versionNumber +
                "\nAuthor\t: " + Author +
                "\n\nDeveloped using Visual C# 2015" +
                "\nCopyrighted by MayonaizeShrimp Translations";

            MessageBox.Show(about);
        }

        private void mnuHelp_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://mayonaizeshrimp.wordpress.com/");
            }
            catch
                (
                 System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        //===============TEXT BOX INTERACTIONS===================//
        private void txtInputLeft_Click(object sender, EventArgs e)
        {
            if (txtInputLeft.Text.Equals("(Insert the original text here)"))
            {
                txtInputLeft.Text = "";
            }
        }

        private void txtInputRight_Click(object sender, EventArgs e)
        {
            if (txtInputRight.Text.Equals("(Insert the encrypted text here)"))
            {
                txtInputRight.Text = "";
            }
        }
        
    }
}
