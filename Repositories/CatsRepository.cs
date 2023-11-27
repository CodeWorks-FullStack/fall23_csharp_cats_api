
namespace csharp_cats_api.Repositories;

public class CatsRepository
{
  private List<Cat> _cats;

  public CatsRepository()
  {
    _cats = [
      new Cat(1,"Gopher", 3, true, "black", 4),
      new Cat(2,"Squishy", 5, true, "Gray", 4),
      new Cat(3,"Blake", 34, false, "Green", 2),
      ];
  }

  internal Cat CreateCat(Cat catData)
  {
    Cat lastCat = _cats[_cats.Count - 1];
    if (lastCat == null)
    {
      catData.Id = 1;
    }
    else
    {
      catData.Id = lastCat.Id + 1;
    }
    _cats.Add(catData);
    return catData;
  }

  internal void DestroyCat(Cat cat)
  {
    _cats.Remove(cat);
  }

  internal Cat GetCatById(int catId)
  {
    Cat foundCat = _cats.Find(cat => cat.Id == catId);
    return foundCat;
  }

  internal List<Cat> GetCats()
  {
    return _cats;
  }
}
