# 🌏 Tourism Website Project

## 📝 Project Overview

The **Tourism Website** is a modern ASP.NET Core MVC application designed to showcase and promote New Zealand's most beautiful tourist destinations.  
It features dynamic data-driven pages with searching, filtering, sorting, and pagination functionality, offering a clean and user-friendly experience.

This project demonstrates the use of the **Model-View-Controller (MVC)** architecture, incorporating Razor Pages, LINQ queries, and responsive front-end design principles.

---

## ✨ Key Features

- 🧭 **MVC Architecture:** Clear separation between Models, Views, and Controllers.  
- 🔍 **Search:** Find destinations by keywords such as “beach” or “museum.”  
- 🎯 **Filter:** Narrow down results by region, category, or popularity.  
- 🔢 **Sorting:** Sort destinations by name, rating, or popularity.  
- 📄 **Pagination:** View destinations across multiple pages.  
- 🖼️ **Gallery View:** Interactive image display for each destination.  
- 💅 **Custom Styling:** Tailored CSS based on Bootstrap for a professional, New Zealand-inspired design.  
- ⚡ **Lightweight & Responsive:** Works across desktop and mobile devices.

---

## 🧰 Technologies Used

- **Backend:** ASP.NET Core MVC (C#)  
- **Frontend:** Razor Pages, HTML5, CSS3, JavaScript  
- **Frameworks:** Bootstrap 5  
- **Database:** In-memory data seeding (AppDb.cs)  
- **Version Control:** Git & GitHub  
- **IDE:** Visual Studio / VS Code

---

## 🚀 Installation & Setup

### 1. Prerequisites
Ensure the following are installed:
- [.NET SDK 9.0 or later](https://dotnet.microsoft.com/download)
- Visual Studio / Visual Studio Code
- Git (optional, for cloning the repository)

### 2. Clone the Repository
```bash
git clone https://github.com/sawmu/NZTourism.git
cd NZTourism/Tourism
```

### 3. Restore Dependencies
```bash
dotnet restore
```

### 4. Build the Project
```bash
dotnet build
```

### 5. Run the Application
```bash
dotnet run
```

Once started, visit the URL below in your browser:  
```
http://localhost:5000
```
or  
```
https://localhost:7000
```

---

## 💻 How to Run the Project

1. **Open the project folder** (`NZTourism/Tourism`) in VS Code or Visual Studio.  
2. If using **Visual Studio**, open the `NZTourism.sln` solution file.  
3. Set **Tourism** as the startup project.  
4. Press **F5** or click **Run** to start the application.  
5. Navigate to your browser and open `http://localhost:5000`.  

**To stop the server:** Press `Ctrl + C` in your terminal.

---

## 🧭 Website Navigation

- **Home Page:** Introduces the website.  
- **Destinations Page:** Displays destinations with search, filter, and paging.  
- **Details Page:** Displays full information about each destination with an image gallery.  

---

## 🪄 Demo Script (for presentation)

1. Open the website using `dotnet run`.  
2. Navigate to **Destinations**.  
3. Use the **Search Bar** to look for “Hobbiton” or “Queenstown.”  
4. Apply filters to view destinations by region (e.g., North Island).  
5. Change sorting to “Highest Rated.”  
6. Navigate through pages using pagination.  
7. Click “Read More” to open the detailed destination page.  
8. Try the interactive image gallery feature.  

---

## 📸 Media Credits

All images are sourced exclusively from **[Unsplash.com](https://unsplash.com)** under the **Unsplash License**, which allows free use for educational and non-commercial purposes.  
Attribution is included where required.

**Example:**
```html
<img src="/img/queenstown.webp" alt="Queenstown Skyline" loading="lazy" decoding="async" width="800" height="533" />
```

---

## 🧠 Author & License

Developed by **Saw Mu Ka Hbaw Aye**.  
All content and media comply with fair use and educational licensing.

---

✅ **End of README**
