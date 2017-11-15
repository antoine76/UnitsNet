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
//     Add CustomCode\Quantities\MyUnit.extra.cs files to add code to generated quantities.
//     Add Extensions\MyUnitExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or quantities.
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

// Windows Runtime Component does not support CultureInfo type, so use culture name string instead for public methods: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
using Culture = System.String;
#else
using Culture = System.IFormatProvider;
#endif

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     Molar entropy is amount of energy required to increase temperature of 1 mole substance by 1 Kelvin.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class MolarEntropy
#else
    public partial struct MolarEntropy : IComparable, IComparable<MolarEntropy>
#endif
    {
        /// <summary>
        ///     Base unit of MolarEntropy.
        /// </summary>
        private readonly double _joulesPerMoleKelvin;

        // Windows Runtime Component requires a default constructor
#if WINDOWS_UWP
        public MolarEntropy() : this(0)
        {
        }
#endif

        public MolarEntropy(double joulespermolekelvin)
        {
            _joulesPerMoleKelvin = Convert.ToDouble(joulespermolekelvin);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        private
#else
        public
#endif
        MolarEntropy(long joulespermolekelvin)
        {
            _joulesPerMoleKelvin = Convert.ToDouble(joulespermolekelvin);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        // Windows Runtime Component does not support decimal type
#if WINDOWS_UWP
        private
#else
        public
#endif
        MolarEntropy(decimal joulespermolekelvin)
        {
            _joulesPerMoleKelvin = Convert.ToDouble(joulespermolekelvin);
        }

        #region Properties

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType => QuantityType.MolarEntropy;

        /// <summary>
        ///     The base unit representation of this quantity for the numeric value stored internally. All conversions go via this value.
        /// </summary>
        public static MolarEntropyUnit BaseUnit
        {
            get { return MolarEntropyUnit.JoulePerMoleKelvin; }
        }

        /// <summary>
        ///     All units of measurement for the MolarEntropy quantity.
        /// </summary>
        public static MolarEntropyUnit[] Units { get; } = Enum.GetValues(typeof(MolarEntropyUnit)).Cast<MolarEntropyUnit>().ToArray();

        /// <summary>
        ///     Get MolarEntropy in JoulesPerMoleKelvin.
        /// </summary>
        public double JoulesPerMoleKelvin
        {
            get { return _joulesPerMoleKelvin; }
        }

        /// <summary>
        ///     Get MolarEntropy in KilojoulesPerMoleKelvin.
        /// </summary>
        public double KilojoulesPerMoleKelvin
        {
            get { return (_joulesPerMoleKelvin) / 1e3d; }
        }

        /// <summary>
        ///     Get MolarEntropy in MegajoulesPerMoleKelvin.
        /// </summary>
        public double MegajoulesPerMoleKelvin
        {
            get { return (_joulesPerMoleKelvin) / 1e6d; }
        }

        #endregion

        #region Static

        public static MolarEntropy Zero
        {
            get { return new MolarEntropy(); }
        }

        /// <summary>
        ///     Get MolarEntropy from JoulesPerMoleKelvin.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MolarEntropy FromJoulesPerMoleKelvin(double joulespermolekelvin)
        {
            double value = (double) joulespermolekelvin;
            return new MolarEntropy(value);
        }
#else
        public static MolarEntropy FromJoulesPerMoleKelvin(QuantityValue joulespermolekelvin)
        {
            double value = (double) joulespermolekelvin;
            return new MolarEntropy((value));
        }
#endif

        /// <summary>
        ///     Get MolarEntropy from KilojoulesPerMoleKelvin.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MolarEntropy FromKilojoulesPerMoleKelvin(double kilojoulespermolekelvin)
        {
            double value = (double) kilojoulespermolekelvin;
            return new MolarEntropy((value) * 1e3d);
        }
#else
        public static MolarEntropy FromKilojoulesPerMoleKelvin(QuantityValue kilojoulespermolekelvin)
        {
            double value = (double) kilojoulespermolekelvin;
            return new MolarEntropy(((value) * 1e3d));
        }
#endif

        /// <summary>
        ///     Get MolarEntropy from MegajoulesPerMoleKelvin.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MolarEntropy FromMegajoulesPerMoleKelvin(double megajoulespermolekelvin)
        {
            double value = (double) megajoulespermolekelvin;
            return new MolarEntropy((value) * 1e6d);
        }
#else
        public static MolarEntropy FromMegajoulesPerMoleKelvin(QuantityValue megajoulespermolekelvin)
        {
            double value = (double) megajoulespermolekelvin;
            return new MolarEntropy(((value) * 1e6d));
        }
#endif

        // Windows Runtime Component does not support nullable types (double?): https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        /// <summary>
        ///     Get nullable MolarEntropy from nullable JoulesPerMoleKelvin.
        /// </summary>
        public static MolarEntropy? FromJoulesPerMoleKelvin(QuantityValue? joulespermolekelvin)
        {
            if (joulespermolekelvin.HasValue)
            {
                return FromJoulesPerMoleKelvin(joulespermolekelvin.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable MolarEntropy from nullable KilojoulesPerMoleKelvin.
        /// </summary>
        public static MolarEntropy? FromKilojoulesPerMoleKelvin(QuantityValue? kilojoulespermolekelvin)
        {
            if (kilojoulespermolekelvin.HasValue)
            {
                return FromKilojoulesPerMoleKelvin(kilojoulespermolekelvin.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable MolarEntropy from nullable MegajoulesPerMoleKelvin.
        /// </summary>
        public static MolarEntropy? FromMegajoulesPerMoleKelvin(QuantityValue? megajoulespermolekelvin)
        {
            if (megajoulespermolekelvin.HasValue)
            {
                return FromMegajoulesPerMoleKelvin(megajoulespermolekelvin.Value);
            }
            else
            {
                return null;
            }
        }

#endif

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MolarEntropyUnit" /> to <see cref="MolarEntropy" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>MolarEntropy unit value.</returns>
#if WINDOWS_UWP
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static MolarEntropy From(double value, MolarEntropyUnit fromUnit)
#else
        public static MolarEntropy From(QuantityValue value, MolarEntropyUnit fromUnit)
#endif
        {
            switch (fromUnit)
            {
                case MolarEntropyUnit.JoulePerMoleKelvin:
                    return FromJoulesPerMoleKelvin(value);
                case MolarEntropyUnit.KilojoulePerMoleKelvin:
                    return FromKilojoulesPerMoleKelvin(value);
                case MolarEntropyUnit.MegajoulePerMoleKelvin:
                    return FromMegajoulesPerMoleKelvin(value);

                default:
                    throw new NotImplementedException("fromUnit: " + fromUnit);
            }
        }

        // Windows Runtime Component does not support nullable types (double?): https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MolarEntropyUnit" /> to <see cref="MolarEntropy" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>MolarEntropy unit value.</returns>
        public static MolarEntropy? From(QuantityValue? value, MolarEntropyUnit fromUnit)
        {
            if (!value.HasValue)
            {
                return null;
            }
            switch (fromUnit)
            {
                case MolarEntropyUnit.JoulePerMoleKelvin:
                    return FromJoulesPerMoleKelvin(value.Value);
                case MolarEntropyUnit.KilojoulePerMoleKelvin:
                    return FromKilojoulesPerMoleKelvin(value.Value);
                case MolarEntropyUnit.MegajoulePerMoleKelvin:
                    return FromMegajoulesPerMoleKelvin(value.Value);

                default:
                    throw new NotImplementedException("fromUnit: " + fromUnit);
            }
        }
#endif

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(MolarEntropyUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <param name="culture">Culture to use for localization. Defaults to Thread.CurrentUICulture.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(MolarEntropyUnit unit, [CanBeNull] Culture culture)
        {
            return UnitSystem.GetCached(culture).GetDefaultAbbreviation(unit);
        }

        #endregion

        #region Arithmetic Operators

        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static MolarEntropy operator -(MolarEntropy right)
        {
            return new MolarEntropy(-right._joulesPerMoleKelvin);
        }

        public static MolarEntropy operator +(MolarEntropy left, MolarEntropy right)
        {
            return new MolarEntropy(left._joulesPerMoleKelvin + right._joulesPerMoleKelvin);
        }

        public static MolarEntropy operator -(MolarEntropy left, MolarEntropy right)
        {
            return new MolarEntropy(left._joulesPerMoleKelvin - right._joulesPerMoleKelvin);
        }

        public static MolarEntropy operator *(double left, MolarEntropy right)
        {
            return new MolarEntropy(left*right._joulesPerMoleKelvin);
        }

        public static MolarEntropy operator *(MolarEntropy left, double right)
        {
            return new MolarEntropy(left._joulesPerMoleKelvin*(double)right);
        }

        public static MolarEntropy operator /(MolarEntropy left, double right)
        {
            return new MolarEntropy(left._joulesPerMoleKelvin/(double)right);
        }

        public static double operator /(MolarEntropy left, MolarEntropy right)
        {
            return Convert.ToDouble(left._joulesPerMoleKelvin/right._joulesPerMoleKelvin);
        }
#endif

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");
            if (!(obj is MolarEntropy)) throw new ArgumentException("Expected type MolarEntropy.", "obj");
            return CompareTo((MolarEntropy) obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(MolarEntropy other)
        {
            return _joulesPerMoleKelvin.CompareTo(other._joulesPerMoleKelvin);
        }

        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static bool operator <=(MolarEntropy left, MolarEntropy right)
        {
            return left._joulesPerMoleKelvin <= right._joulesPerMoleKelvin;
        }

        public static bool operator >=(MolarEntropy left, MolarEntropy right)
        {
            return left._joulesPerMoleKelvin >= right._joulesPerMoleKelvin;
        }

        public static bool operator <(MolarEntropy left, MolarEntropy right)
        {
            return left._joulesPerMoleKelvin < right._joulesPerMoleKelvin;
        }

        public static bool operator >(MolarEntropy left, MolarEntropy right)
        {
            return left._joulesPerMoleKelvin > right._joulesPerMoleKelvin;
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(MolarEntropy left, MolarEntropy right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left._joulesPerMoleKelvin == right._joulesPerMoleKelvin;
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(MolarEntropy left, MolarEntropy right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left._joulesPerMoleKelvin != right._joulesPerMoleKelvin;
        }
#endif

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return _joulesPerMoleKelvin.Equals(((MolarEntropy) obj)._joulesPerMoleKelvin);
        }

        /// <summary>
        ///     Compare equality to another MolarEntropy by specifying a max allowed difference.
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        /// </summary>
        /// <param name="other">Other quantity to compare to.</param>
        /// <param name="maxError">Max error allowed.</param>
        /// <returns>True if the difference between the two values is not greater than the specified max.</returns>
        public bool Equals(MolarEntropy other, MolarEntropy maxError)
        {
            return Math.Abs(_joulesPerMoleKelvin - other._joulesPerMoleKelvin) <= maxError._joulesPerMoleKelvin;
        }

        public override int GetHashCode()
        {
            return _joulesPerMoleKelvin.GetHashCode();
        }

        #endregion

        #region Conversion

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value in new unit if successful, exception otherwise.</returns>
        /// <exception cref="NotImplementedException">If conversion was not successful.</exception>
        public double As(MolarEntropyUnit unit)
        {
            switch (unit)
            {
                case MolarEntropyUnit.JoulePerMoleKelvin:
                    return JoulesPerMoleKelvin;
                case MolarEntropyUnit.KilojoulePerMoleKelvin:
                    return KilojoulesPerMoleKelvin;
                case MolarEntropyUnit.MegajoulePerMoleKelvin:
                    return MegajoulesPerMoleKelvin;

                default:
                    throw new NotImplementedException("unit: " + unit);
            }
        }

        #endregion

        #region Parsing

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
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
        public static MolarEntropy Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="culture">Format to use when parsing number and unit. If it is null, it defaults to <see cref="NumberFormatInfo.CurrentInfo"/> for parsing the number and <see cref="CultureInfo.CurrentUICulture"/> for parsing the unit abbreviation by culture/language.</param>
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
        public static MolarEntropy Parse(string str, [CanBeNull] Culture culture)
        {
            if (str == null) throw new ArgumentNullException("str");

        // Windows Runtime Component does not support CultureInfo type, so use culture name string for public methods instead: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
            IFormatProvider formatProvider = culture == null ? null : new CultureInfo(culture);
#else
            IFormatProvider formatProvider = culture;
#endif
            return QuantityParser.Parse<MolarEntropy, MolarEntropyUnit>(str, formatProvider,
                delegate(string value, string unit, IFormatProvider formatProvider2)
                {
                    double parsedValue = double.Parse(value, formatProvider2);
                    MolarEntropyUnit parsedUnit = ParseUnit(unit, formatProvider2);
                    return From(parsedValue, parsedUnit);
                }, (x, y) => FromJoulesPerMoleKelvin(x.JoulesPerMoleKelvin + y.JoulesPerMoleKelvin));
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out MolarEntropy result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="culture">Format to use when parsing number and unit. If it is null, it defaults to <see cref="NumberFormatInfo.CurrentInfo"/> for parsing the number and <see cref="CultureInfo.CurrentUICulture"/> for parsing the unit abbreviation by culture/language.</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] Culture culture, out MolarEntropy result)
        {
            try
            {
                result = Parse(str, culture);
                return true;
            }
            catch
            {
                result = default(MolarEntropy);
                return false;
            }
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static MolarEntropyUnit ParseUnit(string str)
        {
            return ParseUnit(str, (IFormatProvider)null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static MolarEntropyUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            return ParseUnit(str, cultureName == null ? null : new CultureInfo(cultureName));
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        static MolarEntropyUnit ParseUnit(string str, IFormatProvider formatProvider = null)
        {
            if (str == null) throw new ArgumentNullException("str");

            var unitSystem = UnitSystem.GetCached(formatProvider);
            var unit = unitSystem.Parse<MolarEntropyUnit>(str.Trim());

            if (unit == MolarEntropyUnit.Undefined)
            {
                var newEx = new UnitsNetException("Error parsing string. The unit is not a recognized MolarEntropyUnit.");
                newEx.Data["input"] = str;
                newEx.Data["formatprovider"] = formatProvider?.ToString() ?? "(null)";
                throw newEx;
            }

            return unit;
        }

        #endregion

        /// <summary>
        ///     Set the default unit used by ToString(). Default is JoulePerMoleKelvin
        /// </summary>
        public static MolarEntropyUnit ToStringDefaultUnit { get; set; } = MolarEntropyUnit.JoulePerMoleKelvin;

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(ToStringDefaultUnit);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using current UI culture and two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <returns>String representation.</returns>
        public string ToString(MolarEntropyUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <returns>String representation.</returns>
        public string ToString(MolarEntropyUnit unit, [CanBeNull] Culture culture)
        {
            return ToString(unit, culture, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(MolarEntropyUnit unit, [CanBeNull] Culture culture, int significantDigitsAfterRadix)
        {
            double value = As(unit);
            string format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(unit, culture, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implictly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(MolarEntropyUnit unit, [CanBeNull] Culture culture, [NotNull] string format,
            [NotNull] params object[] args)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

        // Windows Runtime Component does not support CultureInfo type, so use culture name string for public methods instead: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
            IFormatProvider formatProvider = culture == null ? null : new CultureInfo(culture);
#else
            IFormatProvider formatProvider = culture;
#endif
            double value = As(unit);
            object[] formatArgs = UnitFormatter.GetFormatArgs(unit, value, formatProvider, args);
            return string.Format(formatProvider, format, formatArgs);
        }

        /// <summary>
        /// Represents the largest possible value of MolarEntropy
        /// </summary>
        public static MolarEntropy MaxValue
        {
            get
            {
                return new MolarEntropy(double.MaxValue);
            }
        }

        /// <summary>
        /// Represents the smallest possible value of MolarEntropy
        /// </summary>
        public static MolarEntropy MinValue
        {
            get
            {
                return new MolarEntropy(double.MinValue);
            }
        }
    }
}
