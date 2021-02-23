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
namespace UnitsNet.Extensions.NumberToJerk
{
    public static class NumberToJerkExtensions
    {
        #region CentimeterPerSecondCubed

        /// <inheritdoc cref="Jerk.FromCentimetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk CentimetersPerSecondCubed(this int value) => Jerk.FromCentimetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromCentimetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? CentimetersPerSecondCubed(this int? value) => Jerk.FromCentimetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromCentimetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk CentimetersPerSecondCubed(this long value) => Jerk.FromCentimetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromCentimetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? CentimetersPerSecondCubed(this long? value) => Jerk.FromCentimetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromCentimetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk CentimetersPerSecondCubed(this double value) => Jerk.FromCentimetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromCentimetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? CentimetersPerSecondCubed(this double? value) => Jerk.FromCentimetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromCentimetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk CentimetersPerSecondCubed(this float value) => Jerk.FromCentimetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromCentimetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? CentimetersPerSecondCubed(this float? value) => Jerk.FromCentimetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromCentimetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk CentimetersPerSecondCubed(this decimal value) => Jerk.FromCentimetersPerSecondCubed(Convert.ToDouble(value));

        /// <inheritdoc cref="Jerk.FromCentimetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? CentimetersPerSecondCubed(this decimal? value) => Jerk.FromCentimetersPerSecondCubed(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region DecimeterPerSecondCubed

        /// <inheritdoc cref="Jerk.FromDecimetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk DecimetersPerSecondCubed(this int value) => Jerk.FromDecimetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromDecimetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? DecimetersPerSecondCubed(this int? value) => Jerk.FromDecimetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromDecimetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk DecimetersPerSecondCubed(this long value) => Jerk.FromDecimetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromDecimetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? DecimetersPerSecondCubed(this long? value) => Jerk.FromDecimetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromDecimetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk DecimetersPerSecondCubed(this double value) => Jerk.FromDecimetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromDecimetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? DecimetersPerSecondCubed(this double? value) => Jerk.FromDecimetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromDecimetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk DecimetersPerSecondCubed(this float value) => Jerk.FromDecimetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromDecimetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? DecimetersPerSecondCubed(this float? value) => Jerk.FromDecimetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromDecimetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk DecimetersPerSecondCubed(this decimal value) => Jerk.FromDecimetersPerSecondCubed(Convert.ToDouble(value));

        /// <inheritdoc cref="Jerk.FromDecimetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? DecimetersPerSecondCubed(this decimal? value) => Jerk.FromDecimetersPerSecondCubed(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region FootPerSecondCubed

        /// <inheritdoc cref="Jerk.FromFeetPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk FeetPerSecondCubed(this int value) => Jerk.FromFeetPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromFeetPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? FeetPerSecondCubed(this int? value) => Jerk.FromFeetPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromFeetPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk FeetPerSecondCubed(this long value) => Jerk.FromFeetPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromFeetPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? FeetPerSecondCubed(this long? value) => Jerk.FromFeetPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromFeetPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk FeetPerSecondCubed(this double value) => Jerk.FromFeetPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromFeetPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? FeetPerSecondCubed(this double? value) => Jerk.FromFeetPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromFeetPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk FeetPerSecondCubed(this float value) => Jerk.FromFeetPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromFeetPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? FeetPerSecondCubed(this float? value) => Jerk.FromFeetPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromFeetPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk FeetPerSecondCubed(this decimal value) => Jerk.FromFeetPerSecondCubed(Convert.ToDouble(value));

        /// <inheritdoc cref="Jerk.FromFeetPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? FeetPerSecondCubed(this decimal? value) => Jerk.FromFeetPerSecondCubed(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region InchPerSecondCubed

