﻿
using System.Text;

namespace Lab7
{
    /// <summary>
    /// Storehouse — класс для управления запасными частями в складе.
    /// </summary>
    public class Storehouse
    {

        List<PartsWarehouse> warehouseList = new List<PartsWarehouse>();


        /// <summary>
        /// Добавление новой запчасти в List.
        /// </summary>
        /// <param name="newPart">Новая деталь которую необходимо добавить, проверяется есть ли уже данный объект в List через проверку Id.</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void AddParts(PartsWarehouse newPart)
        {
            if (newPart is not null)
            {
                foreach (PartsWarehouse part in warehouseList)
                {
                    if (part.Id.Equals(newPart.Id))
                    {
                        throw new ArgumentOutOfRangeException("This part is already in Storage!");
                    }
                }
                warehouseList.Add(newPart);
            }
            else
            {
                Console.WriteLine(newPart);
                throw new ArgumentOutOfRangeException("This part is already in Storage!");
            }
        }

        /// <summary>
        /// Удаление запчасти из List.
        /// </summary>
        /// <param name="partToRemove">Деталь которую необходимо удалить.</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void RemovePart(PartsWarehouse partToRemove)
        {
            if (partToRemove is not null && warehouseList.Contains(partToRemove))
            {
                warehouseList.Remove(partToRemove);
            }
            else
            {
                throw new ArgumentOutOfRangeException("This part does not exist!");
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            foreach (PartsWarehouse part in warehouseList)
            {
                str.Append(part + "\n");
            }
            return str.ToString();
        }
    }
}
