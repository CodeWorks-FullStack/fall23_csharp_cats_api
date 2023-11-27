

namespace csharp_cats_api.Services;

public class CatsService
{
  private readonly CatsRepository _catsRepository;

  public CatsService(CatsRepository catsRepository)
  {
    _catsRepository = catsRepository;
  }

  internal Cat CreateCat(Cat catData)
  {
    if (catData.Name == null)
    {
      throw new Exception("Please provide a name");
    }
    Cat cat = _catsRepository.CreateCat(catData);
    return cat;
  }

  internal string DestroyCat(int catId)
  {
    // Cat cat = this.GetCatById(catId);
    Cat cat = GetCatById(catId);

    _catsRepository.DestroyCat(cat);


    return $"{cat.Name} has been sent to the farm";
  }

  internal Cat GetCatById(int catId)
  {
    Cat cat = _catsRepository.GetCatById(catId);

    if (cat == null)
    {
      throw new Exception($"Invalid id: {catId}");
    }

    return cat;
  }

  internal List<Cat> GetCats()
  {
    List<Cat> cats = _catsRepository.GetCats();
    return cats;
  }
}