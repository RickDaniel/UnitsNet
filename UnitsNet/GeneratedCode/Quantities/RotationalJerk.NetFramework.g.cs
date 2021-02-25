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
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     Angular jerk is the rate of change of rotational acceleration.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    public partial struct RotationalJerk : IComparable, IComparable<RotationalJerk>
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        #region Nullable From Methods

        /// <summary>
        ///     Get nullable RotationalJerk from nullable DegreesPerSecondCubed.
        /// </summary>
        public static RotationalJerk? FromDegreesPerSecondCubed(QuantityValue? degreespersecondcubed)
        {
            return degreespersecondcubed.HasValue ? FromDegreesPerSecondCubed(degreespersecondcubed.Value) : default(RotationalJerk?);
        }

        /// <summary>
        ///     Get nullable RotationalJerk from nullable RadiansPerSecondCubed.
        /// </summary>
        public static RotationalJerk? FromRadiansPerSecondCubed(QuantityValue? radianspersecondcubed)
        {
            return radianspersecondcubed.HasValue ? FromRadiansPerSecondCubed(radianspersecondcubed.Value) : default(RotationalJerk?);
        }

        /// <summary>
        ///     Get nullable RotationalJerk from nullable RevolutionsPerMinutePerSecondSquared.
        /// </summary>
        public static RotationalJerk? FromRevolutionsPerMinutePerSecondSquared(QuantityValue? revolutionsperminutepersecondsquared)
        {
            return revolutionsperminutepersecondsquared.HasValue ? FromRevolutionsPerMinutePerSecondSquared(revolutionsperminutepersecondsquared.Value) : default(RotationalJerk?);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="RotationalJerkUnit" /> to <see cref="RotationalJerk" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>RotationalJerk unit value.</returns>
        public static RotationalJerk? From(QuantityValue? value, RotationalJerkUnit fromUnit)
        {
            return value.HasValue ? new RotationalJerk((double)value.Value, fromUnit) : default(RotationalJerk?);
        }

        #endregion

        #region Arithmetic Operators

        public static RotationalJerk operator -(RotationalJerk right)
        {
            return new RotationalJerk(-right.Value, right.Unit);
        }

        public static RotationalJerk operator +(RotationalJerk left, RotationalJerk right)
        {
            return new RotationalJerk(left.Value + right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static RotationalJerk operator -(RotationalJerk left, RotationalJerk right)
        {
            return new RotationalJerk(left.Value - right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static RotationalJerk operator *(double left, RotationalJerk right)
        {
            return new RotationalJerk(left * right.Value, right.Unit);
        }

        public static RotationalJerk operator *(RotationalJerk left, double right)
        {
            return new RotationalJerk(left.Value * right, left.Unit);
        }

        public static RotationalJerk operator /(RotationalJerk left, double right)
        {
            return new RotationalJerk(left.Value / right, left.Unit);
        }

        public static double operator /(RotationalJerk left, RotationalJerk right)
        {
            return left.RadiansPerSecondCubed / right.RadiansPerSecondCubed;
        }

        #endregion

        public static bool operator <=(RotationalJerk left, RotationalJerk right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >=(RotationalJerk left, RotationalJerk right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator <(RotationalJerk left, RotationalJerk right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >(RotationalJerk left, RotationalJerk right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(RotationalJerk left, RotationalJerk right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value == right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(RotationalJerk left, RotationalJerk right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value != right.AsBaseNumericType(left.Unit);
        }

        #region Parsing

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static RotationalJerk Parse(string str, [CanBeNull] IFormatProvider provider)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));

            provider = provider ?? UnitSystem.DefaultCulture;

            return QuantityParser.Parse<RotationalJerk, RotationalJerkUnit>(str, provider,
                delegate(string value, string unit, IFormatProvider formatProvider2)
                {
                    double parsedValue = double.Parse(value, formatProvider2);
                    RotationalJerkUnit parsedUnit = ParseUnit(unit, formatProvider2);
                    return From(parsedValue, parsedUnit);
                }, (x, y) => FromRadiansPerSecondCubed(x.RadiansPerSecondCubed + y.RadiansPerSecondCubed));
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] IFormatProvider provider, out RotationalJerk result)
        {
            provider = provider ?? UnitSystem.DefaultCulture;

            try
            {
                result = Parse(str, provider);
                return true;
            }
            catch
            {
                result = default(RotationalJerk);
                return false;
            }
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static RotationalJerkUnit ParseUnit(string str, IFormatProvider provider = null)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));

            var unitSystem = UnitSystem.GetCached(provider);
            var unit = unitSystem.Parse<RotationalJerkUnit>(str.Trim());

            if (unit == RotationalJerkUnit.Undefined)
            {
                var newEx = new UnitsNetException("Error parsing string. The unit is not a recognized RotationalJerkUnit.");
                newEx.Data["input"] = str;
                newEx.Data["provider"] = provider?.ToString() ?? "(null)";
                throw newEx;
            }

            return unit;
        }

        #endregion

        #region ToString Methods

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <returns>String representation.</returns>
        public string ToString(RotationalJerkUnit unit, [CanBeNull] IFormatProvider provider)
        {
            return ToString(unit, provider, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(RotationalJerkUnit unit, [CanBeNull] IFormatProvider provider, int significantDigitsAfterRadix)
        {
            double value = As(unit);
            string format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(unit, provider, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implictly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(RotationalJerkUnit unit, [CanBeNull] IFormatProvider provider, [NotNull] string format, [NotNull] params object[] args)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

            provider = provider ?? UnitSystem.DefaultCulture;

            double value = As(unit);
            object[] formatArgs = UnitFormatter.GetFormatArgs(unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        #endregion
    }
}
