namespace Graduation_project;

public partial class AddNotePage : ContentPage
{
    
   
	public AddNotePage()
	{
		InitializeComponent();

	}

    private void Send_Btn_Clicked(object sender, EventArgs e)
    {
        var note = new Note();
        note.Title = title.Text;
        note.Date = DateTime.Now;
        note.Description = note_entry.Text;
        App.DBTrans.InsertNote(note);
        DisplayAlert("Success", "Adding is successful", "OK");
      
       // Navigation.PushAsync(new MainPage());

    }

    private void ContentPage_Appearing(object sender, EventArgs e)
    {
        App.DBTrans.GetNotes();
    }
}