        /// <inheritdoc cref="Jerk.FromInchesPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk InchesPerSecondCubed(this int value) => Jerk.FromInchesPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromInchesPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? InchesPerSecondCubed(this int? value) => Jerk.FromInchesPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromInchesPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk InchesPerSecondCubed(this long value) => Jerk.FromInchesPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromInchesPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? InchesPerSecondCubed(this long? value) => Jerk.FromInchesPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromInchesPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk InchesPerSecondCubed(this double value) => Jerk.FromInchesPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromInchesPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? InchesPerSecondCubed(this double? value) => Jerk.FromInchesPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromInchesPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk InchesPerSecondCubed(this float value) => Jerk.FromInchesPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromInchesPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? InchesPerSecondCubed(this float? value) => Jerk.FromInchesPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromInchesPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk InchesPerSecondCubed(this decimal value) => Jerk.FromInchesPerSecondCubed(Convert.ToDouble(value));

        /// <inheritdoc cref="Jerk.FromInchesPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? InchesPerSecondCubed(this decimal? value) => Jerk.FromInchesPerSecondCubed(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilometerPerSecondCubed

        /// <inheritdoc cref="Jerk.FromKilometersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk KilometersPerSecondCubed(this int value) => Jerk.FromKilometersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromKilometersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? KilometersPerSecondCubed(this int? value) => Jerk.FromKilometersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromKilometersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk KilometersPerSecondCubed(this long value) => Jerk.FromKilometersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromKilometersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? KilometersPerSecondCubed(this long? value) => Jerk.FromKilometersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromKilometersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk KilometersPerSecondCubed(this double value) => Jerk.FromKilometersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromKilometersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? KilometersPerSecondCubed(this double? value) => Jerk.FromKilometersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromKilometersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk KilometersPerSecondCubed(this float value) => Jerk.FromKilometersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromKilometersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? KilometersPerSecondCubed(this float? value) => Jerk.FromKilometersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromKilometersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk KilometersPerSecondCubed(this decimal value) => Jerk.FromKilometersPerSecondCubed(Convert.ToDouble(value));

        /// <inheritdoc cref="Jerk.FromKilometersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? KilometersPerSecondCubed(this decimal? value) => Jerk.FromKilometersPerSecondCubed(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KnotPerHourSquared

        /// <inheritdoc cref="Jerk.FromKnotsPerHourSquared(UnitsNet.QuantityValue)" />
        public static Jerk KnotsPerHourSquared(this int value) => Jerk.FromKnotsPerHourSquared(value);

        /// <inheritdoc cref="Jerk.FromKnotsPerHourSquared(UnitsNet.QuantityValue)" />
        public static Jerk? KnotsPerHourSquared(this int? value) => Jerk.FromKnotsPerHourSquared(value);

        /// <inheritdoc cref="Jerk.FromKnotsPerHourSquared(UnitsNet.QuantityValue)" />
        public static Jerk KnotsPerHourSquared(this long value) => Jerk.FromKnotsPerHourSquared(value);

        /// <inheritdoc cref="Jerk.FromKnotsPerHourSquared(UnitsNet.QuantityValue)" />
        public static Jerk? KnotsPerHourSquared(this long? value) => Jerk.FromKnotsPerHourSquared(value);

        /// <inheritdoc cref="Jerk.FromKnotsPerHourSquared(UnitsNet.QuantityValue)" />
        public static Jerk KnotsPerHourSquared(this double value) => Jerk.FromKnotsPerHourSquared(value);

        /// <inheritdoc cref="Jerk.FromKnotsPerHourSquared(UnitsNet.QuantityValue)" />
        public static Jerk? KnotsPerHourSquared(this double? value) => Jerk.FromKnotsPerHourSquared(value);

        /// <inheritdoc cref="Jerk.FromKnotsPerHourSquared(UnitsNet.QuantityValue)" />
        public static Jerk KnotsPerHourSquared(this float value) => Jerk.FromKnotsPerHourSquared(value);

        /// <inheritdoc cref="Jerk.FromKnotsPerHourSquared(UnitsNet.QuantityValue)" />
        public static Jerk? KnotsPerHourSquared(this float? value) => Jerk.FromKnotsPerHourSquared(value);

