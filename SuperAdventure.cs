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
        public SuperAdventure()
        {
            InitializeComponent();

            player = new Player
            {
                Name = null,
                CurrentHitPoints = 10,
                MaximumHitPoints = 10,
                Gold = 20,
                ExperiencePoints = 0,
                Level = 1
            };

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
