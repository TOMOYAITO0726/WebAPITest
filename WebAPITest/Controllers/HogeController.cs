using WebAPITest.Base;
using WebAPITest.Model;
using Microsoft.AspNetCore.Mvc;

namespace WebAPITest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HogeController : ControllerBase
    {
        private readonly ILogger<HogeController> _logger;
        private IHogeBusinesslogic<HogeInputModel, HogeResultModel> hogeBusinesslogic;

        public HogeController(ILogger<HogeController> logger, IHogeBusinesslogic<HogeInputModel, HogeResultModel> hogeBusinesslogic)
        {
            _logger = logger;
            this.hogeBusinesslogic = hogeBusinesslogic;
        }

        [HttpGet]
        [Route("Get")]
        public HogeResultModel Get([FromQuery] HogeInputModel input)
        {
            HogeResultModel result = hogeBusinesslogic.GetHoge(input);

            return result;
        }

        [HttpPost]
        [Route("Post")]
        public HogeResultModel Post(HogeInputModel input)
        {
            HogeResultModel result = new HogeResultModel();
            // 処理は割愛します。
            return result;
        }
    }
}