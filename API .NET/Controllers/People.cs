using API_.NET.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_.NET.Controllers
{
    // https://localhost/1987/api/People/Get
    // https://localhost/1987/api/People/GetById

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        [HttpGet]
        public List<PersonModel> Get()
        {
            List<PersonModel> response = new List<PersonModel>();

            for (int i = 0; i < 20; i++)
            {
                response.Add(new PersonModel { Id = i + 1, FullName = "Danny Castillo", Age = 20 });
            }
            return response;
        }

        [HttpGet]
        public string GetById()
        {
            return "";
        }

        [HttpPost]
        public ResponseBase Insert()
        {
            ResponseBase response = new ResponseBase();
            response.Code = -1;
            response.Message = "La persona ya existe";

            return response;
        }
    }
}
