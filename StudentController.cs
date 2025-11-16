using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Mvc;
using mvc_pra_25.Models;

namespace mvc_pra_25.Controllers
{
    public class StudentController : Controller
    {
        string conStr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        // ---------------- INDEX (LIST) ----------------
        public ActionResult Index()
        {
            List<Student> list = new List<Student>();

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Students", con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    list.Add(new Student()
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Name = dr["Name"].ToString(),
                        Age = Convert.ToInt32(dr["Age"])
                    });
                }
            }
            return View(list);
        }

        // ---------------- CREATE GET ----------------
        public ActionResult Create()
        {
            return View();
        }

        // ---------------- CREATE POST ----------------
        [HttpPost]
        public ActionResult Create(Student s)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Students (Name, Age) VALUES (@Name, @Age)", con);
                cmd.Parameters.AddWithValue("@Name", s.Name);
                cmd.Parameters.AddWithValue("@Age", s.Age);
                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("Index");
        }

        // ---------------- EDIT GET ----------------
        public ActionResult Edit(int id)
        {
            Student s = new Student();

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Students WHERE Id=@Id", con);
                cmd.Parameters.AddWithValue("@Id", id);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    s.Id = Convert.ToInt32(dr["Id"]);
                    s.Name = dr["Name"].ToString();
                    s.Age = Convert.ToInt32(dr["Age"]);
                }
            }
            return View(s);
        }

        // ---------------- EDIT POST ----------------
        [HttpPost]
        public ActionResult Edit(Student s)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Students SET Name=@Name, Age=@Age WHERE Id=@Id", con);

                cmd.Parameters.AddWithValue("@Name", s.Name);
                cmd.Parameters.AddWithValue("@Age", s.Age);
                cmd.Parameters.AddWithValue("@Id", s.Id);
                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("Index");
        }

        // ---------------- DELETE GET ----------------
        public ActionResult Delete(int id)
        {
            Student s = new Student();

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Students WHERE Id=@Id", con);
                cmd.Parameters.AddWithValue("@Id", id);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    s.Id = Convert.ToInt32(dr["Id"]);
                    s.Name = dr["Name"].ToString();
                    s.Age = Convert.ToInt32(dr["Age"]);
                }
            }
            return View(s);
        }

        // ---------------- DELETE POST ----------------
        [HttpPost]
        public ActionResult Delete(int id, FormCollection f)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Students WHERE Id=@Id", con);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("Index");
        }
    }
}
