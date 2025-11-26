namespace PrecisionToolingEF.Models
{
    public class Proposal
    {
        public int Id { get; set; }

        public string AltProposalId { get; set; }

        public int CustomerId { get; set; }

        public string? ProposalDescription { get; set; }

        public string? Notes { get; set; }

        public decimal ProposalAmount { get; set; }
    }
}
