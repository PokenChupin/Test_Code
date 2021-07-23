using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

// Added to use PdfSharp
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using MigraDoc.DocumentObjectModel;



namespace Test_code
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public List<Notes> myNotes { get; set; }
        public List<Project> myProject { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            myNotes = new List<Notes>();

            Notes note1 = new Notes();
            note1.Key = 1;
            note1.Content = "Hello World";
            note1.Type = "Note";
            note1.Prio = 0;

            myNotes.Add(note1);

            note1 = new Notes
            {
                Key = 2,
                Content = "Wewew",
                Type = "Note",
                Prio = 0
            };

            myNotes.Add(note1);

            note1 = new Notes
            {
                Key = 3,
                Content = "Just Adding Notes",
                Type = "Note",
                Prio = 0
            };

            myNotes.Add(note1);

            note1 = new Notes
            {
                Key = 4,
                Content = "Ni Woork!",
                Type = "Note",
                Prio = 0
            };

            myNotes.Add(note1);

           myProject = new List<Project>();
            myProject.Add(new Project
            {
                Key = 1,
                Name = "Home",
                Type = "Test",
                IsDefault = false
            });

            myProject.Add(new Project
            {
                Key = 2,
                Name = "School",
                Type = "Test",
                IsDefault = true
            });

            myProject.Add(new Project
            {
                Key = 3,
                Name = "Office",
                Type = "Test",
                IsDefault = false
            });



            ComboBox1.SelectedIndex = FindDefault();

            DataContext = this;
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private int FindDefault()
        {
            int index = 0;
            foreach (Project project in myProject)
            {
                if (project.IsDefault == true)
                {
                    index = myProject.IndexOf(project);
                    break;
                }
            }
            return index;
        }

        private void PrintAsPDF()
        {
            int sectionWidth;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            MigraDoc.DocumentObjectModel.Document doc = new MigraDoc.DocumentObjectModel.Document();
            MigraDoc.DocumentObjectModel.Section sec = doc.AddSection();
            sec.AddParagraph("Table of Notes");
            sec.AddParagraph(); // Blank Line Space

            sectionWidth = (int)doc.DefaultPageSetup.PageWidth - (int)doc.DefaultPageSetup.LeftMargin - (int)doc.DefaultPageSetup.RightMargin; // Needed para ma divide equally ang columns size

            //Define Table
            MigraDoc.DocumentObjectModel.Tables.Table table = new MigraDoc.DocumentObjectModel.Tables.Table();
            table.Borders.Width = 0.5;

            //Define Columns of Table
            MigraDoc.DocumentObjectModel.Tables.Column column = table.AddColumn(sectionWidth / 4);
            column.Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Center;

            column = table.AddColumn(sectionWidth / 4);
            column.Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Center;

            column = table.AddColumn(sectionWidth / 4);
            column.Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Center;

            column = table.AddColumn(sectionWidth / 4);
            column.Format.Alignment = MigraDoc.DocumentObjectModel.ParagraphAlignment.Center;

            //Define header of Table
            MigraDoc.DocumentObjectModel.Tables.Row row = table.AddRow();
            MigraDoc.DocumentObjectModel.Tables.Cell cell = row.Cells[0];
            cell.AddParagraph("Key");
            cell.Format.Font.Bold = true;

            cell = row.Cells[1];
            cell.AddParagraph("Content");
            cell.Format.Font.Bold = true;

            cell = row.Cells[2];
            cell.AddParagraph("Type");
            cell.Format.Font.Bold = true;

            cell = row.Cells[3];
            cell.AddParagraph("Prio");
            cell.Format.Font.Bold = true;

            //Define Data of Table
            foreach(var elem in myNotes)
            {
                row = table.AddRow();

                cell = row.Cells[0];
                cell.AddParagraph(""+elem.Key);

                cell = row.Cells[1];
                cell.AddParagraph(elem.Content);

                cell = row.Cells[2];
                cell.AddParagraph(elem.Type);

                cell = row.Cells[3];
                cell.AddParagraph("" + elem.Prio);
            }

            //Add Table to Document
            doc.LastSection.Add(table);

            //Rendering Doc
            MigraDoc.Rendering.PdfDocumentRenderer docRend = new MigraDoc.Rendering.PdfDocumentRenderer(false);
            docRend.Document = doc;

            docRend.RenderDocument();

            string fileName = "NotePDF.pdf";

            docRend.PdfDocument.Save("C:\\Users\\JR\\Desktop\\TestPDF\\" + fileName);

            //Open File in Default App

            System.Diagnostics.ProcessStartInfo processInfo = new System.Diagnostics.ProcessStartInfo();
            processInfo.FileName = "C:\\Users\\JR\\Desktop\\TestPDF\\" + fileName;
            processInfo.UseShellExecute = true;

            System.Diagnostics.Process.Start(processInfo);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PrintAsPDF();
        }
    }
}
