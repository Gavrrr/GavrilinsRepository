using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using carservice.model;
using carservice.repository;

namespace carservice.service.terms
{
    class TermsServiceImpl : TermsService
    {
        TermsRepository termsRepository = new TermsRepository();

        public bool deleteTerms(int id)
        {
            try
            {
                termsRepository.delete(termsRepository.findTermsById(id));
                return true;
            } 
            catch 
            {
                return false;
            }
        }

        public List<Term> getAll()
        {
            return termsRepository.findAllTerms();
        }

        public bool saveTerms(Term terms)
        {
            termsRepository.save(terms);
            return true;
        }
    }
}
