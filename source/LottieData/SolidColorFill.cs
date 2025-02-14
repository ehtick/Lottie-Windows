// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Toolkit.Uwp.UI.Lottie.Animatables;

namespace Microsoft.Toolkit.Uwp.UI.Lottie.LottieData
{
#if PUBLIC_LottieData
    public
#endif
    sealed class SolidColorFill : ShapeFill
    {
        public SolidColorFill(
            in ShapeLayerContentArgs args,
            PathFillType fillType,
            Animatable<Opacity> opacity,
            Animatable<Color> color)
            : base(in args, fillType, opacity)
        {
            Color = color;
        }

        public Animatable<Color> Color { get; }

        public override ShapeFillKind FillKind => ShapeFillKind.SolidColor;

        /// <inheritdoc/>
        public override ShapeContentType ContentType => ShapeContentType.SolidColorFill;

        public override ShapeLayerContent WithTimeOffset(double offset)
        {
            return new SolidColorFill(CopyArgs(), FillType, Opacity.WithTimeOffset(offset), Color.WithTimeOffset(offset));
        }
    }
}
