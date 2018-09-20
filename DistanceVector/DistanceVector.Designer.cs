namespace DistanceVector
{
    partial class DistanceVectorForm
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
            this.btn_CreateRouter = new System.Windows.Forms.Button();
            this.lbl_NewRouter = new System.Windows.Forms.Label();
            this.lbl_newVertex = new System.Windows.Forms.Label();
            this.txt_VertexValue = new System.Windows.Forms.TextBox();
            this.lbl_VertexValue = new System.Windows.Forms.Label();
            this.btn_addNode = new System.Windows.Forms.Button();
            this.box_RouterOne = new System.Windows.Forms.ComboBox();
            this.box_RouterTwo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_RunSimulation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_PrintRouters = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CreateRouter
            // 
            this.btn_CreateRouter.Location = new System.Drawing.Point(203, 40);
            this.btn_CreateRouter.Name = "btn_CreateRouter";
            this.btn_CreateRouter.Size = new System.Drawing.Size(75, 23);
            this.btn_CreateRouter.TabIndex = 0;
            this.btn_CreateRouter.Text = "Pridėti";
            this.btn_CreateRouter.UseVisualStyleBackColor = true;
            this.btn_CreateRouter.Click += new System.EventHandler(this.btn_CreateRouter_Click);
            // 
            // lbl_NewRouter
            // 
            this.lbl_NewRouter.AutoSize = true;
            this.lbl_NewRouter.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewRouter.Location = new System.Drawing.Point(12, 42);
            this.lbl_NewRouter.Name = "lbl_NewRouter";
            this.lbl_NewRouter.Size = new System.Drawing.Size(178, 18);
            this.lbl_NewRouter.TabIndex = 3;
            this.lbl_NewRouter.Text = "Pridėti naują maršrutizatorių: ";
            // 
            // lbl_newVertex
            // 
            this.lbl_newVertex.AutoSize = true;
            this.lbl_newVertex.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newVertex.Location = new System.Drawing.Point(12, 76);
            this.lbl_newVertex.Name = "lbl_newVertex";
            this.lbl_newVertex.Size = new System.Drawing.Size(134, 18);
            this.lbl_newVertex.TabIndex = 4;
            this.lbl_newVertex.Text = "Pridėti naują briauną: ";
            // 
            // txt_VertexValue
            // 
            this.txt_VertexValue.Location = new System.Drawing.Point(320, 81);
            this.txt_VertexValue.Name = "txt_VertexValue";
            this.txt_VertexValue.Size = new System.Drawing.Size(49, 20);
            this.txt_VertexValue.TabIndex = 6;
            // 
            // lbl_VertexValue
            // 
            this.lbl_VertexValue.AutoSize = true;
            this.lbl_VertexValue.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_VertexValue.Location = new System.Drawing.Point(258, 78);
            this.lbl_VertexValue.Name = "lbl_VertexValue";
            this.lbl_VertexValue.Size = new System.Drawing.Size(45, 18);
            this.lbl_VertexValue.TabIndex = 7;
            this.lbl_VertexValue.Text = "Kaina:";
            // 
            // btn_addNode
            // 
            this.btn_addNode.Location = new System.Drawing.Point(396, 78);
            this.btn_addNode.Name = "btn_addNode";
            this.btn_addNode.Size = new System.Drawing.Size(75, 23);
            this.btn_addNode.TabIndex = 8;
            this.btn_addNode.Text = "Pridėti";
            this.btn_addNode.UseVisualStyleBackColor = true;
            this.btn_addNode.Click += new System.EventHandler(this.btn_addNode_Click);
            // 
            // box_RouterOne
            // 
            this.box_RouterOne.FormattingEnabled = true;
            this.box_RouterOne.Location = new System.Drawing.Point(147, 80);
            this.box_RouterOne.Name = "box_RouterOne";
            this.box_RouterOne.Size = new System.Drawing.Size(43, 21);
            this.box_RouterOne.TabIndex = 10;
            // 
            // box_RouterTwo
            // 
            this.box_RouterTwo.FormattingEnabled = true;
            this.box_RouterTwo.Location = new System.Drawing.Point(203, 80);
            this.box_RouterTwo.Name = "box_RouterTwo";
            this.box_RouterTwo.Size = new System.Drawing.Size(43, 21);
            this.box_RouterTwo.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(230, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pradinė inicializacija";
            // 
            // btn_RunSimulation
            // 
            this.btn_RunSimulation.Location = new System.Drawing.Point(411, 120);
            this.btn_RunSimulation.Name = "btn_RunSimulation";
            this.btn_RunSimulation.Size = new System.Drawing.Size(136, 23);
            this.btn_RunSimulation.TabIndex = 13;
            this.btn_RunSimulation.Text = "Paleisti simuliaciją";
            this.btn_RunSimulation.UseVisualStyleBackColor = true;
            this.btn_RunSimulation.Click += new System.EventHandler(this.btn_RunSimulation_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(535, 2);
            this.label2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(258, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Simuliacija";
            // 
            // btn_PrintRouters
            // 
            this.btn_PrintRouters.Location = new System.Drawing.Point(15, 178);
            this.btn_PrintRouters.Name = "btn_PrintRouters";
            this.btn_PrintRouters.Size = new System.Drawing.Size(86, 23);
            this.btn_PrintRouters.TabIndex = 16;
            this.btn_PrintRouters.Text = "Atspausdinti";
            this.btn_PrintRouters.UseVisualStyleBackColor = true;
            this.btn_PrintRouters.Visible = false;
            this.btn_PrintRouters.Click += new System.EventHandler(this.btn_PrintRouters_Click);
            // 
            // DistanceVectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(559, 296);
            this.Controls.Add(this.btn_PrintRouters);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_RunSimulation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_RouterTwo);
            this.Controls.Add(this.box_RouterOne);
            this.Controls.Add(this.btn_addNode);
            this.Controls.Add(this.lbl_VertexValue);
            this.Controls.Add(this.txt_VertexValue);
            this.Controls.Add(this.lbl_newVertex);
            this.Controls.Add(this.lbl_NewRouter);
            this.Controls.Add(this.btn_CreateRouter);
            this.Name = "DistanceVectorForm";
            this.Text = "Distance Vector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CreateRouter;
        private System.Windows.Forms.Label lbl_NewRouter;
        private System.Windows.Forms.Label lbl_newVertex;
        private System.Windows.Forms.TextBox txt_VertexValue;
        private System.Windows.Forms.Label lbl_VertexValue;
        private System.Windows.Forms.Button btn_addNode;
        private System.Windows.Forms.ComboBox box_RouterOne;
        private System.Windows.Forms.ComboBox box_RouterTwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_RunSimulation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_PrintRouters;
    }
}

