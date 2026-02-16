# Student Score API

A robust and modernized .NET 8 Web API designed to help students track their academic performance and calculate necessary scores.

## Overview

This project provides a RESTful API for managing student data and their associated academic records. It has been re-architected to follow best practices, including the Repository Pattern, Dependency Injection, and a clean separation of concerns.

## Features

-   **Student Management**: Create, read, update, and delete student records.
-   **Secure Data Access**: Uses Entity Framework Core with a repository abstraction layer.
-   **Modern Architecture**: Built on .NET 8, ensuring high performance and long-term support.
-   **Swagger Documentation**: Integrated Swagger UI for easy API exploration and testing.
-   **MySQL Integration**:configured for seamless data persistence with MySQL.

## Technologies Used

-   **Framework**: .NET 8.0
-   **ORM**: Entity Framework Core 8.0.2 (Pomelo.EntityFrameworkCore.MySql)
-   **Database**: MySQL
-   **Testing**: xUnit, Moq
-   **Documentation**: Swashbuckle (Swagger)

## Getting Started

### Prerequisites

-   [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
-   [MySQL Server](https://dev.mysql.com/downloads/mysql/)

### Installation

1.  **Clone the repository**
    ```bash
    git clone https://github.com/Ayomide-R/StudentScoreAPI.git
    cd StudentScoreAPI
    ```

2.  **Configure Database**
    Update the connection string in `appsettings.json` to match your MySQL configuration:
    ```json
    "ConnectionStrings": {
      "DefaultConnection": "server=YOUR_SERVER;port=3306;database=studentscoreapi_bd;user=YOUR_USER;password=YOUR_PASSWORD"
    }
    ```

3.  **Build and Run**
    ```bash
    dotnet build
    dotnet run
    ```

4.  **Explore the API**
    Navigate to `https://localhost:7198/swagger` (or the port shown in your terminal) to view the interactive API documentation.

## Running Tests

The project includes a comprehensive unit test suite ensuring the reliability of core components.

```bash
dotnet test StudentScoreAPI.Tests
```

## Contributors

-   **Ayomide R.** - *Initial Work & Refactoring*

---
*Built with passion and modern .NET practices.*