using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
namespace TaskManagementFinal
{
    public class TasksDAC
    {
        #region Create and Load Tasks File

        /// <summary>
        /// Creates a new xls file having header rows only. Header rows
        /// have the same names as Task class. 
        /// </summary>
        private void CreateNewFile()
        {
            Excel.Application xlApp = new Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show(SharedData.EXCEL_NOT_INSTALLED_WARNING);
            }
            Excel.Workbook xlWorkBook = null;
            Excel.Worksheet xlWorkSheet = null;
            object misValue = System.Reflection.Missing.Value;
            try
            {
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                xlWorkSheet.Name = SharedData.WORKSHEET_NAME;
                xlWorkSheet = FillWorkSheetHeaders(xlWorkSheet);
                xlWorkBook.SaveAs(SharedData.FILE_PATH, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Marshal.ReleaseComObject(xlWorkSheet);
                xlApp.Workbooks.Close();
                Marshal.ReleaseComObject(xlWorkBook);
                xlWorkBook = null;
                Marshal.ReleaseComObject(xlApp);
                xlApp = null;
            }
        }
        
        /// <summary>
        /// File is loaded from storage, and converted to a list. 
        /// OLEDB is used to read the file. 
        /// If no file exists then a new one is created. 
        /// </summary>
        /// <returns></returns>
        public IList<ITask> LoadTasksFile()
        {
            IList<ITask> retVal = null;
            if (!DoesFileExist(SharedData.FILE_PATH))
            {
                CreateNewFile();
                retVal = new List<ITask>();
            }
            if (DoesFileExist(SharedData.FILE_PATH))
            {
                OleDbConnection oledbConnection;
                OleDbDataAdapter oledbDataAdapter;
                DataSet dataSet = new DataSet();

                string connectionString = SharedData.LOAD_CONNECTION_STRING;
                oledbConnection = new OleDbConnection(connectionString);
                oledbDataAdapter = new OleDbDataAdapter("select * from [" + SharedData.WORKSHEET_NAME + "$]", oledbConnection);
                oledbDataAdapter.Fill(dataSet);
                retVal = ConvertToList(dataSet.Tables[0]);
                oledbConnection.Close();
            }
            return retVal;
        }
        
        /// <summary>
        /// Converts Datatable type to List<Task> type. 
        /// </summary>
        /// <param name="dataTable"></param>
        /// <returns></returns>
        private IList<ITask> ConvertToList(DataTable dataTable)
        {
            IList<ITask> retVal = new List<ITask>();
            try
            {
                var rows = dataTable.Rows;
                foreach (DataRow item in rows)
                {
                    Task obj = new Task();
                    obj.TaskName = item["TaskName"].ToString();
                    obj.DueDate = DateTime.Parse(item["DueDate"].ToString().Substring(SharedData.DATE_PREFIX.Length));
                    obj.Assignee = item["Assignee"].ToString();
                    obj.Completed = bool.Parse(item["Completed"].ToString());
                    retVal.Add(obj);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return retVal;
        }
        #endregion

        #region Save using Interop  
       
        /// <summary>
        /// Save all data from datagrid to xls file. 
        /// Using interop.
        /// </summary>
        /// <param name="dataGrid"></param>
        /// <returns></returns>
        public bool SaveFile(DataGridView dataGrid)
        {
            if (!DoesFileExist(SharedData.FILE_PATH))
            {
                CreateNewFile();
                MessageBox.Show(SharedData.FILE_NOT_FOUND_WARNING);
                return false;
            }
            Excel.Application xlApp = new Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show(SharedData.EXCEL_NOT_INSTALLED_WARNING);
                return false;
            }
            Excel.Workbook xlWorkBook = null; ;
            Excel.Worksheet xlWorkSheet = null;
            object misValue = System.Reflection.Missing.Value;
            try
            {
                //open existing workbook
                xlWorkBook = xlApp.Workbooks.Open(SharedData.FILE_PATH, 0, false, 5, string.Empty, string.Empty, false, Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                //clear workseet
                xlWorkSheet.Cells.ClearContents();
                //Before populating, fill headers into the excel file.
                xlWorkSheet = FillWorkSheetHeaders(xlWorkSheet);
                //Populate excel with data.
                for (int i = 0; i < dataGrid.Rows.Count; i++)
                {
                    xlWorkSheet.Cells[i + 2, 1] = dataGrid.Rows[i].Cells[0].Value.ToString();
                    xlWorkSheet.Cells[i + 2, 2] = SharedData.DATE_PREFIX + dataGrid.Rows[i].Cells[1].Value.ToString();
                    xlWorkSheet.Cells[i + 2, 3] = dataGrid.Rows[i].Cells[2].Value.ToString();
                    xlWorkSheet.Cells[i + 2, 4] = dataGrid.Rows[i].Cells[3].Value.ToString();
                }
                xlApp.DisplayAlerts = false;
                //Save the workbook.
                xlWorkBook.SaveAs(SharedData.FILE_PATH, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Marshal.ReleaseComObject(xlWorkSheet);
                xlApp.Workbooks.Close();
                Marshal.ReleaseComObject(xlWorkBook);
                xlWorkBook = null;
                Marshal.ReleaseComObject(xlApp);
                xlApp = null;
            }
            return true;
        }

        private Excel.Worksheet FillWorkSheetHeaders(Excel.Worksheet worksheet)
        {
            worksheet.Name = SharedData.WORKSHEET_NAME;
            worksheet.Cells[1, 1] = "TaskName";
            worksheet.Cells[1, 2] = "DueDate";
            worksheet.Cells[1, 3] = "Assignee";
            worksheet.Cells[1, 4] = "Completed";
            return worksheet;
        }
        #endregion

        #region Load Assignee File

        private List<string> ConvertToAssigneeList(System.Data.DataTable dataTable)
        {
            List<string> retVal = new List<string>();
            try
            {
                var rows = dataTable.Rows;
                if (dataTable.Rows.Count <= 0)
                {
                    retVal.Add("Self");
                }
                foreach (DataRow item in rows)
                {
                    retVal.Add(item[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return retVal;
        }

        /// <summary>
        /// Method to load assignee file from disk.
        /// </summary>
        /// <returns></returns>
        public IList<string> LoadAssigneeFile()
        {
            IList<string> retVal = null;
            if (!DoesFileExist(SharedData.FILE_PATH_ASSIGNEES))
            {
                retVal = new List<string>() { "Self" };
                return retVal;
            }
            if (DoesFileExist(SharedData.FILE_PATH_ASSIGNEES))
            {
                OleDbConnection oledbConnection;
                DataSet dataSet;
                OleDbDataAdapter oledbDataAdapter;
                dataSet = new DataSet();
                string connectionString = SharedData.LOAD_CONNECTION_STRING_ASSIGNEES;
                oledbConnection = new OleDbConnection(connectionString);
                oledbDataAdapter = new OleDbDataAdapter("select * from [Sheet1$]", oledbConnection);
                oledbDataAdapter.Fill(dataSet);
                oledbConnection.Close();
                retVal = ConvertToAssigneeList(dataSet.Tables[0]);
            }
            return retVal;
        }
        #endregion

        #region SharedData
       
        private static bool DoesFileExist(string path)
        {
            if (File.Exists(path))
                return true;
            else
                return false;
        }
        #endregion
    }
}
