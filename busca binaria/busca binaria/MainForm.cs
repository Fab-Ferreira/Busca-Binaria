using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace busca_binaria
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			list.LoadFile("numeros.txt", RichTextBoxStreamType.PlainText); //Iniciar o MainForm carregando a lista dentro do RichTextBox
		}
		
		//Variáveis
		int meio, primeiro, ultimo, num;
		string[] line;
		
		void SearchClick(object sender, EventArgs e)
		{
			try
			{
				num = int.Parse(number.Text); //"num" recebe como int o texto digitado de "number"
				line = list.Lines; //"line" recebe o texto das linhas da RichTextBox 
				primeiro = 0;
				ultimo = list.Lines.Length; //"ultimo" recebe a quantidade de linhas da RichTextBox
				meio = (primeiro + ultimo)/2;
				
				if(int.Parse(line[ultimo - 1]) >= num) //Se o valor da última posição for maior ou igual que "num"
				{	
					while(int.Parse(line[meio]) != num) //Enquanto o texto de uma linha for diferente de "num"
					{
						meio = (primeiro + ultimo)/2;
			
						if(int.Parse(line[meio]) == num) //Se o texto de uma linha for igual ao "num"
						{
							texto.Text = "Encontrado!";
							position.Text = ("Posição: " + (meio + 1));
						}
					
						else if(int.Parse(line[meio]) > num) //Senão, se o texto de uma linha for maior que "num"
						{
							ultimo = meio - 1;
						}
					
						else if(int.Parse(line[meio]) < num) //Senão, se o texto de uma linha for menor que "num"
						{
							primeiro = meio + 1;
						}
					
						if(primeiro > ultimo) //Se o valor primeiro número da lista for maior que o valor do último número da lista
						{
							num = int.Parse(line[meio]);
						
							texto.Text = "Não foi possível localizar o número solicitado.";
							position.Text = "Posição: Inválido";
						}
					}
				}
				else //Se o valor da última posição for menor que "num"
				{
					texto.Text = "Não foi possível localizar o número solicitado.";
					position.Text = "Posição: Inválido";
				}
			}
			
			catch(FormatException erro)
			{
				MessageBox.Show("Erro: " + erro.Message + " (TextBox contendo letras, caracteres especiais ou vazia)");
			}
		}
	}
}
