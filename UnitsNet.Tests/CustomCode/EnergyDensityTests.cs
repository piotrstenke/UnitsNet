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
using UnitsNet.Units;
using Xunit;

namespace UnitsNet.Tests.CustomCode
{
    public class EnergyDensityTests : EnergyDensityTestsBase
    {
        /// <inheritdoc />
        protected override bool SupportsSIUnitSystem => true;
        /// <inheritdoc />
        protected override double GigajoulesPerCubicMeterInOneJoulePerCubicMeter => 1e-9;
        /// <inheritdoc />
        protected override double GigawattHoursPerCubicMeterInOneJoulePerCubicMeter => 2.77777778e-13;
        /// <inheritdoc />
        protected override double JoulesPerCubicMeterInOneJoulePerCubicMeter => 1;
        /// <inheritdoc />
        protected override double KilojoulesPerCubicMeterInOneJoulePerCubicMeter => 1e-3;
        /// <inheritdoc />
        protected override double KilowattHoursPerCubicMeterInOneJoulePerCubicMeter => 2.77777778e-7;
        /// <inheritdoc />
        protected override double MegajoulesPerCubicMeterInOneJoulePerCubicMeter => 1e-6;
        /// <inheritdoc />
        protected override double MegawattHoursPerCubicMeterInOneJoulePerCubicMeter => 2.77777778e-10;
        /// <inheritdoc />
        protected override double PetajoulesPerCubicMeterInOneJoulePerCubicMeter => 1e-15;
        /// <inheritdoc />
        protected override double PetawattHoursPerCubicMeterInOneJoulePerCubicMeter => 2.77777778e-19;
        /// <inheritdoc />
        protected override double TerajoulesPerCubicMeterInOneJoulePerCubicMeter => 1e-12;
        /// <inheritdoc />
        protected override double TerawattHoursPerCubicMeterInOneJoulePerCubicMeter => 2.77777778e-16;
        /// <inheritdoc />
        protected override double WattHoursPerCubicMeterInOneJoulePerCubicMeter => 0.000277777778;

        [Fact]
        public void CombustionEnergy()
        {
            Energy energy = EnergyDensity.CombustionEnergy(EnergyDensity.FromKilowattHoursPerCubicMeter(9.88),
                                                           Volume.FromCubicMeters(1),
                                                           Ratio.FromDecimalFractions(0.9543));
            Assert.Equal(9.428484, energy.KilowattHours, 5);
        }
    }
}