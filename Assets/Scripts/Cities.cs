﻿using System.Collections.Generic;

public enum City
{
    Testbase,
    Tron
}

public static class Cities
{
    private static List<string> cityNames = new List<string>() {"TestBase", "TRON"};

    public static List<string> GetNames()
    {
        return cityNames;
    }


    public static Streets[] GetStreets(City name)
    {
        Streets[] streetses = new Streets[1];
        switch (name)
        {
            case City.Testbase:
                streetses = new[]
                {
                    new Streets {NameStreet = "Street1", AboutStreet = "Желтая улица, короткая часть - парковка"},
                    new Streets {NameStreet = "Street2", AboutStreet = "Красная улица"},
                    new Streets {NameStreet = "Street3", AboutStreet = "Зеленая улица, короткая часть - парк"},
                    new Streets {NameStreet = "Street4", AboutStreet = "Синяя улица"},
                    new Streets {NameStreet = "Street5", AboutStreet = "Розовая улица"},
                    new Streets {NameStreet = "Street6", AboutStreet = "Фиолетовая улица"},
                    new Streets {NameStreet = "Street7", AboutStreet = "Салатовая улица"},
                    new Streets {NameStreet = "Street8", AboutStreet = "Коричневая улица"},
                    new Streets {NameStreet = "Street9", AboutStreet = "Голубая улица, короткая часть - суд"},
                    new Streets {NameStreet = "Street10", AboutStreet = "Оранжевая улица"},
                    new Streets {NameStreet = "Street11", AboutStreet = "Бордовая улица, длинная часть = парк"},
                };
                break;
            case City.Tron:
                streetses = new[]
                {
                    new Streets {NameStreet = "Яблочная", AboutStreet = "3 части"},
                    new Streets {NameStreet = "Томатная", AboutStreet = "3 части"},
                    new Streets {NameStreet = "Мандариновая", AboutStreet = "4 части, первая парк"},
                    new Streets {NameStreet = "Морская", AboutStreet = "4 части"},
                    new Streets {NameStreet = "Сретенка", AboutStreet = "2 части, парк и суд"},
                    new Streets {NameStreet = "Баклажановая", AboutStreet = "3 части"},
                    new Streets {NameStreet = "БэтУлица", AboutStreet = "3 части"},
                    new Streets {NameStreet = "Горная", AboutStreet = "2 части"},
                    new Streets {NameStreet = "Оррная", AboutStreet = "2 части"},
                    new Streets {NameStreet = "Угандовая", AboutStreet = "3 части"},
                    new Streets {NameStreet = "Вакандовая", AboutStreet = "2 части"},
                    new Streets {NameStreet = "Угольная", AboutStreet = "2 части"},
                    new Streets {NameStreet = "Виноградная", AboutStreet = "3 части"},
                    new Streets {NameStreet = "ТМовская", AboutStreet = "4 части, 1 казино"},
                    new Streets {NameStreet = "Единороговая", AboutStreet = "3 части"},
                    new Streets {NameStreet = "Седановая", AboutStreet = "3 части"},
                    new Streets {NameStreet = "Транспортная", AboutStreet = "3 части"},
                    new Streets {NameStreet = "Коммунальная", AboutStreet = "2 части"}
                };
                break;
        }

        return streetses;
    }

