using Microsoft.AspNetCore.Mvc;
using MinhaCantina.Biblioteca.Modelos;

namespace MinhaCantina.Servidor.Controllers;

[Route("[controller]")]
[ApiController]
public class CategoriaController : ControllerBase
{
	[HttpGet]
	public IActionResult PegarCategoria()
	{
		var categoria = Categoria.Criar("Salgados");
		return StatusCode(200, categoria);
	}
}
