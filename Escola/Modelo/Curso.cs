﻿using System;

namespace Modelo
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public override string ToString()
        {
            return Nome;
        }
    }
}
