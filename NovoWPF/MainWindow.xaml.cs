﻿using NovoWPF.RegraDeNegocio;
using NovoWPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NovoWPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Produto> Produtos = new ObservableCollection<Produto>();
        public ObservableCollection<Pessoa> Pessoas   = new ObservableCollection<Pessoa>();
        public ObservableCollection<Pedido> Pedidos   = new ObservableCollection<Pedido>();

        public MainWindow()
        {
            InitializeComponent();
            Produtos = new ObservableCollection<Produto>();
            Pessoas = new ObservableCollection<Pessoa>();
            Pedidos = new ObservableCollection<Pedido>();
            DataContext = new PessoaViewModel(Pessoas, Pedidos);
            DataContext = new ProdutoViewModel(Produtos);
        }
    }
}
