using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoToysPayrollSystem
{
    internal class MessageBox
    {

        public static DialogResult Show(string text, string caption)
        {
            DialogResult result;
            using (var msgForm = new CustomMessageBox(text, caption))
                result = msgForm.ShowDialog();
            return result;
        }
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
        {
            DialogResult result;
            using (var msgForm = new CustomMessageBox(text, caption, buttons))
                result = msgForm.ShowDialog();
            return result;
        }
        public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            DialogResult result;
            using (var msgForm = new CustomMessageBox(text, caption, buttons, icon))
                result = msgForm.ShowDialog();
            return result;
        }
    }
}
