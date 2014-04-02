using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace SpaceTrader
{
    public class Account
    {
        public int Balance { get; set; }

        public void Deposit(int p)
        {
            Balance += p;
        }

        public void MoneyOut(int p)
        {
            Balance -= p;
        }

        //gold
        public ArrayList GoldPriceList = new ArrayList();
        public ArrayList GoldAmountList = new ArrayList();
        public int evaGoldPrice { get; set; }
        public int curGoldAmount { get; set; }
        public void GetEvaGoldPrice()
        {
            int Toprice = 0;
            int Tamount = 0;
            for (int i = 0; i < GoldAmountList.Count; i++)
            {
                Toprice += (int)GoldAmountList[i] * (int)GoldPriceList[i];
                Tamount += (int)GoldAmountList[i];
            }
            evaGoldPrice = Toprice / Tamount;
            curGoldAmount = Tamount;
        }
        public void BuyGold(int p1, int p2)
        {
            if (Balance >= p1 * p2)
            {
                GoldPriceList.Add(p1);
                GoldAmountList.Add(p2);
                GetEvaGoldPrice();
                Balance -= p1 * p2;
            }
        }
        public void SellGold(int p1, int p2)
        {
            int currentAmount = 0;
            foreach (int i in GoldAmountList)
            {
                currentAmount += i;
            }
            if (currentAmount >= p2)
            {
                Balance += p1 * p2;
                while (p2 > 0)
                {
                    if ((int)GoldAmountList[GoldAmountList.Count - 1] > p2)
                    {
                        int b = (int)GoldAmountList[GoldAmountList.Count - 1];
                        GoldAmountList.RemoveAt(GoldAmountList.Count - 1);
                        GoldAmountList.Add(b - p2);
                        GetEvaGoldPrice();
                        p2 = 0;
                        break;
                    }
                    else
                    {
                        p2 -= (int)GoldAmountList[GoldAmountList.Count - 1];
                        GoldAmountList.RemoveAt(GoldAmountList.Count - 1);
                        GoldPriceList.RemoveAt(GoldPriceList.Count - 1);
                    }
                }
            }
        }

        //silver
        public ArrayList SilverPriceList = new ArrayList();
        public ArrayList SilverAmountList = new ArrayList();
        public int evaSilverPrice { get; set; }
        public int curSilverAmount { get; set; }
        public void GetEvaSilverPrice()
        {
            int Toprice = 0;
            int Tamount = 0;
            for (int i = 0; i < SilverAmountList.Count; i++)
            {
                Toprice += (int)SilverAmountList[i] * (int)SilverPriceList[i];
                Tamount += (int)SilverAmountList[i];
            }
            evaSilverPrice = Toprice / Tamount;
            curSilverAmount = Tamount;
        }
        public void BuySilver(int p1, int p2)
        {
            if (Balance >= p1 * p2)
            {
                SilverPriceList.Add(p1);
                SilverAmountList.Add(p2);
                Balance -= p1 * p2;
                GetEvaSilverPrice();
            }
        }
        public void SellSilver(int p1, int p2)
        {
            int currentAmount = 0;
            foreach (int i in SilverAmountList)
            {
                currentAmount += i;
            }
            if (currentAmount >= p2)
            {
                Balance += p1 * p2;
                while (p2 > 0)
                {
                    if ((int)SilverAmountList[SilverAmountList.Count - 1] > p2)
                    {
                        int b = (int)SilverAmountList[SilverAmountList.Count - 1];
                        SilverAmountList.RemoveAt(SilverAmountList.Count - 1);
                        SilverAmountList.Add(b - p2);
                        GetEvaSilverPrice();
                        p2 = 0;
                        break;
                    }
                    else
                    {
                        p2 -= (int)SilverAmountList[SilverAmountList.Count - 1];
                        SilverAmountList.RemoveAt(SilverAmountList.Count - 1);
                        SilverPriceList.RemoveAt(SilverPriceList.Count - 1);
                    }
                }
            }
        }

        //copper
        public ArrayList CopperPriceList = new ArrayList();
        public ArrayList CopperAmountList = new ArrayList();
        public int evaCopperPrice { get; set; }
        public int curCopperAmount { get; set; }
        public void GetEvaCopperPrice()
        {
            int Toprice = 0;
            int Tamount = 0;
            for (int i = 0; i < CopperAmountList.Count; i++)
            {
                Toprice += (int)CopperAmountList[i] * (int)CopperPriceList[i];
                Tamount += (int)CopperAmountList[i];
            }
            evaCopperPrice = Toprice / Tamount;
            curCopperAmount = Tamount;
        }
        public void BuyCopper(int p1, int p2)
        {
            if (Balance >= p1 * p2)
            {
                CopperPriceList.Add(p1);
                CopperAmountList.Add(p2);
                Balance -= p1 * p2;
                GetEvaCopperPrice();
            }
        }
        public void SellCopper(int p1, int p2)
        {
            int currentAmount = 0;
            foreach (int i in CopperAmountList)
            {
                currentAmount += i;
            }
            if (currentAmount >= p2)
            {
                Balance += p1 * p2;
                while (p2 > 0)
                {
                    if ((int)CopperAmountList[CopperAmountList.Count - 1] > p2)
                    {
                        int b = (int)CopperAmountList[CopperAmountList.Count - 1];
                        CopperAmountList.RemoveAt(CopperAmountList.Count - 1);
                        CopperAmountList.Add(b - p2);
                        GetEvaCopperPrice();
                        p2 = 0;
                        break;
                    }
                    else
                    {
                        p2 -= (int)CopperAmountList[CopperAmountList.Count - 1];
                        CopperAmountList.RemoveAt(CopperAmountList.Count - 1);
                        CopperPriceList.RemoveAt(CopperPriceList.Count - 1);
                    }
                }
            }
        }
    }
}
