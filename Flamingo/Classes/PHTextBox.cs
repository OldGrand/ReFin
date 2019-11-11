using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flamingo.Classes
{
    class PHTextBox : System.Windows.Forms.TextBox
    {
        private const int WM_SETFOCUS = 0x07;
        private const int WM_ENABLE = 0x0A;
        private const int WM_SETCURSOR = 0x20;
        private string _placeHolder;

        public string PlaceHolderText
        {
            get
            {
                return _placeHolder;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    _placeHolder = value;
                    this.ForeColor = System.Drawing.Color.Gray;
                    this.Text = _placeHolder;
                }
            }
        }

        public PHTextBox() : base()
        {
            _placeHolder = "";

            this.GotFocus += (object sender, EventArgs e) =>
            {
                if(this.Text.Equals(_placeHolder))
                this.Text = String.Empty;
                this.ForeColor = Color.Black;
            };

            this.LostFocus += (Object sender, EventArgs e) => {
                if (String.IsNullOrEmpty(this.Text) || this.Text.Equals(_placeHolder))
                {
                    this.ForeColor = System.Drawing.Color.Gray;
                    this.Text = _placeHolder;
                }
                else
                {
                    this.ForeColor = Color.Black;
                }
            };
            if (!string.IsNullOrEmpty(_placeHolder))
            {
                this.ForeColor = System.Drawing.Color.Gray;
                this.Text = _placeHolder;
            }
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BackColor = Color.FromArgb(236, 229, 221);
            this.Font = new Font("Rockwell", 14, FontStyle.Regular);
        }

        //protected override void WndProc(ref System.Windows.Forms.Message m)
        //{
        //    if (this.Enabled && !(m.Msg == WM_SETFOCUS || m.Msg == WM_ENABLE || m.Msg == WM_SETCURSOR))
        //        base.WndProc(ref m);
        //}
    }
}
