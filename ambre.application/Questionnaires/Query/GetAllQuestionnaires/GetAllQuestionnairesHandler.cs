using MediatR;
using ambre.repository.Entity;
using ambre.repository.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ambre.application.Questionnaires.Query.GetAllQuestionnairesQuery;

public class GetAllQuestionnairesHandler : IRequestHandler<GetAllQuestionnairesQuery, IList<QuestionnaireEntity>>
{
    private readonly IQuestionnairesRepository _repository;
    private readonly ILogger<GetAllQuestionnairesHandler> _logger;

    public GetAllQuestionnairesHandler(
        IQuestionnairesRepository repository,
        ILogger<GetAllQuestionnairesHandler> logger)
    { 
        _repository = repository;
        _logger = logger;
    }
    
    public async Task<IList<QuestionnaireEntity>> Handle(GetAllQuestionnairesQuery request, CancellationToken cancellationToken) 
    {
        try
        {
            return await _repository.GetAll().ToListAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error while getting all questionnaires");
            return new List<QuestionnaireEntity>();
        }
    }
}