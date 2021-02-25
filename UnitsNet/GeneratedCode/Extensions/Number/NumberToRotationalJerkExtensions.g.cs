﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

// Windows Runtime Component does not support extension methods and method overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
namespace UnitsNet.Extensions.NumberToRotationalJerk
{
    public static class NumberToRotationalJerkExtensions
    {
        #region DegreePerSecondCubed

        /// <inheritdoc cref="RotationalJerk.FromDegreesPerSecondCubed(UnitsNet.QuantityValue)" />
        public static RotationalJerk DegreesPerSecondCubed(this int value) => RotationalJerk.FromDegreesPerSecondCubed(value);

        /// <inheritdoc cref="RotationalJerk.FromDegreesPerSecondCubed(UnitsNet.QuantityValue)" />
        public static RotationalJerk? DegreesPerSecondCubed(this int? value) => RotationalJerk.FromDegreesPerSecondCubed(value);

        /// <inheritdoc cref="RotationalJerk.FromDegreesPerSecondCubed(UnitsNet.QuantityValue)" />
        public static RotationalJerk DegreesPerSecondCubed(this long value) => RotationalJerk.FromDegreesPerSecondCubed(value);

        /// <inheritdoc cref="RotationalJerk.FromDegreesPerSecondCubed(UnitsNet.QuantityValue)" />
        public static RotationalJerk? DegreesPerSecondCubed(this long? value) => RotationalJerk.FromDegreesPerSecondCubed(value);

        /// <inheritdoc cref="RotationalJerk.FromDegreesPerSecondCubed(UnitsNet.QuantityValue)" />
        public static RotationalJerk DegreesPerSecondCubed(this double value) => RotationalJerk.FromDegreesPerSecondCubed(value);

        /// <inheritdoc cref="RotationalJerk.FromDegreesPerSecondCubed(UnitsNet.QuantityValue)" />
        public static RotationalJerk? DegreesPerSecondCubed(this double? value) => RotationalJerk.FromDegreesPerSecondCubed(value);

        /// <inheritdoc cref="RotationalJerk.FromDegreesPerSecondCubed(UnitsNet.QuantityValue)" />
        public static RotationalJerk DegreesPerSecondCubed(this float value) => RotationalJerk.FromDegreesPerSecondCubed(value);

        /// <inheritdoc cref="RotationalJerk.FromDegreesPerSecondCubed(UnitsNet.QuantityValue)" />
        public static RotationalJerk? DegreesPerSecondCubed(this float? value) => RotationalJerk.FromDegreesPerSecondCubed(value);

