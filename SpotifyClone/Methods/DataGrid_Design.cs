using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SpotifyClone.dbConn;
using SpotifyClone.PocosLayer;
using SpotifyClone.PresentationLayer.UserEntry;
using System.Media;
using SpotifyClone.BuisnessLogicLayer;

namespace SpotifyClone.Methods
{
    class DataGrid_Design
    {
        public void SetFontAndColors(DataGridView dataGridView1)
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Dank Mono", 8);
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black; // Text color
            dataGridView1.DefaultCellStyle.BackColor = Color.White; // Cell background color
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White; // Selected text color
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Gray; // Selected cell background color

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Dank Mono", 8);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Gray;

            dataGridView1.EnableHeadersVisualStyles = false;
        }
    }
}
