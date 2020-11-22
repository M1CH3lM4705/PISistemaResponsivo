using PISistemaResponsivo.Models;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;

namespace PISistemaResponsivo.Infraestrutura.Dao
{
    public class PessoaCarenteDao : DaoBase
    {
        public void Salvar(PessoaCarente pessoaCarente)
        {
            _contexto.PessoasCarentes.Add(pessoaCarente);
            _contexto.SaveChanges();
        }

        public PessoaCarente Buscar(int pCarenteId)
        {
            return _contexto.PessoasCarentes.FirstOrDefault(x => x.CarenteId == pCarenteId);
        }

        public void Alterar(PessoaCarente pessoaCarente)
        {
            _contexto.Entry(pessoaCarente).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        public void Excluir(int pCarenteId)
        {
            var pCarente = Buscar(pCarenteId);

            _contexto.PessoasCarentes.Remove(pCarente);
            _contexto.SaveChanges();
        }

        public IEnumerable<PessoaCarente> Listar()
        {
            return _contexto.PessoasCarentes.ToList().OrderBy(x => x.Nome);
        }

    }
}