        /// <inheritdoc cref="RotationalJerk.FromDegreesPerSecondCubed(UnitsNet.QuantityValue)" />
        public static RotationalJerk DegreesPerSecondCubed(this decimal value) => RotationalJerk.FromDegreesPerSecondCubed(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalJerk.FromDegreesPerSecondCubed(UnitsNet.QuantityValue)" />
        public static RotationalJerk? DegreesPerSecondCubed(this decimal? value) => RotationalJerk.FromDegreesPerSecondCubed(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region RadianPerSecondCubed

        /// <inheritdoc cref="RotationalJerk.FromRadiansPerSecondCubed(UnitsNet.QuantityValue)" />
        public static RotationalJerk RadiansPerSecondCubed(this int value) => RotationalJerk.FromRadiansPerSecondCubed(value);

        /// <inheritdoc cref="RotationalJerk.FromRadiansPerSecondCubed(UnitsNet.QuantityValue)" />
        public static RotationalJerk? RadiansPerSecondCubed(this int? value) => RotationalJerk.FromRadiansPerSecondCubed(value);

        /// <inheritdoc cref="RotationalJerk.FromRadiansPerSecondCubed(UnitsNet.QuantityValue)" />
        public static RotationalJerk RadiansPerSecondCubed(this long value) => RotationalJerk.FromRadiansPerSecondCubed(value);

        /// <inheritdoc cref="RotationalJerk.FromRadiansPerSecondCubed(UnitsNet.QuantityValue)" />
        public static RotationalJerk? RadiansPerSecondCubed(this long? value) => RotationalJerk.FromRadiansPerSecondCubed(value);

        /// <inheritdoc cref="RotationalJerk.FromRadiansPerSecondCubed(UnitsNet.QuantityValue)" />
        public static RotationalJerk RadiansPerSecondCubed(this double value) => RotationalJerk.FromRadiansPerSecondCubed(value);

        /// <inheritdoc cref="RotationalJerk.FromRadiansPerSecondCubed(UnitsNet.QuantityValue)" />
        public static RotationalJerk? RadiansPerSecondCubed(this double? value) => RotationalJerk.FromRadiansPerSecondCubed(value);

        /// <inheritdoc cref="RotationalJerk.FromRadiansPerSecondCubed(UnitsNet.QuantityValue)" />
        public static RotationalJerk RadiansPerSecondCubed(this float value) => RotationalJerk.FromRadiansPerSecondCubed(value);

        /// <inheritdoc cref="RotationalJerk.FromRadiansPerSecondCubed(UnitsNet.QuantityValue)" />
        public static RotationalJerk? RadiansPerSecondCubed(this float? value) => RotationalJerk.FromRadiansPerSecondCubed(value);

        /// <inheritdoc cref="RotationalJerk.FromRadiansPerSecondCubed(UnitsNet.QuantityValue)" />
        public static RotationalJerk RadiansPerSecondCubed(this decimal value) => RotationalJerk.FromRadiansPerSecondCubed(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalJerk.FromRadiansPerSecondCubed(UnitsNet.QuantityValue)" />
        public static RotationalJerk? RadiansPerSecondCubed(this decimal? value) => RotationalJerk.FromRadiansPerSecondCubed(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region RevolutionPerMinutePerSecondSquared

        /// <inheritdoc cref="RotationalJerk.FromRevolutionsPerMinutePerSecondSquared(UnitsNet.QuantityValue)" />
        public static RotationalJerk RevolutionsPerMinutePerSecondSquared(this int value) => RotationalJerk.FromRevolutionsPerMinutePerSecondSquared(value);

        /// <inheritdoc cref="RotationalJerk.FromRevolutionsPerMinutePerSecondSquared(UnitsNet.QuantityValue)" />
        public static RotationalJerk? RevolutionsPerMinutePerSecondSquared(this int? value) => RotationalJerk.FromRevolutionsPerMinutePerSecondSquared(value);

        /// <inheritdoc cref="RotationalJerk.FromRevolutionsPerMinutePerSecondSquared(UnitsNet.QuantityValue)" />
        public static RotationalJerk RevolutionsPerMinutePerSecondSquared(this long value) => RotationalJerk.FromRevolutionsPerMinutePerSecondSquared(value);

        /// <inheritdoc cref="RotationalJerk.FromRevolutionsPerMinutePerSecondSquared(UnitsNet.QuantityValue)" />
        public static RotationalJerk? RevolutionsPerMinutePerSecondSquared(this long? value) => RotationalJerk.FromRevolutionsPerMinutePerSecondSquared(value);

        /// <inheritdoc cref="RotationalJerk.FromRevolutionsPerMinutePerSecondSquared(UnitsNet.QuantityValue)" />
        public static RotationalJerk RevolutionsPerMinutePerSecondSquared(this double value) => RotationalJerk.FromRevolutionsPerMinutePerSecondSquared(value);

        /// <inheritdoc cref="RotationalJerk.FromRevolutionsPerMinutePerSecondSquared(UnitsNet.QuantityValue)" />
        public static RotationalJerk? RevolutionsPerMinutePerSecondSquared(this double? value) => RotationalJerk.FromRevolutionsPerMinutePerSecondSquared(value);

        /// <inheritdoc cref="RotationalJerk.FromRevolutionsPerMinutePerSecondSquared(UnitsNet.QuantityValue)" />
        public static RotationalJerk RevolutionsPerMinutePerSecondSquared(this float value) => RotationalJerk.FromRevolutionsPerMinutePerSecondSquared(value);

        /// <inheritdoc cref="RotationalJerk.FromRevolutionsPerMinutePerSecondSquared(UnitsNet.QuantityValue)" />
        public static RotationalJerk? RevolutionsPerMinutePerSecondSquared(this float? value) => RotationalJerk.FromRevolutionsPerMinutePerSecondSquared(value);

        /// <inheritdoc cref="RotationalJerk.FromRevolutionsPerMinutePerSecondSquared(UnitsNet.QuantityValue)" />
        public static RotationalJerk RevolutionsPerMinutePerSecondSquared(this decimal value) => RotationalJerk.FromRevolutionsPerMinutePerSecondSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="RotationalJerk.FromRevolutionsPerMinutePerSecondSquared(UnitsNet.QuantityValue)" />
        public static RotationalJerk? RevolutionsPerMinutePerSecondSquared(this decimal? value) => RotationalJerk.FromRevolutionsPerMinutePerSecondSquared(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
