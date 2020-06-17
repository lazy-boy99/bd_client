using System;
namespace aircraft_client.UI.Interfaces

{
    public interface ILoginView : IView
    {
        string Username { get; }
        string Password { get; }
        event Action Login;
        event Action Exit;
    }
}