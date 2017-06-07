using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pracuj.ath.bielsko.pl.ViewModels
{
    public class OffertViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PostedDate { get; set; }
        public string Location { get; set; }
        public string Company { get; set; }
        public string Img { get; set; }
        public string ContractType { get; set; }
        public string JobCategory { get; set; }
    }
    public class ModelsForOfferts
    {
        public PagedList.IPagedList<OffertViewModel> PagedOffert { get; set; }
        public RegisterViewModel searchBar { get; set; }
    }
}