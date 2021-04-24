using NeoSoft.Day1.Session1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NeoSoft.Day1.Session1.Services
{
    public class LoanApplicationService : ILoanApplicationService
    {
        public void Create(LoanApplicationCreateViewModel viewModel)
        {
            //throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            //throw new NotImplementedException();
        }

        public IEnumerable<LoanApplicationViewModel> Get()
        {
            return new List<LoanApplicationViewModel>();
        }

        public LoanApplicationViewModel Get(int id)
        {
            return new LoanApplicationViewModel
            {
                Id = 1,
                ApplicantName = "Sunil",
                ApplicationDate = DateTime.Now,
                ProductId = "CAR004"
            };
        }

        public IEnumerable<LoanApplicationViewModel> GetByProductId(string productId)
        {
            return new List<LoanApplicationViewModel>();
        }

        public void Update(LoanApplicationUpdateViewModel viewModel)
        {
            //throw new NotImplementedException();
        }
    }
}
