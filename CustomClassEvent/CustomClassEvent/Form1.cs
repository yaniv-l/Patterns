using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomClassEvent
{
    public partial class Form1 : Form
    {
        Frog _frog;
        public Form1()
        {
            InitializeComponent();
            _frog = new Frog(5);
            _frog.Jump += OnJump;
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(OnKeyPressLocal);
        }

        private void OnJump(Object s, EventArgs e)
        {
            MessageBox.Show("Frog has jumped");
        }

        private void OnKeyPressLocal(Object sender, KeyPressEventArgs e)
        {
            _frog.CountKey = 1;
        }
    }
}
