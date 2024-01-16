using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOMSUMINHCHAU.Data.EF
{
    public class GOMSUMINHCHAU_DbContext : DbContext
    {
        public GOMSUMINHCHAU_DbContext(DbContextOptions options) : base(options) { }


    }
}
