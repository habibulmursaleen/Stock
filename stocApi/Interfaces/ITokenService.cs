using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using stocApi.Models;

namespace stocApi.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);

    }
}