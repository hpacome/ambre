using ambre.repository.Entity;
using ambre.repository.Interface;

namespace ambre.repository;

public class QuestionnairesRepository : IQuestionnairesRepository
{
    public QuestionnairesRepository()
    {

    }

    public Task CreateAsync(QuestionnaireEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<IQueryable<QuestionnaireEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<QuestionnaireEntity> GetAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(QuestionnaireEntity entity)
    {
        throw new NotImplementedException();
    }
}