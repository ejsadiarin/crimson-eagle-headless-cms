﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using CMS.API.DataAccessLayer.Models;

namespace CMS.API.DataAccessLayer.Configurations
{
    public class cmsProjectConfigurations : IEntityTypeConfiguration<cmsProject>
    {
        public void Configure(EntityTypeBuilder<cmsProject> builder)
        {
            builder.HasData(
                    new cmsProject
                    {
                        Id = 1,
                        Name = "project 1 ",
                        ProjectOwnerId = 1,
                        LastUpdated = DateTime.UtcNow,
                        IsActive = true,
                    },
                    new cmsProject
                    {
                        Id = 2,
                        Name = "project 2",
                        ProjectOwnerId = 2,
                        LastUpdated = DateTime.UtcNow,
                        IsActive = true,
                    }
                );
        }
    }
}