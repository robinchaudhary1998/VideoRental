using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace VideoRental
{
    public partial class VideosRental : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyRentaldb"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        SqlDataAdapter adp = new SqlDataAdapter();
        SqlDatabase db = new SqlDatabase();
        public VideosRental()
        {
            InitializeComponent();
        }

        private void VideosRental_Load(object sender, EventArgs e)
        {

            FillCustomerGrid();
            FillVideoGrid();
            FillRentedVideoGrid();
            MostBorrow();
            MostPopularVideo();

        }
        
        public void FillCustomerGrid()
        {
            DataSet dsCust = new DataSet();
            cmd = new SqlCommand("select * from Customer", conn);
            adp.SelectCommand = cmd;
            dsCust.Clear();
            adp.Fill(dsCust, "Customer");
            custGrid.DataSource = dsCust.Tables["Customer"];
        }
        private void FillVideoGrid()
        {
            DataSet dsMovie = new DataSet();
            cmd = new SqlCommand("select * from Movie", conn);
            adp.SelectCommand = cmd;
            dsMovie.Clear();
            adp.Fill(dsMovie, "Movie");
            gridVideo.DataSource = dsMovie.Tables["Movie"];
        }
        private void FillRentedVideoGrid()
        {
            DataSet dsRentedMovie = new DataSet();
            cmd = new SqlCommand("select * from ViewRentedMovies", conn);
            adp.SelectCommand = cmd;
            dsRentedMovie.Clear();
            adp.Fill(dsRentedMovie, "ViewRentedMovies");
            gridRentedMovie.DataSource = dsRentedMovie.Tables["ViewRentedMovies"];
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            InsertNewCustomer();
            
            

        }
        public void InsertNewCustomer()
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("First Name is required");
                return;
            }
            else if (string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Last Name is required");
                return;
            }
            else if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Address is required");
                return;
            }
            else if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Phone No. is required");
                return;
            }
            try
            {
                db.AddCustomer(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtPhone.Text);
                lblId.Text = "";
                lblMovieId.Text = "";
                lblRMID.Text = "";
                ClearTextBoxes();
                FillCustomerGrid();
                tabControl1.SelectedIndex = 0;
                MessageBox.Show("Successfully Add Customer");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void custGrid_Click(object sender, EventArgs e)
        {
            if (custGrid.Rows.Count > 0)
            {
                lblId.Text = custGrid.CurrentRow.Cells[0].Value.ToString();
                txtFirstName.Text = custGrid.CurrentRow.Cells[1].Value.ToString();
                txtLastName.Text = custGrid.CurrentRow.Cells[2].Value.ToString();
                txtAddress.Text = custGrid.CurrentRow.Cells[3].Value.ToString();
                txtPhone.Text = custGrid.CurrentRow.Cells[4].Value.ToString();
                
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (string.IsNullOrEmpty(lblId.Text))
                {
                    MessageBox.Show("Select the Customer for Update");
                    return;
                }
                db.EditCustomer(Convert.ToInt32(lblId.Text), txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtPhone.Text);

                lblId.Text = "";
                ClearTextBoxes();
                FillCustomerGrid();
                tabControl1.SelectedIndex = 0;
                MessageBox.Show("Successfully Update Customer");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
               
            

            
        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblId.Text))
            {
                MessageBox.Show("Please Select the Customer for Delete");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("ARE YOU SURE YOU WANT TO DELETE THIS Customer ??", "Customer Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {

                    db.DeleteCustomer(Convert.ToInt32(lblId.Text));
                    MessageBox.Show("Record Deleted.......");
                    ClearTextBoxes();
                    lblId.Text = "";
                    FillCustomerGrid();
                   
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

              
            }
            else if (dialogResult == DialogResult.No)
            {
               
            }
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                MessageBox.Show("Movie Title is required");
                return;
            }
            else if (string.IsNullOrEmpty(txtCost.Text))
            {
                MessageBox.Show("Rental Cost is required");
                return;
            }
            try
            {
                db.AddVideo(txtTitle.Text, dtpReleaseDate.Value.Date, Convert.ToDecimal(txtCost.Text), txtGenre.Text, txtPlot.Text);

                lblId.Text = "";
                lblMovieId.Text = "";
                lblRMID.Text = "";
                ClearTextBoxes();
                FillVideoGrid();
                tabControl1.SelectedIndex = 1;
                MessageBox.Show("Successfully Add Video");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
         
        }

        private void gridVideo_Click(object sender, EventArgs e)
        {
            if (gridVideo.Rows.Count > 0)
            {
                lblMovieId.Text = gridVideo.CurrentRow.Cells[0].Value.ToString();
                txtTitle.Text = gridVideo.CurrentRow.Cells[1].Value.ToString();
                dtpReleaseDate.Text = gridVideo.CurrentRow.Cells[2].Value.ToString();
                txtCost.Text = gridVideo.CurrentRow.Cells[3].Value.ToString();
                txtGenre.Text = gridVideo.CurrentRow.Cells[4].Value.ToString();
                txtPlot.Text = gridVideo.CurrentRow.Cells[5].Value.ToString();

            }
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblMovieId.Text))
            {
                MessageBox.Show("Please Select the Video for Update");
                return;
            }
            try { 
           db.EditVideo(Convert.ToInt32(lblMovieId.Text),txtTitle.Text, dtpReleaseDate.Value.Date, Convert.ToDecimal(txtCost.Text), txtGenre.Text, txtPlot.Text);
            
                lblMovieId.Text = "";
                ClearTextBoxes();
                FillVideoGrid();
                tabControl1.SelectedIndex = 1;
                MessageBox.Show("Successfully Updated Video");
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblMovieId.Text))
            {
                MessageBox.Show("Please Select the Video for Delete");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("ARE YOU SURE YOU WANT TO DELETE THIS Video ??", "Record Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try { 
                db.DeleteVideo(Convert.ToInt32(lblMovieId.Text));
                
                    MessageBox.Show("Record Deleted.......");


                    ClearTextBoxes();
                    lblMovieId.Text = "";
                    FillVideoGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

               
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        private void btnIssueMovie_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(lblId.Text) || string.IsNullOrEmpty(lblMovieId.Text))
            {
                MessageBox.Show("Please Select the Customer and Movie for rental");
                return;
            }
            var alreadyRental = 0;
            conn.Open();
            cmd = new SqlCommand("Select * from RentedMovies where MovieId=@MovieId and DateReturned is NULL", conn);
            cmd.Parameters.AddWithValue("@MovieId", lblMovieId.Text);
            rdr = cmd.ExecuteReader();
            if(rdr.Read())
            {
                alreadyRental = 1;
            }
            else
            {
                alreadyRental = 0;
            }
            rdr.Close();
            conn.Close();
            if(alreadyRental==1)
            {
                MessageBox.Show("This Video already rented");
                return;
            }
            try { 
            db.AddRentalVideo(Convert.ToInt32(lblMovieId.Text), Convert.ToInt32(lblId.Text));

          
                MessageBox.Show("Movie Rented successfully");
                lblId.Text = "";
                lblMovieId.Text = "";
                ClearTextBoxes();
                FillRentedVideoGrid();
                MostBorrow();
                MostPopularVideo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           

        }

        private void gridRentedMovie_Click(object sender, EventArgs e)
        {
            if (gridRentedMovie.Rows.Count > 0)
            {
                lblRMID.Text = gridRentedMovie.CurrentRow.Cells["RMID"].Value.ToString();
                lblId.Text = gridRentedMovie.CurrentRow.Cells["CustId"].Value.ToString();
                txtFirstName.Text = gridRentedMovie.CurrentRow.Cells["FirstName"].Value.ToString();
                txtLastName.Text = gridRentedMovie.CurrentRow.Cells["LastName"].Value.ToString();
                txtAddress.Text = gridRentedMovie.CurrentRow.Cells["Address"].Value.ToString();
                txtPhone.Text = gridRentedMovie.CurrentRow.Cells["Phone"].Value.ToString();
                lblMovieId.Text = gridRentedMovie.CurrentRow.Cells["MovieId"].Value.ToString();
                txtTitle.Text = gridRentedMovie.CurrentRow.Cells["Title"].Value.ToString();
                dtpReleaseDate.Text = gridRentedMovie.CurrentRow.Cells["ReleaseDate"].Value.ToString();
                txtCost.Text = gridRentedMovie.CurrentRow.Cells["RentalCost"].Value.ToString();
                txtGenre.Text = gridRentedMovie.CurrentRow.Cells["Genre"].Value.ToString();
                txtPlot.Text = gridRentedMovie.CurrentRow.Cells["Plot"].Value.ToString();

            }
        }

        private void btnReturnMovie_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(lblRMID.Text))
            {
                MessageBox.Show("Please Select the Rented Movie");
                tabControl1.SelectedIndex = 2;
                return;
            }
            conn.Open();
            var alreadyReturned = 0;
            cmd = new SqlCommand("Select * from RentedMovies where RentedMovieId=@RentedMovieId and DateReturned is Not NULL", conn);
            cmd.Parameters.AddWithValue("@RentedMovieId", lblRMID.Text);
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                alreadyReturned = 1;
            }
            else
            {
                alreadyReturned = 0;
            }
            rdr.Close();
            conn.Close();
            if(alreadyReturned==1)
            {
                MessageBox.Show("This Video already returned");
                return;
            }
            try { 
            db.Returned(Convert.ToInt32(lblRMID.Text));
            
                MessageBox.Show("Movie Returned successfully");
                lblId.Text = "";
                lblMovieId.Text = "";
                lblRMID.Text = "";
                ClearTextBoxes();
                tabControl1.SelectedIndex = 2;
                FillRentedVideoGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           
        }

        private void btnShowRentedVideo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            FillRentedVideoGrid();


        }

        private void dtpReleaseDate_ValueChanged(object sender, EventArgs e)
        {
            if(dtpReleaseDate.Value.Date<=DateTime.Now.Date.AddYears(-5))
            {
                txtCost.Text = "2";
            }
            else
            {
                txtCost.Text = "5";
            }
        }
        private void MostBorrow()
        {
            DataSet ds = new DataSet();
            cmd = new SqlCommand("select CustId,FirstName,LastName,Address,Phone,Count(*) as 'Total Borrows' from ViewRentedMovies group by CustId,FirstName,LastName,Address,Phone order by 'Total Borrows' desc", conn);
            adp.SelectCommand = cmd;
            ds.Clear();
            adp.Fill(ds, "ViewRentedMovies");
            gridMostBorrow.DataSource = ds.Tables["ViewRentedMovies"];
        }
        private void MostPopularVideo()
        {
            DataSet ds = new DataSet();
            cmd = new SqlCommand("select MovieId,Title,ReleaseDate,RentalCost,Genre,Count(*) as 'Total Rented By' from ViewRentedMovies group by MovieId,Title,ReleaseDate,RentalCost,Genre order by 'Total Rented By' desc", conn);
            adp.SelectCommand = cmd;
            ds.Clear();
            adp.Fill(ds, "ViewRentedMovies");
            gridPopularVideo.DataSource = ds.Tables["ViewRentedMovies"];
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex==2)
            {
                FillRentedVideoGrid();
            }
        }

        private void btnRentedOut_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            DataSet dsRentedMovie = new DataSet();
            cmd = new SqlCommand("select * from ViewRentedMovies where DateReturned is Null", conn);
            adp.SelectCommand = cmd;
            dsRentedMovie.Clear();
            adp.Fill(dsRentedMovie, "ViewRentedMovies");
            gridRentedMovie.DataSource = dsRentedMovie.Tables["ViewRentedMovies"];
        }

        private void btnMostborrow_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
            MostBorrow();
        }

        private void btnMostPopular_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
            MostPopularVideo();
        }
    }
    

}