    public static StreetPaths[] GetStreetPaths(City name)
    {
        StreetPaths[] pathes = new StreetPaths[1];
        switch (name)
        {
            case City.Testbase:
                pathes = new[]
                {
                    new StreetPaths
                    {
                        Renta = 25,
                        NamePath = "Желтая 1",
                        IdStreetParent = 1,
                        StartX = 5.63,
                        StartY = -5.64,
                        EndX = -1.57,
                        EndY = -5.64,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 20,
                        NamePath = "Желтая 2",
                        IdStreetParent = 1,
                        StartX = -1.57,
                        StartY = -5.64,
                        EndX = -5.68,
                        EndY = -5.64,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 20,
                        NamePath = "Красная 1",
                        IdStreetParent = 2,
                        StartX = -5.68,
                        StartY = -5.64,
                        EndX = -5.68,
                        EndY = -1.58,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 25,
                        NamePath = "Красная 2",
                        IdStreetParent = 2,
                        StartX = -5.68,
                        StartY = -1.58,
                        EndX = -5.68,
                        EndY = 5.62,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 20,
                        NamePath = "Зеленая 1",
                        IdStreetParent = 3,
                        StartX = -5.68,
                        StartY = 5.62,
                        EndX = -2.63,
                        EndY = 5.62,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 25,
                        NamePath = "Зеленая 2",
                        IdStreetParent = 3,
                        StartX = -2.63,
                        StartY = 5.62,
                        EndX = 5.63,
                        EndY = 5.62,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 20,
                        NamePath = "Синяя 1",
                        IdStreetParent = 4,
                        StartX = 5.63,
                        StartY = 5.62,
                        EndX = 5.63,
                        EndY = 1.58,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 25,
                        NamePath = "Синяя 2",
                        IdStreetParent = 4,
                        StartX = 5.63,
                        StartY = 1.58,
                        EndX = 5.63,
                        EndY = -5.64,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 15,
                        NamePath = "Розовая",
                        IdStreetParent = 5,
                        StartX = -1.57,
                        StartY = -5.64,
                        EndX = -1.57,
                        EndY = -2.74,
                        IsBridge = true
                    },
                    new StreetPaths
                    {
                        Renta = 15,
                        NamePath = "Фиолетовая",
                        IdStreetParent = 6,
                        StartX = -5.68,
                        StartY = -1.58,
                        EndX = -2.68,
                        EndY = -1.58,
                        IsBridge = true
                    },
                    new StreetPaths
                    {
                        Renta = 15,
                        NamePath = "Салатовая 1",
                        IdStreetParent = 7,
                        StartX = -2.63,
                        StartY = 5.62,
                        EndX = -2.63,
                        EndY = 2.68,
                        IsBridge = true
                    },
                    new StreetPaths
                    {
                        Renta = 15,
                        NamePath = "Коричневая",
                        IdStreetParent = 8,
                        StartX = 5.63,
                        StartY = 1.58,
                        EndX = 2.65,
                        EndY = 1.58,
                        IsBridge = true
                    },
                    new StreetPaths
                    {
                        Renta = 25,
                        NamePath = "Голубая 1",
                        IdStreetParent = 9,
                        StartX = 2.65,
                        StartY = -2.74,
                        EndX = -1.57,
                        EndY = -2.74,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 15,
                        NamePath = "Голубая 2",
                        IdStreetParent = 9,
                        StartX = -1.57,
                        StartY = -2.74,
                        EndX = -2.68,
                        EndY = -1.58,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 15,
                        NamePath = "Салатовая 2",
                        IdStreetParent = 7,
                        StartX = -2.68,
                        StartY = -1.58,
                        EndX = -2.63,
                        EndY = 2.68,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 25,
                        NamePath = "Оранжевая",
                        IdStreetParent = 10,
                        StartX = -2.63,
                        StartY = 2.68,
                        EndX = 2.65,
                        EndY = 2.68,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 25,
                        NamePath = "Бордовая 1",
                        IdStreetParent = 11,
                        StartX = 2.65,
                        StartY = 2.68,
                        EndX = 2.65,
                        EndY = 1.58,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 25,
                        NamePath = "Бородовая 2",
                        IdStreetParent = 11,
                        StartX = 2.65,
                        StartY = 1.58,
                        EndX = 2.65,
                        EndY = -2.74,
                        IsBridge = false
                    }
                };
                break;
            case City.Tron:
                pathes = new[]
                {
                    new StreetPaths
                    {
                        Renta = 25,
                        NamePath = "Яблочная 1",
                        IdStreetParent = 1,
                        StartX = 159,
                        StartY = -157,
                        EndX = 0.5,
                        EndY = -157,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 20,
                        NamePath = "Яблочная 2",
                        IdStreetParent = 1,
                        StartX = 0.5,
                        StartY = -157,
                        EndX = -51,
                        EndY = -157,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 30,
                        NamePath = "Транспортная 1",
                        IdStreetParent = 17,
                        StartX = -51,
                        StartY = -157,
                        EndX = -104,
                        EndY = -157,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 25,
                        NamePath = "Яблочная 3",
                        IdStreetParent = 1,
                        StartX = -104,
                        StartY = -157,
                        EndX = -156,
                        EndY = -157,
                        IsBridge = false
                    },

                    new StreetPaths
                    {
                        Renta = 20,
                        NamePath = "Томатная 1",
                        IdStreetParent = 2,
                        StartX = -156,
                        StartY = -157,
                        EndX = -156,
                        EndY = -52,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 25,
                        NamePath = "Томатная 2",
                        IdStreetParent = 2,
                        StartX = -156,
                        StartY = -52,
                        EndX = -156,
                        EndY = 0.5,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 20,
                        NamePath = "Томатная 3",
                        IdStreetParent = 2,
                        StartX = -156,
                        StartY = 0.5,
                        EndX = -156,
                        EndY = 53,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 20,
                        NamePath = "Мандариновая 1",
                        IdStreetParent = 3,
                        StartX = -156,
                        StartY = 53,
                        EndX = -156,
                        EndY = 157,
                        IsBridge = false
                    },

                    new StreetPaths
                    {
                        Renta = 30,
                        NamePath = "Мандариновая 2",
                        IdStreetParent = 3,
                        StartX = -156,
                        StartY = 157,
                        EndX = -51,
                        EndY = 157,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 30,
                        NamePath = "Мандариновая 3",
                        IdStreetParent = 3,
                        StartX = -51,
                        StartY = 157,
                        EndX = 54,
                        EndY = 157,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 25,
                        NamePath = "Мандариновая 4",
                        IdStreetParent = 3,
                        StartX = 54,
                        StartY = 157,
                        EndX = 106.5,
                        EndY = 157,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 20,
                        NamePath = "Морская 1",
                        IdStreetParent = 4,
                        StartX = 106.5,
                        StartY = 157,
                        EndX = 159,
                        EndY = 157,
                        IsBridge = false
                    },

                    new StreetPaths
                    {
                        Renta = 25,
                        NamePath = "Морская 2",
                        IdStreetParent = 4,
                        StartX = 159,
                        StartY = 157,
                        EndX = 159,
                        EndY = 53,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 25,
                        NamePath = "Морская 3",
                        IdStreetParent = 4,
                        StartX = 159,
                        StartY = 53,
                        EndX = 159,
                        EndY = -52,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 30,
                        NamePath = "Коммунальная 1",
                        IdStreetParent = 18,
                        StartX = 159,
                        StartY = -52,
                        EndX = 159,
                        EndY = -103.5,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 20,
                        NamePath = "Морская 4",
                        IdStreetParent = 4,
                        StartX = 159,
                        StartY = -103.5,
                        EndX = 159,
                        EndY = -157,
                        IsBridge = false
                    },

                    new StreetPaths
                    {
                        Renta = 20,
                        NamePath = "Сретенка 1",
                        IdStreetParent = 5,
                        StartX = 159,
                        StartY = -103.5,
                        EndX = 54,
                        EndY = -103.5,
                        IsBridge = true
                    },
                    new StreetPaths
                    {
                        Renta = 20,
                        NamePath = "Сретенка 2",
                        IdStreetParent = 5,
                        StartX = 54,
                        StartY = -103.5,
                        EndX = 0.5,
                        EndY = -103.5,
                        IsBridge = true
                    },

                    new StreetPaths
                    {
                        Renta = 20,
                        NamePath = "Баклажановая 1",
                        IdStreetParent = 6,
                        StartX = 159,
                        StartY = -52,
                        EndX = 106.5,
                        EndY = -52,
                        IsBridge = true
                    },
                    new StreetPaths
                    {
                        Renta = 20,
                        NamePath = "Баклажановая 2",
                        IdStreetParent = 6,
                        StartX = 106.5,
                        StartY = -52,
                        EndX = 54,
                        EndY = -52,
                        IsBridge = true
                    },
                    new StreetPaths
                    {
                        Renta = 20,
                        NamePath = "Баклажановая 3",
                        IdStreetParent = 6,
                        StartX = 54,
                        StartY = -52,
                        EndX = 0.5,
                        EndY = -52,
                        IsBridge = true
                    },
                    new StreetPaths
                    {
                        Renta = 40,
                        NamePath = "БэтУлица 1",
                        IdStreetParent = 7,
                        StartX = 0.5,
                        StartY = -52,
                        EndX = -51,
                        EndY = -52,
                        IsBridge = true
                    },
                    new StreetPaths
                    {
                        Renta = 40,
                        NamePath = "БэтУлица 2",
                        IdStreetParent = 7,
                        StartX = -51,
                        StartY = -52,
                        EndX = -104,
                        EndY = -52,
                        IsBridge = true
                    },
                    new StreetPaths
                    {
                        Renta = 40,
                        NamePath = "БэтУлица 3",
                        IdStreetParent = 7,
                        StartX = -104,
                        StartY = -52,
                        EndX = -156,
                        EndY = -52,
                        IsBridge = true
                    },

                    new StreetPaths
                    {
                        Renta = 20,
                        NamePath = "Горная 1",
                        IdStreetParent = 8,
                        StartX = 106.5,
                        StartY = 0.5,
                        EndX = 54,
                        EndY = 0.5,
                        IsBridge = true
                    },
                    new StreetPaths
                    {
                        Renta = 25,
                        NamePath = "Горная 2",
                        IdStreetParent = 8,
                        StartX = 54,
                        StartY = 0.5,
                        EndX = 0.5,
                        EndY = 0.5,
                        IsBridge = true
                    },
                    new StreetPaths
                    {
                        Renta = 30,
                        NamePath = "Коммунальная 2",
                        IdStreetParent = 18,
                        StartX = 0.5,
                        StartY = 0.5,
                        EndX = -51,
                        EndY = 0.5,
                        IsBridge = true
                    },
                    new StreetPaths
                    {
                        Renta = 20,
                        NamePath = "Орная 1",
                        IdStreetParent = 9,
                        StartX = -51,
                        StartY = 0.5,
                        EndX = -104,
                        EndY = 0.5,
                        IsBridge = true
                    },
                    new StreetPaths
                    {
                        Renta = 25,
                        NamePath = "Орная 2",
                        IdStreetParent = 9,
                        StartX = -104,
                        StartY = 0.5,
                        EndX = -156,
                        EndY = 0.5,
                        IsBridge = true
                    },

                    new StreetPaths
                    {
                        Renta = 25,
                        NamePath = "Угандовая 1",
                        IdStreetParent = 10,
                        StartX = 159,
                        StartY = 53,
                        EndX = 106.5,
                        EndY = 53,
                        IsBridge = true
                    },
                    new StreetPaths
                    {
                        Renta = 25,
                        NamePath = "Угандовая 2",
                        IdStreetParent = 10,
                        StartX = 106.5,
                        StartY = 53,
                        EndX = 54,
                        EndY = 53,
                        IsBridge = true
                    },
                    new StreetPaths
                    {
                        Renta = 25,
                        NamePath = "Угандовая 3",
                        IdStreetParent = 10,
                        StartX = 54,
                        StartY = 53,
                        EndX = 0.5,
                        EndY = 53,
                        IsBridge = true
                    },
                    new StreetPaths
                    {
                        Renta = 25,
                        NamePath = "Вакандовая 1",
                        IdStreetParent = 11,
                        StartX = 0.5,
                        StartY = 53,
                        EndX = -51,
                        EndY = 53,
                        IsBridge = true
                    },
                    new StreetPaths
                    {
                        Renta = 25,
                        NamePath = "Вакандовая 2",
                        IdStreetParent = 11,
                        StartX = -51,
                        StartY = 53,
                        EndX = -156,
                        EndY = 53,
                        IsBridge = true
                    },

                    new StreetPaths
                    {
                        Renta = 20,
                        NamePath = "Угольная 1",
                        IdStreetParent = 12,
                        StartX = -104,
                        StartY = -157,
                        EndX = -104,
                        EndY = -52,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 20,
                        NamePath = "Угольная 2",
                        IdStreetParent = 12,
                        StartX = -103,
                        StartY = -52,
                        EndX = -104,
                        EndY = 0.5,
                        IsBridge = false
                    },

                    new StreetPaths
                    {
                        Renta = 20,
                        NamePath = "Виноградная 1",
                        IdStreetParent = 13,
                        StartX = -51,
                        StartY = -157,
                        EndX = -51,
                        EndY = -52,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 20,
                        NamePath = "Виноградная 2",
                        IdStreetParent = 13,
                        StartX = -51,
                        StartY = -52,
                        EndX = -51,
                        EndY = 0.5,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 20,
                        NamePath = "Виноградная 3",
                        IdStreetParent = 13,
                        StartX = -51,
                        StartY = 0.5,
                        EndX = -51,
                        EndY = 53,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 30,
                        NamePath = "Транспортная 2",
                        IdStreetParent = 17,
                        StartX = -51,
                        StartY = 53,
                        EndX = -51,
                        EndY = 157,
                        IsBridge = false
                    },

                    new StreetPaths
                    {
                        Renta = 50,
                        NamePath = "ТМовская 1",
                        IdStreetParent = 14,
                        StartX = 0.5,
                        StartY = 53,
                        EndX = 0.5,
                        EndY = 0.5,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 50,
                        NamePath = "ТМовская 2",
                        IdStreetParent = 14,
                        StartX = 0.5,
                        StartY = 0.5,
                        EndX = 0.5,
                        EndY = -52,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 50,
                        NamePath = "ТМовская 3",
                        IdStreetParent = 14,
                        StartX = 0.5,
                        StartY = -52,
                        EndX = 0.5,
                        EndY = -103.5,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 50,
                        NamePath = "ТМовская 4",
                        IdStreetParent = 14,
                        StartX = 0.5,
                        StartY = -103.5,
                        EndX = 0.5,
                        EndY = -157,
                        IsBridge = false
                    },

                    new StreetPaths
                    {
                        Renta = 40,
                        NamePath = "Единороговая 1",
                        IdStreetParent = 15,
                        StartX = 54,
                        StartY = 157,
                        EndX = 54,
                        EndY = 53,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 40,
                        NamePath = "Единороговая 2",
                        IdStreetParent = 15,
                        StartX = 54,
                        StartY = 53,
                        EndX = 54,
                        EndY = 0.5,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 40,
                        NamePath = "Единороговая 3",
                        IdStreetParent = 15,
                        StartX = 54,
                        StartY = 0.5,
                        EndX = 54,
                        EndY = -52,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 40,
                        NamePath = "Транспортная 3",
                        IdStreetParent = 17,
                        StartX = 54,
                        StartY = -52,
                        EndX = 54,
                        EndY = -103.5,
                        IsBridge = false
                    },

                    new StreetPaths
                    {
                        Renta = 20,
                        NamePath = "Седановая 1",
                        IdStreetParent = 16,
                        StartX = 106.5,
                        StartY = 157,
                        EndX = 106.5,
                        EndY = 53,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 20,
                        NamePath = "Седановая 2",
                        IdStreetParent = 16,
                        StartX = 106.5,
                        StartY = 53,
                        EndX = 106.5,
                        EndY = 0.5,
                        IsBridge = false
                    },
                    new StreetPaths
                    {
                        Renta = 20,
                        NamePath = "Седановая 3",
                        IdStreetParent = 16,
                        StartX = 106.5,
                        StartY = 0.5,
                        EndX = 106.5,
                        EndY = -52,
                        IsBridge = false
                    }
                };
                break;
        }

        return pathes;
    }

