using PISistemaResponsivo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PISistemaResponsivo.Infraestrutura.Dao
{
    public class VoluntarioDao : DaoBase
    {
        public void Salvar(Voluntario voluntario)
        {
            _contexto.Voluntarios.Add(voluntario);
            _contexto.SaveChanges();
        }

        public Voluntario Buscar(int voluntarioId)
        {
            return _contexto.Voluntarios.FirstOrDefault(x => x.VoluntarioId == voluntarioId);
        }

        public void Alterar(Voluntario voluntario)
        {
            _contexto.Entry(voluntario).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        public void Excluir(int voluntarioId)
        {
            var voluntario = Buscar(voluntarioId);

            _contexto.Voluntarios.Remove(voluntario);
            _contexto.SaveChanges();
        }

        public IEnumerable<Voluntario> Listar()
        {
            return _contexto.Voluntarios.ToList().OrderBy(x => x.NomeVoluntario);
        }
    }
}