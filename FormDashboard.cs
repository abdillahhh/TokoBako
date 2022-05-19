using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTokoBako
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void labelHome_Click(object sender, EventArgs e)
        {

        }

        private void labelDataUser_Click(object sender, EventArgs e)
        {
            FormDataUser user = new FormDataUser();
            user.TopLevel = false;
            user.AutoScroll = true;
            this.panelKonten.Controls.Clear();
            this.panelKonten.Controls.Add(user);
            user.Show();
        }

        private void labelMasterData_Click(object sender, EventArgs e)
        {
            FormMasterData master = new FormMasterData();
            master.TopLevel = false;
            master.AutoScroll = true;
            this.panelKonten.Controls.Clear();
            this.panelKonten.Controls.Add(master);
            master.Show();
        }

        private void labelPendataan_Click(object sender, EventArgs e)
        {
            FormPendataan pen = new FormPendataan();
            pen.TopLevel = false;
            pen.AutoScroll = true;
            this.panelKonten.Controls.Clear();
            this.panelKonten.Controls.Add(pen);
            pen.Show();
        }

        private void labelLaporan_Click(object sender, EventArgs e)
        {
            FormLaporan formLaporan = new FormLaporan();
            formLaporan.TopLevel = false;
            formLaporan.AutoScroll = true;
            this.panelKonten.Controls.Clear();
            this.panelKonten.Controls.Add(formLaporan);
            formLaporan.Show();
        }
    }
}
