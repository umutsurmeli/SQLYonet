using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLYonet
{
    public partial class CikisButon : UserControl
    {
        public CikisButon()
        {
            InitializeComponent();
        }
        public EventHandler CikiButonButtonClicked;
        public void Btn_Cikis_Click(object sender, EventArgs e)
        {
            if (CikiButonButtonClicked != null)
            {
                CikiButonButtonClicked(sender, e);
            }
        }

    }
}
