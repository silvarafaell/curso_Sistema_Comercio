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
                return Idcategoria;
            }
            set
            {
                Idcategoria = value;
            }
        }

        public string Nome
        {
            get
            {
                return Nome;
            }
            set
            {
                Nome = value;
            }
        }

        public string Descricao
        {
            get
            {
                return Descricao;
            }
            set
            {
                Descricao = value;
            }
        }

        public string TextoBuscar
        {
            get
            {
                return Descricao;
            }
            set
            {
                Descricao = value;
            }
        }
    }
}
