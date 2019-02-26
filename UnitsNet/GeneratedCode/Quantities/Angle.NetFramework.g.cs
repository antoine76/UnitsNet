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
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Globalization;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;
using UnitsNet.InternalHelpers;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     In geometry, an angle is the figure formed by two rays, called the sides of the angle, sharing a common endpoint, called the vertex of the angle.
    /// </summary>
    public partial struct Angle : IQuantity<AngleUnit>, IEquatable<Angle>, IComparable, IComparable<Angle>, IConvertible
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly AngleUnit? _unit;

        static Angle()
        {
            BaseDimensions = BaseDimensions.Dimensionless;
            Info = new QuantityInfo<AngleUnit>(QuantityType.Angle, Units, BaseUnit, Zero, BaseDimensions);
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="numericValue">The numeric value  to contruct this quantity with.</param>
        /// <param name="unit">The unit representation to contruct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public Angle(double numericValue, AngleUnit unit)
        {
            if(unit == AngleUnit.Undefined)
              throw new ArgumentException("The quantity can not be created with an undefined unit.", nameof(unit));

            _value = Guard.EnsureValidNumber(numericValue, nameof(numericValue));
            _unit = unit;
        }

        #region Static Properties

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        public static QuantityInfo<AngleUnit> Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions { get; }

        /// <summary>
        ///     The base unit of Angle, which is Degree. All conversions go via this value.
        /// </summary>
        public static AngleUnit BaseUnit { get; } = AngleUnit.Degree;

        /// <summary>
        /// Represents the largest possible value of Angle
        /// </summary>
        public static Angle MaxValue { get; } = new Angle(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Angle
        /// </summary>
        public static Angle MinValue { get; } = new Angle(double.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType { get; } = QuantityType.Angle;

        /// <summary>
        ///     All units of measurement for the Angle quantity.
        /// </summary>
        public static AngleUnit[] Units { get; } = Enum.GetValues(typeof(AngleUnit)).Cast<AngleUnit>().Except(new AngleUnit[]{ AngleUnit.Undefined }).ToArray();

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Degree.
        /// </summary>
        public static Angle Zero { get; } = new Angle(0, BaseUnit);

        #endregion

        #region Properties

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        Enum IQuantity.Unit => Unit;

        /// <inheritdoc />
        public AngleUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        /// <inheritdoc />
        public QuantityInfo<AngleUnit> QuantityInfo => Info;

        /// <inheritdoc cref="IQuantity.QuantityInfo"/>
        QuantityInfo IQuantity.QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => Angle.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => Angle.BaseDimensions;

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Get Angle in Arcminutes.
        /// </summary>
        public double Arcminutes => As(AngleUnit.Arcminute);

        /// <summary>
        ///     Get Angle in Arcseconds.
        /// </summary>
        public double Arcseconds => As(AngleUnit.Arcsecond);

        /// <summary>
        ///     Get Angle in Centiradians.
        /// </summary>
        public double Centiradians => As(AngleUnit.Centiradian);

        /// <summary>
        ///     Get Angle in Deciradians.
        /// </summary>
        public double Deciradians => As(AngleUnit.Deciradian);

        /// <summary>
        ///     Get Angle in Degrees.
        /// </summary>
        public double Degrees => As(AngleUnit.Degree);

        /// <summary>
        ///     Get Angle in Gradians.
        /// </summary>
        public double Gradians => As(AngleUnit.Gradian);

        /// <summary>
        ///     Get Angle in Microdegrees.
        /// </summary>
        public double Microdegrees => As(AngleUnit.Microdegree);

        /// <summary>
        ///     Get Angle in Microradians.
        /// </summary>
        public double Microradians => As(AngleUnit.Microradian);

        /// <summary>
        ///     Get Angle in Millidegrees.
        /// </summary>
        public double Millidegrees => As(AngleUnit.Millidegree);

        /// <summary>
        ///     Get Angle in Milliradians.
        /// </summary>
        public double Milliradians => As(AngleUnit.Milliradian);

        /// <summary>
        ///     Get Angle in Nanodegrees.
        /// </summary>
        public double Nanodegrees => As(AngleUnit.Nanodegree);

        /// <summary>
        ///     Get Angle in Nanoradians.
        /// </summary>
        public double Nanoradians => As(AngleUnit.Nanoradian);

        /// <summary>
        ///     Get Angle in Radians.
        /// </summary>
        public double Radians => As(AngleUnit.Radian);

        /// <summary>
        ///     Get Angle in Revolutions.
        /// </summary>
        public double Revolutions => As(AngleUnit.Revolution);

        #endregion

        #region Static Methods

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(AngleUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="provider">Format to use for localization. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static string GetAbbreviation(AngleUnit unit, [CanBeNull] IFormatProvider provider)
        {
            return UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get Angle from Arcminutes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromArcminutes(QuantityValue arcminutes)
        {
            double value = (double) arcminutes;
            return new Angle(value, AngleUnit.Arcminute);
        }
        /// <summary>
        ///     Get Angle from Arcseconds.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromArcseconds(QuantityValue arcseconds)
        {
            double value = (double) arcseconds;
            return new Angle(value, AngleUnit.Arcsecond);
        }
        /// <summary>
        ///     Get Angle from Centiradians.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromCentiradians(QuantityValue centiradians)
        {
            double value = (double) centiradians;
            return new Angle(value, AngleUnit.Centiradian);
        }
        /// <summary>
        ///     Get Angle from Deciradians.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromDeciradians(QuantityValue deciradians)
        {
            double value = (double) deciradians;
            return new Angle(value, AngleUnit.Deciradian);
        }
        /// <summary>
        ///     Get Angle from Degrees.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromDegrees(QuantityValue degrees)
        {
            double value = (double) degrees;
            return new Angle(value, AngleUnit.Degree);
        }
        /// <summary>
        ///     Get Angle from Gradians.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromGradians(QuantityValue gradians)
        {
            double value = (double) gradians;
            return new Angle(value, AngleUnit.Gradian);
        }
        /// <summary>
        ///     Get Angle from Microdegrees.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromMicrodegrees(QuantityValue microdegrees)
        {
            double value = (double) microdegrees;
            return new Angle(value, AngleUnit.Microdegree);
        }
        /// <summary>
        ///     Get Angle from Microradians.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromMicroradians(QuantityValue microradians)
        {
            double value = (double) microradians;
            return new Angle(value, AngleUnit.Microradian);
        }
        /// <summary>
        ///     Get Angle from Millidegrees.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromMillidegrees(QuantityValue millidegrees)
        {
            double value = (double) millidegrees;
            return new Angle(value, AngleUnit.Millidegree);
        }
        /// <summary>
        ///     Get Angle from Milliradians.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromMilliradians(QuantityValue milliradians)
        {
            double value = (double) milliradians;
            return new Angle(value, AngleUnit.Milliradian);
        }
        /// <summary>
        ///     Get Angle from Nanodegrees.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromNanodegrees(QuantityValue nanodegrees)
        {
            double value = (double) nanodegrees;
            return new Angle(value, AngleUnit.Nanodegree);
        }
        /// <summary>
        ///     Get Angle from Nanoradians.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromNanoradians(QuantityValue nanoradians)
        {
            double value = (double) nanoradians;
            return new Angle(value, AngleUnit.Nanoradian);
        }
        /// <summary>
        ///     Get Angle from Radians.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromRadians(QuantityValue radians)
        {
            double value = (double) radians;
            return new Angle(value, AngleUnit.Radian);
        }
        /// <summary>
        ///     Get Angle from Revolutions.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Angle FromRevolutions(QuantityValue revolutions)
        {
            double value = (double) revolutions;
            return new Angle(value, AngleUnit.Revolution);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="AngleUnit" /> to <see cref="Angle" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Angle unit value.</returns>
        public static Angle From(QuantityValue value, AngleUnit fromUnit)
        {
            return new Angle((double)value, fromUnit);
        }

        #endregion

        #region Static Parse Methods

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
        public static Angle Parse(string str)
        {
            return Parse(str, null);
        }

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
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static Angle Parse(string str, [CanBeNull] IFormatProvider provider)
        {
            return QuantityParser.Default.Parse<Angle, AngleUnit>(
                str,
                provider,
                From);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out Angle result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] IFormatProvider provider, out Angle result)
        {
            return QuantityParser.Default.TryParse<Angle, AngleUnit>(
                str,
                provider,
                From,
                out result);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static AngleUnit ParseUnit(string str)
        {
            return ParseUnit(str, null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static AngleUnit ParseUnit(string str, IFormatProvider provider = null)
        {
            return UnitParser.Default.Parse<AngleUnit>(str, provider);
        }

        /// <inheritdoc cref="TryParseUnit(string,IFormatProvider,out UnitsNet.Units.AngleUnit)"/>
        public static bool TryParseUnit(string str, out AngleUnit unit)
        {
            return TryParseUnit(str, null, out unit);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="unit">The parsed unit if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.TryParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParseUnit(string str, IFormatProvider provider, out AngleUnit unit)
        {
            return UnitParser.Default.TryParse<AngleUnit>(str, provider, out unit);
        }

        #endregion

        #region Arithmetic Operators

        /// <summary>Negate the value.</summary>
        public static Angle operator -(Angle right)
        {
            return new Angle(-right.Value, right.Unit);
        }

        /// <summary>Get <see cref="Angle"/> from adding two <see cref="Angle"/>.</summary>
        public static Angle operator +(Angle left, Angle right)
        {
            return new Angle(left.Value + right.AsBaseNumericType(left.Unit), left.Unit);
        }

        /// <summary>Get <see cref="Angle"/> from subtracting two <see cref="Angle"/>.</summary>
        public static Angle operator -(Angle left, Angle right)
        {
            return new Angle(left.Value - right.AsBaseNumericType(left.Unit), left.Unit);
        }

        /// <summary>Get <see cref="Angle"/> from multiplying value and <see cref="Angle"/>.</summary>
        public static Angle operator *(double left, Angle right)
        {
            return new Angle(left * right.Value, right.Unit);
        }

        /// <summary>Get <see cref="Angle"/> from multiplying value and <see cref="Angle"/>.</summary>
        public static Angle operator *(Angle left, double right)
        {
            return new Angle(left.Value * right, left.Unit);
        }

        /// <summary>Get <see cref="Angle"/> from dividing <see cref="Angle"/> by value.</summary>
        public static Angle operator /(Angle left, double right)
        {
            return new Angle(left.Value / right, left.Unit);
        }

        /// <summary>Get ratio value from dividing <see cref="Angle"/> by <see cref="Angle"/>.</summary>
        public static double operator /(Angle left, Angle right)
        {
            return left.Degrees / right.Degrees;
        }

        #endregion

        #region Equality / IComparable

        /// <summary>Returns true if less or equal to.</summary>
        public static bool operator <=(Angle left, Angle right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        /// <summary>Returns true if greater than or equal to.</summary>
        public static bool operator >=(Angle left, Angle right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        /// <summary>Returns true if less than.</summary>
        public static bool operator <(Angle left, Angle right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        /// <summary>Returns true if greater than.</summary>
        public static bool operator >(Angle left, Angle right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        /// <summary>Returns true if exactly equal.</summary>
        /// <remarks>Consider using <see cref="Equals(Angle, double, ComparisonType)"/> for safely comparing floating point values.</remarks>
        public static bool operator ==(Angle left, Angle right)
        {
            return left.Equals(right);
        }

        /// <summary>Returns true if not exactly equal.</summary>
        /// <remarks>Consider using <see cref="Equals(Angle, double, ComparisonType)"/> for safely comparing floating point values.</remarks>
        public static bool operator !=(Angle left, Angle right)
        {
            return !(left == right);
        }

        /// <inheritdoc />
        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is Angle objAngle)) throw new ArgumentException("Expected type Angle.", nameof(obj));

            return CompareTo(objAngle);
        }

        /// <inheritdoc />
        public int CompareTo(Angle other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        /// <inheritdoc />
        /// <remarks>Consider using <see cref="Equals(Angle, double, ComparisonType)"/> for safely comparing floating point values.</remarks>
        public override bool Equals(object obj)
        {
            if(obj is null || !(obj is Angle objAngle))
                return false;

            return Equals(objAngle);
        }

        /// <inheritdoc />
        /// <remarks>Consider using <see cref="Equals(Angle, double, ComparisonType)"/> for safely comparing floating point values.</remarks>
        public bool Equals(Angle other)
        {
            return _value.Equals(other.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another Angle within the given absolute or relative tolerance.
        ///     </para>
        ///     <para>
        ///     Relative tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a percentage of this quantity's value. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison. A relative tolerance of 0.01 means the absolute difference must be within +/- 1% of
        ///     this quantity's value to be considered equal.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within +/- 1% of a (0.02m or 2cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Relative);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Absolute tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a fixed number in this quantity's unit. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within 0.01 of a (0.01m or 1cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Absolute);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        ///     </para>
        /// </summary>
        /// <param name="other">The other quantity to compare to.</param>
        /// <param name="tolerance">The absolute or relative tolerance value. Must be greater than or equal to 0.</param>
        /// <param name="comparisonType">The comparison type: either relative or absolute.</param>
        /// <returns>True if the absolute difference between the two values is not greater than the specified relative or absolute tolerance.</returns>
        public bool Equals(Angle other, double tolerance, ComparisonType comparisonType)
        {
            if(tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current Angle.</returns>
        public override int GetHashCode()
        {
            return new { QuantityType, Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion Methods

        double IQuantity.As(Enum unit) => As((AngleUnit)unit);

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(AngleUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <inheritdoc />
        public double As(Enum unit) => As((AngleUnit) unit);

        /// <summary>
        ///     Converts this Angle to another Angle with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Angle with the specified unit.</returns>
        public Angle ToUnit(AngleUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new Angle(convertedValue, unit);
        }

        IQuantity<AngleUnit> IQuantity<AngleUnit>.ToUnit(AngleUnit unit) => ToUnit(unit);

        /// <inheritdoc />
        public IQuantity ToUnit(Enum unit) => ToUnit((AngleUnit) unit);

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double AsBaseUnit()
        {
            switch(Unit)
            {
                case AngleUnit.Arcminute: return _value/60;
                case AngleUnit.Arcsecond: return _value/3600;
                case AngleUnit.Centiradian: return (_value*180/Math.PI) * 1e-2d;
                case AngleUnit.Deciradian: return (_value*180/Math.PI) * 1e-1d;
                case AngleUnit.Degree: return _value;
                case AngleUnit.Gradian: return _value*0.9;
                case AngleUnit.Microdegree: return (_value) * 1e-6d;
                case AngleUnit.Microradian: return (_value*180/Math.PI) * 1e-6d;
                case AngleUnit.Millidegree: return (_value) * 1e-3d;
                case AngleUnit.Milliradian: return (_value*180/Math.PI) * 1e-3d;
                case AngleUnit.Nanodegree: return (_value) * 1e-9d;
                case AngleUnit.Nanoradian: return (_value*180/Math.PI) * 1e-9d;
                case AngleUnit.Radian: return _value*180/Math.PI;
                case AngleUnit.Revolution: return _value*360;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(AngleUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case AngleUnit.Arcminute: return baseUnitValue*60;
                case AngleUnit.Arcsecond: return baseUnitValue*3600;
                case AngleUnit.Centiradian: return (baseUnitValue/180*Math.PI) / 1e-2d;
                case AngleUnit.Deciradian: return (baseUnitValue/180*Math.PI) / 1e-1d;
                case AngleUnit.Degree: return baseUnitValue;
                case AngleUnit.Gradian: return baseUnitValue/0.9;
                case AngleUnit.Microdegree: return (baseUnitValue) / 1e-6d;
                case AngleUnit.Microradian: return (baseUnitValue/180*Math.PI) / 1e-6d;
                case AngleUnit.Millidegree: return (baseUnitValue) / 1e-3d;
                case AngleUnit.Milliradian: return (baseUnitValue/180*Math.PI) / 1e-3d;
                case AngleUnit.Nanodegree: return (baseUnitValue) / 1e-9d;
                case AngleUnit.Nanoradian: return (baseUnitValue/180*Math.PI) / 1e-9d;
                case AngleUnit.Radian: return baseUnitValue/180*Math.PI;
                case AngleUnit.Revolution: return baseUnitValue/360;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

        #region ToString Methods

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(null);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <returns>String representation.</returns>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] IFormatProvider provider)
        {
            return ToString(provider, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] IFormatProvider provider, int significantDigitsAfterRadix)
        {
            var value = Convert.ToDouble(Value);
            var format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(provider, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implictly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] IFormatProvider provider, [NotNull] string format, [NotNull] params object[] args)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

            provider = provider ?? GlobalConfiguration.DefaultCulture;

            var value = Convert.ToDouble(Value);
            var formatArgs = UnitFormatter.GetFormatArgs(Unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        #endregion

        #region IConvertible Methods

        TypeCode IConvertible.GetTypeCode()
        {
            return TypeCode.Object;
        }

        bool IConvertible.ToBoolean(IFormatProvider provider)
        {
            throw new InvalidCastException($"Converting {typeof(Angle)} to bool is not supported.");
        }

        byte IConvertible.ToByte(IFormatProvider provider)
        {
            return Convert.ToByte(_value);
        }

        char IConvertible.ToChar(IFormatProvider provider)
        {
            throw new InvalidCastException($"Converting {typeof(Angle)} to char is not supported.");
        }

        DateTime IConvertible.ToDateTime(IFormatProvider provider)
        {
            throw new InvalidCastException($"Converting {typeof(Angle)} to DateTime is not supported.");
        }

        decimal IConvertible.ToDecimal(IFormatProvider provider)
        {
            return Convert.ToDecimal(_value);
        }

        double IConvertible.ToDouble(IFormatProvider provider)
        {
            return Convert.ToDouble(_value);
        }

        short IConvertible.ToInt16(IFormatProvider provider)
        {
            return Convert.ToInt16(_value);
        }

        int IConvertible.ToInt32(IFormatProvider provider)
        {
            return Convert.ToInt32(_value);
        }

        long IConvertible.ToInt64(IFormatProvider provider)
        {
            return Convert.ToInt64(_value);
        }

        sbyte IConvertible.ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte(_value);
        }

        float IConvertible.ToSingle(IFormatProvider provider)
        {
            return Convert.ToSingle(_value);
        }

        string IConvertible.ToString(IFormatProvider provider)
        {
            return ToString(provider);
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            if(conversionType == typeof(Angle))
                return this;
            else if(conversionType == typeof(AngleUnit))
                return Unit;
            else if(conversionType == typeof(QuantityType))
                return Angle.QuantityType;
            else if(conversionType == typeof(BaseDimensions))
                return Angle.BaseDimensions;
            else
                throw new InvalidCastException($"Converting {typeof(Angle)} to {conversionType} is not supported.");
        }

        ushort IConvertible.ToUInt16(IFormatProvider provider)
        {
            return Convert.ToUInt16(_value);
        }

        uint IConvertible.ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32(_value);
        }

        ulong IConvertible.ToUInt64(IFormatProvider provider)
        {
            return Convert.ToUInt64(_value);
        }

        #endregion
    }
}
