/*
 * Base64 ToolBox 1.0
 *
 * Copyright (C) 2005 Sébastien Santoro
 *
 * Ce logiciel est librement diffusé sous licence BSD.
 * 
 * Ce programme est diffusé en espérant qu'il vous sera utile, mais
 * SANS AUCUNE GARANTIE, en ce inclut la garantie de conformité avec
 * un usage particulier.
 *
 * Vous utilisez donc ce logiciel à vos propres risques et périls.
 *
 * Le présent code peut librement être réutilisé dans d'autres applications,
 * y compris commerciales ou non open source.
 *
 * Si vous l'utiliser ainsi ou l'améliorer, ce serait très gentil de votre part
 * d'envoyer un e-mail à dereckson@espace-win.org afin de donner à l'auteur une
 * idée de la "vie" de son code.
 *
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Base64ToolBox {
    /// <summary>
    /// Class Base64ToolBoxForm
    /// </summary>
    partial class Base64ToolBoxForm : Form {
        public Base64ToolBoxForm() {
            InitializeComponent();
            this.tabControl1.Controls.Clear();
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
        }

        /// <summary>
        /// The result image
        /// </summary>
        Image imageResult;

        /// <summary>
        /// Joins strings value, ignoring white spaces and line returns
        /// </summary>
        /// <returns>The merged string</returns>
        private string MergeLines(IEnumerable<string> lines) {
            StringBuilder sb = new StringBuilder();
            foreach (string line in lines) {
                sb.Append(line.Trim());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Disables and removes line break in text.
        /// </summary>
        private void NoLineBreaks() {
            textBoxBlock.Text = MergeLines(textBoxBlock.Lines);
            textBoxBlock.AcceptsReturn = false;
            textBoxBlock.WordWrap = true;
        }

        /// <summary>
        /// Inserts line breaks after 76 chars in text.
        /// </summary>
        private void InsertLineBreaks() {
            if (textBoxBlock.Lines.Length > 0) {
                string content = MergeLines(textBoxBlock.Lines);
                textBoxBlock.Text = "";
                bool start = true;
                while (content.Length > 76) {
                    if (!start) {
                        textBoxBlock.Text += Environment.NewLine;
                    } else {
                        start = false;
                    }
                    textBoxBlock.Text += content.Substring(0, 76);
                    content = content.Substring(76);
                };
                textBoxBlock.Text += Environment.NewLine;
                textBoxBlock.Text += content;
            }
            textBoxBlock.AcceptsReturn = true;
            textBoxBlock.WordWrap = false;
        }

        /// <summary>
        /// Handles the CheckedChanged event of the radioButton1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            if (radioButton1.Checked) {
                InsertLineBreaks();
            } else {
                NoLineBreaks();
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of the radioButton2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            if (radioButton1.Checked) {
                InsertLineBreaks();
            } else {
                NoLineBreaks();
            }
        }

        /// <summary>
        /// Handles the TextChanged event of the textBoxBloc control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void textBoxBloc_TextChanged(object sender, EventArgs e) {
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length == 0 || !IsBase64String(MergeLines(textBox.Lines))) {
                this.buttonGenererImage.BackColor = System.Drawing.Color.OrangeRed;
                //this.buttonGenererImage.BorderColor = System.Drawing.Color.DarkRed;
                this.buttonGenererImage.ForeColor = System.Drawing.Color.Black;
                this.buttonGenererImage.Enabled = false;
                //this.toolTipGenererImage.ToolTipIcon = ToolTipIcon.Warning;
                //this.toolTipGenererImage.IsBalloon = true;
                //this.toolTipGenererImage.ToolTipTitle = "Comment voulez-vous générer une image à partir d'un texte vide ?";
            } else {
                this.buttonGenererImage.BackColor = System.Drawing.Color.GreenYellow;
                //this.buttonGenererImage.BorderColor = System.Drawing.Color.DarkGreen;
                this.buttonGenererImage.ForeColor = System.Drawing.Color.Teal;
                this.buttonGenererImage.Enabled = true;
                //this.toolTipGenererImage.ToolTipIcon = ToolTipIcon.Info;
                //this.toolTipGenererImage.IsBalloon = false;
                //this.toolTipGenererImage.ToolTipTitle = "Génère l'image à partir du texte et l'affiche dans un nouvel onglet.";
            }
        }

        /// <summary>
        /// Converts a Base64 string into an image
        /// </summary>
        /// <param name="base64">BASE 64 character string</param>
        /// <returns>Converted image</returns>
        public static Image GetImageFromBase64String(string base64) {
            byte[] bytes = Convert.FromBase64String(base64);

            string tmpName = Path.GetTempFileName();
            FileStream fs = new FileStream(tmpName, FileMode.Create);
            fs.Write(bytes, 0, bytes.Length);
            fs.Flush();
            fs.Close();

            return Image.FromFile(tmpName);
        }

        /// <summary>
        /// Determines whether the specified string is a valid base64 string.
        /// </summary>
        /// <param name="stringToCheck">The string to check.</param>
        /// <returns><c>true</c> if the specified string is a valid base64 string; otherwise, <c>false</c>.</returns>
        public static bool IsBase64String(string stringToCheck) {
            stringToCheck = stringToCheck.Trim();
            return (stringToCheck.Length % 4 == 0) && Regex.IsMatch(stringToCheck, @"^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None);
        }

        /// <summary>
        /// Handles the Click event of the buttonGenererImage control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void buttonGenererImage_Click(object sender, EventArgs e) {
            //Gets and prints picture
            try {
                imageResult = GetImageFromBase64String(MergeLines(textBoxBlock.Lines));
            } catch (Exception ex) {
                string message = ex.Message;
                if (ex is OutOfMemoryException) {
                    message = "Il semblerait que votre texte ne soit pas la représentation Base64 valide d'une image.";
                }
                MessageBox.Show(message, "Erreur lors de la conversion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            pictureBoxResultat.Image = imageResult;

            //Tabs
            this.tabControl1.Controls.Clear();
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPageResultImage);
            this.tabControl1.Controls.Add(this.tabPage2);
        }

        /// <summary>
        /// Handles the Click event of the buttonCopyPictureClipboard control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void buttonCopyPictureClipboard_Click(object sender, EventArgs e) {
            DataObject data = new DataObject();
            data.SetData(DataFormats.Bitmap, imageResult);
            Clipboard.SetDataObject(data, true);
        }

        /// <summary>
        /// Handles the Click event of the buttonSavePicture control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void buttonSavePicture_Click(object sender, EventArgs e) {
            if (saveFileDialogPicture.ShowDialog() == DialogResult.OK) {
                string filename = saveFileDialogPicture.FileName;
                try {
                    imageResult.Save(filename);
                } catch (Exception exp) {
                    MessageBox.Show(exp.Message, this.Text);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start(@"http://www.espace-win.org/EWOSP?utm_source=Base64ToolBox&utm_medium=software-aboutbox&utm_campaign=from-products");
        }
    }
}