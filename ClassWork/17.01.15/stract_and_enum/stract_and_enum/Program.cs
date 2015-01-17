using System;
using System.Collections.Generic;

namespace EnumerationsAndStructures
{

    enum Discount // виды скидок
    {
        Default = 0, Incentive = 2, Patron = 5, VIP = 15
    }

    enum CommodityType // типы товаров
    {
        FrozenFood, Food, DomesticChemistry, BuildingMaterials
    }

    struct Dimensions // габариты
    {
        public double Length;
        public double Width;
    }

    struct ConsignmentItem // элемент заказа
    {
        public String Name;             // Наименование
        public Decimal Weigth;          // Вес
        public Decimal Price;           // Заявленная стоимость
        public Dimensions Dimensions;   // Размеры
        public CommodityType Type;      // Тип товара
    }

    struct Consignment // заказ
    {
        public Decimal TotalWeigth;
        public Decimal TotalPrice;
        public List<ConsignmentItem> Commodities;
    }

    enum TransportType
    {
        Semitrailer, Coupling, Refrigerator, OpenSideTruck, Tank
    }

    struct Transport
    {
        public String Name;                         // Название
        public Decimal Capacity;                    // Вместимость
        public TransportType Type;                  // Тип
        public List<ConsignmentItem> Commodities;   // Перечень товаров
    }

    enum DistanceSun : ulong
    {
        Sun = 0,
        Mercury = 57900000,
        Venus = 108200000,
        Earth = 149600000,
        Mars = 227900000,
        Jupiter = 7783000000,
        Saturn = 1427000000,
        Uranus = 2870000000,
        Neptune = 4496000000,
        Pluto = 5946000000
    }

    class EnumSwitchExample
    {
        Transport Refrigerator = new Transport();
        Transport Semitrailer = new Transport();
        Transport Coupling = new Transport();
        Transport OpenSideTruck = new Transport();

        public void SetTransport(ConsignmentItem item)
        {
            switch (item.Type)
            {
                case CommodityType.FrozenFood:
                    Refrigerator.Commodities.Add(item);
                    break;
                case CommodityType.Food:
                    Semitrailer.Commodities.Add(item);
                    break;
                case CommodityType.DomesticChemistry:
                    Coupling.Commodities.Add(item);
                    break;
                case CommodityType.BuildingMaterials:
                    OpenSideTruck.Commodities.Add(item);
                    break;
                default:
                    Semitrailer.Commodities.Add(item);
                    break;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {


        }
    }

}