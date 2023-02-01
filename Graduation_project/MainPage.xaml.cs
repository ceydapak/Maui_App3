using System.Security.Claims;

namespace Graduation_project;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
        Note_List.ItemsSource = App.DBTrans.GetNotes();
	}

    private void Note_List_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        var selected = e.Item as Note;
        Detail.Id = selected.Id;
        Detail.Title = selected.Title;
        Detail.Description = selected.Description;  
        Detail.Date= selected.Date;
        Navigation.PushAsync(new DetailPage());

    }

    private void add_note_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AddNotePage());

    }

    private void ContentPage_Appearing(object sender, EventArgs e)
    {

        Note_List.ItemsSource = App.DBTrans.GetNotes();
    }
}

