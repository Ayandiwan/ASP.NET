using System;
using System.Linq;
using System.Web.UI;

namespace WebApplication1
{
    public partial class Index : System.Web.UI.Page
    {
        // ✔ Move DB here (INSIDE class)
        DataClasses1DataContext db = new DataClasses1DataContext();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindGrid();
        }

        void BindGrid()
        {
            GridView1.DataSource = db.Student_07s;
            GridView1.DataBind();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            Student_07 s = new Student_07();
            s.Name = txtName.Text;
            s.City = txtCity.Text;

            db.Student_07s.InsertOnSubmit(s);
            db.SubmitChanges();

            BindGrid();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            int id = int.Parse(txtId.Text);
            var s = db.Student_07s.Single(x => x.Id == id);

            s.Name = txtName.Text;
            s.City = txtCity.Text;

            db.SubmitChanges();
            BindGrid();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var s = db.Student_07s.Single(x => x.Id == id);

            db.Student_07s.DeleteOnSubmit(s);
            db.SubmitChanges();
            BindGrid();
        }
    }
}
