using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Windows;

namespace GANAAN_CUSTOMER_MGR
{
    class Control_DB
    {
        String dbConnection = string.Empty;


        public void test()
        {
            try
            {
                SQLiteDatabase db = new SQLiteDatabase();
                DataTable recipe;
                String query = "select NAME \"Name\", DESCRIPTION \"Description\",";
                query += "PREP_TIME \"Prep Time\", COOKING_TIME \"Cooking Time\"";
                query += "from RECIPE;";
                recipe = db.GetDataTable(query);
                // The results can be directly applied to a DataGridView control
                //recipeDataGrid.DataSource = recipe;


                /*
                // Or looped through for some other reason
                foreach (DataRow r in recipe.Rows)
                {
                    MessageBox.Show(r["Name"].ToString());
                    MessageBox.Show(r["Description"].ToString());
                    MessageBox.Show(r["Prep Time"].ToString());
                    MessageBox.Show(r["Cooking Time"].ToString());
                }
	
                */
            }
            catch (Exception fail)
            {
                String error = "The following error has occurred:\n\n";
                error += fail.Message.ToString() + "\n\n";
                MessageBox.Show(error);
                this.Close();
            }


        }

        private void Close()
        {
            throw new NotImplementedException();
        }
        
    }
}
