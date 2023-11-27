namespace csharp_cats_api.Controllers;

[ApiController]
// [Route("api/cats")]
[Route("api/[controller]")]
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
}