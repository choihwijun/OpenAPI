using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 쇼핑_검색
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        List<Item> list = new List<Item>();
        List<Item> sortedlist = new List<Item>();
        private void btn_search_Click(object sender, EventArgs e)
        {
            lv_shopping.Items.Clear();
            list = ShoppingItem.Search(tbox_query.Text, 1, 100, "sim");

            foreach (Item item in list)
            {
                try
                {
                    if ((int.Parse(tb_minprice.Text) < item.Lprice) && (item.Lprice < int.Parse(tb_maxprice.Text)))
                    {
                        ListViewItem lvi = new ListViewItem(item.Name);
                        lvi.SubItems.Add(item.Lprice.ToString());
                        lv_shopping.Items.Add(lvi);
                        sortedlist.Add(item);
                    }
                }
                catch (Exception ex)
                {
                    ListViewItem lvi = new ListViewItem(item.Name);
                    lvi.SubItems.Add(item.Lprice.ToString());
                    lv_shopping.Items.Add(lvi);
                    sortedlist.Add(item);
                }
            }
        }

        private void lb_url_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TinyBrowser wb = new TinyBrowser(lb_url.Text);
            wb.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sortedlist.Sort((item1, item2) => item1.Lprice.CompareTo(item2.Lprice));
            this.lv_shopping.ListViewItemSorter = new ListviewItemComparer(1, "asc");
            lv_shopping.Sorting = SortOrder.Ascending;
            lv_shopping.Sort();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sortedlist.Sort((item1, item2) => item2.Lprice.CompareTo(item1.Lprice));
            this.lv_shopping.ListViewItemSorter = new ListviewItemComparer(1, "desc");
            lv_shopping.Sorting = SortOrder.Descending;
            lv_shopping.Sort();
        }


        private void lv_shopping_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lv_shopping.SelectedItems.Count > 0)
            {
                int index = lv_shopping.SelectedItems[0].Index;
                if (index == -1) { return; }
                Item item = sortedlist[index];
                lb_name.Text = item.Name;
                lb_url.Text = item.Link;
                lb_brand.Text = item.Brand;
                lb_maker.Text = item.Maker;
                lb_hprice.Text = item.Hprice.ToString();
                lb_lprice.Text = item.Lprice.ToString();
                pbox_image.Load(item.Image);
            }
        }


        public class ListviewItemComparer : IComparer
    {
        private int col;
        public string sort = "asc";
        public ListviewItemComparer()
        {
            col = 0;
        }

        public ListviewItemComparer(int column, string sort)
        {
            col = column;
            this.sort = sort;
        }

        public int Compare(object x, object y)
        {
            int chk = 1;
            try
            {
                if (sort == "asc")  chk = 1;
                else chk = -1;

                if (Convert.ToInt32(((ListViewItem)x).SubItems[col].Text) > Convert.ToInt32(((ListViewItem)y).SubItems[col].Text))
                {
                    return chk;
                }
                else return -chk;
                
            }
            catch (Exception ex)
            {
                if (sort == "asc")
                {
                    return string.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
                    
                }

                else
                    return string.Compare(((ListViewItem)y).SubItems[col].Text, ((ListViewItem)x).SubItems[col].Text);

            }
        }
    }

    //========================정렬
    
    }
}
