﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoWPF.View
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public string Codigo { get; set; }
        public double Valor { get; set; }
        public int QntdProduto { get; set; }

        public Produto()
        {
        }

        public Produto(int idProduto, string nomeProduto, string codigo, double valor)
        {
            IdProduto = idProduto;
            NomeProduto = nomeProduto;
            Codigo = codigo;
            Valor = valor;
        }

        public Produto(int idProduto, string nomeProduto, double valor, int qntdProduto)
        {
            IdProduto = idProduto;
            NomeProduto = nomeProduto;
            Valor = valor;
            QntdProduto = qntdProduto;
        }
    }
}
