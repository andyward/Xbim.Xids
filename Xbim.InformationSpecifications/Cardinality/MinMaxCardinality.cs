﻿using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Xbim.InformationSpecifications.Cardinality
{
    public class MinMaxCardinality : ICardinality
    {
        /// <summary>
        /// The minimum cardinality.
        /// Defaults to 0 (optional).
        /// </summary>
        public int MinOccurs { get; set; } = 0;

        /// <summary>
        /// The maximum expected cardinality.
        /// If null to be considered unbounded, which is also the default
        /// </summary>
        public int? MaxOccurs { get; set; } = null;

        /// <summary>
        /// No requirement needed if maxoccurs is set to 0.
        /// </summary>
        public bool ExpectsRequirements => !(MaxOccurs.HasValue && MaxOccurs.Value == 0);

        public string Description
        {
            get
            {
                var smp = Simplify();
                if (smp is SimpleCardinality smp2)
                {
                    return smp2.Description;
                }
                StringBuilder sb = new StringBuilder();
                sb.Append(MinOccurs.ToString());
                if (MaxOccurs.HasValue)
                    sb.Append($"..{MaxOccurs}");
                return sb.ToString();
            }
        }

        public void ExportBuildingSmartIDS(XmlWriter xmlWriter, ILogger? logger)
        {
            xmlWriter.WriteAttributeString("minOccurs", MinOccurs.ToString());
            if (MaxOccurs != null)
                xmlWriter.WriteAttributeString("maxOccurs", MaxOccurs.ToString());
        }

        /// <summary>
        /// Attempt to reduce this to a SimpleCardinality, or return self.
        /// </summary>
        /// <returns>An instance of SimpleCardinality, if possible, otherwise this instance of MinMaxCardinality.</returns>
        public ICardinality Simplify()
        {
            if (MinOccurs == 0 && MaxOccurs is null)
                return new SimpleCardinality() { ApplicabilityCardinality = CardinalityEnum.Optional };
            else if (MinOccurs == 1 && MaxOccurs is null)
                return new SimpleCardinality() { ApplicabilityCardinality = CardinalityEnum.Required };
            else if (MinOccurs == 0 && MaxOccurs is not null && MaxOccurs.Value == 0)
                return new SimpleCardinality() { ApplicabilityCardinality = CardinalityEnum.Prohibited };
            return this;
        }
    }
}
