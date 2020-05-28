using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using WpfTest01.Business.Model;

namespace WpfTest01.Business.Service
{
    public class SearchService
    {
        private DateTime _startDate = new DateTime(2000, 1, 1);

        public List<SearchResult> Search(string insuredName)
        {
            var results = new List<SearchResult>();

            var randomGenerator = new Random();
            var randomDateRange = (DateTime.Today - _startDate).Days;  

            //Generate some random results
            for (var i = 0; i < 100; i++)
            {
                var result = new SearchResult
                {
                    InsuredName = $"{insuredName.ToLower()}-{Path.GetRandomFileName().Replace(".", string.Empty)}", 
                    InceptionDate = _startDate.AddDays(randomGenerator.Next(randomDateRange)), 
                    IsBound = randomGenerator.Next(2) == 0,
                    QuotedPremium = Math.Round((decimal) randomGenerator.NextDouble() * 100000M)
                };

                results.Add(result);
            }

            //Sleep to mimic a slow service call
            Thread.Sleep(TimeSpan.FromSeconds(3));

            return results;
        }
    }
}