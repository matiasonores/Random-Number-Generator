
namespace RandomNumberGenerator
{
   partial class RandomForm
   {
      /// <summary>
      /// Variable del diseñador necesaria.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Limpiar los recursos que se estén usando.
      /// </summary>
      /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Código generado por el Diseñador de Windows Forms

      /// <summary>
      /// Método necesario para admitir el Diseñador. No se puede modificar
      /// el contenido de este método con el editor de código.
      /// </summary>
      private void InitializeComponent()
      {
         this.RandomLabel = new System.Windows.Forms.Label();
         this.GenerateButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // RandomLabel
         // 
         this.RandomLabel.Font = new System.Drawing.Font("Courier New", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.RandomLabel.Location = new System.Drawing.Point(1, 9);
         this.RandomLabel.Name = "RandomLabel";
         this.RandomLabel.Size = new System.Drawing.Size(481, 338);
         this.RandomLabel.TabIndex = 0;
         this.RandomLabel.Text = "Press the button";
         this.RandomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // GenerateButton
         // 
         this.GenerateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.GenerateButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.GenerateButton.Location = new System.Drawing.Point(200, 350);
         this.GenerateButton.Name = "GenerateButton";
         this.GenerateButton.Size = new System.Drawing.Size(100, 100);
         this.GenerateButton.TabIndex = 1;
         this.GenerateButton.Text = "Generate";
         this.GenerateButton.UseVisualStyleBackColor = true;
         this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
         // 
         // RandomForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(484, 461);
         this.Controls.Add(this.GenerateButton);
         this.Controls.Add(this.RandomLabel);
         this.Name = "RandomForm";
         this.Text = "Random Number Generator";
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Label RandomLabel;
      private System.Windows.Forms.Button GenerateButton;
   }
}

