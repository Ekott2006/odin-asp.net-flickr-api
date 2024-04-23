# Project: Flickr API (ASP.NET)

This project implements a flickr application similar to the Ruby on Rails version covered in The Odin Project's [curriculum](https://www.theodinproject.com/lessons/ruby-on-rails-flickr-api). Here, we'll achieve the same functionality using ASP.NET Core.

## Prerequisites

- **.NET Core SDK:** Ensure you have the .NET Core SDK installed that matches your target framework version (e.g., .NET 8.0). Verify the installation by running `dotnet --version` in CMD. If not installed, download it from [official website](https://dotnet.microsoft.com/en-us/download).
- **Git:** Download and install Git from [official download page](https://git-scm.com/downloads). Verify installation by running `git --version` in CMD.
- **Obtain Flickr API Key:** Visit the [project description](https://www.theodinproject.com/lessons/ruby-on-rails-flickr-api) for details on how to get Flickr API Key.

## Steps

1. **Clone the Repository:**
    - Open CMD and navigate to the desired directory where you want to clone the repository.

   ```bash
   git clone https://github.com/Ekott2006/odin-asp.net-flickr-api.git
   ```

   This will clone the repository into a new folder named `odin-asp.net-flickr-api`.

2. **Navigate to Project Directory:**
    - Change directory into the cloned repository:

   ```bash
   cd odin-asp.net-flickr-api/WebApp
   ```

3. **Insert the API Key:**
    - Open the `appsettings.json` file located in the project root directory.
    - Locate the "Key" inside "FlickrAPI".
    - Replace the placeholder with your obtained Google API key.

4. **Run the Application:**
    - Execute the following command to build and launch the application:

   ```bash
   dotnet run
   ```

The application should start and be accessible in your default web browser, typically at `http://localhost:5276`
