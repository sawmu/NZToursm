# Tourism Web Application (ASP.NET Core MVC)

## 📘 1. Introduction

The **Tourism** website is an ASP.NET Core MVC application built for showcasing New Zealand tourist destinations.  
It demonstrates dynamic searching, filtering, sorting, and paging features, with well-structured code adhering to the MVC architecture.

---

## 🧩 2. Functional & Technical Requirements

| Requirement | Implemented? | Description |
|--------------|--------------|--------------|
| Clear MVC Separation | ✅ | `Models`, `Views`, and `Controllers` are clearly separated. |
| Custom Models | ✅ | `Destination`, `Region`, and `RegionExtensions` models created by the student. |
| Searching | ✅ | Keyword search in destination name, description, and category. |
| Filtering | ✅ | Region, category, island, minimum rating, popularity filters. |
| Sorting | ✅ | By name, rating, popularity, newest. |
| Paging | ✅ | 10 items per page with Previous/Next navigation. |
| Custom CSS | ✅ | `wwwroot/css/site.css` — unique design with gradient hero, rounded search, cards, and footer. |
| JavaScript Interaction | ✅ | Gallery swap script on Details page. |
| Documentation | ✅ | This report explains the logic and code organization. |

---

## 🗂 3. Architecture Overview

### 📄 Models
- **`Destination`** – Defines the data structure for each destination.
- **`Region`** – Enum listing all 16 New Zealand regions.
- **`RegionExtensions`** – Helper extension to classify regions by North/South Island.

### 🧠 Controllers
- **`DestinationsController`** – Implements searching, filtering, sorting, and paging logic.
- **`HomeController`** – Displays the landing (home) page.

### 🖼 Views
- **Home/Index.cshtml** – Landing page hero section.  
- **Destinations/Index.cshtml** – Main view showing filters, cards, and pagination.  
- **Destinations/Details.cshtml** – Individual destination with image gallery and Back button.  
- **Shared/_Layout.cshtml** – Global navigation and header/footer.  
- **Shared/_ViewImports.cshtml** – Enables MVC tag helpers.

---

## ⚙️ 4. Key Code Walkthrough

### **Data/AppDb.cs**
```csharp
public static void Seed()
{
    if (Destinations.Count > 0) return;

    Destinations.AddRange(new[]
    {
        new Destination {
            Id = 1, Name="Bay of Islands", Region=Region.Northland, Category="Beaches",
            Rating=4.6, IsPopular=true,
            Description="Hundreds of subtropical islands with beaches and sailing.",
            ImageUrl="https://images.unsplash.com/photo-1579547945413-497e1b99dac7?q=80&w=1200&auto=format&fit=crop"
        },
        ...
    });
}
