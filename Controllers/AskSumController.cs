//John Magpantay
// 10-25-2022
// Mini challenge3 API VERSION
// Peer review [Kent it works like it supposed to. But one problem for some reason the play again doesn't work.-__-   ]


using Microsoft.AspNetCore.Mvc;

namespace MagpantayJAskingQuestions.Controllers;

[ApiController]
[Route("[controller]")]
public class AskSumController : ControllerBase
{
    [HttpGet]
    [Route("AskMeh/{word}/{word2}/{word3}")]

    public string sayAsk(string word, string word2, string word3)

    {

     return $" What up {word}\n you woke up at {word2}\nPlayAgain? Yes or No\n{word3}";


    }

}
