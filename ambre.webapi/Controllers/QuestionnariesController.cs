using Microsoft.AspNetCore.Mvc;
using MediatR;
using ambre.application.Questionnaires.Query.GetAllQuestionnairesQuery;

namespace ambre.webapi.Controllers;

[ApiController]
[Route("api/questionnaires")]
public class QuestionnairesController : ControllerBase
{
    private readonly IMediator _mediator;

    public QuestionnairesController(IMediator mediator) => _mediator = mediator;

    [HttpGet]
    public async Task<ActionResult> GetAll()
    {
        var questionnaires = await _mediator.Send(new GetAllQuestionnairesQuery());
        return Ok(questionnaires);
    }
}