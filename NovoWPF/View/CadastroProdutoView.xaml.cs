﻿using NovoWPF.ViewModel.Commands;
using System;
using System.Collections.Generic;
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

namespace NovoWPF.View
{
    /// <summary>
    /// Interação lógica para CadastroProdutoView.xam
    /// </summary>
    public partial class CadastroProdutoView : Window
    {
        public CadastroProdutoView()
        {
            InitializeComponent();
        }

        private void BtnSalvarProduto_Click(object sender, RoutedEventArgs e)
        {
            AbrirCadastroProdutoCommand dados = new AbrirCadastroProdutoCommand();
            dados.DadosProduto();
            MessageBox.Show("vai");
            Close();
        }
    }
}
