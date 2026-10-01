using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace N1PO

{

    public abstract class FormaBase
    {
        public string Cor;
        public abstract void Desenhar();
        public abstract string SalvarString();
        public abstract void CarregarString(string info);

    }

    public class ImagemVetorial : FormaBase
    {


        public List<FormaBase> Formas = new List<FormaBase>();

        public override void Desenhar() { }

        public override string SalvarString()
        {
            string textoFinal = "";

            foreach (FormaBase f in Formas)
            {
                textoFinal += f.SalvarString() + "\n";
            }
            return textoFinal;
        }

        public override void CarregarString(string info)
        {

            string[] linhas = info.Split('\n');

        }

    }

    public class Linha : FormaBase
    {
        public int XInicial;
        public int YInicial;
        public int XFinal;
        public int YFinal;
        public int Largura;

        public override void Desenhar() { }

        public override string SalvarString()
        {
            return $"1;{XInicial};{YInicial};{XFinal};{YFinal};{Largura};{Cor}";
        }

        public override void CarregarString(string info)
        {
            string[] partes = info.Split(';');

            XInicial = int.Parse(partes[1]);
            YInicial = int.Parse(partes[2]);
            XFinal = int.Parse(partes[3]);
            YFinal = int.Parse(partes[4]);
            Largura = int.Parse(partes[5]);
            Cor = partes[6];
        }
    }
    public class Retangulo : FormaBase
    {
        public int X;
        public int Y;
        public int Largura;
        public int Altura;
        public override void Desenhar() { }
        public override string SalvarString() {

            return $"2;{X};{Y};{Largura};{Altura};{Cor}";


        }
        public override void CarregarString(string info) {

            string[] partes = info.Split(';');

            X = int.Parse(partes[1]);
            Y = int.Parse(partes[2]);
            Largura = int.Parse(partes[3]);
            Altura = int.Parse(partes[4]);
            Cor = partes[5];

        }

        

    }

    public class Circulo : FormaBase{
        public int XCentro;
        public int YCentro;

        public int Raio;
        public override void Desenhar() { }
        public override string SalvarString()
        {
            return $"3;{XCentro};{YCentro};{Raio};{Cor}";
        }
        public override void CarregarString(string info)
        {
            string[] partes = info.Split(';');

            XCentro = int.Parse(partes[1]);
            YCentro = int.Parse(partes[2]);
            Raio = int.Parse(partes[3]);
            Cor = partes[4];
        }

    }

    public class Elipse: FormaBase
    {
        public int XCentro;
        public int YCentro;

        public int RaioHorizontal;

        public int RaioVertical;
        public override void Desenhar() { }
        public override string SalvarString()
        {
            return $"4;{XCentro};{YCentro};{RaioHorizontal};{RaioVertical};{Cor}";
        }
        public override void CarregarString(string info)
        {
            string[] partes = info.Split(';');

            XCentro = int.Parse(partes[1]);
            YCentro = int.Parse(partes[2]);
            RaioHorizontal = int.Parse(partes[3]);
            RaioVertical = int.Parse(partes[4]);
            Cor = partes[5];
        }
    }

    public class Poligono : FormaBase
    {
        public int XInicial;
        public int YInicial;
        public int XMeio;
        public int YMeio;
        public int XFinal;
        public int YFinal;


        public override void Desenhar() { }

        public override string SalvarString()
        {
            return $"5;{XInicial};{YInicial};{XMeio};{YMeio};{XFinal};{YFinal};{Cor}";
        }

        public override void CarregarString(string info)
        {
            string[] partes = info.Split(';');

            XInicial = int.Parse(partes[1]);
            YInicial = int.Parse(partes[2]);
            XMeio = int.Parse(partes[3]);
            YMeio = int.Parse(partes[4]);
            XFinal = int.Parse(partes[5]);
            YFinal = int.Parse(partes[6]);
            Cor = partes[7];
        }
    }

    public class Texto : FormaBase
    {
        public int X;
        public int Y;
        public string Nome = " Dia de Sol ";

        public override void Desenhar() { }

        public override string SalvarString()
        {
            return $"6;{X};{Y};{Nome};{Cor}";
        }

        public override void CarregarString(string info)
        {
            string[] partes = info.Split(';');

            X = int.Parse(partes[1]);
            Y = int.Parse(partes[2]);
            Nome = partes[3];
            Cor = partes[4];
        }

    }

   

}
