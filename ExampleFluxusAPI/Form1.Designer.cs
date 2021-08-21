
namespace ExampleFluxusAPI
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
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.keyLabel = new System.Windows.Forms.Label();
            this.getKey = new System.Windows.Forms.Button();
            this.verifyKey = new System.Windows.Forms.Button();
            this.scriptEditor = new System.Windows.Forms.TextBox();
            this.executeButton = new System.Windows.Forms.Button();
            this.injectButton = new System.Windows.Forms.Button();
            this.isInjectedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // keyTextBox
            // 
            this.keyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyTextBox.Location = new System.Drawing.Point(43, 12);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(583, 20);
            this.keyTextBox.TabIndex = 0;
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(12, 15);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(25, 13);
            this.keyLabel.TabIndex = 1;
            this.keyLabel.Text = "Key";
            // 
            // getKey
            // 
            this.getKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.getKey.Location = new System.Drawing.Point(713, 10);
            this.getKey.Name = "getKey";
            this.getKey.Size = new System.Drawing.Size(75, 23);
            this.getKey.TabIndex = 2;
            this.getKey.Text = "Get Key";
            this.getKey.UseVisualStyleBackColor = true;
            this.getKey.Click += new System.EventHandler(this.getKey_Click);
            // 
            // verifyKey
            // 
            this.verifyKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.verifyKey.Location = new System.Drawing.Point(632, 10);
            this.verifyKey.Name = "verifyKey";
            this.verifyKey.Size = new System.Drawing.Size(75, 23);
            this.verifyKey.TabIndex = 3;
            this.verifyKey.Text = "Verify Key";
            this.verifyKey.UseVisualStyleBackColor = true;
            this.verifyKey.Click += new System.EventHandler(this.verifyKey_Click);
            // 
            // scriptEditor
            // 
            this.scriptEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scriptEditor.Location = new System.Drawing.Point(12, 38);
            this.scriptEditor.Multiline = true;
            this.scriptEditor.Name = "scriptEditor";
            this.scriptEditor.Size = new System.Drawing.Size(776, 371);
            this.scriptEditor.TabIndex = 4;
            // 
            // executeButton
            // 
            this.executeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.executeButton.Location = new System.Drawing.Point(12, 415);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(75, 23);
            this.executeButton.TabIndex = 5;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // injectButton
            // 
            this.injectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.injectButton.Location = new System.Drawing.Point(93, 415);
            this.injectButton.Name = "injectButton";
            this.injectButton.Size = new System.Drawing.Size(75, 23);
            this.injectButton.TabIndex = 6;
            this.injectButton.Text = "Inject";
            this.injectButton.UseVisualStyleBackColor = true;
            this.injectButton.Click += new System.EventHandler(this.injectButton_Click);
            // 
            // isInjectedLabel
            // 
            this.isInjectedLabel.AutoSize = true;
            this.isInjectedLabel.Location = new System.Drawing.Point(174, 420);
            this.isInjectedLabel.Name = "isInjectedLabel";
            this.isInjectedLabel.Size = new System.Drawing.Size(65, 13);
            this.isInjectedLabel.TabIndex = 7;
            this.isInjectedLabel.Text = "Not Injected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.isInjectedLabel);
            this.Controls.Add(this.injectButton);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.scriptEditor);
            this.Controls.Add(this.verifyKey);
            this.Controls.Add(this.getKey);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.keyTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Button getKey;
        private System.Windows.Forms.Button verifyKey;
        private System.Windows.Forms.TextBox scriptEditor;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Button injectButton;
        private System.Windows.Forms.Label isInjectedLabel;
    }
}

