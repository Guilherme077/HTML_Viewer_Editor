
namespace SCMCS
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.AbrirArquivo = new System.Windows.Forms.OpenFileDialog();
            this.TextFile = new System.Windows.Forms.TextBox();
            this.SalvarArquivo = new System.Windows.Forms.SaveFileDialog();
            this.CriarArquivo = new System.Windows.Forms.SaveFileDialog();
            this.SelectColor = new System.Windows.Forms.ColorDialog();
            this.SelectFont = new System.Windows.Forms.FontDialog();
            this.WebNav = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.abrirArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.coresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fundoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.letrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ASBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.OnAS = new System.Windows.Forms.ToolStripMenuItem();
            this.OffAS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.supportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browserAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IconSaveN = new System.Windows.Forms.ToolStripLabel();
            this.DirectoryName = new System.Windows.Forms.ToolStripLabel();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redefinirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AbrirArquivo
            // 
            this.AbrirArquivo.FileName = "openFileDialog1";
            // 
            // TextFile
            // 
            this.TextFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextFile.ForeColor = System.Drawing.Color.White;
            this.TextFile.Location = new System.Drawing.Point(0, 0);
            this.TextFile.Multiline = true;
            this.TextFile.Name = "TextFile";
            this.TextFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextFile.Size = new System.Drawing.Size(550, 526);
            this.TextFile.TabIndex = 0;
            this.TextFile.TextChanged += new System.EventHandler(this.TextFile_TextChanged);
            // 
            // SalvarArquivo
            // 
            this.SalvarArquivo.DefaultExt = "html";
            this.SalvarArquivo.Filter = "Arquivos de internet (*.html)|";
            this.SalvarArquivo.Title = "Salvar como...";
            // 
            // SelectColor
            // 
            this.SelectColor.Color = System.Drawing.Color.DimGray;
            // 
            // SelectFont
            // 
            this.SelectFont.AllowVerticalFonts = false;
            this.SelectFont.ShowApply = true;
            // 
            // WebNav
            // 
            this.WebNav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebNav.Location = new System.Drawing.Point(3, 23);
            this.WebNav.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebNav.Name = "WebNav";
            this.WebNav.Size = new System.Drawing.Size(422, 500);
            this.WebNav.TabIndex = 0;
            this.WebNav.Url = new System.Uri("", System.UriKind.Relative);
            this.WebNav.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebNav_DocumentCompleted);
            this.WebNav.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.WebNav_Navigated);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WebNav);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 526);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Title of HTML script";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TextFile);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(982, 526);
            this.splitContainer1.SplitterDistance = 550;
            this.splitContainer1.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.toolStrip1.BackgroundImage = global::SCMCS.Properties.Resources.LinhaHTMLVE;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton3,
            this.toolStripDropDownButton2,
            this.IconSaveN,
            this.DirectoryName});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(982, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.abrirArquivoToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.salvarToolStripMenuItem1,
            this.toolStripSeparator1,
            this.imprimirToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.MintCream;
            this.toolStripDropDownButton1.Image = global::SCMCS.Properties.Resources.OpenIcon;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "File";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // abrirArquivoToolStripMenuItem
            // 
            this.abrirArquivoToolStripMenuItem.Name = "abrirArquivoToolStripMenuItem";
            this.abrirArquivoToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.abrirArquivoToolStripMenuItem.Text = "Open file";
            this.abrirArquivoToolStripMenuItem.Click += new System.EventHandler(this.abrirArquivoToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.salvarToolStripMenuItem.Text = "Save as";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem1
            // 
            this.salvarToolStripMenuItem1.Name = "salvarToolStripMenuItem1";
            this.salvarToolStripMenuItem1.ShortcutKeyDisplayString = "Ctrl + S";
            this.salvarToolStripMenuItem1.Size = new System.Drawing.Size(224, 28);
            this.salvarToolStripMenuItem1.Text = "Save";
            this.salvarToolStripMenuItem1.Click += new System.EventHandler(this.salvarToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.imprimirToolStripMenuItem.Text = "Print";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coresToolStripMenuItem,
            this.fontSizeToolStripMenuItem,
            this.toolStripSeparator2,
            this.ASBtn,
            this.toolStripSeparator3,
            this.redefinirToolStripMenuItem});
            this.toolStripDropDownButton3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton3.Image = global::SCMCS.Properties.Resources.TextIcon;
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton3.Text = "Text";
            // 
            // coresToolStripMenuItem
            // 
            this.coresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fundoToolStripMenuItem,
            this.letrasToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.coresToolStripMenuItem.Name = "coresToolStripMenuItem";
            this.coresToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.coresToolStripMenuItem.Text = "Colors";
            // 
            // fundoToolStripMenuItem
            // 
            this.fundoToolStripMenuItem.Name = "fundoToolStripMenuItem";
            this.fundoToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.fundoToolStripMenuItem.Text = "Backcolor";
            this.fundoToolStripMenuItem.Click += new System.EventHandler(this.fundoToolStripMenuItem_Click);
            // 
            // letrasToolStripMenuItem
            // 
            this.letrasToolStripMenuItem.Name = "letrasToolStripMenuItem";
            this.letrasToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.letrasToolStripMenuItem.Text = "Text";
            this.letrasToolStripMenuItem.Click += new System.EventHandler(this.letrasToolStripMenuItem_Click);
            // 
            // fontSizeToolStripMenuItem
            // 
            this.fontSizeToolStripMenuItem.Name = "fontSizeToolStripMenuItem";
            this.fontSizeToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.fontSizeToolStripMenuItem.Text = "Font settings";
            this.fontSizeToolStripMenuItem.Click += new System.EventHandler(this.fontSizeToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // ASBtn
            // 
            this.ASBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OnAS,
            this.OffAS});
            this.ASBtn.Name = "ASBtn";
            this.ASBtn.Size = new System.Drawing.Size(224, 28);
            this.ASBtn.Text = "Auto Save (ON)";
            // 
            // OnAS
            // 
            this.OnAS.Name = "OnAS";
            this.OnAS.Size = new System.Drawing.Size(117, 28);
            this.OnAS.Text = "On";
            this.OnAS.Click += new System.EventHandler(this.OnAS_Click);
            // 
            // OffAS
            // 
            this.OffAS.Name = "OffAS";
            this.OffAS.Size = new System.Drawing.Size(117, 28);
            this.OffAS.Text = "Off";
            this.OffAS.Click += new System.EventHandler(this.OffAS_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supportToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.browserAboutToolStripMenuItem});
            this.toolStripDropDownButton2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDropDownButton2.Image = global::SCMCS.Properties.Resources.HelpIcon;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton2.Text = "Help";
            // 
            // supportToolStripMenuItem
            // 
            this.supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            this.supportToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.supportToolStripMenuItem.Text = "Support";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // browserAboutToolStripMenuItem
            // 
            this.browserAboutToolStripMenuItem.Name = "browserAboutToolStripMenuItem";
            this.browserAboutToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.browserAboutToolStripMenuItem.Text = "Browser About";
            this.browserAboutToolStripMenuItem.Click += new System.EventHandler(this.browserAboutToolStripMenuItem_Click);
            // 
            // IconSaveN
            // 
            this.IconSaveN.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.IconSaveN.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconSaveN.Name = "IconSaveN";
            this.IconSaveN.Size = new System.Drawing.Size(17, 24);
            this.IconSaveN.Text = "*";
            // 
            // DirectoryName
            // 
            this.DirectoryName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.DirectoryName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectoryName.Name = "DirectoryName";
            this.DirectoryName.Size = new System.Drawing.Size(0, 24);
            this.DirectoryName.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.newToolStripMenuItem.Text = "New";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.windowToolStripMenuItem.Text = "Window";
            this.windowToolStripMenuItem.Click += new System.EventHandler(this.windowToolStripMenuItem_Click);
            // 
            // redefinirToolStripMenuItem
            // 
            this.redefinirToolStripMenuItem.Name = "redefinirToolStripMenuItem";
            this.redefinirToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.redefinirToolStripMenuItem.Text = "Redefinir ";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(221, 6);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "HTML Viewer Editor 2023 - Personal Edition";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResizeBegin += new System.EventHandler(this.Menu_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.Menu_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Menu_SizeChanged);
            this.Click += new System.EventHandler(this.Menu_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseDown_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseMove_1);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Menu_MouseUp_1);
            this.Move += new System.EventHandler(this.Menu_Move);
            this.Resize += new System.EventHandler(this.Menu_Resize);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem abrirArquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.OpenFileDialog AbrirArquivo;
        private System.Windows.Forms.TextBox TextFile;
        private System.Windows.Forms.SaveFileDialog SalvarArquivo;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog CriarArquivo;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripLabel DirectoryName;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem coresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fundoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem letrasToolStripMenuItem;
        private System.Windows.Forms.ColorDialog SelectColor;
        private System.Windows.Forms.ToolStripLabel IconSaveN;
        private System.Windows.Forms.ToolStripMenuItem fontSizeToolStripMenuItem;
        private System.Windows.Forms.FontDialog SelectFont;
        private System.Windows.Forms.WebBrowser WebNav;
        private System.Windows.Forms.ToolStripMenuItem supportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem browserAboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ASBtn;
        private System.Windows.Forms.ToolStripMenuItem OnAS;
        private System.Windows.Forms.ToolStripMenuItem OffAS;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem redefinirToolStripMenuItem;
    }
}

