﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Matricula { get; set; }
        public string Cpf { get; set; }
        public string Foto { get; set; }
        public int TurmaId { get; set; }
        public string Senha { get; set; }
        public override string ToString()
        {
            return $"{Nome} - {Email} - {Matricula}";
        }
    }
}
