namespace AppJuanDiegoSilva_MAUI;

public partial class NotePage_JDS : ContentPage
{

    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
    public NotePage_JDS()
	{
		InitializeComponent();

        if (File.Exists(_fileName))
            TextEditor.Text = File.ReadAllText(_fileName);
    }

    private void SaveButton_Clicked_JDS(object sender, EventArgs e)
    {
        // Save the file.
        File.WriteAllText(_fileName, TextEditor.Text);
    }

    private void DeleteButton_Clicked_JDS(object sender, EventArgs e)
    {
        // Delete the file.
        if (File.Exists(_fileName))
            File.Delete(_fileName);

        TextEditor.Text = string.Empty;
    }
}