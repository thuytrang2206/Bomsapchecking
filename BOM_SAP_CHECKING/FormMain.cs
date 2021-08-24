using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using System.Deployment.Application;
using System.Reflection;
using BOM_SAP_CHECKING.MyClass;

namespace BOM_SAP_CHECKING
{
    public partial class FormMain : Form
    {
        private Timer t = null;
        DataTableCollection tableCollcetion;

        List<List_bom_sap1> listbomsap1 = new List<List_bom_sap1>();
        List<List_bom_sap2> listbomsap2 = new List<List_bom_sap2>();
        List<List_result> list_result = new List<List_result>();
        List<List_bom_sap1> listbomsap1_null = new List<List_bom_sap1>();
        List<List_bom_sap2> listbomsap2_null = new List<List_bom_sap2>();
        List<List_result> list_result_null = new List<List_result>();
        private void StartTimer()
        {
            t = new Timer();
            t.Interval = 100;
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;
        }
        void t_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString();
        }
        public FormMain()
        {
            InitializeComponent();
        }
        public static string GetRunningVersion()
        {
            try
            {
                return ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            }
            catch
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public void reload()
        {
            try
            {
                if (Properties.Settings.Default.PathfileA != "" && Properties.Settings.Default.PathfileB != "")
                {
                    if (!Directory.Exists(Properties.Settings.Default.PathfileA))
                    {
                        using (var stream = File.Open(Properties.Settings.Default.PathfileA, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        {
                            timer1.Enabled = true;
                            label4.Visible = true;
                            label4.Text = Properties.Settings.Default.PathfileA.Split('\\').LastOrDefault();
                            label4.ForeColor = Color.Red;
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                });
                                tableCollcetion = result.Tables;
                                cbobom2.Items.Clear();
                                foreach (DataTable table in tableCollcetion)
                                {
                                    cbobom2.Items.Add(table.TableName);
                                    cbobom2.SelectedIndex = 0;
                                }
                            }
                        }
                    }
                    //
                    if (!Directory.Exists(Properties.Settings.Default.PathfileB))
                    {
                        using (var stream = File.Open(Properties.Settings.Default.PathfileB, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        {
                            Properties.Settings.Default.PathfileB = Properties.Settings.Default.PathfileB;
                            Properties.Settings.Default.Save();
                            label5.Visible = true;
                            label5.Text = Properties.Settings.Default.PathfileB.Split('\\').LastOrDefault();
                            label5.ForeColor = Color.Red;
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                });
                                tableCollcetion = result.Tables;
                                cbobom1.Items.Clear();
                                foreach (DataTable table in tableCollcetion)
                                {
                                    cbobom1.Items.Add(table.TableName);
                                    if (cbobom1.Items.Count > 4)
                                    {
                                        cbobom1.SelectedIndex = 4;
                                    }
                                    else
                                    {
                                        cbobom1.SelectedIndex = 0;
                                    }
                                }
                            }
                        }
                    }
                }
                cbobom2.Text = Properties.Settings.Default.BOM2;
                cbobom1.Text = Properties.Settings.Default.BOM1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbobom1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollcetion[cbobom1.SelectedItem.ToString()];
            dtgvbom1.DataSource = dt;
        }

