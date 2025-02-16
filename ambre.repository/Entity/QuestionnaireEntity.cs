namespace ambre.repository.Entity;

public class QuestionnaireEntity
{
    public QuestionnaireEntity(string question, string response)
    {
        Id = Guid.NewGuid();
        Question = question;
        Response = response;
    }

    public Guid Id { get; set; }

    public string Question { get; set; }

    public string Response { get; set; }
}