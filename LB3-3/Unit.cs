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

        //public void Move(ICellable.Direction direction) {
        //    if (distance > 0) { 
                
        //    }
        //}

        protected int distance;//выше

        private Faction faction;

        private int initiative;//реализовать инициативу
        abstract public void Death();//реализовать смерть
        public abstract string GetSign();

        private List<IAbilitiy> abilitiys;//сделать способности

        //сделать врагов и союзников
        enum Faction {
            SpaceMarines,
            //Tyranids,
            Necrons,
            Orks
        }

        //фабрика для препятствий
        //сделать комманду из юнитов игрока

        //сделать фабрику или абстрактную фабрику для создания юнитов
    }
}
