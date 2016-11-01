using Requester.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RequesterRepro
{
    public class Tests
    {
        [Fact]
        public void ShouldTest()
        {
            When.Head("http://www.google.com").TheResponse(should => should.BeSuccessful());
        }        
    }
}
