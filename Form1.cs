using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
using System.Windows.Forms;

namespace ParseFileForDataProcessing
{
    public partial class Form1 : Form
    {
        string gbl_save_filename = "";
        string gbl_open_filename = "";


        public bool isNumeric(string val, System.Globalization.NumberStyles NumberStyle)
        {
            Double result;
            return Double.TryParse(val, NumberStyle,
                System.Globalization.CultureInfo.CurrentCulture, out result);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog Dialog = new SaveFileDialog())
            {

                if (Dialog.ShowDialog() == DialogResult.OK)
                    gbl_save_filename = Dialog.FileName;
                else
                    return;
            }

            using (OpenFileDialog Dialog = new OpenFileDialog())
            {
                if (Dialog.ShowDialog() == DialogResult.OK)
                    gbl_open_filename = Dialog.FileName;
                else
                    return;
            }

            checkBox1.Font = new Font(checkBox1.Font, FontStyle.Regular);
            checkBox1.Checked = false;

            #region parsing

            try
            {
//                using (StreamWriter outfile2 = new StreamWriter(gbl_save_filename + "1"))
//                {
                    using (StreamWriter outfile = new StreamWriter(gbl_save_filename))
                    {
                        using (StreamReader infile = new StreamReader(gbl_open_filename))
                        {
                            String line;
                            int count = 0;

                            //Read the first line of text
                            line = infile.ReadLine();

                            //Continue to read until you reach end of file
                            while (line != null)
                            {

                                #region cr_sr_RB
                                if (cr_sr_RB.Checked == true)
                                {

                                    line = line.Replace(header_TB.Text, null);
                                    string[] a = line.Split(textBox2.Text.ToCharArray());

                                    if ((a.Length == data_fields_NUD.Value))// && (test == true))
                                    {

                                    StringBuilder sb = new StringBuilder();

                                    for (int i = 0; i < data_fields_NUD.Value; i++)
                                    {
                                        Double n;
                                        bool isNumeric = Double.TryParse((a[i].TrimStart()).TrimEnd(), out n);
                                        if (isNumeric)
                                        {
                                            sb.Append((a[i].TrimStart()).TrimEnd());
                                            sb.Append(" ");
                                        }
                                    }

                                    string myString = sb.ToString().TrimEnd();
                                    outfile.WriteLine(myString);

                                    }
                                }
                                #endregion


                                count++;
                                line = infile.ReadLine();
                            }

                            checkBox1.Font = new Font(checkBox1.Font, FontStyle.Bold);
                            checkBox1.Checked = true;
                        }
                   }
//                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            #endregion
        }

    }
}