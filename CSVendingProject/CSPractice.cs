// Matthew G. Mershon
// Vending Machine program
//C# , MVS2012

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPractice
{
    public class Vending
    {
            int colaTotal = 0, lemonTotal = 0, grapeTotal = 0, rootTotal = 0, waterTotal = 0;
            double money, COST = 0.75;
            string drinkChoice;
            bool keepGoing;

       public void Main()
        {

            while (keepGoing)
            {
                Console.WriteLine("Please enter the quantity of money you wish to insert.");
                money = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please select your drink. The Choices are 'Cola','Lemon','Grape','Root', and 'Water'");
                drinkChoice = Console.ReadLine();
                if (checkAndCharge(money))
                {
                    switch (drinkChoice)
                    {
                        case "Cola":
                            if (colaTotal >= 5)
                                Console.WriteLine("There are no more of this drink.");
                            else
                                colaTotal++;
                            Console.WriteLine("Enjoy your Cola.");
                            break;
                        case "Lemon":
                            if (lemonTotal >= 5)
                                Console.WriteLine("There are no more of this drink.");
                            else
                                lemonTotal++;
                            Console.WriteLine("Enjoy your Lemon.");
                            break;
                        case "Grape":
                            if (grapeTotal >= 5)
                                Console.WriteLine("There are no more of this drink.");
                            else
                                grapeTotal++;
                            Console.WriteLine("Enjoy your Grape.");
                            break;
                        case "Root":
                            if (rootTotal >= 5)
                                Console.WriteLine("There are no more of this drink.");
                            else
                                rootTotal++;
                            Console.WriteLine("Enjoy your Root.");
                            break;
                        case "Water":
                            if (waterTotal >= 5)
                                Console.WriteLine("There are no more of this drink.");
                            else
                                waterTotal++;
                            Console.WriteLine("Enjoy your Water.");
                            break;
                        default:
                            Console.WriteLine("Default case");
                            break;
                    }
                }
                Console.WriteLine("You want to continue. True or False.");

                keepGoing = Convert.ToBoolean(Console.ReadLine());
            }

        }


        public bool checkAndCharge(double userMoney) //Method used for each drink button. 
        {
            double moneyTemp = userMoney; //Pulls value from user input.
            if (moneyTemp < .75) //Each drink is $0.75.
            {
                Console.WriteLine("You have insufficient funds."); //When the transaction is unsuccessful.
                return false; //Wont subtract a "soda" from the total.
            }
            else
            {
                moneyTemp = moneyTemp - .75; //Subtract the soda cost from user input.
                money = moneyTemp;
                return true; //Will subtract a soda from total.
            }
        }
    


        /* private void button1_Click(object sender, EventArgs e) //Cola button.
         {
             if (colaTotal > 5)
             {
                 MessageBox.Show("There are no more drinks of this type!", "Sorry");
             }
             else if (checkAndCharge() == true)
             {
                 colaTotal++; //Add to count.
             }
             else
             {

             }
         }

         private void button2_Click(object sender, EventArgs e) //Lemon button.
         {
             if (lemonTotal > 5)
             {
                 MessageBox.Show("There are no more drinks of this type!", "Sorry");
             }
             else if (checkAndCharge() == true)
             {
                 lemonTotal++; //Add to count.
             }
             else
             {

             }
         }

         private void button3_Click(object sender, EventArgs e) //Grape button.
         {
             if (grapeTotal > 5)
             {
                 MessageBox.Show("There are no more drinks of this type!", "Sorry");
             }
             else if (checkAndCharge() == true)
             {
                 grapeTotal++; //Add to count.
             }
             else
             {

             }
         }

         private void button4_Click(object sender, EventArgs e) //Rootbeer button.
         {
             if (rootTotal > 5)
             {
                 MessageBox.Show("There are no more drinks of this type!", "Sorry");
             }
             else if (checkAndCharge() == true)
             {
                 rootTotal++; //Add to count.
             }
             else
             {

             }
         }

         private void button5_Click(object sender, EventArgs e) //Water bottle button.
         {
             if (waterTotal > 5)
             {
                 MessageBox.Show("There are no more drinks of this type!", "Sorry");
             }
             else if (checkAndCharge() == true)
             {
                 waterTotal++; //Add to count.
             }
             else
             {

             }
         }

         private void numericUpDown1_ValueChanged(object sender, EventArgs e) //Field for money.
         {

         }
         */
    }
}
