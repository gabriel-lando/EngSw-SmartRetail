﻿using System;
using System.Text.RegularExpressions;

namespace SmartRetail
{
    class LoginData {
        public string senha, email;
    }
    class Gerente {
        public string senha;
        public InfoBasica info = new InfoBasica();
    }
    class Fornecedor {
        public string senha;
        public InfoBasica info = new InfoBasica();
    }
    class Cliente
    {
        public string facial_data, endereco_cobranca;
        public int infoID;
        public long nro_carta_de_credito;
        public bool onStore;
        public Carrinho carrinho = new Carrinho();
        public InfoBasica info = new InfoBasica();
    }
    class Produto
    {
        public int fornecedorID, quantidade, productID, prateleira;
        public string nome;
        public float preco;
        public DateTime validade;
    }
    class Carrinho
    {
        public int carrinhoID, infoID;
        public float preco_total;
    }
    class Sacola
    {
        public int sacolaID, carrinhoID, quantidade, productID;
    }
    class Oferta
    {
        public int productID;
        public string nome;
        public float desconto;
        public DateTime duracao;
    }
    class Venda
    {
        public int nota_fiscal, carrinhoID, infoID;
        public string nome;
        public float preco_total;
    }

    class InfoBasica {
        public string nome, email;
        public long cadastro, telefone;
        public int funcao, infoID;

        public bool ValidaEmail()
        {
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (rg.IsMatch(this.email))
                return true;
            else
                return false;
        }

    }
}
