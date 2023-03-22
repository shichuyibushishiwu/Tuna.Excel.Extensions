///************************************************************************************
///   Author:十五
///   CretaeTime:2023/3/22 21:47:59
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
    public class Cell
    {
        public Cell()
        {

        }

        public CellStyle? CellStyle { get; set; }

        public object? Value { get; set; }

        public override string ToString()
        {
            return "";
        }
    }
}
