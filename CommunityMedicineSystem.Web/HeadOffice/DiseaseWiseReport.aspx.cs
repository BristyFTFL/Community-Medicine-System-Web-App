using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CommunityMedicineSystem.BLL;
using CommunityMedicineSystem.DAO;

namespace CommunityMedicineSystem.Web.HeadOffice
{
    public partial class DiseaseWiseReport : System.Web.UI.Page
    {
        DiseaseManager aDiseaseManager = new DiseaseManager();

        public void showButton_Click(object sender, EventArgs e)
        {
            int diseaseId= Convert.ToInt32(diseaseDropDownList.SelectedValue);
            showGridView.DataSource = aDiseaseManager.GetTotalPatientList(startDateTextBox.Value, endDateTextBox.Value, diseaseId);
            showGridView.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            diseaseDropDownList.DataSource = aDiseaseManager.GetAllDiseases();
            diseaseDropDownList.DataTextField = "Name";
            diseaseDropDownList.DataValueField ="Id";
            diseaseDropDownList.DataBind();
        }
    }
}