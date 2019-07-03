using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XoramagInterface
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }
        public void ChangeStatsDialogBox(string changingStats)
        {
            string newStats;
            bool okButtonClicked = false;
            // Create a new instance of the form.
            Form StatsDialogBox = new Form();
            // Create two buttons to use as the accept and cancel buttons.
            Button okButton = new Button();
            Button cancelButton = new Button();
            TextBox entryOfData = new TextBox();
            TextBox questionBox = new TextBox();

            
            //OkButton
            okButton.Text = "Confirm";
            okButton.Location = new Point(155, 24);
            okButton.Click += new System.EventHandler(OkButton_Click);
            //CancelButton
            cancelButton.Text = "Cancel";
            cancelButton.Location = new Point(155, 49);
            //QuestionBox
            questionBox.Text = "What the new " + changingStats + " of the Player?";
            questionBox.Size = new Size(400,200);
            questionBox.Location = new Point(0,0);
            //Entry of data
            entryOfData.Location = new Point(0,25);
            entryOfData.Size = new Size(150, 20);
            // Set the caption bar text of the form.   


            StatsDialogBox.Text = "Change " + changingStats;
            // Display a help button on the form.
            StatsDialogBox.HelpButton = true;

            // Define the border style of the form to a dialog box.
            StatsDialogBox.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Set the MaximizeBox to false to remove the maximize box.
            StatsDialogBox.MaximizeBox = false;
            // Set the MinimizeBox to false to remove the minimize box.
            StatsDialogBox.MinimizeBox = false;
            //Set StatsDialog Size
            StatsDialogBox.Size = new Size(250,125);
            // Set the accept button of the form to button1.
            StatsDialogBox.AcceptButton = okButton;
            // Set the cancel button of the form to button2.
            StatsDialogBox.CancelButton = cancelButton;         
            // Set the start position of the form to the center of the screen.
            StatsDialogBox.StartPosition = FormStartPosition.CenterScreen;

            // Add button1 to the form.
            StatsDialogBox.Controls.Add(okButton);
            // Add button2 to the form.
            StatsDialogBox.Controls.Add(cancelButton);
            //Add question box to the form
            StatsDialogBox.Controls.Add(questionBox);
            //Add EntryOfData to the form
            StatsDialogBox.Controls.Add(entryOfData);
            // Display the form as a modal dialog box.
            StatsDialogBox.ShowDialog();
            
            if (okButtonClicked ==  true)
            {
                newStats = entryOfData.Text;
                this.Close();
                //close form
                //return newStats;
            }

            void OkButton_Click(object sender, EventArgs e)
            {
                okButtonClicked = true;
            }
        }
        //Interface
        private void InterfaceLoad(object sender, EventArgs e)
        {
            
        }

        //Focused
        private void WeaponEvent(object sender, EventArgs e)
        {

        }
        private void ArmorEvent(object sender, EventArgs e)
        {

        }
        private void MiscEvent(object sender, EventArgs e)
        {

        }
        

        //Character Menu
        private void CharacterNewEvent(object sender, EventArgs e)
        {

        }
        private void CharacterSaveEvent(object sender, EventArgs e)
        {

        }
        private void CharacterLoadEvent(object sender, EventArgs e)
        {

        }

        //Invetory Menu
        private void InventoryAddEvent(object sender, EventArgs e)
        {

        }
        private void InventoryRemoveEvent(object sender, EventArgs e)
        {

        }

        //Adventure Menu
        private void AdventureCombatEvent(object sender, EventArgs e)
        {
            Battle.Combat(); //Not Working
        }
        private void AdventureDestinyEvent(object sender, EventArgs e)
        {
        }

        //StatsBlock
        private void NaturalAbilityButtonChanged(object sender, EventArgs e)
        {
            ChangeStatsDialogBox("natural ability");
        }
        private void ZeroPrivilegeButtonChanged(object sender, EventArgs e)
        {

        }
        private void EndurenceButtonChanged(object sender, EventArgs e)
        {

        }

        //Autre
        private void MainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
