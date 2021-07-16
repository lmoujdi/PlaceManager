using PlaceManager.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlaceManager.Data
{
    public static class DbInitializer
    {
        public static void Initialize(PlaceDbContext context)
        {

            if (context.Places.Any())
            {
                return;
            }

            var places = new Place[]
            {
                new Place { Name = "Le Café du Marché",   Address = "Rue de Conthey 17, 1950 Sion" },
                new Place { Name = "Casa Ferlin",   Address = "Stampfenbachstrasse 38, 8006 Zürich"}
            };

            foreach (Place s in places)
            {
                context.Places.Add(s);
            }
            context.SaveChanges();


            var openingHours = new OpeningHour[]{

                        new OpeningHour
                        {
                            PlaceId = places.Single(x=>x.Name =="Casa Ferlin").Id,
                            Day =1,
                            openingHourType=OpeningHourType.Open,
                            Start= "10:30",
                            End = "15:00"
                        },
                         new OpeningHour
                        {
                             PlaceId = places.Single(x=>x.Name =="Casa Ferlin").Id,
                            Day =2,
                            openingHourType=OpeningHourType.Open,
                            Start= "10:30",
                            End = "15:00"
                        },
                          new OpeningHour
                        {
                            PlaceId = places.Single(x=>x.Name =="Casa Ferlin").Id,
                            Day =4,
                            openingHourType=OpeningHourType.Open,
                            Start= "10:30",
                            End = "15:00"
                        },
                           new OpeningHour
                        {
                             PlaceId = places.Single(x=>x.Name =="Casa Ferlin").Id,
                            Day =5,
                            openingHourType=OpeningHourType.Open,
                            Start= "10:30",
                            End = "15:00"
                        },
                             new OpeningHour
                        {
                             PlaceId = places.Single(x=>x.Name =="Casa Ferlin").Id,
                            Day =6,
                            openingHourType=OpeningHourType.Close,
                            Start= "10:30",
                            End = "15:00"
                        },
                               new OpeningHour
                        {
                            PlaceId = places.Single(x=>x.Name =="Casa Ferlin").Id,
                            Day =7,
                            openingHourType=OpeningHourType.Close,
                            Start= "10:30",
                            End = "15:00"
                        }
                    ,
                        new OpeningHour
                        {
                            PlaceId = places.Single(x=>x.Name =="Le Café du Marché" ).Id,
                            Day =1,
                            openingHourType=OpeningHourType.Open,
                            Start= "10:30",
                            End = "15:00"
                        },
                         new OpeningHour
                        {
                           PlaceId = places.Single(x=>x.Name =="Le Café du Marché" ).Id,
                            Day =2,
                            openingHourType=OpeningHourType.Open,
                            Start= "10:30",
                            End = "15:00"
                        },
                          new OpeningHour
                          {
                              PlaceId = places.Single(x=>x.Name =="Le Café du Marché" ).Id,
                              Day = 4,
                              openingHourType = OpeningHourType.Open,
                              Start = "10:30",
                              End = "15:00"
                          },
                           new OpeningHour
                           {
                               PlaceId = places.Single(x=>x.Name =="Le Café du Marché" ).Id,
                               Day = 5,
                               openingHourType = OpeningHourType.Open,
                               Start = "10:30",
                               End = "15:00"
                           },
                             new OpeningHour
                             {
                                PlaceId = places.Single(x=>x.Name =="Le Café du Marché" ).Id,
                                 Day = 6,
                                 openingHourType = OpeningHourType.Close,
                                 Start = "10:30",
                                 End = "15:00"
                             },
                               new OpeningHour
                               {
                                  PlaceId = places.Single(x=>x.Name =="Le Café du Marché" ).Id,
                                   Day = 7,
                                   openingHourType = OpeningHourType.Close,
                                   Start = "10:30",
                                   End = "15:00"
                               }

                };

            foreach (OpeningHour o in openingHours)
            {
                context.OpeningHours.Add(o);
            }

            context.SaveChanges();
        }
    }
}
