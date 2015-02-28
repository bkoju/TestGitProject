using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;

            DisplayData(); 
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var db = new AppContext())
            {
                var presentation = new Presentation
                {
                    Date = DateTime.Now,
                    Presenter = "Cayden B",
                    Description = "Aliens have landed on the earth"
                };
                db.Presentations.Add(presentation);
                db.SaveChanges();
            }

            DisplayData();
        }

        private void DisplayData()
        {
            dataGridViewPresentations.DataSource = GetAllPresentations();
        }

        private List<Presentation> GetAllPresentations()
        {
            using (var db = new AppContext())
            {
                return db.Presentations.ToList();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (var db = new AppContext())
            {

            }
        }
    }
}
