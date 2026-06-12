# Record Store Frontend

A Blazor web application for browsing and managing records in the Record Store inventory system.

This application connects to the Record Store API and allows users to view records, browse inventory, and edit album information through a user-friendly interface.

---

## Features

### Current Features

- View all records in stock
- View album details
- Edit album information
- Update records via the Record Store API
- Album cover image support
- Form validation using Data Annotations
- Loading and error state handling

### Technologies Used

- C#
- Blazor Server / Interactive Server
- ASP.NET Core
- HTML
- CSS
- HttpClient
- REST API Integration

---

## Getting Started

### Prerequisites

You will need:

- .NET 8 SDK (or the version specified by your project)
- Visual Studio 2022 or Visual Studio Code
- The Record Store API running locally

### Clone the Repository

```bash
git clone <repository-url>
cd Record-Store-FrontEnd
```

### Run the Application

```bash
dotnet restore
dotnet run
```

The application will launch in your browser.

---

## Backend Dependency

This frontend relies on the Record Store API being available.

Ensure the backend project is running before starting the frontend.

Example API URL:

```text
https://localhost:7093
```

Update any API URLs in the application if your backend uses a different port.

---

## Project Structure

```text
Components/
│
├── RecordSummary.razor
├── RecordsSummaryList.razor
├── RecordsLoader.razor
└── RecordDetails.razor

Models/
│
├── Record.cs
└── UpdatedAlbumRequest.cs

Pages/
│
└── Home.razor
```

---

## Example User Journey

### Viewing Records

1. User visits the application.
2. RecordsLoader requests data from the API.
3. RecordsSummaryList displays available records.
4. RecordSummary displays basic information for each record.

### Editing a Record

1. User navigates to an album edit page.
2. Existing album information is loaded from the API.
3. User updates one or more fields.
4. User selects **Save Changes**.
5. A PUT request is sent to the API.
6. Updated information is persisted to the database.

---

## Validation

The application uses Blazor's built-in validation features:

- DataAnnotationsValidator
- ValidationMessage components
- Required field validation
- Input type validation

---

## Error Handling

The application includes:

- API request error handling
- User-friendly error messages
- Loading indicators during API requests
- Validation feedback on forms

---

## Future Improvements

Potential future enhancements include:

- Album search functionality
- Filtering by artist, genre, and release year
- Album creation functionality
- Album deletion functionality
- User authentication and authorisation
- Responsive mobile-first design improvements
- Pagination for large inventories
- Improved styling and accessibility support

---

## Learning Outcomes

This project demonstrates:

- Component-based UI development with Blazor
- API integration using HttpClient
- Form handling and validation
- State management
- CRUD operations
- Separation of concerns
- Responsive frontend design principles

---

## Author

Created as part of the Northcoders Software Development Programme.
