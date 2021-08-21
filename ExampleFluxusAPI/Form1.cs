using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FluxusAPI; // import API

namespace ExampleFluxusAPI
{
    public partial class Form1 : Form
    {
        private Fluxus api = new Fluxus(); // API

        public Form1()
        {
            InitializeComponent();
            Fluxus.InitializeFluxus(); // Initialize Fluxus

            api.InjectStateChanged += () =>
            {
                if (api.IsInjected == true)
                {
                    isInjectedLabel.Text = "Injected!";
                }

                else
                {
                    isInjectedLabel.Text = "Not Injected!";
                }
            }; // Inject event
        }

        private void getKey_Click(object sender, EventArgs e)
        {
            Fluxus.GetKey(); // Get Fluxus key
        }

        private void verifyKey_Click(object sender, EventArgs e)
        {
            bool success = Fluxus.VerifyKey(keyTextBox.Text); // Verify key from TextBox
            if (success == true)
            {
                MessageBox.Show("Key is valid! Fluxus is now functional.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Key is not valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            api.Execute(scriptEditor.Text); // Execute
        }

        private void injectButton_Click(object sender, EventArgs e)
        {
            api.Inject(); // Inject
        }
    }
}
