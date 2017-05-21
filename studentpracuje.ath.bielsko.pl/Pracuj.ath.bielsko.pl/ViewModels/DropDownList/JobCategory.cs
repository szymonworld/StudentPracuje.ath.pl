using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pracuj.ath.bielsko.pl.ViewModels.DropDownList
{

    public class JobCategory
    {
        public class DropDownListViewModel
        {
            /// <summary>
            /// Used when the dropdown list allows only one value to be selected
            /// </summary>
            public string SelectedValue { get; set; }

            public string[] SelectedValues { get; set; }

            public SelectList SelectListItems { get; set; }
        }

        public class DropDownItem
        {
            public string Value { get; set; }
            public string Text { get; set; }
            public string Group { get; set; }
        }

            public string Name { get; set; }
            public DropDownListViewModel Type { get; set; }
    }
}