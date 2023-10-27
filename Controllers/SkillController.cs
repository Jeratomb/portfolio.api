using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace portfolio.api.Controllers
{
    [Route("[controller]")]
    [EnableCors]
    public class SkillController : Controller
    {
        private readonly ILogger<SkillController> _logger;

        public SkillController(ILogger<SkillController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetSkills")]
        public IEnumerable<Skill> Get()
        {

            var knowledges = new Knowledges();

            Array values = Enum.GetValues(typeof(Scale));
            Random random = new Random();

            _logger.Log(LogLevel.Information, "Get call");

            var returnValue = Enumerable.Range(0, 8).Select(index => new Skill
            {
                _id = Guid.NewGuid(),
                _name = "Test-Project-" + index,
                _knowledge = knowledges._knowledges.ElementAt(index),
                _scale = (Scale)values.GetValue(random.Next(0,3))

            })
                    .ToArray();

            return returnValue;


        }
    }
}