        private void cbobom2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollcetion[cbobom2.SelectedItem.ToString()];
            dtgvbom2.DataSource = dt;
        }

        private void btnbomsap1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openfiledialog = new OpenFileDialog() { Filter = "All files (*.*)|*.*" })
                {
                    if (openfiledialog.ShowDialog() == DialogResult.OK)
                    {
                        timer1.Enabled = true;
                        using (var stream = File.Open(openfiledialog.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        {
                            Properties.Settings.Default.PathfileB = openfiledialog.FileName;
                            Properties.Settings.Default.Save();
                            label4.Visible = true;
                            label4.Text = openfiledialog.FileName.Split('\\').LastOrDefault();
                            label4.ForeColor = Color.Red;
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                });
                                tableCollcetion = result.Tables;
                                cbobom1.Items.Clear();
                                foreach (DataTable table in tableCollcetion)
                                {
                                    cbobom1.Items.Add(table.TableName);
                                    if (cbobom1.Items.Count > 4)
                                    {
                                        cbobom1.SelectedIndex = 4;
                                    }
                                    else
                                    {
                                        cbobom1.SelectedIndex = 0;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnbomsap2_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openfiledialog = new OpenFileDialog() { Filter = "All files (*.*)|*.*" })/*Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx*/
                {
                    if (openfiledialog.ShowDialog() == DialogResult.OK)
                    {
                        using (var stream = File.Open(openfiledialog.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        {
                            Properties.Settings.Default.PathfileA = openfiledialog.FileName;
                            Properties.Settings.Default.Save();
                            timer1.Enabled = true;
                            label5.Visible = true;
                            label5.Text = openfiledialog.FileName.Split('\\').LastOrDefault();
                            label5.ForeColor = Color.Red;
                            using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                            {
                                DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                                {
                                    ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                                });
                                tableCollcetion = result.Tables;
                                cbobom2.Items.Clear();
                                foreach (DataTable table in tableCollcetion)
                                {
                                    cbobom2.Items.Add(table.TableName);
                                    cbobom2.SelectedIndex = 0;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cbobom2.Items.Count == 0 || cbobom1.Items.Count == 0)
                {
                    MessageBox.Show("Please select file before pressing start", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                listbomsap1.Clear();
                listbomsap2.Clear();
                list_result.Clear();
                var result_bom1 = dtgvbom1.Rows.OfType<DataGridViewRow>().Select(r => r.Cells.OfType<DataGridViewCell>().Select(c => c.Value).ToArray()).ToList();
                foreach (var itembom1 in result_bom1)
                {
                    var data_bom1 = new List_bom_sap1()
                    {
                        Material_Number = itembom1[0].ToString(),
                        Assemble_Materialnumber = itembom1[4].ToString(),
                        Bom_Component = itembom1[7].ToString(),
                        AI_Group = itembom1[9].ToString(),
                        AI_Rankingorder = itembom1[10].ToString(),
                        AI_strategy = itembom1[11].ToString(),
                        Usage_probability = itembom1[12].ToString(),
                        Dis_indicator = itembom1[13].ToString(),
                        Dis_group = itembom1[14].ToString(),
                        Follow_up = itembom1[15].ToString(),
                        Qty = itembom1[23].ToString(),
                        Location = itembom1[25].ToString(),
                        Installation_position = itembom1[42].ToString()
                    };
                    listbomsap1.Add(data_bom1);
                }
                var result_bom2 = dtgvbom2.Rows.OfType<DataGridViewRow>().Select(r => r.Cells.OfType<DataGridViewCell>().Select(c => c.Value).ToArray()).ToList();
                foreach (var itembom2 in result_bom2)
                {
                    var data_bom2 = new List_bom_sap2()
                    {
                        Material_Number = itembom2[0].ToString(),
                        Assemble_Materialnumber = itembom2[4].ToString(),
                        Bom_Component = itembom2[7].ToString(),
                        AI_Group = itembom2[9].ToString(),
                        AI_Rankingorder = itembom2[10].ToString(),
                        AI_strategy = itembom2[11].ToString(),
                        Usage_probability = itembom2[12].ToString(),
                        Dis_indicator = itembom2[13].ToString(),
                        Dis_group = itembom2[14].ToString(),
                        Follow_up = itembom2[15].ToString(),
                        Qty = itembom2[23].ToString(),
                        Location = itembom2[25].ToString(),
                        Installation_position = itembom2[42].ToString()
                    };
                    listbomsap2.Add(data_bom2);
                }
                foreach (var itemlistbom1 in listbomsap1)
                {
                    foreach (var itemlistbom2 in listbomsap2)
                    {
                        var result_check_material = itemlistbom1.Material_Number.SequenceEqual(itemlistbom2.Material_Number);
                        var result_check_assemble = itemlistbom1.Assemble_Materialnumber.SequenceEqual(itemlistbom2.Assemble_Materialnumber);
                        var result_check_bom = itemlistbom1.Bom_Component.SequenceEqual(itemlistbom2.Bom_Component);
                        var result_check_aigroup = itemlistbom1.AI_Group.SequenceEqual(itemlistbom2.AI_Group);
                        var result_check_aistraegy = itemlistbom1.AI_strategy.SequenceEqual(itemlistbom2.AI_strategy);
                        var result_check_airanking = itemlistbom1.AI_Rankingorder.SequenceEqual(itemlistbom2.AI_Rankingorder);
                        var result_check_usage = itemlistbom1.Usage_probability.SequenceEqual(itemlistbom2.Usage_probability);
                        var result_check_disindicator = itemlistbom1.Dis_indicator.SequenceEqual(itemlistbom2.Dis_indicator);
                        var result_check_disigroup = itemlistbom1.Dis_group.SequenceEqual(itemlistbom2.Dis_group);
                        var result_check_followup = itemlistbom1.Follow_up.SequenceEqual(itemlistbom2.Follow_up);
                        var result_check_qty = itemlistbom1.Qty.SequenceEqual(itemlistbom2.Qty);
                        var result_check_Loaction = itemlistbom1.Location.SequenceEqual(itemlistbom2.Location);
                        string[] arr_itembom1installation = (itemlistbom1.Installation_position).Split(',');
                        string[] arr_itembom2installation = (itemlistbom2.Installation_position).Split(',');
                        string[] result_dist = arr_itembom2installation.Except(arr_itembom1installation).ToArray();
                        string result;
                        // var result_check_position = itemlistbom1.Installation_position.SequenceEqual(itemlistbom2.Installation_position);
                        if (result_dist == null)
                        {
                             result = "True";
                        }
                        else
                        {
                            result = "False";
                        }

                        var add_item = new List_result()
                        {
                            Material_Number = result_check_material.ToString(),
                            Assemble_Materialnumber = result_check_assemble.ToString(),
                            Bom_Component = result_check_bom.ToString(),
                            AI_Group = result_check_aigroup.ToString(),
                            AI_Rankingorder = result_check_aistraegy.ToString(),
                            AI_strategy = result_check_airanking.ToString(),
                            Usage_probability = result_check_usage.ToString(),
                            Dis_indicator = result_check_disindicator.ToString(),
                            Dis_group = result_check_disigroup.ToString(),
                            Follow_up = result_check_followup.ToString(),
                            Qty = result_check_qty.ToString(),
                            Location = result_check_Loaction.ToString(),
                            Installation_position = result
                        };
                        list_result.Add(add_item);

                    }
                }
                if (list_result.Count > 0)
                {
                    label6.Visible = true;
                    label6.Text = "";
                    dtgvresult.Size = new Size(1310, 283);
                    dtgvresult.DataSource = list_result;
                    groupBox1.Visible = false;
                    lbl_restart.Visible = true;     
                }
                else
                {
                    label6.Visible = true;
                    label6.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblexport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Application.Workbooks.Add(Type.Missing);
            for (int i = 1; i < dtgvresult.Columns.Count + 1; i++)
            {
                app.Cells[1, i] = dtgvresult.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dtgvresult.Rows.Count; i++)
            {
                for (int j = 0; j < dtgvresult.Columns.Count; j++)
                {
                    app.Cells[i + 2, j + 1] = dtgvresult.Rows[i].Cells[j].Value.ToString();
                }
            }

            app.Columns.AutoFit();
            app.Visible = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            cbobom1.Text = Properties.Settings.Default.BOM1;
            cbobom2.Text = Properties.Settings.Default.BOM2;
            lblVersion.Text = GetRunningVersion();
            StartTimer();
        }

        public void Restart()
        {
            cbobom1.Items.Clear();
            cbobom2.Items.Clear();
            dtgvbom1.DataSource = null;
            dtgvbom2.DataSource = null;
            dtgvresult.DataSource = null;
            label6.Visible = false;
            list_result = new List<List_result>();
            cbobom1.Text = Properties.Settings.Default.BOM1;
            cbobom2.Text = Properties.Settings.Default.BOM2;
            lbl_restart.Visible = false;
            dtgvresult.Size = new Size(651, 283);
            groupBox1.Visible = true;
            label4.ResetText();
            label5.ResetText();
        }

        private void lbl_restart_Click(object sender, EventArgs e)
        {
            Restart();
        }
    }
}
