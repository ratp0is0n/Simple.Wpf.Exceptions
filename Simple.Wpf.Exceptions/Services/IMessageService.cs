namespace Simple.Wpf.Exceptions.Services
{
    using System;
    using Models;
    using ViewModels;

    public interface IMessageService : IService
    {
        IObservable<Message> Show { get; }

        void Post(string header, ICloseableViewModel viewModel);
    }
}
