using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace analizador_lexico
{
    public partial class Form1 : Form
    {
        lexico Analiza_Lexico = new lexico();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Analiza_Lexico.Inicia(); 
            //analizar codigo
            Analiza_Lexico.Analiza(textBox_codigo.Text); 
            TOKEN_LEXEMA.Rows.Clear();

            if (Analiza_Lexico.NoTokens > 0) 
                //agregar linea al datagrid
                TOKEN_LEXEMA.Rows.Add(Analiza_Lexico.NoTokens);
            for (int i = 0; i < Analiza_Lexico.NoTokens; i++) 
            { 
                //agregar datos a las lineas agregadas
                TOKEN_LEXEMA.Rows[i].Cells[0].Value = Analiza_Lexico.Token[i]; 
                TOKEN_LEXEMA.Rows[i].Cells[1].Value = Analiza_Lexico.Lexema[i]; 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Limpiar el Datagrid             
            TOKEN_LEXEMA.Rows.Clear(); 
            //Limpiar el TextBoxt             
            textBox_codigo.Text = "";             
            textBox_codigo.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
