using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InputValidation;

namespace SemesterProjekt2021
{
    class PriceSetter
    {

        public static Result AproximateBoligPris(Bolig b, ref int recommendedPrice)
        {
            Result r = new Result();

            Bolig[] bs = new Bolig[1];
            DatabaseAccessor.ReadAllBolig(ref bs);
            List<int> priceList = new List<int>();

            for (int p = 0; p < 3; p++)
            {
                List<(int x, int y)> tupleList = new List<(int x, int y)>();
                for (int i = 0; i < bs.Length; i++)
                {
                    if (bs[i].IsSold)
                    {
                        int x = 0;
                        int y = 0;
                        switch (p)
                        {
                            case 0:
                                x = bs[i].InArea;
                                y = bs[i].SellingPrice;
                                break;
                            case 1:
                                x = bs[i].OutArea;
                                y = bs[i].SellingPrice;
                                break;
                            case 2:
                                x = bs[i].Rooms;
                                y = bs[i].SellingPrice;
                                break;
                        }
                        tupleList.Add((x, y));
                    }
                }
                switch (p)
                {
                    case 0:
                        priceList.Add(FindMedianOverList(b.InArea, tupleList.ToArray()));

                        break;
                    case 1:
                        priceList.Add(FindMedianOverList(b.OutArea, tupleList.ToArray()));

                        break;
                    case 2:
                        priceList.Add(FindMedianOverList(b.Rooms, tupleList.ToArray()));

                        break;
                }
            }
            int sum = 0;
            for (int i = 0; i < priceList.Count; i++)
            {
                sum += priceList[i];
            }
            sum /= priceList.Count;

            recommendedPrice = sum;

            return r;
        }

        private static int FindMedianOverList(int input,(int x,int y)[] list  )
        {
            int recommendedPrice = 0;

            int xMean = 0;
            int yMean = 0;
            
            for (int i = 0; i < list.Length; i++)
            {
                xMean += list[i].x;
                yMean += list[i].y;
            }

            xMean /= list.Length;
            yMean /= list.Length;

            int a = yMean / xMean;

            recommendedPrice = a * input;

            return recommendedPrice;
        }
    }
}
