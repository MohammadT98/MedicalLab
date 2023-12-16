using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalLab
{
    public static class ToPersian
    {
        public static void EngNumToPrs(TextBox txb)
        {
            if (txb.Text != string.Empty)
            {
                txb.Text = txb.Text.Replace('۰', '0');
                txb.Text = txb.Text.Replace('۱', '1');
                txb.Text = txb.Text.Replace('۲', '2');
                txb.Text = txb.Text.Replace('۳', '3');
                txb.Text = txb.Text.Replace('۴', '4');
                txb.Text = txb.Text.Replace('۵', '5');
                txb.Text = txb.Text.Replace('۶', '6');
                txb.Text = txb.Text.Replace('۷', '7');
                txb.Text = txb.Text.Replace('۸', '8');
                txb.Text = txb.Text.Replace('۹', '9');
            }
        }

        public static void EngNumToPrs(ComboBox cmb)
        {
            if (cmb.Text != string.Empty)
            {
                cmb.Text = cmb.Text.Replace('۰', '0');
                cmb.Text = cmb.Text.Replace('۱', '1');
                cmb.Text = cmb.Text.Replace('۲', '2');
                cmb.Text = cmb.Text.Replace('۳', '3');
                cmb.Text = cmb.Text.Replace('۴', '4');
                cmb.Text = cmb.Text.Replace('۵', '5');
                cmb.Text = cmb.Text.Replace('۶', '6');
                cmb.Text = cmb.Text.Replace('۷', '7');
                cmb.Text = cmb.Text.Replace('۸', '8');
                cmb.Text = cmb.Text.Replace('۹', '9');
            }
        }

        public static void CheckPersian(TextBox txb)
        {
            if (txb.Text != string.Empty)
            {
                int temp = txb.SelectionStart;
                //persian numbers to english for regex
                Regex rgxPersianNumbers = new Regex("[۰۱۲۳۴۵۶۷۸۹]");
                if (rgxPersianNumbers.IsMatch(txb.Text))
                {
                    EngNumToPrs(txb);
                        txb.SelectionStart = temp;
                        txb.SelectionLength = 0;
                }
                //not English, only persian
                Regex rgx = new Regex(@"[a-zA-Z]");

                if (rgx.IsMatch(txb.Text))
                {
                    //replace english characters
                    txb.Text = Regex.Replace(txb.Text, @"[a-zA-Z]", "", RegexOptions.RightToLeft);

                    //cursor to end
                    txb.SelectionStart = temp;
                    txb.SelectionLength = 0;
                }
            }
        }

        public static void CheckPersianWithoutNumbers(TextBox txb)
        {
            if (txb.Text != string.Empty)
            {
                int temp = txb.SelectionStart;
                //persian numbers to english for regex
                Regex rgxPersianNumbers = new Regex("[۰۱۲۳۴۵۶۷۸۹]");
                if (rgxPersianNumbers.IsMatch(txb.Text))
                {
                    EngNumToPrs(txb);
                        txb.SelectionStart = temp;
                        txb.SelectionLength = 0;
                }
                //not English, only persian
                Regex rgx = new Regex(@"[a-zA-Z0-9]");

                if (rgx.IsMatch(txb.Text))
                {
                    //replace english characters
                    txb.Text = Regex.Replace(txb.Text, @"[a-zA-Z0-9]", "", RegexOptions.RightToLeft);

                    //cursor to end
                        txb.SelectionStart = temp;
                        txb.SelectionLength = 0;
                }
            }
        }
        public static void CheckPersianWithoutNumbers(ComboBox cmb)
        {
            if (cmb.Text != string.Empty)
            {
                int temp = cmb.SelectionStart;
                //persian numbers to english for regex
                Regex rgxPersianNumbers = new Regex("[۰۱۲۳۴۵۶۷۸۹]");
                if (rgxPersianNumbers.IsMatch(cmb.Text))
                {
                    EngNumToPrs(cmb);
                    cmb.SelectionStart = temp;
                    cmb.SelectionLength = 0;
                }
                //not English, only persian
                Regex rgx = new Regex(@"[a-zA-Z0-9]");

                if (rgx.IsMatch(cmb.Text))
                {
                    //replace english characters
                    cmb.Text = Regex.Replace(cmb.Text, @"[a-zA-Z0-9]", "", RegexOptions.RightToLeft);

                    //cursor to end
                    cmb.SelectionStart = temp;
                    cmb.SelectionLength = 0;
                }
            }
        }
    }
}
