```
 _______   __                                         
/       \ /  |                                        
$$$$$$$  |$$ |  ______   ________   ______    ______  
$$ |__$$ |$$ | /      \ /        | /      \  /      \ 
$$    $$< $$ | $$$$$$  |$$$$$$$$/ /$$$$$$  |/$$$$$$  |
$$$$$$$  |$$ | /    $$ |  /  $$/  $$ |  $$ |$$ |  $$/ 
$$ |__$$ |$$ |/$$$$$$$ | /$$$$/__ $$ \__$$ |$$ |      
$$    $$/ $$ |$$    $$ |/$$      |$$    $$/ $$ |      
$$$$$$$/  $$/  $$$$$$$/ $$$$$$$$/  $$$$$$/  $$/       
 ________               __                            
/        |             /  |                           
$$$$$$$$/______    ____$$ |  ______                   
   $$ | /      \  /    $$ | /      \                  
   $$ |/$$$$$$  |/$$$$$$$ |/$$$$$$  |                 
   $$ |$$ |  $$ |$$ |  $$ |$$ |  $$ |                 
   $$ |$$ \__$$ |$$ \__$$ |$$ \__$$ |                 
   $$ |$$    $$/ $$    $$ |$$    $$/                  
   $$/  $$$$$$/   $$$$$$$/  $$$$$$/                   
                                                      
```                                                      


# Project Overview

A simple task management web app built with Blazor on ASP.NET Core in .NET 10

Project was first created from the the dotnet template with `dotnet new blazor`.

Then the Movie Database App tutorial was built in with instuctions from:

https://dotnet.microsoft.com/en-us/learn/aspnet/blazor-tutorial/intro

and then from:

https://learn.microsoft.com/en-us/aspnet/core/blazor/tutorials/movie-database-app/part-1?view=aspnetcore-10.0&preserve-view=true&pivots=cli

For reference the full constructed Blazor Movie Database tutorial can be found here:

https://github.com/dotnet/blazor-samples/tree/main/8.0/BlazorWebAppMovies

And finally, the app was adapted into a task manager.


# Blazor learning notes

- Inject the NavigationManager and use the NavigateTo() method to change location
- For the EditForm component (and likely other built in components), use the Enhance flag to use SSR to sumbit the form without a full page  refresh
- Use the [SupplyParameterFromQuery] and [SupplyParameterFromQuery] to harvest values posted to the page
