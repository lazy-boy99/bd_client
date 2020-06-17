namespace aircraft_client.UI.Interfaces
{
    public interface IView
    {
        void Show();
        void Close();
        void ShowError(string errorMessage, string title);
    }
}