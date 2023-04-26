using AplicativoWeb.Models; //camada Model
using Microsoft.AspNetCore.Mvc; //Microsoft
namespace AplicativoWeb.Controllers; //Definindo
//Criamos a classe Controller

public class CursoController:Controller{

    public IActionResult Index(){
        Curso c1 = new Curso();
        //set
        c1.Descricao = "Primeiro Passo no ASP.NET Core";
        c1.TituloInterno = "Desenvolvedor C#";
        c1.TituloMarketing = "Crie Aplicativo Incríveis";
        //get
        ViewData["curso"] = c1;
    
        return View();
            }
            //Action
            public IActionResult Create(){
                ViewData["titulo"]="Cadastro de curso";
                ViewBag.DataHora = DateTime.Now;
                return View();
            }

}