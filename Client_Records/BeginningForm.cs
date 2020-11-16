using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            if (Directory.Exists("C:\\ProgramData\\Records\\Data.mdf"))
            {
                databaseOperations.setUpLocalDb();
                databaseOperations.setUpDbStructure();
            }
            databaseOperations.writeDataToDB("yeet", "yeet", "yeet", "yeet", "yeet", "yeet");
        }

        private void buttonNewEntry_Click(object sender, EventArgs e)
        {

        }

        private void BeginningForm_Load(object sender, EventArgs e)
        {

        }
    }
}
