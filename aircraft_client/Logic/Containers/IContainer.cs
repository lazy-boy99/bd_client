﻿namespace aircraft_client.Logic.Containers

{
    public interface IContainer
    {
        void Register<TService, TImplementation>() where TImplementation : TService;
        void Register<TService>();
        void RegisterInstance<T>(T instance);
        TService Resolve<TService>();
        bool IsRegistered<TService>();
    }
}