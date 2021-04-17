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
using WP.Classes;

namespace WP.Course_Form
{
    public partial class PrintCourseForm : Form
    {
        Course course = new Course();

        public PrintCourseForm()
        {
            InitializeComponent();
        }

        private void PrintCourseForm_Load(object sender, EventArgs e)
        {
            dataGridViewCourse.DataSource = course.GetAllCourses();
            dataGridViewCourse.RowTemplate.Height = 70;
            dataGridViewCourse.ReadOnly = true;
            dataGridViewCourse.AllowUserToAddRows = false;

            dataGridViewCourse.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCourse.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCourse.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCourse.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
                    ToWord(dataGridViewCourse, savefile.FileName);
                    MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (savefile.FileName.EndsWith("xlsx") == true)
                {
                    ToExcel(dataGridViewCourse, savefile.FileName);
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

                oDoc.SaveAs(filename);
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

                for (int i = 0; i < DGV.Rows.Count; i++)
                {
                    workSheet.Cells[i + 2, "A"] = DGV.Rows[i].Cells[0].Value;
                    workSheet.Cells[i + 2, "B"] = DGV.Rows[i].Cells[1].Value;
                    workSheet.Cells[i + 2, "C"] = DGV.Rows[i].Cells[2].Value;
                    workSheet.Cells[i + 2, "D"] = DGV.Rows[i].Cells[3].Value;
                }
                workSheet.Columns[1].AutoFit();
                workSheet.Columns[2].AutoFit();
                workSheet.Columns[3].AutoFit();
                workSheet.Columns[4].AutoFit();

                workSheet.SaveAs(filename);

                excelApp.Quit();

                return true;
            }
            return false;
        }
    }
}