        /// <inheritdoc cref="Jerk.FromKnotsPerHourSquared(UnitsNet.QuantityValue)" />
        public static Jerk KnotsPerHourSquared(this decimal value) => Jerk.FromKnotsPerHourSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="Jerk.FromKnotsPerHourSquared(UnitsNet.QuantityValue)" />
        public static Jerk? KnotsPerHourSquared(this decimal? value) => Jerk.FromKnotsPerHourSquared(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KnotPerMinuteSquared

        /// <inheritdoc cref="Jerk.FromKnotsPerMinuteSquared(UnitsNet.QuantityValue)" />
        public static Jerk KnotsPerMinuteSquared(this int value) => Jerk.FromKnotsPerMinuteSquared(value);

        /// <inheritdoc cref="Jerk.FromKnotsPerMinuteSquared(UnitsNet.QuantityValue)" />
        public static Jerk? KnotsPerMinuteSquared(this int? value) => Jerk.FromKnotsPerMinuteSquared(value);

        /// <inheritdoc cref="Jerk.FromKnotsPerMinuteSquared(UnitsNet.QuantityValue)" />
        public static Jerk KnotsPerMinuteSquared(this long value) => Jerk.FromKnotsPerMinuteSquared(value);

        /// <inheritdoc cref="Jerk.FromKnotsPerMinuteSquared(UnitsNet.QuantityValue)" />
        public static Jerk? KnotsPerMinuteSquared(this long? value) => Jerk.FromKnotsPerMinuteSquared(value);

        /// <inheritdoc cref="Jerk.FromKnotsPerMinuteSquared(UnitsNet.QuantityValue)" />
        public static Jerk KnotsPerMinuteSquared(this double value) => Jerk.FromKnotsPerMinuteSquared(value);

        /// <inheritdoc cref="Jerk.FromKnotsPerMinuteSquared(UnitsNet.QuantityValue)" />
        public static Jerk? KnotsPerMinuteSquared(this double? value) => Jerk.FromKnotsPerMinuteSquared(value);

        /// <inheritdoc cref="Jerk.FromKnotsPerMinuteSquared(UnitsNet.QuantityValue)" />
        public static Jerk KnotsPerMinuteSquared(this float value) => Jerk.FromKnotsPerMinuteSquared(value);

        /// <inheritdoc cref="Jerk.FromKnotsPerMinuteSquared(UnitsNet.QuantityValue)" />
        public static Jerk? KnotsPerMinuteSquared(this float? value) => Jerk.FromKnotsPerMinuteSquared(value);

        /// <inheritdoc cref="Jerk.FromKnotsPerMinuteSquared(UnitsNet.QuantityValue)" />
        public static Jerk KnotsPerMinuteSquared(this decimal value) => Jerk.FromKnotsPerMinuteSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="Jerk.FromKnotsPerMinuteSquared(UnitsNet.QuantityValue)" />
        public static Jerk? KnotsPerMinuteSquared(this decimal? value) => Jerk.FromKnotsPerMinuteSquared(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KnotPerSecondSquared

        /// <inheritdoc cref="Jerk.FromKnotsPerSecondSquared(UnitsNet.QuantityValue)" />
        public static Jerk KnotsPerSecondSquared(this int value) => Jerk.FromKnotsPerSecondSquared(value);

        /// <inheritdoc cref="Jerk.FromKnotsPerSecondSquared(UnitsNet.QuantityValue)" />
        public static Jerk? KnotsPerSecondSquared(this int? value) => Jerk.FromKnotsPerSecondSquared(value);

        /// <inheritdoc cref="Jerk.FromKnotsPerSecondSquared(UnitsNet.QuantityValue)" />
        public static Jerk KnotsPerSecondSquared(this long value) => Jerk.FromKnotsPerSecondSquared(value);

        /// <inheritdoc cref="Jerk.FromKnotsPerSecondSquared(UnitsNet.QuantityValue)" />
        public static Jerk? KnotsPerSecondSquared(this long? value) => Jerk.FromKnotsPerSecondSquared(value);

        /// <inheritdoc cref="Jerk.FromKnotsPerSecondSquared(UnitsNet.QuantityValue)" />
        public static Jerk KnotsPerSecondSquared(this double value) => Jerk.FromKnotsPerSecondSquared(value);

        /// <inheritdoc cref="Jerk.FromKnotsPerSecondSquared(UnitsNet.QuantityValue)" />
        public static Jerk? KnotsPerSecondSquared(this double? value) => Jerk.FromKnotsPerSecondSquared(value);

        /// <inheritdoc cref="Jerk.FromKnotsPerSecondSquared(UnitsNet.QuantityValue)" />
        public static Jerk KnotsPerSecondSquared(this float value) => Jerk.FromKnotsPerSecondSquared(value);

        /// <inheritdoc cref="Jerk.FromKnotsPerSecondSquared(UnitsNet.QuantityValue)" />
        public static Jerk? KnotsPerSecondSquared(this float? value) => Jerk.FromKnotsPerSecondSquared(value);

        /// <inheritdoc cref="Jerk.FromKnotsPerSecondSquared(UnitsNet.QuantityValue)" />
        public static Jerk KnotsPerSecondSquared(this decimal value) => Jerk.FromKnotsPerSecondSquared(Convert.ToDouble(value));

        /// <inheritdoc cref="Jerk.FromKnotsPerSecondSquared(UnitsNet.QuantityValue)" />
        public static Jerk? KnotsPerSecondSquared(this decimal? value) => Jerk.FromKnotsPerSecondSquared(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MeterPerSecondCubed

        /// <inheritdoc cref="Jerk.FromMetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk MetersPerSecondCubed(this int value) => Jerk.FromMetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromMetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? MetersPerSecondCubed(this int? value) => Jerk.FromMetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromMetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk MetersPerSecondCubed(this long value) => Jerk.FromMetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromMetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? MetersPerSecondCubed(this long? value) => Jerk.FromMetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromMetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk MetersPerSecondCubed(this double value) => Jerk.FromMetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromMetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? MetersPerSecondCubed(this double? value) => Jerk.FromMetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromMetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk MetersPerSecondCubed(this float value) => Jerk.FromMetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromMetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? MetersPerSecondCubed(this float? value) => Jerk.FromMetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromMetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk MetersPerSecondCubed(this decimal value) => Jerk.FromMetersPerSecondCubed(Convert.ToDouble(value));

        /// <inheritdoc cref="Jerk.FromMetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? MetersPerSecondCubed(this decimal? value) => Jerk.FromMetersPerSecondCubed(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MicrometerPerSecondCubed

        /// <inheritdoc cref="Jerk.FromMicrometersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk MicrometersPerSecondCubed(this int value) => Jerk.FromMicrometersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromMicrometersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? MicrometersPerSecondCubed(this int? value) => Jerk.FromMicrometersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromMicrometersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk MicrometersPerSecondCubed(this long value) => Jerk.FromMicrometersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromMicrometersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? MicrometersPerSecondCubed(this long? value) => Jerk.FromMicrometersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromMicrometersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk MicrometersPerSecondCubed(this double value) => Jerk.FromMicrometersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromMicrometersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? MicrometersPerSecondCubed(this double? value) => Jerk.FromMicrometersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromMicrometersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk MicrometersPerSecondCubed(this float value) => Jerk.FromMicrometersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromMicrometersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? MicrometersPerSecondCubed(this float? value) => Jerk.FromMicrometersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromMicrometersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk MicrometersPerSecondCubed(this decimal value) => Jerk.FromMicrometersPerSecondCubed(Convert.ToDouble(value));

        /// <inheritdoc cref="Jerk.FromMicrometersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? MicrometersPerSecondCubed(this decimal? value) => Jerk.FromMicrometersPerSecondCubed(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MillimeterPerSecondCubed

        /// <inheritdoc cref="Jerk.FromMillimetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk MillimetersPerSecondCubed(this int value) => Jerk.FromMillimetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromMillimetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? MillimetersPerSecondCubed(this int? value) => Jerk.FromMillimetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromMillimetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk MillimetersPerSecondCubed(this long value) => Jerk.FromMillimetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromMillimetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? MillimetersPerSecondCubed(this long? value) => Jerk.FromMillimetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromMillimetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk MillimetersPerSecondCubed(this double value) => Jerk.FromMillimetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromMillimetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? MillimetersPerSecondCubed(this double? value) => Jerk.FromMillimetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromMillimetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk MillimetersPerSecondCubed(this float value) => Jerk.FromMillimetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromMillimetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? MillimetersPerSecondCubed(this float? value) => Jerk.FromMillimetersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromMillimetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk MillimetersPerSecondCubed(this decimal value) => Jerk.FromMillimetersPerSecondCubed(Convert.ToDouble(value));

        /// <inheritdoc cref="Jerk.FromMillimetersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? MillimetersPerSecondCubed(this decimal? value) => Jerk.FromMillimetersPerSecondCubed(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region NanometerPerSecondCubed

        /// <inheritdoc cref="Jerk.FromNanometersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk NanometersPerSecondCubed(this int value) => Jerk.FromNanometersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromNanometersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? NanometersPerSecondCubed(this int? value) => Jerk.FromNanometersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromNanometersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk NanometersPerSecondCubed(this long value) => Jerk.FromNanometersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromNanometersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? NanometersPerSecondCubed(this long? value) => Jerk.FromNanometersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromNanometersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk NanometersPerSecondCubed(this double value) => Jerk.FromNanometersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromNanometersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? NanometersPerSecondCubed(this double? value) => Jerk.FromNanometersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromNanometersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk NanometersPerSecondCubed(this float value) => Jerk.FromNanometersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromNanometersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? NanometersPerSecondCubed(this float? value) => Jerk.FromNanometersPerSecondCubed(value);

        /// <inheritdoc cref="Jerk.FromNanometersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk NanometersPerSecondCubed(this decimal value) => Jerk.FromNanometersPerSecondCubed(Convert.ToDouble(value));

        /// <inheritdoc cref="Jerk.FromNanometersPerSecondCubed(UnitsNet.QuantityValue)" />
        public static Jerk? NanometersPerSecondCubed(this decimal? value) => Jerk.FromNanometersPerSecondCubed(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region StandardGravityPerSecond

        /// <inheritdoc cref="Jerk.FromStandardGravityPerSecond(UnitsNet.QuantityValue)" />
        public static Jerk StandardGravityPerSecond(this int value) => Jerk.FromStandardGravityPerSecond(value);

        /// <inheritdoc cref="Jerk.FromStandardGravityPerSecond(UnitsNet.QuantityValue)" />
        public static Jerk? StandardGravityPerSecond(this int? value) => Jerk.FromStandardGravityPerSecond(value);

        /// <inheritdoc cref="Jerk.FromStandardGravityPerSecond(UnitsNet.QuantityValue)" />
        public static Jerk StandardGravityPerSecond(this long value) => Jerk.FromStandardGravityPerSecond(value);

        /// <inheritdoc cref="Jerk.FromStandardGravityPerSecond(UnitsNet.QuantityValue)" />
        public static Jerk? StandardGravityPerSecond(this long? value) => Jerk.FromStandardGravityPerSecond(value);

        /// <inheritdoc cref="Jerk.FromStandardGravityPerSecond(UnitsNet.QuantityValue)" />
        public static Jerk StandardGravityPerSecond(this double value) => Jerk.FromStandardGravityPerSecond(value);

        /// <inheritdoc cref="Jerk.FromStandardGravityPerSecond(UnitsNet.QuantityValue)" />
        public static Jerk? StandardGravityPerSecond(this double? value) => Jerk.FromStandardGravityPerSecond(value);

        /// <inheritdoc cref="Jerk.FromStandardGravityPerSecond(UnitsNet.QuantityValue)" />
        public static Jerk StandardGravityPerSecond(this float value) => Jerk.FromStandardGravityPerSecond(value);

        /// <inheritdoc cref="Jerk.FromStandardGravityPerSecond(UnitsNet.QuantityValue)" />
        public static Jerk? StandardGravityPerSecond(this float? value) => Jerk.FromStandardGravityPerSecond(value);

        /// <inheritdoc cref="Jerk.FromStandardGravityPerSecond(UnitsNet.QuantityValue)" />
        public static Jerk StandardGravityPerSecond(this decimal value) => Jerk.FromStandardGravityPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="Jerk.FromStandardGravityPerSecond(UnitsNet.QuantityValue)" />
        public static Jerk? StandardGravityPerSecond(this decimal? value) => Jerk.FromStandardGravityPerSecond(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
