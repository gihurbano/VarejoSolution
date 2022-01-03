using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Estado
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public override string ToString() //esta função é para retornar o real valor do nome da que foi cadastrado
        {
            return this.Nome;
        }

        public static List<Estado> Lista() {
            var lista = new List<Estado>();
            var e1 = new Estado();

            e1.Id = 1;
            e1.Nome = "SP";
            lista.Add(e1);

            e1 = new Estado();
            e1.Id = 2;
            e1.Nome = "RJ";
            lista.Add(e1);

            e1 = new Estado();
            e1.Id = 3;
            e1.Nome = "PR";
            lista.Add(e1);


            return lista;

        
        }
      
    }
}
