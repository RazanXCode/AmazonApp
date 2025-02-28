# AmazonApp

## Project Overview
AmazonApp is a simple ASP.NET Core MVC project that simulates an e-commerce platform. It allows users to view products, place orders, and view order history.

## Setup Instructions
### Prerequisites:
- .NET
- Visual Studio 2022 (or VS Code with C# extension)
- Bootstrap (Included via CDN in _Layout.cshtml)

### Steps to Run the Project:
1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/AmazonApp.git
   ```
2. Open the project in Visual Studio.
3. Set **AmazonApp** as the startup project.
4. Run the application using  `dotnet run`.
5. Navigate to `http://localhost:5000/` (or the assigned port) in your browser.

## Features Implemented
- **Product Management:**
  - Displays a list of available products.
  - Uses Bootstrap for responsive design.
- **Order Management:**
  - Allows users to place an order using a form.
  - Tracks order history by User ID.
- **Navigation Bar:**
  - Provides quick access to "Products" and "Place Order" pages.
- **Attribute-Based Routing:**
  - `GET /Products` → Displays product list.
  - `GET /Orders/PlaceOrder` → Displays order placement form.
  - `GET /Orders/{userId}` → Retrieves and displays order history.

## Upcoming Features
- **User Authentication** (Login/Signup system)
- **Product Filtering and Search**

## Technologies Used
- **ASP.NET Core MVC** (C#)
- **Bootstrap 5** (CDN for styling)
- **HTML**

## How to Contribute
1. Fork the repository.
2. Create a new branch:
   ```bash
   git checkout -b feature-branch
   ```
3. Make your changes and commit them:
   ```bash
   git commit -m "Add new feature"
   ```
4. Push to your fork:
   ```bash
   git push origin feature-branch
   ```
5. Submit a pull request.

---


