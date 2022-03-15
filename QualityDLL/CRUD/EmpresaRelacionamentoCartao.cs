using System;

namespace WS.CRUD
{
    public class EmpresaRelacionamentoCartao : WS.CRUD.Base
    {
        public EmpresaRelacionamentoCartao(long? idEmpresa, EJB.EntityManager.EntityManager entityManager)
            : base(idEmpresa, entityManager)
        {
        }

        public override Object incluir(System.Collections.Hashtable parametros)
        {
            Data.EmpresaRelacionamentoCartao input = (Data.EmpresaRelacionamentoCartao)parametros["Key"];
            Tables.EmpresaRelacionamentoCartao bd = new Tables.EmpresaRelacionamentoCartao();

            bd.idEmpresaRelacionamentoCartao.isNull = true;
            bd.idEmpresaRelacionamentoCartao.value = input.idEmpresaRelacionamentoCartao;
            bd.saldoAtual.value = input.saldoAtual;
            if (input.empresaRelacionamento != null)
                bd.empresaRelacionamento.idEmpresaRelacionamento.value = input.empresaRelacionamento.idEmpresaRelacionamento;
            else { }

            this.m_EntityManager.persist(bd);

            ((Data.EmpresaRelacionamentoCartao)parametros["Key"]).idEmpresaRelacionamentoCartao = (int)bd.idEmpresaRelacionamentoCartao.value;

            return input; //this.preencher(input, bd, 0);
        }

        public override Object alterar(System.Collections.Hashtable parametros)
        {
            Data.EmpresaRelacionamentoCartao input = (Data.EmpresaRelacionamentoCartao)parametros["Key"];
            Tables.EmpresaRelacionamentoCartao bd = (Tables.EmpresaRelacionamentoCartao)this.m_EntityManager.find
            (
                typeof(Tables.EmpresaRelacionamentoCartao),
                new Object[]
                {
                    input.idEmpresaRelacionamentoCartao
                }
            );

            bd.saldoAtual.value = input.saldoAtual;
            if (input.empresaRelacionamento != null)
                bd.empresaRelacionamento.idEmpresaRelacionamento.value = input.empresaRelacionamento.idEmpresaRelacionamento;
            else { }

            this.m_EntityManager.merge(bd);

            return input; //this.preencher(input, bd, 0);
        }

        public override void excluir(System.Collections.Hashtable parametros)
        {
            Tables.EmpresaRelacionamentoCartao bd = new Tables.EmpresaRelacionamentoCartao();

            bd.idEmpresaRelacionamentoCartao.value = ((Data.EmpresaRelacionamentoCartao)parametros["Key"]).idEmpresaRelacionamentoCartao;
            this.m_EntityManager.remove(bd);
        }

        public override Object preencher(Data.Base input, EJB.TableBase.TTableBase bd, int level)
        {
            if (bd != null)
            {
                if
                (
                    !((Tables.EmpresaRelacionamentoCartao)bd).idEmpresaRelacionamentoCartao.isNull
                )
                {
                    //
                    //Dados Basicos
                    //
                    ((Data.EmpresaRelacionamentoCartao)input).operacao = ENum.eOperacao.NONE;

                    ((Data.EmpresaRelacionamentoCartao)input).idEmpresaRelacionamentoCartao = ((Tables.EmpresaRelacionamentoCartao)bd).idEmpresaRelacionamentoCartao.value;
                    ((Data.EmpresaRelacionamentoCartao)input).saldoAtual = ((Tables.EmpresaRelacionamentoCartao)bd).saldoAtual.value;
                    ((Data.EmpresaRelacionamentoCartao)input).empresaRelacionamento = (Data.EmpresaRelacionamento)(new WS.CRUD.EmpresaRelacionamento(this.m_IdEmpresaCorrente, this.m_EntityManager)).preencher
                    (
                        new Data.EmpresaRelacionamento(),
                        ((Tables.EmpresaRelacionamentoCartao)bd).empresaRelacionamento,
                        level + 1
                    );
                }
                else { }
            }
            else { }

            return input;
        }

