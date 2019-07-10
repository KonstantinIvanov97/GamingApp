using GamingApp.Utility;
using System;
using System.Windows.Input;

namespace GamingApp.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        private ICommand changeContentCommand;

        private IServiceProvider serviceProvider;

        private BaseViewModel currentContent;

        public MainViewModel(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public BaseViewModel CurrentContent
        {
            get
            {
                return currentContent;
            }
            set
            {
                if (currentContent == value)
                    return;

                currentContent = value;
                OnPropertyChanged(nameof(CurrentContent));
            }
        }

        public ICommand ChangeContentCommand
        {
            get
            {
                if (this.changeContentCommand == null)
                {
                    this.changeContentCommand =
                        new CommandHandler<string>(currentType => ChangeContent(currentType));
                }

                return this.changeContentCommand;
            }
        }

        private void ChangeContent(string view)
        {
            CurrentContent = ViewModelFactory.CreateViewModel(view, serviceProvider);
        }
    }
}
