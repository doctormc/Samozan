using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace iMessengerCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class iMessengerCoreAPIController : ControllerBase
    {
        private readonly IRequestProcessor processor;

        public iMessengerCoreAPIController(IRequestProcessor _processor)
        {
            this.processor = _processor;
        }

        [HttpPost]
        public Guid Post([FromBody] List<Guid> ListOfClients)
        {
            return processor.GetFromRepoDialoguesByClients(ListOfClients);
        }
    }
}
