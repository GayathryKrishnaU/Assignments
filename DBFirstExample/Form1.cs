using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFirstExample
{
    public partial class Form1 : Form
    {
        TRainingdbEntities db = new TRainingdbEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            //form data
            //retrieve data from textbox
            string name = txtname.Text;
            //combobox
            string gender = cbgender.SelectedItem.ToString();
            //radio button
            string membership = "";
            if (rbfree.Checked)
                membership = rbfree.Text;
            if (rbpaid.Checked)
                membership = rbpaid.Text;
            //checklistbox
            string shopping = "";
            foreach (var d in clbshop.CheckedItems)
            {
                shopping += d + ",";
            }
            //checkbox
            string cod = "";
            if (cbcod.Checked)
                cod = "yes";

            else
                cod = "no";
            string pass = txtpassword.Text;
            MessageBox.Show(name + "\n" + gender + "\n" + membership + "\n" + shopping + "\n" + cod + "\n" + pass);
            //insert data to db through entity framework

            RegisterShopping rs = new RegisterShopping();
            rs.Name = name;
            rs.Gender = gender;
            rs.Membership = membership;
            rs.ShoppingPreference = shopping;
            rs.COD = cod;
            rs.Password = pass;
            db.RegisterShoppings.Add(rs);
            var res=db.SaveChanges();
            if (res > 0)
                MessageBox.Show("Data inserted");
            this.registerShoppingTableAdapter.Fill(this.tRainingdbDataSet.RegisterShopping);

        }

        private void btnselect_Click(object sender, EventArgs e)
        {
            foreach(var t in db.RegisterShoppings)
            {
                lbselect.Items.Add(t.Id);
                lbselect.Items.Add(t.Name);
                lbselect.Items.Add(t.Gender);
                lbselect.Items.Add(t.Membership);
                lbselect.Items.Add(t.ShoppingPreference);
                lbselect.Items.Add(t.COD);
                lbselect.Items.Add(t.Password);
                lbselect.Items.Add("***********");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRainingdbDataSet.RegisterShopping' table. You can move, or remove it, as needed.
            this.registerShoppingTableAdapter.Fill(this.tRainingdbDataSet.RegisterShopping);

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int Id = (int)cbid.SelectedValue;
            var del = (from t in db.RegisterShoppings where t.Id == Id select t).SingleOrDefault();
            db.RegisterShoppings.Remove(del);
            var res = db.SaveChanges();
            if (res > 0)
                MessageBox.Show("Data Deleted");
            this.registerShoppingTableAdapter.Fill(this.tRainingdbDataSet.RegisterShopping);

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string cod = "";
            if (cbcod.Checked)
                cod = "yes";

            else
                cod = "no";
            string membership = "";
            if (rbfree.Checked)
                membership = rbfree.Text;
            if (rbpaid.Checked)
                membership = rbpaid.Text;
            //checklistbox
            string shopping = "";
            foreach (var d in clbshop.CheckedItems)
            {
                shopping += d + ",";
            }
            string pass = txtpassword.Text;
            int Id = (int)cbid.SelectedValue;
            var olddata = db.RegisterShoppings.Where(x => x.Id == Id).SingleOrDefault();
            olddata.Membership = membership;
            olddata.ShoppingPreference = shopping;
            olddata.COD = cod;
            olddata.Password = pass;
            olddata.Id = Id;
            var res = db.SaveChanges();
            if (res > 0)
                MessageBox.Show("Data updated");
        }

        private void btnsp_Click(object sender, EventArgs e)
        {
            int id = (int)cbid.SelectedValue;
            lbselect.Items.Clear();
           var res= db.sp_SelectRegisterShopping(id);
            foreach (var r in res)
            {
                lbselect.Items.Add(r.Id);
                lbselect.Items.Add(r.Name);
                lbselect.Items.Add(r.Gender);
                lbselect.Items.Add(r.ShoppingPreference);
                lbselect.Items.Add(r.Membership);
                lbselect.Items.Add(r.COD);
                lbselect.Items.Add(r.Password);
            }


        }
    }
}
