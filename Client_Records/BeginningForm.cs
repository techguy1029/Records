using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Records
{
    public partial class BeginningForm : Form
    {
        public BeginningForm()
        {
            InitializeComponent();
            buttonNewEntry.TextAlign = ContentAlignment.MiddleCenter;
            databaseOperations.setUpLocalDb();
        }

        private void buttonNewEntry_Click(object sender, EventArgs e)
        {

        }

        private void BeginningForm_Load(object sender, EventArgs e)
        {

        }
    }
}
