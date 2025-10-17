using Tourism.Models;

namespace Tourism.Data;

/// <summary>
/// Minimal in-memory "Db" just for this assignment.
/// No EF required, but the API looks list-like so you can replace later.
/// </summary>
public static class AppDb
{
    // NOTE: List<T> acts as our "table"
    public static List<Destination> Destinations { get; } = new();

    // Call once at startup to populate demo content
    public static void Seed()
{
    if (Destinations.Count > 0) return;

    Destinations.AddRange(new[]
    {
        // NORTHLAND
        new Destination {
            Id = 1, Name="Bay of Islands", Region=Region.Northland, Category="Beaches",
            Rating=4.6, IsPopular=true,
            Description="Hundreds of subtropical islands with beaches and sailing in Northland.",
            ImageUrl="https://images.unsplash.com/photo-1641546356703-1bd4bb656f9b?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&q=80&w=1207"
        },
        new Destination {
            Id = 2, Name="Cape Reinga Lighthouse", Region=Region.Northland, Category="Scenic",
            Rating=4.8, IsPopular=true,
            Description="Where the Tasman Sea meets the Pacific Ocean at the northern tip of NZ.",
            ImageUrl="https://images.unsplash.com/photo-1598421695310-482cab033ebc?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&q=80&w=1170"
        },

        // AUCKLAND
        new Destination {
            Id = 3, Name="Sky Tower", Region=Region.Auckland, Category="Adventure",
            Rating=4.5, IsPopular=true,
            Description="Auckland’s iconic tower with observation decks and the SkyJump.",
            ImageUrl="https://images.unsplash.com/photo-1677557769796-a63930e463b5?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&q=80&w=1171"
        },
        new Destination {
            Id = 4, Name="Waiheke Island", Region=Region.Auckland, Category="Nature",
            Rating=4.7, IsPopular=true,
            Description="A short ferry ride from Auckland with vineyards and white-sand beaches.",
            ImageUrl="https://images.unsplash.com/photo-1710563447214-a856ea672171?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&q=80&w=1074"
        },

        // WAIKATO
        new Destination {
            Id = 5, Name="Hobbiton Movie Set", Region=Region.Waikato, Category="Historical",
            Rating=4.8, IsPopular=true,
            Description="Step into the Shire! Guided tours of the LOTR & Hobbit film set.",
            ImageUrl="https://images.unsplash.com/photo-1667514625690-5fcf02c23c21?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&q=80&w=1170"
        },
        new Destination {
            Id = 6, Name="Waitomo Glowworm Caves", Region=Region.Waikato, Category="Adventure",
            Rating=4.6, IsPopular=true,
            Description="Boat ride under glittering glowworms and limestone formations.",
            ImageUrl="https://images.unsplash.com/photo-1577729182857-5202978ad76c?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&q=80&w=1170"
        },

        // BAY OF PLENTY
        new Destination {
            Id = 7, Name="Mount Maunganui", Region=Region.BayOfPlenty, Category="Beaches",
            Rating=4.7, IsPopular=true,
            Description="Golden-sand beach and summit views over Tauranga.",
            ImageUrl="https://images.unsplash.com/photo-1588027216464-a3225f923383?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&q=80&w=1171"
        },
        new Destination {
            Id = 8, Name="Wai-O-Tapu Thermal Wonderland", Region=Region.BayOfPlenty, Category="Nature",
            Rating=4.5, IsPopular=true,
            Description="Colorful geothermal wonderland near Rotorua.",
            ImageUrl="https://images.unsplash.com/photo-1516483638261-f4dbaf036963?q=80&w=1200&auto=format&fit=crop"
        },

        // GISBORNE
        new Destination {
            Id = 9, Name="Rere Rockslide", Region=Region.Gisborne, Category="Adventure",
            Rating=4.3, IsPopular=false,
            Description="Natural rock waterslide—bring a boogie board!",
            ImageUrl="https://images.unsplash.com/photo-1507525428034-b723cf961d3e?q=80&w=1200&auto=format&fit=crop"
        },
        new Destination {
            Id = 10, Name="Eastwoodhill Arboretum", Region=Region.Gisborne, Category="Nature",
            Rating=4.4, IsPopular=false,
            Description="National arboretum with scenic tree walks.",
            ImageUrl="https://images.unsplash.com/photo-1502082553048-f009c37129b9?q=80&w=1200&auto=format&fit=crop"
        },

        // HAWKES BAY
        new Destination {
            Id = 11, Name="Napier Art Deco Walk", Region=Region.HawkesBay, Category="Historical",
            Rating=4.6, IsPopular=true,
            Description="Explore 1930s Art Deco architecture and heritage buildings.",
            ImageUrl="https://images.unsplash.com/photo-1528909514045-2fa4ac7a08ba?q=80&w=1200&auto=format&fit=crop"
        },
        new Destination {
            Id = 12, Name="Te Mata Peak", Region=Region.HawkesBay, Category="Scenic",
            Rating=4.7, IsPopular=true,
            Description="Panoramic views over Hawke’s Bay wine region.",
            ImageUrl="https://images.unsplash.com/photo-1507525428034-b723cf961d3e?q=80&w=1200&auto=format&fit=crop"
        },

        // TARANAKI
        new Destination {
            Id = 13, Name="Mount Taranaki", Region=Region.Taranaki, Category="Adventure",
            Rating=4.7, IsPopular=true,
            Description="Symmetrical volcano offering alpine hikes and waterfalls.",
            ImageUrl="https://images.unsplash.com/photo-1513836279014-a89f7a76ae86?q=80&w=1200&auto=format&fit=crop"
        },
        new Destination {
            Id = 14, Name="New Plymouth Coastal Walkway", Region=Region.Taranaki, Category="Family-Friendly",
            Rating=4.5, IsPopular=false,
            Description="13 km waterfront path with stunning bridges and sea views.",
            ImageUrl="https://images.unsplash.com/photo-1707291665769-e5e281bc68fa?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&q=80&w=1244"
        },

        // 🏞 MANAWATU-WHANGANUI
        new Destination {
            Id = 15, Name="Tongariro Alpine Crossing", Region=Region.ManawatuWhanganui, Category="Adventure",
            Rating=4.9, IsPopular=true,
            Description="World-renowned one-day hike through volcanic landscapes.",
            ImageUrl="https://images.unsplash.com/photo-1502786129293-79981df4e689?q=80&w=1200&auto=format&fit=crop"
        },
        new Destination {
            Id = 16, Name="Whanganui River Journey", Region=Region.ManawatuWhanganui, Category="Nature",
            Rating=4.5, IsPopular=false,
            Description="Multi-day canoe trip through lush gorges and native bush.",
            ImageUrl="https://images.unsplash.com/photo-1665563654265-436d54bee41b?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&q=80&w=1170"
        },

        // WELLINGTON
        new Destination {
            Id = 17, Name="Te Papa Museum", Region=Region.Wellington, Category="Museums",
            Rating=4.6, IsPopular=true,
            Description="New Zealand’s national museum of art, culture, and history.",
            ImageUrl="https://images.unsplash.com/photo-1680436601148-09e3a102d1f4?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&q=80&w=1171"
        },
        new Destination {
            Id = 18, Name="Zealandia Sanctuary", Region=Region.Wellington, Category="Nature",
            Rating=4.6, IsPopular=false,
            Description="Fenced valley sanctuary rewilding native birds and reptiles.",
            ImageUrl="https://plus.unsplash.com/premium_photo-1730078556314-dda2f21fff53?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&q=80&w=1170"
        },

        // TASMAN
        new Destination {
            Id = 19, Name="Abel Tasman National Park", Region=Region.Tasman, Category="Nature",
            Rating=4.8, IsPopular=true,
            Description="Golden beaches and turquoise bays along the coastal track.",
            ImageUrl="https://images.unsplash.com/photo-1668010884237-a469a7c93c93?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&q=80&w=1173"
        },

        // NELSON
        new Destination {
            Id = 20, Name="Nelson Lakes National Park", Region=Region.Nelson, Category="Scenic",
            Rating=4.5, IsPopular=false,
            Description="Alpine lakes and hiking trails in the northern South Island.",
            ImageUrl="https://images.unsplash.com/photo-1506744038136-46273834b3fb?q=80&w=1200&auto=format&fit=crop"
        },

        // MARLBOROUGH
        new Destination {
            Id = 21, Name="Marlborough Wine Trail", Region=Region.Marlborough, Category="Family-Friendly",
            Rating=4.4, IsPopular=true,
            Description="Cycle between vineyards tasting world-famous Sauvignon Blanc.",
            ImageUrl="https://images.unsplash.com/photo-1510626176961-4b57d4fbad03?q=80&w=1200&auto=format&fit=crop"
        },

        // 🌧 WEST COAST
        new Destination {
            Id = 22, Name="Franz Josef Glacier", Region=Region.WestCoast, Category="Adventure",
            Rating=4.6, IsPopular=true,
            Description="Glacier hikes and helicopter tours through icy landscapes.",
            ImageUrl="https://images.unsplash.com/photo-1705591878587-8c2cb45f1e91?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&q=80&w=1170"
        },
        new Destination {
            Id = 23, Name="Punakaiki Pancake Rocks", Region=Region.WestCoast, Category="Nature",
            Rating=4.6, IsPopular=true,
            Description="Unique limestone rock formations and blowholes.",
            ImageUrl="https://images.unsplash.com/photo-1570399698888-a87707749d1a?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&q=80&w=1170"
        },

        // CANTERBURY
        new Destination {
            Id = 24, Name="Aoraki / Mount Cook", Region=Region.Canterbury, Category="Nature",
            Rating=4.9, IsPopular=true,
            Description="New Zealand’s highest peak, ideal for hiking and stargazing.",
            ImageUrl="https://images.unsplash.com/photo-1683713193512-e8f0d36febd1?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&q=80&w=1170"
        },
        new Destination {
            Id = 25, Name="Lake Tekapo", Region=Region.Canterbury, Category="Scenic",
            Rating=4.7, IsPopular=true,
            Description="Lakeside Church of the Good Shepherd under clear night skies.",
            ImageUrl="https://images.unsplash.com/photo-1612038032672-b94a10ce7ebd?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&q=80&w=1170"
        },

        // 🎿 OTAGO
        new Destination {
            Id = 26, Name="Queenstown Skyline", Region=Region.Otago, Category="Adventure",
            Rating=4.8, IsPopular=true,
            Description="Gondola rides, luge tracks, and sweeping mountain views.",
            ImageUrl="https://images.unsplash.com/photo-1507608616759-54f48f0af0ee?q=80&w=1200&auto=format&fit=crop"
        },
        new Destination {
            Id = 27, Name="Milford Sound Cruise", Region=Region.Otago, Category="Nature",
            Rating=4.9, IsPopular=true,
            Description="Majestic fjord with waterfalls and wildlife in Fiordland.",
            ImageUrl="https://images.unsplash.com/photo-1676407422248-3f8ae12f03c9?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&q=80&w=1074"
        },

        // SOUTHLAND
        new Destination {
            Id = 28, Name="Stewart Island / Rakiura", Region=Region.Southland, Category="Nature",
            Rating=4.5, IsPopular=false,
            Description="Remote island paradise known for native kiwi birds.",
            ImageUrl="https://images.unsplash.com/photo-1583221953317-949514407dd0?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&q=80&w=1170"
        },
        new Destination {
            Id = 29, Name="Invercargill Transport World", Region=Region.Southland, Category="Museums",
            Rating=4.6, IsPopular=false,
            Description="Huge private museum of vintage cars and trucks.",
            ImageUrl="https://images.unsplash.com/photo-1730007992507-1dee93f365ba?ixlib=rb-4.1.0&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&q=80&w=1170"
        }
    });
}

}
