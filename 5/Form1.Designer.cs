namespace _5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            transparencyButton = new Button();
            colorButton = new Button();
            helloWorldButton = new Button();
            supermegabutton = new Button();
            consumesTransparency_checkBox = new CheckBox();
            consumesColor_checkBox = new CheckBox();
            consumesHelloWorld_checkBox = new CheckBox();
            SuspendLayout();
            // 
            // transparencyButton
            // 
            transparencyButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            transparencyButton.Location = new Point(95, 25);
            transparencyButton.Name = "transparencyButton";
            transparencyButton.Size = new Size(138, 47);
            transparencyButton.TabIndex = 0;
            transparencyButton.Text = "Transparency";
            transparencyButton.UseVisualStyleBackColor = true;
            // 
            // colorButton
            // 
            colorButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            colorButton.Location = new Point(304, 25);
            colorButton.Name = "colorButton";
            colorButton.Size = new Size(170, 47);
            colorButton.TabIndex = 1;
            colorButton.Text = "Background color";
            colorButton.UseVisualStyleBackColor = true;
            // 
            // helloWorldButton
            // 
            helloWorldButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            helloWorldButton.Location = new Point(551, 25);
            helloWorldButton.Name = "helloWorldButton";
            helloWorldButton.Size = new Size(138, 47);
            helloWorldButton.TabIndex = 2;
            helloWorldButton.Text = "Hello World";
            helloWorldButton.UseVisualStyleBackColor = true;
            // 
            // supermegabutton
            // 
            supermegabutton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            supermegabutton.Location = new Point(247, 113);
            supermegabutton.Name = "supermegabutton";
            supermegabutton.Size = new Size(298, 51);
            supermegabutton.TabIndex = 3;
            supermegabutton.Text = "Supermegabutton";
            supermegabutton.UseVisualStyleBackColor = true;
            supermegabutton.Click += supermegabutton_Click;
            // 
            // consumesTransparency_checkBox
            // 
            consumesTransparency_checkBox.AutoSize = true;
            consumesTransparency_checkBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            consumesTransparency_checkBox.Location = new Point(247, 192);
            consumesTransparency_checkBox.Name = "consumesTransparency_checkBox";
            consumesTransparency_checkBox.Size = new Size(349, 25);
            consumesTransparency_checkBox.TabIndex = 4;
            consumesTransparency_checkBox.Text = "\"Supermegabutton\" consumes \"Transparency\"";
            consumesTransparency_checkBox.UseVisualStyleBackColor = true;
            // 
            // consumesColor_checkBox
            // 
            consumesColor_checkBox.AutoSize = true;
            consumesColor_checkBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            consumesColor_checkBox.Location = new Point(247, 232);
            consumesColor_checkBox.Name = "consumesColor_checkBox";
            consumesColor_checkBox.Size = new Size(295, 25);
            consumesColor_checkBox.TabIndex = 5;
            consumesColor_checkBox.Text = "\"Supermegabutton\" consumes \"Color\"";
            consumesColor_checkBox.UseVisualStyleBackColor = true;
            // 
            // consumesHelloWorld_checkBox
            // 
            consumesHelloWorld_checkBox.AutoSize = true;
            consumesHelloWorld_checkBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            consumesHelloWorld_checkBox.Location = new Point(247, 273);
            consumesHelloWorld_checkBox.Name = "consumesHelloWorld_checkBox";
            consumesHelloWorld_checkBox.Size = new Size(339, 25);
            consumesHelloWorld_checkBox.TabIndex = 6;
            consumesHelloWorld_checkBox.Text = "\"Supermegabutton\" consumes \"Hello World\"";
            consumesHelloWorld_checkBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(consumesHelloWorld_checkBox);
            Controls.Add(consumesColor_checkBox);
            Controls.Add(consumesTransparency_checkBox);
            Controls.Add(supermegabutton);
            Controls.Add(helloWorldButton);
            Controls.Add(colorButton);
            Controls.Add(transparencyButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button transparencyButton;
        private Button colorButton;
        private Button helloWorldButton;
        private Button supermegabutton;
        private CheckBox consumesTransparency_checkBox;
        private CheckBox consumesColor_checkBox;
        private CheckBox consumesHelloWorld_checkBox;
    }
}