Project Overview
This project is a simple note-taking Windows Forms application developed using C#. The application allows users to add, delete, and search through their notes. It consists of a form (Form1) with several controls: text boxes for input, buttons for actions, and labels for displaying information.

Key Components and Functionalities
Adding Notes:

Users can type a note into a text box (muistiinpanoTextBox).
Clicking the "Add Note" button (LisaaMuistiinpanoButton) adds the note to a list (muistiinpanot) and updates the display.
Deleting Notes:

Users can select a note from a list box (muistiinpanoLista).
Clicking the "Delete Note" button (PoistaMuistiinpanoButton) removes the selected note from the list and updates the display.
Searching Notes:

Users can type a keyword into a search text box (hakuTextBox).
Clicking the "Search" button (button1) filters the notes that contain the keyword and updates the display with the search results.
Updating the Display:

The list of notes is displayed in a list box (muistiinpanoLista), which gets updated whenever notes are added, deleted, or searched.
Displaying Current Date and Time:

On form load (Form1_Load), the current date and time are displayed in labels (label1 for time and label2 for date).
Code Walkthrough
Variables and Constructor
muistiinpanot: A list to store the notes.
Form1(): Initializes the form and its components.
csharp
Kopioi koodi
public partial class Form1 : Form
{
    private List<string> muistiinpanot = new List<string>();
    public Form1()
    {
        InitializeComponent();
    }
}
Adding Notes
LisaaMuistiinpanoButton_Click: Event handler for adding a new note.
csharp
Kopioi koodi
private void LisaaMuistiinpanoButton_Click(object sender, EventArgs e)
{
    string uusiMuistiinpano = muistiinpanoTextBox.Text;
    muistiinpanot.Add(uusiMuistiinpano);
    PaivitaMuistiinpanoLista();
    muistiinpanoTextBox.Clear();
}
Deleting Notes
PoistaMuistiinpanoButton_Click: Event handler for deleting the selected note.
csharp
Kopioi koodi
private void PoistaMuistiinpanoButton_Click(object sender, EventArgs e)
{
    if (muistiinpanoLista.SelectedIndex != -1)
    {
        muistiinpanot.RemoveAt(muistiinpanoLista.SelectedIndex);
        PaivitaMuistiinpanoLista();
        muistiinpanoTextBox.Clear();
    }
}
Updating the List Display
PaivitaMuistiinpanoLista: Clears the list box and populates it with the updated list of notes.
csharp
Kopioi koodi
private void PaivitaMuistiinpanoLista()
{
    muistiinpanoLista.Items.Clear();
    foreach (string muistiinpano in muistiinpanot)
    {
        muistiinpanoLista.Items.Add(muistiinpano);
    }
}
Searching Notes
button1_Click: Event handler for searching notes based on a keyword.
csharp
Kopioi koodi
private void button1_Click(object sender, EventArgs e)
{
    string avainsana = hakuTextBox.Text.ToLower();
    List<string> hakutulokset = muistiinpanot.Where(note => note.ToLower().Contains(avainsana)).ToList();

    muistiinpanoLista.Items.Clear();
    foreach (string tulos in hakutulokset)
    {
        muistiinpanoLista.Items.Add(tulos);
    }
}
Form Load Event
Form1_Load: Event handler for displaying the current date and time when the form loads.
csharp
Kopioi koodi
private void Form1_Load(object sender, EventArgs e)
{
    label1.Text = DateTime.Now.ToLongTimeString();
    label2.Text = DateTime.Now.ToLongDateString();
}
Controls in the Form
muistiinpanoTextBox: TextBox for entering new notes.
LisaaMuistiinpanoButton: Button for adding the entered note.
muistiinpanoLista: ListBox for displaying the list of notes.
PoistaMuistiinpanoButton: Button for deleting the selected note.
hakuTextBox: TextBox for entering a search keyword.
button1: Button for initiating the search.
label1: Label for displaying the current time.
label2: Label for displaying the current date.
Additional Notes
Ensure the form design includes all the necessary controls and they are properly named as referenced in the code.
Error handling and validation (e.g., ensuring non-empty inputs) can be added for better robustness.
This guide should help you understand the structure and functionality of the project. If you have any specific questions or need further details, feel free to ask!
