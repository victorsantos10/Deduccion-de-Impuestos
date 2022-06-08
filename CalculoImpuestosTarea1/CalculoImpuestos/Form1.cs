using System;
using System.Windows.Forms;



namespace CalculoImpuestos

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calcular();
        }
        private void Calcular()
        {
            if (string.IsNullOrEmpty(SBTxt.Text))
            {
                MessageBox.Show("Ingrese un sueldo");
                return;
            }

            double SB, ST, AFP, ISR, SFS;
            SB = double.Parse(SBTxt.Text);

            AFP = SB * 0.07;
            ISR = SB * 0.09;
            SFS = SB * 0.10;

            ST = SB -(AFP + ISR + SFS);

            STtxt.Text = ST.ToString(); // Sueldo neto

            AFPTxt.Text = AFP.ToString(); // afp
            ISRTxt.Text = ISR.ToString(); // isr  
            SFSTxt.Text = SFS.ToString(); // sfs
        }
    }
}