        public override Object consultar(System.Collections.Hashtable parametros)
        {
            Data.EmpresaRelacionamentoCartao result = (Data.EmpresaRelacionamentoCartao)parametros["Key"];

            try
            {
                result = (Data.EmpresaRelacionamentoCartao)this.preencher
                (
                    new Data.EmpresaRelacionamentoCartao(),
                    this.m_EntityManager.find
                    (
                        typeof(Tables.EmpresaRelacionamentoCartao),
                        new Object[]
                        {
                            result.idEmpresaRelacionamentoCartao
                        }
                    ),
                    0
                );
            }
            catch (Exception e)
            {
                Utils.Utils.WriteLog(this.GetType().ToString() + ".consultar() -> " + e.ToString());
                throw new Exception(e.Message);
            }

            return result;
        }

        public override String makeSelect(Type classBase, Data.Base input, Object _fieldKeys, System.Collections.Hashtable _params = null)
        {
            String
                result = "",
                sqlWhere = "",
                sqlOrderBy = "";

            int
                numRows = 0,
                offSet = -1;

            bool onlyCount = false;

            if (_params != null)
            {
                if (_params.ContainsKey("numRows"))
                    numRows = (int)_params["numRows"];
                else { }

                if (_params.ContainsKey("onlyCount"))
                    onlyCount = (bool)_params["onlyCount"];
                else { }

                if (_params.ContainsKey("offSet"))
                    offSet = (int)_params["offSet"];
                else { }

                if (_params.ContainsKey("where"))
                    sqlWhere = ((String)_params["where"] ?? "");
                else { }

                if (_params.ContainsKey("orderBy"))
                    sqlOrderBy = ((String)_params["orderBy"] ?? "");
                else { }
            }
            else { }

            Data.EmpresaRelacionamentoCartao _input = (Data.EmpresaRelacionamentoCartao)input;

            System.Collections.Generic.List<EJB.TableBase.TField> fieldKeys = (System.Collections.Generic.List<EJB.TableBase.TField>)_fieldKeys;

            EJB.TableBase.TTableBase table = (EJB.TableBase.TTableBase)classBase.GetConstructor(System.Type.EmptyTypes).Invoke(new Object[0]);

            if (table != null)
            {
                if (_input.idEmpresaRelacionamentoCartao > 0)
                {
                    sqlWhere += ((sqlWhere.Length > 0 ? " and " : "") + "empresaRelacionamentoCartao.idEmpresaRelacionamentoCartao = @idEmpresaRelacionamentoCartao");
                    fieldKeys.Add(new EJB.TableBase.TFieldInteger("idEmpresaRelacionamentoCartao", _input.idEmpresaRelacionamentoCartao));
                    if (!sqlOrderBy.Contains("empresaRelacionamentoCartao.idEmpresaRelacionamentoCartao"))
                        sqlOrderBy += ((sqlOrderBy.Length > 0 ? ", " : "") + "empresaRelacionamentoCartao.idEmpresaRelacionamentoCartao");
                    else { }
                }
                else { }              

                if (_input.empresaRelacionamento != null)
                {
                    if (_input.empresaRelacionamento.idEmpresa > 0)
                    {
                        sqlWhere += ((sqlWhere.Length > 0 ? " and " : "") + "empresaRelacionamento.idEmpresa = @idEmpresa");
                        fieldKeys.Add(new EJB.TableBase.TFieldInteger("idEmpresa", _input.empresaRelacionamento.idEmpresa));
                        if (!sqlOrderBy.Contains("empresaRelacionamento.idEmpresa"))
                            sqlOrderBy += ((sqlOrderBy.Length > 0 ? ", " : "") + "empresaRelacionamento.idEmpresa");
                        else { }
                    }
                    else { }

                    if (_input.empresaRelacionamento.idEmpresaRelacionamento > 0)
                    {
                        sqlWhere += ((sqlWhere.Length > 0 ? " and " : "") + "empresaRelacionamento.idempresaRelacionamento = @idempresaRelacionamento");
                        fieldKeys.Add(new EJB.TableBase.TFieldInteger("idempresaRelacionamento", _input.empresaRelacionamento.idEmpresaRelacionamento));
                        if (!sqlOrderBy.Contains("empresaRelacionamento.idempresaRelacionamento"))
                            sqlOrderBy += ((sqlOrderBy.Length > 0 ? ", " : "") + "empresaRelacionamento.idempresaRelacionamento");
                        else { }
                    }
                    else { }

                    if (_input.empresaRelacionamento.pessoa != null)
                    {
                        if ((_input.empresaRelacionamento.pessoa != null) && (_input.empresaRelacionamento.pessoa.idPessoa > 0))
                        {
                            sqlWhere += ((sqlWhere.Length > 0 ? " and " : "") + "pessoa.idPessoa = @idPessoa");
                            fieldKeys.Add(new EJB.TableBase.TFieldInteger("idPessoa", _input.empresaRelacionamento.pessoa.idPessoa));
                            if (!sqlOrderBy.Contains("pessoa.idPessoa"))
                                sqlOrderBy += ((sqlOrderBy.Length > 0 ? ", " : "") + "pessoa.idPessoa");
                            else { }
                        }
                        else { }

                        if ((_input.empresaRelacionamento.pessoa.cpfCnpj != null) && (_input.empresaRelacionamento.pessoa.cpfCnpj.Length > 0))
                        {
                            sqlWhere += ((sqlWhere.Length > 0 ? " and " : "") + "pessoa.cpfCnpj like @cpfCnpj");
                            fieldKeys.Add(new EJB.TableBase.TFieldString("cpfCnpj", '%' + _input.empresaRelacionamento.pessoa.cpfCnpj + '%'));
                            if (!sqlOrderBy.Contains("pessoa.cpfCnpj"))
                                sqlOrderBy += ((sqlOrderBy.Length > 0 ? ", " : "") + "pessoa.cpfCnpj");
                            else { }
                        }
                        else { }

                        if ((_input.empresaRelacionamento.pessoa.nomeRazaoSocial != null) && (_input.empresaRelacionamento.pessoa.nomeRazaoSocial.Length > 0))
                        {
                            sqlWhere += ((sqlWhere.Length > 0 ? " and " : "") + "pessoa.nomeRazaoSocial COLLATE Latin1_General_CI_AI like @nomeRazaoSocial COLLATE Latin1_General_CI_AI");
                            fieldKeys.Add(new EJB.TableBase.TFieldString("nomeRazaoSocial", '%' + _input.empresaRelacionamento.pessoa.nomeRazaoSocial + '%'));
                            if (!sqlOrderBy.Contains("pessoa.nomeRazaoSocial"))
                                sqlOrderBy += ((sqlOrderBy.Length > 0 ? ", " : "") + "pessoa.nomeRazaoSocial");
                            else { }
                        }
                        else { }
                    }
                    else { }
                }
                else { }

                result =
                (
                    "select " + (onlyCount ? "" : (((numRows > 0) && (offSet < 0)) ? " top " + numRows.ToString() + " " : "")) +
                    "   " + (onlyCount ? " COUNT(1) " : "empresaRelacionamentoCartao.* ") +
                    "from " +
                    (
                        "   empresaRelacionamentoCartao empresaRelacionamentoCartao " +
                        "       inner join empresaRelacionamento empresaRelacionamento " +
                        "           on	empresaRelacionamento.idEmpresaRelacionamento = empresaRelacionamentoCartao.idEmpresaRelacionamento " +
                        "       inner join pessoa pessoa " +
                        "           on	pessoa.idPessoa = empresaRelacionamento.idPessoaRelacionamento "
                    ) +
                    (sqlWhere.Length > 0 ? " where " + sqlWhere : "") +
                    (onlyCount ? "" :
                        (sqlOrderBy.Length > 0 ? " order by " + sqlOrderBy : "") +
                        (((numRows > 0) && (offSet >= 0)) ? " offset " + offSet + " rows fetch next " + numRows + " rows only" : "")
                    )
                );

                table = null;
            }
            else { }

            return result;
        }


