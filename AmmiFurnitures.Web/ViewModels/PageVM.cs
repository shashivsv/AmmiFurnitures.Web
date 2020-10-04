using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmmiFurnitures.Web.ViewModels
{
    public class PageVM
    {
        public PageVM()
        {

        }
        public int PageId { get; set; }
        public string Title{ get; set; }
        public string Body{ get; set; }
        public int HasSideBar { get; set; }
    }
}