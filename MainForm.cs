using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.IO;
using ClosedXML.Excel;

namespace Service_Station_Manager
{
    public partial class MainForm : Form
    {
        ProjectContext db;
        string selectedMenuItem;
        public MainForm()
        {
            InitializeComponent();
            db = new ProjectContext();
            ButtonDisabled();
            ToolTip toolTipInsert = new ToolTip();
            ToolTip toolTipUpdate = new ToolTip();
            ToolTip toolTipDelete = new ToolTip();
            ToolTip toolTipExcel = new ToolTip();

            toolTipInsert.SetToolTip(buttonInsert, "Insert");
            toolTipUpdate.SetToolTip(buttonUpdate, "Update");
            toolTipDelete.SetToolTip(buttonDelete, "Delete");
            toolTipExcel.SetToolTip(buttonExport, "Export to Excel file");

        }
        private void ButtonEnabled()
        {
            buttonInsert.Enabled = true;
            buttonInsert.Visible = true;

            buttonUpdate.Enabled = true;
            buttonUpdate.Visible = true;

            buttonDelete.Enabled = true;
            buttonDelete.Visible = true;
        }
        private void ButtonDisabled()
        {
            buttonInsert.Enabled = false;
            buttonInsert.Visible = false;

            buttonUpdate.Enabled = false;
            buttonUpdate.Visible = false;

            buttonDelete.Enabled = false;
            buttonDelete.Visible = false;
        }


