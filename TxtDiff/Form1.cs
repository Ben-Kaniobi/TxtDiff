using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frm_TxtDiff : Form
    {
        public frm_TxtDiff()
        {
            InitializeComponent();
        }

        Color col_del = Color.Red;
        Color col_add = Color.Green;

        Control FocusedControl;

        private void txt_A_TextChanged(object sender, EventArgs e)
        {
            if (txt_A.Text == "" && txt_B.Text == "")
            {
                btn_comp.Enabled = false;
            }
            else
            {
                btn_comp.Enabled = true;
            }
        }

        private void txt_B_TextChanged(object sender, EventArgs e)
        {
            if (txt_A.Text == "" && txt_B.Text == "")
            {
                btn_comp.Enabled = false;
            }
            else
            {
                btn_comp.Enabled = true;
            }
        }

        void AppendColoredText(RichTextBox box, string text, Color color)
        {
            //Select text
            box.SelectionStart = box.TextLength;
            box.SelectionLength = text.Length;

            //Change styles
            if (color == col_add) box.SelectionFont = new Font(box.SelectionFont, FontStyle.Underline);
            if (color == col_del) box.SelectionFont = new Font(box.SelectionFont, FontStyle.Strikeout);

            //Change color
            box.SelectionColor = color;

            box.AppendText(text);

            //Reset styles and color
            box.SelectionFont = box.Font;
            box.SelectionColor = box.ForeColor;
        }

        void compare()
        {
            txt_comp.Text = "";

            if (txt_A.Text == txt_B.Text)
            {
                AppendColoredText(txt_comp, "The two texts are the same.", Color.Blue);
                return;
            }

            string[] linesA = txt_A.Text.Split('\n').Select(s => s.Trim()).ToArray();
            string[] linesB = txt_B.Text.Split('\n').Select(s => s.Trim()).ToArray();

            int la = 0; //Line number of A
            int lb = 0; //Line number of B
            while(la < linesA.Length) //Every line
            {
                if (lb >= linesB.Length)
                {
                    //txt_comp.Text += "-" + linesA[la];
                    AppendColoredText(txt_comp, linesA[la], col_del);
                }
                else if (linesA[la] == linesB[lb])
                {
                    //txt_comp.Text += linesA[la];
                    AppendColoredText(txt_comp, linesA[la], txt_comp.ForeColor);
                }
                else
                {
                    //Line added
                    if ((lb+1 < linesB.Length) && (linesA[la] == linesB[lb+1]))
                    {
                        //txt_comp.Text += "+" + linesB[lb] + "\n" + linesA[la];
                        AppendColoredText(txt_comp, linesB[lb], col_add);
                        AppendColoredText(txt_comp, "\n" + linesA[la], txt_comp.ForeColor);

                        lb++;
                    }
                    //Line deleted
                    else if ((la + 1 < linesA.Length) && (linesA[la + 1] == linesB[lb]))
                    {
                        //txt_comp.Text += "-" + linesA[la] + "\n" + linesB[lb];
                        AppendColoredText(txt_comp, linesA[la], col_del);
                        AppendColoredText(txt_comp, "\n" + linesB[lb], txt_comp.ForeColor);

                        la++;
                    }
                    //Line changed
                    else
                    {
                        //Begin of word comparsion
                        //(pretty much the same as with lines)

                        string[] wordsA = linesA[la].Split(' ').Select(s => s.Trim()).ToArray();
                        string[] wordsB = linesB[lb].Split(' ').Select(s => s.Trim()).ToArray();

                        int wa = 0; //Word number of a
                        int wb = 0; //Word number of b
                        while (wa < wordsA.Length) //Every word
                        {
                            if (wb >= wordsB.Length)
                            {
                                //txt_comp.Text += "-" + wordsA[wa];
                                AppendColoredText(txt_comp, wordsA[wa], col_del);
                            }
                            else if (wordsA[wa] == wordsB[wb])
                            {
                                //txt_comp.Text += wordsA[wa];
                                AppendColoredText(txt_comp, wordsA[wa], txt_comp.ForeColor);
                            }
                            else
                            {
                                //Word added
                                if ((wb + 1 < wordsB.Length) && (wordsA[wa] == wordsB[wb + 1]))
                                {
                                    //txt_comp.Text += "+" + wordsB[wb] + " " + wordsA[wa];
                                    AppendColoredText(txt_comp, wordsB[wb], col_add);
                                    AppendColoredText(txt_comp, " " + wordsA[wa], txt_comp.ForeColor);

                                    wb++;
                                }
                                //Word deleted
                                else if ((wa + 1 < wordsA.Length) && (wordsA[wa + 1] == wordsB[wb]))
                                {
                                    //txt_comp.Text += "-" + wordsA[wa] + " " + wordsB[wb];
                                    AppendColoredText(txt_comp, wordsA[wa], col_del);
                                    AppendColoredText(txt_comp, " " + wordsB[wb], txt_comp.ForeColor);

                                    wa++;
                                }
                                //Word changed
                                else
                                {
                                    //txt_comp.Text += "-" + wordsA[wa] + "+" + wordsB[wb];
                                    AppendColoredText(txt_comp, wordsA[wa], col_del);
                                    AppendColoredText(txt_comp, wordsB[wb], col_add);
                                }
                            }
                            if (wa + 1 < wordsA.Length) AppendColoredText(txt_comp, " ", txt_comp.ForeColor);

                            if ((wordsB.Length >= wordsA.Length) && (wa + 1 == wordsA.Length))
                            {
                                //Line B is longer -> Append all added words
                                while (wb + 1 < wordsB.Length)
                                {
                                    wb++;
                                    //txt_comp.Text += " +" + wordsB[wb];
                                    AppendColoredText(txt_comp, " ", txt_comp.ForeColor);
                                    AppendColoredText(txt_comp, wordsB[wb], col_add);
                                }
                            }

                            wa++;
                            wb++;

                            //End of word comparison
                        }
                    }
                }
                if (la + 1 < linesA.Length) AppendColoredText(txt_comp, "\n", txt_comp.ForeColor);

                if ((linesB.Length >= linesA.Length) && (la + 1 == linesA.Length))
                {
                    //Text B is longer -> Append all added lines
                    while (lb + 1 < linesB.Length)
                    {
                        lb++;
                        //txt_comp.Text += "\n+" + linesB[lb];
                        AppendColoredText(txt_comp, "\n", txt_comp.ForeColor);
                        AppendColoredText(txt_comp, linesB[lb], col_add);
                    }
                }

                la++;
                lb++;
            }
        }

        void comp_checked(bool state)
        {
            lbl_A.Visible = !state;
            lbl_B.Visible = !state;

            txt_A.Enabled = !state;
            txt_B.Enabled = !state;
            spl_Texts.Visible = !state;

            txt_comp.Enabled = state;
            txt_comp.Visible = state;
        }

        private void btn_comp_CheckedChanged(object sender, EventArgs e)
        {
            if (btn_comp.Checked)
            {
                //Changes visible
                comp_checked(true);

                compare();
            }
            else
            {
                //Original texts visible
                comp_checked(false);
            }
        }

        private void btn_comp_GotFocus(object sender, EventArgs e)
        {
            FocusedControl = ActiveControl;
        }

        private void txt_A_GotFocus(object sender, EventArgs e)
        {
            FocusedControl = spl_Texts.ActiveControl;
        }

        private void txt_B_GotFocus(object sender, EventArgs e)
        {
            FocusedControl = spl_Texts.ActiveControl;
        }

        private void txt_comp_GotFocus(object sender, EventArgs e)
        {
            FocusedControl = ActiveControl;
        }

        private void chb_wordwrap_CheckedChanged(object sender, EventArgs e)
        {
            txt_A.WordWrap = chb_wordwrap.Checked;
            txt_B.WordWrap = chb_wordwrap.Checked;
            txt_comp.WordWrap = chb_wordwrap.Checked;

            //Focus back to last focused control
            FocusedControl.Focus();
        }
    }
}