namespace Tourism.Models;

public static class RegionExtensions
{
    // Very small helper to classify regions into islands.
    public static string Island(this Region r) => r switch
    {
        Region.Northland or Region.Auckland or Region.Waikato or Region.BayOfPlenty
        or Region.Gisborne or Region.HawkesBay or Region.Taranaki
        or Region.ManawatuWhanganui or Region.Wellington => "North Island",

        Region.Tasman or Region.Nelson or Region.Marlborough or Region.WestCoast
        or Region.Canterbury or Region.Otago or Region.Southland => "South Island",

        _ => "Unknown"
    };
}
