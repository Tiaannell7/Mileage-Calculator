using System;
using System.IO;
using System.Windows.Forms;

namespace Mileage
{
    public partial class MEC_Form : Form
    {
        public MEC_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        //calculate the efficiency//
        private void calculateButton_Click(object sender, EventArgs e)
        {
            EfficiencyTextBox.Clear();

            try
            {
                int Miles_Driven, Gas_used, Efficiency;

                Miles_Driven = Convert.ToInt32(Miles_DrivenTextBox.Text);
                Gas_used = Convert.ToInt32(Gallons_UsedTextBox.Text);
                Efficiency = Miles_Driven / Gas_used;
                EfficiencyTextBox.Text = Efficiency.ToString();

                //write the inputs and the answer to the text documnet MilesPerGallon//
                string filePath = @"C:\Users\nellt\Documents\Work\2nd year\PRG521\Formative\FA3/MilesperGallon.txt";
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine("-----------------------------------------------------------------------------");
                    writer.WriteLine("Miles Driven : " + Miles_DrivenTextBox.Text.ToString());
                    writer.WriteLine("Gallons of Gas Used: " + Gallons_UsedTextBox.Text.ToString());
                    writer.WriteLine("Efficienct(Miles/ Gallon): " + EfficiencyTextBox.Text.ToString());

                }
            }

            //Expection for when a user enter text in the documnet//
            catch (FormatException)
            {
                MessageBox.Show(
              "The input values must be value.",
              "Invalid Input Values",
              MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            //other errors
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Calculation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                //write error to the text file
                string filePath = @"C:\Users\nellt\Documents\Work\2nd year\PRG521\Formative\FA3/Exceptionfile.txt";
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine("-----------------------------------------------------------------------------");
                    writer.WriteLine("Date : " + DateTime.Now.ToString());
                    writer.WriteLine();

                    while (ex != null)
                    {
                        writer.WriteLine(ex.GetType().FullName);
                        writer.WriteLine("Message : " + ex.Message);
                        writer.WriteLine("StackTrace : " + ex.StackTrace);

                        ex = ex.InnerException;
                    }
                }
            }

            //when calculation is done
            finally
            {
                MessageBox.Show("Calculation Finished", "Done",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Exit Button

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
