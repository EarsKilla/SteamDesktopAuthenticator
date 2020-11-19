﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steam_Desktop_Authenticator {
	public partial class ListInputForm : Form {
		public ListInputForm(List<string> options) {
			Items = options;
			InitializeComponent();
		}

		public int SelectedIndex;
		readonly List<string> Items;

		private void ListInputForm_Load(object sender, EventArgs e) {
			foreach (string item in Items) {
				lbItems.Items.Add(item);
			}
		}

		private void BtnAccept_Click(object sender, EventArgs e) {
			if (lbItems.SelectedIndex != -1) {
				SelectedIndex = lbItems.SelectedIndex;
				Close();
			}
		}

		private void BtnCancel_Click(object sender, EventArgs e) => Close();
	}
}
