using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prova.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaPagamentoController : ControllerQuality
    {
        //Criar uma action do tipo POST, que servirá como uma API de busca de resultados.
        //Retornar um array com todos os registros.
        [
            Route("api/[controller]/{descricao}/{idEmpresa}/BuscaContaPagamento"),
            HttpPost
        ]
        public async Task<ActionResult<dynamic>> BuscaContaPagamento(string descricao, int idEmpresa)
        {
            Data.ContaPagamento contaPagamento = new Data.ContaPagamento
            {
                descricao = descricao,
                idEmpresa = idEmpresa
            };
            List<Data.Base> arrayList = Utils.Utils.listaDados(idEmpresa, contaPagamento, 10);

            return UtilsGestao.UtilsApi.Retorno(arrayList);
        }


        //Criar uma action do tipo GET, que servirá como uma API de detalhamento de registro.
        //Retornar um objeto com os dados do registro em questão.
        [
            Route("api/[controller]/DetalhamentoRegistro"),
            HttpGet
        ]
        public async Task<ActionResult<dynamic>> DetalhamentoRegistro()
        {
            var body = await this.GetBody<Data.ContasAReceber>();

            if (body == null)
                throw new Exception("Parâmetros incorretos!");
            else { }

            Data.ContaPagamento contaPagamento = new Data.ContaPagamento();

            contaPagamento = (Data.ContaPagamento)sr.consultar(contaPagamento);

            return contaPagamento;
        }

        [
            Route(""),
            HttpGet
        ]
        public ActionResult<dynamic> Teste()
        {
            Data.ContaPagamento key = new Data.ContaPagamento();
            var grid = GenerateGrid ? new UtilsApi.Grid().FillFormComponentFields(key.GetType(), false) : new GridModel { };
            return null;
        }
    }
}
