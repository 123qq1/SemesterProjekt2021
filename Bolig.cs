using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt2021
{
    class Bolig
    {


        public Bolig(int id, int realtorId, int sellerId, int buyerId, string type, string address, string city, int zip, int rooms, int inArea, int outArea, int built, bool active, bool isSold, string soldDate, string energyLable, int offerPrice, int sellingPrice)
        {
            Id = id;
            RealtorId = realtorId;
            SellerId = sellerId;
            BuyerId = buyerId;
            Type = type;
            Address = address;
            City = city;
            Zip = zip;
            Rooms = rooms;
            InArea = inArea;
            OutArea = outArea;
            Built = built;
            Active = active;
            IsSold = isSold;
            SoldDate = soldDate;
            EnergyLabels = energyLable;
            OfferPrice = offerPrice;
            SellingPrice = sellingPrice;
        }

        public Bolig()
        {

        }

        public int Id { get; set; }
        public int RealtorId { get; set; }
        public int SellerId { get; set; }
        public int BuyerId { get; set; }
        public string Type { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }
        public int Rooms { get; set; }
        public int InArea { get; set; }
        public int OutArea { get; set; }
        public int Built { get; set; }
        public bool Active { get; set; }
        public bool IsSold { get; set; }
        public string SoldDate { get; set; }
        public string EnergyLabels { get; set; }
        public int OfferPrice { get; set; }
        public int SellingPrice { get; set; }


    }
}
