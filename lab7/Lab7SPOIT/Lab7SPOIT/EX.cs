using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using Excel = Microsoft.Office.Interop.Excel;

namespace Lab7SPOIT
{
    class EX : IDisposable
    {
        private Excel.Application _excel;
        private Excel.Workbook _workbook;
        private Excel.Worksheet _worksheet;
        private string _filepath;
        public EX()
        {
            _excel = new Excel.Application();

        }
        public void Dispose()
        {
            try
            {
                _workbook.Close();
                _excel.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ErrorOpen2", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            //throw new NotImplementedException();
        }

        internal bool Open(string filePath, out bool Create)
        {

            try
            {
                
                if (System.IO.File.Exists(filePath))
                {
                    
                    _workbook = _excel.Workbooks.Open(filePath);
                    //_excel.Visible = true;
                    Create = false;
                }
                else

                {
                    _excel.Visible = true;
                    //MessageBox.Show("Create file".ToString(), "ErrorOpen1", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _workbook = _excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                    _worksheet = (Worksheet)_workbook.ActiveSheet;
                    _filepath = filePath;
                    //_workbook.SaveAs(_filepath);
                    Create = true;

                }
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ErrorOpen2", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            Create = false;
            return false;
            //throw new NotImplementedException();
        }

        internal bool Set(int row, int column, string data)
        {

            try
            {
                ((Excel.Worksheet)_excel.ActiveSheet).Cells[row, column] = data;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ErrorSet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }
        internal bool Set(string column, int row, string data)
        {

            try
            {
                ((Excel.Worksheet)_excel.ActiveSheet).Cells[row, column] = data;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ErrorSet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }
        internal bool SetFormula(int row, int column, string data)
        {

            try
               
            {
               
                //_worksheet.Rows[row.ToString()].Insert();
                //MessageBox.Show((row+" "+column+" "+data).ToString(), "ErrorhhSet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _worksheet.Cells[row, column].Formula = data;
                _worksheet.Hyperlinks.Add(_worksheet.Cells[row, column], "mailto:"+data, Type.Missing, data, data);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show(ex.ToString(), "ErrorSet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }
        internal bool Get(string text, out string row, out string col)
        {

            try
            {
               
                string from = "A1";
                string to = "M10";
                Range rng = ((Excel.Worksheet)_excel.ActiveSheet).get_Range(from, to);
                Range findRng = rng.Find(text);
                //data.Cells[1, "B"].Value
                //MessageBox.Show(findRng.Column.ToString()+ findRng.Row.ToString() + (findRng!=null).ToString(),   "AAAA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(((Excel.Worksheet)_excel.ActiveSheet).Cells[findRng.Column, findRng.Row].Hyperlinks[0].Address,   "AAAA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (findRng != null)
                {
                    row = findRng.Row.ToString();
                    col = findRng.Column.ToString();
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ErrorGet", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            row = String.Empty;
            col = String.Empty;
            return false;
        }

        internal void Save()
        {
            if(!string.IsNullOrEmpty(_filepath))
            {
                _workbook.SaveAs(_filepath);
                _filepath = null;
            }
            else
            {
                _workbook.Save();
            }
            _excel.Visible = false;
        }
    }
}
