using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Logbook.Properties;

namespace Logbook
{
    public partial class UserControl : System.Windows.Forms.UserControl
    {
        public Guna2Button diamondCount { get; set; }
        public bool IsChecked { get; set; }
        public void IsPresent()
        {
            greenRadio.Checked = true;
        }

        List<string> classWorkScore = new List<string>
        {
            "-","12","11","10","9","8","7","6","5","4","3","2","1","0"
        };

        List<string> controlWorkScore = new List<string>
        {
            "-","12","11","10","9","8","7","6","5","4","3","2","1","0"
        };
        public UserControl()
        {
            InitializeComponent();
            /*controlCombo.DataSource = controlWorkScore;
            classCombo.DataSource = classWorkScore;*/
        }

        public UserControl(User user)
        {
            InitializeComponent();
            diamondCount = new Guna2Button();
            controlCombo.DataSource = controlWorkScore;
            classCombo.DataSource = classWorkScore;
            idLbl.Text = user.Id.ToString();
            fullnameLbl.Text = user.GetFullName();
            timeLbl.Text = user.LastDate;

        }


        private void controlCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*controlCombo.FillColor = Color.FromArgb(177, 156, 219);
            controlCombo.ForeColor = Color.White;*/

            if (controlCombo.Text == "-")
            {
                //controlCombo.BorderColor = Color.FromArgb(177, 156, 219);
                controlCombo.FillColor = Color.White;
                controlCombo.ForeColor = Color.FromArgb(177, 156, 219);
            }
            else
            {
                controlCombo.FillColor = Color.FromArgb(177, 156, 219);
                controlCombo.ForeColor = Color.White;

            }
        }

        private void classCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (classCombo.Text == "-")
            {
                //classCombo.BorderColor = Color.FromArgb(177, 156, 219);
                classCombo.FillColor = Color.White;
                classCombo.ForeColor = Color.FromArgb(153, 204, 102);
            }
            else
            {
                classCombo.FillColor = Color.FromArgb(153, 204, 102);
                classCombo.ForeColor = Color.White;

            }
            /*classCombo.FillColor = Color.FromArgb(153, 204, 102);
            classCombo.ForeColor = Color.White;*/
        }

        private void diamonds_Click(object sender, EventArgs e)
        {
            diamondCount.Text = Form1.ActiveForm.Tag as string;

            var pb = sender as PictureBox;

            if (redRadio.Checked == false)
            {
                if (pb.Tag == "d1")
                {
                    diamond1.Image = Resources.diamond;
                    diamond2.Image = Resources.undiamond;
                    diamond3.Image = Resources.undiamond;
                    diamond1.Enabled = false;
                    diamondCount.Text = $"{Convert.ToInt32(diamondCount.Text) - 1}";
                }

                else if (pb.Tag == "d2")
                {
                    diamond1.Image = Resources.diamond;
                    diamond2.Image = Resources.diamond;
                    diamond3.Image = Resources.undiamond;
                    diamond1.Enabled = false;
                    diamond2.Enabled = false;
                    diamondCount.Text = $"{Convert.ToInt32(diamondCount.Text) - 2}";
                }

                else
                {
                    diamond1.Image = Resources.diamond;
                    diamond2.Image = Resources.diamond;
                    diamond3.Image = Resources.diamond;
                    diamond1.Enabled = true;
                    diamond2.Enabled = true;
                    diamond3.Enabled = true;
                    diamondCount.Text = $"{Convert.ToInt32(diamondCount.Text) - 3}";
                    if (pb.Tag == "d1")
                    {
                        diamond1.Image = Resources.diamond;
                        diamond2.Image = Resources.undiamond;
                        diamond3.Image = Resources.undiamond;
                        diamond1.Enabled = false;
                    }
                }
            }
            if (Convert.ToInt32(diamondCount.Text) == -1)
            {
                diamondCount.Text = "0";
            }
            Form1.ActiveForm.Tag = diamondCount.Text;




            /*if (redRadio.Checked == false)
            {
                if (pb.Tag == "d1")
                {
                    diamond1.Image = Resources.diamond;
                    diamond2.Image = Resources.undiamond;
                    diamond3.Image = Resources.undiamond;
                    diamond1.Enabled = false;
                    diamondCount.Text = $"{Convert.ToInt32(diamondCount.Text) - 1}";
                }
                else if (pb.Tag == "d2")
                {
                    diamond1.Image = Resources.diamond;
                    diamond2.Image = Resources.diamond;
                    diamond3.Image = Resources.undiamond;
                    diamond1.Enabled = false;
                    diamond2.Enabled = false;
                    diamondCount.Text = $"{Convert.ToInt32(diamondCount.Text) - 2}";
                }
                else
                {
                    diamond1.Image = Resources.diamond;
                    diamond2.Image = Resources.diamond;
                    diamond3.Image = Resources.diamond;
                    diamond1.Enabled = false;
                    diamond2.Enabled = false;
                    diamond3.Enabled = false;
                    diamondCount.Text = $"{Convert.ToInt32(diamondCount.Text) - 3}";
                }
            }
            Form1.ActiveForm.Tag = diamondCount.Text;*/
        }

        private void clearDiamond_Click(object sender, EventArgs e)
        {
            diamond1.Image = Resources.undiamond;
            diamond2.Image = Resources.undiamond;
            diamond3.Image = Resources.undiamond;
            diamond1.Enabled = true;
            diamond2.Enabled = true;
            diamond3.Enabled = true;
            diamondCount.Text = $"{Convert.ToInt32(diamondCount.Text) + 5}";

            Form1.ActiveForm.Tag = diamondCount.Text;
        }
    }
}
