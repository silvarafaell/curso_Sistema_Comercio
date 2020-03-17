using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados;
using System.Data;

namespace CamadaNegocio
{
    public class NCategoria
    { 
        public static string Inserir(string nome, string descricao)
        {
            DCategoria obj = new CamadaDados.DCategoria();
            obj.Nome = nome;
            obj.Descricao = descricao;
            return obj.Inserir(obj);
        }
    }
}
