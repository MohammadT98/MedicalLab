using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MedicalLab
{
    public static class RegeX
    {
        public static void OnlyNumbers(TextBox txb)
        {
            if (txb.Text != string.Empty)
            {
                int temp = txb.SelectionStart;
                //persian numbers to english for regex
                Regex rgxPersianNumbers = new Regex("[۰۱۲۳۴۵۶۷۸۹]");
                if (rgxPersianNumbers.IsMatch(txb.Text))
                {
                    ToPersian.EngNumToPrs(txb);

                    txb.SelectionStart = temp;
                    txb.SelectionLength = 0;
                }
                Regex rgxChar = new Regex(@"[a-zA-Z]|[\u0600-\u06FF\s]");
                if (rgxChar.IsMatch(txb.Text))
                {
                    txb.Text = Regex.Replace(txb.Text, @"[a-zA-Z]|[\u0600-\u06FF\s]", "");

                    txb.SelectionStart = temp;
                    txb.SelectionLength = 0;
                }
            }
        }
        public static void OnlyNumbers(ComboBox cmb)
        {
            if (cmb.Text != string.Empty)
            {
                int temp = cmb.SelectionStart;
                //persian numbers to english for regex
                Regex rgxPersianNumbers = new Regex("[۰۱۲۳۴۵۶۷۸۹]");
                if (rgxPersianNumbers.IsMatch(cmb.Text))
                {
                    ToPersian.EngNumToPrs(cmb);

                    cmb.SelectionStart = temp;
                    cmb.SelectionLength = 0;
                }
                Regex rgxChar = new Regex(@"[a-zA-Z]|[\u0600-\u06FF\s]");
                if (rgxChar.IsMatch(cmb.Text))
                {
                    cmb.Text = Regex.Replace(cmb.Text, @"[a-zA-Z]|[\u0600-\u06FF\s]", "");

                    cmb.SelectionStart = temp;
                    cmb.SelectionLength = 0;
                }
            }
        }
    }
}
