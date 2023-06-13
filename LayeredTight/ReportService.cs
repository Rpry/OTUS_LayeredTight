using BusinessLogicLayer;

namespace LayeredTight;

public class ReportController
{
    private ReportService _reportService;

    public ReportController()
    {
        _reportService = new ReportService();
    }
    
    public bool Delete(int id)
    {
        return _reportService.Delete(id);
    }
}