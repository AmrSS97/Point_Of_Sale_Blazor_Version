using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using Models.Enums;
using Models.Enums.Extensions;
using System;
using System.Collections.Generic;

namespace Data.Configuration
{
    public class FeatureConfiguration : IEntityTypeConfiguration<Feature>
    {
        public void Configure(EntityTypeBuilder<Feature> builder)
        {
            List<Feature> lstFeatures = new List<Feature>();

            lstFeatures.Add(new Feature
            {
                FeatureID = FeatureEnum.Security.GetEnumGuid(),
                FeatureName = "Security",
                FeatureNameAr = "نظام الحماية",
                MenuIcon = "icon-wrench"
            });
            lstFeatures.Add(new Feature
            {
                FeatureID = FeatureEnum.ControlPanel.GetEnumGuid(),
                FeatureName = "Control Panel",
                FeatureNameAr = "لوحة التحكم",
                MenuIcon = "icon-settings"
            });

            builder.HasData(lstFeatures.ToArray());
        }
    }
}
