# Ceinor Technical Interview - Blazor

## 📝 Overview
This technical assessment evaluates your skills as a Fullstack Blazor Developer. The test focuses on:

- **Frontend**: Creating responsive UI components with Blazor
- **Styling**: Implementing custom CSS with attention to design
- **Backend**: Building API controllers and business logic
- **Architecture**: Following the established components and business logic patterns

**Recommended time:** 1 hour 30 minutes
  
While there is no strict time limit, we suggest aiming to complete the task within this timeframe. This will be measured from the moment you accept the assignment to your last commit.

## 🏗️ Project Structure
```
CeinorBlazor/
├─ CeinorBlazor.Client/	                       # Blazor WebAssembly Client
│  ├─ Pages/                                   # Razor pages
│  └─ Services/                                # Client-side services
├─ CeinorBlazor/                               # ASP.NET Core Server
│  ├─ Controllers/                             # API Controllers
│  ├─ Executors/                               # Business logic layer
│  └─ Services/                                # Data access layer
├─ CeinorBlazor.Components/                    # Reusable Component Library
│  ├─ CeinorCard.razor                         # Card component example
│  └─ CeinorButton.razor                       # Button component example
└─ CeinorBlazor.Shared/                        # Shared DTOs and Models
   └─ Models/
```

### Current Implementation

1. **Component Library** (`CeinorBlazor.Components`)
   - `CeinorCard` - Styled card component with header, content, and actions
   - `CeinorButton` - Button component with variants (Primary, Secondary, Success, Danger, Warning)
   - Both components include scoped CSS styling

2. **Client Application**
   - `UserService` - Service to fetch users from the API
   - `Users.razor` - Page displaying users using the component library

3. **Server Application**
   - `UsersController` - API controller for user operations
   - `MockUserDataService` - Mock data service with sample users

4. **Shared Models**
   - `UserDto` - User data transfer object

## ✏️ Your Task

Build a **user search component** that encapsulates filters and actions, is responsive (mobile and desktop), respects light/dark theme, and reuses the component library (`CeinorButton`, `CeinorCard`, and new components in the library when appropriate). When navigating away and back to `/users`, filter values must persist and be re-applied.

### 🔍 Filter Component Requirements
- A single text input for searching by **name** or **email**.
- A **checkbox** to filter by **all/active/inactive**.
- A **combobox** of **roles** using the roles available from the full list; include an option **"All roles"** (selected by default).
- A **Search** button that includes **text and an icon**.
- Encapsulate all filters and the button in a filter component thats is exclusively used from the **Users** page.
- Attractive and usable design with minimal complexity.

### 🛰️ Backend Requirements
- Create a **new executor** to filter the full user list based on the filters provided by the client.
- Expose the filtered search via the API so `UserService` can request filtered users.

### 🔄 Filter Persistence
- When navigating between pages in Blazor, filters must be preserved and re-applied when returning to `/users`.

#### ➕ Bonus

This is not a requirement, only do it if you have time left, preferrably as a separate commit:

- Add unit tests for the executors **GetUsers**, **GetUserById**, and **GetUsersByFilter**.

## 🌟 Tips for Success
1. **Time Management**: Allocate time wisely across all parts
2. **Start Simple**: Get basic functionality working first, then enhance
3. **Consistent Styling**: Match your styles to existing components, use and expand the current theme CSS variables
4. **Test As You Go**: Run the application frequently to verify your changes
5. **Comments**: Add brief comments to explain complex logic

## ✅ Submission
When complete, ensure:
1. All code compiles without errors
2. The application runs and all routes work
3. Your new component is properly styled
4. The API endpoint returns correct data
5. The UI is responsive and polished

## 🍀 Good Luck!

Show us your best work!
