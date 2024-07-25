# ASP.NET Core Razor Pages Image Selector

This project is a simple web application built with ASP.NET Core Razor Pages and C#. It allows users to select different programming language images from a dropdown list and displays the selected image dynamically using both client-side and server-side approaches.

## Overview

This project serves as a beginner-friendly introduction to ASP.NET Core and C# for web development. It demonstrates:

- Setting up a basic Razor Pages application.
- Using C# for server-side logic to handle user input and update the UI.
- Implementing a dynamic image selector:
  - **Server-side**: Updates the image on form submission without JavaScript.
  - **Client-side**: Dynamically updates the image using JavaScript for immediate feedback.

<video width="640" height="360" controls>
  <source src="./readme_media/project.mp4" type="video/mp4">
  Your browser does not support the video tag.
</video>

## Getting Started

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) installed on your machine.

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/thankyoucode/506-dotnet-csharp.git
   cd your-repository
   ```

2. Restore dependencies and build the project:

   ```bash
   dotnet restore
   dotnet build
   ```

### Usage

1. Run the application:

   ```bash
   dotnet run
   ```

2. Open a web browser and navigate to `https://localhost:5001` (or `http://localhost:5000`).

   **Note:** If port `5000` is already in use, the application may run on a different port such as `5001`. Check the console output after running `dotnet run` for the exact URL.

3. **Server-side Approach:**

   - You will see a dropdown list with options like Python, C, React, and Angular.
   - Selecting an option and submitting the form updates the displayed image below it.

4. **Client-side Approach:**

   - There is a second dropdown list that updates the image immediately using JavaScript when an option is selected.
   - This provides immediate visual feedback without a full page refresh.

## Technologies Used

- ASP.NET Core Razor Pages
- C# programming language
- HTML, Razor syntax, and JavaScript for views
