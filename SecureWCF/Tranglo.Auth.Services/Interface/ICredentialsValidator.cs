using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tranglo.Auth.Model;

namespace Tranglo.Auth.Services.Interface
{
    public interface ICredentialsValidator
    {
        bool IsValid(User user);
    }
}
