using NeoSoft.Day1.Session1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoSoft.Day1.Session1.Repositories
{
    public interface ILoanApplicationRepository
    {
        IEnumerable<LoanApplication> Get();
        LoanApplication Get(int id);
        void Create(LoanApplication application);
        void Update(LoanApplication application);
        void Delete(int id);
    }
}
