/*
 * Created by SharpDevelop.
 * User: fabri
 * Date: 29/04/2022
 * Time: 00:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace busca_binaria
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox list;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button search;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox number;
		private System.Windows.Forms.Label texto;
		private System.Windows.Forms.Label position;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.list = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.search = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.number = new System.Windows.Forms.TextBox();
			this.texto = new System.Windows.Forms.Label();
			this.position = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(193, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(255, 35);
			this.label1.TabIndex = 0;
			this.label1.Text = "BUSCA BINÁRIA";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// list
			// 
			this.list.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.list.Location = new System.Drawing.Point(12, 90);
			this.list.Name = "list";
			this.list.Size = new System.Drawing.Size(216, 371);
			this.list.TabIndex = 1;
			this.list.Text = "";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(77, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 30);
			this.label2.TabIndex = 2;
			this.label2.Text = "Lista";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// search
			// 
			this.search.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.search.Location = new System.Drawing.Point(323, 171);
			this.search.Name = "search";
			this.search.Size = new System.Drawing.Size(241, 39);
			this.search.TabIndex = 3;
			this.search.Text = "Procurar Número";
			this.search.UseVisualStyleBackColor = true;
			this.search.Click += new System.EventHandler(this.SearchClick);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(243, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(387, 30);
			this.label3.TabIndex = 4;
			this.label3.Text = "Número a ser pesquisado:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// number
			// 
			this.number.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.number.Location = new System.Drawing.Point(491, 108);
			this.number.Name = "number";
			this.number.Size = new System.Drawing.Size(123, 30);
			this.number.TabIndex = 5;
			this.number.Text = "0";
			this.number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// texto
			// 
			this.texto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.texto.Location = new System.Drawing.Point(248, 246);
			this.texto.Name = "texto";
			this.texto.Size = new System.Drawing.Size(382, 30);
			this.texto.TabIndex = 7;
			this.texto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// position
			// 
			this.position.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.position.Location = new System.Drawing.Point(248, 301);
			this.position.Name = "position";
			this.position.Size = new System.Drawing.Size(234, 30);
			this.position.TabIndex = 8;
			this.position.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(642, 473);
			this.Controls.Add(this.position);
			this.Controls.Add(this.texto);
			this.Controls.Add(this.number);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.search);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.list);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "busca binaria";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
