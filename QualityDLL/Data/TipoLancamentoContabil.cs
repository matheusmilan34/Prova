using System;
using Utils.Pagina.Attributes;

namespace Data
{
    //[Serializable]
    public class TipoLancamentoContabil : Base
    {
        public TipoLancamentoContabil()
            : base()
        {
        }

        [
            TFieldAttributeKey(true, true),
            TFieldAttributeGridDisplay("ID", 55),
            TFieldAttributeData(6, true)
        ]
        private int m_IdTipoLancamentoContabil;
        public int idTipoLancamentoContabil
        {
            get { return this.m_IdTipoLancamentoContabil; }
            set { this.m_IdTipoLancamentoContabil = value; }
        }

        [
            TFieldAttributeGridDisplay("Descri��o", 250),
            TFieldAttributeEditDisplay("Descri��o", 250),
            TFieldAttributeData(50, true)
        ]
        private String m_Descricao;
        public String descricao
        {
            get { return this.m_Descricao; }
            set { this.m_Descricao = value; }
        }

        [
            TFieldAttributeGridDisplay("D�bito/Cr�dito", 130),
            TFieldAttributeData(1, true),
            TFieldAttributeSubfield("ItemGenerico:_Selecione;D_D�bito;C_Cr�dito")
        ]
        private String m_DebitoCredito;
        public String debitoCredito
        {
            get { return this.m_DebitoCredito; }
            set { this.m_DebitoCredito = value; }
        }

        public override string ToString()
        {
            return this.m_IdTipoLancamentoContabil.ToString();
        }
    }
}
