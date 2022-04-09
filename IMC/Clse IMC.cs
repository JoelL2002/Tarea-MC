using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    internal class Clse_IMC
    {
        
        private const double KG = 2.2046;
        public String Nombre { get; set; }
        public int Edad { get; set; }
        public int Altura { get; set; }
        public char Sexo { get; set; }
        public int Peso { get; set; }
        public double Imc { get; set; }
        private string etapa;

        private string delgadez = "Su indice de masa corporal es bajo, podria tener delgadez";
        private string normal = "Su indice de masa corporal es normal, siga asi C:";
        private string sobrepeso = "Su indice de masa corporal es un poco alto, podria tener sobre peso";
        private string obesidad = "Su indice de masa corporal es muy alto, podria tener obesidad";

        public void getdatos()
        {

            Console.WriteLine("Ingrese su nombre: ");
            Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su edad: ");
            Edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese su altura en centimetros: ");
            Altura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese su sexo, M si es masculino y F si es femenino: ");
            Sexo = Convert.ToChar(Console.ReadLine());
            Sexo = Char.ToUpper(Sexo);

            Console.WriteLine("Ingrese su peso en libras: ");
            Peso = Convert.ToInt32(Console.ReadLine());

        }

        public string formula()
        {
            double pesoKG = this.Peso / KG;
            double estaturaMts = (double)this.Altura / 100;
            double altu = (Math.Pow(estaturaMts, 2));
            Imc = pesoKG / altu;
            Imc = Math.Round(Imc, 2);
            return this.Imc.ToString();

        }

        public string verificacionEtapa()
        {        
      
            if (Edad >= 2 && Edad < 12)
            {
                etapa = "niño";
            }
            else if (Edad >= 12 && Edad < 18)
            {
                etapa = "adolescente";
            }
            else if (Edad >= 18)

            {
                etapa = "adulto";
            }

            return etapa;
        }

        public string verificacionIMC()
        {
            string mensaje = "";
            if (Sexo == 'F')
            {
                switch (etapa)
                {
                    case "niño":
                        {

                            if (Imc <= 13.8)
                            {
                                mensaje = delgadez;
                            }
                            else if (Imc > 13.8 && Imc <= 18.1)
                            {
                                mensaje = normal;
                            }
                            else if (Imc > 18.1 && Imc <= 20)
                            {
                                mensaje = sobrepeso;
                            }
                            else if (Imc > 20)
                            {
                                mensaje = obesidad;
                            }
                        }
                        break;


                    case "adolescente":
                        {
                            if (Imc <= 16)
                            {
                                mensaje = delgadez;
                            }
                            else if (Imc > 16 && Imc <= 23.5)
                            {
                                mensaje = normal;
                            }
                            else if (Imc > 23.5 && Imc <= 27.4)
                            {
                                mensaje = sobrepeso;
                            }
                            else if (Imc > 27.4)
                            {
                                mensaje = obesidad;
                            }
                        }
                        break;

                    case "adulto":
                        {
                            if (Imc <= 18.9)
                            {
                                mensaje = delgadez;
                            }
                            else if (Imc > 19 && Imc <= 23.5)
                            {
                                mensaje = normal;
                            }
                            else if (Imc > 23.5 && Imc <= 27.5)
                            {
                                mensaje = sobrepeso;
                            }
                            else if (Imc > 27.5)
                            {
                                mensaje = obesidad;
                            }
                        }
                        break;
                }
            }
            else if(Sexo == 'M')
            {
                switch (etapa)
                {
                    case "niño":
                        {

                            if (Imc <= 14.1)
                            {
                                mensaje = delgadez;
                            }
                            else if (Imc > 14.1 && Imc <= 17.9)
                            {
                                mensaje = normal;
                            }
                            else if (Imc > 17.9 && Imc <= 19.6)
                            {
                                mensaje = sobrepeso;
                            }
                            else if (Imc > 19.6)
                            {
                                mensaje = obesidad;
                            }
                        }
                        break;


                    case "adolescente":
                        {
                            if (Imc <= 16.2)
                            {
                                mensaje = delgadez;
                            }
                            else if (Imc > 16.2 && Imc <= 22.9)
                            {
                                mensaje = normal;
                            }
                            else if (Imc > 22.9 && Imc <= 26.2)
                            {
                                mensaje = sobrepeso;
                            }
                            else if (Imc > 26.2)
                            {
                                mensaje = obesidad;
                            }
                        }
                        break;

                    case "adulto":
                        {
                            if (Imc <= 19.9)
                            {
                                mensaje = delgadez;
                            }
                            else if (Imc > 20 && Imc <= 24.9)
                            {
                                mensaje = normal;
                            }
                            else if (Imc > 24.9 && Imc <= 29.9)
                            {
                                mensaje = sobrepeso;
                            }
                            else if (Imc > 29.9)
                            {
                                mensaje = obesidad;
                            }
                        }
                        break;
                }
            }
           

            return mensaje;
        }

        public override string ToString()
        {
            String retorno = $" Nombre = {Nombre}\n Edad = {Edad}\n Altura ={ Altura}\n Sexo = {Sexo}\n Peso = {Peso}\n IMC = {Imc}\n\n {verificacionIMC()} ";
            return retorno;
        }

    }

}
