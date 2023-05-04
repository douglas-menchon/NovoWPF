﻿using NovoWPF.Commands;
using NovoWPF.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NovoWPF.ViewModel.Commands.CommandProdutos.EditarProduto
{
    public class EditarProdutoCommand : CommandBase
    {
        public ObservableCollection<Produto> Produtos { get; set; }
        private CadastroProdutoView CadastroProdutoView { get; set; }


        public EditarProdutoCommand(ObservableCollection<Produto> produtos, CadastroProdutoView cadastroProdutoView)
        {
            Produtos = produtos;
            CadastroProdutoView = cadastroProdutoView;
        }

        public override void Execute(object parameter)
        {
            if (CadastroProdutoView.nomeProdutoBox.Text != "" && CadastroProdutoView.codigoProdutoBox.Text != "" && CadastroProdutoView.valorProdutoBox.Text != "")
            {

                int idText = Convert.ToInt32(CadastroProdutoView.idProdutoBox.Text);
                int indexList = Produtos.IndexOf(Produtos.Where(p => p.IdProduto == idText).FirstOrDefault());


                Produtos[indexList].NomeProduto = CadastroProdutoView.nomeProdutoBox.Text.ToUpper();
                Produtos[indexList].Codigo = CadastroProdutoView.codigoProdutoBox.Text;

                if (!string.IsNullOrEmpty(CadastroProdutoView.valorProdutoBox.Text))
                {
                    Produtos[indexList].Valor = double.Parse(CadastroProdutoView.valorProdutoBox.Text);
                }

                MessageBox.Show($"Produto: {CadastroProdutoView.nomeProdutoBox.Text} editado com sucesso");
          
                CadastroProdutoView.Visibility = Visibility.Collapsed;
            }
            else
            {
                MessageBox.Show("Campos obrigatórios não preenchidos!!");
            }

        }
    }
}

