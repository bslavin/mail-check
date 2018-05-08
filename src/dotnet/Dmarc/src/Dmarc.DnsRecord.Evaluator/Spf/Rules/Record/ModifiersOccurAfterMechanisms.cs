using Dmarc.DnsRecord.Evaluator.Rules;
using Dmarc.DnsRecord.Evaluator.Spf.Domain;

namespace Dmarc.DnsRecord.Evaluator.Spf.Rules.Record
{
    public class ModifiersOccurAfterMechanisms : IRule<SpfRecord>
    {
        public bool IsErrored(SpfRecord record, out Evaluator.Rules.Error error)
        {
            int lastIndexOfMechanism = record.Terms.FindLastIndex(_ => _ is Mechanism);
            int firstIndexOfModifier = record.Terms.FindIndex(_ => _ is Modifier);

            if (firstIndexOfModifier == -1 || lastIndexOfMechanism <= firstIndexOfModifier)
            {
                error = null;
                return false;
            }
            error = new Evaluator.Rules.Error(Evaluator.Rules.ErrorType.Error, SpfRulesResource.ModifiersOccurAfterMechanismsErrorMessage);
            return true;
        }
    }
}