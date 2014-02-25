using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeurenProbleem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            uint win = 0, lose = 0;
            Random quiz = new Random();
            Decimal target = numericUpDown1.Value;
            for(Decimal i = 0; i < target; i++)
            {
                int j = quiz.Next(3);
                int pick = quiz.Next(3);
                List<int> leftOvers = new List<int>();
                leftOvers.AddRange(new int[3] { 0, 1, 2 });
                leftOvers.Remove(j);
                leftOvers.Remove(pick);

                int doorToOpen = quiz.Next(leftOvers.Count);
                leftOvers.Remove(doorToOpen);

                if (radioStay.Checked)
                {
                    if (j == pick)
                        win++;
                    else
                        lose++;
                }
                else
                {
                    if (j != pick)
                        win++;
                    else
                        lose++;
                }
            }
            GewonnenCounterLabel.Text = String.Format("Aantal keer goed gegokt: {0}", win);
            verlorenCounterLabel.Text = String.Format("Aantal keer fout gegokt: {0}", lose);
        }
    }
}
