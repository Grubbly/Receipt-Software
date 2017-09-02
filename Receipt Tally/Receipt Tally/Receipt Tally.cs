using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Receipt_Tally
{
    public partial class Form1 : Form
    {
        int  transactionID,
             transactionCounter,
             numberOfParticipants;

        double tristan,
               collin,
               ryan,
               tad;

        double itemAmount, 
               splitAmount,
               amountToRemove,
               total;

        List<double> transactionArray = new List<double>(); //holds amount for each transaction
        List< List<int> > transactionParticipants = new List< List<int> >(); //holds who participated in a transactionID

        int numberOfSplits;

        public const int tristanID = 1;
        public const int collinID = 2;
        public const int ryanID = 3;
        public const int tadID = 4;

        public Form1()
        {       
            InitializeComponent();

            transactionCounter = 0;
            numberOfParticipants = 0;

            tristan = 0;
            collin = 0;
            ryan = 0;
            tad = 0;

            itemAmount = 0;
            total = 0;

            numberOfSplits = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ChkTad_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkTad.Checked)           
                numberOfSplits++;            
            else           
                numberOfSplits--;
            

            LblSplit.Text = "Split " + numberOfSplits + " ways";
        }

        private void ChkRyan_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkRyan.Checked)           
                numberOfSplits++;            
            else           
                numberOfSplits--;
            

            LblSplit.Text = "Split " + numberOfSplits + " ways";
        }

        private void ChkCollin_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkCollin.Checked)            
                numberOfSplits++;            
            else           
                numberOfSplits--;
            

            LblSplit.Text = "Split " + numberOfSplits + " ways";
        }

        private void ChkTristan_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkTristan.Checked)            
                numberOfSplits++;           
            else
                numberOfSplits--;
            

            LblSplit.Text = "Split " + numberOfSplits + " ways";
        }

        private void LblTristan_Click(object sender, EventArgs e)
        {

        }

        private void LblCollin_Click(object sender, EventArgs e)
        {

        }

        private void LblSplit_Click(object sender, EventArgs e)
        {
           
        }

        private void Display_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return  && Display.Text != "")
            {
                itemAmount = Convert.ToDouble(Display.Text);
                splitAmount = itemAmount / numberOfSplits;
                transactionArray.Add(splitAmount);

                total += itemAmount;
                LblRunningTotal.Text = "Running Total: $" + total;

                Feed.AppendText("Transaction " + transactionCounter + ":\n");
                Feed.AppendText( "Charged $" + itemAmount + ", \n" + numberOfSplits + " ways\n\n" );

                List<int> temp = new List<int>();



                if(ChkCollin.Checked)
                {
                    collin += splitAmount;
                    //round(collin);
                    LblCollin.Text = "Collin: $" + collin;
                    Feed.AppendText("Collin: $" + splitAmount + " new total: $" + collin + "\n");
                    temp.Add(collinID);
                    numberOfParticipants++;
                }

                if (ChkTristan.Checked)
                {
                    tristan += splitAmount;
                    //round(tristan);
                    lblTristan.Text = "Tristan: $" + tristan;
                    Feed.AppendText("Tristan: $" + splitAmount + " new total: $" + tristan + "\n");
                    temp.Add(tristanID);
                    numberOfParticipants++;
                }

                if (ChkRyan.Checked)
                {
                    ryan += splitAmount;
                    //round(ryan);
                    LblRyan.Text = "Ryan: $" + ryan;
                    Feed.AppendText("Ryan: $" + splitAmount + " new total: $" + ryan + "\n");
                    temp.Add(ryanID);
                    numberOfParticipants++;
                }

                if (ChkTad.Checked)
                {
                    tad += splitAmount;
                    //round(tad);
                    LblTad.Text = "Tad: $" + tad;
                    Feed.AppendText("Tad: $" + splitAmount + " new total: $" + tad + "\n");
                    temp.Add(tadID);
                    numberOfParticipants++;
                }

                transactionParticipants.Add(temp);

                numberOfParticipants = 0;
                Feed.AppendText("\n");
                transactionCounter++;
                Feed.AppendText("\n");
                Display.Clear();
            }
            
        }

        private void LblTitle_Click(object sender, EventArgs e)
        {

        }

        private void Feed_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblRunningTotal_Click(object sender, EventArgs e)
        {

        }

        private void TxtbTransactionID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (TxtbTransactionID.Text != "")
            {
                transactionID = Convert.ToInt32(TxtbTransactionID.Text);
                amountToRemove = transactionArray[transactionID];

                total -= ( amountToRemove* transactionParticipants[transactionID].Count() );
                LblRunningTotal.Text = "Running Total: $" + total;

                Feed.AppendText("\nREMOVING FROM TRANSACTION " + transactionID + "\n");
                Feed.AppendText("Original Amount: $" + amountToRemove * transactionParticipants[transactionID].Count() + "\n\n");

                for (int index = 0; index < transactionParticipants[transactionID].Count(); index++)
                {
                    if(transactionParticipants[transactionID][index] == tristanID)
                    {

                        lblTristan.Text = "Tristan " + (tristan -= amountToRemove);
                        Feed.AppendText("Removed $" + amountToRemove + " from Tristan's total, new total: $" + tristan + "\n");
                    }

                    if (transactionParticipants[transactionID][index] == collinID)
                    {
                        LblCollin.Text = "Collin " + (collin -= amountToRemove);
                        Feed.AppendText("Removed $" + amountToRemove + " from Collin's total, new total: $" + collin + "\n");
                    }

                    if (transactionParticipants[transactionID][index] == ryanID)
                    {
                        LblRyan.Text = "Ryan " + (ryan -= amountToRemove);
                        Feed.AppendText("Removed $" + amountToRemove + " from Ryan's total, new total: $" + ryan + "\n");
                    }

                    if (transactionParticipants[transactionID][index] == tadID)
                    {
                        LblTad.Text = "Tad " + (tad -= amountToRemove);
                        Feed.AppendText("Removed $" + amountToRemove + " from Tad's total, new total: $" + tad + "\n");
                    }

                }

                Feed.AppendText("\n");
                Feed.AppendText("\n");
                TxtbTransactionID.Clear();

            }
        }

        private double round(double total)
        {
            return ((total*100)%1)/100;
        }

        private void LblRyan_Click(object sender, EventArgs e)
        {

        }

        private void LblTad_Click(object sender, EventArgs e)
        {

        }

        private void Display_TextChanged(object sender, EventArgs e)
        {
            
        }
        
    }
}
