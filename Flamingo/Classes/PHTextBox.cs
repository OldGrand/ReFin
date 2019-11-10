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
        System.Drawing.Color DefaultColor;
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
    }
}
