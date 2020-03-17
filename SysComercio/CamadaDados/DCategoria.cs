using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
      public class DCategoria
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
            string resp = "";//variavel resp
            SqlConnection SqlCon = new SqlConnection(); //abrindo a conexao
            try //usar o try quando se tratar conexao
            {
                //codigo
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinserir_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcategoria = new SqlParameter();
                ParIdcategoria.ParameterName = "@idcategoria";
                ParIdcategoria.SqlDbType = SqlDbType.Int;
                ParIdcategoria.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdcategoria);

                SqlParameter ParNome = new SqlParameter();
                ParNome.ParameterName = "@nome";
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = categoria.Nome;
                SqlCmd.Parameters.Add(ParNome);

                SqlParameter ParDescricao = new SqlParameter();
                ParDescricao.ParameterName = "@descricao";
                ParDescricao.SqlDbType = SqlDbType.VarChar;
                ParDescricao.Size = 100;
                ParDescricao.Value = categoria.Descricao;
                SqlCmd.Parameters.Add(ParDescricao);

                //Executar o comando

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "Registro não foi Inserido";

            }
            catch (Exception ex)//se der algum erro executa o catch
            {
                resp = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); //quando tem uma unica linha não precisa abir chaves
            }
        }

        //Metodo Editar
        public string Editar(DCategoria categoria)
        {
            string resp = "";//variavel resp
            SqlConnection SqlCon = new SqlConnection(); //abrindo a conexao
            try //usar o try quando se tratar conexao
            {
                //codigo
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcategoria = new SqlParameter();
                ParIdcategoria.ParameterName = "@idcategoria";
                ParIdcategoria.SqlDbType = SqlDbType.Int;
                ParIdcategoria.Value = categoria.Idcategoria;
                SqlCmd.Parameters.Add(ParIdcategoria);

                SqlParameter ParNome = new SqlParameter();
                ParNome.ParameterName = "@nome";
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = categoria.Nome;
                SqlCmd.Parameters.Add(ParNome);

                SqlParameter ParDescricao = new SqlParameter();
                ParDescricao.ParameterName = "@descricao";
                ParDescricao.SqlDbType = SqlDbType.VarChar;
                ParDescricao.Size = 100;
                ParDescricao.Value = categoria.Descricao;
                SqlCmd.Parameters.Add(ParDescricao);

                //Executar o comando

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "A edição não foi feita";

            }
            catch (Exception ex)//se der algum erro executa o catch
            {
                resp = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); //quando tem uma unica linha não precisa abir chaves
            }

        }

        //Metodo Excluir
        public string Excluir(DCategoria categoria)
        {
            string resp = "";//variavel resp
            SqlConnection SqlCon = new SqlConnection(); //abrindo a conexao
            try //usar o try quando se tratar conexao
            {
                //codigo
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdeletar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdcategoria = new SqlParameter();
                ParIdcategoria.ParameterName = "@idcategoria";
                ParIdcategoria.SqlDbType = SqlDbType.Int;
                ParIdcategoria.Value = categoria.Idcategoria;
                SqlCmd.Parameters.Add(ParIdcategoria);

                
                //Executar o comando

                resp = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "A exclusão não foi feita";

            }
            catch (Exception ex)//se der algum erro executa o catch
            {
                resp = ex.Message;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); //quando tem uma unica linha não precisa abir chaves
            }


        }

        //Metodo Mostrar
        public DataTable Mostrar(DCategoria categoria)
        {
            DataTable DtResultado = new DataTable("categoria");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch(Exception ex)
            {
                DtResultado = null;//se der erro deixa nula
            }
        }

        //Metodo Buscar Nome
        public DataTable BuscarNome(DCategoria categoria)
        {
            DataTable DtResultado = new DataTable("categoria");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_nome";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = categoria.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }

        }
    }
}
