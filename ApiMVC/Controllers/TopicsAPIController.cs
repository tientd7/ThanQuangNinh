using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Business.Interface;
using DTO;

namespace ApiMVC.Controllers
{
    [AllowAnonymous]
    public class TopicsAPIController : ApiController
    {
        private readonly ITopicBusiness _topic;
        public TopicsAPIController(ITopicBusiness topic)
        {
            _topic = topic;
        }
        // GET: api/TopicsAPI
        [ResponseType(typeof(CourseDTO))]
        public HttpResponseMessage GetTopics(int pageIndex = 1, int pageSize = 20)
        {
            return Request.CreateResponse(_topic.GetAll(pageIndex, pageSize));
        }

        // GET: api/TopicsAPI/5
        [ResponseType(typeof(TopicComponent))]
        public HttpResponseMessage GetTopic(int id)
        {
            return Request.CreateResponse(_topic.GetById(id));
        }

        //// PUT: api/TopicsAPI/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutTopic(int id, Topic topic)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != topic.Id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(topic).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!TopicExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/TopicsAPI
        //[ResponseType(typeof(Topic))]
        //public IHttpActionResult PostTopic(Topic topic)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Topics.Add(topic);
        //    db.SaveChanges();

        //    return CreatedAtRoute("DefaultApi", new { id = topic.Id }, topic);
        //}

        //// DELETE: api/TopicsAPI/5
        //[ResponseType(typeof(Topic))]
        //public IHttpActionResult DeleteTopic(int id)
        //{
        //    Topic topic = db.Topics.Find(id);
        //    if (topic == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Topics.Remove(topic);
        //    db.SaveChanges();

        //    return Ok(topic);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool TopicExists(int id)
        //{
        //    return db.Topics.Count(e => e.Id == id) > 0;
        //}
    }
}