SignalR Real-Time Chat App

This is a simple ASP.NET Core SignalR application that enables real-time communication between clients using WebSockets. It includes a backend SignalR hub and a frontend to send and receive messages.

🚀 Getting Started

Prerequisites

Ensure you have the following installed:

.NET 6 SDK

A modern web browser (Chrome, Edge, Firefox, etc.)

1️⃣ Clone the Repository

git clone https://github.com/your-username/SignalRApp.git
cd SignalRApp

2️⃣ Install Dependencies

dotnet restore

3️⃣ Run the Application

dotnet run

The application will start at http://localhost:5073.

📂 SignalRApp
 ┣ 📂 wwwroot           # Static frontend files
 ┃ ┗ 📄 index.html      # Frontend entry point
 ┣ 📂 Hubs
 ┃ ┗ 📄 ChatHub.cs      # SignalR Hub implementation
 ┣ 📄 Program.cs        # App configuration
 ┗ 📄 SignalRApp.csproj # Project file



🔧 How It Works

Backend:

The ChatHub.cs file defines the SignalR Hub, which enables real-time communication.

The Program.cs file configures the app and serves static files.

Frontend:

The index.html file connects to the SignalR Hub and enables real-time messaging.

📌 Conclusion

This SignalR application enables real-time messaging between clients. If you encounter issues, ensure CORS is correctly configured, index.html is inside wwwroot/, and the frontend connects to the right port.
