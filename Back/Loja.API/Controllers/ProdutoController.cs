using Microsoft.AspNetCore.Mvc;

namespace Loja.API.Controllers{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase{
        public ProdutoController(){

        }
        [HttpGet]
        public string Get(){
            return "Olá Mundo!";
        }

        [HttpGet("{id}")]
        public string Get(int id){
            return "Olá Mundo!"+id;
        }

        [HttpPost]
        public string Post(){
            return "Olá Post!";
        }

        [HttpPut("{id}")]
        public string Put(int id){
            return "Olá Put!"+id;
        }

        [HttpDelete("{id}")]
        public string Delete(int id){
            return "Olá Delete!"+id;
        }
    }
}