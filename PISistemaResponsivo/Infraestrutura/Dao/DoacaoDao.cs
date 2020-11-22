using PISistemaResponsivo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PISistemaResponsivo.Infraestrutura.Dao
{
    public class DoacaoDao : DaoBase
    {
        public void Salvar(Doacao doacao)
        {
            _contexto.Doacoes.Add(doacao);
            _contexto.SaveChanges();
        }

        public Doacao Buscar(int doacaoId)
        {
            return _contexto.Doacoes.FirstOrDefault(x => x.DoacaoId == doacaoId);
        }

        public void Alterar(Doacao doacao)
        {
            _contexto.Entry(doacao).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        public void Excluir(int doacaoId)
        {
            var doacao = Buscar(doacaoId);

            _contexto.Doacoes.Remove(doacao);
            _contexto.SaveChanges();
        }

        public IEnumerable<Doacao> Listar()
        {
            return _contexto.Doacoes.ToList().OrderByDescending(x => x.DoacaoId);
        }
    }
}