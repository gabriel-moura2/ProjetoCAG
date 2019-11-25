﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaApp
{
    class Curso
    {
        private int id;
        private string nome;
        public int Id {
            get { return id; }
        }
        public string Nome {
            get { return nome; }
        }

        public Curso(string n, int i)
        {
            nome = n;
            id = i;
        }

        public override string ToString()
        {
            return nome;
        }
    }
}