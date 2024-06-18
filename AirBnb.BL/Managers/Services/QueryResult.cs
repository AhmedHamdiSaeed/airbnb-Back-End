using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBnb.BL.Managers.Services
{
    public record QueryResult(object Data, int TotalPages, int page, int pageSize, int total);

}
