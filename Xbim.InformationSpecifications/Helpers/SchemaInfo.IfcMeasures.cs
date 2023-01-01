// SchemaInfo.IfcMeasures.cs is automatically generated by xbim.xids.generator.Execute_GenerateIfcMeasureDictionary() using Xbim.Essentials 5.9.0.375
using System.Collections.Generic;

namespace Xbim.InformationSpecifications.Helpers
{
	public partial class SchemaInfo
	{
		/// <summary>
		/// Repository of valid <see cref="IfcMeasureInfo"/> metadata given the persistence string defined in bS IDS
		/// </summary>
		public static Dictionary<string, IfcMeasureInfo> IfcMeasures { get; } = new()
		{
			{ "IfcAmountOfSubstanceMeasure", new IfcMeasureInfo("IfcAmountOfSubstanceMeasure", "Amount of substance", "mole", "mol", "(0, 0, 0, 0, 0, 1, 0)", new[] { "Ifc2x3.MeasureResource.IfcAmountOfSubstanceMeasure", "Ifc4.MeasureResource.IfcAmountOfSubstanceMeasure", "Ifc4x3.MeasureResource.IfcAmountOfSubstanceMeasure" }, "IfcUnitEnum.AMOUNTOFSUBSTANCEUNIT") },
			{ "IfcAreaDensityMeasure", new IfcMeasureInfo("IfcAreaDensityMeasure", "Area density", "", "Kg/m2", "(-2, 1, 0, 0, 0, 0, 0)", new[] { "Ifc4.MeasureResource.IfcAreaDensityMeasure", "Ifc4x3.MeasureResource.IfcAreaDensityMeasure" }, "IfcDerivedUnitEnum.AREADENSITYUNIT") },
			{ "IfcAreaMeasure", new IfcMeasureInfo("IfcAreaMeasure", "Area", "square meter", "m2", "(2, 0, 0, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcAreaMeasure", "Ifc4.MeasureResource.IfcAreaMeasure", "Ifc4x3.MeasureResource.IfcAreaMeasure" }, "IfcUnitEnum.AREAUNIT") },
			{ "IfcDynamicViscosityMeasure", new IfcMeasureInfo("IfcDynamicViscosityMeasure", "Dynamic viscosity", "", "Pa s", "(-1, 1, -1, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcDynamicViscosityMeasure", "Ifc4.MeasureResource.IfcDynamicViscosityMeasure", "Ifc4x3.MeasureResource.IfcDynamicViscosityMeasure" }, "IfcDerivedUnitEnum.DYNAMICVISCOSITYUNIT") },
			{ "IfcElectricCapacitanceMeasure", new IfcMeasureInfo("IfcElectricCapacitanceMeasure", "Electric capacitance", "farad", "F", "(-2, 1, 4, 1, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcElectricCapacitanceMeasure", "Ifc4.MeasureResource.IfcElectricCapacitanceMeasure", "Ifc4x3.MeasureResource.IfcElectricCapacitanceMeasure" }, "IfcUnitEnum.ELECTRICCAPACITANCEUNIT") },
			{ "IfcElectricChargeMeasure", new IfcMeasureInfo("IfcElectricChargeMeasure", "Electric charge", "coulomb", "C", "(0, 0, 1, 1, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcElectricChargeMeasure", "Ifc4.MeasureResource.IfcElectricChargeMeasure", "Ifc4x3.MeasureResource.IfcElectricChargeMeasure" }, "IfcUnitEnum.ELECTRICCHARGEUNIT") },
			{ "IfcElectricConductanceMeasure", new IfcMeasureInfo("IfcElectricConductanceMeasure", "Electric conductance", "siemens", "S", "(-2, -1, 3, 2, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcElectricConductanceMeasure", "Ifc4.MeasureResource.IfcElectricConductanceMeasure", "Ifc4x3.MeasureResource.IfcElectricConductanceMeasure" }, "IfcUnitEnum.ELECTRICCONDUCTANCEUNIT") },
			{ "IfcElectricCurrentMeasure", new IfcMeasureInfo("IfcElectricCurrentMeasure", "Electric current", "ampere", "A", "(0, 0, 0, 1, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcElectricCurrentMeasure", "Ifc4.MeasureResource.IfcElectricCurrentMeasure", "Ifc4x3.MeasureResource.IfcElectricCurrentMeasure" }, "IfcUnitEnum.ELECTRICCURRENTUNIT") },
			{ "IfcElectricResistanceMeasure", new IfcMeasureInfo("IfcElectricResistanceMeasure", "Electric resistance", "ohm", "Ω", "(2, 1, -3, -2, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcElectricResistanceMeasure", "Ifc4.MeasureResource.IfcElectricResistanceMeasure", "Ifc4x3.MeasureResource.IfcElectricResistanceMeasure" }, "IfcUnitEnum.ELECTRICRESISTANCEUNIT") },
			{ "IfcElectricVoltageMeasure", new IfcMeasureInfo("IfcElectricVoltageMeasure", "Electric voltage", "volt", "V", "(2, 1, -3, -1, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcElectricVoltageMeasure", "Ifc4.MeasureResource.IfcElectricVoltageMeasure", "Ifc4x3.MeasureResource.IfcElectricVoltageMeasure" }, "IfcUnitEnum.ELECTRICVOLTAGEUNIT") },
			{ "IfcEnergyMeasure", new IfcMeasureInfo("IfcEnergyMeasure", "Energy", "joule", "J", "(2, 1, -2, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcEnergyMeasure", "Ifc4.MeasureResource.IfcEnergyMeasure", "Ifc4x3.MeasureResource.IfcEnergyMeasure" }, "IfcUnitEnum.ENERGYUNIT") },
			{ "IfcForceMeasure", new IfcMeasureInfo("IfcForceMeasure", "Force", "newton", "N", "(1, 1, -2, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcForceMeasure", "Ifc4.MeasureResource.IfcForceMeasure", "Ifc4x3.MeasureResource.IfcForceMeasure" }, "IfcUnitEnum.FORCEUNIT") },
			{ "IfcFrequencyMeasure", new IfcMeasureInfo("IfcFrequencyMeasure", "Frequency", "hertz", "Hz", "(0, 0, -1, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcFrequencyMeasure", "Ifc4.MeasureResource.IfcFrequencyMeasure", "Ifc4x3.MeasureResource.IfcFrequencyMeasure" }, "IfcUnitEnum.FREQUENCYUNIT") },
			{ "IfcHeatFluxDensityMeasure", new IfcMeasureInfo("IfcHeatFluxDensityMeasure", "Heat flux density", "", "W/m2", "(0, 1, -3, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcHeatFluxDensityMeasure", "Ifc4.MeasureResource.IfcHeatFluxDensityMeasure", "Ifc4x3.MeasureResource.IfcHeatFluxDensityMeasure" }, "IfcDerivedUnitEnum.HEATFLUXDENSITYUNIT") },
			{ "IfcHeatingValueMeasure", new IfcMeasureInfo("IfcHeatingValueMeasure", "Heating", "", "J/K", "(2, 1, -2, 0, -1, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcHeatingValueMeasure", "Ifc4.MeasureResource.IfcHeatingValueMeasure", "Ifc4x3.MeasureResource.IfcHeatingValueMeasure" }, "IfcDerivedUnitEnum.HEATINGVALUEUNIT") },
			{ "IfcIlluminanceMeasure", new IfcMeasureInfo("IfcIlluminanceMeasure", "Illuminance", "lux", "lx", "(-2, 0, 0, 0, 0, 0, 1)", new[] { "Ifc2x3.MeasureResource.IfcIlluminanceMeasure", "Ifc4.MeasureResource.IfcIlluminanceMeasure", "Ifc4x3.MeasureResource.IfcIlluminanceMeasure" }, "IfcUnitEnum.ILLUMINANCEUNIT") },
			{ "IfcIonConcentrationMeasure", new IfcMeasureInfo("IfcIonConcentrationMeasure", "Ion concentration measure", "", "mol/m3", "(-3, 1, 0, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcIonConcentrationMeasure", "Ifc4.MeasureResource.IfcIonConcentrationMeasure", "Ifc4x3.MeasureResource.IfcIonConcentrationMeasure" }, "IfcDerivedUnitEnum.IONCONCENTRATIONUNIT") },
			{ "IfcIsothermalMoistureCapacityMeasure", new IfcMeasureInfo("IfcIsothermalMoistureCapacityMeasure", "Iso thermal moisture capacity", "", "m3/Kg", "(3, -1, 0, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcIsothermalMoistureCapacityMeasure", "Ifc4.MeasureResource.IfcIsothermalMoistureCapacityMeasure", "Ifc4x3.MeasureResource.IfcIsothermalMoistureCapacityMeasure" }, "IfcDerivedUnitEnum.ISOTHERMALMOISTURECAPACITYUNIT") },
			{ "IfcLengthMeasure", new IfcMeasureInfo("IfcLengthMeasure", "Length", "meter", "m", "(1, 0, 0, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcLengthMeasure", "Ifc4.MeasureResource.IfcLengthMeasure", "Ifc4x3.MeasureResource.IfcLengthMeasure" }, "IfcUnitEnum.LENGTHUNIT") },
			{ "IfcLinearVelocityMeasure", new IfcMeasureInfo("IfcLinearVelocityMeasure", "Speed", "", "m/s", "(1, 0, -1, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcLinearVelocityMeasure", "Ifc4.MeasureResource.IfcLinearVelocityMeasure", "Ifc4x3.MeasureResource.IfcLinearVelocityMeasure" }, "IfcDerivedUnitEnum.LINEARVELOCITYUNIT") },
			{ "IfcLuminousFluxMeasure", new IfcMeasureInfo("IfcLuminousFluxMeasure", "Luminous flux", "Lumen", "lm", "(0, 0, 0, 0, 0, 0, 1)", new[] { "Ifc2x3.MeasureResource.IfcLuminousFluxMeasure", "Ifc4.MeasureResource.IfcLuminousFluxMeasure", "Ifc4x3.MeasureResource.IfcLuminousFluxMeasure" }, "IfcUnitEnum.LUMINOUSFLUXUNIT") },
			{ "IfcLuminousIntensityMeasure", new IfcMeasureInfo("IfcLuminousIntensityMeasure", "Luminous intensity", "candela", "cd", "(0, 0, 0, 0, 0, 0, 1)", new[] { "Ifc2x3.MeasureResource.IfcLuminousIntensityMeasure", "Ifc4.MeasureResource.IfcLuminousIntensityMeasure", "Ifc4x3.MeasureResource.IfcLuminousIntensityMeasure" }, "IfcUnitEnum.LUMINOUSINTENSITYUNIT") },
			{ "IfcMassDensityMeasure", new IfcMeasureInfo("IfcMassDensityMeasure", "Mass density", "", "Kg/m3", "(-3, 1, 0, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcMassDensityMeasure", "Ifc4.MeasureResource.IfcMassDensityMeasure", "Ifc4x3.MeasureResource.IfcMassDensityMeasure" }, "IfcDerivedUnitEnum.MASSDENSITYUNIT") },
			{ "IfcMassFlowRateMeasure", new IfcMeasureInfo("IfcMassFlowRateMeasure", "Mass flow rate", "", "Kg/s", "(0, 1, -1, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcMassFlowRateMeasure", "Ifc4.MeasureResource.IfcMassFlowRateMeasure", "Ifc4x3.MeasureResource.IfcMassFlowRateMeasure" }, "IfcDerivedUnitEnum.MASSFLOWRATEUNIT") },
			{ "IfcMassMeasure", new IfcMeasureInfo("IfcMassMeasure", "Mass", "kilogram", "Kg", "(0, 1, 0, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcMassMeasure", "Ifc4.MeasureResource.IfcMassMeasure", "Ifc4x3.MeasureResource.IfcMassMeasure" }, "IfcUnitEnum.MASSUNIT") },
			{ "IfcMassPerLengthMeasure", new IfcMeasureInfo("IfcMassPerLengthMeasure", "Mass per length", "", "Kg/m", "(-1, 1, 0, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcMassPerLengthMeasure", "Ifc4.MeasureResource.IfcMassPerLengthMeasure", "Ifc4x3.MeasureResource.IfcMassPerLengthMeasure" }, "IfcDerivedUnitEnum.MASSPERLENGTHUNIT") },
			{ "IfcModulusOfElasticityMeasure", new IfcMeasureInfo("IfcModulusOfElasticityMeasure", "Modulus of elasticity", "", "N/m2", "(-1, 1, -2, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcModulusOfElasticityMeasure", "Ifc4.MeasureResource.IfcModulusOfElasticityMeasure", "Ifc4x3.MeasureResource.IfcModulusOfElasticityMeasure" }, "IfcDerivedUnitEnum.MODULUSOFELASTICITYUNIT") },
			{ "IfcMoistureDiffusivityMeasure", new IfcMeasureInfo("IfcMoistureDiffusivityMeasure", "Moisture diffusivity", "", "m3/s", "(3, 0, -1, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcMoistureDiffusivityMeasure", "Ifc4.MeasureResource.IfcMoistureDiffusivityMeasure", "Ifc4x3.MeasureResource.IfcMoistureDiffusivityMeasure" }, "IfcDerivedUnitEnum.MOISTUREDIFFUSIVITYUNIT") },
			{ "IfcMolecularWeightMeasure", new IfcMeasureInfo("IfcMolecularWeightMeasure", "Molecular weight", "", "Kg/mol", "(0, 1, 0, 0, 0, -1, 0)", new[] { "Ifc2x3.MeasureResource.IfcMolecularWeightMeasure", "Ifc4.MeasureResource.IfcMolecularWeightMeasure", "Ifc4x3.MeasureResource.IfcMolecularWeightMeasure" }, "IfcDerivedUnitEnum.MOLECULARWEIGHTUNIT") },
			{ "IfcMomentOfInertiaMeasure", new IfcMeasureInfo("IfcMomentOfInertiaMeasure", "Moment of inertia", "", "m4", "(4, 0, 0, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcMomentOfInertiaMeasure", "Ifc4.MeasureResource.IfcMomentOfInertiaMeasure", "Ifc4x3.MeasureResource.IfcMomentOfInertiaMeasure" }, "IfcDerivedUnitEnum.MOMENTOFINERTIAUNIT") },
			{ "IfcPHMeasure", new IfcMeasureInfo("IfcPHMeasure", "PH", "", "PH", "(0, 0, 0, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcPHMeasure", "Ifc4.MeasureResource.IfcPHMeasure", "Ifc4x3.MeasureResource.IfcPHMeasure" }, "IfcDerivedUnitEnum.PHUNIT") },
			{ "IfcPlanarForceMeasure", new IfcMeasureInfo("IfcPlanarForceMeasure", "Planar force", "", "Pa", "(-1, 1, -2, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcPlanarForceMeasure", "Ifc4.MeasureResource.IfcPlanarForceMeasure", "Ifc4x3.MeasureResource.IfcPlanarForceMeasure" }, "IfcDerivedUnitEnum.PLANARFORCEUNIT") },
			{ "IfcPlaneAngleMeasure", new IfcMeasureInfo("IfcPlaneAngleMeasure", "Angle", "radian", "rad", "(0, 0, 0, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcPlaneAngleMeasure", "Ifc4.MeasureResource.IfcPlaneAngleMeasure", "Ifc4x3.MeasureResource.IfcPlaneAngleMeasure" }, "IfcUnitEnum.PLANEANGLEUNIT") },
			{ "IfcPowerMeasure", new IfcMeasureInfo("IfcPowerMeasure", "Power", "watt", "W", "(2, 1, -3, 0, 0, 0, 0", new[] { "Ifc2x3.MeasureResource.IfcPowerMeasure", "Ifc4.MeasureResource.IfcPowerMeasure", "Ifc4x3.MeasureResource.IfcPowerMeasure" }, "IfcUnitEnum.POWERUNIT") },
			{ "IfcPressureMeasure", new IfcMeasureInfo("IfcPressureMeasure", "Pressure", "pascal", "Pa", "(-1, 1, -2, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcPressureMeasure", "Ifc4.MeasureResource.IfcPressureMeasure", "Ifc4x3.MeasureResource.IfcPressureMeasure" }, "IfcUnitEnum.PRESSUREUNIT") },
			{ "IfcRadioActivityMeasure", new IfcMeasureInfo("IfcRadioActivityMeasure", "Radio activity", "Becqurel", "Bq", "(0, 0, -1, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcRadioActivityMeasure", "Ifc4.MeasureResource.IfcRadioActivityMeasure", "Ifc4x3.MeasureResource.IfcRadioActivityMeasure" }, "IfcUnitEnum.RADIOACTIVITYUNIT") },
			{ "IfcRatioMeasure", new IfcMeasureInfo("IfcRatioMeasure", "Ratio", "Percent", "%", "(0, 0, 0, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcRatioMeasure", "Ifc4.MeasureResource.IfcRatioMeasure", "Ifc4x3.MeasureResource.IfcRatioMeasure" }, "") },
			{ "IfcRotationalFrequencyMeasure", new IfcMeasureInfo("IfcRotationalFrequencyMeasure", "Rotational frequency", "hertz", "Hz", "(0, 0, -1, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcRotationalFrequencyMeasure", "Ifc4.MeasureResource.IfcRotationalFrequencyMeasure", "Ifc4x3.MeasureResource.IfcRotationalFrequencyMeasure" }, "IfcDerivedUnitEnum.ROTATIONALFREQUENCYUNIT") },
			{ "IfcSectionModulusMeasure", new IfcMeasureInfo("IfcSectionModulusMeasure", "Section modulus", "", "m3", "(3, 0, 0, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcSectionModulusMeasure", "Ifc4.MeasureResource.IfcSectionModulusMeasure", "Ifc4x3.MeasureResource.IfcSectionModulusMeasure" }, "IfcDerivedUnitEnum.SECTIONMODULUSUNIT") },
			{ "IfcSoundPowerMeasure", new IfcMeasureInfo("IfcSoundPowerMeasure", "Sound power", "decibel", "db", "(0, 0, 0, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcSoundPowerMeasure", "Ifc4.MeasureResource.IfcSoundPowerMeasure", "Ifc4x3.MeasureResource.IfcSoundPowerMeasure" }, "IfcDerivedUnitEnum.SOUNDPOWERUNIT") },
			{ "IfcSoundPressureMeasure", new IfcMeasureInfo("IfcSoundPressureMeasure", "Sound pressure", "decibel", "db", "(0, 0, 0, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcSoundPressureMeasure", "Ifc4.MeasureResource.IfcSoundPressureMeasure", "Ifc4x3.MeasureResource.IfcSoundPressureMeasure" }, "IfcDerivedUnitEnum.SOUNDPRESSUREUNIT") },
			{ "IfcSpecificHeatCapacityMeasure", new IfcMeasureInfo("IfcSpecificHeatCapacityMeasure", "Specific heat capacity", "", "J/Kg K", "(2, 0, -2, 0, -1, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcSpecificHeatCapacityMeasure", "Ifc4.MeasureResource.IfcSpecificHeatCapacityMeasure", "Ifc4x3.MeasureResource.IfcSpecificHeatCapacityMeasure" }, "IfcDerivedUnitEnum.SPECIFICHEATCAPACITYUNIT") },
			{ "IfcTemperatureRateOfChangeMeasure", new IfcMeasureInfo("IfcTemperatureRateOfChangeMeasure", "Temperature rate of change", "", "K/s", "(0, 0, -1, 0, 1, 0, 0)", new[] { "Ifc4.MeasureResource.IfcTemperatureRateOfChangeMeasure", "Ifc4x3.MeasureResource.IfcTemperatureRateOfChangeMeasure" }, "IfcDerivedUnitEnum.TEMPERATURERATEOFCHANGEUNIT") },
			{ "IfcThermalConductivityMeasure", new IfcMeasureInfo("IfcThermalConductivityMeasure", "Thermal conductivity", "", "W/m K", "(1, 1, -3, 0, -1, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcThermalConductivityMeasure", "Ifc4.MeasureResource.IfcThermalConductivityMeasure", "Ifc4x3.MeasureResource.IfcThermalConductivityMeasure" }, "IfcDerivedUnitEnum.THERMALCONDUCTANCEUNIT") },
			{ "IfcThermodynamicTemperatureMeasure", new IfcMeasureInfo("IfcThermodynamicTemperatureMeasure", "Temperature", "kelvin", "K", "(0, 0, 0, 0, 1, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcThermodynamicTemperatureMeasure", "Ifc4.MeasureResource.IfcThermodynamicTemperatureMeasure", "Ifc4x3.MeasureResource.IfcThermodynamicTemperatureMeasure" }, "IfcUnitEnum.THERMODYNAMICTEMPERATUREUNIT") },
			{ "IfcTimeMeasure", new IfcMeasureInfo("IfcTimeMeasure", "Time", "second", "s", "(0, 0, 1, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcTimeMeasure", "Ifc4.MeasureResource.IfcTimeMeasure", "Ifc4x3.MeasureResource.IfcTimeMeasure" }, "IfcUnitEnum.TIMEUNIT") },
			{ "IfcTorqueMeasure", new IfcMeasureInfo("IfcTorqueMeasure", "Torque", "", "N m", "(2, 1, -2, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcTorqueMeasure", "Ifc4.MeasureResource.IfcTorqueMeasure", "Ifc4x3.MeasureResource.IfcTorqueMeasure" }, "IfcDerivedUnitEnum.TORQUEUNIT") },
			{ "IfcVaporPermeabilityMeasure", new IfcMeasureInfo("IfcVaporPermeabilityMeasure", "Vapor permeability", "", "Kg / s m Pa", "(0, 0, 1, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcVaporPermeabilityMeasure", "Ifc4.MeasureResource.IfcVaporPermeabilityMeasure", "Ifc4x3.MeasureResource.IfcVaporPermeabilityMeasure" }, "IfcDerivedUnitEnum.VAPORPERMEABILITYUNIT") },
			{ "IfcVolumeMeasure", new IfcMeasureInfo("IfcVolumeMeasure", "Volume", "cubic meter", "m3", "(3, 0, 0, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcVolumeMeasure", "Ifc4.MeasureResource.IfcVolumeMeasure", "Ifc4x3.MeasureResource.IfcVolumeMeasure" }, "IfcUnitEnum.VOLUMEUNIT") },
			{ "IfcVolumetricFlowRateMeasure", new IfcMeasureInfo("IfcVolumetricFlowRateMeasure", "Volumetric flow rate", "", "m3/s", "(3, 0, -1, 0, 0, 0, 0)", new[] { "Ifc2x3.MeasureResource.IfcVolumetricFlowRateMeasure", "Ifc4.MeasureResource.IfcVolumetricFlowRateMeasure", "Ifc4x3.MeasureResource.IfcVolumetricFlowRateMeasure" }, "IfcDerivedUnitEnum.VOLUMETRICFLOWRATEUNIT") },
		};
	}
}
