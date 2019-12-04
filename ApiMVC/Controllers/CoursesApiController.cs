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
using System.Web.Http.Results;
using Business.Interface;
using DAL;
using DTO;
using Entities;

namespace ApiMVC.Controllers
{
    [AllowAnonymous]
    public class CoursesApiController : ApiController
    {
        private readonly ICourseBusiness _course;
        public CoursesApiController(ICourseBusiness course)
        {
            _course = course;
        }
        // GET: api/CoursesApi
        /// <summary>
        /// Get All Courses with paging
        /// </summary>
        /// <remark>
        /// Default paging with pageindex =1 and pagesize = 20
        /// </remark>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [ResponseType(typeof(CourseDTO))]
        public HttpResponseMessage GetCourses(int pageIndex =1, int pageSize = 20)
        {
            return Request.CreateResponse(_course.GetAll(pageIndex,pageSize));
        }
    }
        // GET: api/CoursesApi/5
    //    [ResponseType(typeof(Course))]
    //    public IHttpActionResult GetCourse(int id)
    //    {
    //        Course course = db.Courses.Find(id);
    //        if (course == null)
    //        {
    //            return NotFound();
    //        }

    //        return Ok(course);
    //    }

    //    // PUT: api/CoursesApi/5
    //    [ResponseType(typeof(void))]
    //    public IHttpActionResult PutCourse(int id, Course course)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        if (id != course.Id)
    //        {
    //            return BadRequest();
    //        }

    //        db.Entry(course).State = EntityState.Modified;

    //        try
    //        {
    //            db.SaveChanges();
    //        }
    //        catch (DbUpdateConcurrencyException)
    //        {
    //            if (!CourseExists(id))
    //            {
    //                return NotFound();
    //            }
    //            else
    //            {
    //                throw;
    //            }
    //        }

    //        return StatusCode(HttpStatusCode.NoContent);
    //    }

    //    // POST: api/CoursesApi
    //    [ResponseType(typeof(Course))]
    //    public IHttpActionResult PostCourse(Course course)
    //    {
    //        if (!ModelState.IsValid)
    //        {
    //            return BadRequest(ModelState);
    //        }

    //        db.Courses.Add(course);
    //        db.SaveChanges();

    //        return CreatedAtRoute("DefaultApi", new { id = course.Id }, course);
    //    }

    //    // DELETE: api/CoursesApi/5
    //    [ResponseType(typeof(Course))]
    //    public IHttpActionResult DeleteCourse(int id)
    //    {
    //        Course course = db.Courses.Find(id);
    //        if (course == null)
    //        {
    //            return NotFound();
    //        }

    //        db.Courses.Remove(course);
    //        db.SaveChanges();

    //        return Ok(course);
    //    }

    //    protected override void Dispose(bool disposing)
    //    {
    //        if (disposing)
    //        {
    //            db.Dispose();
    //        }
    //        base.Dispose(disposing);
    //    }

    //    private bool CourseExists(int id)
    //    {
    //        return db.Courses.Count(e => e.Id == id) > 0;
    //    }
    //}
}