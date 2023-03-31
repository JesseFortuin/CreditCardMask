using CreditCardMask.BL;
using Microsoft.AspNetCore.Mvc;

namespace CreditCardMask.Api.Controllers
{
    [ApiController]
    [Route("api/mask")]
    //base contains functionality controllers need
    //access to model state, current user, methods to return responses
    public class MaskController : ControllerBase
    {
        //action level
        [HttpGet("{input}")]
        //returns any data in contructor is Represented in Json form
        public JsonResult Maskify(string input)
        {
            MaskingDetails mask = new MaskingDetails();

            var result = mask.Maskify(input);

            return new JsonResult(result);
        }
    }
}
