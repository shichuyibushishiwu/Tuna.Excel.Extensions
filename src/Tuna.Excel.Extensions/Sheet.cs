///************************************************************************************
///   Author:十五
///   CretaeTime:2023/3/22 21:58:03
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
    public class Sheet
    {
        public Sheet()
        {

        }

        public Row this[int row]
        {
            get
            {
                return new Row();
            }
        }

        public Cell this[int row, int column]
        {
            get
            {
                return new Cell();
            }
        }


        public string Name { get; set; } = string.Empty;
    }
}
