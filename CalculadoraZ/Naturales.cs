using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraZ
{
    class Naturales
    {
        #region Atributos
        private double d1; // Primer dato
        private double d2; // Segundo dato
        private double rs; // Resultado (variable donde se guardara los resultados de d1 y d2)
        private char op;   // Variable de caracteres para las operaciones (+ - * / ) 
        #endregion

        #region Constructor
        public Naturales() // Inicializa los atributos de la clase
        {
            d1 = 0; d2 = 0;
            rs = 0; op = ' ';
        }
        #endregion

        #region (set - get) 
        public void setD1(double n) // Funcion (set) insertar del primer dato (d1)
        { d1 = n; }
        public double getD1()       // Funcion (get) retorna el primer dato (d1)
        { return d1; }

        public void setD2(double n) // Funcion (set) inserta primer dato (d2)
        { d2 = n; }
        public double getD2()       // Funcion (get) retorna primer dato (d2)
        { return d2; }

        public void setRs(double n) // Funcion (set) insertar el resultado (rs)
        { rs = n; }
        public double getRs()       // Funcion (get) retornar el resultado (rs)
        { return rs; }

        public void setOp(char n)   // Funcion Insertar caracter (op)
        { op = n; }
        public char getOp()         // Retornar caracter (op)
        { return op; }
        #endregion 

        #region Metodos

        public void opBasicas() // Operaciones basicas
        {
            switch (op)
            {
                case '+':
                    rs = d1 + d2;
                    break;
                case '-':
                    rs = d1 - d2;
                    break;
                case '*':
                    rs=d1*d2;
                    break;
                case '/':
                    rs = d1 / d2;
                    break;
                case '^': // Operacion de exponente yˣ
                    rs = yx(d1, d2);
                    break;
                case '%': // Operacion de porcentaje
                    rs = d1 * (d2 / 100);
                    break;
            }
            d1 = rs;
        }

        public string binario()
        {
            string bin = "";
            int n = Convert.ToInt32(d1);
            while (n > 0)
            {
                int x = n % 2;
                bin = x.ToString() + bin;
                n = n / 2;
            }
            return bin;
        }

        public string octal()
        {
            string oct = "";
            int n = Convert.ToInt32(d1);
            while (n > 0)
            {
                int x = n % 8;
                oct = x.ToString() + oct;
                n = n / 8;
            }
            return oct;
        }

        public string hexadecimal()
        {
            string hex = "";
            int n = Convert.ToInt32(d1);
            while(n>0)
            {
                int x=n%16;
                string hx=x.ToString();
                switch(x)
                {
                    case 10:
                        hx="A";
                        break;
                    case 11:
                        hx="B";
                        break;
                    case 12:
                        hx="C";
                        break;
                    case 13:
                        hx="D";
                        break;
                    case 14:
                        hx="E";
                        break;
                    case 15:
                        x='F';
                        break;
                }
                hex=hx+hex;
                n=n/16;
            }
            return hex;
        }

        public double x2()
        {
            return rs = d1 * d1;
        }

        public double x3()
        {
            return rs = (d1 * d1) * d1;
        }

        public double yx(double y, double x)// este metodo sera llamado como una operacion básica arriba ↑
        {
            double res = 1;
            for (int i = 0; i < x; i++)
                res = res * y;
            return res;
        }

        public void limpiar() // Metodo que limpiara todos los datos guardados
        {
            d1 = 0; d2 = 0; rs = 0; op = ' ';
        }

        public double seno()
        {
            return Math.Sin(d1);
        }

        public double coseno()
        {
            return Math.Cos(d1);
        }

        public double  tangente()
        {
            return Math.Tan(d1);
        }

        public double senh()
        {
            return Math.Sinh(d1);
        }

        public double cosh()
        {
            return Math.Cosh(d1);
        }

        public double tanh()
        {
            return Math.Tanh(d1);
        }

        public double factorial()
        {
            double n=d1;
            double fac=1;
            for (int i = 1; i <= n; i++)
                fac = fac * i;
            d1 = fac;
            return fac;
        }

        public double raizcuadrada()
        {
            return Math.Sqrt(d1);
        }

        public double pi()
        {
            return rs = d1 * Math.PI;
        }

        #endregion 

    }
}
