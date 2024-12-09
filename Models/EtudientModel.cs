public class Etudiant
{
    public int Id { get; set; }
    public string Matricule { get; set; }
    public string NomComplet { get; set; }
    public string Adresse { get; set; }
    public int AnneeInscription { get; set; }
}

public class Cours
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan HeureDebut { get; set; }
    public TimeSpan HeureFin { get; set; }
    public int NombreHeures { get; set; }
    public string Semestre { get; set; }
    public string Module { get; set; }
    public Professeur Professeur { get; set; }
    public List<Classe> Classes { get; set; }
}

public class Absence
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public Etudiant Etudiant { get; set; }
    public Cours Cours { get; set; }
}
