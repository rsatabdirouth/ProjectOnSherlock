using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOnSherlock.Models.UtilityObjects.PPIEnum
{
    public enum LoanStatusEnum
    {
        FinishedPaidoff=1,
        UpToDateWithPayments,
        InArrears,
        InADebtManagementPlan,
        InIVAOrBankruptcy,
        DeclaredInsolvent
    }
}
