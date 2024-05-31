using JWTAuthenticationDemo.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWTAuthenticationDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService service;
        public BookController(IBookService service)
        {
            this.service = service;
        }
        [HttpGet]
        [Authorize(Roles = "Admin,Customer")]
        [Route("GetBooks")]
        public IActionResult GetBooks()
        {
            var model = service.GetBooks();
            return new ObjectResult(model);
        }
    }

}
