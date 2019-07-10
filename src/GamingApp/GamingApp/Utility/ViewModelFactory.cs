using GamingApp.Interfaces;
using GamingApp.ViewModels;
using System;

namespace GamingApp.Utility
{
    public static class ViewModelFactory
    {
        private const string viewModelsNamespace = "GamingApp.ViewModels.";

        private const string viewsNamespace = "GamingApp.Views.";

        public static BaseViewModel CreateViewModel(string viewName, IServiceProvider serviceProvider)
        {
            var viewFullName = viewsNamespace + viewName;

            var viewType = Type.GetType(viewFullName);

            var view = (IView)serviceProvider.GetService(viewType);

            var viewModelFullName = $"{viewModelsNamespace}{viewName}Model";

            var viewModelType = Type.GetType(viewModelFullName);

            var viewModel = (BaseViewModel)serviceProvider.GetService(viewModelType);

            viewModel.View = view;
            view.DataContext = viewModel;

            return viewModel;
        }
    }
}
