using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
	public class MetodosComunes
	{
		public static bool ValidarDecimal(TextBox CajaDeTexto)
		{
			try
			{
				decimal d = Convert.ToDecimal(CajaDeTexto.Text);
				return true;
			}

			catch (Exception ex)
			{
				CajaDeTexto.Text = "0";
				CajaDeTexto.Select(0, CajaDeTexto.Text.Length);
				return false;
			}
		}
	}
}
