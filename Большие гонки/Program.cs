using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Большие_гонки
{
    enum Team_Name
    {
        Головорезы,
        Гении,
        Гильдия_бабушек,
        Разъярённые_кошки
    }

    enum Country
    {
        Россия,
        Китай,
        Казахстан,
        Франция
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Team Russia = new Team(Team_Name.Головорезы);
            Team France = new Team(Team_Name.Гильдия_бабушек);
            Team China = new Team(Team_Name.Гении);
            Team Kazakhstan = new Team(Team_Name.Разъярённые_кошки);
        }
    }
}
