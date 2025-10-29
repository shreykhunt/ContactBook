using ContactBook.Models;
using SelectPdf;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ContactBook.Controllers
{
    public class ContactController : Controller
    {

        AppDbContext db = new AppDbContext();
        // GET: Contact
        public ActionResult Index(string searchby, string search)
        {
            if (searchby == "Name")
            {
                var data = db.Contacts.Where(model => model.Name.StartsWith(search)).ToList();
                return View(data);
            }
            else if (searchby == "Address")
            {
                var data = db.Contacts.Where(model => model.Address == search).ToList();
                return View(data);
            }
            else
            {
                var data = db.Contacts.ToList();
                return View(data);
            }
                
        }

        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(Contact Con)
        {
            db.Contacts.Add(Con);
            var a = db.SaveChanges();

            if (a > 0)
            {
                TempData["InsertMessage"] = "Inserted Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.InsertMessage = "<script> alert('Data is not inserted') </script>";
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            var row = db.Contacts.Where(model => model.Id == id).FirstOrDefault();
            return View(row);
        }

        [HttpPost]
        public ActionResult Edit(Contact Con)
        {
            db.Entry(Con).State = EntityState.Modified;
            var a = db.SaveChanges();

            if (a > 0)
            {
                TempData["InsertMessage"] = "Update Successfully";
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.InsertMessage = "<script> alert('Data is not Updated') </script>";
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            var StudentIdRow = db.Contacts.Where(model => model.Id == id).FirstOrDefault();
            return View(StudentIdRow);
        }

        [HttpPost]
        public ActionResult Delete(Contact Con)
        {
            db.Entry(Con).State = EntityState.Deleted;
            var a = db.SaveChanges();
            if (a > 0)
            {
                TempData["DeletedMessage"] = "<script> alert('Row Deleted Successfully !!') </script>";
            }
            else
            {
                TempData["DeletedMessage"] = "<script> alert('Data is not Deleted') </script>";
            }
            return RedirectToAction("Index");
        }

        public ActionResult Details (int id)
        {
            var row = db.Contacts.Where(model => model.Id == id).FirstOrDefault();
            return View(row);
        }

        

        public ActionResult ExportToPdf()
        {
            var contacts = db.Contacts.ToList();

            string html = "<h2>Contact List</h2><table border='1' cellpadding='5' cellspacing='0'><tr><th>Name</th><th>Email</th><th>Phone</th><th>Address</th></tr>";
            foreach (var contact in contacts)
            {
                html += $"<tr><td>{contact.Name}</td><td>{contact.Email}</td><td>{contact.PhoneNumber}</td><td>{contact.Address}</td></tr>";
            }
            html += "</table>";

            HtmlToPdf converter = new HtmlToPdf();
            PdfDocument doc = converter.ConvertHtmlString(html);
            byte[] pdf = doc.Save();
            doc.Close();

            return File(pdf, "application/pdf", "ContactList.pdf");
        }
        public ActionResult ExportToCsv()
        {
            var contacts = db.Contacts.ToList();

            var csv = new StringBuilder();
            csv.AppendLine("Name,Email,PhoneNumber,Address");

            foreach (var contact in contacts)
            {
                csv.AppendLine($"{contact.Name},{contact.Email},{contact.PhoneNumber},{contact.Address}");
            }

            byte[] buffer = Encoding.UTF8.GetBytes(csv.ToString());
            return File(buffer, "text/csv", "ContactList.csv");
        }
    }
}