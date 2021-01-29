using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ETradeApp.Business.Abstract;
using ETradeApp.Business.Concrete;
using ETradeApp.Business.DependencyResolvers.Ninject;
using ETradeApp.DataAccess.Concrete.EntityFramework;
using ETradeApp.Entities.Concrete;

namespace ETradeApp.WinFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private IProductService _productService;
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbx_category.DataSource = _categoryService.ListCategories();
            cbx_category.DisplayMember = "Name";
            cbx_category.ValueMember = "Id";
        }

        private void LoadProducts()
        {
            dgw_product.DataSource = _productService.ListProducts();
        }

        private void cbx_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgw_product.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbx_category.SelectedValue));
            }
            catch
            {
            }

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            dgw_product.DataSource = String.IsNullOrEmpty(txt_name.Text) ? _productService.ListProducts() : _productService.GetProductsByName(txt_name.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _productService.Add(new Product
            {
                Name = txt_name_ad.Text
            });
            LoadProducts();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                Id = Convert.ToInt32(dgw_product.CurrentRow.Cells[0].Value),
                Name = txt_up.Text
            });
            LoadProducts();
        }

        private void dgw_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_up.Text = dgw_product.CurrentRow.Cells[2].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _productService.Delete(new Product
            {
                Id = Convert.ToInt32(dgw_product.CurrentRow.Cells[0].Value)
            });
            LoadProducts();
        }
    }
}