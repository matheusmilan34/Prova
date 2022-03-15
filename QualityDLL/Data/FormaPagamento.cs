using System;
using Utils.Pagina.Attributes;

namespace Data
{
	//[Serializable]
	public class FormaPagamento: Base
	{
		public FormaPagamento(): base()
		{
		}

        [
            TFieldAttributeKey(true, true),
            TFieldAttributeGridDisplay("ID", 55),
            TFieldAttributeData(6, true)
        ]
        private int m_IdFormaPagamento;
		public int idFormaPagamento
		{
			get{return this.m_IdFormaPagamento;}
			set{this.m_IdFormaPagamento = value;}
		}

        [
            TFieldAttributeGridDisplay("Descri��o", 280),
            TFieldAttributeData(50, true)
        ]
        private String m_Descricao;
		public String descricao
		{
			get{return this.m_Descricao;}
			set{this.m_Descricao = value;}
        }

        [
            TFieldAttributeGridDisplay("Tipo", 123),
            TFieldAttributeData(2, true),
            TFieldAttributeSubfield("ItemGenerico:_Selecione;1_Dinheiro;2_Cart�o de Cr�dito;3_Cart�o de D�bito;4_Cheque � vista;5_Cheque Pr�-Datado;51_Cart�o Pr�-Pago;52_Cartao P�s-Pago")
        ]
        private int m_Tipo;
        public int tipo
        {
            get { return this.m_Tipo; }
            set { this.m_Tipo = value; }
        }

        [
            TFieldAttributeGridDisplay("C�digo Fiscal", 123),
            TFieldAttributeData(2, false),
            TFieldAttributeSubfield("ItemGenerico:_Selecione;1_1 - Dinheiro;2_2 - Cheque;3_3 - Cart�o de Cr�dito;4_4 - Cart�o de D�bito;5_5 - Cr�dito da Loja;10_10 - Vale Alimenta��o;11_11 - Vale Refei��o;12_12 - Vale Presente;13_13 - Vale Combust�vel;14_14 - Duplicata Mercantil;15_15 - Boleto Banc�rio;90_90 - Sem Pagamento;99_99 - Outro")
        ]
        private int m_CodigoFiscal;
        public int codigoFiscal
        {
            get { return this.m_CodigoFiscal; }
            set { this.m_CodigoFiscal = value; }
        }

        [
            TFieldAttributeGridDisplay("Bandeira do Cart�o", 130),
            TFieldAttributeData(2, false),
            TFieldAttributeSubfield("ItemGenerico:_Selecione;1_Visa;2_MasterCard;3_American Express;4_SoroCred;5_Diners Club;6_Elo;7_HiperCard;8_Aura;9_Cabal;99_Outro")
        ]
        private int m_IdBandeiraCartao;
        public int idBandeiraCartao
        {
            get { return this.m_IdBandeiraCartao; }
            set { this.m_IdBandeiraCartao = value; }
        }

        [
            TFieldAttributeGridDisplay("Habilitar Valor Digitado", 150),
            TFieldAttributeData(2, false),
            TFieldAttributeSubfield("ItemGenerico:_Selecione;1_Sim;0_N�o")
        ]
        private string m_HabilitarValorDigitadoFechamento;
        public string habilitarValorDigitadoFechamento
        {
            get { return this.m_HabilitarValorDigitadoFechamento; }
            set { this.m_HabilitarValorDigitadoFechamento = value; }
        }

        public override string ToString()
        {
            return this.m_IdFormaPagamento.ToString();
        }
    }
}
