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


