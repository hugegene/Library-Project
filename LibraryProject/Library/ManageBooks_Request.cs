using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class RequestBookForm : Form
    {
        public RequestBookForm()
        {
            InitializeComponent();
        }

        private void CancelRequestButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool ValidateValues(out String err)
        {
            err = "";

            if (String.IsNullOrEmpty(TitleTextBox.Text) || TitleTextBox.Text.Length >= 255)
            {
                err = "Enter Valid Title";
                return false;
            }

            if (String.IsNullOrEmpty(AuthorTextBox.Text) || AuthorTextBox.Text.Length >= 50)
            {
                err = "Enter Valid Author";
                return false;
            }

            // Remarks can be empty, no need to check that
            if (RemarksTextBox.Text.Length >= 255)
            {
                err = "Enter Valid Remarks";
                return false;
            }

            return true;
        }

        private void RequestButton_Click(object sender, EventArgs e)
        {
            String errorMessage;

            // Display error if values are invalid
            if (!ValidateValues(out errorMessage))
            {
                MessageBox.Show(errorMessage, "Unable to Add Request", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Create the Connection (TODO : Get the connection string from elsewhere)
            String connectionString = "data source=(local);"
                + "initial catalog=SA45Team13bLibrary;";
            if (Environment.MachineName.StartsWith("ISS"))
            {
                connectionString += "User id=sa;"
                + "Password=Secret;";
            }
            else
            {
                connectionString += "integrated security = SSPI;";
            }

            SqlConnection connection = new SqlConnection(connectionString);

            // Create the SQL Update Command
            SqlCommand cmd = new SqlCommand();
            String sqlQuery = "INSERT INTO BookRequested VALUES"
                + "(@Title, @Author, @Remarks)";
            cmd.CommandText = sqlQuery;
            cmd.Connection = connection;

            // Display a message if update fails
            try
            {
                // Adding the parameters
                cmd.Parameters.Add("@Title", SqlDbType.NVarChar, 255).Value = TitleTextBox.Text;
                cmd.Parameters.Add("@Author", SqlDbType.NVarChar, 50).Value = AuthorTextBox.Text;
                cmd.Parameters.Add("@Remarks", SqlDbType.NVarChar, 255).Value = RemarksTextBox.Text;

                // Insert The Request
                connection.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Your request has been noted.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("One or more fields violates database consistency"
                    + Environment.NewLine + ex.Message, "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Close this form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
