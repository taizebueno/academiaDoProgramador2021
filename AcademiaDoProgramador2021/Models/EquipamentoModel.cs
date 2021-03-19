using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDoProgramador2021.Models
{
    class EquipamentoModel
    {
        private Int32 _id;
        private String _nome;
        private Int32 _numero_serie;
        private Double _preco;
        private String _data_fabricacao;
      
        private DAO.EquipamentoDAO equipamento_dao;

        public EquipamentoModel()
        {

        }

        public Int32 id
        {
            get { return id; }
            set { id = value; }
        }
        public String nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public Int32 numero_serie
        {
            get { return _numero_serie; }
            set { _numero_serie = value; }
        }
        public Double preco
        {
            get { return _preco; }
            set { _preco = value; }
        }
        public String data_fabricacao
        {
            get { return _data_fabricacao; }
            set { _data_fabricacao = value; }
        }

        public void Inserir()
        {
            equipamento_dao = new DAO.EquipamentoDAO();
            equipamento_dao.InserirEquipamento(_nome, _numero_serie, _preco, _data_fabricacao);
        }
        /*public void Atualizar()
        {
            cdao = new DAO.CrudDAO();
            cdao.AtualizarDados(itemcodigo, itemdescricao, itempreco, itemid);
        }
        public void Remover()
        {
            cdao = new DAO.CrudDAO();
            cdao.RemoverDados(itemcodigo, itemid);
        }*/
    }
}
