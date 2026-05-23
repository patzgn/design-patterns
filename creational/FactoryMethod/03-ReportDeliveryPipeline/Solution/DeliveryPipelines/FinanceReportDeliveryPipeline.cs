using ReportDeliveryPipeline.Solution.DeliveryChannels;

namespace ReportDeliveryPipeline.Solution.DeliveryPipelines;

public class FinanceReportDeliveryPipeline : ReportDeliveryPipeline
{
    protected override IReportDeliveryChannel CreateDeliveryChannel()
    {
        return new EmailReportDeliveryChannel("finance-reports@example.com", "Confidential");
    }
}
