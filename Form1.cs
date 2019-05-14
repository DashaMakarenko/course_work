using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int n = 0;
        int i = 0;
        int j = 0;
        int k = 0;
        int q = 0;
        int p = 0;
        int r = 0;
        int s = 0;
        double a = 0;
        int b = 0;
        int c = 0;
        int u = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void matrix1_Click(object sender, EventArgs e)
        {
           /* this.add_row1.Show();
            this.add_col1.Show();
            this.del_row1.Show();
            this.del_col1.Show();*/
            if (txt_row1.Text != "" & txt_col1.Text != "")
            {
                dataGridView1.RowCount = (Convert.ToInt16(txt_row1.Text));
                q = dataGridView1.RowCount;
                dataGridView1.AllowUserToResizeColumns = true;
                dataGridView1.AutoResizeRows();
                dataGridView1.ColumnCount = Convert.ToInt16(txt_col1.Text);
                p = dataGridView1.ColumnCount;
                dataGridView1.AutoResizeColumns();
            }
        }

        private void add_row1_Click(object sender, EventArgs e)
        {
            n = dataGridView1.Rows.Add();
            txt_row1.Text = Convert.ToString(q + 1);
            q += 1;
        }

        private void add_col1_Click(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            i = dataGridView1.Columns.Add(col);
            dataGridView1.AutoResizeColumns();
            txt_col1.Text = Convert.ToString(p + 1);
            p += 1;
        }

        private void del_row1_Click(object sender, EventArgs e)
        {
            n = dataGridView1.RowCount;
            if (n > 1)
            {
                dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
                n -= 1;
            }
        }

        private void del_col1_Click(object sender, EventArgs e)
        {
            u = dataGridView1.ColumnCount;
            if (u > 1)
            {
                dataGridView1.Columns.Remove(dataGridView1.Columns[0]);
                u -= 1;
                dataGridView1.ColumnCount = u;
                txt_col1.Text = Convert.ToString(u);
                u = 1;
            }
        }

        private void matrix2_Click(object sender, EventArgs e)
        {
            if (txt_row2.Text != "" & txt_col2.Text != "")
            {
                dataGridView2.RowCount = (Convert.ToInt16(txt_row2.Text));
                r = dataGridView2.RowCount;
                dataGridView2.AutoResizeRows();
                dataGridView2.ColumnCount = Convert.ToInt16(txt_col2.Text);
                s = dataGridView2.ColumnCount;
                dataGridView2.AutoResizeColumns();
            }
        }

        private void add_row2_Click(object sender, EventArgs e)
        {
            j = dataGridView2.Rows.Add();
            txt_row2.Text = Convert.ToString(r + 1);
            r += 1;
        }

        private void add_col2_Click(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            k = dataGridView2.Columns.Add(col);
            dataGridView2.AutoResizeColumns();
            txt_col2.Text = Convert.ToString(s + 1);
            s += 1;
        }

        private void del_row2_Click(object sender, EventArgs e)
        {
            j = dataGridView2.RowCount;
            if (j > 1)
            {
                dataGridView2.Rows.Remove(dataGridView2.Rows[0]);
                j -= 1;
                dataGridView2.RowCount = j;
                txt_row2.Text = Convert.ToString(j);
                j -= 1;

            }
        }

        private void del_col2_Click(object sender, EventArgs e)
        {
            k = dataGridView2.ColumnCount;
            if (k > 1)
            {
                dataGridView2.Columns.Remove(dataGridView2.Columns[0]);
                k -= 1;
                dataGridView2.ColumnCount = k;
                txt_col2.Text = Convert.ToString(k);
                k = 1;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txt_col1.Text) == Convert.ToInt16(txt_row2.Text))
            {
                ans_Grid.RowCount = Convert.ToInt16(txt_row1.Text);
                ans_Grid.ColumnCount = Convert.ToInt16(txt_col2.Text);
                ans_Grid.AutoResizeColumns();
                ans_Grid.AutoResizeRows();

                try
                {
                    foreach (DataGridViewRow row in this.dataGridView1.Rows)
                    {
                        int R1 = row.Index;
                        {
                            for (b = 0; b < dataGridView2.ColumnCount; b++)
                            {
                                a = 0;
                                for (c = 0; c < dataGridView2.RowCount; c++)
                                {

                                    decimal D = Convert.ToDecimal(dataGridView1.Rows[R1].Cells[c].Value.ToString());
                                    decimal E = Convert.ToDecimal(dataGridView2.Rows[c].Cells[b].Value.ToString());
                                    decimal A = D * E;
                                    ans_Grid.Rows[R1].Cells[b].Value = decimal.Parse(A.ToString());
                                    ans_Grid.Rows[R1].Cells[b].Value = a + Convert.ToDouble(ans_Grid.Rows[R1].Cells[b].Value);
                                    a = Convert.ToDouble(ans_Grid.Rows[R1].Cells[b].Value);

                                }
                            }
                        }
                    }
                }
                catch (Exception)
                {
                }
                for (int ansco = 1; ansco <= s; ansco++)

                    ans_Grid.Columns[ansco - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            else
            {
                MessageBox.Show("Неправильна розмірність матриць ");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt16(txt_row1.Text) == Convert.ToInt16(txt_row2.Text))
               & ((Convert.ToInt16(txt_col1.Text) == Convert.ToInt16(txt_col2.Text))))
            {
                ans_Grid.RowCount = Convert.ToInt16(txt_row1.Text);
                ans_Grid.ColumnCount = Convert.ToInt16(txt_col1.Text);
                ans_Grid.AutoResizeColumns();
                ans_Grid.AutoResizeRows();
                try
                {
                    foreach (DataGridViewRow row in this.dataGridView1.Rows)
                    {
                        int R1 = row.Index;
                        {
                            for (c = 0; c < dataGridView2.RowCount; c++)
                            {
                                a = 0;
                                for (b = 0; b < dataGridView2.ColumnCount; b++)
                                {
                                    decimal D = Convert.ToDecimal(dataGridView1.Rows[R1].Cells[b].Value.ToString());
                                    decimal E = Convert.ToDecimal(dataGridView2.Rows[R1].Cells[b].Value.ToString());
                                    decimal A = D + E;
                                    ans_Grid.Rows[R1].Cells[b].Value = decimal.Parse(A.ToString());
                                }
                            }
                        }
                    }
                }
                catch (Exception)
                {

                }

                for (int ansco = 1; ansco <= s; ansco++)
                    ans_Grid.Columns[ansco - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            else
            {
                MessageBox.Show("Неправильна розмірність матриць ");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt16(txt_row1.Text) == Convert.ToInt16(txt_row2.Text))
               & ((Convert.ToInt16(txt_col1.Text) == Convert.ToInt16(txt_col2.Text))))
            {
                ans_Grid.RowCount = Convert.ToInt16(txt_row1.Text);
                ans_Grid.ColumnCount = Convert.ToInt16(txt_col1.Text);
                ans_Grid.AutoResizeColumns();
                ans_Grid.AutoResizeRows();
                try
                {
                    foreach (DataGridViewRow row in this.dataGridView1.Rows)
                    {
                        int R1 = row.Index;
                        {
                            for (c = 0; c < dataGridView2.RowCount; c++)
                            {
                                a = 0;
                                for (b = 0; b < dataGridView2.ColumnCount; b++)
                                {
                                    decimal D = Convert.ToDecimal(dataGridView1.Rows[R1].Cells[b].Value.ToString());
                                    decimal E = Convert.ToDecimal(dataGridView2.Rows[R1].Cells[b].Value.ToString());
                                    decimal A = D - E;
                                    ans_Grid.Rows[R1].Cells[b].Value = decimal.Parse(A.ToString());
                                }
                            }
                        }
                    }
                }
                catch (Exception)
                {
                }
                for (int ansco = 1; ansco <= s; ansco++)
                    ans_Grid.Columns[ansco - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            else
            {
                MessageBox.Show("Неправильна розмірність матриць");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView2.Columns.Clear();
            ans_Grid.Columns.Clear();
        }
    }
}
