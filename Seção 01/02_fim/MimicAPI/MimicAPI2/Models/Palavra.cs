﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MimicAPI2.Models
{
    public class Palavra
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public int Pontuacao { get; set; }
        public bool Ativo { get; set; }
        public DateTime Criado { get; set; }
        public DateTime? Atualizado { get; set; }
    }
}
