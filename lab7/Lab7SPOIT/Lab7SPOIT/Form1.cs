using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab7SPOIT
{
    public partial class Form1 : Form
    {
        Dictionary<string, object> dic;
        
        public Form1()
        {
            InitializeComponent();
            dic = new Dictionary<string, object>()
            {
                {"$STATE@CTriangle", RC },
                {"$STATE@UTriangle", RU },
                {"D@FSketch", NumCD },
                {"H@Figure", NumCH },
                {"TS@CSketch", NumCTL },
                {"TS@USketch", NumUPL },
                {"G@CSketch", NumCTD },
                {"G@USketch", NumUTD }
            };

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void SetInfo(EX helper)
        {
            string ProgCol;
            string col;
            string row;
            if (helper.Get("Program", out ProgCol, out row))
            {
                foreach (KeyValuePair<string, object> entry in dic)
                {
                    if (!helper.Get(entry.Key, out col, out row)) { throw new InvalidOperationException(entry.Key); }
                    //MessageBox.Show(row + $" {entry.Key} row", entry.Key.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (entry.Key.Contains("STATE"))
                    {
                        if (((CheckBox)entry.Value).Checked) { helper.Set(Int32.Parse(ProgCol), Int32.Parse(row), "1"); } else { helper.Set(Int32.Parse(ProgCol), Int32.Parse(row), "0"); }
                    }
                    else
                    {
                        helper.Set(Int32.Parse(ProgCol), Int32.Parse(row), ((NumericUpDown)entry.Value).Value.ToString());
                    }
                }
                MessageBox.Show("OK".ToString(), "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                helper.Save();
            }
        }
        private void BTN_Click(object sender, EventArgs e)
        {
            bool Create;
            try
            {
                using (EX helper = new EX())
                {
                    if(helper.Open(filePath: fpath.Text, out Create))
                    {
                        if (!Create)
                        {
                            SetInfo(helper);
                        }
                        else {
                            int col = 2;
                            int row = 1;
                            foreach (KeyValuePair<string, object> entry in dic)
                            {
                               // helper.SetFormula(row, col, ($"=HYPERLINK(\"mailto:{entry.Key}\"; \"{entry.Key}\")"));
                                helper.SetFormula(row, col, entry.Key);
                                col++;

                            }
                            helper.Set(2, 1, "Program");
                            SetInfo(helper);
                        }
                        //helper.Save();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ErrorForm", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void NumCH_ValueChanged(object sender, EventArgs e)
        {
            if(NumCTL.Value>= NumCD.Value|| NumUPL.Value >= NumCD.Value)
            {
                NumCTL.Value = 1;
                NumUPL.Value = 1;
            }
            //MessageBox.Show(NumCTL.Maximum.ToString(), "ErrorGet", MessageBoxButtons.OK, MessageBoxIcon.Error);
            NumCTL.Maximum = NumCD.Value - 1;
            NumUPL.Maximum = NumCD.Value - 1;
        }
    }
}
