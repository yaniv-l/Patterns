using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObserverPattern.Classes;

namespace ObserverPattern
{
    public partial class frmObserverPattern : Form
    {
        Subject _subject = new Subject();

        public frmObserverPattern()
        {
            InitializeComponent();
            Observer observer1 = new Observer(txtObserver1);
            Observer observer2 = new Observer(txtObserver2);

            this._subject.Subscribe(observer1);
            this._subject.Subscribe(observer2);
        }
        
        private void txtSubject_TextChanged(object sender, EventArgs e)
        {
            this._subject.change(txtSubject.Text);
        }
    }
}
