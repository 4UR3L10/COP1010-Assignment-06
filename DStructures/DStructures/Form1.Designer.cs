namespace DStructures
{
    partial class FormDataStructures
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataStructures));
            this.labelAmountOfNumbers = new System.Windows.Forms.Label();
            this.textBoxNumbers = new System.Windows.Forms.TextBox();
            this.labelOriginalList = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.listBoxOriginalList = new System.Windows.Forms.ListBox();
            this.listBoxSortedList = new System.Windows.Forms.ListBox();
            this.labelSortedList = new System.Windows.Forms.Label();
            this.buttonShowValues = new System.Windows.Forms.Button();
            this.buttonOrderList = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.imageListCards = new System.Windows.Forms.ImageList(this.components);
            this.pictureBoxPrevious = new System.Windows.Forms.PictureBox();
            this.pictureBoxNext = new System.Windows.Forms.PictureBox();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAmountOfNumbers
            // 
            this.labelAmountOfNumbers.AutoSize = true;
            this.labelAmountOfNumbers.Location = new System.Drawing.Point(7, 9);
            this.labelAmountOfNumbers.Name = "labelAmountOfNumbers";
            this.labelAmountOfNumbers.Size = new System.Drawing.Size(157, 20);
            this.labelAmountOfNumbers.TabIndex = 0;
            this.labelAmountOfNumbers.Text = "How many numbers :";
            // 
            // textBoxNumbers
            // 
            this.textBoxNumbers.Location = new System.Drawing.Point(186, 6);
            this.textBoxNumbers.Name = "textBoxNumbers";
            this.textBoxNumbers.Size = new System.Drawing.Size(236, 26);
            this.textBoxNumbers.TabIndex = 1;
            this.textBoxNumbers.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelOriginalList
            // 
            this.labelOriginalList.AutoSize = true;
            this.labelOriginalList.Location = new System.Drawing.Point(66, 38);
            this.labelOriginalList.Name = "labelOriginalList";
            this.labelOriginalList.Size = new System.Drawing.Size(91, 20);
            this.labelOriginalList.TabIndex = 6;
            this.labelOriginalList.Text = "Original List";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(643, 75);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(137, 62);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "&Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // listBoxOriginalList
            // 
            this.listBoxOriginalList.FormattingEnabled = true;
            this.listBoxOriginalList.ItemHeight = 20;
            this.listBoxOriginalList.Location = new System.Drawing.Point(28, 75);
            this.listBoxOriginalList.Name = "listBoxOriginalList";
            this.listBoxOriginalList.Size = new System.Drawing.Size(162, 204);
            this.listBoxOriginalList.TabIndex = 8;
            // 
            // listBoxSortedList
            // 
            this.listBoxSortedList.FormattingEnabled = true;
            this.listBoxSortedList.ItemHeight = 20;
            this.listBoxSortedList.Location = new System.Drawing.Point(333, 75);
            this.listBoxSortedList.Name = "listBoxSortedList";
            this.listBoxSortedList.Size = new System.Drawing.Size(190, 204);
            this.listBoxSortedList.TabIndex = 9;
            // 
            // labelSortedList
            // 
            this.labelSortedList.AutoSize = true;
            this.labelSortedList.Location = new System.Drawing.Point(371, 38);
            this.labelSortedList.Name = "labelSortedList";
            this.labelSortedList.Size = new System.Drawing.Size(86, 20);
            this.labelSortedList.TabIndex = 7;
            this.labelSortedList.Text = "Sorted List";
            // 
            // buttonShowValues
            // 
            this.buttonShowValues.Enabled = false;
            this.buttonShowValues.Location = new System.Drawing.Point(50, 309);
            this.buttonShowValues.Name = "buttonShowValues";
            this.buttonShowValues.Size = new System.Drawing.Size(120, 39);
            this.buttonShowValues.TabIndex = 2;
            this.buttonShowValues.Text = "&Show Values";
            this.buttonShowValues.UseVisualStyleBackColor = true;
            this.buttonShowValues.Click += new System.EventHandler(this.buttonShowValues_Click);
            // 
            // buttonOrderList
            // 
            this.buttonOrderList.Enabled = false;
            this.buttonOrderList.Location = new System.Drawing.Point(366, 309);
            this.buttonOrderList.Name = "buttonOrderList";
            this.buttonOrderList.Size = new System.Drawing.Size(91, 38);
            this.buttonOrderList.TabIndex = 3;
            this.buttonOrderList.Text = "&OrderList";
            this.buttonOrderList.UseVisualStyleBackColor = true;
            this.buttonOrderList.Click += new System.EventHandler(this.buttonOrderList_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(643, 209);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(137, 55);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "&Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // imageListCards
            // 
            this.imageListCards.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListCards.ImageStream")));
            this.imageListCards.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListCards.Images.SetKeyName(0, "Yugioh-01.jpg");
            this.imageListCards.Images.SetKeyName(1, "Yugioh-02.jpg");
            this.imageListCards.Images.SetKeyName(2, "Yugioh-03.jpg");
            this.imageListCards.Images.SetKeyName(3, "Yugioh-04.jpg");
            this.imageListCards.Images.SetKeyName(4, "Yugioh-05.jpg");
            this.imageListCards.Images.SetKeyName(5, "Yugioh-06.jpg");
            this.imageListCards.Images.SetKeyName(6, "Yugioh-07.jpg");
            // 
            // pictureBoxPrevious
            // 
            this.pictureBoxPrevious.Location = new System.Drawing.Point(28, 353);
            this.pictureBoxPrevious.Name = "pictureBoxPrevious";
            this.pictureBoxPrevious.Size = new System.Drawing.Size(246, 247);
            this.pictureBoxPrevious.TabIndex = 10;
            this.pictureBoxPrevious.TabStop = false;
            // 
            // pictureBoxNext
            // 
            this.pictureBoxNext.Location = new System.Drawing.Point(333, 353);
            this.pictureBoxNext.Name = "pictureBoxNext";
            this.pictureBoxNext.Size = new System.Drawing.Size(257, 247);
            this.pictureBoxNext.TabIndex = 11;
            this.pictureBoxNext.TabStop = false;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(50, 606);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(120, 54);
            this.buttonPrevious.TabIndex = 12;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(366, 606);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(91, 54);
            this.buttonNext.TabIndex = 13;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // FormDataStructures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 1046);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.pictureBoxNext);
            this.Controls.Add(this.pictureBoxPrevious);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonOrderList);
            this.Controls.Add(this.buttonShowValues);
            this.Controls.Add(this.labelSortedList);
            this.Controls.Add(this.listBoxSortedList);
            this.Controls.Add(this.listBoxOriginalList);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelOriginalList);
            this.Controls.Add(this.textBoxNumbers);
            this.Controls.Add(this.labelAmountOfNumbers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormDataStructures";
            this.Text = "Data Structures Lists";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAmountOfNumbers;
        private System.Windows.Forms.TextBox textBoxNumbers;
        private System.Windows.Forms.Label labelOriginalList;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ListBox listBoxOriginalList;
        private System.Windows.Forms.ListBox listBoxSortedList;
        private System.Windows.Forms.Label labelSortedList;
        private System.Windows.Forms.Button buttonShowValues;
        private System.Windows.Forms.Button buttonOrderList;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ImageList imageListCards;
        private System.Windows.Forms.PictureBox pictureBoxPrevious;
        private System.Windows.Forms.PictureBox pictureBoxNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
    }
}

