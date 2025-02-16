using MediatR;
using ambre.repository.Entity;

namespace ambre.application.Questionnaires.Query.GetAllQuestionnairesQuery;

public record GetAllQuestionnairesQuery() : IRequest<IList<QuestionnaireEntity>>;