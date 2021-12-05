using System;

namespace ConsoleApp2_OOP_C4
{
    class Program
    {
        //поля
        private int BuildingCount;
        private int StoreysCount;
        private int apartments;
        private int entrances;


        static void Main(string[] args)
        {
            new Building(1);
            new Storeys(9);
            new apartments(216);
            new Entrances(6);
        }
        //свойства
        public int Building //номер здания
        {
            get
            {
                return BuildingCount;
            }
            set
            {
                BuildingCount = value;
            }
        }
            public int Storeys //этажи
        {
            get
            {
                return StoreysCount;
            }
            set
            {
                StoreysCount = value;
            }
        }
        public int Apartments //количество квартир
        {
            get
            {
                return apartments;
            }
            set
            {
                apartments = value;
            }
        }
        public int Entrances // количество подъездов
        {
            get
            {
                return entrances;
            }
            set
            {
                entrances = value;
            }
        }

        private class Building
        {
            private int v;

            public Building(int v)
            {
                this.v = v;
            }
        }

        private class Storeys
        {
            private int v;

            public Storeys(int v)
            {
                this.v = v;
            }
        }

        private class apartments
        {
            private int v;

            public apartments(int v)
            {
                this.v = v;
            }
            //Конструкторы
            public House(int BuildingCount, int StoreysCount, int apartments, int entrances)
            {
                this.BuildingCount = BuildingCount;
                this.StoreysCount = StoreysCount;
                this.apartments = apartments;
                this.entrances = entrances;
            }
        }
    }
}

