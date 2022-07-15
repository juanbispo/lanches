using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public PedidoController(IPedidoRepository pedidoRepository, CarrinhoCompra carrinhoCompra)
        {
            _pedidoRepository = pedidoRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        [Authorize]
        [HttpGet]
        public IActionResult Checkout()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Checkout(Pedido pedido)
        {
            int totalItensPedido = 0;
            decimal precoTotalPedido = 0.0m;

            //obtem os itens do carrinho de compra do cliente

            List<CarrinhoCompraItem> items = _carrinhoCompra.GetCarrinhoCompraItens();

            _carrinhoCompra.CarrinhoCompraItems = items;

            //verificar se existem itens do pedido

            if (_carrinhoCompra.CarrinhoCompraItems.Count == 0)
            {
                ModelState.AddModelError("", "Seu Carrinho Está Vazio");

            }

            //Calcular o Total de Itens e o Total do Pedido

            foreach(var item in items)
            {
                totalItensPedido += item.Quantidade;

                precoTotalPedido += (item.Quantidade + item.Lanche.Preco);
            }

            //atribui os valores obtidos no foreach

            pedido.TotalItensPedido = totalItensPedido;

            pedido.PedidoTotal = precoTotalPedido;

            //validar os dados do pedido

            if (ModelState.IsValid)
            {
                //criar o pedido e os detalhes do pedido

                _pedidoRepository.CriarPedido(pedido);

                //define mensagens ao cliente

                ViewBag.CheckoutCompletoMensagem = "Obrigado pelo seu pedido !";
                ViewBag.TotalPedido = _carrinhoCompra.GetCarrinhoCompraTotal();

                _carrinhoCompra.LimparCarrinho();

                return View("~/Views/Pedido/CheckoutCompleto.cshtml", pedido);
            }
            return View(pedido);
        }
    }
}
