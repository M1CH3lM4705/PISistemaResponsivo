using PISistemaResponsivo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PISistemaResponsivo.Infraestrutura.Dao
{
    public class EnderecoDao : DaoBase
    {
        public void Salvar(Endereco endereco)
        {
            _contexto.Enderecos.Add(endereco);
            _contexto.SaveChanges();
        }

        public Endereco Buscar(int enderecoId)
        {
            return _contexto.Enderecos.FirstOrDefault(x => x.EnderecoId == enderecoId);
        }

        public void Alterar(Endereco endereco)
        {
            _contexto.Entry(endereco).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        public void Excluir(int enderecoId)
        {
            var endereco = Buscar(enderecoId);

            _contexto.Enderecos.Remove(endereco);
            _contexto.SaveChanges();
        }

        public IEnumerable<Endereco> Listar()
        {
            return _contexto.Enderecos.ToList().OrderBy(x => x.EnderecoId);
        }
    }
}