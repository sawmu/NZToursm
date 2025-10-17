using Microsoft.AspNetCore.Mvc;
using Tourism.Data;
using Tourism.Models;

namespace Tourism.Controllers;

/// <summary>
/// Destinations listing + details. Implements Searching, Filtering, Sorting, Paging
/// using query-string parameters for a simple, bookmarkable UI.
/// </summary>
public class DestinationsController : Controller
{
    // Show 10 per page to match the requirement example
    private const int PageSize = 10;

    /// <param name="q">Search text (name/description/category match)</param>
    /// <param name="region">Exact Region filter</param>
    /// <param name="category">Category filter (e.g., Nature/Adventure/...)</param>
    /// <param name="island">"North Island" | "South Island"</param>
    /// <param name="minRating">Minimum rating (0..5)</param>
    /// <param name="popularOnly">Only popular items (true/false)</param>
    /// <param name="sort">
    /// name_asc | name_desc | rating_desc | rating_asc | popular_desc | newest
    /// </param>
    /// <param name="page">1-based page index</param>
    public IActionResult Index(
        string? q,
        Region? region,
        string? category,
        string? island,
        double? minRating,
        bool popularOnly = false,
        string sort = "name_asc",
        int page = 1)
    {
        // Keep UI state for the View
        ViewData["q"] = q;
        ViewData["region"] = region;
        ViewData["category"] = category;
        ViewData["island"] = island;
        ViewData["minRating"] = minRating;
        ViewData["popularOnly"] = popularOnly;
        ViewData["sort"] = sort;

        IEnumerable<Destination> query = AppDb.Destinations;

        // Searching (name, description, category)
        if (!string.IsNullOrWhiteSpace(q))
        {
            var needle = q.Trim().ToLowerInvariant();
            query = query.Where(d =>
                d.Name.ToLowerInvariant().Contains(needle) ||
               (d.Description?.ToLowerInvariant().Contains(needle) ?? false) ||
                d.Category.ToLowerInvariant().Contains(needle));
        }

        // Filtering
        if (region.HasValue) query = query.Where(d => d.Region == region.Value);

        if (!string.IsNullOrWhiteSpace(category))
            query = query.Where(d => d.Category.Equals(category, StringComparison.OrdinalIgnoreCase));

        if (!string.IsNullOrWhiteSpace(island))
            query = query.Where(d => d.Region.Island().Equals(island, StringComparison.OrdinalIgnoreCase));

        if (minRating is >= 0 and <= 5)
            query = query.Where(d => d.Rating >= minRating!.Value);

        if (popularOnly)
            query = query.Where(d => d.IsPopular);

        // ↕ Sorting
        query = sort switch
        {
            "name_desc"    => query.OrderByDescending(d => d.Name),
            "rating_desc"  => query.OrderByDescending(d => d.Rating).ThenBy(d => d.Name),
            "rating_asc"   => query.OrderBy(d => d.Rating).ThenBy(d => d.Name),
            "popular_desc" => query.OrderByDescending(d => d.IsPopular).ThenByDescending(d => d.Rating),
            "newest"       => query.OrderByDescending(d => d.Id), // assuming higher Id = newer
            _              => query.OrderBy(d => d.Name) // name_asc
        };

        // Paging
        var total = query.Count();
        var totalPages = Math.Max(1, (int)Math.Ceiling(total / (double)PageSize));
        var safePage = Math.Clamp(page, 1, totalPages);
        var items = query.Skip((safePage - 1) * PageSize).Take(PageSize).ToList();

        // Data for UI widgets
        ViewData["Total"] = total;
        ViewData["Page"] = safePage;
        ViewData["PageSize"] = PageSize;
        ViewData["TotalPages"] = totalPages;
        ViewData["Categories"] = AppDb.Destinations.Select(d => d.Category).Distinct().OrderBy(s => s).ToList();
        ViewData["Islands"] = new[] { "North Island", "South Island" };

        return View(items);
    }

    public IActionResult Details(int id)
    {
        var item = AppDb.Destinations.FirstOrDefault(d => d.Id == id);
        if (item is null) return NotFound();
        return View(item);
    }
}
