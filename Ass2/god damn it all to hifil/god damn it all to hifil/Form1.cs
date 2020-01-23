using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace god_damn_it_all_to_hifil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    public struct TaxBrack{
			public double Bracket;
			public int LRange;
			public int HRange;

			public TaxBrack(double A, int B, int C){
				Bracket=A;
				LRange=B;
				HRange=C;
			}
		}

        static string PRINT = "";
		// The code for calcuatoing the Hrange gets complex/hard to read, so I'm making my own function for it, so when I need to change it, I change it here.
		public static double TaxNum(int H, int L, double B ){
			double sum=Math.Round(B* (H-L));
			PRINT+=("At "+B+"% bracket, the amount due is  "+sum +"\n");
			return (sum);
		}
		// Given amount of taxable income, return the tax of it, from the highest bracket for a single person
		public static void FederalTax(int TaxableIncome, int Det=12200){
			int temp=TaxableIncome;
			TaxableIncome-=Det;

			//Console.Write(TaxableIncome+":\t");
			TaxBrack[] Taxis={
				new TaxBrack(.10,0,9700),		//0
				new TaxBrack(.12,9700,39475),		//1
				new TaxBrack(.22,39475,84200),		//2
				new TaxBrack(.24,84200,160725),		//3
				new TaxBrack(.32,160725,204100),	//4
				new TaxBrack(.35,204100,510300),	//5
				new TaxBrack(.37, 510300,-1) 		//6
			};

			int Range=0;
			for(int i=1; i<Taxis.Length; i++){
				if(Taxis[i].LRange<TaxableIncome){
					Range++;
				}
			}
			PRINT+=(Range +"\t" + Taxis[Range].Bracket +"\n");

			double sum=0;
			for(int i=0; i<Range; i++){
				sum+=TaxNum(Taxis[i].HRange, Taxis[i].LRange, Taxis[i].Bracket);
			}
			sum+=TaxNum(TaxableIncome, Taxis[Range].LRange, Taxis[Range].Bracket);

			for(int i=Range; i<Taxis.Length; i++){

				PRINT+=("At "+Taxis[i].Bracket+"% bracket, the amount due is  "+0 +"\n");
			}


			if ( sum<0)
				sum=0;

			PRINT+=("Your tax is " + sum +
					"$ with a gross income percentage of " + Math.Round(sum/temp,2)  
					+ "% adjected it's " + Math.Round(sum/TaxableIncome,2) + "%\n" +

					"At a dectuable rate of " + Det + "\n");



		}
        private void Sumbit_Click(object sender, EventArgs e)
        {
            string temp = Income.Text;
            int IIncome = 0;
            if (temp.Length != 0 ) {
                IIncome = Int32.Parse(temp);
                temp = Detuctions.Text;
                if (temp.Length != 0)
                {
                    int Decutions = Int32.Parse(temp);
                    FederalTax(IIncome, Decutions);
                    Output.Text = PRINT;
                    PRINT = "";
                }
                else {
                    FederalTax(IIncome);
                    Output.Text = PRINT;
                    PRINT = "";
                }
            }
            else
            {
                MessageBox.Show("Nothings in taxes BRAH");
            }

              
        }
    }
}
