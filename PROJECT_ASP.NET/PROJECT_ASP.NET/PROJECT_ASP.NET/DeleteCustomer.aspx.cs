﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PROJECT_ASP.NET
{
    public partial class DeleteCustomer : System.Web.UI.Page
    {
        string kode;
        protected void Page_Load(object sender, EventArgs e)
        {
            kode = Request.QueryString["id"];
            Label1.Text = "Apakah Anda Yakin Ingin Menghapus Data Customer Dengan Kode " + kode;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Models.Customers delete = new Models.Customers();
            delete.Id_Customer = kode;
            string flag = delete.Delete();
            if (flag == "OK")
            {
                response.Text = GlobalVariable.getSuccess("Data Berhasil Dihapus");
                Label1.Text = "";
                Button1.Visible = false;
                Button2.Text = "Kembali";
            }
            else
            {
                response.Text = GlobalVariable.getFail("Data Gagal Dihapus");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Customer.aspx");
        }
    }
}