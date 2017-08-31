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
        double tristan,
               collin,
               ryan,
               tad;

        double itemAmount, splitAmount;

        int numberOfSplits;

        public Form1()
        {
            InitializeComponent();

            tristan = 0;
            collin = 0;
            ryan = 0;
            tad = 0;

            itemAmount = 0;

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
            if (e.KeyChar == (char)Keys.Return)
            {
                itemAmount = Convert.ToDouble(Display.Text);
                splitAmount = itemAmount / numberOfSplits;
                
                if(ChkCollin.Checked)
                {
                    collin += splitAmount;
                    //round(collin);
                    LblCollin.Text = "Collin: " + collin;                    
                }

                if (ChkTristan.Checked)
                {
                    tristan += splitAmount;
                    //round(tristan);
                    lblTristan.Text = "Tristan: " + tristan;                   
                }

                if (ChkRyan.Checked)
                {
                    ryan += splitAmount;
                    //round(ryan);
                    LblRyan.Text = "Ryan: " + ryan;                   
                }

                if (ChkTad.Checked)
                {
                    tad += splitAmount;
                    //round(tad);
                    LblTad.Text = "Tad: " + tad;                   
                }

                Display.Clear();
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
