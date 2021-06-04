using MvcFullCRUD.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcFullCRUD.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        db_testEntities dbObj = new db_testEntities();
        public ActionResult Student(tbl_Student obj)
        {
            //if (obj != null)
                return View(obj);
            //else 
            //    return View();
           
        }

        [HttpPost]
        public ActionResult AddStudent(tbl_Student model)
        {
            tbl_Student obj = new tbl_Student();
            if (ModelState.IsValid)
            {
            obj.ID = model.ID;
            obj.Name = model.Name;
            obj.Surname = model.Surname;
            obj.Email = model.Email;
            obj.Mobile = model.Mobile;
            obj.Description = model.Description;
                if (model.ID == 0)
                {
                    dbObj.tbl_Student.Add(obj);
                    dbObj.SaveChanges();
                }
                else
                {
                    dbObj.Entry(obj).State = System.Data.Entity.EntityState.Modified;
                    dbObj.SaveChanges();
                }
            }
            ModelState.Clear();
            return View("Student");
        }

        public ActionResult StudentList()
        {
            var result = dbObj.tbl_Student.ToList();
            return View(result);
        }

        public ActionResult Delete(int id)
        {
            var res = dbObj.tbl_Student.Where(x => x.ID == id).First();
            dbObj.tbl_Student.Remove(res);
            dbObj.SaveChanges();

            var list = dbObj.tbl_Student.ToList();
            return View("StudentList", list);
        }

    }
}