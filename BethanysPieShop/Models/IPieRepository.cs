namespace BethanysPieShop.Models;

public interface IPieRepository
{
    IEnumerable<Pie> AllPies();
    IEnumerable<Pie> PiesOfTheWeek { get; }
    Pie? GetPieById(int pieId);
}