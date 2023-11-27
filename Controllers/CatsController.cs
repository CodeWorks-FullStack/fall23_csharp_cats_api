namespace csharp_cats_api.Controllers;

[ApiController]
[Route("api/[controller]")] // [Route("api/cats")]
public class CatsController : ControllerBase
{

  private readonly CatsService _catsService;

  public CatsController(CatsService catsService)
  {
    _catsService = catsService;
  }

  [HttpGet]
  public ActionResult<List<Cat>> GetCats()
  {
    try
    {
      // const cats = await catsService.getCats()
      List<Cat> cats = _catsService.GetCats();
      return Ok(cats);
    }
    catch (Exception error)
    {
      return BadRequest(error.Message);
    }
  }

  [HttpGet("{catId}")]
  public ActionResult<Cat> GetCatById(int catId)
  {
    try
    {
      Cat cat = _catsService.GetCatById(catId);
      return Ok(cat);
    }
    catch (Exception error)
    {
      return BadRequest(error.Message);

    }
  }

  [HttpPost]
  public ActionResult<Cat> CreateCat([FromBody] Cat catData)
  {
    try
    {
      Cat cat = _catsService.CreateCat(catData);
      return Ok(cat);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("{catId}")]
  public ActionResult<string> DestroyCat(int catId)
  {
    try
    {
      string message = _catsService.DestroyCat(catId);
      return Ok(message);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

}