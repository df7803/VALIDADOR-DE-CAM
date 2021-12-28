﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Xml;


namespace CAM
{
    

    public partial class Form1 : Form
    {
        
       
        public Form1()
        {
            InitializeComponent();
        }
        private string a = "trumph-Geo files (*.GEO) |*.geo";
        private string b = @"Y:\004 - ENGENHARIA\06 - CAM";
        private string c = "planilha Excel files (*.excel) |*.xls";


        


        private void button2_Click_1(object sender, EventArgs e)
        {
            button2.Text = MessageBox.Show("pre requisitos- Planilha OSFA  ".ToUpper() + "\n" +
           " 1_ o nome  do arquivo OSFA precisa ser igual ao nome" +
           "do programa normalmente  e so remover o terceiro digito (-)" + "\n" + "\n" +
           " Remover a coluna tipo.".ToUpper() + "\n" + "2_ Remover  o L antes do material usando somente na laser" + "\n" +
              "\n" + "\n" +
           "LEGENDA DE CORES" + "\n" + "3_ Vermelho = Revisão diferente ou não existe no programa/ peça" + "\n" +
           "azul Quantidade diferente").ToString();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LblESCOLHA_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = b;
            openFileDialog.Filter = c;                  /*ctrl + K + c*/
            

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //System.Diagnostics.Process.Start(openFileDialog.FileName);
                label1.Text = openFileDialog.SafeFileName;
                label1.BackColor = Color.Yellow;
                // MessageBox.Show("arquivo existe");
                //System.Diagnostics.Process.Start(openFileDialog.FileName);  //abre o arquivo selecionado

            }
            else
            {
                label1.BackColor = Color.Red;
                button1.BackColor = Color.Blue;
                button2.BackColor = Color.Green;
              
            }
        }
        public void label1_load(object sender, EventArgs e)
        {
            string excel = label1.Text;
            Random random = new Random();




        }

        private void CBTC2020_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void CBTC1000_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CBTL1030_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Manual_Click(object sender, EventArgs e)
        {
            //abre um arquivo
            OpenFileDialog openFileDialog3 = new OpenFileDialog();
            openFileDialog3.InitialDirectory = @"Y:\004 - ENGENHARIA\06 - CAM";
            openFileDialog3.Filter = "planilha Excel files (*.excel) |*.xls";
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                //System.Diagnostics.Process.Start(openFileDialog.FileName);
                label1.Text = openFileDialog3.SafeFileName;
                label1.BackColor = Color.Yellow;
            }
            else label1.BackColor = Color.Red;
        }
        private void button4_Click(object sender, EventArgs e)  //onde estão os arquivos
        {
            // abre uma pasta 
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = b;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                label3.Text = folderBrowserDialog.SelectedPath;
                
               
            }
            else
            {
                return;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string leitor = label1.Text;

            if (File.Exists(leitor))
            {
                    string[] array = File.ReadAllLines(leitor);
                    foreach (var item in array)
                    {
                        
                    }
 
            }
        }
        private void GEO_CheckedChanged(object sender, EventArgs e)
        {
          if (GEO.Checked == true)
            {
                //seleciona o tipo de arquivo que vai ser executado no check .geo

                OpenFileDialog openFileDialog4 = new OpenFileDialog();              
                openFileDialog4.FileName = "trumph-Geo files (*.GEO) | *.geo";
            }
        }
        private void DXF_CheckedChanged(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog5 = new OpenFileDialog();
            openFileDialog5.FileName = "trumph-Geo files (*.dxf) | *.dxf";
        }
        private void GMT_CheckedChanged(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog6 = new OpenFileDialog();
            openFileDialog6.FileName = "trumph-Geo files (*.gmt) | *.gmt";
        }
        private void LST_CheckedChanged(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog7 = new OpenFileDialog();
            openFileDialog7.FileName = "trumph-Geo files (*.lst) | *.lst";
        }
        private void button5_SaveToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog salveLocal = new SaveFileDialog();
            salveLocal.InitialDirectory = b;
            salveLocal.Filter = c;
            salveLocal.FileName = label1.Text;
            

            
            if (salveLocal.ShowDialog() == DialogResult.OK)
            {
                label4.Text = salveLocal.FileName;
                label4.Visible = salveLocal.OverwritePrompt;
                MessageBox.Show("Salvo com sucesso");
                //Stream arquivo = File.Create(label4.Text); // cria um excel e não salva
                
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {
           
        }
      
    }
}
