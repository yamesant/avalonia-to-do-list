using System;
using AvaloniaToDoList.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaToDoList.ViewModels;

/*   NOTE:
 *
 *   Please mind that this samples uses the CommunityToolkit.Mvvm package for the ViewModels. Feel free to use any other
 *   MVVM-Framework (like ReactiveUI or Prism) that suits your needs best.
 *
 */


/// <summary>
/// This is a ViewModel which represents a <see cref="Models.ToDoItem"/>
/// </summary>
public partial class ToDoItemViewModel : ViewModelBase
{
    /// <summary>
    /// Creates a new blank ToDoItemViewModel
    /// </summary>
    public ToDoItemViewModel()
    {
        // empty
    }
    
    /// <summary>
    /// Creates a new ToDoItemViewModel for the given <see cref="Models.ToDoItem"/>
    /// </summary>
    /// <param name="item">The item to load</param>
    public ToDoItemViewModel(ToDoItem item)
    {
        // Init the properties with the given values
        Content = item.Content;
        CompletionDateTime = item.CompletionDateTime;
        Status = item.Status;
    }
    
    /// <summary>
    /// Gets or sets the content of the to-do item
    /// </summary>
    [ObservableProperty] 
    private string? _content;

    [ObservableProperty]
    private DateTime? _completionDateTime;

    [ObservableProperty]
    private ToDoItemStatus _status;
    
    /// <summary>
    /// Gets a ToDoItem of this ViewModel
    /// </summary>
    /// <returns>The ToDoItem</returns>
    public ToDoItem GetToDoItem()
    {
        return new ToDoItem()
        {
            Content = Content,
            CompletionDateTime = CompletionDateTime,
            Status = Status,
        };
    }
}