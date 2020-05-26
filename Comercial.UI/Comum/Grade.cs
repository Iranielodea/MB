using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercial.UI.Comum
{
    public static class Grade
    {
        public static void Configurar(ref DataGridView grid)
        {
            grid.AutoGenerateColumns = false;
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.RowsDefaultCellStyle.BackColor = Color.Gray;
            grid.RowsDefaultCellStyle.ForeColor = Color.Black;
            grid.RowsDefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            grid.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        public static int RetornarId(ref DataGridView grid, string id)
        {
            if (grid.RowCount > 0)
                return Convert.ToInt32(grid.CurrentRow.Cells[id].Value.ToString());
            else
                return 0;
        }

        public static List<string> ListarCampos(ref DataGridView grid)
        {
            var lista = new List<string>();
            for(int i = 0; i < grid.Columns.Count; i++)
            {
                if (grid.Columns[i].Visible)
                    lista.Add(grid.Columns[i].HeaderText);
            }
            return lista;
        }

        public static string BuscarCampo(ref DataGridView grid, string campo)
        {
            string resultado = "";
            for (int i = 0; i < grid.Columns.Count; i++)
            {
                if(grid.Columns[i].HeaderText == campo)
                {
                    resultado = grid.Columns[i].DataPropertyName;
                }
            }
            if (resultado == "")
                resultado = grid.Columns[0].DataPropertyName;
            return resultado;
        }
    }
}
