using System.ComponentModel.DataAnnotations.Schema;

namespace ambre.repository.Entity;

[Table("questionnaires")]
public class QuestionnaireEntity
{
    public QuestionnaireEntity(string question, string response)
    {
        Id = Guid.NewGuid();
        Question = question;
        Response = response;
    }

    [Column("id")]
    public Guid Id { get; set; }

    [Column("question")]
    public string Question { get; set; }

    [Column("response")]
    public string Response { get; set; }
}