using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace Flamingo.Extension_Classes
{
    public static class ExtensionClasses
    {
        public static bool EmailValidation(string email) => new Regex(@"^([A-Za-z0-9]+[\._]?[A-Za-z0-9]+)+@[a-zA-Z]+?\.[a-zA-Z]{2,6}$").IsMatch(email);

        public static void CenteringElements(ControlCollection controls, Size clientSize)
        {
            for (int i = 0; i < controls.Count; i++)
                if (controls[i].Tag != null && controls[i].Tag.Equals("Centering"))
                    controls[i].Left = clientSize.Width / 2 - controls[i].Width / 2;
        }
    }
}
