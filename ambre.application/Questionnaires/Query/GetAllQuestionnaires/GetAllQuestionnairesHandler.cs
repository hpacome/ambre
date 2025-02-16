using MediatR;
using ambre.repository.Entity;
using ambre.repository.Interface;

namespace ambre.application.Questionnaires.Query.GetAllQuestionnairesQuery;

public class GetAllQuestionnairesHandler : IRequestHandler<GetAllQuestionnairesQuery, IEnumerable<QuestionnaireEntity>>
{
    private readonly IQuestionnairesRepository _repository;

    public GetAllQuestionnairesHandler(IQuestionnairesRepository repository) => _repository = repository;
    public async Task<IEnumerable<QuestionnaireEntity>> Handle(GetAllQuestionnairesQuery request,
        CancellationToken cancellationToken) => (await _repository.GetAllAsync()).AsEnumerable();
}