﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo
{
    public class Disciplina
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CargaHoraria { get; set; }
        public override string ToString()
        {
            return Nome;
        }
    }
}
