using CommunityToolkit.Mvvm.Input;
using Proyecto_1.Models;

namespace Proyecto_1.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}