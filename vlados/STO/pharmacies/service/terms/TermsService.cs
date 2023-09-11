using carservice.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carservice.service.terms
{

    interface TermsService
    {
        bool saveTerms(Term terms);

        List<Term> getAll();

        bool deleteTerms(int id);
    }
}
