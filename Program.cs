using System;
using System.IO;
using System.Linq.Expressions;
using System.Xml.Serialization;
using Xperiments.DesignPatterns.Adapter.Models;

namespace Xperiments.DesignPatterns.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {   
            Cliente cliente = new Cliente();
            cliente.Nome = "Bruno Lopes";
            cliente.Endereco = "Casa do ator";
            cliente.DataDeNascimento = DateTime.Now;

            string xml = new GeradorDeXml().GeraXml(cliente);

            Console.WriteLine(xml);
           
            
        }
    }
}
