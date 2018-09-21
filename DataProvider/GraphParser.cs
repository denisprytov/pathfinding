using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PathFindingApp.DataStructure;

namespace PathFindingApp.DataProvider
{
    static class GraphParser
    {
        public static LabirintGraph ParseGraph(string[] data)
        {
            //    //проецируем все числа в вершины и собираем из этого список вершин 
            //    var list = (from str in data from word in str select (int)Char.GetNumericValue(word) into num select new LabirintVertex((CellTypes)num)).ToList();
            //    for (int i = 0; i < list.Count; i++)
            //    {
            //        if (list[i].NodeType == CellTypes.Block)
            //        {
            //            continue;
            //        }
            //        if (i > data.Length && list[i - data.Length].NodeType != CellTypes.Block) //не первая строчка и не блок сверху
            //        {
            //            list[i].Neighbours.Add(list[i - data.Length]);
            //            list[i - data.Length].Neighbours.Add(list[i]);
            //        }
            //        if (i % data.Length == 0 || list[i - 1].NodeType == CellTypes.Block)
            //        {
            //            continue;
            //        }
            //        list[i].Neighbours.Add(list[i - 1]); //если не стенка слева или слева не блок
            //        list[i - 1].Neighbours.Add(list[i]);
            //    }
            //    return new LabirinthGraph(list);
            //}

            //public static TableLayoutPanel ParsePanel(string[] data, TableLayoutPanel panel)
            //{
            //    for (var i = 0; i < data.Length; i++)
            //    for (var j = 0; j < data[i].Length; j++)
            //    {
            //        //находим соответствующую панель
            //        var cell = (PanelControl)panel.Controls[data[i].Length * i + j];
            //        //достаем из строки число
            //        var num = (int)Char.GetNumericValue(data[i][j]);
            //        //заполняем панель
            //        cell.Tag = (CellTypes)num;
            //        cell.BackColor = Colors[num];

            //        }
            //    return panel;
            //}

            var list = (from t in data
                from t1 in t
                select (int) Char.GetNumericValue(t1)
                into num
                select new LabirintVertex((CellTypes) num)).ToList();
            for (var i = 0; i < list.Count; i++)
            {
                if (list[i].NodeType == CellTypes.Block) continue;
                //если не верхняя строка и сосед сверху - не стенка, то добавляем в соседи друг друга
                if (i >= data.Length && list[i - data.Length].NodeType != CellTypes.Block)
                {
                    list[i].Neighbours.Add(list[i - data.Length]);
                    list[i - data.Length].Neighbours.Add(list[i]);
                }

                //если не левая граница и сосед слева не стена, то добавляем в соседи друг друга
                if (i % data.Length == 0 || list[i - 1].NodeType == CellTypes.Block) continue;
                list[i].Neighbours.Add(list[i - 1]);
                list[i - 1].Neighbours.Add(list[i]);
            }

            return new LabirintGraph(list);
        }

        /// <summary>
        /// Парсим данные для заполнения таблицы из файла
        /// </summary>
        /// <param name="data">Исходные данные</param>
        /// <param name="panel">Панель в которую будем выводить</param>
        /// <returns>Фиктивный возврат панели</returns>
        public static TableLayoutPanel ParsePanel(string[] data, TableLayoutPanel panel)
        {
            for (var i = 0; i < data.Length; i++)
            for (var j = 0; j < data[i].Length; j++)
            {
                //находим соответствующую панель
                var cell = (PanelControl) panel.Controls[data[i].Length * i + j];
                //достаем из строки число
                var num = (int) Char.GetNumericValue(data[i][j]);
                //заполняем панель
                cell.Tag = (CellTypes) num;
                cell.BackColor = Colors[num];
            }

            return panel;
        }



        public static readonly System.Drawing.Color[] Colors =
        {
            System.Drawing.Color.White, System.Drawing.Color.DarkRed,
            System.Drawing.Color.ForestGreen, System.Drawing.Color.BlueViolet, System.Drawing.Color.LightSkyBlue,
            System.Drawing.Color.Aquamarine
        };
    }
}
