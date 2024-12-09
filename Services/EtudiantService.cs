public interface IEtudiantService
{
    List<Cours> GetCours(int etudiantId);
    List<Absence> GetAbsences(int etudiantId);
}

public class EtudiantService : IEtudiantService
{
    private readonly AppDbContext _context;

    public EtudiantService(AppDbContext context)
    {
        _context = context;
    }

    public List<Cours> GetCours(int etudiantId)
    {
        return _context.Cours
            .Where(c => c.Classes.Any(cl => cl.Etudiants.Any(e => e.Id == etudiantId)))
            .ToList();
    }

    public List<Absence> GetAbsences(int etudiantId)
    {
        return _context.Absences
            .Where(a => a.Etudiant.Id == etudiantId)
            .ToList();
    }
}
