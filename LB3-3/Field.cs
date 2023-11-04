using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB3_3
{
    internal class Field
    {
        private List<Cell> field;

        public int? size { get; }

        private static Field instance;

        private Field(int? size) {
            field = new List<Cell>();
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++){
                    Cell cell = new Cell(i, j);
                    field.Add(cell);
                }
                this.size = size;
            }
        }

        public static Field getInstance(int? size) {
            //if (size == null || size < 1) { throw; }   сделать проверку
            if (instance == null) { 
                instance = new Field(size);
            }
            return instance;
        }

        public void FieldOut() {
            int count = 0;

            foreach (Cell cell in field){

                Console.Write(cell.ToString());
                count++;

                if (count % size == 0) {
                Console.WriteLine();
                }
            }
        }
    }
}
