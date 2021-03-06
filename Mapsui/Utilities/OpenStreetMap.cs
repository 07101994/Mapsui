﻿using BruTile.Predefined;
using BruTile.Web;
using Mapsui.Layers;

namespace Mapsui.Utilities
{
    public static class OpenStreetMap
    {
        private static readonly BruTile.Attribution OpenStreetMapAttribution = new BruTile.Attribution(
            "© OpenStreetMap contributors", "http://www.openstreetmap.org/copyright");

        public static TileLayer CreateTileLayer()
        {
            return new TileLayer(new HttpTileSource(new GlobalSphericalMercator(0, 18),
                        "http://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png",
                        new[] { "a", "b", "c" }, name: "OpenStreetMap",
                        attribution: OpenStreetMapAttribution));
        }
    }
}