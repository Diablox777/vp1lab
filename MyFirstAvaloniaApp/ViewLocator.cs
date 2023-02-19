using Avalonia.Controls;
using Avalonia.Controls.Templates;
using MyFirstAvaloniaApp.ViewModels;
using System;

namespace MyFirstAvaloniaApp
{
    public class ViewLocator : IDataTemplate
    {
        public IControl Build(object data)
        {
            var names = data.GetType().FullName!.Replace("ViewModel", "View");
            var types = Type.GetType(names);

            if (types != null)
            {
                return (Control)Activator.CreateInstance(types)!;
            }
            else
            {
                return new TextBlock { Text = "Not Found: " + names };
            }
        }

        public bool Match(object data)
        {
            return data is ViewModelBase;
        }
    }
}
