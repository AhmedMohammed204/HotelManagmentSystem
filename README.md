# Hotel Management System (HMS) Documentation

The Hotel Management System (HMS) is a desktop application developed to emulate and streamline hotel booking processes. Built using the .NET Framework, ADO.NET, and Microsoft SQL Server, HMS offers a robust solution for managing hotel operations efficiently. It is an integral component of the [Swift Trips environment](https://github.com/Momennxd/SwiftTrips_APIs/tree/main), which provides a comprehensive platform for booking services such as hotels, flights, and cars.

## Table of Contents

1. [Introduction](#introduction)
2. [System Requirements](#system-requirements)
3. [Application Architecture](#application-architecture)
4. [Key Features](#key-features)
5. [User Guide](#user-guide)
6. [Troubleshooting](#troubleshooting)
7. [Contact](#contact)

## Introduction

HMS is designed to assist hotel administrators in managing bookings, guest information, room availability, and other essential operations. By leveraging the capabilities of ADO.NET for data access and Microsoft SQL Server for data storage, HMS ensures reliable and efficient data management.

## System Requirements

- **Operating System**: Windows 7 or later
- **.NET Framework**: Version 4.7.2 or higher
- **Database**: Microsoft SQL Server 2016 or later
- **Hardware**: Minimum 4 GB RAM, 2 GHz processor

## Application Architecture

HMS is structured following a modular design to promote maintainability and scalability. The primary components include:

- **Presentation Layer**: Handles user interactions through a Windows Forms interface.
- **Business Logic Layer**: Contains the core functionalities and business rules of the application.
- **Data Access Layer**: Manages database operations using ADO.NET to interact with Microsoft SQL Server.

This layered architecture ensures a clear separation of concerns, facilitating easier updates and maintenance.

## Key Features

- **Booking Management**: Create, view, modify, and cancel bookings with ease.
- **Guest Management**: Maintain comprehensive records of guest information.
- **Room Management**: Monitor room availability, assign rooms, and manage room statuses.
- **Reporting**: Generate detailed reports on bookings, occupancy rates, and financials.
- **User Authentication**: Secure login system with role-based access control.

## User Guide

### Launching the Application

- Double-click the HMS desktop icon or navigate to the installation directory and run `HMS.exe`.

### Logging In

- Enter your username and password on the login screen.
- Click "Login" to access the main dashboard.

### Managing Bookings

- Navigate to the "Bookings" section from the main menu.
- To create a new booking:
  - Click "New Booking."
  - Fill in the guest details, room selection, and booking dates.
  - Click "Save" to confirm.
- To modify or cancel an existing booking:
  - Select the booking from the list.
  - Choose "Edit" to modify or "Cancel" to remove the booking.

### Managing Guests

- Navigate to the "Guests" section.
- View the list of registered guests.
- To add a new guest:
  - Click "Add Guest."
  - Enter the required information.
  - Click "Save."

### Managing Rooms

- Navigate to the "Rooms" section.
- View the current status of all rooms.
- To update room information:
  - Select the room from the list.
  - Click "Edit."
  - Make the necessary changes and click "Save."

## Troubleshooting

- **Unable to Connect to Database**:
  - Ensure that SQL Server is running and accessible.
  - Verify that the connection string in `App.config` is correctly configured.
- **Application Crashes on Startup**:
  - Check that the .NET Framework version 4.7.2 or higher is installed.
  - Review the error logs located in the `Logs` folder within the installation directory for more details.

## Contact

For questions or support, please contact [ahmedbkry204@gmail.com](mailto:support@hmsapp.com).
