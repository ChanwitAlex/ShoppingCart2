using System.Security.Policy;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string strCash = tbCash.Text;
                //get amount 
                string strCoffeePrice = tbCoffeePrice.Text;
                string strGreenTeaPrice = tbGreenTeaPrice.Text;


                //get price
                string strCoffeeQuantity = tbCoffeeQuantity.Text;
                string strGreenTeaQuantity = tbGreenTeaQuantity.Text;

                int iCoffeePrice = 0;
                int iGreenTeaPrice = 0;
                int iCoffeeQuantity = 0;
                int iGreenTeaQuantity = 0;
                int iCash = 0;
                try
                {
                    //covert string to int
                    iCash = int.Parse(strCash);
                    if (chbCoffee.Checked)
                    {
                        iCoffeePrice = int.Parse(strCoffeePrice);
                        iCoffeeQuantity = int.Parse(strCoffeeQuantity);
                    }
                    if (chbGreenTea.Checked)
                    {
                        iGreenTeaPrice = int.Parse(strGreenTeaPrice);
                        iGreenTeaQuantity = int.Parse(strGreenTeaQuantity);
                    }
                }
                catch (Exception ex)
                {
                    iCoffeePrice = 0;
                    iCoffeeQuantity = 0;
                    iGreenTeaPrice = 0;
                    iGreenTeaQuantity = 0;
                    iCash = 0;

                }
                //calculate total
                int iCoffeeTotal = iCoffeePrice * iCoffeeQuantity;
                int iGreenTeaTotal = iGreenTeaPrice * iGreenTeaQuantity;
                int iTotal = iCoffeeTotal + iGreenTeaTotal;
                int iChange = iCash - iTotal;

                //display total
                tbTotal.Text = iTotal.ToString();
                tbChange.Text = iChange.ToString();


                int[] denominations = { 1000, 500, 100, 50, 20, 10, 5, 1 };
                int[] changeCount = new int[denominations.Length];
                int remainingChange = iChange;

                for (int i = 0; i < denominations.Length; i++)
                {
                    changeCount[i] = remainingChange / denominations[i];
                    remainingChange %= denominations[i];
                }


                tb1000.Text = changeCount[0].ToString();
                tb500.Text = changeCount[1].ToString();
                tb100.Text = changeCount[2].ToString();
                tb50.Text = changeCount[3].ToString();  
                tb20.Text = changeCount[4].ToString();
                tb10.Text = changeCount[5].ToString();
                tb5.Text = changeCount[6].ToString();
                tb1.Text = changeCount[7].ToString();
            }
        }
    }
}