    public static PathsForBuy[] GetPathForBuys(City name)
    {
        PathsForBuy[] pathsForBuys = new PathsForBuy[1];
        switch (name)
        {
            case City.Testbase:
                pathsForBuys = new[]
                {
                    new PathsForBuy {IdPathForBuy = 1, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 3, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 4, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 6, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 7, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 8, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 9, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 10, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 11, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 12, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 13, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 15, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 16, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 17, IdPlayer = 0, PriceStreetPath = 100}
                };
                break;
            case City.Tron:
                pathsForBuys = new[]
                {
                    new PathsForBuy {IdPathForBuy = 1, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 2, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 3, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 4, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 5, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 6, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 7, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 9, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 10, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 11, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 12, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 13, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 14, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 15, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 16, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 19, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 20, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 21, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 22, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 23, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 24, IdPlayer = 0, PriceStreetPath = 200},
                    new PathsForBuy {IdPathForBuy = 25, IdPlayer = 0, PriceStreetPath = 200},
                    new PathsForBuy {IdPathForBuy = 26, IdPlayer = 0, PriceStreetPath = 200},
                    new PathsForBuy {IdPathForBuy = 27, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 28, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 29, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 30, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 31, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 32, IdPlayer = 0, PriceStreetPath = 150},
                    new PathsForBuy {IdPathForBuy = 33, IdPlayer = 0, PriceStreetPath = 150},
                    new PathsForBuy {IdPathForBuy = 34, IdPlayer = 0, PriceStreetPath = 150},
                    new PathsForBuy {IdPathForBuy = 35, IdPlayer = 0, PriceStreetPath = 150},
                    new PathsForBuy {IdPathForBuy = 36, IdPlayer = 0, PriceStreetPath = 150},
                    new PathsForBuy {IdPathForBuy = 37, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 38, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 39, IdPlayer = 0, PriceStreetPath = 150},
                    new PathsForBuy {IdPathForBuy = 40, IdPlayer = 0, PriceStreetPath = 150},
                    new PathsForBuy {IdPathForBuy = 42, IdPlayer = 0, PriceStreetPath = 150},
                    new PathsForBuy {IdPathForBuy = 43, IdPlayer = 0, PriceStreetPath = 150},
                    new PathsForBuy {IdPathForBuy = 44, IdPlayer = 0, PriceStreetPath = 200},
                    new PathsForBuy {IdPathForBuy = 45, IdPlayer = 0, PriceStreetPath = 200},
                    new PathsForBuy {IdPathForBuy = 46, IdPlayer = 0, PriceStreetPath = 200},
                    new PathsForBuy {IdPathForBuy = 47, IdPlayer = 0, PriceStreetPath = 150},
                    new PathsForBuy {IdPathForBuy = 48, IdPlayer = 0, PriceStreetPath = 150},
                    new PathsForBuy {IdPathForBuy = 49, IdPlayer = 0, PriceStreetPath = 150},
                    new PathsForBuy {IdPathForBuy = 50, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 51, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 52, IdPlayer = 0, PriceStreetPath = 100},
                    new PathsForBuy {IdPathForBuy = 53, IdPlayer = 0, PriceStreetPath = 100}
                };
                break;
        }

        return pathsForBuys;
    }

