using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Race
{
    class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;


        public Guy(string Name, Bet MyBet, int Cash, RadioButton MyRadioButton, Label MyLabel )
        {
            this.Name = Name;
            this.MyBet = MyBet;
            this.Cash = Cash;
            this.MyRadioButton = MyRadioButton;
            this.MyLabel = MyLabel;

        }

        public void UpdateLables()
        {
            if (MyBet == null)
            {
                MyLabel.Text = "Nie wykonano jescze zakladu";
            }
            else
            {
                MyLabel.Text = MyBet.GetDescription();
            }

            MyRadioButton.Text = Name + " ma " + Cash;

        }

        public void ClearBet()
        {

        }

        public bool PlaceBet(int amount, int DogToWin)
        {
            if (Cash > amount)
            {
                MyBet = new Bet(amount, DogToWin, this);

                return true;

            }
            else
            {
                return false;
            }
        }

        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);

        }
    }
}
