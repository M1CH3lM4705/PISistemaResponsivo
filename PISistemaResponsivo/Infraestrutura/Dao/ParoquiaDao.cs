using PISistemaResponsivo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PISistemaResponsivo.Infraestrutura.Dao
{
    public class ParoquiaDao : DaoBase
    {
        public void Salvar(Paroquia paroquia)
        {
            _contexto.Paroquias.Add(paroquia);
            _contexto.SaveChanges();
        }

        public Paroquia Buscar(int paroquiaId)
        {
            return _contexto.Paroquias.FirstOrDefault(x => x.ParoquiaId == paroquiaId);
        }

        public void Alterar(Paroquia paroquia)
        {
            _contexto.Entry(paroquia).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        public void Excluir(int paroquiaId)
        {
            var paroquia = Buscar(paroquiaId);

            _contexto.Paroquias.Remove(paroquia);
            _contexto.SaveChanges();
        }

        public IEnumerable<Paroquia> Listar()
        {
            return _contexto.Paroquias.ToList().OrderBy(x => x.NomeParoquia);
        }
    }
}