using Microsoft.AspNetCore.Mvc;

namespace Add2NumbersEndPoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddTwoNumbersController : ControllerBase
    {
        [HttpGet]
        [Route("Sum")]

        public string GetSum(int num1, int num2)
        {
            int result = num1 + num2;
            return $"The sum of {num1} + {num2} is equal to {result}";
        }

    }
}