using System;

public class Class1
{
    public Class1()
    {
    }
        public struct item
    {
        public string name;
        public string date;
        public double massa;
        public double price;
        public string provider;
        public int lifeDays;

        public void print()
        {
            Console.WriteLine("Название: {0} \nДата поступления: {1} \nМасса: {2}" +
                "\nЦена: {3} \nПоставщик: {4}\nСрок годности(дней): {5} \n\n", name, date, massa, price, provider, lifeDays);
        }
        public item(string n, string d, double m, double p, string prov, int l)
        {
            name = n; date = d; massa = m; price = p; provider = prov; lifeDays = l;
        }
    }

    public static void structureTask()
    {
        item[] items = new item[3];
        items[0].name = "item 1";
        items[1].name = "item 2";
        items[0].date = "01-02-2018";
        items[1].date = "21-01-2014";
        items[0].massa = 1;
        items[1].massa = 0.3;
        items[0].price = 33;
        items[1].price = 15.70;
        items[0].provider = "provider 1";
        items[1].provider = "provider 2";
        items[0].lifeDays = 77;
        items[1].lifeDays = 30;

        items[2] = new item("item 3", "01-06-2016", 5.5, 900, "provider 3", 21);

        int i = 0;
        do {
            items[i].print(); i++;
        } while (i < 3);
    }
}