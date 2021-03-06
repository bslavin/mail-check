using System.Linq;
using Dmarc.DnsRecord.Evaluator.Rules;
using Dmarc.DnsRecord.Evaluator.Spf.Domain;

namespace Dmarc.DnsRecord.Evaluator.Spf.Rules.Record
{
    public class ExplanationDoesntOccurMoreThanOnce : IRule<SpfRecord>
    {
        public bool IsErrored(SpfRecord record, out Evaluator.Rules.Error error)
        {
            int explanationCount = record.Terms.OfType<Explanation>().Count();
            if (explanationCount <= 1)
            {
                error = null;
                return false;
            }
            error = new Evaluator.Rules.Error(Evaluator.Rules.ErrorType.Error, 
                string.Format(SpfRulesResource.ExplanationDoesntOccurMoreThanOnceErrorMessage, explanationCount));

            return true;
        }
    }
}