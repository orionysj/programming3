# Programming3 Project


This collaborative project serves as a demonstration of our collective proficiency in C# programming. Through the implementation of Windows Forms, we aim not only to showcase our individual skills but also to enhance our understanding of creating user-friendly interfaces within the C# environment. This project provides us with a hands-on opportunity to apply and expand our knowledge in a team setting, emphasizing collaboration and mutual learning.

## MySQL Connector Configuration

To use this project with your MySQL database, you need to configure the `MySQLConnector.cs` file. Follow these steps:

1. Open the `MySQLConnector.cs` file located in the `YourProjectNamespace` folder.

2. Locate the `Initialize` method in the `MySQLConnector` class:

    ```csharp
    // Initialize the connection properties
    private void Initialize()
    {
        server = ""; // Replace with your MySQL server hostname or IP address
        database = ""; // Replace with your MySQL database name
        username = ""; // Replace with your MySQL username
        password = ""; // Replace with your MySQL password

        string connectionString = $"Server={server};Database={database};Uid={username};Pwd={password};";
        connection = new MySqlConnection(connectionString);
    }
    ```

3. Replace the placeholder values (`server`, `database`, `username`, `password`) with your MySQL server details:

    ```csharp
    // Initialize the connection properties
    private void Initialize()
    {
        server = "your_mysql_server"; // Replace with your MySQL server hostname or IP address
        database = "your_database_name"; // Replace with your MySQL database name
        username = "your_mysql_username"; // Replace with your MySQL username
        password = "your_mysql_password"; // Replace with your MySQL password

        string connectionString = $"Server={server};Database={database};Uid={username};Pwd={password};";
        connection = new MySqlConnection(connectionString);
    }
    ```

4. Save the changes.

## Getting Started with the Program

### Welcome to the program! Here's a quick guide on how to navigate and use its features:

![image](https://github.com/orionysj/programming3/assets/56135061/6a18b36a-9633-4a6b-9fe3-b752032963b7)


### Home Screen
- All pages share a consistent layout, ensuring familiarity.
- On the left side of the screen, find a list of functions for easy navigation.

### Navigation
1. Click on the desired function to access the corresponding page.
2. Each page provides settings located where app information is typically found.
  
### Performing Actions
- Once on a page, leverage the settings to manipulate displayed data or interact with the database.
  
Enjoy exploring the program's functionality! If you have any questions, refer to the documentation or feel free to reach out for assistance.