    public static Builds[] GetBuildses(City name)
    {
        Builds[] buildses = new Builds[1];
        switch (name)
        {
            case City.Testbase:
                buildses = new[]
                {
                    new Builds
                    {
                        NameBuild = "Дом на Желтой 1",
                        AboutBuild = "",
                        Enabled = false,
                        IdStreetPath = 1,
                        PriceBuild = 100,
                        posX = 2.25,
                        posY = -7
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Красной 1",
                        AboutBuild = "",
                        Enabled = false,
                        IdStreetPath = 3,
                        PriceBuild = 100,
                        posX = -7,
                        posY = -3.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Красной 2",
                        AboutBuild = "",
                        Enabled = false,
                        IdStreetPath = 4,
                        PriceBuild = 100,
                        posX = -7,
                        posY = 2
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Зеленой 2",
                        AboutBuild = "",
                        Enabled = false,
                        IdStreetPath = 6,
                        PriceBuild = 100,
                        posX = 1.5,
                        posY = 7
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Синей 1",
                        AboutBuild = "",
                        Enabled = false,
                        IdStreetPath = 7,
                        PriceBuild = 100,
                        posX = 7,
                        posY = 4
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Синей 2.1",
                        AboutBuild = "",
                        Enabled = false,
                        IdStreetPath = 8,
                        PriceBuild = 100,
                        posX = 7,
                        posY = -1
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Синей 2.2",
                        AboutBuild = "",
                        Enabled = false,
                        IdStreetPath = 8,
                        PriceBuild = 100,
                        posX = 7,
                        posY = -3.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Розовой",
                        AboutBuild = "",
                        Enabled = false,
                        IdStreetPath = 9,
                        PriceBuild = 100,
                        posX = 0,
                        posY = -4
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Фиолетовой",
                        AboutBuild = "",
                        Enabled = false,
                        IdStreetPath = 10,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Салатовой 1",
                        AboutBuild = "",
                        Enabled = false,
                        IdStreetPath = 11,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Коричневой",
                        AboutBuild = "",
                        Enabled = false,
                        IdStreetPath = 12,
                        PriceBuild = 100,
                        posX = 4.2,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Голубой 1",
                        AboutBuild = "",
                        Enabled = false,
                        IdStreetPath = 13,
                        PriceBuild = 100,
                        posX = 0,
                        posY = -1
                    },
                    new Builds
                    {
                        NameBuild = "Дои на Салатовая 2",
                        AboutBuild = "",
                        Enabled = false,
                        IdStreetPath = 15,
                        PriceBuild = 100,
                        posX = -1.3,
                        posY = 1
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Оранжевой",
                        AboutBuild = "",
                        Enabled = false,
                        IdStreetPath = 16,
                        PriceBuild = 100,
                        posX = 0,
                        posY = 4
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Бордовой 1",
                        AboutBuild = "",
                        Enabled = false,
                        IdStreetPath = 17,
                        PriceBuild = 100,
                        posX = 4,
                        posY = 3.35
                    }
                };
                break;
            case City.Tron:
                buildses = new[]
                {
                    new Builds
                    {
                        NameBuild = "Дом на Яблочной 1.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 1,
                        PriceBuild = 100,
                        posX = 2.25,
                        posY = -7
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Яблочной 1.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 1,
                        PriceBuild = 100,
                        posX = -7,
                        posY = -3.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Яблочной 1.3",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 1,
                        PriceBuild = 100,
                        posX = -7,
                        posY = 2
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Яблочной 1.4",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 1,
                        PriceBuild = 100,
                        posX = 1.5,
                        posY = 7
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Яблочной 1.5",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 1,
                        PriceBuild = 100,
                        posX = 7,
                        posY = 4
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Яблочной 1.6",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 1,
                        PriceBuild = 100,
                        posX = 7,
                        posY = -1
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Яблочной 1.7",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 1,
                        PriceBuild = 100,
                        posX = 7,
                        posY = -3.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Яблочной 1.8",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 1,
                        PriceBuild = 100,
                        posX = 0,
                        posY = -4
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Яблочной 1.9",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 1,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Яблочной 1.10",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 1,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Яблочной 2.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 2,
                        PriceBuild = 100,
                        posX = 4.2,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Яблочной 2.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 2,
                        PriceBuild = 100,
                        posX = 0,
                        posY = -1
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Яблочной 2.3",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 2,
                        PriceBuild = 100,
                        posX = -1.3,
                        posY = 1
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Транспортной 1.1",
                        AboutBuild = "Прокат велосипедов",
                        Enabled = false,
                        IdStreetPath = 3,
                        PriceBuild = 100,
                        posX = -7,
                        posY = -3.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Транспортной 1.2",
                        AboutBuild = "Таксопарк",
                        Enabled = false,
                        IdStreetPath = 3,
                        PriceBuild = 100,
                        posX = -7,
                        posY = 2
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Транспортной 1.3",
                        AboutBuild = "Станция метро",
                        Enabled = false,
                        IdStreetPath = 3,
                        PriceBuild = 100,
                        posX = 1.5,
                        posY = 7
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Яблочной 3.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 4,
                        PriceBuild = 100,
                        posX = 0,
                        posY = 4
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Яблочной 3.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 4,
                        PriceBuild = 100,
                        posX = 4,
                        posY = 3.35
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Яблочной 3.3",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 4,
                        PriceBuild = 100,
                        posX = 2.25,
                        posY = -7
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Томатной 1.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 5,
                        PriceBuild = 100,
                        posX = 7,
                        posY = 4
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Томатной 1.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 5,
                        PriceBuild = 100,
                        posX = 7,
                        posY = -1
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Томатной 1.3",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 5,
                        PriceBuild = 100,
                        posX = 7,
                        posY = -3.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Томатной 1.4",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 5,
                        PriceBuild = 100,
                        posX = 0,
                        posY = -4
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Томатной 1.5",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 5,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Томатной 1.6",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 5,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Томатной 1.7",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 5,
                        PriceBuild = 100,
                        posX = 4.2,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Томатной 1.8",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 5,
                        PriceBuild = 100,
                        posX = 0,
                        posY = -1
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Томатной 2.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 6,
                        PriceBuild = 100,
                        posX = -1.3,
                        posY = 1
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Томатной 2.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 6,
                        PriceBuild = 100,
                        posX = 0,
                        posY = 4
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Томатной 2.3",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 6,
                        PriceBuild = 100,
                        posX = 4,
                        posY = 3.35
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Томатной 3.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 7,
                        PriceBuild = 100,
                        posX = 2.25,
                        posY = -7
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Томатной 3.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 7,
                        PriceBuild = 100,
                        posX = -7,
                        posY = -3.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Томатной 3.3",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 7,
                        PriceBuild = 100,
                        posX = -7,
                        posY = 2
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Мандариновой 2.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 9,
                        PriceBuild = 100,
                        posX = 1.5,
                        posY = 7
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Мандариновой 2.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 9,
                        PriceBuild = 100,
                        posX = 7,
                        posY = 4
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Мандариновой 2.3",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 9,
                        PriceBuild = 100,
                        posX = 7,
                        posY = -1
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Мандариновой 2.4",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 9,
                        PriceBuild = 100,
                        posX = 7,
                        posY = -3.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Мандариновой 2.5",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 9,
                        PriceBuild = 100,
                        posX = 0,
                        posY = -4
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Мандариновой 2.6",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 9,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Мандариновой 2.7",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 9,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Мандариновой 3.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 10,
                        PriceBuild = 100,
                        posX = 4.2,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Мандариновой 3.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 10,
                        PriceBuild = 100,
                        posX = 0,
                        posY = -1
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Мандариновой 3.3",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 10,
                        PriceBuild = 100,
                        posX = -1.3,
                        posY = 1
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Мандариновой 3.4",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 10,
                        PriceBuild = 100,
                        posX = 0,
                        posY = 4
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Мандариновой 3.5",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 10,
                        PriceBuild = 100,
                        posX = 4,
                        posY = 3.35
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Мандариновой 3.6",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 10,
                        PriceBuild = 100,
                        posX = 2.25,
                        posY = -7
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Мандариновой 3.7",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 10,
                        PriceBuild = 100,
                        posX = -7,
                        posY = -3.5
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Мандариновой 4.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 11,
                        PriceBuild = 100,
                        posX = -7,
                        posY = 2
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Мандариновой 4.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 11,
                        PriceBuild = 100,
                        posX = 1.5,
                        posY = 7
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Мандариновой 4.3",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 11,
                        PriceBuild = 100,
                        posX = 7,
                        posY = 4
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Морской 1.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 12,
                        PriceBuild = 100,
                        posX = 7,
                        posY = -1
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Морской 1.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 12,
                        PriceBuild = 100,
                        posX = 7,
                        posY = -3.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Морской 1.3",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 12,
                        PriceBuild = 100,
                        posX = 0,
                        posY = -4
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Морской 2.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 13,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Морской 2.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 13,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Морской 2.3",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 13,
                        PriceBuild = 100,
                        posX = 4.2,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Морской 2.4",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 13,
                        PriceBuild = 100,
                        posX = 0,
                        posY = -1
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Морской 2.5",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 13,
                        PriceBuild = 100,
                        posX = -1.3,
                        posY = 1
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Морской 2.6",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 13,
                        PriceBuild = 100,
                        posX = 0,
                        posY = 4
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Морской 2.7",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 13,
                        PriceBuild = 100,
                        posX = 4,
                        posY = 3.35
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Морской 3.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 14,
                        PriceBuild = 100,
                        posX = 2.25,
                        posY = -7
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Морской 3.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 14,
                        PriceBuild = 100,
                        posX = -7,
                        posY = -3.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Морской 3.3",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 14,
                        PriceBuild = 100,
                        posX = -7,
                        posY = 2
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Морской 3.4",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 14,
                        PriceBuild = 100,
                        posX = 1.5,
                        posY = 7
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Морской 3.5",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 14,
                        PriceBuild = 100,
                        posX = 7,
                        posY = 4
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Морской 3.6",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 14,
                        PriceBuild = 100,
                        posX = 7,
                        posY = -1
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Морской 3.7",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 14,
                        PriceBuild = 100,
                        posX = 7,
                        posY = -3.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Морской 3.8",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 14,
                        PriceBuild = 100,
                        posX = 0,
                        posY = -4
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Коммунальной 1.1",
                        AboutBuild = "Электростанция",
                        Enabled = false,
                        IdStreetPath = 15,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Коммунальной 1.2",
                        AboutBuild = "Гидростанция",
                        Enabled = false,
                        IdStreetPath = 15,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Коммунальной 1.3",
                        AboutBuild = "Очистительная станция",
                        Enabled = false,
                        IdStreetPath = 15,
                        PriceBuild = 100,
                        posX = 4.2,
                        posY = 0
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Морской 4.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 16,
                        PriceBuild = 100,
                        posX = 0,
                        posY = -1
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Морской 4.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 16,
                        PriceBuild = 100,
                        posX = -1.3,
                        posY = 1
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Морской 4.3",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 16,
                        PriceBuild = 100,
                        posX = 0,
                        posY = 4
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Баклажановой 1.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 19,
                        PriceBuild = 100,
                        posX = 4,
                        posY = 3.35
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Баклажановой 1.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 19,
                        PriceBuild = 100,
                        posX = 2.25,
                        posY = -7
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Баклажановой 2.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 20,
                        PriceBuild = 100,
                        posX = -7,
                        posY = -3.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Баклажановой 2.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 20,
                        PriceBuild = 100,
                        posX = -7,
                        posY = 2
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Баклажановой 3.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 21,
                        PriceBuild = 100,
                        posX = 1.5,
                        posY = 7
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Баклажановой 3.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 21,
                        PriceBuild = 100,
                        posX = 7,
                        posY = 4
                    },

                    new Builds
                    {
                        NameBuild = "Дом на БэтУлице 1.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 22,
                        PriceBuild = 100,
                        posX = 7,
                        posY = -1
                    },
                    new Builds
                    {
                        NameBuild = "Дом на БэтУлице 1.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 22,
                        PriceBuild = 100,
                        posX = 7,
                        posY = -3.5
                    },

                    new Builds
                    {
                        NameBuild = "Дом на БэтУлице 2.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 23,
                        PriceBuild = 100,
                        posX = 0,
                        posY = -4
                    },
                    new Builds
                    {
                        NameBuild = "Дом на БэтУлице 2.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 23,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },

                    new Builds
                    {
                        NameBuild = "Дом на БэтУлице 3.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 24,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на БэтУлице 3.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 24,
                        PriceBuild = 100,
                        posX = 4.2,
                        posY = 0
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Горной 1.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 25,
                        PriceBuild = 100,
                        posX = 0,
                        posY = -1
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Горной 1.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 25,
                        PriceBuild = 100,
                        posX = -1.3,
                        posY = 1
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Горной 2.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 26,
                        PriceBuild = 100,
                        posX = 0,
                        posY = 4
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Горной 2.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 26,
                        PriceBuild = 100,
                        posX = 4,
                        posY = 3.35
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Коммунальной 2.1",
                        AboutBuild = "Электростанция",
                        Enabled = false,
                        IdStreetPath = 27,
                        PriceBuild = 100,
                        posX = 2.25,
                        posY = -7
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Коммунальной 2.2",
                        AboutBuild = "Станция переработки мусора",
                        Enabled = false,
                        IdStreetPath = 27,
                        PriceBuild = 100,
                        posX = -7,
                        posY = -3.5
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Орной 1.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 28,
                        PriceBuild = 100,
                        posX = -7,
                        posY = 2
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Орной 1.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 28,
                        PriceBuild = 100,
                        posX = 1.5,
                        posY = 7
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Орной 2.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 29,
                        PriceBuild = 100,
                        posX = 7,
                        posY = 4
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Орной 2.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 29,
                        PriceBuild = 100,
                        posX = 7,
                        posY = -1
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Угандовой 1.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 30,
                        PriceBuild = 100,
                        posX = 7,
                        posY = -3.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Угандовой 1.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 30,
                        PriceBuild = 100,
                        posX = 0,
                        posY = -4
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Угандовой 2.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 31,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Угандовой 2.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 31,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Угандовой 3.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 32,
                        PriceBuild = 100,
                        posX = 4,
                        posY = 3.35
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Угандовой 3.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 32,
                        PriceBuild = 100,
                        posX = 2.25,
                        posY = -7
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Угандовой 3.3",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 32,
                        PriceBuild = 100,
                        posX = -7,
                        posY = -3.5
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Вакандовой 1.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 33,
                        PriceBuild = 100,
                        posX = -7,
                        posY = 2
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Вакандовой 1.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 33,
                        PriceBuild = 100,
                        posX = 1.5,
                        posY = 7
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Вакандовой 2.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 34,
                        PriceBuild = 100,
                        posX = 7,
                        posY = 4
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Вакандовой 2.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 34,
                        PriceBuild = 100,
                        posX = 7,
                        posY = -1
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Вакандовой 2.3",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 34,
                        PriceBuild = 100,
                        posX = 7,
                        posY = -3.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Вакандовой 2.4",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 34,
                        PriceBuild = 100,
                        posX = 0,
                        posY = -4
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Вакандовой 2.5",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 34,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Вакандовой 2.6",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 34,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Угольной 1.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 35,
                        PriceBuild = 100,
                        posX = 7,
                        posY = 4
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Угольной 1.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 35,
                        PriceBuild = 100,
                        posX = 7,
                        posY = -1
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Угольной 1.3",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 35,
                        PriceBuild = 100,
                        posX = 7,
                        posY = -3.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Угольной 1.4",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 35,
                        PriceBuild = 100,
                        posX = 0,
                        posY = -4
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Угольной 1.5",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 35,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Угольной 1.6",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 35,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Угольной 1.7",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 35,
                        PriceBuild = 100,
                        posX = 7,
                        posY = 4
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Угольной 1.8",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 35,
                        PriceBuild = 100,
                        posX = 7,
                        posY = -1
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Угольной 2.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 36,
                        PriceBuild = 100,
                        posX = 7,
                        posY = -3.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Угольной 2.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 36,
                        PriceBuild = 100,
                        posX = 0,
                        posY = -4
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Виноградной 1.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 37,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Виноградной 1.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 37,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Виноградной 1.3",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 37,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Виноградной 1.4",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 37,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Виноградной 1.5",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 37,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Виноградной 1.6",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 37,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Виноградной 1.7",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 37,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Виноградной 1.8",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 37,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Виноградной 2.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 38,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Виноградной 2.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 38,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Виноградной 3.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 39,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Виноградной 3.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 39,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Транспортной 2.1",
                        AboutBuild = "Автобусное депо",
                        Enabled = false,
                        IdStreetPath = 40,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Транспортной 2.2",
                        AboutBuild = "Автобусное депо",
                        Enabled = false,
                        IdStreetPath = 40,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Транспортной 2.3",
                        AboutBuild = "Таксопарк",
                        Enabled = false,
                        IdStreetPath = 40,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Транспортной 2.4",
                        AboutBuild = "Таксопарк",
                        Enabled = false,
                        IdStreetPath = 40,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Транспортной 2.5",
                        AboutBuild = "Станция метро",
                        Enabled = false,
                        IdStreetPath = 40,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Транспортной 2.6",
                        AboutBuild = "Прокат велосипедов",
                        Enabled = false,
                        IdStreetPath = 40,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },

                    new Builds
                    {
                        NameBuild = "Дом на ТМовской 2.1",
                        AboutBuild = "Дом Юхмана",
                        Enabled = false,
                        IdStreetPath = 42,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на ТМовской 2.2",
                        AboutBuild = "Дом Кем",
                        Enabled = false,
                        IdStreetPath = 42,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },

                    new Builds
                    {
                        NameBuild = "Дом на ТМовской 3.1",
                        AboutBuild = "Дом Дехан",
                        Enabled = false,
                        IdStreetPath = 43,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на ТМовской 3.2",
                        AboutBuild = "Дом Бертон",
                        Enabled = false,
                        IdStreetPath = 43,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на ТМовской 3.3",
                        AboutBuild = "Дом Леры",
                        Enabled = false,
                        IdStreetPath = 43,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },

                    new Builds
                    {
                        NameBuild = "Дом на ТМовской 4.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 44,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на ТМовской 4.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 44,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на ТМовской 4.3",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 44,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Единороговой 1.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 45,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Единороговой 1.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 45,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Единороговой 1.3",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 45,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Единороговой 1.4",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 45,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Единороговой 1.5",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 45,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Единороговой 1.6",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 45,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Единороговой 2.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 46,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "ом на Единороговой 2.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 46,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Единороговой 3.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 47,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Единороговой 3.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 47,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Транспортной 3.1",
                        AboutBuild = "Станция метро",
                        Enabled = false,
                        IdStreetPath = 48,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Транспортной 3.2",
                        AboutBuild = "Прокат велосипедов",
                        Enabled = false,
                        IdStreetPath = 48,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Седановой 1.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 49,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Седановой 1.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 49,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Седановой 1.3",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 49,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Седановой 1.4",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 49,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Седановой 1.5",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 49,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Седановой 1.6",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 49,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Седановой 2.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 50,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Седановой 2.2",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 50,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Седановой 2.3",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 50,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },

                    new Builds
                    {
                        NameBuild = "Дом на Седановой 3.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 51,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 0
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Седановой 3.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 51,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    },
                    new Builds
                    {
                        NameBuild = "Дом на Седановой 3.1",
                        AboutBuild = "Жилой дом",
                        Enabled = false,
                        IdStreetPath = 51,
                        PriceBuild = 100,
                        posX = -4,
                        posY = 4.5
                    }
                };
                break;
        }

        return buildses;
    }

    public static Events[] GetEvents(City name)
    {
        Events[] eventses = new Events[1];
        switch (name)
        {
            case City.Testbase:
                eventses = new[]
                {
                    new Events {IdGovermentPath = 2, Info = "", NameEvent = "Surprize :/", Price = 20},
                    new Events {IdGovermentPath = 5, Info = "", NameEvent = "Surprize :3", Price = 20},
                    new Events {IdGovermentPath = 14, Info = "", NameEvent = "You're catched bad gay", Price = -20},
                    new Events {IdGovermentPath = 14, Info = "", NameEvent = "Surprize :)", Price = 20},
                    new Events {IdGovermentPath = 18, Info = "", NameEvent = "Surprize :0", Price = 20}
                };
                break;
            case City.Tron:
                eventses = new[]
                {
                    new Events
                    {
                        IdGovermentPath = 8,
                        Info = "Поздравляем! Вы выиграли в лотерею!",
                        NameEvent = "Лотерея",
                        Price = 100
                    }, //парк
                    new Events
                    {
                        IdGovermentPath = 8,
                        Info = "О нет! Вас обокрали!",
                        NameEvent = "Воришки!",
                        Price = -50
                    }, //парк
                    new Events
                    {
                        IdGovermentPath = 8,
                        Info = "Нужно закупить оборудование!",
                        NameEvent = "Субботник",
                        Price = -50
                    }, //парк
                    new Events
                    {
                        IdGovermentPath = 17,
                        Info = "Поздравляем! Вы выиграли в конкурсе!",
                        NameEvent = "Праздник в городе!",
                        Price = 70
                    }, //парк
                    new Events
                    {
                        IdGovermentPath = 17,
                        Info = "Вы посетили благотворительную ярмарку!",
                        NameEvent = "Благотворительная ярмарка!",
                        Price = -20
                    }, //парк
                    new Events
                    {
                        IdGovermentPath = 17,
                        Info = "Нужно закупить оборудование!",
                        NameEvent = "Субботник",
                        Price = -20
                    }, //парк
                    new Events
                    {
                        IdGovermentPath = 18,
                        Info = "Вы заключены под стражу!",
                        NameEvent = "Арест!",
                        Price = -100
                    }, //суд
                    new Events
                    {
                        IdGovermentPath = 18,
                        Info = "Ошибка в налоговой привела к увеличению вашего капитала",
                        NameEvent = "Ошибка в налоговой!",
                        Price = 50
                    }, //суд
                    new Events
                    {
                        IdGovermentPath = 18,
                        Info = "Ошибка в налоговой привела к уменьшению вашего капитала",
                        NameEvent = "Ошибка в налоговой!",
                        Price = -50
                    }, //суд
                    new Events
                    {
                        IdGovermentPath = 41,
                        Info = "Фортуна на вашей стороне! Вы выиграли крупную сумму денег!",
                        NameEvent = "Крупный Выигрыш!",
                        Price = 200
                    }, //казино
                    new Events
                    {
                        IdGovermentPath = 41,
                        Info = "Фортуна на вашей стороне! Вы выиграли небольшую сумму денег!",
                        NameEvent = "Выигрыш!",
                        Price = 50
                    }, //казино
                    new Events
                    {
                        IdGovermentPath = 41,
                        Info = "О нет! Вам не повезло и Вы проиграли большую сумму денег!",
                        NameEvent = "Проигрыш",
                        Price = -125
                    } //казино
                };
                break;
        }

        return eventses;
    }
}