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
    public partial class Form1 : Form
    {
        CategoryRepository _categoryRepository;

        public Form1()
        {
            InitializeComponent();
            _categoryRepository = new CategoryRepository();
        }
        void ListCategories()
        {
            lstCategories.DataSource = _categoryRepository.Select( x => new CategoryVM
            {
                ID = x.ID,
                CategoryName = x.CategoryName,
                Description = x.Description,
                Products = x.Products
            }).ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ListCategories();
        }

        private void lstKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListCategories();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryName.Text.Trim()))
            {
                MessageBox.Show("Please enter a category name");return;
            }

            Category c = new Category
            {
                CategoryName = txtCategoryName.Text,
                Description = txtDescription.Text
            };
            _categoryRepository.Add(c);
            ListCategories();
        }

        CategoryVM _selected;

        private void lstCategories_Click(object sender, EventArgs e)
        {
            if(lstCategories.SelectedIndex > -1)
            {
                _selected = (CategoryVM)lstCategories.SelectedItem;
                txtCategoryName.Text = _selected.CategoryName;
                txtDescription.Text = _selected.Description;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(_selected != null)
            {
                Category toBeDeletedCategory = _categoryRepository.Find(_selected.ID);
                _categoryRepository.Delete(toBeDeletedCategory);
                ListCategories();
                _selected = null;
                txtDescription.Text = txtCategoryName.Text = null;
            }
            else
            {
                MessageBox.Show("Please choose a category.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_selected != null)
            {
                Category toBeUpdated = _categoryRepository.Find(_selected.ID);
                toBeUpdated.CategoryName = txtCategoryName.Text;
                toBeUpdated.Description = txtDescription.Text;
                _categoryRepository.Update(toBeUpdated);
                ListCategories() ;
                _selected = null;
                txtDescription.Text = txtCategoryName.Text = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }
    }
}
