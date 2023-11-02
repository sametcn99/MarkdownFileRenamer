# Markdown File Renamer

Markdown File Renamer is a simple C# application for renaming and moving files using the titles from Markdown files.

## How It Works

1. **Folder Selection**:
   - Click the "Select Folder" button to choose a folder. The Markdown files in this folder will be processed.

2. **Execution**:
   - Click the "Run" button to process the Markdown files in the selected folder.
   - Each Markdown file's title is used to rename the file and move it to the specified folder.

3. **Results**:
   - Upon completion, a "RenamedFiles" folder containing the new file names is created, and this folder is opened in Windows Explorer.

## Title Rule

The titles of Markdown files are considered as the second line of the file. They are cleaned and used as the file names.

## Removing Special Characters

Title file names are cleaned by removing special characters:
- Turkish characters are translated to their English counterparts.
- Invalid characters are replaced with "-" (hyphens).
- Consecutive "-" signs are replaced with a single "-" (hyphen).

## User Guide

For more information and usage instructions, please visit the [GitHub page](https://github.com/sametcn99/MarkdownFileRenamer).

## Requirements

To run this application, you must first clone the project from the [GitHub repository](https://github.com/sametcn99/MarkdownFileRenamer) and then follow the instructions in the README.

## Contribution

This project is open-source, and we welcome your contributions. Please visit the GitHub page to contribute.

## License

This project is licensed under the MIT License. For more information, see the [LICENSE](LICENSE) file.
