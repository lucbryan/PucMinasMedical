using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AE_n_D
{
    public partial class AnfangForms : Form
    {
        public AnfangForms()
        {
            InitializeComponent();
            Thread thread = new Thread(new ThreadStart(Load));
            thread.Start();

        }
        public void Load()
        {
            SistemaClinica sistema = new SistemaClinica();
        }

    }
}
