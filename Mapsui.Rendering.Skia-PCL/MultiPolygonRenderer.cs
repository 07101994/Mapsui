﻿using Mapsui.Geometries;
using Mapsui.Providers;
using Mapsui.Styles;
using SkiaSharp;

namespace Mapsui.Rendering.Skia
{
    public static class MultiPolygonRenderer
    {
        public static void Draw(SKCanvas canvas, IViewport viewport, IStyle style, IFeature feature, IGeometry geometry)
        {
            var multiPolygon = (MultiPolygon) geometry;

            foreach (var polygon in multiPolygon)
            {
                PolygonRenderer.Draw(canvas, viewport, style, feature, polygon);
            }
        }
    }
}