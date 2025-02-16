using ambre.repository.Entity;
using ambre.repository.Interface;

namespace ambre.repository;

public class QuestionnairesRepository : IQuestionnairesRepository
{
    private readonly ApplicationDbContext _context;

    public QuestionnairesRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public void Create(QuestionnaireEntity entity)
    {
        _context.Questionnaires.Add(entity);
        _context.SaveChanges();
    }

    public IQueryable<QuestionnaireEntity> GetAll()
    {
        return _context.Questionnaires.AsQueryable();
    }

    public QuestionnaireEntity? Get(Guid id)
    {
        return _context.Questionnaires.FirstOrDefault(x => x.Id == id);
    }

    public void Update(QuestionnaireEntity entity)
    {
        _context.Questionnaires.Update(entity);
        _context.SaveChanges();
    }
}