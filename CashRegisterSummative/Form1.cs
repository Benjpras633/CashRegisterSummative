using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CashRegisterSummative
{
    public partial class Form1 : Form
    {
        const double DAYS = 12.00;
        const double WEEKS = 84.00;
        const double MONTHS = 288.00;
        const double TAX = 0.13;
        double pricedays; 
        double priceweeks;
        double pricemonths;
        double costofOrder;
        double costofOrderTotal;
        double tendered;
        double change;
        double taxCost;
        int numberofDays;
        int numberofWeeks;
        int numberofMonths;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                numberofDays = Convert.ToInt16(daysInput.Text);
                numberofWeeks = Convert.ToInt16(WeeksInput.Text);
                numberofMonths = Convert.ToInt16(monthsInput.Text);

                pricedays = numberofDays * DAYS;
                priceweeks = numberofWeeks * WEEKS;
                pricemonths = numberofMonths * MONTHS;

                costofOrder = pricedays + priceweeks + pricemonths;

                taxCost = costofOrder * TAX;
                costofOrderTotal = costofOrder + taxCost;

                subtotalOP.Text = costofOrder.ToString("C");
                taxOP.Text = taxCost.ToString("C");
                totalOP.Text = costofOrderTotal.ToString("C");

            }
            catch
            {
                messageLabel.Text = "Please enter a amount.  ";

                return;
            }
            
        }

        private void CalculatechangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                numberofDays = Convert.ToInt16(daysInput.Text);
                numberofWeeks = Convert.ToInt16(WeeksInput.Text);
                numberofMonths = Convert.ToInt16(monthsInput.Text);

                pricedays = numberofDays * DAYS;
                priceweeks = numberofWeeks * WEEKS;
                pricemonths = numberofMonths * MONTHS;

                costofOrder = pricedays + priceweeks + pricemonths;

                taxCost = costofOrder * TAX;
                costofOrderTotal = costofOrder + taxCost;

                tendered = Convert.ToInt16(tenderedOutput.Text);
                change = tendered - costofOrderTotal;
                changeOutput.Text = change.ToString("C");

            }
            catch
            {
                messageLabel.Text = "Please enter a amount";
            }
            
                 
        }

       

        private void PrintreceiptButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Font drawfont = new Font("MV Boli", 16, FontStyle.Bold);
            Font smallfont = new Font("MV Boli", 12, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Gray);
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SoundPlayer cashregister = new SoundPlayer(Properties.Resources.cash_register);

            cashregister.Play();
            g.FillRectangle(drawBrush, 400, 80, 350, 475);

            g.DrawString(" Ben's Bed And Breakfast Inc.", drawfont, blackBrush, 400, 100);
            g.DrawString("\n\n\nOrder Number  273", smallfont, blackBrush, 420, 100);
            g.DrawString("\n\n\n\nSeptember 28 , 2019", smallfont, blackBrush, 420, 100);

            g.DrawString("\n\n\n\n\n\n\nDays        x" + numberofDays + "     @ " + DAYS.ToString("C") , smallfont, blackBrush, 420, 100);
            g.DrawString("\n\n\n\n\n\n\n\nWeeks      x" + numberofWeeks + "    @ " + WEEKS.ToString("C"), smallfont, blackBrush, 420, 100);
            g.DrawString("\n\n\n\n\n\n\n\n\nMonths    x" + numberofMonths + "   @ " + MONTHS.ToString("C"), smallfont, blackBrush, 420, 100);
            g.DrawString("\n\n\n\n\n\n\n\n\n\n\nSubtotal        " + costofOrder.ToString("C"), smallfont, blackBrush, 420, 100);
            g.DrawString("\n\n\n\n\n\n\n\n\n\n\n\nTax             "  + taxCost.ToString("C"), smallfont, blackBrush, 420, 100);
            g.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\nTotal           " + costofOrderTotal.ToString("C"), smallfont, blackBrush, 420, 100);
            g.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nTendered        " + tendered.ToString("C"), smallfont, blackBrush, 420, 100);
            g.DrawString("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\nChange          " + change.ToString("C"), smallfont, blackBrush, 420, 100);









        }

        private void NeworderButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            g.Clear(Color.White);
            change = 0;
            pricedays = 0;
            priceweeks = 0;
            pricemonths = 0;

            costofOrder = 0;

            taxCost = 0;
            costofOrderTotal = 0;
            tendered = 0;

            subtotalOP.Text= Convert.ToString("$0.00");
            taxOP.Text = Convert.ToString("$0.00");
            totalOP.Text = Convert.ToString("$0.00");

            numberofDays = 0;
            numberofWeeks = 0;
            numberofMonths = 0;

            daysInput.Text = "0";
            WeeksInput.Text = "0";
            monthsInput.Text = "0";

            changeOutput.Text = Convert.ToString("$0.00");
            tenderedOutput.Text = "";







        }
    }
    }

