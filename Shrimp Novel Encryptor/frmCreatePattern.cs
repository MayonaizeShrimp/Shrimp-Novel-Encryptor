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
    public partial class frmCreatePattern : Form
    {
        //======================================//
        //                                      //
        //          VARIABLE DECLARATION        //
        //            MayonaizeShrimp           //
        //                                      //
        //======================================//

        //Normal alphabet
        char[] normal = {'a', 'b', 'c', 'd', 'e',
            'f', 'g', 'h', 'i', 'j',
            'k', 'l', 'm', 'n', 'o',
            'p', 'q', 'r', 's', 't',
            'u', 'v', 'w', 'x', 'y', 'z'
        };

        //======================================//
        //                                      //
        //               FUNCTIONS              //
        //            MayonaizeShrimp           //
        //                                      //
        //======================================//

        
        //Get pattern
        private string getPattern()
        {
            string pattern = "";

            pattern = txtA.Text + txtB.Text + txtC.Text + txtD.Text + txtE.Text + 
                txtF.Text + txtG.Text + txtH.Text + txtI.Text + txtJ.Text + txtK.Text + 
                txtL.Text + txtM.Text + txtN.Text + txtO.Text + txtP.Text + txtQ.Text + 
                txtR.Text + txtS.Text + txtT.Text + txtU.Text + txtV.Text + txtW.Text + 
                txtX.Text + txtY.Text + txtZ.Text;

            return pattern;
        }

        //Get key to create the font
        private string getKey(string pattern)
        {
            string key = "";
            var array = new char[26];
            int counter = 0;

            for (int i = 0; i < 26; i++) array[i] = normal[i];

            foreach (char i in pattern)
            {   
                int index = (int)i - 97;
                int temp = counter++ + 97;
                array[index] = (char) temp;
            }

            foreach(char i in array)
            {
                key += i;
            }
            
            return key;
        }

        //Create and save the file
        private void saveFile()
        {
            if (savePattern.ShowDialog() == DialogResult.OK)
            {
                string pattern = getPattern();
                string key = getKey(pattern);

                using (StreamWriter writer = new StreamWriter(savePattern.FileName))
                {
                    writer.WriteLine(key.ToLower());
                    writer.WriteLine("PATTERN#"+pattern.ToLower());
                }
                MessageBox.Show("File saved successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("There's an error in saving file");
            }
        }

        //======================================//
        //                                      //
        //        FORM OBJECTS INTERACTION      //
        //             MayonaizeShrimp          //
        //                                      //
        //======================================//

        //============Constructor===========//
        public frmCreatePattern()
        {
            InitializeComponent();
        }

        //============BUTTON INTERACTIONS==========//
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtA.Text = "a";
            txtB.Text = "b";
            txtC.Text = "c";
            txtD.Text = "d";
            txtE.Text = "e";
            txtF.Text = "f";
            txtG.Text = "g";
            txtH.Text = "h";
            txtI.Text = "i";
            txtJ.Text = "j";
            txtK.Text = "k";
            txtL.Text = "l";
            txtM.Text = "m";
            txtN.Text = "n";
            txtO.Text = "o";
            txtP.Text = "p";
            txtQ.Text = "q";
            txtR.Text = "r";
            txtS.Text = "s";
            txtT.Text = "t";
            txtU.Text = "u";
            txtV.Text = "v";
            txtW.Text = "w";
            txtX.Text = "x";
            txtY.Text = "y";
            txtZ.Text = "z";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        //============TEXT BOX INTERACTIONS=============//

        //Will empty the box when clicked
        private void txtA_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
        }
        private void txtB_Click(object sender, EventArgs e)
        {
            txtB.Text = "";
        }
        private void txtC_Click(object sender, EventArgs e)
        {
            txtC.Text = "";
        }
        private void txtD_Click(object sender, EventArgs e)
        {
            txtD.Text = "";
        }
        private void txtE_Click(object sender, EventArgs e)
        {
            txtE.Text = "";
        }
        private void txtF_Click(object sender, EventArgs e)
        {
            txtF.Text = "";
        }
        private void txtG_Click(object sender, EventArgs e)
        {
            txtG.Text = "";
        }
        private void txtH_Click(object sender, EventArgs e)
        {
            txtH.Text = "";
        }
        private void txtI_Click(object sender, EventArgs e)
        {
            txtI.Text = "";
        }
        private void txtJ_Click(object sender, EventArgs e)
        {
            txtJ.Text = "";
        }
        private void txtK_Click(object sender, EventArgs e)
        {
            txtK.Text = "";
        }
        private void txtL_Click(object sender, EventArgs e)
        {
            txtL.Text = "";
        }
        private void txtM_Click(object sender, EventArgs e)
        {
            txtM.Text = "";
        }
        private void txtN_Click(object sender, EventArgs e)
        {
            txtN.Text = "";
        }
        private void txtO_Click(object sender, EventArgs e)
        {
            txtO.Text = "";
        }
        private void txtP_Click(object sender, EventArgs e)
        {
            txtP.Text = "";
        }
        private void txtQ_Click(object sender, EventArgs e)
        {
            txtQ.Text = "";
        }
        private void txtR_Click(object sender, EventArgs e)
        {
            txtR.Text = "";
        }
        private void txtS_Click(object sender, EventArgs e)
        {
            txtS.Text = "";
        }
        private void txtT_Click(object sender, EventArgs e)
        {
            txtT.Text = "";
        }
        private void txtU_Click(object sender, EventArgs e)
        {
            txtU.Text = "";
        }
        private void txtV_Click(object sender, EventArgs e)
        {
            txtV.Text = "";
        }
        private void txtW_Click(object sender, EventArgs e)
        {
            txtW.Text = "";
        }
        private void txtX_Click(object sender, EventArgs e)
        {
            txtX.Text = "";
        }
        private void txtY_Click(object sender, EventArgs e)
        {
            txtY.Text = "";
        }
        private void txtZ_Click(object sender, EventArgs e)
        {
            txtZ.Text = "";
        }
    }
}
