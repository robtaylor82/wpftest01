using System;

namespace WpfTest01.Business.Model
{
    public class SearchResult
    {
        public string InsuredName { get; set; }
        public DateTime InceptionDate { get; set; }
        public bool IsBound { get; set; }
        public decimal QuotedPremium { get; set; }
    }
}