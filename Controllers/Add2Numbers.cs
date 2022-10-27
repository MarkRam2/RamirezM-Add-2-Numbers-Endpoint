// Mark A Ramirez
// Adding 2 numbers
// 10/25/2022
// this code will take in two inputs and add them togeather
/* peer reviwed by: Freddy Aguilar - the program takes their mini challenge
 2 and converts it into API format. 
 The program takes two numbers from the user and when typed into the url on 
 Postman will add them both up, outputting the answer.*/




using Microsoft.AspNetCore.Mvc;

namespace Add_2_Numbers___Endpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class Add2NumbersController : ControllerBase
{

    [HttpGet]
    [Route("Adding/{num1}/{num2}")]

    public int Math(string num1, string num2)
    {
        int Num1 = Convert.ToInt32(num1);
        int Num2 = Convert.ToInt32(num2);

        return Num1 + Num2;
    }

}
