﻿using NovoWPF.View;
using NovoWPF.ViewModel.Commands;
using NovoWPF.ViewModel.Commands.CommandProdutos.EditarProduto;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace NovoWPF.ViewModel
{
    public class CadastroProdutoViewModel : CloseWindow
    {
        public CadastroProdutoView CadastroProdutoView { get; set; }

        public ObservableCollection<Produto> Produtos { get; set; }

        public ICommand SalvarProduto { get; }
        public ICommand EditarProduto { get; }


        public CadastroProdutoViewModel(ObservableCollection<Produto> produtos , CadastroProdutoView cadastro, ProdutoViewModel produtoViewModel)
        {
            Produtos = produtos;
            CadastroProdutoView = cadastro;
            SalvarProduto = new SalvarProdutoCommand(Produtos, CadastroProdutoView, produtoViewModel);
        }

        public CadastroProdutoViewModel(ObservableCollection<Produto> produtos, CadastroProdutoView cadastro)
        {
            EditarProduto = new EditarProdutoCommand(produtos, cadastro);
        }

        public CadastroProdutoViewModel()
        {
        }
      
    }
}