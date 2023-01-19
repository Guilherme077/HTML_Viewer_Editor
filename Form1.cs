using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SCMCS
{
    public partial class Menu : Form
    {
        int UltimoAcessoFile = 0;
        bool loaded = false;
        private bool mover;
        private int cX, cY;
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        //JANELA
        private void Menu_Load(object sender, EventArgs e)
        {
            AtualizaWindow(); // Atualiza as cores ao iniciar
            AbrirInicio();
            loaded = true;
            
        }
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.UltimoDiretorio = DirectoryName.Text;

            Properties.Settings.Default.DistSplitter = splitContainer1.SplitterDistance;
            //Properties.Settings.Default.SizeWindow = ActiveForm.Size;
            //Properties.Settings.Default.Maximized = ActiveForm.MaximizeBox;


            Properties.Settings.Default.Save(); // Salva as configurações
            
            
        }

        //FILE
        private void abrirArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirArquivo.ShowDialog(); // Abre caixa de dialogo para encontrar o arquivo
            DirectoryName.Text = AbrirArquivo.FileName;
            try
            {


                using (StreamReader file = File.OpenText(AbrirArquivo.FileName)) // Encontra
                {
                    TextFile.Text = file.ReadToEnd();
                    file.Close();
                }
                UltimoAcessoFile = 1;
                IconSaveN.Visible = false;
            }
            catch
            {
                MessageBox.Show("The file cant be opened!");
            }


        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalvarArquivo.ShowDialog();
            
            
            
            if (SalvarArquivo.CheckFileExists == false)
            {
                try
                {
                    File.Create(SalvarArquivo.FileName);
                    DirectoryName.Text = SalvarArquivo.FileName;
                    
                }
                catch
                {
                    MessageBox.Show("The file cant be saved!");
                }
                
            }
            
                DirectoryName.Text = SalvarArquivo.FileName;
                using (FileStream file = File.Open(SalvarArquivo.FileName, FileMode.Truncate))
                {


                    StreamWriter sw = new StreamWriter(file);
                    foreach (string linha in TextFile.Lines)
                    {
                        sw.WriteLine(linha);
                    }
                    DirectoryName.Text = SalvarArquivo.FileName;
                    sw.Close();
                    file.Close();
                    IconSaveN.Visible = false;
                    UltimoAcessoFile = 1;
                    
                    //MessageBox("Arquivo ")
                }
            
        }

        private void salvarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (UltimoAcessoFile == 0)
            {
                MessageBox.Show("Não há diretório existente, utilize 'Salvar como' ou 'Abrir arquivo'");
            }
            if (UltimoAcessoFile == 1)
            {
                try
                {
                    using (FileStream file = File.Open(DirectoryName.Text, FileMode.Truncate))
                    {
                        StreamWriter sw = new StreamWriter(file);
                        foreach (string linha in TextFile.Lines)
                        {
                            sw.WriteLine(linha);
                        }
                        sw.Close();
                        file.Close();
                        IconSaveN.Visible = false;

                    }
                }
                catch
                {
                    MessageBox.Show("The file cant be saved!");
                }
                
            }
        }
        //OUTROS
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
           
        }
        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }
        private void TextFile_TextChanged(object sender, EventArgs e)
        {
            IconSaveN.Visible = true;

            if (UltimoAcessoFile == 1)
            {
                try
                {
                    using (FileStream file = File.Open(DirectoryName.Text, FileMode.Truncate))
                    {
                        StreamWriter sw = new StreamWriter(file);
                        foreach (string linha in TextFile.Lines)
                        {
                            sw.WriteLine(linha);
                        }
                        sw.Close();
                        file.Close();
                        IconSaveN.Visible = false;
                        
                    }
                }
                catch
                {
                    //MessageBox.Show("The file cant be saved!");
                }
                ReloadWebNav();
            }

        }
        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }
        //TEXT
        private void fundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectColor.ShowDialog(); // Pergunta a cor ao usuário
            Properties.Settings.Default.CorDeFundo = SelectColor.Color; // Seta a cor conforme citado na chamada do void
            AtualizaWindow(); // Atualiza as cores da janela e salva
        }
        private void letrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectColor.ShowDialog(); // Pergunta a cor ao usuário
            Properties.Settings.Default.CorDoTexto = SelectColor.Color; // Seta a cor conforme citado na chamada do void
            AtualizaWindow(); // Atualiza as cores da janela e salva
        }
        //ROTINAS
        public void AtualizaWindow()
        {
            Properties.Settings.Default.Save(); // Salva as configurações
            TextFile.BackColor = Properties.Settings.Default.CorDeFundo; // Seta a cor de fundo
            TextFile.ForeColor = Properties.Settings.Default.CorDoTexto; // Seta a cor do texto
            TextFile.Font = Properties.Settings.Default.Fonte;
            splitContainer1.SplitterDistance = Properties.Settings.Default.DistSplitter;

            

            
            
            //ActiveForm.mi = Properties.Settings.Default.Maximized;



        }

        public void AbrirInicio()
        {
            //AbrirArquivo.ShowDialog(); // Abre caixa de dialogo para encontrar o arquivo
            //DirectoryName.Text = AbrirArquivo.FileName;
            if(Properties.Settings.Default.UltimoDiretorio == null || File.Exists(Properties.Settings.Default.UltimoDiretorio))
            {
                DirectoryName.Text = Properties.Settings.Default.UltimoDiretorio;
                using (StreamReader file = File.OpenText(Properties.Settings.Default.UltimoDiretorio)) // Encontra
                {
                    TextFile.Text = file.ReadToEnd();
                    file.Close();
                }
                UltimoAcessoFile = 1;
                IconSaveN.Visible = false;
            }
            else
            {
                MessageBox.Show("The last file opened in the program cant be opened. File: " + Properties.Settings.Default.UltimoDiretorio);
            }
            
        }

        private void fontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectFont.ShowDialog();
            //TextFile.Font = SelectFont.Font;
            Properties.Settings.Default.Fonte = SelectFont.Font;
            AtualizaWindow();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_ResizeEnd(object sender, EventArgs e)
        {
            //TextFile.Width = ActiveForm.Width/2 - 8;
            
            //groupBox1.Width = ActiveForm.Width/2 - 8;

        }

        private void Menu_Resize(object sender, EventArgs e)
        {

        }

        private void Menu_SizeChanged(object sender, EventArgs e)
        {
            //if (loaded)
            //{
               
             //  TextFile.Width = ActiveForm.Width / 2 - 8;
            //   groupBox1.Width = ActiveForm.Width / 2 - 8;
            //}
            
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            // TextFile.Visible = true;
            //ActiveForm.Size = Properties.Settings.Default.SizeWindow;
        }

        private void Menu_Move(object sender, EventArgs e)
        {
            
        }

        private void Menu_ResizeBegin(object sender, EventArgs e)
        {
            //WebNav.Visible = false;
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ReloadWebNav();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About FormAbout = new About();
            FormAbout.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void WebNav_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        private void ReloadWebNav()
        {
            WebNav.Navigate(DirectoryName.Text);
            
            
        }

        private void WebNav_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            groupBox1.Text = WebNav.DocumentTitle;
        }

        private void splitter1_SplitterMoving(object sender, SplitterEventArgs e)
        {
            //groupBox1.Visible = false;
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            //groupBox1.Visible = true;
           // groupBox1.Width = ActiveForm.Width - TextFile.Width - 9;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void browserAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Browser version: " + "Internet Explorer " + WebNav.Version);
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            Menu menu = (Menu)ActiveForm;
            menu.Close();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Menu menu = (Menu)ActiveForm;
            menu.WindowState = FormWindowState.Maximized;
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            Menu menu = (Menu)ActiveForm;
            menu.WindowState = FormWindowState.Minimized;
        }




        //MOVER JANELA


        

        

        private void Menu_MouseDown_1(object sender, MouseEventArgs e)
        {
            
                if (e.Button == MouseButtons.Left)
                {
                    cX = e.X;
                    cY = e.Y;
                    mover = true;
                }
            
        }

        private void Menu_MouseUp_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mover = false;
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // printDialog1.Document = DirectoryName.Text;
            //printDialog1.ShowDialog();
            
        }

        private void Menu_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Menu menu = (Menu)ActiveForm;
                this.Left += e.X - (cX - menu.Left);
                this.Top += e.Y - (cY - menu.Top);
            }
        }

      


    }


    

}
