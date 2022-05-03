using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GestaoTarefas.WinApp
{
    [Serializable]

    public class RepositorioBase<T> where T : EntidadeBase
    {
       
            protected List<T> registros;

            public virtual void Inserir(T entidade)
            {
            }

            public virtual void Editar(T entidade)
            {
            }

            public virtual void Excluir(T entidade)
            {
            }

            public List<T> CarregarRegistrosDoArquivo(string diretorio)
            {
                if (File.Exists(diretorio) == false)
                {
                    return new List<T>();
                }

                BinaryFormatter serializador = new BinaryFormatter();

                byte[] bytesRegistros = File.ReadAllBytes(diretorio);

                MemoryStream ms = new MemoryStream(bytesRegistros);

                return (List<T>)serializador.Deserialize(ms);
            }
        
    }
}
