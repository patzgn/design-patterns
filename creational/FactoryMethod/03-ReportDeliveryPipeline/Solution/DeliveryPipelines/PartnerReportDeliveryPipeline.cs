using ReportDeliveryPipeline.Solution.DeliveryChannels;

namespace ReportDeliveryPipeline.Solution.DeliveryPipelines;

public class PartnerReportDeliveryPipeline : ReportDeliveryPipeline
{
    protected override IReportDeliveryChannel CreateDeliveryChannel()
    {
        return new SecureFileTransferChannel("/partners/inbound/reports", 3);
    }
}
