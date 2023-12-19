using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    internal class Book_123456789 : Product_123456789
    {
        protected string pageCount;

        public Book_123456789(string type, string title, string pagecount) : base(type, title)
        {
            this.pageCount = pagecount;
        }
        public string PageCount
        {
            get
            {
                return pageCount;
            }

            set
            {
                pageCount = value;
            }
        }
    }
}
