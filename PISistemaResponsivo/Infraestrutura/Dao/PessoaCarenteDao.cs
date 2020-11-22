using PISistemaResponsivo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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


    }
}