using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3_3
{
    abstract class Unit : ICellable
    {
        public int Health { get; protected set; }
        public int Armor { get; protected set; }
        abstract public void Move();//реализовать движение по полю

        protected int distance;//выше

        private Fraction fraction;

        private int initiative;//реализовать инициативу
        abstract public void Death();//реализовать смерть
        public abstract string GetSign();

        private List<IAbilitiy> abilitiys;//сделать способности

        //сделать врагов и союзников
        enum Fraction {
        // сделать фракции
        }

        //сделать комманду из юнитов игрока

        //сделать фабрику или абстрактную фабрику для создания юнитов
    }
}
