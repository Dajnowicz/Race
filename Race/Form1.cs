using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Race
{
    public partial class Form1 : Form
    {

        Guy[] guys = new Guy[3];
        Greyhound[] greyhounds = new Greyhound[4];

        public Form1()
        {
            InitializeComponent();
            SetupRaceTrack();
        }

        private void SetupRaceTrack()
        {

            int startingPosition = pictureBox1.Left - raceTrack.Left;
            int racetrackLength = raceTrack.Size.Width;
            guys[0] = new Guy("Janek", null, 100, RadioJanek, LabelJanek);
            guys[1] = new Guy("Bartek", null, 100, RadioBartek, LabelBartek);
            guys[2] = new Guy("Arek", null, 100, RadioArek, LabelArek);
         
            greyhounds[0] = new Greyhound(startingPosition, racetrackLength, pictureBox1);
            greyhounds[1] = new Greyhound(startingPosition, racetrackLength, pictureBox2);
            greyhounds[2] = new Greyhound(startingPosition, racetrackLength, pictureBox3);
            greyhounds[3] = new Greyhound(startingPosition, racetrackLength, pictureBox4);

            for (int i = 0; i < 3; i++)
            {
                guys[i].UpdateLables();
            }
        }

        private void RadioJanek_CheckedChanged(object sender, EventArgs e)
        {
            ChangeNameOfBetter("Janek");
        }
        private void RadioBartek_CheckedChanged(object sender, EventArgs e)
        {
            ChangeNameOfBetter("Bartek");
        }
        private void RadioArek_CheckedChanged(object sender, EventArgs e)
        {
            ChangeNameOfBetter("Arek");
        }
        private void ChangeNameOfBetter(string Name)
        {
            BetterLabel.Text = Name;
        }

        private void Stawia_Click(object sender, EventArgs e)
        {
            int number = 0;
            if (RadioJanek.Checked == true)
            {
                number = 0;
            }
            if (RadioBartek.Checked == true)
            {
                number = 1;
            }
            if (RadioArek.Checked == true)
            {
                number = 2;
            }

            guys[number].PlaceBet((int)NumericMoney.Value, (int)NumericDog.Value);
            guys[number].UpdateLables();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            bool NoWinner = true;
            int winningDog;
            startButton.Enabled = false;

            while (NoWinner)
            {
                Application.DoEvents();
                for (int i = 0; i < greyhounds.Length; i++)
                {
                    if (greyhounds[i].Run())
                    {
                        winningDog = i + 1;
                        NoWinner = false;
                        MessageBox.Show("We have a winner - dog #" + winningDog);
                        foreach (Guy guy in guys)
                        {
                            if (guy.MyBet != null)
                            {
                                guy.Collect(winningDog);
                                guy.MyBet = null;
                                guy.UpdateLables();
                            }
                        }
                        foreach (Greyhound dog in greyhounds)
                        {
                            dog.TakeStartingPosition();
                        }
                        break;
                    }
                }
            }
            startButton.Enabled = true;
        }
    }
}