        public override Object listar(System.Collections.Hashtable parametros)
        {
            Data.EmpresaRelacionamentoCartao input = (Data.EmpresaRelacionamentoCartao)parametros["Key"];
            System.Collections.Generic.List<Data.Base> result = new System.Collections.Generic.List<Data.Base>();
            string mode = (string)(parametros["Mode"] == null ? "" : parametros["Mode"]);
            int level = (int)(parametros["Level"] == null ? 0 : parametros["Level"]);

            System.Collections.Hashtable makeSelectParams = new System.Collections.Hashtable();
            makeSelectParams["numRows"] = (parametros["Top"] == null ? 0 : (int)parametros["Top"]);
            makeSelectParams["where"] = (parametros["Filter"] == null ? "" : (String)parametros["Filter"]);
            makeSelectParams["orderBy"] = (parametros["Order"] == null ? "" : (String)parametros["Order"]);
            makeSelectParams["offSet"] = (parametros["Offset"] == null ? -1 : parametros["Offset"]);

            Report.Base report = (Report.Base)parametros["Report"];

            try
            {
                System.Collections.Generic.List<EJB.TableBase.TField> _fieldKeys = new System.Collections.Generic.List<EJB.TableBase.TField>();

                if (parametros["Filter"] != null)
                {
                    String
                        _filter = (String)parametros["Filter"],
                        _keys = "";

                    while (_filter.Contains("@"))
                    {
                        String _key = _filter.Substring(_filter.IndexOf("@")).Split(new char[] { ' ', ')' })[0];

                        if (!_keys.Contains("[" + _key + "]"))
                        {
                            _fieldKeys.Add((EJB.TableBase.TField)parametros[_key]);
                            _keys += "[" + _key + "]";
                        }
                        else { }

                        _filter = _filter.Substring(_filter.IndexOf("@") + _key.Length);
                    }
                }
                else { }

                String _select = this.makeSelect
                (
                    typeof(Tables.EmpresaRelacionamentoCartao),
                    input,
                    _fieldKeys,
                    makeSelectParams
                );

                makeSelectParams.Clear();
                makeSelectParams = null;

                foreach
                (
                    Tables.EmpresaRelacionamentoCartao _data in
                    (System.Collections.Generic.List<Tables.EmpresaRelacionamentoCartao>)this.m_EntityManager.list
                    (
                        typeof(Tables.EmpresaRelacionamentoCartao),
                        _select,
                       _fieldKeys.ToArray()
                    )
                )
                {
                    Data.Base _base = new Data.Base();

                    //if (mode == "Roll")
                    //{
                    //_base = new Data.ResultadoConsulta();

                    //if (!_data.codConsCampo.codUsuario.isNull)
                    //{
                    //    ((Data.ResultadoConsulta)_base).codigo = (int)_data.codConsCampo.codUsuario.value;
                    //    ((Data.ResultadoConsulta)_base).descricao =
                    //    (
                    //        _data.descricao.value + "(" + _data.codConsCampo.idCadastro.nome.value + ")"
                    //    );
                    //}
                    //else
                    //{
                    //    ((Data.ResultadoConsulta)_base).codigo = (int)_data.codCarteira.value;
                    //    ((Data.ResultadoConsulta)_base).descricao = _data.descricao.value;
                    //}
                    //}
                    //else
                    _base = (Data.Base)this.preencher(new Data.EmpresaRelacionamentoCartao(), _data, level);

                    if (report != null)
                        report.ProcessRecord(_base);
                    else
                        result.Add(_base);
                }

                if (report != null)
                    report.ProcessRecord(null);
                else { }

                _fieldKeys.Clear();
                _fieldKeys = null;
                _select = null;
            }
            catch (Exception e)
            {
                Utils.Utils.WriteLog(this.GetType().ToString() + ".listar() -> " + e.ToString());
                throw new Exception(e.Message);
            }

            return ((result.Count > 0) ? result.ToArray() : null);
        }
    }
}
