using ProjectBLL.DesignPatterns.GenericRepository.ConcRep;
using ProjectENTITIES.Models;
using ProjectWinFormUI.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWinFormUI
{
    public partial class Form2 : Form
    {

        ProductRepository _proRep;
        CategoryRepository _catRep;
        public Form2()
        {
            InitializeComponent();
            _proRep = new ProductRepository();
            _catRep = new CategoryRepository();
        }

        void ListCategories()
        {
            cmbCategories.DataSource= _catRep.Select(x => new CategoryVM
            {
                ID = x.ID,
                CategoryName = x.CategoryName,
                Description = x.Description
            }).ToList();

            cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.ValueMember = "ID";
        }

        void ListProducts()
        {
            lstProducts.DataSource = _proRep.Select(x => new ProductVM
            {
                ID = x.ID,
                ProductName = x.ProductName,
                UnitPrice = x.UnitPrice,
                CategoryID= x.CategoryID,
                CategoryName = x.Category == null ? "No categories to be shown." : x.Category.CategoryName
            }).ToList();
        }

        ProductVM _selected;
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                p.ProductName = txtCategoryName.Text;
                p.UnitPrice = Convert.ToDecimal(txtPrice.Text);
                if (cmbCategories.SelectedIndex > -1) p.CategoryID = Convert.ToInt32(cmbCategories.SelectedValue);
                _proRep.Add(p);
                ListProducts();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ListCategories();
            ListProducts();
        }

        private void btnListCategories_Click(object sender, EventArgs e)
        {
            ListCategories();
        }

        private void lstProducts_Click(object sender, EventArgs e)
        {
            if(lstProducts.SelectedIndex > -1)
            {
                _selected = (ProductVM)lstProducts.SelectedItem;
                txtCategoryName.Text = _selected.ProductName;
                txtPrice.Text = _selected.UnitPrice.ToString();
                cmbCategories.SelectedValue = _selected.CategoryID != null ? _selected.CategoryID.Value : -1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selected != null)
            {
                Product toBeDeleted = _proRep.Find(_selected.ID);
                _proRep.Delete(toBeDeleted);
                ListProducts();
                _selected = null;
                txtCategoryName.Text = txtPrice.Text = null;
                cmbCategories.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Please choose a product.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_selected != null)
                {
                    Product toBeUptaded = _proRep.Find(_selected.ID);
                    toBeUptaded.ProductName = txtCategoryName.Text;
                    toBeUptaded.UnitPrice=Convert.ToDecimal(txtPrice.Text);
                    if (cmbCategories.SelectedIndex > -1) toBeUptaded.CategoryID = Convert.ToInt32(cmbCategories.SelectedValue);
                    _proRep.Update(toBeUptaded);
                    ListProducts();
                    _selected = null;
                    txtCategoryName.Text = txtPrice.Text = null;    
                    cmbCategories.SelectedIndex = -1;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
