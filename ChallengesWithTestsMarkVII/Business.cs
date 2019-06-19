
using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMarkVII
{
    public class Business
    {
        public string Name { get; set; }
        public double TotalRevenue { get; set; }
        public double TotalExpenses { get; set; }
        public Business ParentCompany { get; set; }

        public static implicit operator Business(int v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator List<object>(Business v)
        {
            throw new NotImplementedException();
        }
    }
}
