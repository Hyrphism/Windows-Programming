using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Text;
using DataTable = System.Data.DataTable;

namespace WP
{
    public partial class PrintStudentForm : Form
    {
        public PrintStudentForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Value = dateTimePicker1.MinDate;

            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Value = DateTime.Now;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            bool flag = false;
            string query = null;
            string start = dateTimePicker1.Value.ToString();
            string end = dateTimePicker2.Value.ToString();

            if (radioButtonAll.Checked == true)
            {
                flag = true;
                query = "SELECT * FROM Student";
            }
            else if (radioButtonMale.Checked == true)
            {
                query = "SELECT * FROM Student WHERE gender = 'Male'";
            }
            else if (radioButtonFemale.Checked == true)
            {
                query = "SELECT * FROM Student WHERE gender = 'Female'";
            }
            if (radioButtonYes.Checked == true)
            {
                if (flag)
                {
                    query += " WHERE ";
                }
                else
                {
                    query += " AND ";
                }
                query += $" bdate BETWEEN CONVERT(DATETIME,'{start}', 103) AND CONVERT(DATETIME,'{end}', 103)";
            }

            DataTable table = student.GetTable(query);
            this.GetDataGridView(table);
        }

        private void GetDataGridView(DataTable table)
        {
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = table;
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn image = new DataGridViewImageColumn();
            image = (DataGridViewImageColumn)dataGridView1.Columns[7];
            image.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            print.Document = printDoc;
            print.AllowSelection = true;
            print.AllowSomePages = true;
            if (print.ShowDialog() == DialogResult.OK) printDoc.Print();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx|Excel files(.xlsx)|*.xlsx |CSV (*.csv)|*.csv";
            savefile.InitialDirectory = @"D:\";

            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                if (savefile.FileName.EndsWith("docx") == true)
                {
                    ToWord(dataGridView1, savefile.FileName);
                    MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (savefile.FileName.EndsWith("xlsx") == true)
                {
                    ToExcel(dataGridView1, savefile.FileName);
                    MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (savefile.FileName.EndsWith("csv") == true)
                {
                    ToCSV(savefile.FileName);
                    MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        public void ToWord(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int rowCount = DGV.Rows.Count;
                int columnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[rowCount + 1, columnCount + 1];

                int r = 0;
                for (int c = 0; c <= columnCount - 1; c++)
                {
                    for (r = 0; r <= rowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    }
                }

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;

                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= rowCount - 1; r++)
                {
                    for (int c = 0; c <= columnCount - 1; c++)
                    {
                        oTemp += DataArray[r, c] + "\t";
                    }
                }
                oRange.Text = oTemp;
                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref rowCount, ref columnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);
                oRange.Select();
                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                for (int c = 0; c <= columnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }

                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range headerRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "Student List";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                for (r = 0; r <= rowCount - 1; r++)
                {
                    byte[] imgbyte = (byte[])DGV.Rows[r].Cells[7].Value;
                    MemoryStream ms = new MemoryStream(imgbyte);
                    Image finalePic = (Image)(new Bitmap(Image.FromStream(ms), new Size(70, 70)));
                    Clipboard.SetDataObject(finalePic);
                    oDoc.Application.Selection.Tables[1].Cell(r + 2, 8).Range.Paste();
                    oDoc.Application.Selection.Tables[1].Cell(r + 2, 8).Range.InsertParagraph();
                }

                oDoc.SaveAs(filename);
            }
        }

        public void ToCSV(string filename)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                bool fileError = false;
                if (File.Exists(filename))
                {
                    try
                    {
                        File.Delete(filename);
                    }
                    catch (IOException ex)
                    {
                        fileError = true;
                        MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                    }
                }
                if (!fileError)
                {
                    try
                    {
                        int columnCount = dataGridView1.Columns.Count;
                        string columnNames = "";
                        string[] outputCsv = new string[dataGridView1.Rows.Count + 1];
                        for (int i = 0; i < columnCount; i++)
                        {
                            columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                        }
                        outputCsv[0] += columnNames;

                        for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                        {
                            for (int j = 0; j < columnCount; j++)
                            {
                                outputCsv[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                            }
                        }

                        File.WriteAllLines(filename, outputCsv, Encoding.UTF8);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error :" + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        public bool ToExcel(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                var excelApp = new Excel.Application();
                excelApp.Visible = true;

                excelApp.Workbooks.Add();

                Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;

                workSheet.Cells[1, "A"] = DGV.Columns[0].Name;
                workSheet.Cells[1, "B"] = DGV.Columns[1].Name;
                workSheet.Cells[1, "C"] = DGV.Columns[2].Name;
                workSheet.Cells[1, "D"] = DGV.Columns[3].Name;
                workSheet.Cells[1, "E"] = DGV.Columns[4].Name;
                workSheet.Cells[1, "F"] = DGV.Columns[5].Name;
                workSheet.Cells[1, "G"] = DGV.Columns[6].Name;
                workSheet.Cells[1, "H"] = DGV.Columns[7].Name;

                for (int i = 0; i < DGV.Rows.Count; i++)
                {
                    workSheet.Cells[i + 2, "A"] = DGV.Rows[i].Cells[0].Value;
                    workSheet.Cells[i + 2, "B"] = DGV.Rows[i].Cells[1].Value;
                    workSheet.Cells[i + 2, "C"] = DGV.Rows[i].Cells[2].Value;
                    workSheet.Cells[i + 2, "D"] = DGV.Rows[i].Cells[3].Value;
                    workSheet.Cells[i + 2, "E"] = DGV.Rows[i].Cells[4].Value;
                    workSheet.Cells[i + 2, "F"] = DGV.Rows[i].Cells[5].Value;
                    workSheet.Cells[i + 2, "G"] = DGV.Rows[i].Cells[6].Value;
                }
                workSheet.Columns[1].AutoFit();
                workSheet.Columns[2].AutoFit();
                workSheet.Columns[3].AutoFit();
                workSheet.Columns[4].AutoFit();
                workSheet.Columns[5].AutoFit();
                workSheet.Columns[6].AutoFit();
                workSheet.Columns[7].AutoFit();

                workSheet.SaveAs(filename);

                excelApp.Quit();

                return true;
            }
            return false;
        }
    }
}
