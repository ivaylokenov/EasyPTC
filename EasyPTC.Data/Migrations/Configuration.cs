namespace EasyPTC.Data.Migrations
{
    using EasyPTC.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EasyPtcDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(EasyPtcDbContext context)
        {
            this.SeedAds(context);
        }

        private void SeedAds(EasyPtcDbContext context)
        {
            context.Advertisements.AddOrUpdate(a => a.Id,
                new Advertisement
                {
                    Name = "We are cool",
                    AvailableClicks = 500,
                    Url = "telerikacademy.com",
                },
                new Advertisement
                {
                    Name = "We are cool 1",
                    AvailableClicks = 500,
                    Url = "telerikacademy.com",
                }, new Advertisement
                {
                    Name = "We are cool 2",
                    AvailableClicks = 500,
                    Url = "telerikacademy.com",
                },
                new Advertisement
                {
                    Name = "We are cool",
                    AvailableClicks = 500,
                    Url = "telerikacademy.com",
                },
                new Advertisement
                {
                    Name = "We are cool 1",
                    AvailableClicks = 500,
                    Url = "telerikacademy.com",
                }, new Advertisement
                {
                    Name = "We are cool 2",
                    AvailableClicks = 500,
                    Url = "telerikacademy.com",
                }, new Advertisement
                {
                    Name = "We are cool",
                    AvailableClicks = 500,
                    Url = "telerikacademy.com",
                },
                new Advertisement
                {
                    Name = "We are cool 1",
                    AvailableClicks = 500,
                    Url = "telerikacademy.com",
                }, new Advertisement
                {
                    Name = "We are cool 2",
                    AvailableClicks = 500,
                    Url = "telerikacademy.com",
                }, new Advertisement
                {
                    Name = "We are cool",
                    AvailableClicks = 500,
                    Url = "telerikacademy.com",
                },
                new Advertisement
                {
                    Name = "We are cool 1",
                    AvailableClicks = 500,
                    Url = "telerikacademy.com",
                }, new Advertisement
                {
                    Name = "We are cool 2",
                    AvailableClicks = 500,
                    Url = "telerikacademy.com",
                }, new Advertisement
                {
                    Name = "We are cool",
                    AvailableClicks = 500,
                    Url = "telerikacademy.com",
                },
                new Advertisement
                {
                    Name = "We are cool 1",
                    AvailableClicks = 500,
                    Url = "telerikacademy.com",
                }, new Advertisement
                {
                    Name = "We are cool 2",
                    AvailableClicks = 500,
                    Url = "telerikacademy.com",
                }, new Advertisement
                {
                    Name = "We are cool",
                    AvailableClicks = 500,
                    Url = "telerikacademy.com",
                },
                new Advertisement
                {
                    Name = "We are cool 1",
                    AvailableClicks = 500,
                    Url = "telerikacademy.com",
                }, new Advertisement
                {
                    Name = "We are cool 2",
                    AvailableClicks = 500,
                    Url = "telerikacademy.com",
                }, new Advertisement
                {
                    Name = "We are cool",
                    AvailableClicks = 500,
                    Url = "telerikacademy.com",
                },
                new Advertisement
                {
                    Name = "We are cool 1",
                    AvailableClicks = 500,
                    Url = "telerikacademy.com",
                }, new Advertisement
                {
                    Name = "We are cool 2",
                    AvailableClicks = 500,
                    Url = "telerikacademy.com",
                }, new Advertisement
                {
                    Name = "We are cool",
                    AvailableClicks = 500,
                    Url = "telerikacademy.com",
                },
                new Advertisement
                {
                    Name = "We are cool 1",
                    AvailableClicks = 500,
                    Url = "telerikacademy.com",
                }, new Advertisement
                {
                    Name = "We are cool 2",
                    AvailableClicks = 500,
                    Url = "telerikacademy.com",
                });
        }
    }
}
