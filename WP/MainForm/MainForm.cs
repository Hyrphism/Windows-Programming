﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP.Course_Form;
using WP.ResultForm;

namespace WP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void ADDNEWSTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStdF = new AddStudentForm();
            addStdF.ShowDialog();
        }

        private void STUDENTLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentListForm stdListF = new StudentListForm();
            stdListF.ShowDialog();
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm updateDeleteStdF = new UpdateDeleteStudentForm();
            updateDeleteStdF.ShowDialog();
        }

        private void STATICToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticsForm staticsForm = new StaticsForm();
            staticsForm.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintStudentForm printForm = new PrintStudentForm();
            printForm.ShowDialog();
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourseForm = new AddCourseForm();
            addCourseForm.ShowDialog();
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourseForm removeCourse = new RemoveCourseForm();
            removeCourse.ShowDialog();
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourseForm editCourseForm = new EditCourseForm();
            editCourseForm.ShowDialog();
        }

        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCourseForm manageCourseForm = new ManageCourseForm();
            manageCourseForm.ShowDialog();
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintCourseForm printCourseForm = new PrintCourseForm();
            printCourseForm.ShowDialog();
        }

        private void aDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScoreForm addScoreForm = new AddScoreForm();
            addScoreForm.ShowDialog();
        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveScoreForm removeScoreForm = new RemoveScoreForm();
            removeScoreForm.ShowDialog();
        }

        private void averageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AverageScore averageScore = new AverageScore();
            averageScore.ShowDialog();
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScoreForm manageScoreForm = new ManageScoreForm();
            manageScoreForm.ShowDialog();
        }

        private void aVGResultByScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvgResultByScoreForm avgResultByScoreForm = new AvgResultByScoreForm();
            avgResultByScoreForm.ShowDialog();
        }

        private void staticsResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticsResultForm staticsResultForm = new StaticsResultForm();
            staticsResultForm.ShowDialog();
        }

        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
