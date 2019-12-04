using Business.Interface;
using DAL.Interface;
using DTO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class LessonBusiness : ILessonBusiness
    {
        private readonly IRepository<Lesson> _repository;
        private readonly ICourseBusiness _course;
        public LessonBusiness(IRepository<Lesson> repository, ICourseBusiness course)
        {
            _repository = repository;
            _course = course;
        }
        public LessonDTO GetByCourse(int courseId, int pageIndex = 1, int pageSize = 20)
        {
            LessonDTO rst = new LessonDTO();
            rst.Course = _course.GetById(courseId);
            if (rst.Course == null)
                return null;
            var query = _repository.GetMany(e => e.CourseId==courseId).OrderBy(t => t.Name);

            rst.Pager = new Paging(query.Count(), pageSize, pageIndex);
            rst.Components = (from s in query.Skip((pageIndex - 1) * pageSize).Take(pageSize)

                              select new LessonComponent()
                              {
                                  Id = s.Id,
                                  Name = s.Name,
                                  Description = s.Description,
                                  ImageUrl = s.ImageUrl,
                                  CourseId = s.CourseId,
                                  CourseName = s.Course.Name
                              }).ToList();
            return rst;
        }

        public LessonComponent GetById(int lessonId)
        {
            var lesson = _repository.FirstOrDefault(e => e.Id == lessonId && e.Course.IsEnable);
            if (lesson == null)
                return null;
            else
                return new LessonComponent(lesson, _course.GetById(lesson.CourseId).Name);
            //return new LessonComponent(lesson, lesson.Course.Name);
        }
    }
}
