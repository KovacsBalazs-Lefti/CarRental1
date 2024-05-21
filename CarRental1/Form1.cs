using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental1
{
    public partial class Form1 : Form
    {
        private CarService carService;
        public Form1()
        {
            InitializeComponent();
            Cargrid.AutoGenerateColumns = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                carService = new CarService();
                //frissíti a datagridet az aktuális adatokkal
                RefreshCarsGrid();

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message, "Hiba történt az adatbázis kapcsolat kialakításakor");
                this.Close();

            }
        }

        private void RefreshCarsGrid()
        {
            Cargrid.DataSource = carService.GetCars();
            //törlése az auto selectnek
            Cargrid.ClearSelection();

        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (Cargrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("A törléshez válasszon ki egy autót!");
                return;
            }
            DialogResult result = MessageBox.Show("Biztos szeretné törölni a kiválasztott autót?", "Biztos", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }
            try
            {
                Car selected = Cargrid.SelectedRows[0].DataBoundItem as Car;
                if (carService.DeleteCar(selected.Id))
                {
                    MessageBox.Show("Sikeres törlés");
                }
                else
                {
                    MessageBox.Show("Ez az autó már korábban törlésre került", "Hiba történt a törlés során");
                }
                RefreshCarsGrid();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Hiba történt a törlés során");

            }

        }
    }
}
