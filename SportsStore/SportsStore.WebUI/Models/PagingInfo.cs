using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsStore.WebUI.Models
{
    public class PagingInfo
    {
        public int TotalItems { get; set; } // сколько всего элементов в БД
        public int ItemsPerPage { get; set; } // сколько элементо вдолжно быть на странице
        public int CurrentPage { get; set; } // текущая страница
        public int TotalPages// сколько всего будет сtраниц во View
        {
            get { return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage); }
        }
    }

}