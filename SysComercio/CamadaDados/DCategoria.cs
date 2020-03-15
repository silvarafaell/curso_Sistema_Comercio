using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    class DCategoria
    {
        private int _Idcategoria;
        private string _Nome;
        private string _Descricao;
        private string _TextoBuscar;

        public int Idcategoria 
        { 
            get
            {
                return _Idcategoria;
            }
            set
            {
                _Idcategoria = value;
            }
        }

        public string Nome
        {
            get
            {
                return _Nome;
            }
            set
            {
                _Nome = value;
            }
        }

        public string Descricao
        {
            get
            {
                return _Descricao;
            }
            set
            {
                _Descricao = value;
            }
        }

        public string TextoBuscar
        {
            get
            {
                return _TextoBuscar;
            }
            set
            {
                _TextoBuscar = value;
            }
        }

        //Construtor Vazio

        public DCategoria()
        {

        }

        //Construtor com Parametros

        public DCategoria(int idcategoria, string nome, string descricao, string textobuscar)
        {
            this.Idcategoria = idcategoria;
            this.Nome = nome;
            this.Descricao = descricao;
            this.TextoBuscar = textobuscar;

        }

        //Metodo Inserir
        public string Inserir(DCategoria categoria)
        {

        }

        //Metodo Editar
        public string Editar(DCategoria categoria)
        {

        }

        //Metodo Excluir
        public string Excluir(DCategoria categoria)
        {

        }

        //Metodo Mostrar
        public DataTable Mostrar(DCategoria categoria)
        {

        }

        //Metodo Buscar Nome
        public string BuscarNome(DCategoria categoria)
        {

        }
    }
}
