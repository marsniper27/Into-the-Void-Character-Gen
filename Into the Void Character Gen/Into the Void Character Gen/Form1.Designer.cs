namespace Into_The_Void_Character_Gen
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.construct = new System.Windows.Forms.Button();
            this.human = new System.Windows.Forms.Button();
            this.Abilities = new System.Windows.Forms.Button();
            this.Continue = new System.Windows.Forms.Button();
            this.HumanPanel = new System.Windows.Forms.Panel();
            this.ConstructPanel = new System.Windows.Forms.Panel();
            this.CharacterPanel = new System.Windows.Forms.Panel();
            this.AttributePanel = new System.Windows.Forms.Panel();
            this.CareerPanel = new System.Windows.Forms.Panel();
            this.FlawsPanel = new System.Windows.Forms.Panel();
            this.AbilitesPanel = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.CharacterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.construct);
            this.panel1.Controls.Add(this.human);
            this.panel1.Controls.Add(this.Abilities);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.MinimumSize = new System.Drawing.Size(330, 318);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 318);
            this.panel1.TabIndex = 0;
            // 
            // construct
            // 
            this.construct.Location = new System.Drawing.Point(186, 126);
            this.construct.Name = "construct";
            this.construct.Size = new System.Drawing.Size(75, 23);
            this.construct.TabIndex = 1;
            this.construct.Text = "Construct";
            this.construct.UseVisualStyleBackColor = true;
            this.construct.Click += new System.EventHandler(this.construct_Click);
            // 
            // human
            // 
            this.human.Location = new System.Drawing.Point(77, 126);
            this.human.Name = "human";
            this.human.Size = new System.Drawing.Size(75, 23);
            this.human.TabIndex = 0;
            this.human.Text = "Human";
            this.human.UseVisualStyleBackColor = true;
            this.human.Click += new System.EventHandler(this.human_Click);
            // 
            // Continue
            // 
            this.Continue.Location = new System.Drawing.Point(0, 0);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(75, 23);
            this.Continue.TabIndex = 5;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            this.Continue.Visible = false;
            // 
            // Human Panel
            // 
            this.HumanPanel.AutoSize = true;
            this.HumanPanel.Location = new System.Drawing.Point(13, 13);
            this.HumanPanel.Name = "Human";
            this.HumanPanel.Size = new System.Drawing.Size(330, 318);
            this.HumanPanel.TabIndex = 0;
            this.HumanPanel.Text = "Human";
            // 
            // Construct Panel
            // 
            this.ConstructPanel.AutoSize = true;
            this.ConstructPanel.Location = new System.Drawing.Point(13, 13);
            this.ConstructPanel.Name = "Construct";
            this.ConstructPanel.Size = new System.Drawing.Size(330, 318);
            this.ConstructPanel.TabIndex = 0;
            this.ConstructPanel.Text = "Construct";
            // 
            // Character Panel
            // 
            this.CharacterPanel.AutoSize = true;
            this.CharacterPanel.Controls.Add(this.name);
            this.CharacterPanel.Location = new System.Drawing.Point(335, 13);
            this.CharacterPanel.Name = "Character";
            this.CharacterPanel.Size = new System.Drawing.Size(410, 318);
            this.CharacterPanel.TabIndex = 0;
            // 
            // Attribute Panel
            // 
            this.AttributePanel.AutoSize = true;
            this.AttributePanel.Location = new System.Drawing.Point(13, 13);
            this.AttributePanel.Name = "Atrributes";
            this.AttributePanel.Size = new System.Drawing.Size(330, 318);
            this.AttributePanel.TabIndex = 0;
            this.AttributePanel.Text = "Attributes";
            // 
            // Flaws Panel
            // 
            this.FlawsPanel.AutoSize = true;
            this.FlawsPanel.Location = new System.Drawing.Point(13, 13);
            this.FlawsPanel.Name = "Flaws";
            this.FlawsPanel.Size = new System.Drawing.Size(215, 318);
            this.FlawsPanel.TabIndex = 0;
            this.FlawsPanel.Text = "Flaws";
            // 
            // Career Panel
            // 
            this.CareerPanel.AutoSize = true;
            this.CareerPanel.Location = new System.Drawing.Point(13, 13);
            this.CareerPanel.Name = "Career";
            this.CareerPanel.Size = new System.Drawing.Size(215, 318);
            this.CareerPanel.TabIndex = 0;
            this.CareerPanel.Text = "Career";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(0, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 13);
            this.name.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Name";
            this.textBox1.TextChanged += textBox1_Changed;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(22, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0; 
            // 
            // Abilites Panel
            // 
            this.AbilitesPanel.AutoSize = true;
            this.AbilitesPanel.Controls.Add(label2);
            this.AbilitesPanel.Location = new System.Drawing.Point(13, 13);
            this.AbilitesPanel.Name = "Human";
            this.AbilitesPanel.Size = new System.Drawing.Size(330, 318);
            this.AbilitesPanel.TabIndex = 0;
            this.AbilitesPanel.Text = "Human";
            this.AbilitesPanel.AutoScroll = true;
            // 
            // Abilites
            // 
            this.Abilities.Location = new System.Drawing.Point(77, 300);
            this.Abilities.Name = "Abilities";
            this.Abilities.Size = new System.Drawing.Size(75, 23);
            this.Abilities.TabIndex = 0;
            this.Abilities.Text = "Abilities";
            this.Abilities.UseVisualStyleBackColor = true;
            this.Abilities.Click += new System.EventHandler(this.Abilities_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(750, 700);
            this.label2.TabIndex = 0;
            this.label2.ReadOnly = true;
            this.label2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.label2.Multiline = true;
            this.label2.AutoSize = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(358, 343);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HumanPanel);
            this.Controls.Add(this.ConstructPanel);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.AttributePanel);
            this.Controls.Add(this.FlawsPanel);
            this.Controls.Add(this.CareerPanel);
            this.Controls.Add(this.AbilitesPanel);
            this.Name = "Form1";
            this.Text = "Into the Void Character Gen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.CharacterPanel.ResumeLayout(false);
            this.CharacterPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel HumanPanel;
        private System.Windows.Forms.Panel ConstructPanel;
        private System.Windows.Forms.Panel CharacterPanel;
        private System.Windows.Forms.Panel AttributePanel;
        private System.Windows.Forms.Panel FlawsPanel;
        private System.Windows.Forms.Panel CareerPanel;
        private System.Windows.Forms.Panel AbilitesPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox label2;
        private System.Windows.Forms.Button construct;
        private System.Windows.Forms.Button human;
        private System.Windows.Forms.Button Abilities;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Label name;
    }
}
