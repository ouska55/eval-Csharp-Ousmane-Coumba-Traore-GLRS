public class EtudiantController : Controller
{
    private readonly IEtudiantService _etudiantService;

    public EtudiantController(IEtudiantService etudiantService)
    {
        _etudiantService = etudiantService;
    }

    public IActionResult ListeCours()
    {
        int etudiantId = GetEtudiantId(); // Obtenez l'identifiant de l'étudiant connecté
        var cours = _etudiantService.GetCours(etudiantId);
        return View(cours);
    }

    public IActionResult ListeAbsences()
    {
        int etudiantId = GetEtudiantId(); // Obtenez l'identifiant de l'étudiant connecté
        var absences = _etudiantService.GetAbsences(etudiantId);
        return View(absences);
    }

    private int GetEtudiantId()
    {
        // Implémentez la logique pour obtenir l'identifiant de l'étudiant connecté
        return 1; // Exemple
    }
}
