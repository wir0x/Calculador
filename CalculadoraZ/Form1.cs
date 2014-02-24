using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraZ
{
    public partial class Form1 : Form
    {
        bool newOp = true; // este booleano servira para verificar que si se esta realizando una nueva operación
        bool pnt = false; // este booleano servira para verificar que se presione solo una vez el punto decimal
        public Form1()
        {
            InitializeComponent();
        }
        
        Naturales nat = new Naturales(); 
        /* Aca se crea una nueva instacia de la clase Naturales (nat)
         * Para acceder a clase Naturales (set - get y métodos)  
         * Primero se tiene que ingresar la instancia de la clase (nat) punto(.) seguido
         * del metodo que quiere ser llamado (Ej. nat.Suma())*/

        private bool divPor0()// Este método servira para verificar que no se divida entre 0
        {
            if (nat.getD2() == 0 && nat.getOp() == '/')
            {
                txt1.Text = "Error! no puede dividirse por cero";
                return true;
            }
            else return false;
        }
        private void saveDate() // Método para guardar los datos (d1 y d2) 
        {
            if (newOp == false)
            {
                if (nat.getOp() == ' ')
                    nat.setD1(double.Parse(txt1.Text));
                else 
                {
                    nat.setD2(double.Parse(txt1.Text));
                    if (!divPor0())// pregunda que si es diferente de la division entre 0 
                    {
                        nat.opBasicas();
                        txt1.Text = nat.getRs().ToString();
                    }
                }
            }
            newOp = true;
        }
        private void btnBin_Click(object sender, EventArgs e)
        {
            saveDate();
            txt1.Text= nat.binario();
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            saveDate();
            txt1.Text=nat.octal();
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            saveDate();
            txt1.Text=nat.hexadecimal();
        }
        /*Apartir de aqui estan los botones de los numeros
         * La primera vez que se introduce un dato siempre ingresara por false,
         * despues entra por if
         * si se presiona una operacion volvera a entrar por else, y luego recien por if
         */
        private void btn1_Click(object sender, EventArgs e)
        {
            if (newOp == false && txt1.Text!="0")
                txt1.Text = txt1.Text + btn1.Text;
            else {// la primera ves que ingreses un dato siempre entrara por aca por (else) luego por if
                txt1.Text = btn1.Text;
                newOp = false;
                pnt = true;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (newOp == false && txt1.Text != "0")
                txt1.Text = txt1.Text + btn2.Text;
            else {
                txt1.Text = btn2.Text;
                newOp = false;
                pnt = true;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (newOp == false && txt1.Text != "0")
                txt1.Text = txt1.Text + btn3.Text;
            else {
                txt1.Text = btn3.Text;
                newOp = false;
                pnt = true;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (newOp == false && txt1.Text != "0")
                txt1.Text = txt1.Text + btn4.Text;
            else {
                txt1.Text = btn4.Text;
                newOp = false;
                pnt = true;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (newOp == false && txt1.Text != "0")
                txt1.Text = txt1.Text + btn5.Text;
            else {
                txt1.Text = btn5.Text;
                newOp = false;
                pnt = true;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            
            if (newOp == false && txt1.Text != "0")
                txt1.Text = txt1.Text + btn6.Text;
            else {
                txt1.Text = btn6.Text;
                newOp = false;
                pnt = true;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            
            if (newOp == false && txt1.Text != "0")
                txt1.Text = txt1.Text + btn7.Text;
            else {
                txt1.Text = btn7.Text;
                newOp = false;
                pnt = true;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (newOp == false && txt1.Text != "0")
                txt1.Text = txt1.Text + btn8.Text;
            else {
                txt1.Text = btn8.Text;
                newOp = false;
                pnt = true;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (newOp == false && txt1.Text != "0")
                txt1.Text = txt1.Text + btn9.Text;
            else {
                txt1.Text = btn9.Text;
                newOp = false;
                pnt = true;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (newOp == false && txt1.Text != "0")
                txt1.Text = txt1.Text + btn0.Text;
            else {
                txt1.Text = btn0.Text;
                newOp = false;
                pnt = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            nat.limpiar();
            txt1.Clear();
        }

        private void btnX2_Click(object sender, EventArgs e)
        {
            saveDate();
            txt1.Text = nat.x2().ToString();
        }

        private void bntX3_Click(object sender, EventArgs e)
        {
            saveDate();
            txt1.Text = nat.x3().ToString();
        }

        private void btnYx_Click(object sender, EventArgs e)
        {
            saveDate();
            nat.setOp('^');
            
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            saveDate();
            nat.setOp(' ');
        }

        private void btnX_Click(object sender, EventArgs e)
        {
           
            saveDate();
            nat.setOp('*');
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            saveDate();
            nat.setOp('/');
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
          
            saveDate();
            nat.setOp('+');
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            
            saveDate();
            nat.setOp('-');
        }

        private void btnMasMenos_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txt1.Text);
            n = n * -1;
            txt1.Text = n.ToString();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            saveDate();
            txt1.Text = nat.seno().ToString();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            saveDate();
            txt1.Text = nat.coseno().ToString();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            saveDate();
            txt1.Text = nat.tangente().ToString();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            saveDate();
            txt1.Text = nat.senh().ToString();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            saveDate();
            txt1.Text = nat.cosh().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveDate();
            txt1.Text = nat.tanh().ToString();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            saveDate();
            txt1.Text = nat.raizcuadrada().ToString();
        }

        private void btnXX_Click(object sender, EventArgs e)
        {
            saveDate();
            txt1.Text = nat.factorial().ToString();
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            if (!divPor0()) {
                nat.setOp('%');
                saveDate();
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!divPor0()) {
                if (pnt == true) {
                    txt1.Text = txt1.Text + btnPunto.Text;
                    pnt = false;
                }
            }
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            if (divPor0()) {
                saveDate();
                txt1.Text = nat.pi().ToString();
            }
        }

    }
}
