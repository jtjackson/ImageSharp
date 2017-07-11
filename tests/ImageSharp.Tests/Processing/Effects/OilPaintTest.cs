// <copyright file="OilPaintTest.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace ImageSharp.Tests.Processing.Effects
{
    using ImageSharp.PixelFormats;
    using ImageSharp.Processing.Processors;
    using SixLabors.Primitives;
    using Xunit;

    public class OilPaintTest : BaseImageOperationsExtensionTest
    {
        [Fact]
        public void OilPaint_OilPaintingProcessorDefaultsSet()
        {
            this.operations.OilPaint();
            var processor = this.Verify<OilPaintingProcessor<Rgba32>>();

            Assert.Equal(10, processor.Levels);
            Assert.Equal(15, processor.BrushSize);
        }

        [Fact]
        public void OilPaint_rect_OilPaintingProcessorDefaultsSet()
        {
            this.operations.OilPaint(this.rect);
            var processor = this.Verify<OilPaintingProcessor<Rgba32>>(this.rect);

            Assert.Equal(10, processor.Levels);
            Assert.Equal(15, processor.BrushSize);
        }
        [Fact]
        public void OilPaint_Levels_Brsuh_OilPaintingProcessorDefaultsSet()
        {
            this.operations.OilPaint(34, 65);
            var processor = this.Verify<OilPaintingProcessor<Rgba32>>();

            Assert.Equal(34, processor.Levels);
            Assert.Equal(65, processor.BrushSize);
        }

        [Fact]
        public void OilPaint_Levels_Brsuh_rect_OilPaintingProcessorDefaultsSet()
        {
            this.operations.OilPaint(54, 43, this.rect);
            var processor = this.Verify<OilPaintingProcessor<Rgba32>>(this.rect);

            Assert.Equal(54, processor.Levels);
            Assert.Equal(43, processor.BrushSize);
        }
    }
}