        private void MainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonDisabled();
            var installs = from i in db.Installations
                           join c in db.Cars on i.ID_Car equals c.ID_Car
                           join cl in db.Clients on i.ID_Client equals cl.ID_Client
                           join t in db.TypesOfWorks on i.ID_Work equals t.ID_Work
                           join p in db.Parts on i.ID_Part equals p.ID_Part
                           join em in db.Employees on i.ID_Employee equals em.ID_Employee
                           join g in db.Garages on i.ID_Garage equals g.ID_Garage
                           select new { Car = c.Model, Client = cl.Name + " " + cl.SurName, Service = t.Type, Part = p.Name, Employee = em.Name + " " + em.SurName, Garage = g.ID_Garage };
            dataGridViewMain.DataSource = installs.ToList();
        }
        private void ClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonEnabled();
            selectedMenuItem = "CLIENT";
            dataGridViewMain.DataSource = db.Clients.ToList();
        }
        private void InstallationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonEnabled();
            dataGridViewMain.DataSource = db.Installations.ToList();
            selectedMenuItem = "INSTALLATION";
        }
        private void CarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonEnabled();
            dataGridViewMain.DataSource = db.Cars.ToList();
            selectedMenuItem = "CAR";
        }
        private void EmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonEnabled();
            dataGridViewMain.DataSource = db.Employees.ToList();
            selectedMenuItem = "EMPLOYEE";
        }
        private void ServiceTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonEnabled();
            dataGridViewMain.DataSource = db.TypesOfWorks.ToList();
            selectedMenuItem = "TYPE";
        }
        private void GaragesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonEnabled();
            dataGridViewMain.DataSource = db.Garages.ToList();
            selectedMenuItem = "GARAGE";
        }
        private void PartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonEnabled();
            dataGridViewMain.DataSource = db.Parts.ToList();
            selectedMenuItem = "PART";
        }


        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            DialogResult result;
            try
            {
                switch (selectedMenuItem)
                {
                    case "CAR":
                        CarForm insertCarForm = new CarForm();
                        result = insertCarForm.ShowDialog(this);
                        if (result == DialogResult.Cancel)
                            return;
                        Car car = new Car();
                        car.Model = insertCarForm.textBoxModel.Text;
                        car.RegisterSign = insertCarForm.textBoxRegSign.Text;
                        car.Year = Convert.ToInt32(insertCarForm.textBoxYear.Text);
                        car.Color = insertCarForm.textBoxColor.Text;
                        db.Cars.Add(car);
                        db.SaveChanges();
                        dataGridViewMain.DataSource = db.Cars.ToList();
                        insertCarForm.Close();
                        break;

                    case "CLIENT":
                        ClientForm insertClientForm = new ClientForm();
                        result = insertClientForm.ShowDialog(this);
                        if (result == DialogResult.Cancel)
                            return;
                        Client client = new Client();
                        client.SurName = insertClientForm.textBoxSurname.Text;
                        client.Name = insertClientForm.textBoxName.Text;
                        client.Passport = insertClientForm.textBoxPassport.Text;
                        client.Telephone = Convert.ToInt32(insertClientForm.textBoxTelephone.Text);
                        db.Clients.Add(client);
                        db.SaveChanges();
                        dataGridViewMain.DataSource = db.Clients.ToList();
                        insertClientForm.Close();
                        break;

                    case "EMPLOYEE":
                        EmployeeForm insertEmployeeForm = new EmployeeForm();
                        result = insertEmployeeForm.ShowDialog(this);
                        if (result == DialogResult.Cancel)
                            return;
                        Employee employee = new Employee();
                        employee.SurName = insertEmployeeForm.textBoxSurname.Text;
                        employee.Name = insertEmployeeForm.textBoxName.Text;
                        employee.Passport = insertEmployeeForm.textBoxPassport.Text;
                        employee.Telephone = Convert.ToInt32(insertEmployeeForm.textBoxTelephone.Text);
                        db.Employees.Add(employee);
                        db.SaveChanges();
                        dataGridViewMain.DataSource = db.Employees.ToList();
                        insertEmployeeForm.Close();
                        break;

                    case "INSTALLATION":
                        InstallationForm insertInstallationForm = new InstallationForm();
                        result = insertInstallationForm.ShowDialog(this);
                        if (result == DialogResult.Cancel)
                            return;
                        Installation installation = new Installation();
                        installation.ID_Client = Convert.ToInt32(insertInstallationForm.textBoxClient.Text);
                        installation.ID_Car = Convert.ToInt32(insertInstallationForm.textBoxCar.Text);
                        installation.ID_Work = Convert.ToInt32(insertInstallationForm.textBoxType.Text);
                        installation.ID_Part = Convert.ToInt32(insertInstallationForm.textBoxPart.Text);
                        installation.ID_Employee = Convert.ToInt32(insertInstallationForm.textBoxEmployee.Text);
                        installation.ID_Garage = Convert.ToInt32(insertInstallationForm.textBoxGarage.Text);
                        db.Installations.Add(installation);
                        db.SaveChanges();
                        dataGridViewMain.DataSource = db.Installations.ToList();
                        insertInstallationForm.Close();
                        break;
                    case "PART":
                        PartForm insertPartForm = new PartForm();
                        result = insertPartForm.ShowDialog(this);
                        if (result == DialogResult.Cancel)
                            return;
                        Part part = new Part();
                        part.Name = insertPartForm.textBoxName.Text;
                        part.Cost = Convert.ToDecimal(insertPartForm.textBoxCost.Text);
                        db.Parts.Add(part);
                        db.SaveChanges();
                        dataGridViewMain.DataSource = db.Parts.ToList();
                        insertPartForm.Close();
                        break;
                    case "TYPE":
                        TypeForm insertTypeForm = new TypeForm();
                        result = insertTypeForm.ShowDialog(this);
                        if (result == DialogResult.Cancel)
                            return;
                        TypesOfWork typeOfWork = new TypesOfWork();
                        typeOfWork.Type = insertTypeForm.textBoxType.Text;
                        typeOfWork.Cost = Convert.ToDecimal(insertTypeForm.textBoxCost.Text);
                        db.TypesOfWorks.Add(typeOfWork);
                        db.SaveChanges();
                        dataGridViewMain.DataSource = db.TypesOfWorks.ToList();
                        insertTypeForm.Close();
                        break;
                    case "GARAGE":
                        GarageForm insertGarageForm = new GarageForm();
                        result = insertGarageForm.ShowDialog(this);
                        if (result == DialogResult.Cancel)
                            return;
                        Garage garage = new Garage();
                        if (insertGarageForm.radioButtonOpen.Checked)
                        {
                            garage.Condition = true;
                        }
                        else if (insertGarageForm.radioButtonClose.Checked)
                        {
                            garage.Condition = false;
                        }
                        db.Garages.Add(garage);
                        db.SaveChanges();
                        dataGridViewMain.DataSource = db.Garages.ToList();
                        insertGarageForm.Close();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect value. Data was not saved to the database. (" + ex.Message + ")");
            }
        }
        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;
                switch (selectedMenuItem)
                {
                    case "CAR":
                        CarForm updateCarForm = new CarForm();
                        updateCarForm.textBoxModel.Text = dataGridViewMain.CurrentRow.Cells[1].Value.ToString();
                        updateCarForm.textBoxRegSign.Text = dataGridViewMain.CurrentRow.Cells[2].Value.ToString();
                        updateCarForm.textBoxYear.Text = dataGridViewMain.CurrentRow.Cells[3].Value.ToString();
                        updateCarForm.textBoxColor.Text = dataGridViewMain.CurrentRow.Cells[4].Value.ToString();
                        result = updateCarForm.ShowDialog(this);
                        if (result == DialogResult.Cancel)
                            return;
                        Car car = db.Cars.Find(Convert.ToInt32(dataGridViewMain.CurrentRow.Cells[0].Value));
                        car.Model = updateCarForm.textBoxModel.Text;
                        car.RegisterSign = updateCarForm.textBoxRegSign.Text;
                        car.Year = Convert.ToInt32(updateCarForm.textBoxYear.Text);
                        car.Color = updateCarForm.textBoxColor.Text;                       
                        db.SaveChanges();
                        updateCarForm.Close();
                        break;

                    case "CLIENT":
                        ClientForm updateClientForm = new ClientForm();
                        updateClientForm.textBoxSurname.Text = dataGridViewMain.CurrentRow.Cells[1].Value.ToString();
                        updateClientForm.textBoxName.Text = dataGridViewMain.CurrentRow.Cells[2].Value.ToString();
                        updateClientForm.textBoxPassport.Text = dataGridViewMain.CurrentRow.Cells[3].Value.ToString();
                        updateClientForm.textBoxTelephone.Text = dataGridViewMain.CurrentRow.Cells[4].Value.ToString();
                        result = updateClientForm.ShowDialog(this);
                        if (result == DialogResult.Cancel)
                            return;
                        Client client = db.Clients.Find(Convert.ToInt32(dataGridViewMain.CurrentRow.Cells[0].Value));
                        client.SurName = updateClientForm.textBoxSurname.Text;
                        client.Name = updateClientForm.textBoxName.Text;
                        client.Passport = updateClientForm.textBoxPassport.Text;
                        client.Telephone = Convert.ToInt32(updateClientForm.textBoxTelephone.Text);
                        db.SaveChanges();
                        updateClientForm.Close();
                        break;

                    case "EMPLOYEE":
                        EmployeeForm updateEmployeeForm = new EmployeeForm();
                        updateEmployeeForm.textBoxSurname.Text = dataGridViewMain.CurrentRow.Cells[1].Value.ToString();
                        updateEmployeeForm.textBoxName.Text = dataGridViewMain.CurrentRow.Cells[2].Value.ToString();
                        updateEmployeeForm.textBoxPassport.Text = dataGridViewMain.CurrentRow.Cells[3].Value.ToString();
                        updateEmployeeForm.textBoxTelephone.Text = dataGridViewMain.CurrentRow.Cells[4].Value.ToString();
                        result = updateEmployeeForm.ShowDialog(this);
                        if (result == DialogResult.Cancel)
                            return;
                        Employee employee = db.Employees.Find(Convert.ToInt32(dataGridViewMain.CurrentRow.Cells[0].Value));
                        employee.SurName = updateEmployeeForm.textBoxSurname.Text;
                        employee.Name = updateEmployeeForm.textBoxName.Text;
                        employee.Passport = updateEmployeeForm.textBoxPassport.Text;
                        employee.Telephone = Convert.ToInt32(updateEmployeeForm.textBoxTelephone.Text);
                        db.SaveChanges();
                        updateEmployeeForm.Close();
                        break;

                    case "PART":
                        PartForm updatePartForm = new PartForm();
                        updatePartForm.textBoxName.Text = dataGridViewMain.CurrentRow.Cells[1].Value.ToString();
                        updatePartForm.textBoxCost.Text = dataGridViewMain.CurrentRow.Cells[2].Value.ToString();
                        result = updatePartForm.ShowDialog(this);
                        if (result == DialogResult.Cancel)
                            return;
                        Part part = db.Parts.Find(Convert.ToInt32(dataGridViewMain.CurrentRow.Cells[0].Value));
                        part.Name = updatePartForm.textBoxName.Text;
                        part.Cost = Convert.ToDecimal(updatePartForm.textBoxCost.Text);
                        db.SaveChanges();
                        updatePartForm.Close();
                        break;

                    case "TYPE":
                        TypeForm updateTypeForm = new TypeForm();
                        updateTypeForm.textBoxType.Text = dataGridViewMain.CurrentRow.Cells[1].Value.ToString();
                        updateTypeForm.textBoxCost.Text = dataGridViewMain.CurrentRow.Cells[2].Value.ToString();
                        result = updateTypeForm.ShowDialog(this);
                        if (result == DialogResult.Cancel)
                            return;
                        TypesOfWork typeOfWork = db.TypesOfWorks.Find(Convert.ToInt32(dataGridViewMain.CurrentRow.Cells[0].Value));
                        typeOfWork.Type = updateTypeForm.textBoxType.Text;
                        typeOfWork.Cost = Convert.ToDecimal(updateTypeForm.textBoxCost.Text);
                        db.SaveChanges();
                        updateTypeForm.Close();
                        break;

                    case "GARAGE":
                        GarageForm updateGarageForm = new GarageForm();
                        if ((bool)(dataGridViewMain.CurrentRow.Cells[1].Value) == true)
                        {
                            updateGarageForm.radioButtonClose.Checked = false;
                            updateGarageForm.radioButtonOpen.Checked = true;
                        }
                        else if ((bool)(dataGridViewMain.CurrentRow.Cells[1].Value) == false)
                        {
                            updateGarageForm.radioButtonClose.Checked = true;
                            updateGarageForm.radioButtonOpen.Checked = false;
                        }
                        result = updateGarageForm.ShowDialog(this);
                        if (result == DialogResult.Cancel)
                            return;
                        Garage garage = db.Garages.Find(Convert.ToInt32(dataGridViewMain.CurrentRow.Cells[0].Value));
                        if (updateGarageForm.radioButtonOpen.Checked)
                        {
                            garage.Condition = true;
                        }
                        else if (updateGarageForm.radioButtonClose.Checked)
                        {
                            garage.Condition = false;
                        }
                        db.SaveChanges();
                        updateGarageForm.Close();
                        break;

                    case "INSTALLATION":
                        InstallationForm updateInstallationForm = new InstallationForm();
                        updateInstallationForm.textBoxClient.Text = dataGridViewMain.CurrentRow.Cells[1].Value.ToString();
                        updateInstallationForm.textBoxCar.Text = dataGridViewMain.CurrentRow.Cells[2].Value.ToString();
                        updateInstallationForm.textBoxType.Text = dataGridViewMain.CurrentRow.Cells[3].Value.ToString();
                        updateInstallationForm.textBoxPart.Text = dataGridViewMain.CurrentRow.Cells[4].Value.ToString();
                        updateInstallationForm.textBoxEmployee.Text = dataGridViewMain.CurrentRow.Cells[5].Value.ToString();
                        updateInstallationForm.textBoxGarage.Text = dataGridViewMain.CurrentRow.Cells[6].Value.ToString();
                        result = updateInstallationForm.ShowDialog(this);
                        if (result == DialogResult.Cancel)
                            return;
                        Installation installation = db.Installations.Find(Convert.ToInt32(dataGridViewMain.CurrentRow.Cells[0].Value));
                        installation.ID_Client = Convert.ToInt32(updateInstallationForm.textBoxClient.Text);
                        installation.ID_Car = Convert.ToInt32(updateInstallationForm.textBoxCar.Text);
                        installation.ID_Work = Convert.ToInt32(updateInstallationForm.textBoxType.Text);
                        installation.ID_Part = Convert.ToInt32(updateInstallationForm.textBoxPart.Text);
                        installation.ID_Employee = Convert.ToInt32(updateInstallationForm.textBoxEmployee.Text);
                        installation.ID_Garage = Convert.ToInt32(updateInstallationForm.textBoxGarage.Text);
                        db.SaveChanges();
                        updateInstallationForm.Close();
                        break;

                }
                dataGridViewMain.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect value. Data was not saved to the database. (" + ex.Message+")");                
            }

        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                switch (selectedMenuItem)
                {
                    case "CAR":
                        Car car = db.Cars.Find(Convert.ToInt32(dataGridViewMain.CurrentRow.Cells[0].Value));
                        db.Cars.Remove(car);
                        db.SaveChanges();
                        dataGridViewMain.DataSource = db.Cars.ToList();
                        break;
                    case "CLIENT":
                        Client client = db.Clients.Find(Convert.ToInt32(dataGridViewMain.CurrentRow.Cells[0].Value));
                        db.Clients.Remove(client);
                        db.SaveChanges();
                        dataGridViewMain.DataSource = db.Clients.ToList();
                        break;
                    case "TYPE":
                        TypesOfWork typeOfWork = db.TypesOfWorks.Find(Convert.ToInt32(dataGridViewMain.CurrentRow.Cells[0].Value));
                        db.TypesOfWorks.Remove(typeOfWork);
                        db.SaveChanges();
                        dataGridViewMain.DataSource = db.TypesOfWorks.ToList();
                        break;
                    case "PART":
                        Part part = db.Parts.Find(Convert.ToInt32(dataGridViewMain.CurrentRow.Cells[0].Value));
                        db.Parts.Remove(part);
                        db.SaveChanges();
                        dataGridViewMain.DataSource = db.Parts.ToList();
                        break;
                    case "EMPLOYEE":
                        Employee employee = db.Employees.Find(Convert.ToInt32(dataGridViewMain.CurrentRow.Cells[0].Value));
                        db.Employees.Remove(employee);
                        db.SaveChanges();
                        dataGridViewMain.DataSource = db.Employees.ToList();
                        break;
                    case "GARAGE":
                        Garage garage = db.Garages.Find(Convert.ToInt32(dataGridViewMain.CurrentRow.Cells[0].Value));
                        db.Garages.Remove(garage);
                        db.SaveChanges();
                        dataGridViewMain.DataSource = db.Garages.ToList();
                        break;
                    case "INSTALLATION":
                        Installation installation = db.Installations.Find(Convert.ToInt32(dataGridViewMain.CurrentRow.Cells[0].Value));
                        db.Installations.Remove(installation);
                        db.SaveChanges();
                        dataGridViewMain.DataSource = db.Installations.ToList();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Incorrect value. Data was not saved to the database. (" + ex.Message + ")");
            }

        }
        private void ButtonExport_Click(object sender, EventArgs e)
        {
            using (var workbook = new XLWorkbook())
            {
                var installs = from i in db.Installations
                               join c in db.Cars on i.ID_Car equals c.ID_Car
                               join cl in db.Clients on i.ID_Client equals cl.ID_Client
                               join t in db.TypesOfWorks on i.ID_Work equals t.ID_Work
                               join p in db.Parts on i.ID_Part equals p.ID_Part
                               join em in db.Employees on i.ID_Employee equals em.ID_Employee
                               join g in db.Garages on i.ID_Garage equals g.ID_Garage
                               select new { Car = c.Model, Client = cl.Name + " " + cl.SurName, Service = t.Type, Part = p.Name, Employee = em.Name + " " + em.SurName, Garage = g.ID_Garage };

                var worksheet = workbook.Worksheets.Add("Main");
                worksheet.Cell(1, 1).Value = "Car";
                worksheet.Cell(1, 2).Value = "Client";
                worksheet.Cell(1, 3).Value = "Type of service";
                worksheet.Cell(1, 4).Value = "Part";
                worksheet.Cell(1, 5).Value = "Employee";
                worksheet.Cell(1, 6).Value = "Garage";
                var rangeWithData = worksheet.Cell(2, 1).InsertData(installs.AsEnumerable());

                var garages = db.Garages.ToList();
                var worksheetGarage = workbook.Worksheets.Add("Garages");
                worksheetGarage.Cell(1, 1).Value = "ID";
                worksheetGarage.Cell(1, 2).Value = "Condition";
                var rangeWithDataGarage = worksheetGarage.Cell(2, 1).InsertData(garages.AsEnumerable());

                var cars = db.Cars.ToList();
                var worksheetCar = workbook.Worksheets.Add("Cars");
                worksheetCar.Cell(1, 1).Value = "ID";
                worksheetCar.Cell(1, 2).Value = "Model";
                worksheetCar.Cell(1, 3).Value = "RegisterSign";
                worksheetCar.Cell(1, 4).Value = "Year";
                worksheetCar.Cell(1, 5).Value = "Color";
                var rangeWithDataCar = worksheetCar.Cell(2, 1).InsertData(cars.AsEnumerable());

                var clients = db.Clients.ToList();
                var worksheetClient = workbook.Worksheets.Add("Clients");
                worksheetClient.Cell(1, 1).Value = "ID";
                worksheetClient.Cell(1, 2).Value = "Surname";
                worksheetClient.Cell(1, 3).Value = "Name";
                worksheetClient.Cell(1, 4).Value = "Passport";
                worksheetClient.Cell(1, 5).Value = "Telephone";
                var rangeWithDataClient = worksheetClient.Cell(2, 1).InsertData(clients.AsEnumerable());

                var employees = db.Employees.ToList();
                var worksheetEmployee = workbook.Worksheets.Add("Employees");
                worksheetEmployee.Cell(1, 1).Value = "ID";
                worksheetEmployee.Cell(1, 2).Value = "Surname";
                worksheetEmployee.Cell(1, 3).Value = "Name";
                worksheetEmployee.Cell(1, 4).Value = "Passport";
                worksheetEmployee.Cell(1, 5).Value = "Telephone";
                var rangeWithDataEmployee = worksheetEmployee.Cell(2, 1).InsertData(employees.AsEnumerable());
                

                var parts = db.Parts.ToList();
                var worksheetPart = workbook.Worksheets.Add("Parts");
                worksheetPart.Cell(1, 1).Value = "ID";
                worksheetPart.Cell(1, 2).Value = "Name";
                worksheetPart.Cell(1, 3).Value = "Cost";
                var rangeWithDataPart = worksheetPart.Cell(2, 1).InsertData(parts.AsEnumerable());

                var types = db.TypesOfWorks.ToList();
                var worksheetType = workbook.Worksheets.Add("Types of service");
                worksheetType.Cell(1, 1).Value = "ID";
                worksheetType.Cell(1, 2).Value = "Type";
                worksheetType.Cell(1, 3).Value = "Cost";
                var rangeWithDataType = worksheetType.Cell(2, 1).InsertData(types.AsEnumerable());

                workbook.SaveAs("Service Station.xlsx");
            }
        }
    }

}
