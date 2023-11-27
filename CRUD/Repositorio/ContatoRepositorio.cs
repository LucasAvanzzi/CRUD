﻿using CRUD.Data;
using CRUD.Models;

namespace CRUD.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {

        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            // gravar meu banco de dados
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;

        }

        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }
    }
}
