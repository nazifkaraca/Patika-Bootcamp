# Asp.Net Core MVC Structure Setup

In this practical project, the objective is to create an ASP.NET Core Empty project and configure its structure according to the MVC (Model-View-Controller) design pattern.

## Project Structure

Please create and configure the following folders:

- **Controllers Folder**: Add a folder named `Controllers` where the project's controllers will reside.
- **Models Folder**: Add a folder named `Models` to contain the data models used in the application.
- **Views Folder**: Add a folder named `Views` to store the view templates.
- **wwwroot Folder**: Add a folder named `wwwroot` where static files (CSS, JavaScript, images, etc.) will be stored and accessed.

## Configuration Instructions

After setting up the folder structure, open the `Program.cs` file and implement the following configurations:

1. **Add MVC Services**:
   - Enable MVC application features to support both views and controllers. This will allow the application to handle incoming requests and respond with rendered views.

2. **Enable Static Files**:
   - Configure the application to serve static files from the `wwwroot` folder, ensuring that CSS, JavaScript, images, and other resources can be accessed in the application.

3. **Configure Routing**:
   - Set up routing to properly handle incoming requests and direct them to the correct controllers and actions.

4. **Default Routing**:
   - Define a default route for the homepage that specifies the default controller, action, and any necessary parameters.

## Key Concepts and Methods

At the bottom of `Program.cs`, add explanations as comments for the following concepts and methods:

- **Controller**: A class responsible for handling HTTP requests and returning the appropriate response.
- **Action**: A method within a controller that processes requests and returns a specific view or data.
- **Model**: Represents the data structure in the application, used to manage and transfer data between the controller and the view.
- **View**: Represents the UI of the application and is rendered as HTML to the user.
- **Razor**: A syntax for embedding server-side code in views to render dynamic HTML.
- **RazorView**: A Razor-based view that combines Razor syntax with HTML, allowing dynamic content rendering.
- **wwwroot**: The folder used to store static files such as CSS, JavaScript, and images, making them accessible to the client.
- **builder.Build()**: A method that builds the application and prepares it for execution.
- **app.Run()**: Starts the application and begins listening for incoming requests.

---

## Summary

1. Create folders: `Controllers`, `Models`, `Views`, `wwwroot`.
2. Add MVC services to support controllers and views.
3. Enable serving static files from `wwwroot`.
4. Set up routing for request handling.
5. Define a default route for the homepage.
