using ambre.repository.Entity;

namespace ambre.repository.Interface;

public interface IQuestionnairesRepository
{
    void Create(QuestionnaireEntity entity);

    void Update(QuestionnaireEntity entity);

    QuestionnaireEntity? Get(Guid id);

    IQueryable<QuestionnaireEntity> GetAll();
}