using Projeto_Senai_Air_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Senai_Air_System.Repositories
{
    class UsuarioRepository
    {
        private static List<Usuario> usuarios;

        private static int contador = 1;

        public UsuarioRepository()
        {
            if (usuarios == null)
            {
                usuarios = new List<Usuario>();

                usuarios.Add(new Usuario
                {
                    id = 1,
                    nome = "Gabriel",
                    usuario = "biel",
                    senha = "123123",
                }
               );
                contador++;
            }
        }
        public List<Usuario> buscarTodos()
        {
            return usuarios;
        }

        public void adicionar(Usuario usuario)
        {
            usuario.id = contador;

            usuarios.Add(usuario);
            contador++;
        }
        public void editar (Usuario usuario)
        {
            Usuario u = usuarios.Find(x => x.id == usuario.id);
            usuarios[usuarios.IndexOf(u)] = usuario;
        }
        public void deletar (int id)
        {
            Usuario usuario = usuarios.Find(x => x.id == id);

            usuarios.Remove(usuario);
        }
    }
}
