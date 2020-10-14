using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomDYO.Api.DataAccess
{
    public class SpGetProductCategory
    {
        public int MainCtgyId { get; set; }
        public string MainCtgyName { get; set; }
        public string MainCtgyDcpn { get; set; }
        public int? MainCtgyCustId { get; set; }
        public string MainCtgyPath { get; set; }
        public int? MainCtgyParent { get; set; }

        public int _CtgyId { get; set; }
        public string _CtgyName { get; set; }
        public string _CtgyDcpn { get; set; }
        public int _CtgyCustId { get; set; }
        public string _CtgyPath { get; set; }
        public int _CtgyParent { get; set; }

        public int __CtgyId { get; set; }
        public string __CtgyName { get; set; }
        public string __CtgyDcpn { get; set; }
        public int __CtgyCustId { get; set; }
        public string __CtgyPath { get; set; }
        public int __CtgyParent { get; set; }

        public int ___CtgyId { get; set; }
        public string ___CtgyName { get; set; }
        public string ___CtgyDcpn { get; set; }
        public int ___CtgyCustId { get; set; }
        public string ___CtgyPath { get; set; }
        public int ___CtgyParent { get; set; }

    }

    public class MainCategory
    {
        public int MainCtgyId { get; set; }
        public string MainCtgyName { get; set; }
        public string MainCtgyDcpn { get; set; }
        public int MainCtgyCustId { get; set; }
        public string MainCtgyPath { get; set; }
        public int MainCtgyParent { get; set; }
        public List<_Category> _Category { get; set; }
    }

    public class _Category
    {
        public int _CtgyId { get; set; }
        public string _CtgyName { get; set; }
        public string _CtgyDcpn { get; set; }
        public int _CtgyCustId { get; set; }
        public string _CtgyPath { get; set; }
        public int _CtgyParent { get; set; }
        public List<__Category> __Category { get; set; }
    }

    public class __Category
    {
        public int __CtgyId { get; set; }
        public string __CtgyName { get; set; }
        public string __CtgyDcpn { get; set; }
        public int __CtgyCustId { get; set; }
        public string __CtgyPath { get; set; }
        public int __CtgyParent { get; set; }
        public List<___Category> ___Category { get; set; }
    }

    public class ___Category
    {

        public int ___CtgyId { get; set; }
        public string ___CtgyName { get; set; }
        public string ___CtgyDcpn { get; set; }
        public int ___CtgyCustId { get; set; }
        public string ___CtgyPath { get; set; }
        public int ___CtgyParent { get; set; }
    }

}
