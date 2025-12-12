namespace AlgoritmosOrdenamientoo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.Button btnBubble;
        private System.Windows.Forms.Button btnCocktail;
        private System.Windows.Forms.Button btnInsertion;
        private System.Windows.Forms.ListBox lbOriginal;
        private System.Windows.Forms.ListBox lbSorted;
        private System.Windows.Forms.Label lblStats;
        private System.Windows.Forms.Label lblOriginalTitle;
        private System.Windows.Forms.Label lblSortedTitle;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label lblSizeTitle;

        private System.Windows.Forms.Button btnMergeDirecto;
        private System.Windows.Forms.Button btnMergeNatural;
        private System.Windows.Forms.Label lblDivisiones;
        private System.Windows.Forms.Label lblMezclas;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            topPanel = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            lblSizeTitle = new Label();
            nudSize = new NumericUpDown();
            btnBubble = new Button();
            btnCocktail = new Button();
            btnInsertion = new Button();
            btnMergeDirecto = new Button();
            btnMergeNatural = new Button();
            bottomPanel = new Panel();
            lblStats = new Label();
            lblMezclas = new Label();
            lblDivisiones = new Label();
            splitContainer = new SplitContainer();
            lbOriginal = new ListBox();
            lblOriginalTitle = new Label();
            lbSorted = new ListBox();
            lblSortedTitle = new Label();
            button4 = new Button();
            label1 = new Label();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSize).BeginInit();
            bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.WhiteSmoke;
            topPanel.Controls.Add(button3);
            topPanel.Controls.Add(button2);
            topPanel.Controls.Add(button1);
            topPanel.Controls.Add(lblSizeTitle);
            topPanel.Controls.Add(nudSize);
            topPanel.Controls.Add(btnBubble);
            topPanel.Controls.Add(btnCocktail);
            topPanel.Controls.Add(btnInsertion);
            topPanel.Controls.Add(btnMergeDirecto);
            topPanel.Controls.Add(btnMergeNatural);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Padding = new Padding(20);
            topPanel.Size = new Size(1825, 80);
            topPanel.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.SeaGreen;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 9F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1622, 12);
            button3.Name = "button3";
            button3.Size = new Size(180, 54);
            button3.TabIndex = 9;
            button3.Text = "Shell Sort";
            button3.Click += BtnShell_Click;

            button3.UseVisualStyleBackColor = false;
        
            // 
            // button2
            // 
            button2.BackColor = Color.MediumPurple;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 9F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1415, 12);
            button2.Name = "button2";
            button2.Size = new Size(180, 54);
            button2.TabIndex = 8;
            button2.Text = "Heap Sort";
            button2.UseVisualStyleBackColor = false;
            button2.Click += BtnHeapSort_Click;

            // 
            // button1
            // 
            button1.BackColor = Color.SeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 9F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(796, 12);
            button1.Name = "button1";
            button1.Size = new Size(180, 54);
            button1.TabIndex = 0;
            button1.Text = "Selection Sort";
            button1.UseVisualStyleBackColor = false;
            // 
            // lblSizeTitle
            // 
            lblSizeTitle.AutoSize = true;
            lblSizeTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblSizeTitle.Location = new Point(20, 5);
            lblSizeTitle.Name = "lblSizeTitle";
            lblSizeTitle.Size = new Size(166, 23);
            lblSizeTitle.TabIndex = 1;
            lblSizeTitle.Text = "Tamaño del arreglo";
            // 
            // nudSize
            // 
            nudSize.Font = new Font("Microsoft Sans Serif", 10.2F);
            nudSize.Location = new Point(23, 33);
            nudSize.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudSize.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudSize.Name = "nudSize";
            nudSize.Size = new Size(120, 27);
            nudSize.TabIndex = 2;
            nudSize.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnBubble
            // 
            btnBubble.BackColor = Color.DodgerBlue;
            btnBubble.FlatStyle = FlatStyle.Flat;
            btnBubble.Font = new Font("Microsoft Sans Serif", 9F);
            btnBubble.ForeColor = Color.White;
            btnBubble.Location = new Point(191, 12);
            btnBubble.Name = "btnBubble";
            btnBubble.Size = new Size(180, 54);
            btnBubble.TabIndex = 3;
            btnBubble.Text = "Bubble Sort";
            btnBubble.UseVisualStyleBackColor = false;
            btnBubble.Click += BtnBubble_Click;
            // 
            // btnCocktail
            // 
            btnCocktail.BackColor = Color.MediumPurple;
            btnCocktail.FlatStyle = FlatStyle.Flat;
            btnCocktail.Font = new Font("Microsoft Sans Serif", 9F);
            btnCocktail.ForeColor = Color.White;
            btnCocktail.Location = new Point(390, 12);
            btnCocktail.Name = "btnCocktail";
            btnCocktail.Size = new Size(180, 54);
            btnCocktail.TabIndex = 4;
            btnCocktail.Text = "Cocktail Sort";
            btnCocktail.UseVisualStyleBackColor = false;
            btnCocktail.Click += BtnCocktail_Click;
            // 
            // btnInsertion
            // 
            btnInsertion.BackColor = Color.SeaGreen;
            btnInsertion.FlatStyle = FlatStyle.Flat;
            btnInsertion.Font = new Font("Microsoft Sans Serif", 9F);
            btnInsertion.ForeColor = Color.White;
            btnInsertion.Location = new Point(590, 12);
            btnInsertion.Name = "btnInsertion";
            btnInsertion.Size = new Size(180, 54);
            btnInsertion.TabIndex = 5;
            btnInsertion.Text = "Insertion Sort";
            btnInsertion.UseVisualStyleBackColor = false;
            btnInsertion.Click += BtnInsertion_Click;
            // 
            // btnMergeDirecto
            // 
            btnMergeDirecto.BackColor = Color.DarkOrange;
            btnMergeDirecto.FlatStyle = FlatStyle.Flat;
            btnMergeDirecto.Font = new Font("Microsoft Sans Serif", 9F);
            btnMergeDirecto.ForeColor = Color.White;
            btnMergeDirecto.Location = new Point(1010, 12);
            btnMergeDirecto.Name = "btnMergeDirecto";
            btnMergeDirecto.Size = new Size(180, 54);
            btnMergeDirecto.TabIndex = 6;
            btnMergeDirecto.Text = "Merge Sort Directo";
            btnMergeDirecto.UseVisualStyleBackColor = false;
            btnMergeDirecto.Click += BtnMergeDirecto_Click;
            // 
            // btnMergeNatural
            // 
            btnMergeNatural.BackColor = Color.Chocolate;
            btnMergeNatural.FlatStyle = FlatStyle.Flat;
            btnMergeNatural.Font = new Font("Microsoft Sans Serif", 9F);
            btnMergeNatural.ForeColor = Color.White;
            btnMergeNatural.Location = new Point(1210, 12);
            btnMergeNatural.Name = "btnMergeNatural";
            btnMergeNatural.Size = new Size(180, 54);
            btnMergeNatural.TabIndex = 7;
            btnMergeNatural.Text = "Merge Sort Natural";
            btnMergeNatural.UseVisualStyleBackColor = false;
            btnMergeNatural.Click += BtnMergeNatural_Click;
            // 
            // bottomPanel
            // 
            bottomPanel.BackColor = Color.LightYellow;
            bottomPanel.Controls.Add(lblStats);
            bottomPanel.Controls.Add(lblMezclas);
            bottomPanel.Controls.Add(lblDivisiones);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(0, 559);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Padding = new Padding(10);
            bottomPanel.Size = new Size(1825, 180);
            bottomPanel.TabIndex = 1;
            // 
            // lblStats
            // 
            lblStats.Dock = DockStyle.Fill;
            lblStats.Font = new Font("Consolas", 10F, FontStyle.Bold);
            lblStats.Location = new Point(10, 70);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(1805, 100);
            lblStats.TabIndex = 0;
            lblStats.Text = "Estadísticas aparecerán aquí...";
            lblStats.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMezclas
            // 
            lblMezclas.Dock = DockStyle.Top;
            lblMezclas.Font = new Font("Consolas", 10F, FontStyle.Bold);
            lblMezclas.Location = new Point(10, 40);
            lblMezclas.Name = "lblMezclas";
            lblMezclas.Size = new Size(1805, 30);
            lblMezclas.TabIndex = 1;
            lblMezclas.Text = "Mezclas: 0";
            // 
            // lblDivisiones
            // 
            lblDivisiones.Dock = DockStyle.Top;
            lblDivisiones.Font = new Font("Consolas", 10F, FontStyle.Bold);
            lblDivisiones.Location = new Point(10, 10);
            lblDivisiones.Name = "lblDivisiones";
            lblDivisiones.Size = new Size(1805, 30);
            lblDivisiones.TabIndex = 2;
            lblDivisiones.Text = "Divisiones: 0";
            // 
            // splitContainer
            // 
            splitContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            splitContainer.Location = new Point(0, 80);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(lbOriginal);
            splitContainer.Panel1.Controls.Add(lblOriginalTitle);
            splitContainer.Panel1.Padding = new Padding(10);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(lbSorted);
            splitContainer.Panel2.Controls.Add(lblSortedTitle);
            splitContainer.Panel2.Padding = new Padding(10);
            splitContainer.Size = new Size(1452, 479);
            splitContainer.SplitterDistance = 596;
            splitContainer.TabIndex = 0;
            // 
            // lbOriginal
            // 
            lbOriginal.Dock = DockStyle.Fill;
            lbOriginal.Font = new Font("Microsoft Sans Serif", 13.8F);
            lbOriginal.Location = new Point(10, 33);
            lbOriginal.Name = "lbOriginal";
            lbOriginal.Size = new Size(576, 436);
            lbOriginal.TabIndex = 0;
            // 
            // lblOriginalTitle
            // 
            lblOriginalTitle.Dock = DockStyle.Top;
            lblOriginalTitle.Location = new Point(10, 10);
            lblOriginalTitle.Name = "lblOriginalTitle";
            lblOriginalTitle.Size = new Size(576, 23);
            lblOriginalTitle.TabIndex = 1;
            lblOriginalTitle.Text = "Arreglo Original";
            lblOriginalTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbSorted
            // 
            lbSorted.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbSorted.Font = new Font("Microsoft Sans Serif", 13.8F);
            lbSorted.Location = new Point(13, 36);
            lbSorted.Name = "lbSorted";
            lbSorted.Size = new Size(719, 410);
            lbSorted.TabIndex = 0;
            // 
            // lblSortedTitle
            // 
            lblSortedTitle.Dock = DockStyle.Top;
            lblSortedTitle.Location = new Point(10, 10);
            lblSortedTitle.Name = "lblSortedTitle";
            lblSortedTitle.Size = new Size(832, 23);
            lblSortedTitle.TabIndex = 1;
            lblSortedTitle.Text = "Arreglo Ordenado";
            lblSortedTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            button4.BackColor = Color.DodgerBlue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 9F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(1622, 113);
            button4.Name = "button4";
            button4.Size = new Size(180, 54);
            button4.TabIndex = 10;
            button4.Text = "Gnome Sort";
            button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1428, 249);
            label1.Name = "label1";
            label1.Size = new Size(286, 20);
            label1.TabIndex = 10;
            label1.Text = "Algoritmos no basados en comparación";
            // 
            // button5
            // 
            button5.BackColor = Color.Chocolate;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 9F);
            button5.ForeColor = Color.White;
            button5.Location = new Point(1458, 296);
            button5.Name = "button5";
            button5.Size = new Size(180, 54);
            button5.TabIndex = 10;
            button5.Text = "Counting Sort";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.MediumPurple;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 9F);
            button6.ForeColor = Color.White;
            button6.Location = new Point(1458, 384);
            button6.Name = "button6";
            button6.Size = new Size(180, 54);
            button6.TabIndex = 10;
            button6.Text = "Bucket Sort";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.SeaGreen;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Microsoft Sans Serif", 9F);
            button7.ForeColor = Color.White;
            button7.Location = new Point(1458, 472);
            button7.Name = "button7";
            button7.Size = new Size(180, 54);
            button7.TabIndex = 10;
            button7.Text = "Radix Sort";
            button7.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            ClientSize = new Size(1825, 739);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(splitContainer);
            Controls.Add(bottomPanel);
            Controls.Add(topPanel);
            Name = "Form1";
            Text = "Tester de Algoritmos";
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSize).EndInit();
            bottomPanel.ResumeLayout(false);
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button3;
        private Button button2;
        private Button button4;
        private Label label1;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}

