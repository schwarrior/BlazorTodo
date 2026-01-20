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

- Override the OnInitializedAsync component event to harvest incoming parameters and setup the component
- Inject the NavigationManager and use the NavigateTo() method to change location
- For the EditForm component (and likely other built in components), use the Enhance flag to use SSR to sumbit the form without a full page  refresh
- Use the [SupplyParameterFromQuery] to harvest values posted to the page
- Use the [SupplyParameterFromForm] to reference form input values on the current page in the @code portion of the razor page
- ! is the null forgiving operator. When suffixing a value, allow a nullable value to be used where a not null value is required. Suppress warnings and errors.
- Use the Blazore QuickGrid component to display data in a table
- Continue on Part 4 - Work with a database https://learn.microsoft.com/en-us/aspnet/core/blazor/tutorials/movie-database-app/part-4?view=aspnetcore-10.0&pivots=cli


# Blazor learning question

- Does the following razor condition re-evaluate when the movie is loaded async by OnInitiailizedAsync and GetFirstOrDefaultAsync? Or does it wait to evaulate until the awaiting GetFirstOrDefaultAsync method finishes? 

```html,razor
@if (movie is null)
    {
        <p><em>Loading...</em></p>
    }
    else {
        <!-- set up the the table header row -->
    }
```

