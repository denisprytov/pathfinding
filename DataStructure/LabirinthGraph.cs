using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFindingApp.DataStructure
{
    //class LabirinthGraph
    //{
    //    private int? _size;
    //    private int? _finishX;
    //    private int? _finishY;

    //    public List<LabirintVertex> Vertices { get; }

    //    private int FinishX
    //    {
    //        get
    //        {
    //            if (_finishX == null)
    //            {
    //                _finishX = GetX(Finish);
    //            }
    //            return _finishX.Value;
    //        }
    //    }

    //    private int FinishY
    //    {
    //        get
    //        {
    //            if (_finishY == null)
    //            {
    //                _finishY = GetY(Finish);
    //            }
    //            return _finishY.Value;
    //        }
    //    }

    //    public int Size
    //    {
    //        get
    //        {
    //            if (_size == null)
    //            {
    //                _size = (int)Math.Sqrt(Vertices.Count);
    //            }
    //            return _size.Value;
    //        }
    //    }

    //    public LabirintVertex Start { get; }

    //    public LabirintVertex Finish { get; }

    //    public int GetX(LabirintVertex v)
    //    {
    //        return Vertices.IndexOf(v) % Size;
    //    }

    //    public int GetY(LabirintVertex v)
    //    {
    //        return Vertices.IndexOf(v) / Size;
    //    }

    //    public int ManhattanToFinish(LabirintVertex v)
    //    {
    //        int tmp = Math.Abs(GetX(v) - FinishX) + Math.Abs(GetY(v) - FinishY);
    //        return tmp;
    //    }

    //    public LabirintVertex this[int i] => Vertices[i];

    //    public LabirinthGraph(IEnumerable<LabirintVertex> vertices)
    //    {
    //        Vertices = vertices.ToList();
    //        try
    //        {
    //            Start = Vertices.First(v => v.NodeType == CellTypes.Start); //находим первый элемент с типом старт
    //            Finish = Vertices.First(v => v.NodeType == CellTypes.Finish);
    //        }
    //        catch (Exception e)
    //        {
    //            var msg = e.Message;
    //        }
    //    }
    //}
    class LabirintGraph
    {

        #region Поля

        private int? _size;
        private int? _finishX;
        private int? _finishY;
        #endregion

        #region Свойства

        /// <summary>
        /// Набор ячеек лабиринта
        /// </summary>
        public List<LabirintVertex> Vertices { get; }

        /// <summary>
        /// Координата X финиша
        /// </summary>
        private int FinishX
        {
            get
            {
                if (_finishX == null) _finishX = GetX(Finish);
                return _finishX.Value;
            }

        }

        /// <summary>
        /// Координата Y финиша
        /// </summary>
        private int FinishY
        {
            get
            {
                if (_finishY == null) _finishY = GetY(Finish);
                return _finishY.Value;
            }

        }

        public int Size
        {
            get
            {
                //Ленивая инициализация
                if (_size == null) _size = (int)Math.Sqrt(Vertices.Count);
                return _size.Value;
            }
        }

        /// <summary>
        /// Стартовый элемент лабиринта
        /// </summary>
        public LabirintVertex Start { get; }

        /// <summary>
        /// Финишный элемент лабиринте
        /// </summary>
        public LabirintVertex Finish { get; }
        #endregion

        #region Методы

        public int GetX(LabirintVertex v)
        {
            return Vertices.IndexOf(v) % Size;
        }

        public int GetY(LabirintVertex v)
        {
            return Vertices.IndexOf(v) / Size;
        }

        public int ManhattanToFinish(LabirintVertex v)
        {
            return Math.Abs(GetX(v) - FinishX) + Math.Abs(GetY(v) - FinishY);
        }

        #endregion

        /// <summary>
        /// Индексатор ячеек лабиринта
        /// </summary>
        /// <param name="i">индекс</param>
        /// <returns></returns>
        public LabirintVertex this[int i] => Vertices[i];

        public LabirintGraph(IEnumerable<LabirintVertex> vertices)
        {
            Vertices = vertices.ToList();
            try
            {
                Start = Vertices.First(v =>
                    v.NodeType == CellTypes.Start); //находим первый элемент с типом старт, отмечаем его для доступа
                Finish = Vertices.First(v => v.NodeType == CellTypes.Finish); //аналогично финиш
            }

            catch (Exception e)
            {
                var msg = e.Message;
            }
        }
    }
}
