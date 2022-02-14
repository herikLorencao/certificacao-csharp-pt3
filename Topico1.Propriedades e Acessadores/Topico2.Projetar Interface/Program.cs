using System;

namespace Topico2.Projetar_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IEletrodomestico eletro1 = new Televisao();
            IEletrodomestico eletro2 = new Abajur();
            IEletrodomestico eletro3 = new Lanterna();
            IEletrodomestico eletro4 = new Radio();

            var aux = eletro1;
            eletro1 = eletro2;
            eletro2 = eletro3;
            eletro3 = eletro4;
            eletro4 = aux;
        }
    }

    interface IEletrodomestico
    {
        public event EventHandler Ligou;
        public event EventHandler Desligou;

        void Ligar();
        void Desligar();
    }

    interface IIluminacao
    {
        public double Potencia { get; set; }
    }

    interface IRadioReceptor
    {
        public double Potencia { get; set; }
    }

    class Televisao : IEletrodomestico, IRadioReceptor
    {
        public event EventHandler Ligou;
        public event EventHandler Desligou;
        public double Potencia { get; set; }
        
        public void Ligar()
        {
            Console.WriteLine("Ligar.Televisao");    
        }

        public void Desligar()
        {
            Console.WriteLine("Desligar.Televisao");
        }
    }

    class Abajur : IEletrodomestico, IIluminacao
    {
        public event EventHandler Ligou;
        public event EventHandler Desligou;
        public double Potencia { get; set; }
        
        public void Ligar()
        {
            Console.WriteLine("Ligar.Abajur");    
        }

        public void Desligar()
        {
            Console.WriteLine("Desligar.Abajur");
        }

    }

    class Lanterna : IEletrodomestico, IIluminacao
    {
        public event EventHandler Ligou;
        public event EventHandler Desligou;
        public double Potencia { get; set; }
        
        public void Ligar()
        {
            Console.WriteLine("Ligar.Lanterna");    
        }

        public void Desligar()
        {
            Console.WriteLine("Desligar.Lanterna");
        }
    }

    class Radio : IEletrodomestico, IRadioReceptor
    {
        public event EventHandler Ligou;
        public event EventHandler Desligou;
        public double Potencia { get; set; }
        
        public void Ligar()
        {
            Console.WriteLine("Ligar.Radio");    
        }

        public void Desligar()
        {
            Console.WriteLine("Desligar.Radio");
        }
    }
}