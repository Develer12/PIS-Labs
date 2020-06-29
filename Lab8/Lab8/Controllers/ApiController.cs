using Microsoft.AspNetCore.Mvc;

namespace Lab8.Controllers
{
    [Route("api")]
    [ApiController]
    public class APIController : ControllerBase
    {
        private IPhoneDictionary repo;
        public APIController(IPhoneDictionary r)
        {
            repo = r;
        }

        // GET api/
        [HttpGet]
        public ActionResult Select()
        {
            var telephones = repo.selectAll();
            if (telephones == null)
            {
                return NoContent();
            }
            return Ok(telephones);
        }

        // GET api/5
        [HttpGet("{id:int}")]
        public ActionResult Getone(int id)
        {
            var telephones = repo.selectById(id);
            if (telephones == null)
            {
                return NoContent();
            }
            return Ok(telephones);
        }

        // POST api/
        [HttpPost]
        public ActionResult Post(Telephone telephone)
        {
            bool flag = repo.insert(telephone.surname, telephone.number);

            if (flag)
            {
                return Ok(telephone);
            }
            else
            {
                return NoContent();
            }
        }


        // PUT api/
        [HttpPut]
        public ActionResult Put(Telephone telephone)
        {
            bool flag = repo.update(telephone.id ,telephone.surname, telephone.number);

            if (flag)
            {
                return Ok(telephone);
            }
            else
            {
                return NoContent();
            }
        }

        // DELETE api/5
        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            bool flag = repo.delete(id);

            if (flag)
            {
                return Ok();
            }
            else
            {
                return NoContent();
            }
        }
    }
}
