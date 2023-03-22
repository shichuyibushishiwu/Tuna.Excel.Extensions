///************************************************************************************
///   Author:十五
///   CretaeTime:2023/3/22 21:46:09
///   Mail:1012201478@qq.com
///   Github:https://github.com/shichuyibushishiwu
///
///   Description:
///
///************************************************************************************

using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tuna.Excel.Extensions
{
    public class Document : IDisposable
    {
        private NPOI.SS.UserModel.IWorkbook? _workbook;
        private FileStream? _fileStream;
        private string? _path;

        public Document(string path) : this()
        {
            _path = path;
        }

        public Document()
        {
            Sheets = new SheetCollection();
        }

        public SheetCollection Sheets { get; set; }

        public void Dispose()
        {
            this.Save();

            _fileStream?.Close();
            _fileStream?.Dispose();
            _workbook?.Close();
        }

        private void Save()
        {
            if (File.Exists(_path))
            {

            }
            _fileStream = new FileStream(_path, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            _workbook = new XSSFWorkbook();
            _workbook.CreateSheet();
            _workbook.Write(_fileStream, false);
        }
    }
}
