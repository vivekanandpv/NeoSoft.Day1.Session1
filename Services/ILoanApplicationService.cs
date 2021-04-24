using NeoSoft.Day1.Session1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoSoft.Day1.Session1.Services
{
    public interface ILoanApplicationService
    {
        IEnumerable<LoanApplicationViewModel> Get();
        LoanApplicationViewModel Get(int id);
        IEnumerable<LoanApplicationViewModel> GetByProductId(string productId);
        void Create(LoanApplicationCreateViewModel viewModel);
        void Update(LoanApplicationUpdateViewModel viewModel);
        void Delete(int id);
    }
}
