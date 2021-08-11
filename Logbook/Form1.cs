using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Logbook
{

    public partial class Form1 : Form
    {
        public List<UserControl> UserList = new List<UserControl>();
        public int LocX { get; set; }
        public int LocY { get; set; }
        public bool Pressed { get; set; } = true;

        public Form1()
        {
            InitializeComponent();
            LocX = mainPanel.Location.X;
            LocY = mainPanel.Location.Y;
            KeyPreview = true;
            User user1 = new User
            {
                Id = 1,
                Name = "Nicat",
                Surname = "Ceferli",
                FatherName = "Rasim",
                LastDate = DateTime.Now.AddDays(-2).ToString("MM/dd/yyyy")
            };
            User user2 = new User
            {
                Id = 2,
                Name = "Emiraslan",
                Surname = "Eliyev",
                FatherName = "Isa",
                LastDate = DateTime.Now.AddDays(-7).ToString("MM/dd/yyyy")
            };
            User user3 = new User
            {
                Id = 3,
                Name = "Ilqar",
                Surname = "Hesenzade",
                FatherName = "Ilham",
                LastDate = DateTime.Now.AddDays(-4).ToString("MM/dd/yyyy")
            };
            User user4 = new User
            {
                Id = 4,
                Name = "Kenan",
                Surname = "Idayatov",
                FatherName = "Ilqar",
                LastDate = DateTime.Now.AddDays(-3).ToString("MM/dd/yyyy")
            };
            User user5 = new User
            {
                Id = 5,
                Name = "Nebi",
                Surname = "Nebili",
                FatherName = "Elcin",
                LastDate = DateTime.Now.AddDays(-1).ToString("MM/dd/yyyy")
            };
            User user6 = new User
            {
                Id = 6,
                Name = "Yusif",
                Surname = "Rustamov",
                FatherName = "Habil",
                LastDate = DateTime.Now.AddDays(-5).ToString("MM/dd/yyyy")
            };
            User user7 = new User
            {

                Id = 7,
                Name = "Zahid",
                Surname = "Vahabzade",
                FatherName = "Yusif",
                LastDate = DateTime.Now.AddDays(-8).ToString("MM/dd/yyyy")
            };
            User user8 = new User
            {
                Id = 8,
                Name = "Emin",
                Surname = "Velizade",
                FatherName = "Elnur",
                LastDate = DateTime.Now.AddDays(-4).ToString("MM/dd/yyyy")
            };
            User user9 = new User
            {
                Id = 9,
                Name = "Emin",
                Surname = "Velizade",
                FatherName = "Elnur",
                LastDate = DateTime.Now.AddDays(-4).ToString("MM/dd/yyyy")
            };
            User user10 = new User
            {
                Id = 10,
                Name = "Emin",
                Surname = "Velizade",
                FatherName = "Elnur",
                LastDate = DateTime.Now.AddDays(-4).ToString("MM/dd/yyyy")
            };
            User user11 = new User
            {
                Id = 11,
                Name = "Emin",
                Surname = "Velizade",
                FatherName = "Elnur",
                LastDate = DateTime.Now.AddDays(-4).ToString("MM/dd/yyyy")
            };
            User user12 = new User
            {
                Id = 12,
                Name = "Emin",
                Surname = "Velizade",
                FatherName = "Elnur",
                LastDate = DateTime.Now.AddDays(-4).ToString("MM/dd/yyyy")
            };

            UserControl users1 = new UserControl(user1);
            UserList.Add(users1);
            UserControl users2 = new UserControl(user2);
            UserList.Add(users2);
            UserControl users3 = new UserControl(user3);
            UserList.Add(users3);
            UserControl users4 = new UserControl(user4);
            UserList.Add(users4);
            UserControl users5 = new UserControl(user5);
            UserList.Add(users5);
            UserControl users6 = new UserControl(user6);
            UserList.Add(users6);
            UserControl users7 = new UserControl(user7);
            UserList.Add(users7);
            UserControl users8 = new UserControl(user8);
            UserList.Add(users8);
            UserControl users9 = new UserControl(user9);
            UserList.Add(users9);
            UserControl users10 = new UserControl(user10);
            UserList.Add(users10);
            UserControl users11 = new UserControl(user11);
            UserList.Add(users11);
            UserControl users12 = new UserControl(user12);
            UserList.Add(users12);
            foreach (var user in UserList)
            {
                Controls.Add(user);
                mainPanel.Controls.Add(user);
                user.Controls.Owner.BringToFront();
                user.Dock = DockStyle.Top;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData != Keys.Escape) return;
            if
            (
                MessageBox.Show
                (
                    "Do you want to quit ?",
                    "Exit",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2
                ) == DialogResult.Yes
            )
            {
                Application.Exit();
            }
        }



        private void checkEveryoneRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkEveryoneRadio.Checked) return;
            foreach (var user in UserList)
            {
                user.IsPresent();
                checkEveryoneRadio.Checked = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tag = $"{diamondCount.Text}";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            diamondCount.Text = Tag as string;
        }

        private void teacher_Checked(object sender, EventArgs e)
        {
            mainPanel.Enabled = true;
        }

        private void changeSubjectTxt_Click(object sender, EventArgs e)
        {
            //LocX = mainPanel.Location.X;
            //LocY = mainPanel.Location.Y;
            if (mainTeacherRadio.Checked || substituteTeacherRadio.Checked)
            {
                if (Pressed)
                {
                    changeSubjectTxt.Size = new Size(200, 50);
                    mainPanel.Location = new Point(LocX, LocY + 20);
                    Pressed = false;
                    addMaterialBtn.Location = new Point(900, 85);
                    //acceptBtn.Location = new Point(900, 57);
                    acceptBtn.Visible = true;
                    //cancelBtn.Location = new Point(990, 57);
                    cancelBtn.Visible = true;
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            changeSubjectTxt.Size = new Size(23, 21);
            mainPanel.Location = new Point(LocX, LocY);
            addMaterialBtn.Location = new Point(1024, 67);
            changeSubjectTxt.Text = "";
            acceptBtn.Visible = false;
            cancelBtn.Visible = false;
            Pressed = true;

        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            changeSubjectTxt.Size = new Size(23, 21);
            mainPanel.Location = new Point(LocX, LocY);
            addMaterialBtn.Location = new Point(1024, 67);
            changeSubjectTxt.Visible = false;
            //subjectLabel.Text = $"{subjectLabel.Text}{changeSubjectTxt.Text}";
            /*Size size = TextRenderer.MeasureText(subjectLabel.Text, subjectLabel.Font);
            subjectLabel.Width = size.Width;
            subjectLabel.Height = size.Height;*/
            changeSubjectTxt.Text = changeSubjectTxt.Text;
            Size size = TextRenderer.MeasureText(changeSubjectTxt.Text, changeSubjectTxt.Font);
            changeSubjectTxt.Width = size.Width;
            changeSubjectTxt.Height = size.Height+10;
            acceptBtn.Visible = false;
            cancelBtn.Visible = false;
            Pressed = true;
        }
    }
}
