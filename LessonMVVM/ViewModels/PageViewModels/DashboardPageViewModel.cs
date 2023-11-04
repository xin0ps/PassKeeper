using LessonMVVM.Commands;
using LessonMVVM.Models;
using LessonMVVM.Views.Pages;
using LessonMVVM.Views.Windows;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace LessonMVVM.ViewModels.PageViewModels;

public class DashboardPageViewModel 
{




    public ICommand? SignIn { get; set; }

    public DashboardPageViewModel()
    {

        SignIn = new RelayCommand(signin);
     
    }

    public void signin(object? parameter)
    {

        var a = parameter as Page;
        if(a!= null)
        {

            a.NavigationService.Navigate(new SignInPage());
        }
      
    }



    
}
