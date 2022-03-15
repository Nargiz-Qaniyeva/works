using System;
using System.Collections.Generic;
using System.Text;

namespace work.Models
{
    class Book:Product
    {
        public string Genre;

        public Book(string Genre,int No, string Name, int Price): base(No,Name,Price)
        {
            this.Genre = Genre;
        }
        public string GetInfo()
        {
            return $"Kitab No: {No} - Adi: {Name} - Qiymeti: {Price} - Janri: {Genre}\nNo: {No} - Name: {Name} - Price: {Price}";
        }
    }
}
