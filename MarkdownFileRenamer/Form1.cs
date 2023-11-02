using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MarkdownFileRenamer
{
    public partial class Form1 : Form
    {
        string selectedFolderPath;

        public Form1()
        {
            InitializeComponent();
        }

        // Method called when the "Select Folder" button is clicked
        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            // Create a folder browser dialog for selecting a directory
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select a folder";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                // Store the selected folder path
                selectedFolderPath = fbd.SelectedPath;// Store the selected folder path
                selectedFolderLabel.Enabled = true;// Enable the "Selected Folder" label
                selectedFolderLabel.Text = selectedFolderPath;// Display the selected folder path
                runButton.Enabled = true;// Enable the "Run" button
            }
            else
            {
                Console.WriteLine("Folder not found.");
            }
        }

        // Method to rename and move files
        private void RenameFiles()
        {

            // Get the parent folder of the selected folder
            string parentFolder = Path.GetDirectoryName(selectedFolderPath);
            // Create a new folder for the renamed files
            string newFolderPath = Path.Combine(parentFolder, "RenamedFiles");

            // Check if the new folder doesn't exist, and if not, create it
            if (!Directory.Exists(newFolderPath))
            {
                Directory.CreateDirectory(newFolderPath);// Create the new folder
            }

            // Check if the selected folder exists
            if (Directory.Exists(selectedFolderPath))// Check if the selected folder exists
            {
                // Get a list of Markdown files in the selected folder
                string[] markdownFiles = Directory.GetFiles(selectedFolderPath, "*.md");// Get all files with the ".md" extension
                foreach (var markdownFile in markdownFiles)// Loop through the Markdown files
                {
                    // Read the content of the Markdown file
                    string markdownContent = File.ReadAllText(markdownFile);
                    // Get a new file name based on the Markdown content
                    string newFileName = GetTitle(markdownContent);// Call the GetTitle method

                    if (!string.IsNullOrEmpty(newFileName))
                    {
                        // Create a new file path for the renamed file
                        string newFilePath = Path.Combine(newFolderPath, newFileName + ".md");// Add the ".md" extension
                        // Copy the original file to the new location
                        try
                        {
                            File.Copy(markdownFile, newFilePath);// Copy the file
                        }
                        catch (Exception)// If the file already exists, show a message box
                        {
                            MessageBox.Show("Files already exist");
                            break;
                        }
                    }
                }
                // Open the new folder with Windows Explorer
                Process.Start("explorer.exe", newFolderPath);
            }
        }

        // Method used to extract the title from the content of a Markdown file
        static string GetTitle(string content)
        {
            // Split the content into lines
            string[] lines = content.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);// Split the content into lines

            if (lines.Length >= 2)// Check if the content has at least 2 lines
            {
                // Extract the second line as the title line
                string titleLine = lines[1];
                if (titleLine.Length >= 10)// Check if the title line is long enough
                {
                    // Remove unnecessary characters from the title
                    titleLine = titleLine.Remove(0, 8);// Remove the first 8 characters
                    titleLine = titleLine.Remove(titleLine.Length - 1);// Remove the last character
                    // Sanitize the title by removing special characters
                    string sanitizedString = SanitizeString(titleLine);// Call the SanitizeString method
                    return sanitizedString;// Return the sanitized string
                }
                else
                {
                    Console.WriteLine("Something is wrong.");// Something is wrong
                }
            }
            else
            {
                Console.WriteLine("Title not found.");// Title not found
            }
            return "";// Return an empty string if the title is not found
        }

        // Method to sanitize a string by removing special characters
        static string SanitizeString(string input)
        {
            // Replace Turkish characters with their English equivalents
            string result = input
                .Replace("ç", "c")
                .Replace("Ç", "C")
                .Replace("ğ", "g")
                .Replace("Ğ", "G")
                .Replace("ı", "i")
                .Replace("İ", "I")
                .Replace("ö", "o")
                .Replace("Ö", "O")
                .Replace("ş", "s")
                .Replace("Ş", "S")
                .Replace("ü", "u")
                .Replace("Ü", "U");

            // Replace other characters with "-"
            result = new string(result
                .ToCharArray()
                .Select(c => char.IsLetterOrDigit(c) || c == '-' ? c : '-')
                .ToArray());

            // Replace multiple "-" signs with a single "-"
            result = Regex.Replace(result, @"-+", "-");

            return result;// Return the sanitized string
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            RenameFiles();// Call the RenameFiles method
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/sametcn99/MarkdownFileRenamer");
        }
    }
}
