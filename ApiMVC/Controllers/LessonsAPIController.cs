using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Business.Interface;
using DAL;
using DTO;
using Entities;

namespace ApiMVC.Controllers
{
    [AllowAnonymous]
    public class LessonsAPIController : ApiController
    {
        private readonly ILessonBusiness _lesson;
        public LessonsAPIController(ILessonBusiness lesson)
        {
            _lesson = lesson;
        }

        [ResponseType(typeof(LessonDTO))]
        public HttpResponseMessage GetLessons(int pageIndex = 1, int pageSize = 20)
        {
            return Request.CreateResponse(_lesson.GetAll( pageIndex, pageSize));
        }

        [ResponseType(typeof(LessonComponent))]
        public HttpResponseMessage GetLesson(int id)
        {
            return Request.CreateResponse(_lesson.GetById(id));
        }
        //// GET: api/Lessons1
        //public IQueryable<Lesson> GetLessons()
        //{
        //    return db.Lessons;
        //}

        //// GET: api/Lessons1/5
        //[ResponseType(typeof(Lesson))]
        //public IHttpActionResult GetLesson(int id)
        //{
        //    Lesson lesson = db.Lessons.Find(id);
        //    if (lesson == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(lesson);
        //}

        //// PUT: api/Lessons1/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutLesson(int id, Lesson lesson)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != lesson.Id)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(lesson).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!LessonExists(id))
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

        //// POST: api/Lessons1
        //[ResponseType(typeof(Lesson))]
        //public IHttpActionResult PostLesson(Lesson lesson)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Lessons.Add(lesson);
        //    db.SaveChanges();

        //    return CreatedAtRoute("DefaultApi", new { id = lesson.Id }, lesson);
        //}

        //// DELETE: api/Lessons1/5
        //[ResponseType(typeof(Lesson))]
        //public IHttpActionResult DeleteLesson(int id)
        //{
        //    Lesson lesson = db.Lessons.Find(id);
        //    if (lesson == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Lessons.Remove(lesson);
        //    db.SaveChanges();

        //    return Ok(lesson);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool LessonExists(int id)
        //{
        //    return db.Lessons.Count(e => e.Id == id) > 0;
        //}
    }
}