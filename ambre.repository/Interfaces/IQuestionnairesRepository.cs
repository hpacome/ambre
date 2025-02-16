using ambre.repository.Entity;

namespace ambre.repository.Interface;

public interface IQuestionnairesRepository
{
    Task CreateAsync(QuestionnaireEntity entity);

    Task UpdateAsync(QuestionnaireEntity entity);

    Task<QuestionnaireEntity> GetAsync(Guid id);

    Task<IQueryable<QuestionnaireEntity>> GetAllAsync();
}