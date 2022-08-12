using Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private Player player;
        private Location location;
        public SuperAdventure()
        {
            InitializeComponent();

            location = new Location(1, "Casa", "Essa é a sua casa");

            player = new Player(null, 10, 0, 1, 10, 10);

            lblHitPoints.Text = player.CurrentHitPoints.ToString();
            lblGold.Text = player.Gold.ToString();
            lblExperience.Text = player.ExperiencePoints.ToString();
            lblLevel.Text = player.Level.ToString();

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            player.Name = txtName.Text;
            lblNome.Text = player.Name;

            lblNome.Visible = true;
            btnConfirmar.Visible = false;
            lblInputName.Visible = false;
            txtName.Visible = false;
        }
    }
}
