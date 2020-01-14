using System;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Data.OleDb;
using System.Data;
using DataBaseCSV;


namespace AprovCSV
{
    public partial class Form1 : Form
    {


        public DBAccess ConectDB()
        {
            DBAccess BancoConectado = new DBAccess("Data Source=localhost\\SQL2008; Initial Catalog=BaseAproveHiDoctor; User Id=sa; Password=totvs@123;");
            return BancoConectado;
        }

        public Form1()
        {
            InitializeComponent();
         }

        private void btSelect_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.ShowDialog();
                int ImportedRecord = 0, inValidItem = 0;
                string SourceURl = "";

                if (dialog.FileName != "" && dialog.FileName.EndsWith(".csv"))
                {

                    DataTable DataTable = new DataTable();
                    DataTable = GetDataTabletFromCSVFile(dialog.FileName);
                    //if (Convert.ToString(DataTable.Columns[0]).ToLower() != "ColunaPcod")
                    //{
                    //    MessageBox.Show("Caminho do arquivo invalido");
                    //    btnSave.Enabled = false;
                    //    return;
                    //}
                    txtFile.Text = dialog.SafeFileName;
                    SourceURl = dialog.FileName;
                    if (DataTable.Rows != null && DataTable.Rows.ToString() != String.Empty)
                    {
                        dgItems.DataSource = DataTable;
                    }
                    foreach (DataGridViewRow row in dgItems.Rows)
                    {
                        if (Convert.ToString(row.Cells["Paci_ln_Counter"].Value) == "" || row.Cells["Paci_ln_Counter"].Value == null
                            || Convert.ToString(row.Cells["Paci_tx_NomePaciente"].Value) == "" || row.Cells["Paci_tx_NomePaciente"].Value == null
                            || Convert.ToString(row.Cells["Paci_tx_TelefonesPaciente"].Value) == "" || row.Cells["Paci_tx_TelefonesPaciente"].Value == null)
                        {
                            inValidItem += 1;
                        }
                        else
                        {
                            ImportedRecord += 1;
                        }
                    }
                    if (dgItems.Rows.Count == 0)
                    {
                        btnSave.Enabled = false;
                        MessageBox.Show("There is no data in this file", "GAUTAM POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Selected File is Invalid, Please Select valid csv file.", "GAUTAM POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception " + ex);
            }
        }
        public static DataTable GetDataTabletFromCSVFile(string csv_file_path)
        {
            DataTable csvData = new DataTable();
            try
            {
                if (csv_file_path.EndsWith(".csv"))
                {
                    using (Microsoft.VisualBasic.FileIO.TextFieldParser csvReader = new Microsoft.VisualBasic.FileIO.TextFieldParser(csv_file_path))
                    {
                        csvReader.SetDelimiters(new string[] { "," });
                        csvReader.HasFieldsEnclosedInQuotes = true;
                        //read column
                        string[] colFields = csvReader.ReadFields();
                        foreach (string column in colFields)
                        {
                            DataColumn datecolumn = new DataColumn(column);
                            datecolumn.AllowDBNull = true;
                            csvData.Columns.Add(datecolumn);
                        }
                        while (!csvReader.EndOfData)
                        {
                            string[] fieldData = csvReader.ReadFields();
                            for (int i = 0; i < fieldData.Length; i++)
                            {
                                if (fieldData[i] == "")
                                {
                                    fieldData[i] = null;
                                }
                            }
                            csvData.Rows.Add(fieldData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exce " + ex);
            }
            return csvData;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dtItem = (DataTable)(dgItems.DataSource);
            string Nome, Phone, Pcod;
            string InsertItemQry = "";
            int count = 0;
            try
            {
                foreach (DataRow dr in dtItem.Rows)
                {
                    Nome = Convert.ToString(dr["Paci_tx_NomePaciente"]);
                    Phone = Convert.ToString(dr["Paci_tx_TelefonesPaciente"]);
                    Pcod = Convert.ToString(dr["Paci_ln_Counter"]);

                    if (Nome != "")
                    {
                        InsertItemQry += $@"INSERT INTO Pacientes (PCOD,Name,Phone) VALUES ({Pcod},'{Nome}','{Phone}')";
                        count++;
                    }
                }
                if (InsertItemQry.Length > 5)
                {
                    ConectDB().ExecuteQuery(InsertItemQry);
                    var i = count;
                    progressBar2.Maximum = count;
                    progressBar.Maximum = count;
                    progressBar2.Value = 0;
                    progressBar.Value = 0;
                    while (progressBar.Value != i)
                    {
                        progressBar.Value++;
                    }
                    if (progressBar.Value == i)
                    {
                        ConectDB().ExecuteQuery($@"update pacientes set Unit = 0");
                        btnClini02.Visible = true;
                    }
                }



            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro no paciente:  " + ex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxSIM_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClini02_Click(object sender, EventArgs e)
        {
            
            progressBar2.Visible = true;
            while (progressBar2.Value != progressBar.Maximum)
            {
                progressBar2.Value++;
            }

            ConectDB().ExecuteQuery($@"-- begin transaction
                                        DECLARE @ID int
                                        DECLARE @pcod int
                                        DECLARE @UNIT int
                                        DECLARE @USERNUMBER int

                                        DECLARE db_cursor CURSOR FOR 
                                        SELECT PCod
                                        FROM Pacientes
                                        WHERE Pacientes.Pcod is not null

                                        set @ID = 0
                                        SET @UNIT = 0
                                        SET @USERNUMBER = 2
                                        OPEN db_cursor  
                                        FETCH NEXT FROM db_cursor INTO @pcod 

                                        WHILE @@FETCH_STATUS = 0  

                                        BEGIN  
	                                        set @id = @id+1
	                                        INSERT INTO Pacientes_02(PCod,clini_02_id,UNIT,UserNumber)      
	                                        values(@pcod,@id,@UNIT,@USERNUMBER)
                                            FETCH NEXT FROM db_cursor INTO @PCod 
                                        END 

                                        CLOSE db_cursor  
                                        DEALLOCATE db_cursor

                                        -- commit transaction
                                        --rollback transaction");

        }
    }


}


