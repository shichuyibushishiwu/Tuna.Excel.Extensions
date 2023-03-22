///************************************************************************************
///   Author:十五
///   CretaeTime:2023/3/22 21:47:13
///   Mail:1012201478@qq.com
///   Github:https://github.com/shichuyibushishiwu
///
///   Description:
///
///************************************************************************************

using System;
using System.Collections.Generic;
using System.Text;

namespace Tuna.Excel.Extensions
{
    public class Row
    {
        public Row()
        {
            Cells = new CellCollection();
        }


        public CellCollection Cells { get; set; }

        public Cell this[int column]
        {
            get
            {
                return new Cell();
            }
        }
    }
}
