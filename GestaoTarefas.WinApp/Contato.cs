﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoTarefas.WinApp
{
    [Serializable]

    public class Contato : EntidadeBase
    {
        public string nome;
        public string email;
        public string telefone;
        public string empresa;
        public string cargo;

        public override string ToString()
        {
            return $"Nome: {nome} | Email: {email} | Telefone: {telefone} | Empresa:{empresa} | Cargo:{cargo}";
        }


    }
}