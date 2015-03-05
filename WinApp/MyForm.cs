using MyLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace WinApp
{
	public partial class MyForm : Form
	{
		public MyForm()
		{
			InitializeComponent();
		}

		private void btnGetConnString_Click(object sender, EventArgs e)
		{
			Helper h = new Helper();
			var t = h.MyLibTest();
			MessageBox.Show(t, "Warning !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			lblStatus.Text = "OK";
		}
	}
}
